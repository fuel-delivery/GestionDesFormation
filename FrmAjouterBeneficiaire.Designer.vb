<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAjouterBeneficiaire
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
        Me.ChkPlusieurs = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DateNais = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtPrenom = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtNom = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnAnnuler = New System.Windows.Forms.Button()
        Me.BtnAjouter = New System.Windows.Forms.Button()
        Me.TxtCode = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.DarkOrange
        Me.GroupBox1.Controls.Add(Me.BtnInitialiser)
        Me.GroupBox1.Controls.Add(Me.CmbVille)
        Me.GroupBox1.Controls.Add(Me.ChkPlusieurs)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.DateNais)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TxtPrenom)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TxtNom)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.BtnAnnuler)
        Me.GroupBox1.Controls.Add(Me.BtnAjouter)
        Me.GroupBox1.Controls.Add(Me.TxtCode)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(500, 400)
        Me.GroupBox1.TabIndex = 27
        Me.GroupBox1.TabStop = False
        '
        'BtnInitialiser
        '
        Me.BtnInitialiser.Image = Global.GestionDesFormation.My.Resources.Resources.Reset_16
        Me.BtnInitialiser.Location = New System.Drawing.Point(31, 337)
        Me.BtnInitialiser.Name = "BtnInitialiser"
        Me.BtnInitialiser.Size = New System.Drawing.Size(30, 30)
        Me.BtnInitialiser.TabIndex = 40
        Me.BtnInitialiser.UseVisualStyleBackColor = True
        '
        'CmbVille
        '
        Me.CmbVille.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbVille.FormattingEnabled = True
        Me.CmbVille.Location = New System.Drawing.Point(153, 253)
        Me.CmbVille.Name = "CmbVille"
        Me.CmbVille.Size = New System.Drawing.Size(138, 21)
        Me.CmbVille.TabIndex = 39
        '
        'ChkPlusieurs
        '
        Me.ChkPlusieurs.AutoSize = True
        Me.ChkPlusieurs.Location = New System.Drawing.Point(252, 344)
        Me.ChkPlusieurs.Name = "ChkPlusieurs"
        Me.ChkPlusieurs.Size = New System.Drawing.Size(68, 17)
        Me.ChkPlusieurs.TabIndex = 31
        Me.ChkPlusieurs.Text = "Plusieurs"
        Me.ChkPlusieurs.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(108, 257)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "Ville :"
        '
        'DateNais
        '
        Me.DateNais.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateNais.Location = New System.Drawing.Point(153, 201)
        Me.DateNais.Name = "DateNais"
        Me.DateNais.Size = New System.Drawing.Size(138, 20)
        Me.DateNais.TabIndex = 30
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(51, 205)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 13)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "Date Naissance :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(91, 152)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "Prénom :"
        '
        'TxtPrenom
        '
        Me.TxtPrenom.Location = New System.Drawing.Point(153, 148)
        Me.TxtPrenom.Name = "TxtPrenom"
        Me.TxtPrenom.Size = New System.Drawing.Size(236, 20)
        Me.TxtPrenom.TabIndex = 29
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(105, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Nom :"
        '
        'TxtNom
        '
        Me.TxtNom.Location = New System.Drawing.Point(153, 91)
        Me.TxtNom.Name = "TxtNom"
        Me.TxtNom.Size = New System.Drawing.Size(236, 20)
        Me.TxtNom.TabIndex = 28
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(102, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Code :"
        '
        'BtnAnnuler
        '
        Me.BtnAnnuler.BackColor = System.Drawing.Color.Salmon
        Me.BtnAnnuler.Image = Global.GestionDesFormation.My.Resources.Resources.cancel_16
        Me.BtnAnnuler.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAnnuler.Location = New System.Drawing.Point(403, 338)
        Me.BtnAnnuler.Name = "BtnAnnuler"
        Me.BtnAnnuler.Size = New System.Drawing.Size(67, 29)
        Me.BtnAnnuler.TabIndex = 33
        Me.BtnAnnuler.Text = "&Annuler"
        Me.BtnAnnuler.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAnnuler.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnAnnuler.UseVisualStyleBackColor = False
        '
        'BtnAjouter
        '
        Me.BtnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAjouter.Image = Global.GestionDesFormation.My.Resources.Resources.add_Beneficiaire_16
        Me.BtnAjouter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAjouter.Location = New System.Drawing.Point(323, 338)
        Me.BtnAjouter.Name = "BtnAjouter"
        Me.BtnAjouter.Size = New System.Drawing.Size(74, 29)
        Me.BtnAjouter.TabIndex = 32
        Me.BtnAjouter.Text = "&Ajouter"
        Me.BtnAjouter.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAjouter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnAjouter.UseVisualStyleBackColor = True
        '
        'TxtCode
        '
        Me.TxtCode.Location = New System.Drawing.Point(153, 34)
        Me.TxtCode.Name = "TxtCode"
        Me.TxtCode.Size = New System.Drawing.Size(138, 20)
        Me.TxtCode.TabIndex = 27
        '
        'FrmAjouterBeneficiaire
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(500, 400)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmAjouterBeneficiaire"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FrmAjouterBeneficiaire"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnInitialiser As Button
    Friend WithEvents CmbVille As ComboBox
    Friend WithEvents ChkPlusieurs As CheckBox
    Friend WithEvents Label5 As Label
    Friend WithEvents DateNais As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtPrenom As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtNom As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnAnnuler As Button
    Friend WithEvents BtnAjouter As Button
    Friend WithEvents TxtCode As TextBox
End Class
