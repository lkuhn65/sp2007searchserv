Public Class ParseFrm
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
	Friend WithEvents Label1 As System.Windows.Forms.Label
	Friend WithEvents InpTxt As System.Windows.Forms.TextBox
	Friend WithEvents DecodeBtn As System.Windows.Forms.Button
	Friend WithEvents SBar As System.Windows.Forms.StatusBar
	Friend WithEvents OutTxt As System.Windows.Forms.TextBox
	Friend WithEvents Label2 As System.Windows.Forms.Label
	Friend WithEvents FontDlg As System.Windows.Forms.FontDialog
	Friend WithEvents MainMnu As System.Windows.Forms.MainMenu
	Friend WithEvents FontsMnu As System.Windows.Forms.MenuItem
	Friend WithEvents FontMnu As System.Windows.Forms.MenuItem
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ParseFrm))
		Me.Label1 = New System.Windows.Forms.Label
		Me.InpTxt = New System.Windows.Forms.TextBox
		Me.DecodeBtn = New System.Windows.Forms.Button
		Me.SBar = New System.Windows.Forms.StatusBar
		Me.OutTxt = New System.Windows.Forms.TextBox
		Me.Label2 = New System.Windows.Forms.Label
		Me.FontDlg = New System.Windows.Forms.FontDialog
		Me.MainMnu = New System.Windows.Forms.MainMenu(Me.components)
		Me.FontsMnu = New System.Windows.Forms.MenuItem
		Me.FontMnu = New System.Windows.Forms.MenuItem
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.Location = New System.Drawing.Point(8, 12)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(280, 20)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Paste your encoded query here:"
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'InpTxt
		'
		Me.InpTxt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
								Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.InpTxt.Location = New System.Drawing.Point(4, 32)
		Me.InpTxt.Multiline = True
		Me.InpTxt.Name = "InpTxt"
		Me.InpTxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
		Me.InpTxt.Size = New System.Drawing.Size(592, 188)
		Me.InpTxt.TabIndex = 1
		'
		'DecodeBtn
		'
		Me.DecodeBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.DecodeBtn.Location = New System.Drawing.Point(520, 4)
		Me.DecodeBtn.Name = "DecodeBtn"
		Me.DecodeBtn.Size = New System.Drawing.Size(75, 23)
		Me.DecodeBtn.TabIndex = 2
		Me.DecodeBtn.Text = "Decode"
		'
		'SBar
		'
		Me.SBar.Location = New System.Drawing.Point(0, 419)
		Me.SBar.Name = "SBar"
		Me.SBar.Size = New System.Drawing.Size(600, 22)
		Me.SBar.TabIndex = 5
		'
		'OutTxt
		'
		Me.OutTxt.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
								Or System.Windows.Forms.AnchorStyles.Left) _
								Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.OutTxt.Location = New System.Drawing.Point(4, 244)
		Me.OutTxt.Multiline = True
		Me.OutTxt.Name = "OutTxt"
		Me.OutTxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
		Me.OutTxt.Size = New System.Drawing.Size(592, 176)
		Me.OutTxt.TabIndex = 7
		'
		'Label2
		'
		Me.Label2.Location = New System.Drawing.Point(8, 224)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(280, 20)
		Me.Label2.TabIndex = 6
		Me.Label2.Text = "Output:"
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'MainMnu
		'
		Me.MainMnu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.FontsMnu})
		'
		'FontsMnu
		'
		Me.FontsMnu.Index = 0
		Me.FontsMnu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.FontMnu})
		Me.FontsMnu.Text = "&Fonts"
		'
		'FontMnu
		'
		Me.FontMnu.Index = 0
		Me.FontMnu.Text = "&Change Fonts"
		'
		'ParseFrm
		'
		Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
		Me.ClientSize = New System.Drawing.Size(600, 441)
		Me.Controls.Add(Me.OutTxt)
		Me.Controls.Add(Me.InpTxt)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.SBar)
		Me.Controls.Add(Me.DecodeBtn)
		Me.Controls.Add(Me.Label1)
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.Menu = Me.MainMnu
		Me.Name = "ParseFrm"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Encoding Helper"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

#End Region

	Private Sub DecodeBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DecodeBtn.Click

		If InpTxt.Text = "" Then
			MessageBox.Show("You must enter text to be decoded.", APP_NAME, _
			 MessageBoxButtons.OK, MessageBoxIcon.Error)
			Exit Sub
		End If

        OutTxt.Text = Web.HttpUtility.HtmlDecode(InpTxt.Text)
		SBar.Text = "Input decoded at " & Now.ToString

	End Sub

	Private Sub chgFontMnu_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles FontMnu.Click

		FontDlg.ShowDialog()

		If FontDlg.Font.Name <> "" Then
			InpTxt.Font = FontDlg.Font
			OutTxt.Font = FontDlg.Font
		End If

	End Sub

End Class
