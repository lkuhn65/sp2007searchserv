<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConnectDialog
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.OK_Button = New System.Windows.Forms.Button
        Me.Cancel_Button = New System.Windows.Forms.Button
        Me.lblWebService = New System.Windows.Forms.Label
        Me.rbMOSS = New System.Windows.Forms.RadioButton
        Me.rbWSS = New System.Windows.Forms.RadioButton
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.UrlTxt = New System.Windows.Forms.TextBox
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(402, 79)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        '
        'lblWebService
        '
        Me.lblWebService.AutoSize = True
        Me.lblWebService.Location = New System.Drawing.Point(239, 51)
        Me.lblWebService.Name = "lblWebService"
        Me.lblWebService.Size = New System.Drawing.Size(108, 13)
        Me.lblWebService.TabIndex = 14
        Me.lblWebService.Text = "_vti_bin/search.asmx"
        '
        'rbMOSS
        '
        Me.rbMOSS.AutoSize = True
        Me.rbMOSS.Checked = True
        Me.rbMOSS.Location = New System.Drawing.Point(151, 49)
        Me.rbMOSS.Name = "rbMOSS"
        Me.rbMOSS.Size = New System.Drawing.Size(56, 17)
        Me.rbMOSS.TabIndex = 13
        Me.rbMOSS.TabStop = True
        Me.rbMOSS.Text = "MOSS"
        Me.rbMOSS.UseVisualStyleBackColor = True
        '
        'rbWSS
        '
        Me.rbWSS.AutoSize = True
        Me.rbWSS.Location = New System.Drawing.Point(95, 49)
        Me.rbWSS.Name = "rbWSS"
        Me.rbWSS.Size = New System.Drawing.Size(50, 17)
        Me.rbWSS.TabIndex = 12
        Me.rbWSS.Text = "WSS"
        Me.rbWSS.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(12, 51)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(68, 13)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "Server Type:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Server Url:"
        '
        'UrlTxt
        '
        Me.UrlTxt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UrlTxt.Location = New System.Drawing.Point(95, 23)
        Me.UrlTxt.Name = "UrlTxt"
        Me.UrlTxt.Size = New System.Drawing.Size(453, 20)
        Me.UrlTxt.TabIndex = 10
        Me.UrlTxt.Text = "http://localhost"
        '
        'ConnectDialog
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(560, 120)
        Me.Controls.Add(Me.lblWebService)
        Me.Controls.Add(Me.rbMOSS)
        Me.Controls.Add(Me.rbWSS)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.UrlTxt)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ConnectDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Connect to SharePoint Search Service"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents lblWebService As System.Windows.Forms.Label
    Friend WithEvents rbMOSS As System.Windows.Forms.RadioButton
    Friend WithEvents rbWSS As System.Windows.Forms.RadioButton
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents UrlTxt As System.Windows.Forms.TextBox

End Class
