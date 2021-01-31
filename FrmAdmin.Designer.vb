<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmAdmin
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LblGestionFormation = New System.Windows.Forms.Label()
        Me.LblGestionBeneficiaire = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.BtnFermer = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Montserrat", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(84, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(312, 45)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Administration"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(480, 91)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'LblGestionFormation
        '
        Me.LblGestionFormation.BackColor = System.Drawing.Color.DimGray
        Me.LblGestionFormation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblGestionFormation.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblGestionFormation.Image = Global.GestionDesFormation.My.Resources.Resources.Formations_16
        Me.LblGestionFormation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LblGestionFormation.Location = New System.Drawing.Point(145, 117)
        Me.LblGestionFormation.Name = "LblGestionFormation"
        Me.LblGestionFormation.Size = New System.Drawing.Size(200, 25)
        Me.LblGestionFormation.TabIndex = 2
        Me.LblGestionFormation.Text = "&Gestion Des Formation"
        Me.LblGestionFormation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblGestionBeneficiaire
        '
        Me.LblGestionBeneficiaire.BackColor = System.Drawing.Color.DimGray
        Me.LblGestionBeneficiaire.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblGestionBeneficiaire.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LblGestionBeneficiaire.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblGestionBeneficiaire.Image = Global.GestionDesFormation.My.Resources.Resources.user_group_16
        Me.LblGestionBeneficiaire.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LblGestionBeneficiaire.Location = New System.Drawing.Point(145, 71)
        Me.LblGestionBeneficiaire.Name = "LblGestionBeneficiaire"
        Me.LblGestionBeneficiaire.Size = New System.Drawing.Size(200, 25)
        Me.LblGestionBeneficiaire.TabIndex = 1
        Me.LblGestionBeneficiaire.Text = "    &Gestion Des Beneficiaires"
        Me.LblGestionBeneficiaire.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.LblGestionBeneficiaire)
        Me.GroupBox2.Controls.Add(Me.LblGestionFormation)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox2.Location = New System.Drawing.Point(0, 91)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(480, 213)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Menu : "
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.BtnFermer)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox3.Location = New System.Drawing.Point(0, 304)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(480, 56)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        '
        'BtnFermer
        '
        Me.BtnFermer.BackColor = System.Drawing.Color.Salmon
        Me.BtnFermer.Image = Global.GestionDesFormation.My.Resources.Resources.cancel_16
        Me.BtnFermer.Location = New System.Drawing.Point(200, 13)
        Me.BtnFermer.Name = "BtnFermer"
        Me.BtnFermer.Size = New System.Drawing.Size(80, 30)
        Me.BtnFermer.TabIndex = 12
        Me.BtnFermer.Text = "&Fermer"
        Me.BtnFermer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnFermer.UseVisualStyleBackColor = False
        '
        'FrmAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkOrange
        Me.ClientSize = New System.Drawing.Size(480, 360)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmAdmin"
        Me.Text = "Administration"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents LblGestionBeneficiaire As Label
    Friend WithEvents LblGestionFormation As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents BtnFermer As Button
End Class
