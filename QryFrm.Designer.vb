<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QryFrm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(QryFrm))
        Me.propdg = New System.Windows.Forms.DataGridView
        Me.ScopeChk = New System.Windows.Forms.CheckedListBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.MakeSqlBtn = New System.Windows.Forms.Button
        Me.QueryBtn = New System.Windows.Forms.Button
        Me.QueryPacket = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.QueryTxt = New System.Windows.Forms.TextBox
        Me.NumRec = New System.Windows.Forms.NumericUpDown
        Me.StartNum = New System.Windows.Forms.NumericUpDown
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ConnectToServiceMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OpenQueryPacketFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ParseMnu = New System.Windows.Forms.ToolStripMenuItem
        Me.WhereMnu = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SQLSyntaxHelpMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.KeywordSyntaxHelpMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SearchSchemaHelpMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AboutSharePointSearchServiceToolToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.StatusLbl = New System.Windows.Forms.ToolStripStatusLabel
        Me.tbLocale = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.pnlSQLOptions = New System.Windows.Forms.Panel
        Me.OrChk = New System.Windows.Forms.CheckBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.FreetxtOpt = New System.Windows.Forms.RadioButton
        Me.ContainsOpt = New System.Windows.Forms.RadioButton
        Me.WildChk = New System.Windows.Forms.CheckBox
        Me.rbKeywordSyntax = New System.Windows.Forms.RadioButton
        Me.rbSQLSyntax = New System.Windows.Forms.RadioButton
        Me.cbIncludeHighConfidenceResults = New System.Windows.Forms.CheckBox
        Me.cbIncludeSpecialTermResults = New System.Windows.Forms.CheckBox
        Me.cbIncludeRelevanceResults = New System.Windows.Forms.CheckBox
        Me.cbImplicitAndBehavior = New System.Windows.Forms.CheckBox
        Me.cbIgnoreAllNoiseQuery = New System.Windows.Forms.CheckBox
        Me.cbTrimDuplicates = New System.Windows.Forms.CheckBox
        Me.cbEnableStemming = New System.Windows.Forms.CheckBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.GroupBox7 = New System.Windows.Forms.GroupBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.QueryExBtn = New System.Windows.Forms.Button
        CType(Me.propdg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumRec, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StartNum, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.pnlSQLOptions.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.SuspendLayout()
        '
        'propdg
        '
        Me.propdg.AllowUserToAddRows = False
        Me.propdg.AllowUserToDeleteRows = False
        Me.propdg.AllowUserToOrderColumns = True
        Me.propdg.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.propdg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.propdg.Location = New System.Drawing.Point(184, 28)
        Me.propdg.Margin = New System.Windows.Forms.Padding(2)
        Me.propdg.Name = "propdg"
        Me.propdg.RowHeadersWidth = 25
        Me.propdg.Size = New System.Drawing.Size(776, 248)
        Me.propdg.TabIndex = 6
        '
        'ScopeChk
        '
        Me.ScopeChk.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ScopeChk.CheckOnClick = True
        Me.ScopeChk.FormattingEnabled = True
        Me.ScopeChk.HorizontalScrollbar = True
        Me.ScopeChk.Location = New System.Drawing.Point(9, 62)
        Me.ScopeChk.Name = "ScopeChk"
        Me.ScopeChk.Size = New System.Drawing.Size(169, 214)
        Me.ScopeChk.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Scopes:"
        '
        'MakeSqlBtn
        '
        Me.MakeSqlBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.MakeSqlBtn.Location = New System.Drawing.Point(9, 395)
        Me.MakeSqlBtn.Name = "MakeSqlBtn"
        Me.MakeSqlBtn.Size = New System.Drawing.Size(242, 23)
        Me.MakeSqlBtn.TabIndex = 0
        Me.MakeSqlBtn.Text = "Step 1: Generate QueryPacket Request XML"
        Me.MakeSqlBtn.UseVisualStyleBackColor = True
        '
        'QueryBtn
        '
        Me.QueryBtn.Location = New System.Drawing.Point(206, 16)
        Me.QueryBtn.Name = "QueryBtn"
        Me.QueryBtn.Size = New System.Drawing.Size(277, 23)
        Me.QueryBtn.TabIndex = 1
        Me.QueryBtn.Text = "&Query(queryXml As String) As String"
        Me.QueryBtn.UseVisualStyleBackColor = True
        '
        'QueryPacket
        '
        Me.QueryPacket.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.QueryPacket.Location = New System.Drawing.Point(12, 19)
        Me.QueryPacket.Multiline = True
        Me.QueryPacket.Name = "QueryPacket"
        Me.QueryPacket.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.QueryPacket.Size = New System.Drawing.Size(944, 137)
        Me.QueryPacket.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Query Text:"
        '
        'QueryTxt
        '
        Me.QueryTxt.Location = New System.Drawing.Point(66, 23)
        Me.QueryTxt.Name = "QueryTxt"
        Me.QueryTxt.Size = New System.Drawing.Size(112, 20)
        Me.QueryTxt.TabIndex = 2
        '
        'NumRec
        '
        Me.NumRec.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.NumRec.Location = New System.Drawing.Point(587, 330)
        Me.NumRec.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.NumRec.Name = "NumRec"
        Me.NumRec.Size = New System.Drawing.Size(61, 20)
        Me.NumRec.TabIndex = 11
        Me.NumRec.Value = New Decimal(New Integer() {20, 0, 0, 0})
        '
        'StartNum
        '
        Me.StartNum.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.StartNum.Location = New System.Drawing.Point(587, 306)
        Me.StartNum.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.StartNum.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.StartNum.Name = "StartNum"
        Me.StartNum.Size = New System.Drawing.Size(61, 20)
        Me.StartNum.TabIndex = 9
        Me.StartNum.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label6.Location = New System.Drawing.Point(523, 330)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 20)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "# Records:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label5.Location = New System.Drawing.Point(523, 304)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 20)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Start #:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ToolsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(984, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConnectToServiceMenuItem, Me.OpenQueryPacketFileToolStripMenuItem, Me.ToolStripSeparator1, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'ConnectToServiceMenuItem
        '
        Me.ConnectToServiceMenuItem.Name = "ConnectToServiceMenuItem"
        Me.ConnectToServiceMenuItem.Size = New System.Drawing.Size(280, 22)
        Me.ConnectToServiceMenuItem.Text = "&Connect to SharePoint Search Service..."
        '
        'OpenQueryPacketFileToolStripMenuItem
        '
        Me.OpenQueryPacketFileToolStripMenuItem.Name = "OpenQueryPacketFileToolStripMenuItem"
        Me.OpenQueryPacketFileToolStripMenuItem.Size = New System.Drawing.Size(280, 22)
        Me.OpenQueryPacketFileToolStripMenuItem.Text = "&Open QueryPacket File..."
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(277, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(280, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ParseMnu, Me.WhereMnu})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.ToolsToolStripMenuItem.Text = "&Tools"
        '
        'ParseMnu
        '
        Me.ParseMnu.Name = "ParseMnu"
        Me.ParseMnu.Size = New System.Drawing.Size(165, 22)
        Me.ParseMnu.Text = "&Query Parser"
        '
        'WhereMnu
        '
        Me.WhereMnu.Name = "WhereMnu"
        Me.WhereMnu.Size = New System.Drawing.Size(165, 22)
        Me.WhereMnu.Text = "&Where Predicates"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SQLSyntaxHelpMenuItem, Me.KeywordSyntaxHelpMenuItem, Me.SearchSchemaHelpMenuItem, Me.AboutSharePointSearchServiceToolToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'SQLSyntaxHelpMenuItem
        '
        Me.SQLSyntaxHelpMenuItem.Name = "SQLSyntaxHelpMenuItem"
        Me.SQLSyntaxHelpMenuItem.Size = New System.Drawing.Size(428, 22)
        Me.SQLSyntaxHelpMenuItem.Text = "Enterprise Search SQL Syntax Help on MSDN"
        '
        'KeywordSyntaxHelpMenuItem
        '
        Me.KeywordSyntaxHelpMenuItem.Name = "KeywordSyntaxHelpMenuItem"
        Me.KeywordSyntaxHelpMenuItem.Size = New System.Drawing.Size(428, 22)
        Me.KeywordSyntaxHelpMenuItem.Text = "Enterprise Search Keyword Syntax Help on MSDN"
        '
        'SearchSchemaHelpMenuItem
        '
        Me.SearchSchemaHelpMenuItem.Name = "SearchSchemaHelpMenuItem"
        Me.SearchSchemaHelpMenuItem.Size = New System.Drawing.Size(428, 22)
        Me.SearchSchemaHelpMenuItem.Text = "Microsoft.Search Schema Reference for Enterprise Search on MSDN"
        '
        'AboutSharePointSearchServiceToolToolStripMenuItem
        '
        Me.AboutSharePointSearchServiceToolToolStripMenuItem.Name = "AboutSharePointSearchServiceToolToolStripMenuItem"
        Me.AboutSharePointSearchServiceToolToolStripMenuItem.Size = New System.Drawing.Size(428, 22)
        Me.AboutSharePointSearchServiceToolToolStripMenuItem.Text = "About SharePoint Search Service Tool"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StatusLbl})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 692)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(984, 22)
        Me.StatusStrip1.TabIndex = 3
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'StatusLbl
        '
        Me.StatusLbl.Name = "StatusLbl"
        Me.StatusLbl.Size = New System.Drawing.Size(969, 17)
        Me.StatusLbl.Spring = True
        Me.StatusLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tbLocale
        '
        Me.tbLocale.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.tbLocale.Location = New System.Drawing.Point(587, 354)
        Me.tbLocale.Name = "tbLocale"
        Me.tbLocale.Size = New System.Drawing.Size(61, 20)
        Me.tbLocale.TabIndex = 13
        Me.tbLocale.Text = "en-US"
        '
        'Label14
        '
        Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(523, 357)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(42, 13)
        Me.Label14.TabIndex = 12
        Me.Label14.Text = "Locale:"
        '
        'GroupBox5
        '
        Me.GroupBox5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox5.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox5.Controls.Add(Me.GroupBox2)
        Me.GroupBox5.Controls.Add(Me.QueryTxt)
        Me.GroupBox5.Controls.Add(Me.tbLocale)
        Me.GroupBox5.Controls.Add(Me.Label14)
        Me.GroupBox5.Controls.Add(Me.cbIncludeHighConfidenceResults)
        Me.GroupBox5.Controls.Add(Me.cbIncludeSpecialTermResults)
        Me.GroupBox5.Controls.Add(Me.cbIncludeRelevanceResults)
        Me.GroupBox5.Controls.Add(Me.cbImplicitAndBehavior)
        Me.GroupBox5.Controls.Add(Me.cbIgnoreAllNoiseQuery)
        Me.GroupBox5.Controls.Add(Me.cbTrimDuplicates)
        Me.GroupBox5.Controls.Add(Me.cbEnableStemming)
        Me.GroupBox5.Controls.Add(Me.Label10)
        Me.GroupBox5.Controls.Add(Me.MakeSqlBtn)
        Me.GroupBox5.Controls.Add(Me.propdg)
        Me.GroupBox5.Controls.Add(Me.Label2)
        Me.GroupBox5.Controls.Add(Me.ScopeChk)
        Me.GroupBox5.Controls.Add(Me.Label4)
        Me.GroupBox5.Controls.Add(Me.NumRec)
        Me.GroupBox5.Controls.Add(Me.StartNum)
        Me.GroupBox5.Controls.Add(Me.Label6)
        Me.GroupBox5.Controls.Add(Me.Label5)
        Me.GroupBox5.Location = New System.Drawing.Point(6, 35)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(966, 424)
        Me.GroupBox5.TabIndex = 0
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Step 1: Set Query Options"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.pnlSQLOptions)
        Me.GroupBox2.Controls.Add(Me.rbKeywordSyntax)
        Me.GroupBox2.Controls.Add(Me.rbSQLSyntax)
        Me.GroupBox2.Location = New System.Drawing.Point(9, 282)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(508, 107)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Choose Query Syntax and Options"
        '
        'pnlSQLOptions
        '
        Me.pnlSQLOptions.Controls.Add(Me.OrChk)
        Me.pnlSQLOptions.Controls.Add(Me.GroupBox1)
        Me.pnlSQLOptions.Controls.Add(Me.WildChk)
        Me.pnlSQLOptions.Location = New System.Drawing.Point(8, 43)
        Me.pnlSQLOptions.Name = "pnlSQLOptions"
        Me.pnlSQLOptions.Size = New System.Drawing.Size(466, 58)
        Me.pnlSQLOptions.TabIndex = 1
        '
        'OrChk
        '
        Me.OrChk.AutoSize = True
        Me.OrChk.Location = New System.Drawing.Point(215, 13)
        Me.OrChk.Name = "OrChk"
        Me.OrChk.Size = New System.Drawing.Size(242, 17)
        Me.OrChk.TabIndex = 1
        Me.OrChk.Text = "Use 'Or' instead of 'And' to combine properites"
        Me.OrChk.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.FreetxtOpt)
        Me.GroupBox1.Controls.Add(Me.ContainsOpt)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(187, 33)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Keyword Predicate:"
        '
        'FreetxtOpt
        '
        Me.FreetxtOpt.AutoSize = True
        Me.FreetxtOpt.Location = New System.Drawing.Point(103, 13)
        Me.FreetxtOpt.Name = "FreetxtOpt"
        Me.FreetxtOpt.Size = New System.Drawing.Size(81, 17)
        Me.FreetxtOpt.TabIndex = 1
        Me.FreetxtOpt.Text = "FREETEXT"
        Me.FreetxtOpt.UseVisualStyleBackColor = True
        '
        'ContainsOpt
        '
        Me.ContainsOpt.AutoSize = True
        Me.ContainsOpt.Checked = True
        Me.ContainsOpt.Location = New System.Drawing.Point(11, 13)
        Me.ContainsOpt.Name = "ContainsOpt"
        Me.ContainsOpt.Size = New System.Drawing.Size(80, 17)
        Me.ContainsOpt.TabIndex = 0
        Me.ContainsOpt.TabStop = True
        Me.ContainsOpt.Text = "CONTAINS"
        Me.ContainsOpt.UseVisualStyleBackColor = True
        '
        'WildChk
        '
        Me.WildChk.AutoSize = True
        Me.WildChk.Location = New System.Drawing.Point(215, 32)
        Me.WildChk.Name = "WildChk"
        Me.WildChk.Size = New System.Drawing.Size(105, 17)
        Me.WildChk.TabIndex = 2
        Me.WildChk.Text = "Wildcard Search"
        Me.WildChk.UseVisualStyleBackColor = True
        '
        'rbKeywordSyntax
        '
        Me.rbKeywordSyntax.AutoSize = True
        Me.rbKeywordSyntax.Location = New System.Drawing.Point(187, 21)
        Me.rbKeywordSyntax.Name = "rbKeywordSyntax"
        Me.rbKeywordSyntax.Size = New System.Drawing.Size(148, 17)
        Me.rbKeywordSyntax.TabIndex = 2
        Me.rbKeywordSyntax.Text = "Generate Keyword Syntax"
        Me.rbKeywordSyntax.UseVisualStyleBackColor = True
        '
        'rbSQLSyntax
        '
        Me.rbSQLSyntax.AutoSize = True
        Me.rbSQLSyntax.Checked = True
        Me.rbSQLSyntax.Location = New System.Drawing.Point(6, 21)
        Me.rbSQLSyntax.Name = "rbSQLSyntax"
        Me.rbSQLSyntax.Size = New System.Drawing.Size(128, 17)
        Me.rbSQLSyntax.TabIndex = 0
        Me.rbSQLSyntax.TabStop = True
        Me.rbSQLSyntax.Text = "Generate SQL Syntax"
        Me.rbSQLSyntax.UseVisualStyleBackColor = True
        '
        'cbIncludeHighConfidenceResults
        '
        Me.cbIncludeHighConfidenceResults.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cbIncludeHighConfidenceResults.AutoSize = True
        Me.cbIncludeHighConfidenceResults.Checked = True
        Me.cbIncludeHighConfidenceResults.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbIncludeHighConfidenceResults.Location = New System.Drawing.Point(789, 336)
        Me.cbIncludeHighConfidenceResults.Name = "cbIncludeHighConfidenceResults"
        Me.cbIncludeHighConfidenceResults.Size = New System.Drawing.Size(172, 17)
        Me.cbIncludeHighConfidenceResults.TabIndex = 20
        Me.cbIncludeHighConfidenceResults.Text = "IncludeHighConfidenceResults"
        Me.cbIncludeHighConfidenceResults.UseVisualStyleBackColor = True
        '
        'cbIncludeSpecialTermResults
        '
        Me.cbIncludeSpecialTermResults.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cbIncludeSpecialTermResults.AutoSize = True
        Me.cbIncludeSpecialTermResults.Checked = True
        Me.cbIncludeSpecialTermResults.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbIncludeSpecialTermResults.Location = New System.Drawing.Point(789, 321)
        Me.cbIncludeSpecialTermResults.Name = "cbIncludeSpecialTermResults"
        Me.cbIncludeSpecialTermResults.Size = New System.Drawing.Size(155, 17)
        Me.cbIncludeSpecialTermResults.TabIndex = 19
        Me.cbIncludeSpecialTermResults.Text = "IncludeSpecialTermResults"
        Me.cbIncludeSpecialTermResults.UseVisualStyleBackColor = True
        '
        'cbIncludeRelevanceResults
        '
        Me.cbIncludeRelevanceResults.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cbIncludeRelevanceResults.AutoSize = True
        Me.cbIncludeRelevanceResults.Checked = True
        Me.cbIncludeRelevanceResults.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbIncludeRelevanceResults.Location = New System.Drawing.Point(789, 305)
        Me.cbIncludeRelevanceResults.Name = "cbIncludeRelevanceResults"
        Me.cbIncludeRelevanceResults.Size = New System.Drawing.Size(148, 17)
        Me.cbIncludeRelevanceResults.TabIndex = 18
        Me.cbIncludeRelevanceResults.Text = "IncludeRelevanceResults"
        Me.cbIncludeRelevanceResults.UseVisualStyleBackColor = True
        '
        'cbImplicitAndBehavior
        '
        Me.cbImplicitAndBehavior.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cbImplicitAndBehavior.AutoSize = True
        Me.cbImplicitAndBehavior.Checked = True
        Me.cbImplicitAndBehavior.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbImplicitAndBehavior.Location = New System.Drawing.Point(664, 350)
        Me.cbImplicitAndBehavior.Name = "cbImplicitAndBehavior"
        Me.cbImplicitAndBehavior.Size = New System.Drawing.Size(119, 17)
        Me.cbImplicitAndBehavior.TabIndex = 17
        Me.cbImplicitAndBehavior.Text = "ImplicitAndBehavior"
        Me.cbImplicitAndBehavior.UseVisualStyleBackColor = True
        '
        'cbIgnoreAllNoiseQuery
        '
        Me.cbIgnoreAllNoiseQuery.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cbIgnoreAllNoiseQuery.AutoSize = True
        Me.cbIgnoreAllNoiseQuery.Checked = True
        Me.cbIgnoreAllNoiseQuery.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbIgnoreAllNoiseQuery.Location = New System.Drawing.Point(664, 335)
        Me.cbIgnoreAllNoiseQuery.Name = "cbIgnoreAllNoiseQuery"
        Me.cbIgnoreAllNoiseQuery.Size = New System.Drawing.Size(122, 17)
        Me.cbIgnoreAllNoiseQuery.TabIndex = 16
        Me.cbIgnoreAllNoiseQuery.Text = "IgnoreAllNoiseQuery"
        Me.cbIgnoreAllNoiseQuery.UseVisualStyleBackColor = True
        '
        'cbTrimDuplicates
        '
        Me.cbTrimDuplicates.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cbTrimDuplicates.AutoSize = True
        Me.cbTrimDuplicates.Checked = True
        Me.cbTrimDuplicates.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbTrimDuplicates.Location = New System.Drawing.Point(664, 320)
        Me.cbTrimDuplicates.Name = "cbTrimDuplicates"
        Me.cbTrimDuplicates.Size = New System.Drawing.Size(96, 17)
        Me.cbTrimDuplicates.TabIndex = 15
        Me.cbTrimDuplicates.Text = "TrimDuplicates"
        Me.cbTrimDuplicates.UseVisualStyleBackColor = True
        '
        'cbEnableStemming
        '
        Me.cbEnableStemming.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cbEnableStemming.AutoSize = True
        Me.cbEnableStemming.Location = New System.Drawing.Point(664, 305)
        Me.cbEnableStemming.Name = "cbEnableStemming"
        Me.cbEnableStemming.Size = New System.Drawing.Size(105, 17)
        Me.cbEnableStemming.TabIndex = 14
        Me.cbEnableStemming.Text = "EnableStemming"
        Me.cbEnableStemming.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(184, 12)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(142, 13)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "Managed Search Properties:"
        '
        'GroupBox6
        '
        Me.GroupBox6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox6.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox6.Controls.Add(Me.QueryPacket)
        Me.GroupBox6.Location = New System.Drawing.Point(6, 468)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(966, 162)
        Me.GroupBox6.TabIndex = 1
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Step 2: Review QueryPacket Request XML (tweak if needed)"
        '
        'GroupBox7
        '
        Me.GroupBox7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox7.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox7.Controls.Add(Me.Label9)
        Me.GroupBox7.Controls.Add(Me.QueryExBtn)
        Me.GroupBox7.Controls.Add(Me.QueryBtn)
        Me.GroupBox7.Location = New System.Drawing.Point(6, 636)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(966, 48)
        Me.GroupBox7.TabIndex = 2
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Step 3: Run Query"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(19, 21)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(180, 13)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Search Service Method To Execute:"
        '
        'QueryExBtn
        '
        Me.QueryExBtn.Location = New System.Drawing.Point(489, 16)
        Me.QueryExBtn.Name = "QueryExBtn"
        Me.QueryExBtn.Size = New System.Drawing.Size(277, 23)
        Me.QueryExBtn.TabIndex = 2
        Me.QueryExBtn.Text = "Query&Ex(queryXml As String) As System.Xml.DataSet"
        Me.QueryExBtn.UseVisualStyleBackColor = True
        '
        'QryFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(984, 714)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "QryFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SharePoint Search Service Tool"
        CType(Me.propdg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumRec, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StartNum, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.pnlSQLOptions.ResumeLayout(False)
        Me.pnlSQLOptions.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents propdg As System.Windows.Forms.DataGridView
    Friend WithEvents ScopeChk As System.Windows.Forms.CheckedListBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents MakeSqlBtn As System.Windows.Forms.Button
    Friend WithEvents QueryBtn As System.Windows.Forms.Button
    Friend WithEvents QueryPacket As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents QueryTxt As System.Windows.Forms.TextBox
    Friend WithEvents NumRec As System.Windows.Forms.NumericUpDown
    Friend WithEvents StartNum As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ParseMnu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WhereMnu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents StatusLbl As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents QueryExBtn As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cbImplicitAndBehavior As System.Windows.Forms.CheckBox
    Friend WithEvents cbIgnoreAllNoiseQuery As System.Windows.Forms.CheckBox
    Friend WithEvents cbTrimDuplicates As System.Windows.Forms.CheckBox
    Friend WithEvents cbEnableStemming As System.Windows.Forms.CheckBox
    Friend WithEvents cbIncludeHighConfidenceResults As System.Windows.Forms.CheckBox
    Friend WithEvents cbIncludeSpecialTermResults As System.Windows.Forms.CheckBox
    Friend WithEvents cbIncludeRelevanceResults As System.Windows.Forms.CheckBox
    Friend WithEvents tbLocale As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenQueryPacketFileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutSharePointSearchServiceToolToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConnectToServiceMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SQLSyntaxHelpMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KeywordSyntaxHelpMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SearchSchemaHelpMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rbSQLSyntax As System.Windows.Forms.RadioButton
    Friend WithEvents pnlSQLOptions As System.Windows.Forms.Panel
    Friend WithEvents OrChk As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents FreetxtOpt As System.Windows.Forms.RadioButton
    Friend WithEvents ContainsOpt As System.Windows.Forms.RadioButton
    Friend WithEvents WildChk As System.Windows.Forms.CheckBox
    Friend WithEvents rbKeywordSyntax As System.Windows.Forms.RadioButton

End Class
