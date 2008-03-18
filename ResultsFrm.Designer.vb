<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ResultsFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ResultsFrm))
        Me.Label1 = New System.Windows.Forms.Label
        Me.QryTxt = New System.Windows.Forms.TextBox
        Me.btnSaveQuery = New System.Windows.Forms.Button
        Me.btnSaveResults = New System.Windows.Forms.Button
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.RelevantResults = New System.Windows.Forms.TabPage
        Me.RetDg = New System.Windows.Forms.DataGridView
        Me.SpecialTermResults = New System.Windows.Forms.TabPage
        Me.RetDg2 = New System.Windows.Forms.DataGridView
        Me.HighConfidenceResults = New System.Windows.Forms.TabPage
        Me.RetDg3 = New System.Windows.Forms.DataGridView
        Me.XMLResults = New System.Windows.Forms.TabPage
        Me.WebCtrl = New System.Windows.Forms.WebBrowser
        Me.RawTextReults = New System.Windows.Forms.TabPage
        Me.RetTxt = New System.Windows.Forms.TextBox
        Me.TabControl1.SuspendLayout()
        Me.RelevantResults.SuspendLayout()
        CType(Me.RetDg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SpecialTermResults.SuspendLayout()
        CType(Me.RetDg2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HighConfidenceResults.SuspendLayout()
        CType(Me.RetDg3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XMLResults.SuspendLayout()
        Me.RawTextReults.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(0, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Query:"
        '
        'QryTxt
        '
        Me.QryTxt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.QryTxt.Location = New System.Drawing.Point(34, 3)
        Me.QryTxt.Multiline = True
        Me.QryTxt.Name = "QryTxt"
        Me.QryTxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.QryTxt.Size = New System.Drawing.Size(586, 110)
        Me.QryTxt.TabIndex = 15
        '
        'btnSaveQuery
        '
        Me.btnSaveQuery.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSaveQuery.Location = New System.Drawing.Point(627, 6)
        Me.btnSaveQuery.Name = "btnSaveQuery"
        Me.btnSaveQuery.Size = New System.Drawing.Size(100, 23)
        Me.btnSaveQuery.TabIndex = 33
        Me.btnSaveQuery.Text = "Save Query..."
        Me.btnSaveQuery.UseVisualStyleBackColor = True
        '
        'btnSaveResults
        '
        Me.btnSaveResults.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSaveResults.Location = New System.Drawing.Point(627, 90)
        Me.btnSaveResults.Name = "btnSaveResults"
        Me.btnSaveResults.Size = New System.Drawing.Size(100, 23)
        Me.btnSaveResults.TabIndex = 34
        Me.btnSaveResults.Text = "Save Results..."
        Me.btnSaveResults.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.RelevantResults)
        Me.TabControl1.Controls.Add(Me.SpecialTermResults)
        Me.TabControl1.Controls.Add(Me.HighConfidenceResults)
        Me.TabControl1.Controls.Add(Me.XMLResults)
        Me.TabControl1.Controls.Add(Me.RawTextReults)
        Me.TabControl1.Location = New System.Drawing.Point(5, 119)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(722, 313)
        Me.TabControl1.TabIndex = 35
        '
        'RelevantResults
        '
        Me.RelevantResults.Controls.Add(Me.RetDg)
        Me.RelevantResults.Location = New System.Drawing.Point(4, 22)
        Me.RelevantResults.Name = "RelevantResults"
        Me.RelevantResults.Padding = New System.Windows.Forms.Padding(3)
        Me.RelevantResults.Size = New System.Drawing.Size(714, 287)
        Me.RelevantResults.TabIndex = 0
        Me.RelevantResults.Text = "Relevant Results"
        Me.RelevantResults.UseVisualStyleBackColor = True
        '
        'RetDg
        '
        Me.RetDg.AllowUserToAddRows = False
        Me.RetDg.AllowUserToDeleteRows = False
        Me.RetDg.AllowUserToOrderColumns = True
        Me.RetDg.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RetDg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.RetDg.Location = New System.Drawing.Point(0, 0)
        Me.RetDg.Name = "RetDg"
        Me.RetDg.Size = New System.Drawing.Size(714, 287)
        Me.RetDg.TabIndex = 33
        '
        'SpecialTermResults
        '
        Me.SpecialTermResults.Controls.Add(Me.RetDg2)
        Me.SpecialTermResults.Location = New System.Drawing.Point(4, 22)
        Me.SpecialTermResults.Name = "SpecialTermResults"
        Me.SpecialTermResults.Padding = New System.Windows.Forms.Padding(3)
        Me.SpecialTermResults.Size = New System.Drawing.Size(714, 287)
        Me.SpecialTermResults.TabIndex = 1
        Me.SpecialTermResults.Text = "Special Term Results"
        Me.SpecialTermResults.UseVisualStyleBackColor = True
        '
        'RetDg2
        '
        Me.RetDg2.AllowUserToAddRows = False
        Me.RetDg2.AllowUserToDeleteRows = False
        Me.RetDg2.AllowUserToOrderColumns = True
        Me.RetDg2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RetDg2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.RetDg2.Location = New System.Drawing.Point(-2, 2)
        Me.RetDg2.Name = "RetDg2"
        Me.RetDg2.Size = New System.Drawing.Size(716, 289)
        Me.RetDg2.TabIndex = 34
        '
        'HighConfidenceResults
        '
        Me.HighConfidenceResults.Controls.Add(Me.RetDg3)
        Me.HighConfidenceResults.Location = New System.Drawing.Point(4, 22)
        Me.HighConfidenceResults.Name = "HighConfidenceResults"
        Me.HighConfidenceResults.Padding = New System.Windows.Forms.Padding(3)
        Me.HighConfidenceResults.Size = New System.Drawing.Size(714, 287)
        Me.HighConfidenceResults.TabIndex = 2
        Me.HighConfidenceResults.Text = "High Confidence Results"
        Me.HighConfidenceResults.UseVisualStyleBackColor = True
        '
        'RetDg3
        '
        Me.RetDg3.AllowUserToAddRows = False
        Me.RetDg3.AllowUserToDeleteRows = False
        Me.RetDg3.AllowUserToOrderColumns = True
        Me.RetDg3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RetDg3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.RetDg3.Location = New System.Drawing.Point(0, 2)
        Me.RetDg3.Name = "RetDg3"
        Me.RetDg3.Size = New System.Drawing.Size(714, 285)
        Me.RetDg3.TabIndex = 35
        '
        'XMLResults
        '
        Me.XMLResults.Controls.Add(Me.WebCtrl)
        Me.XMLResults.Location = New System.Drawing.Point(4, 22)
        Me.XMLResults.Name = "XMLResults"
        Me.XMLResults.Padding = New System.Windows.Forms.Padding(3)
        Me.XMLResults.Size = New System.Drawing.Size(714, 287)
        Me.XMLResults.TabIndex = 3
        Me.XMLResults.Text = "XML"
        Me.XMLResults.UseVisualStyleBackColor = True
        '
        'WebCtrl
        '
        Me.WebCtrl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WebCtrl.Location = New System.Drawing.Point(0, 3)
        Me.WebCtrl.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebCtrl.Name = "WebCtrl"
        Me.WebCtrl.Size = New System.Drawing.Size(714, 284)
        Me.WebCtrl.TabIndex = 32
        '
        'RawTextReults
        '
        Me.RawTextReults.Controls.Add(Me.RetTxt)
        Me.RawTextReults.Location = New System.Drawing.Point(4, 22)
        Me.RawTextReults.Name = "RawTextReults"
        Me.RawTextReults.Padding = New System.Windows.Forms.Padding(3)
        Me.RawTextReults.Size = New System.Drawing.Size(714, 287)
        Me.RawTextReults.TabIndex = 4
        Me.RawTextReults.Text = "Text"
        Me.RawTextReults.UseVisualStyleBackColor = True
        '
        'RetTxt
        '
        Me.RetTxt.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RetTxt.Location = New System.Drawing.Point(0, 0)
        Me.RetTxt.Multiline = True
        Me.RetTxt.Name = "RetTxt"
        Me.RetTxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.RetTxt.Size = New System.Drawing.Size(714, 287)
        Me.RetTxt.TabIndex = 14
        '
        'ResultsFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(730, 435)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.btnSaveResults)
        Me.Controls.Add(Me.btnSaveQuery)
        Me.Controls.Add(Me.QryTxt)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ResultsFrm"
        Me.Padding = New System.Windows.Forms.Padding(2, 2, 0, 0)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Query Results"
        Me.TabControl1.ResumeLayout(False)
        Me.RelevantResults.ResumeLayout(False)
        CType(Me.RetDg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SpecialTermResults.ResumeLayout(False)
        CType(Me.RetDg2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HighConfidenceResults.ResumeLayout(False)
        CType(Me.RetDg3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XMLResults.ResumeLayout(False)
        Me.RawTextReults.ResumeLayout(False)
        Me.RawTextReults.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents QryTxt As System.Windows.Forms.TextBox
    Friend WithEvents btnSaveQuery As System.Windows.Forms.Button
    Friend WithEvents btnSaveResults As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents RelevantResults As System.Windows.Forms.TabPage
    Friend WithEvents RetDg As System.Windows.Forms.DataGridView
    Friend WithEvents SpecialTermResults As System.Windows.Forms.TabPage
    Friend WithEvents RetDg2 As System.Windows.Forms.DataGridView
    Friend WithEvents HighConfidenceResults As System.Windows.Forms.TabPage
    Friend WithEvents XMLResults As System.Windows.Forms.TabPage
    Friend WithEvents RawTextReults As System.Windows.Forms.TabPage
    Friend WithEvents RetDg3 As System.Windows.Forms.DataGridView
    Friend WithEvents WebCtrl As System.Windows.Forms.WebBrowser
    Friend WithEvents RetTxt As System.Windows.Forms.TextBox
End Class
