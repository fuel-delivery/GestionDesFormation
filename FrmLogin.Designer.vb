<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLogin
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnAfficherMP = New System.Windows.Forms.Button()
        Me.TxtPassword = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtLogin = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtnAnnuler = New System.Windows.Forms.Button()
        Me.BtnLogin = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(45, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 14)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Username :"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.BtnAfficherMP)
        Me.GroupBox1.Controls.Add(Me.TxtPassword)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TxtLogin)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(400, 202)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'BtnAfficherMP
        '
        Me.BtnAfficherMP.BackColor = System.Drawing.Color.Transparent
        Me.BtnAfficherMP.BackgroundImage = Global.GestionDesFormation.My.Resources.Resources.show_password_16
        Me.BtnAfficherMP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnAfficherMP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAfficherMP.Location = New System.Drawing.Point(301, 125)
        Me.BtnAfficherMP.Name = "BtnAfficherMP"
        Me.BtnAfficherMP.Size = New System.Drawing.Size(21, 21)
        Me.BtnAfficherMP.TabIndex = 4
        Me.BtnAfficherMP.UseVisualStyleBackColor = False
        '
        'TxtPassword
        '
        Me.TxtPassword.Location = New System.Drawing.Point(115, 125)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.Size = New System.Drawing.Size(180, 21)
        Me.TxtPassword.TabIndex = 5
        Me.TxtPassword.Text = "123"
        Me.TxtPassword.UseSystemPasswordChar = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 14)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Mot de passe :"
        '
        'TxtLogin
        '
        Me.TxtLogin.Location = New System.Drawing.Point(115, 58)
        Me.TxtLogin.Name = "TxtLogin"
        Me.TxtLogin.Size = New System.Drawing.Size(180, 21)
        Me.TxtLogin.TabIndex = 3
        Me.TxtLogin.Text = "admin"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.BtnAnnuler)
        Me.GroupBox2.Controls.Add(Me.BtnLogin)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox2.Location = New System.Drawing.Point(0, 202)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(400, 59)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        '
        'BtnAnnuler
        '
        Me.BtnAnnuler.BackColor = System.Drawing.Color.Salmon
        Me.BtnAnnuler.ForeColor = System.Drawing.Color.Black
        Me.BtnAnnuler.Image = Global.GestionDesFormation.My.Resources.Resources.cancel_16
        Me.BtnAnnuler.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAnnuler.Location = New System.Drawing.Point(311, 16)
        Me.BtnAnnuler.Name = "BtnAnnuler"
        Me.BtnAnnuler.Size = New System.Drawing.Size(73, 27)
        Me.BtnAnnuler.TabIndex = 5
        Me.BtnAnnuler.Text = "&Annuler"
        Me.BtnAnnuler.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAnnuler.UseVisualStyleBackColor = False
        '
        'BtnLogin
        '
        Me.BtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLogin.Image = Global.GestionDesFormation.My.Resources.Resources.login_161
        Me.BtnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnLogin.Location = New System.Drawing.Point(201, 16)
        Me.BtnLogin.Name = "BtnLogin"
        Me.BtnLogin.Size = New System.Drawing.Size(104, 27)
        Me.BtnLogin.TabIndex = 4
        Me.BtnLogin.Text = "&Se Connecter"
        Me.BtnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnLogin.UseVisualStyleBackColor = True
        '
        'FrmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkOrange
        Me.ClientSize = New System.Drawing.Size(400, 260)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmLogin"
        Me.Text = "FrmLogin"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TxtPassword As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtLogin As TextBox
    Friend WithEvents BtnAfficherMP As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BtnAnnuler As Button
    Friend WithEvents BtnLogin As Button
End Class
