Public Class ResultsFrm


	Private mFileName
	Public Property XmlFileName() As String
		Get
			Return mFileName
		End Get
		Set(ByVal value As String)
			mFileName = value
		End Set
	End Property


	Public Property Results() As String
		Get
			Return RetTxt.Text
		End Get
		Set(ByVal value As String)
			RetTxt.Text = value
		End Set
	End Property


	Public Property Query() As String
		Get
			Return QryTxt.Text
		End Get
		Set(ByVal value As String)
			QryTxt.Text = value
		End Set
	End Property


	Private ds As DataSet = Nothing
	Public Property SearchDataset() As DataSet
		Get
			Return ds
		End Get
		Set(ByVal value As DataSet)
			ds = value
            RetDg.DataSource = ds.Tables(0)
            If ds.Tables.Count > 1 Then
                RetDg2.DataSource = ds.Tables(1)
                If ds.Tables.Count > 2 Then
                    RetDg3.DataSource = ds.Tables(2)
                End If
            End If
        End Set
	End Property


    Private Sub ResultsFrm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'navigate to the xml results temp file
        WebCtrl.Navigate(XmlFileName)
        If Me.SearchDataset Is Nothing Then
            'move to the XML tab if there's no datagrid to show.
            Me.TabControl1.SelectTab("XMLResults")
        End If
    End Sub

    Private Sub btnSaveResults_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveResults.Click
        Dim fsd As New SaveFileDialog()
        fsd.DefaultExt = "xml"
        fsd.AddExtension = True
        fsd.Title = "Save Query Results to XML file"
        fsd.OverwritePrompt = True
        fsd.Filter = "xml|Query Results (xml)"
        fsd.ShowDialog(Me)
        If fsd.FileName.Length > 0 Then
            If Me.SearchDataset Is Nothing Then
                System.IO.File.WriteAllText(fsd.FileName, RetTxt.Text)
            Else
                Me.SearchDataset.WriteXml(fsd.FileName)
            End If
        End If
    End Sub

    Private Sub btnSaveQuery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveQuery.Click
        Dim fsd As New SaveFileDialog()
        fsd.DefaultExt = "QueryPacket"
        fsd.AddExtension = True
        fsd.Title = "Save Query to reuse later"
        fsd.OverwritePrompt = True
        fsd.Filter = "QueryPacket XML (*.QueryPacket)|*.QueryPacket|All files (*.*)|*.*"
        fsd.ShowDialog(Me)
        If fsd.FileName.Length > 0 Then
            System.IO.File.WriteAllText(fsd.FileName, QryTxt.Text)
        End If
    End Sub
End Class