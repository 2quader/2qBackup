<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnStart = New System.Windows.Forms.Button
        Me.lblCSrc = New System.Windows.Forms.Label
        Me.lblCTarget = New System.Windows.Forms.Label
        Me.lblCUser = New System.Windows.Forms.Label
        Me.lblCPass = New System.Windows.Forms.Label
        Me.txtSrc = New System.Windows.Forms.TextBox
        Me.txtTarget = New System.Windows.Forms.TextBox
        Me.txtUser = New System.Windows.Forms.TextBox
        Me.lbLog = New System.Windows.Forms.ListBox
        Me.txtmPass = New System.Windows.Forms.MaskedTextBox
        Me.bgwZIP = New System.ComponentModel.BackgroundWorker
        Me.SuspendLayout()
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(12, 227)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(136, 23)
        Me.btnStart.TabIndex = 0
        Me.btnStart.Text = "Backup starten"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'lblCSrc
        '
        Me.lblCSrc.AutoSize = True
        Me.lblCSrc.Location = New System.Drawing.Point(12, 15)
        Me.lblCSrc.Name = "lblCSrc"
        Me.lblCSrc.Size = New System.Drawing.Size(40, 13)
        Me.lblCSrc.TabIndex = 1
        Me.lblCSrc.Text = "Quelle:"
        '
        'lblCTarget
        '
        Me.lblCTarget.AutoSize = True
        Me.lblCTarget.Location = New System.Drawing.Point(12, 41)
        Me.lblCTarget.Name = "lblCTarget"
        Me.lblCTarget.Size = New System.Drawing.Size(27, 13)
        Me.lblCTarget.TabIndex = 2
        Me.lblCTarget.Text = "Ziel:"
        '
        'lblCUser
        '
        Me.lblCUser.AutoSize = True
        Me.lblCUser.Location = New System.Drawing.Point(12, 67)
        Me.lblCUser.Name = "lblCUser"
        Me.lblCUser.Size = New System.Drawing.Size(32, 13)
        Me.lblCUser.TabIndex = 3
        Me.lblCUser.Text = "User:"
        '
        'lblCPass
        '
        Me.lblCPass.AutoSize = True
        Me.lblCPass.Location = New System.Drawing.Point(12, 93)
        Me.lblCPass.Name = "lblCPass"
        Me.lblCPass.Size = New System.Drawing.Size(33, 13)
        Me.lblCPass.TabIndex = 4
        Me.lblCPass.Text = "Pass:"
        '
        'txtSrc
        '
        Me.txtSrc.Location = New System.Drawing.Point(58, 12)
        Me.txtSrc.Name = "txtSrc"
        Me.txtSrc.ReadOnly = True
        Me.txtSrc.Size = New System.Drawing.Size(214, 20)
        Me.txtSrc.TabIndex = 5
        '
        'txtTarget
        '
        Me.txtTarget.Location = New System.Drawing.Point(58, 38)
        Me.txtTarget.Name = "txtTarget"
        Me.txtTarget.ReadOnly = True
        Me.txtTarget.Size = New System.Drawing.Size(214, 20)
        Me.txtTarget.TabIndex = 6
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(58, 64)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.ReadOnly = True
        Me.txtUser.Size = New System.Drawing.Size(214, 20)
        Me.txtUser.TabIndex = 7
        '
        'lbLog
        '
        Me.lbLog.FormattingEnabled = True
        Me.lbLog.Location = New System.Drawing.Point(12, 116)
        Me.lbLog.Name = "lbLog"
        Me.lbLog.Size = New System.Drawing.Size(260, 108)
        Me.lbLog.TabIndex = 9
        '
        'txtmPass
        '
        Me.txtmPass.Location = New System.Drawing.Point(58, 90)
        Me.txtmPass.Name = "txtmPass"
        Me.txtmPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtmPass.ReadOnly = True
        Me.txtmPass.Size = New System.Drawing.Size(214, 20)
        Me.txtmPass.TabIndex = 10
        '
        'bgwZIP
        '
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.txtmPass)
        Me.Controls.Add(Me.lbLog)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.txtTarget)
        Me.Controls.Add(Me.txtSrc)
        Me.Controls.Add(Me.lblCPass)
        Me.Controls.Add(Me.lblCUser)
        Me.Controls.Add(Me.lblCTarget)
        Me.Controls.Add(Me.lblCSrc)
        Me.Controls.Add(Me.btnStart)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.Text = "2qBackup"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents lblCSrc As System.Windows.Forms.Label
    Friend WithEvents lblCTarget As System.Windows.Forms.Label
    Friend WithEvents lblCUser As System.Windows.Forms.Label
    Friend WithEvents lblCPass As System.Windows.Forms.Label
    Friend WithEvents txtSrc As System.Windows.Forms.TextBox
    Friend WithEvents txtTarget As System.Windows.Forms.TextBox
    Friend WithEvents txtUser As System.Windows.Forms.TextBox
    Friend WithEvents lbLog As System.Windows.Forms.ListBox
    Friend WithEvents txtmPass As System.Windows.Forms.MaskedTextBox
    Friend WithEvents bgwZIP As System.ComponentModel.BackgroundWorker

End Class
