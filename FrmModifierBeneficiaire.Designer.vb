<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmModifierBeneficiaire
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnInitialiser = New System.Windows.Forms.Button()
        Me.CmbVille = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DateNais = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtPrenom = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtNom = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnAnnuler = New System.Windows.Forms.Button()
        Me.BtnModifier = New System.Windows.Forms.Button()
        Me.TxtCode = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnInitialiser)
        Me.GroupBox1.Controls.Add(Me.CmbVille)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.DateNais)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TxtPrenom)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TxtNom)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.BtnAnnuler)
        Me.GroupBox1.Controls.Add(Me.BtnModifier)
        Me.GroupBox1.Controls.Add(Me.TxtCode)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(498, 398)
        Me.GroupBox1.TabIndex = 34
        Me.GroupBox1.TabStop = False
        '
        'BtnInitialiser
        '
        Me.BtnInitialiser.Image = Global.GestionDesFormation.My.Resources.Resources.Reset_16
        Me.BtnInitialiser.Location = New System.Drawing.Point(27, 336)
        Me.BtnInitialiser.Name = "BtnInitialiser"
        Me.BtnInitialiser.Size = New System.Drawing.Size(30, 30)
        Me.BtnInitialiser.TabIndex = 46
        Me.BtnInitialiser.UseVisualStyleBackColor = True
        '
        'CmbVille
        '
        Me.CmbVille.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbVille.FormattingEnabled = True
        Me.CmbVille.Location = New System.Drawing.Point(149, 252)
        Me.CmbVille.Name = "CmbVille"
        Me.CmbVille.Size = New System.Drawing.Size(138, 21)
        Me.CmbVille.TabIndex = 45
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(104, 256)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 44
        Me.Label5.Text = "Ville :"
        '
        'DateNais
        '
        Me.DateNais.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateNais.Location = New System.Drawing.Point(149, 201)
        Me.DateNais.Name = "DateNais"
        Me.DateNais.Size = New System.Drawing.Size(138, 20)
        Me.DateNais.TabIndex = 37
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(47, 204)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 13)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "Date Naissance :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(87, 151)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "Prénom :"
        '
        'TxtPrenom
        '
        Me.TxtPrenom.Location = New System.Drawing.Point(149, 147)
        Me.TxtPrenom.Name = "TxtPrenom"
        Me.TxtPrenom.Size = New System.Drawing.Size(236, 20)
        Me.TxtPrenom.TabIndex = 36
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(101, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "Nom :"
        '
        'TxtNom
        '
        Me.TxtNom.Location = New System.Drawing.Point(149, 90)
        Me.TxtNom.Name = "TxtNom"
        Me.TxtNom.Size = New System.Drawing.Size(236, 20)
        Me.TxtNom.TabIndex = 35
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(98, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "Code :"
        '
        'BtnAnnuler
        '
        Me.BtnAnnuler.BackColor = System.Drawing.Color.Salmon
        Me.BtnAnnuler.Image = Global.GestionDesFormation.My.Resources.Resources.cancel_16
        Me.BtnAnnuler.Location = New System.Drawing.Point(399, 337)
        Me.BtnAnnuler.Name = "BtnAnnuler"
        Me.BtnAnnuler.Size = New System.Drawing.Size(73, 29)
        Me.BtnAnnuler.TabIndex = 39
        Me.BtnAnnuler.Text = "&Annuler"
        Me.BtnAnnuler.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnAnnuler.UseVisualStyleBackColor = False
        '
        'BtnModifier
        '
        Me.BtnModifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnModifier.Image = Global.GestionDesFormation.My.Resources.Resources.verified_Beneficiaire_16
        Me.BtnModifier.Location = New System.Drawing.Point(315, 337)
        Me.BtnModifier.Name = "BtnModifier"
        Me.BtnModifier.Size = New System.Drawing.Size(78, 29)
        Me.BtnModifier.TabIndex = 38
        Me.BtnModifier.Text = "&Modifier"
        Me.BtnModifier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnModifier.UseVisualStyleBackColor = True
        '
        'TxtCode
        '
        Me.TxtCode.Location = New System.Drawing.Point(149, 33)
        Me.TxtCode.Name = "TxtCode"
        Me.TxtCode.Size = New System.Drawing.Size(138, 20)
        Me.TxtCode.TabIndex = 34
        '
        'FrmModifierBeneficiaire
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkOrange
        Me.ClientSize = New System.Drawing.Size(498, 398)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmModifierBeneficiaire"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnInitialiser As Button
    Friend WithEvents CmbVille As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents DateNais As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtPrenom As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtNom As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnAnnuler As Button
    Friend WithEvents BtnModifier As Button
    Friend WithEvents TxtCode As TextBox
End Class
