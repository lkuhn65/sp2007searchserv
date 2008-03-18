Imports System.Windows.Forms

Public Class ConnectDialog

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        My.Settings.ServerUrl = UrlTxt.Text
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub ConnectDialog_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        UrlTxt.Text = My.Settings.ServerUrl
        If UrlTxt.Text.Length = 0 Then
            UrlTxt.Text = "http://" & System.Environment.MachineName
        End If

    End Sub

    Private Sub rbWSS_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbWSS.CheckedChanged
        lblWebService.Text = "_vti_bin/spssearch.asmx"
    End Sub

    Private Sub rbMOSS_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbMOSS.CheckedChanged
        lblWebService.Text = "_vti_bin/search.asmx"
    End Sub
End Class
