Public Class LoginForm

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        My.Settings.Username = Username
        My.Settings.IgnoreCertErrors = IgnoreCertErrors
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Public ReadOnly Property Username()
        Get
            Return Me.UsernameTextBox.Text
        End Get
    End Property

    Public ReadOnly Property Password()
        Get
            Return Me.PasswordTextBox.Text
        End Get
    End Property

    Public ReadOnly Property IgnoreCertErrors()
        Get
            Return Me.IgnoreCertErrChk.Checked
        End Get
    End Property

    Private Sub LoginForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.UsernameTextBox.Text = My.Settings.Username
        Me.IgnoreCertErrChk.Checked = My.Settings.IgnoreCertErrors
    End Sub
End Class
