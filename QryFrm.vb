Imports System.Xml
Imports System.Web
Imports System.IO
Imports System.Net
Imports System.Configuration


Public Class QryFrm

    Private sws As System.Web.Services.Protocols.SoapHttpClientProtocol = Nothing
    Private ds As DataSet = Nothing
    Private Hlp As New Web.HttpUtility
    Private CurQuery As Integer = 0
    Private wFrm As New PredFrm
    Private bServerChanged As Boolean = False
    Private serviceUrl As String
    Private webServiceName As String
    Private appTitle As String
    Private bMOSSSearch As Boolean


    Private Sub QryFrm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'make sure our web references are released
        sws = Nothing
        'save the user's most recent settings
        My.Settings.Save()
    End Sub


    Private Sub QryFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'reload the user's last saved settings
        My.Settings.Reload()
        ' hang on to the designer configured form title, because we're going to 
        ' append the url of the target service to it later.
        appTitle = Me.Text
    End Sub


    Private Function InitWS() As Boolean

        Dim Ret As Boolean = True

        Try
            'need to recreate this each time in case the user has changed servers
            If sws Is Nothing OrElse bServerChanged Then
                If bMOSSSearch Then
                    sws = New SearchWS.QueryService
                Else
                    sws = New SPSearchWS.QueryService
                End If
                sws.Url = IIf(serviceUrl.EndsWith("/"), serviceUrl, serviceUrl & "/") & webServiceName
                sws.Credentials = System.Net.CredentialCache.DefaultCredentials

                'set the server changed flag off
                bServerChanged = False
            End If
        Catch ex As Exception
            MessageBox.Show("Error initializing Query web service: " & ex.Message)
            Ret = False
        End Try

        Return Ret

    End Function

    Public Shared Function ServerCertificateValidationCallback(ByVal sender As Object, _
        ByVal cert As System.Security.Cryptography.X509Certificates.X509Certificate, _
        ByVal chain As System.Security.Cryptography.X509Certificates.X509Chain, _
        ByVal sslPolicyErrors As System.Net.Security.SslPolicyErrors) As Boolean
        'this call back funciton is installed if the user chooses to ignore all cert errors.
        Return True
    End Function

    Private Sub ConnectToService()

        Dim Ret As String = String.Empty
        Dim dt As DataColumn = Nothing

        Dim xDoc As New XmlDocument
        Dim xNS As XmlNamespaceManager = Nothing
        Dim xList As XmlNodeList = Nothing
        Dim xNode As XmlNode = Nothing

        Me.Cursor = Cursors.WaitCursor

        Try
            'init the web service
            If Not InitWS() Then Exit Sub

            'get the service status
            Try
                ' first try is with the windows identity
                If bMOSSSearch Then
                    Ret = CType(sws, SearchWS.QueryService).Status()
                Else
                    Ret = CType(sws, SPSearchWS.QueryService).Status()
                End If
                Me.Text = appTitle & " [" & sws.Url & "]" & Ret
            Catch UnAuthorized As System.Net.WebException
                If UnAuthorized.Message.Contains("401") Then
                    ' if we get unauthorized, try again after getting login info from the user.
                    Dim logonDlg As New LoginForm
                    Dim rslt As Windows.Forms.DialogResult
                    rslt = logonDlg.ShowDialog()
                    If rslt = Windows.Forms.DialogResult.OK Then
                        If logonDlg.Username.Length > 0 And logonDlg.Password.Length > 0 Then
                            sws.Credentials = New System.Net.NetworkCredential(logonDlg.Username, logonDlg.Password)
                            sws.PreAuthenticate = True
                        End If
                        If logonDlg.IgnoreCertErrors Then
                            ' per: http://msdn2.microsoft.com/en-us/library/system.net.servicepointmanager.servercertificatevalidationcallback(vs.80).aspx
                            ServicePointManager.ServerCertificateValidationCallback = AddressOf ServerCertificateValidationCallback
                        End If
                    End If
                    If bMOSSSearch Then
                        Ret = CType(sws, SearchWS.QueryService).Status()
                    Else
                        Ret = CType(sws, SPSearchWS.QueryService).Status()
                    End If
                    Me.Text = appTitle & " [" & sws.Url & "]" & Ret
                Else
                    'something else happened, let the user know...
                    Me.Text = appTitle
                    Throw UnAuthorized
                End If
            End Try

            ' can only load scopes and props for MOSS Search service
            If bMOSSSearch Then
                'get the scope info
                Ret = ""
                Ret = CType(sws, SearchWS.QueryService).GetPortalSearchInfo()
                If Ret <> "" Then
                    'clear out the old list of scopes
                    ScopeChk.Items.Clear()

                    'load the xml 
                    xDoc.LoadXml(Ret)

                    'create a namespace manager for querying
                    xNS = New XmlNamespaceManager(xDoc.NameTable)
                    xNS.AddNamespace("a", "urn:Microsoft.MSSearch.Response.Config")

                    'find the scopes
                    xList = xDoc.SelectNodes("/a:SiteConfigInfo/a:Scopes/a:Scope/a:Name", xNS)

                    'make sure we got some matches
                    If Not xList Is Nothing Then
                        For Each xNode In xList
                            'add each item to the scope list
                            ScopeChk.Items.Add(New ScopeItem(xNode.InnerText, xNode.InnerText))
                        Next
                    End If

                    'get the application ID
                    xNode = xDoc.SelectSingleNode("/a:SiteConfigInfo/a:Id", xNS)

                    'grab the results - add Search Applicaiton ID to window title.
                    If xNode IsNot Nothing Then Me.Text = Me.Text & " SSP ID:" & xNode.InnerText

                End If

                'get the list of search properties
                ds = CType(sws, SearchWS.QueryService).GetSearchMetadata()
                If ds IsNot Nothing AndAlso ds.Tables.Count > 0 Then
                    'add the columns for criteria
                    dt = New DataColumn("Criteria", GetType(System.String))
                    ds.Tables(0).Columns.Add(dt)

                    dt = New DataColumn("IncludeInResults", GetType(System.Boolean))
                    ds.Tables(0).Columns.Add(dt)

                    dt = New DataColumn("SortBy", GetType(System.String))
                    ds.Tables(0).Columns.Add(dt)

                    'bind
                    propdg.DataSource = ds.Tables(0)
                    ' The below autogenerated column is removed so 
                    ' a DataGridViewComboboxColumn could be used instead.
                    propdg.Columns.Remove("SortBy")
                    Dim comboboxColumn As DataGridViewComboBoxColumn
                    comboboxColumn = New DataGridViewComboBoxColumn()
                    With comboboxColumn
                        .Name = "SortBy"
                        .DataPropertyName = .Name
                        .HeaderText = .Name
                        .ValueMember = .Name
                        .DisplayMember = .ValueMember
                        .Items.Add("")
                        .Items.Add("Asc")
                        .Items.Add("Desc")
                        .SortMode = DataGridViewColumnSortMode.Automatic
                        .Width = 110
                        .MaxDropDownItems = 3
                        .FlatStyle = FlatStyle.Flat
                    End With
                    ' Tack this example column onto the end.
                    propdg.Columns.Add(comboboxColumn)

                    For Each col As DataGridViewColumn In propdg.Columns
                        If col.Index > 2 Then
                            col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                        End If
                    Next

                    ' http://msdn2.microsoft.com/en-us/library/ms497227.aspx
                    'configure sorting for boolean columns
                    propdg.Columns("Retrievable").SortMode = DataGridViewColumnSortMode.Automatic
                    propdg.Columns("FullTextQueriable").SortMode = DataGridViewColumnSortMode.Automatic
                    propdg.Columns("IncludeInResults").SortMode = DataGridViewColumnSortMode.Automatic

                Else
                    MessageBox.Show("No properties were found")
                End If
            Else
                ' may want to drop a default query out into the UI at this point

            End If

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            Me.Cursor = Cursors.Default
        End Try

    End Sub


    Private Sub QueryBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QueryBtn.Click
        RunQuery(False)
    End Sub

    Private Sub QueryExBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QueryExBtn.Click
        RunQuery(True)
    End Sub

    Private Sub RunQuery(ByVal exMethod As Boolean)
        Dim Ret As String = String.Empty
        Dim ds As DataSet = Nothing
        Dim Query As String = String.Empty

        Dim RetFrm As New ResultsFrm

        'make sure we have a query to run
        If QueryPacket.Text = "" Then
            MessageBox.Show("You must load, generate or enter a query into the QueryPacket field first.")
            QueryPacket.Focus()
            Exit Sub
        End If

        Me.Cursor = Cursors.WaitCursor

        'init the web service
        If Not InitWS() Then Exit Sub

        Query = QueryPacket.Text

        Try
            'run the query
            Try
                ' first try is with the windows identity
                'execute the query
                If exMethod Then
                    ' WSS and MOSS QueryEx methods use a different SOAPAction, so need to be 
                    ' specific here...
                    If bMOSSSearch Then
                        ds = CType(sws, SearchWS.QueryService).QueryEx(Query)
                    Else
                        ds = CType(sws, SPSearchWS.QueryService).QueryEx(Query)
                    End If
                Else
                    If bMOSSSearch Then
                        Ret = CType(sws, SearchWS.QueryService).Query(Query)
                    Else
                        Ret = CType(sws, SPSearchWS.QueryService).Query(Query)
                    End If
                End If

            Catch UnAuthorized As System.Net.WebException
                If UnAuthorized.Message.Contains("401") Then
                    ' if we get unauthorized, try again after getting login info from the user.
                    Dim logonDlg As New LoginForm
                    Dim rslt As Windows.Forms.DialogResult
                    rslt = logonDlg.ShowDialog()
                    If rslt = Windows.Forms.DialogResult.OK Then
                        If logonDlg.Username.Length > 0 And logonDlg.Password.Length > 0 Then
                            sws.Credentials = New System.Net.NetworkCredential(logonDlg.Username, logonDlg.Password)
                            sws.PreAuthenticate = True
                        End If
                        If logonDlg.IgnoreCertErrors Then
                            ' per: http://msdn2.microsoft.com/en-us/library/system.net.servicepointmanager.servercertificatevalidationcallback(vs.80).aspx
                            ServicePointManager.ServerCertificateValidationCallback = AddressOf ServerCertificateValidationCallback
                        End If
                    End If
                    'execute the query again
                    If exMethod Then
                        ' WSS and MOSS QueryEx methods use a different SOAPAction, so need to be 
                        ' specific here...
                        If bMOSSSearch Then
                            ds = CType(sws, SearchWS.QueryService).QueryEx(Query)
                        Else
                            ds = CType(sws, SPSearchWS.QueryService).QueryEx(Query)
                        End If
                    Else
                        If bMOSSSearch Then
                            Ret = CType(sws, SearchWS.QueryService).Query(Query)
                        Else
                            Ret = CType(sws, SPSearchWS.QueryService).Query(Query)
                        End If
                    End If
                Else
                    'something else happened, let the user know...
                    Throw UnAuthorized
                End If
            End Try
            'load the dataset into a grid
            If Not ds Is Nothing Then
                RetFrm.SearchDataset = ds
                ' load the dataset into web browser
                LoadIntoBrowser(ds.GetXml, RetFrm)
                'RetFrm.Results = RetFrm.Results + ds.GetXmlSchema
            Else
                LoadIntoBrowser(Ret, RetFrm)
            End If

        Catch ex As Exception
            MessageBox.Show("Error running query: " & ex.Message)
        Finally
            Me.Cursor = Cursors.Default
        End Try

        RetFrm.Query = Query
        CurQuery += 1
        RetFrm.Text = "Query Results #" & CurQuery.ToString() & IIf(QueryTxt.Text <> "", " (" & QueryTxt.Text & ")", "")
        RetFrm.Show()
    End Sub

    Private Sub LoadIntoBrowser(ByVal rawXML As String, ByVal retFrm As ResultsFrm)
        'vars to write out results to temp xml file
        Dim tempFile As String = String.Empty
        Dim fs As FileStream = Nothing
        Dim data() As Byte

        'save as temp file so we can load in web browser
        'get a temp file name
        tempFile = Path.ChangeExtension(Path.GetTempFileName(), "xml")

        'open the file for writing
        fs = File.Open(tempFile, FileMode.Create)

        'convert our data to a byte array
        data = System.Text.UTF8Encoding.UTF8.GetBytes(rawXML)

        'write out the data
        fs.Write(data, 0, data.Length)

        'close the file
        fs.Close()

        'set up the result form for xml results
        retFrm.Results = rawXML
        retFrm.XmlFileName = tempFile
    End Sub

    Private Function MakeQueryPacket(ByVal KeywordQueryType As Boolean, ByVal KeywordsOrSql As String, ByVal AdditionalProperties As String) As String

        Dim Qry As New System.Text.StringBuilder(1024)

        Qry.AppendLine("<?xml version=""1.0"" encoding=""utf-8"" ?>")
        Qry.AppendLine("<QueryPacket xmlns=""urn:Microsoft.Search.Query"" Revision=""1000"">")
        Qry.AppendLine("<Query domain=""QDomain"">")
        Qry.AppendLine(" <SupportedFormats><Format>urn:Microsoft.Search.Response.Document.Document</Format></SupportedFormats>")
        Qry.AppendLine(" <Context>")
        If KeywordQueryType Then
            Qry.Append("  <QueryText language=""" & tbLocale.Text.Trim(" ") & """ type=""STRING"" >")
            Qry.Append(KeywordsOrSql)
            Qry.AppendLine("</QueryText>")

        Else
            Qry.Append("   <QueryText language=""" & tbLocale.Text.Trim(" ") & """ type=""MSSQLFT"">")
            Qry.Append("<![CDATA[ ")
            Qry.Append(KeywordsOrSql)
            Qry.AppendLine(" ]]></QueryText>")
        End If
        Qry.AppendLine(" </Context>")
        If KeywordQueryType AndAlso AdditionalProperties.Length > 0 Then
            Qry.Append(AdditionalProperties)
        End If
        If KeywordQueryType Then
            Qry.Append(GetKeywordSortBy())
        End If
        Qry.AppendLine(" <Range><StartAt>" & StartNum.Value.ToString() & "</StartAt><Count>" & NumRec.Value.ToString() & "</Count></Range>")
        Qry.AppendLine(" <EnableStemming>" & IIf(cbEnableStemming.Checked, "true", "false") & "</EnableStemming>")
        Qry.AppendLine(" <TrimDuplicates>" & IIf(cbTrimDuplicates.Checked, "true", "false") & "</TrimDuplicates>")
        Qry.AppendLine(" <IgnoreAllNoiseQuery>" & IIf(cbIgnoreAllNoiseQuery.Checked, "true", "false") & "</IgnoreAllNoiseQuery>")
        Qry.AppendLine(" <ImplicitAndBehavior>" & IIf(cbImplicitAndBehavior.Checked, "true", "false") & "</ImplicitAndBehavior>")
        If (cbIncludeRelevanceResults.Visible) Then
            Qry.AppendLine(" <IncludeRelevanceResults>" & IIf(cbIncludeRelevanceResults.Checked, "true", "false") & "</IncludeRelevanceResults>")
        End If
        If (cbIncludeSpecialTermResults.Visible) Then
            Qry.AppendLine(" <IncludeSpecialTermResults>" & IIf(cbIncludeSpecialTermResults.Checked, "true", "false") & "</IncludeSpecialTermResults>")
        End If
        If (cbIncludeHighConfidenceResults.Visible) Then
            Qry.AppendLine(" <IncludeHighConfidenceResults>" & IIf(cbIncludeHighConfidenceResults.Checked, "true", "false") & "</IncludeHighConfidenceResults>")
        End If

        Qry.AppendLine("</Query></QueryPacket>")
        Return Qry.ToString()

    End Function


    Private Sub MakeSqlBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MakeSqlBtn.Click
        ' prepare property criteria
        Dim BaseFields As New Hashtable
        Dim Fields As New Hashtable
        Dim Criteria As New Hashtable
        Dim Criterion As SearchCriterion = Nothing
        For Each dg As DataGridViewRow In propdg.Rows
            'check the required fields if they aren't
            If BaseFields.ContainsKey(dg.Cells(0).Value) Then dg.Cells("IncludeInResults").Value = True

            'otherwise see if the field is checked
            If dg.Cells("IncludeInResults").Value IsNot DBNull.Value AndAlso dg.Cells("IncludeInResults").Value Then
                Try
                    'if it isn't one of our base fields that we've already captured, then add it
                    If Not BaseFields.ContainsKey(dg.Cells(0).Value) Then Fields.Add(dg.Cells(0).Value, 1)
                Catch ex As Exception
                    'only put it in a TRY in case they checked one or more of the required query fields
                End Try
            End If

            'look to see if there is any criteria here
            If dg.Cells("Criteria").Value IsNot DBNull.Value AndAlso dg.Cells("Criteria").Value <> "" Then
                'only add it if it isn't a system.byte data type
                If dg.Cells("Type").Value = "System.Byte[]" Then
                    MessageBox.Show("We cannot create criteria for a field with a Byte() data type (" & dg.Cells(0).Value & ")")
                    dg.Cells("Criteria").Value = ""
                Else
                    Criteria.Add(dg.Cells(0).Value, New SearchCriterion(dg.Cells("Type").Value, dg.Cells("Criteria").Value))
                End If
            End If

            '*****************************************************************************
            'IT SEEMS IN THIS WSSv3/MOSS YOU CAN ACTUALLY DO A QUERY WITHOUT THE WHERE CLAUSE
            'SO WE WON'T REQUIRE CRITERIA
            '*****************************************************************************
        Next

        If rbSQLSyntax.Checked Then
            'oohhh, fun, make the SQL!
            Dim Temp As String = String.Empty
            Dim Where As New System.Text.StringBuilder(1024)
            Dim DateCriteria As String = String.Empty
            Dim Sql As New System.Text.StringBuilder(2048)
            Dim OneKey As String = String.Empty
            Dim si As ScopeItem = Nothing
            Dim HaveCriteria As Boolean = False
            Dim Joiner As String = "AND "

            Me.Cursor = Cursors.WaitCursor

            Try
                'make sure we've gotten some properties first
                If propdg.Rows.Count = 0 And bMOSSSearch Then
                    MessageBox.Show("You must retrieve the properties first.  Please use File > Connect to SharePoint Search Service... menu.")
                    Exit Sub
                End If

                'add the required fields
                'Title, Path, Description, Write, Rank, Size,
                BaseFields.Add("Title", 0)
                BaseFields.Add("Path", 0)
                BaseFields.Add("Description", 0)
                BaseFields.Add("Write", 0)
                BaseFields.Add("Rank", 0)
                BaseFields.Add("Size", 0)

                'figure out if the WHERE clause should use " OR " instead of " AND "
                If OrChk.Checked Then Joiner = "OR "

                'create the SELECT 
                Sql.Append("SELECT ")
                For Each OneKey In BaseFields.Keys
                    Sql.Append(OneKey & ", ")
                Next
                For Each OneKey In Fields.Keys
                    Sql.Append(OneKey & ", ")
                Next

                'trim off the trailing comma and space
                Sql.Remove(Sql.Length - 2, 2)

                'add the FROM
                Sql.Append(" FROM portal..scope() ")

                'create the WHERE clause if needed
                If QueryTxt.Text <> "" OrElse Criteria.Count > 0 OrElse ScopeChk.SelectedItems.Count > 0 Then

                    Where.Append("WHERE ")

                    'look for keyword search
                    If QueryTxt.Text <> "" Then
                        If ContainsOpt.Checked Then
                            Where.Append("CONTAINS ('""" & QueryTxt.Text & IIf(WildChk.Checked, "*", "") & """') ")
                        Else
                            'Where.Append("WITH (""DAV:contentclass"":0,*:1.0, ")
                            'Where.Append("WITH (""DAV:contentclass"":0, ")
                            'Where.Append("""urn:schemas.microsoft.com:fulltextqueryinfo:description"":0,")
                            'Where.Append("""urn:schemas-microsoft-com:office:office#Keywords"":1.0,")
                            'Where.Append("""urn:schemas-microsoft-com:office:office#Title"":0.9,")
                            'Where.Append("""DAV:displayname"":0.9,")
                            'Where.Append("""urn:schemas-microsoft-com:publishing:Category"":0.8,")
                            'Where.Append("""urn:schemas-microsoft-com:office:office#Subject"":0.8,")
                            'Where.Append("""urn:schemas-microsoft-com:office:office#Author"":0.7,")
                            'Where.Append("""urn:schemas-microsoft-com:office:office#Description"":0.5,")
                            'Where.Append("""urn:schemas-microsoft-com:sharepoint:portal:profile:PreferredName"":0.2,")
                            'Where.Append("contents:0.1,*:0.05) AS #WeightedProps ")

                            'Where.Append("FREETEXT(#WeightedProps, '")
                            Where.Append("FREETEXT(DefaultProperties, '")

                            'ENCODE SearchTerms and append; SINGLE QUOTES, FOR EXAMPLE, WILL CAUSE AN ERROR
                            Where.Append(EncodeCriteria(QueryTxt.Text) & "') ")
                            'Where.Append(EncodeCriteria(KeyTxt.Text) & "') OR FREETEXT(*,'")
                            'Where.Append(EncodeCriteria(KeyTxt.Text) & "') ")
                        End If

                        'set criteria flag
                        HaveCriteria = True
                    End If

                    'if we have property criteria or scopes plug in an AND
                    If Criteria.Count > 0 AndAlso _
                     Not ((Where.ToString.EndsWith("AND ")) OrElse (Where.ToString.EndsWith("OR "))) AndAlso HaveCriteria Then _
                     Where.Append(Joiner)


                    'enumerate property clauses
                    For Each OneKey In Criteria.Keys
                        'set criteria flag
                        HaveCriteria = True

                        'get the current criterion
                        Criterion = CType(Criteria(OneKey), SearchCriterion)

                        'figure out what data type we have so we know what to plug into the WHERE clause
                        Select Case Criterion.DataType
                            Case "System.DateTime"
                                '"foo" >= 'yyyy-m-d 0:0:0'
                                'for dates we'll search for values greater than or equal to the date entered
                                Where.Append(ControlChars.Quote & OneKey & ControlChars.Quote & " >= '")

                                'need to format date as YYYY-M-D 0:0:0
                                'putting in a try block in case the person has input an invalid value
                                Try
                                    DateCriteria = CDate(Criterion.Value).ToString("yyyy-M-d") & " 0:0:0"
                                Catch DateEx As Exception
                                    'reset criteria to empty string
                                    DateCriteria = ""
                                End Try

                                Where.Append(DateCriteria & "' " & Joiner)

                            Case "System.String"
                                'CONTAINS("foo",'"my value"')
                                'all other cases treat as a string
                                Where.Append(IIf(ContainsOpt.Checked, "CONTAINS", "FREETEXT") & " (" & ControlChars.Quote & OneKey & ControlChars.Quote & ",'")
                                Where.Append(ControlChars.Quote & Criterion.Value & IIf(WildChk.Checked, "*", "") & ControlChars.Quote & "') " & _
                                 Joiner)
                            Case Else
                                '"foo"=1
                                Where.Append(ControlChars.Quote & OneKey & ControlChars.Quote & " = ")
                                Where.Append(Criterion.Value & " " & Joiner)
                        End Select
                    Next

                    'look for search scopes
                    If ScopeChk.CheckedItems.Count > 0 Then
                        'add a AND if necessary
                        If ScopeChk.CheckedItems.Count > 0 AndAlso Not ((Where.ToString.EndsWith("AND ")) OrElse _
                         (Where.ToString.EndsWith("OR "))) AndAlso HaveCriteria Then Where.Append(Joiner)

                        'open the scopes clauses
                        Where.Append(" ( ")

                        For Each si In ScopeChk.CheckedItems
                            Where.Append("(""SCOPE"" = '" & si.Value & "') OR ")
                        Next

                        'trim the trailing " OR "
                        Where.Remove(Where.Length - 4, 4)

                        'close out the scopes clauses
                        Where.Append(" ) ")
                    End If

                    'trim off the trailing AND and space if there was property criteria
                    If Where.ToString.EndsWith(Joiner) Then Where.Remove(Where.Length - Joiner.Length, Joiner.Length)
                End If

                'create the Xml for the query
                'write out the results
                '6/26/2008 - I don't know why, but to get a SQL query to work with WSS search, must
                ' tack a " --" onto the end of the query text.  
                QueryPacket.Text = MakeQueryPacket(False, Sql.ToString & Where.ToString & " " & BuildOrderBy() & IIf(bMOSSSearch, "", " --"), "")

            Catch ex As Exception
                MessageBox.Show("An error occurred creating the Sql: " & ex.Message)
            Finally
                Me.Cursor = Cursors.Default
            End Try
        Else
            'oohhh, fun, make the Keyword query!

            'create the Xml for the query
            'write out the results
            QueryPacket.Text = MakeQueryPacket(True, MakeKeywordQuery(Criteria), GetKeywordProperties(Fields))

        End If
    End Sub
    Private Function BuildOrderBy() As String
        Dim SortByProps As New Hashtable
        For Each dg As DataGridViewRow In propdg.Rows
            If dg.Cells(propdg.Columns("SortBy").Index).Value.ToString.Length > 0 Then
                SortByProps.Add(dg.Cells(0).Value, dg.Cells(propdg.Columns("SortBy").Index).Value)
            End If
        Next
        If SortByProps.Count > 0 Then
            Dim orderByClause As New System.Text.StringBuilder
            orderByClause.Append(" ORDER BY ")
            For Each key As String In SortByProps.Keys
                orderByClause.Append("""" & key & """ " & SortByProps(key) & ",")
            Next
            'remove the trailing comma
            orderByClause.Remove(orderByClause.Length - 1, 1)
            Return orderByClause.ToString()
        Else
            'use the default...
            Return " ORDER BY ""Rank"" DESC"
        End If
    End Function
    Private Function GetKeywordSortBy() As String
        Dim SortByProps As New Hashtable
        For Each dg As DataGridViewRow In propdg.Rows
            If dg.Cells(propdg.Columns("SortBy").Index).Value.ToString.Length > 0 Then
                SortByProps.Add(dg.Cells(0).Value, dg.Cells(propdg.Columns("SortBy").Index).Value)
            End If
        Next
        If SortByProps.Count = 0 Then
            ' if the user didn't specify anything, we put in Rank DESC as the default
            SortByProps.Add("Rank", "Desc")
        End If
        If SortByProps.Count > 0 Then
            Dim orderByClause As New System.Text.StringBuilder
            Dim counter As Integer = 1
            orderByClause.Append("<SortByProperties>")
            For Each key As String In SortByProps.Keys
                orderByClause.Append("<SortByProperty name=""" & key & _
                                                    """ direction=" & IIf(SortByProps(key) = "Asc", """Ascending""", """Descending""") & _
                                                    " order=""" & counter.ToString() & """/>")
                counter += 1
            Next
            orderByClause.Append("</SortByProperties>" & vbCrLf)
            Return orderByClause.ToString()
        End If
        Return ""
    End Function
    Private Function MakeKeywordQuery(ByVal Criteria As Hashtable) As String
        Dim retString As New System.Text.StringBuilder
        ' get the free text part
        retString.Append(QueryTxt.Text)
        ' tack on the property filters
        Dim OneKey As String = String.Empty
        Dim Criterion As SearchCriterion = Nothing
        For Each OneKey In Criteria.Keys

            'get the current criterion
            Criterion = CType(Criteria(OneKey), SearchCriterion)

            'figure out what data type we have so we know what to plug into the WHERE clause
            Select Case Criterion.DataType
                Case "System.DateTime"
                    'need to format date as YYYY-M-D 0:0:0
                    'putting in a try block in case the person has input an invalid value
                    Try
                        'It sure would be niced to do something like " foo:>='yyyy-m-d 0:0:0' "
                        'But, alas, in WSSv3/MOSS date properties only support equality test
                        retString.Append(" " & OneKey & ":")
                        Dim DateCriteria As String
                        If Criterion.Value.Length > 10 Then
                            'assume they entered a value with time component, so use it as-is
                            DateCriteria = Criterion.Value
                        Else
                            DateCriteria = CDate(Criterion.Value).ToString("yyyy-M-d") & " 0:0:0"
                        End If
                        retString.Append("'" & DateCriteria & "'")

                    Catch DateEx As Exception
                        'reset criteria to empty string
                        'we(can) 't format the date, so just skip this thing
                        MessageBox.Show("There's a problem with the date format provided for " & OneKey & " so it is being skipped.")
                    End Try

                Case "System.String"
                    ' foo:"my value" 
                    retString.Append(" " & OneKey & ":""" & EncodeCriteria(Criterion.Value) & """")

                Case Else
                    ' foo:1
                    retString.Append(" " & OneKey & ":" & Criterion.Value)

            End Select
        Next


        retString.Append(" ")
        ' tack on the scopes
        If ScopeChk.CheckedItems.Count > 0 Then
            Dim si As ScopeItem = Nothing
            For Each si In ScopeChk.CheckedItems
                ' Surround scope names with quotes in case they have embedded spaces
                retString.Append(" SCOPE:""" & EncodeCriteria(si.Value) & """")
            Next
        End If
        Return retString.ToString
    End Function

    Private Function GetKeywordProperties(ByVal Fields As Hashtable) As String
        Dim retString As New System.Text.StringBuilder
        If Fields.Count > 0 Then
            retString.Append("<Properties>")
            Dim OneKey As String = String.Empty
            For Each OneKey In Fields.Keys
                retString.Append("<Property name=""" & OneKey & """ />")
            Next
            ' When the Properties Element is not present in the query packet, a keyword query will return all of the following properties
            '<WorkId><Rank><Title><Author><Size><Path><Description><Write><SiteName><CollapsingStatus>
            '<HitHighlightedSummary><HitHighlightedProperties>
            '<ContentClass><IsDocument>
            ' When the Properties Element IS present, only the properties you ask for are returned.
            ' we'll help out the user and toss a few of them back in...
            retString.Append("<Property name=""Rank"" />")
            retString.Append("<Property name=""Title"" />")
            retString.Append("<Property name=""Author"" />")
            retString.Append("<Property name=""Size"" />")
            retString.Append("<Property name=""Path"" />")
            retString.Append("<Property name=""Description"" />")
            retString.Append("<Property name=""Write"" />")
            retString.Append("<Property name=""HitHighlightedSummary"" />")
            retString.Append("<Property name=""HitHighlightedProperties"" />")

            retString.Append("</Properties>")
        End If
        Return retString.ToString
    End Function

    Private Function EncodeCriteria(ByVal Value As String) As String

        Dim Ret As String

        'encode it
        Ret = HttpUtility.HtmlEncode(Value)

        'doesn't get single quotes
        Ret = Ret.Replace("'", "%27")

        Return Ret

    End Function



    Private Class ScopeItem
        Public Text As String
        Public Value As String

        Public Sub New(ByVal Text As String, ByVal Value As String)
            Me.Text = Text
            Me.Value = Value
        End Sub

        Public Overrides Function ToString() As String
            Return Me.Text
        End Function
    End Class



    Private Class SearchCriterion
        Public DataType As String
        Public Value As String

        Public Sub New(ByVal DataType As String, ByVal Value As String)
            Me.DataType = DataType
            Me.Value = Value
        End Sub

        Public Overrides Function ToString() As String
            Return Me.Value
        End Function

    End Class


    Private Sub WhereMnu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WhereMnu.Click
        If wFrm Is Nothing Then wFrm = New PredFrm
        wFrm.Show()
        wFrm.Activate()
    End Sub


    Private Sub ParseMnu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ParseMnu.Click
        Dim pFrm As New ParseFrm
        pFrm.ShowDialog()
        pFrm = Nothing
    End Sub

    Private Sub UrlTxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'set flag so we know we need to create a new connection to the web service
        bServerChanged = True
    End Sub

    Private Sub FreetxtOpt_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If FreetxtOpt.Checked Then
            If WildChk.Checked Then
                WildChk.Checked = False
                StatusLbl.Text = "If you use FREETEXT then you can't use Wildcard searching."
            End If
        End If

    End Sub

    Private Sub WildChk_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If WildChk.Checked Then
            If FreetxtOpt.Checked Then
                ContainsOpt.Checked = True
                StatusLbl.Text = "If you do a Wildcard search then you can't use FREETEXT."
            End If
        End If
    End Sub


    Private Sub OpenQueryPacketFileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenQueryPacketFileToolStripMenuItem.Click
        Dim fod As New OpenFileDialog()
        fod.DefaultExt = "QueryPacket"
        fod.AddExtension = True
        fod.Title = "Open a QueryPacket XML file"
        fod.Filter = "QueryPacket XML (*.QueryPacket)|*.QueryPacket|All files (*.*)|*.*"
        fod.ShowDialog(Me)
        If Not fod.FileName.Length <= 0 Then
            Me.QueryPacket.Text = System.IO.File.ReadAllText(fod.FileName)
        End If
    End Sub

    Private Sub AboutSharePointSearchServiceToolToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutSharePointSearchServiceToolToolStripMenuItem.Click
        Dim abtBox As New AboutBox
        abtBox.ShowDialog()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ConnectToServiceMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConnectToServiceMenuItem.Click
        Dim cnctDialog As New ConnectDialog
        If cnctDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            bServerChanged = True
            If cnctDialog.rbWSS.Checked Then
                cbIncludeHighConfidenceResults.Hide()
                cbIncludeRelevanceResults.Hide()
                cbIncludeSpecialTermResults.Hide()
            End If
            If cnctDialog.rbMOSS.Checked Then
                cbIncludeHighConfidenceResults.Show()
                cbIncludeRelevanceResults.Show()
                cbIncludeSpecialTermResults.Show()
            End If

            serviceUrl = cnctDialog.UrlTxt.Text
            webServiceName = cnctDialog.lblWebService.Text
            bMOSSSearch = webServiceName.Contains("/search.asmx")
            ConnectToService()
        End If
    End Sub

    Private Sub QryFrm_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        ' we know the first thing the user needs to do is connect, so go there now
        ConnectToServiceMenuItem_Click(Nothing, Nothing)
    End Sub

    Private Sub SQLSyntaxHelpMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SQLSyntaxHelpMenuItem.Click
        Try
            System.Diagnostics.Process.Start("IExplore", "http://msdn.microsoft.com/en-us/library/ms493660.aspx")
        Catch
            MessageBox.Show("The system could not launch the url http://msdn.microsoft.com/en-us/library/ms493660.aspx using Internet Explorer.", _
            "An error has occurred", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub KeywordSyntaxHelpMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KeywordSyntaxHelpMenuItem.Click
        Try
            System.Diagnostics.Process.Start("IExplore", "http://msdn.microsoft.com/en-us/library/ms497636.aspx")
        Catch
            MessageBox.Show("The system could not launch the url http://msdn.microsoft.com/en-us/library/ms497636.aspx using Internet Explorer.", _
            "An error has occurred", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub SearchSchemaHelpMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchSchemaHelpMenuItem.Click
        Try
            System.Diagnostics.Process.Start("IExplore", "http://msdn.microsoft.com/en-us/library/ms544835.aspx")
        Catch
            MessageBox.Show("The system could not launch the url http://msdn.microsoft.com/en-us/library/ms544835.aspx using Internet Explorer.", _
            "An error has occurred", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub WSS30SQLSyntaxHelpMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WSS30SQLSyntaxHelpMenuItem.Click
        Try
            System.Diagnostics.Process.Start("IExplore", "http://msdn.microsoft.com/en-us/library/ms443580.aspx")
        Catch
            MessageBox.Show("The system could not launch the url http://msdn.microsoft.com/en-us/library/ms443580.aspx using Internet Explorer.", _
            "An error has occurred", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub WSS30KeywordSyntaxHelpMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WSS30KeywordSyntaxHelpMenuItem.Click
        Try
            System.Diagnostics.Process.Start("IExplore", "http://msdn.microsoft.com/en-us/library/ms467796.aspx")
        Catch
            MessageBox.Show("The system could not launch the url http://msdn.microsoft.com/en-us/library/ms467796.aspx using Internet Explorer.", _
            "An error has occurred", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub WSS30SearchSchemaHelpMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WSS30SearchSchemaHelpMenuItem.Click
        Try
            System.Diagnostics.Process.Start("IExplore", "http://msdn.microsoft.com/en-us/library/ms413625.aspx")
        Catch
            MessageBox.Show("The system could not launch the url http://msdn.microsoft.com/en-us/library/ms413625.aspx using Internet Explorer.", _
            "An error has occurred", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub rbSQLSyntax_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbSQLSyntax.CheckedChanged
        If rbSQLSyntax.Checked Then
            pnlSQLOptions.Enabled = True
        Else
            pnlSQLOptions.Enabled = False
        End If
    End Sub
End Class
