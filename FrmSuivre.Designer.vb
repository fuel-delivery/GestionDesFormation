<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmSuivre
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSuivre))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnFermer = New System.Windows.Forms.Button()
        Me.BtnImprimer = New System.Windows.Forms.Button()
        Me.BtnSupprimer = New System.Windows.Forms.Button()
        Me.BtnModifier = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DGV_Suivre = New System.Windows.Forms.DataGridView()
        Me.Col_CodeB = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_Nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_Libelle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Etat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_CodeF = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_DateDebut = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_DateFin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CmbDuree = New System.Windows.Forms.ComboBox()
        Me.BtnInitialiser = New System.Windows.Forms.Button()
        Me.BtnAjouterFormation = New System.Windows.Forms.Button()
        Me.DateFinF = New System.Windows.Forms.DateTimePicker()
        Me.DateDebutF = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BtnAjouter = New System.Windows.Forms.Button()
        Me.LblFormation = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CmbFormation = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CmbBeneficiaire = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PrDoc = New System.Drawing.Printing.PrintDocument()
        Me.PrDialog = New System.Windows.Forms.PrintPreviewDialog()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DGV_Suivre, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.BtnFermer)
        Me.GroupBox1.Controls.Add(Me.BtnImprimer)
        Me.GroupBox1.Controls.Add(Me.BtnSupprimer)
        Me.GroupBox1.Controls.Add(Me.BtnModifier)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(700, 53)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        '
        'BtnFermer
        '
        Me.BtnFermer.BackColor = System.Drawing.Color.Salmon
        Me.BtnFermer.Image = Global.GestionDesFormation.My.Resources.Resources.cancel_16
        Me.BtnFermer.Location = New System.Drawing.Point(619, 12)
        Me.BtnFermer.Name = "BtnFermer"
        Me.BtnFermer.Size = New System.Drawing.Size(66, 29)
        Me.BtnFermer.TabIndex = 9
        Me.BtnFermer.Text = "&Fermer"
        Me.BtnFermer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnFermer.UseVisualStyleBackColor = False
        '
        'BtnImprimer
        '
        Me.BtnImprimer.Image = Global.GestionDesFormation.My.Resources.Resources.printer_16
        Me.BtnImprimer.Location = New System.Drawing.Point(213, 12)
        Me.BtnImprimer.Name = "BtnImprimer"
        Me.BtnImprimer.Size = New System.Drawing.Size(84, 29)
        Me.BtnImprimer.TabIndex = 12
        Me.BtnImprimer.Text = "&Imprimer"
        Me.BtnImprimer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnImprimer.UseVisualStyleBackColor = True
        '
        'BtnSupprimer
        '
        Me.BtnSupprimer.Image = Global.GestionDesFormation.My.Resources.Resources.add_trash_16
        Me.BtnSupprimer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSupprimer.Location = New System.Drawing.Point(105, 12)
        Me.BtnSupprimer.Name = "BtnSupprimer"
        Me.BtnSupprimer.Size = New System.Drawing.Size(84, 29)
        Me.BtnSupprimer.TabIndex = 11
        Me.BtnSupprimer.Text = "&Supprimer"
        Me.BtnSupprimer.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSupprimer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnSupprimer.UseVisualStyleBackColor = True
        '
        'BtnModifier
        '
        Me.BtnModifier.Image = Global.GestionDesFormation.My.Resources.Resources.bookmark_16
        Me.BtnModifier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnModifier.Location = New System.Drawing.Point(15, 12)
        Me.BtnModifier.Name = "BtnModifier"
        Me.BtnModifier.Size = New System.Drawing.Size(84, 29)
        Me.BtnModifier.TabIndex = 10
        Me.BtnModifier.Text = "&Modifier"
        Me.BtnModifier.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnModifier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnModifier.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.DGV_Suivre)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox2.Location = New System.Drawing.Point(0, 53)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(700, 258)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Liste :"
        '
        'DGV_Suivre
        '
        Me.DGV_Suivre.AllowUserToAddRows = False
        Me.DGV_Suivre.AllowUserToDeleteRows = False
        Me.DGV_Suivre.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV_Suivre.BackgroundColor = System.Drawing.Color.White
        Me.DGV_Suivre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Suivre.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Col_CodeB, Me.Col_Nom, Me.Col_Libelle, Me.Etat, Me.Col_CodeF, Me.Col_DateDebut, Me.Col_DateFin})
        Me.DGV_Suivre.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV_Suivre.Location = New System.Drawing.Point(3, 16)
        Me.DGV_Suivre.Name = "DGV_Suivre"
        Me.DGV_Suivre.ReadOnly = True
        Me.DGV_Suivre.Size = New System.Drawing.Size(694, 239)
        Me.DGV_Suivre.TabIndex = 1
        '
        'Col_CodeB
        '
        Me.Col_CodeB.HeaderText = "Code"
        Me.Col_CodeB.Name = "Col_CodeB"
        Me.Col_CodeB.ReadOnly = True
        '
        'Col_Nom
        '
        Me.Col_Nom.HeaderText = "Nom"
        Me.Col_Nom.Name = "Col_Nom"
        Me.Col_Nom.ReadOnly = True
        '
        'Col_Libelle
        '
        Me.Col_Libelle.HeaderText = "Formation"
        Me.Col_Libelle.Name = "Col_Libelle"
        Me.Col_Libelle.ReadOnly = True
        '
        'Etat
        '
        Me.Etat.HeaderText = "Col_Etat"
        Me.Etat.Name = "Etat"
        Me.Etat.ReadOnly = True
        '
        'Col_CodeF
        '
        Me.Col_CodeF.HeaderText = "Code Formation"
        Me.Col_CodeF.Name = "Col_CodeF"
        Me.Col_CodeF.ReadOnly = True
        Me.Col_CodeF.Visible = False
        '
        'Col_DateDebut
        '
        Me.Col_DateDebut.HeaderText = "Date Debut"
        Me.Col_DateDebut.Name = "Col_DateDebut"
        Me.Col_DateDebut.ReadOnly = True
        '
        'Col_DateFin
        '
        Me.Col_DateFin.HeaderText = "Date Fin"
        Me.Col_DateFin.Name = "Col_DateFin"
        Me.Col_DateFin.ReadOnly = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.CmbDuree)
        Me.GroupBox3.Controls.Add(Me.BtnInitialiser)
        Me.GroupBox3.Controls.Add(Me.BtnAjouterFormation)
        Me.GroupBox3.Controls.Add(Me.DateFinF)
        Me.GroupBox3.Controls.Add(Me.DateDebutF)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.BtnAjouter)
        Me.GroupBox3.Controls.Add(Me.LblFormation)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.CmbFormation)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.CmbBeneficiaire)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox3.Location = New System.Drawing.Point(0, 311)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(700, 153)
        Me.GroupBox3.TabIndex = 9
        Me.GroupBox3.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(347, 104)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Durée (Mois) :"
        '
        'CmbDuree
        '
        Me.CmbDuree.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbDuree.FormattingEnabled = True
        Me.CmbDuree.Items.AddRange(New Object() {"15 jours                  15j", "Un mois                  01m", "02 mois                  02m", "03 mois                  03m", "04 mois                  04m", "05 mois                  05m", "06 mois                  06m", "07 mois                  07m", "08 mois                  08m", "09 mois                  09m", "10 mois                  10m", "11 mois                  11m", "Une année                  01a", "02 ans                  02a"})
        Me.CmbDuree.Location = New System.Drawing.Point(436, 100)
        Me.CmbDuree.Name = "CmbDuree"
        Me.CmbDuree.Size = New System.Drawing.Size(65, 21)
        Me.CmbDuree.TabIndex = 6
        '
        'BtnInitialiser
        '
        Me.BtnInitialiser.Image = Global.GestionDesFormation.My.Resources.Resources.Reset_16
        Me.BtnInitialiser.Location = New System.Drawing.Point(632, 104)
        Me.BtnInitialiser.Name = "BtnInitialiser"
        Me.BtnInitialiser.Size = New System.Drawing.Size(29, 29)
        Me.BtnInitialiser.TabIndex = 8
        Me.BtnInitialiser.UseVisualStyleBackColor = True
        '
        'BtnAjouterFormation
        '
        Me.BtnAjouterFormation.Image = Global.GestionDesFormation.My.Resources.Resources.add_book_16
        Me.BtnAjouterFormation.Location = New System.Drawing.Point(191, 55)
        Me.BtnAjouterFormation.Name = "BtnAjouterFormation"
        Me.BtnAjouterFormation.Size = New System.Drawing.Size(25, 24)
        Me.BtnAjouterFormation.TabIndex = 3
        Me.BtnAjouterFormation.UseVisualStyleBackColor = True
        '
        'DateFinF
        '
        Me.DateFinF.Location = New System.Drawing.Point(436, 57)
        Me.DateFinF.Name = "DateFinF"
        Me.DateFinF.Size = New System.Drawing.Size(181, 20)
        Me.DateFinF.TabIndex = 5
        '
        'DateDebutF
        '
        Me.DateDebutF.Location = New System.Drawing.Point(436, 15)
        Me.DateDebutF.Name = "DateDebutF"
        Me.DateDebutF.Size = New System.Drawing.Size(181, 20)
        Me.DateDebutF.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(367, 60)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Date Fin :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(352, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 13)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Date Debut :"
        '
        'BtnAjouter
        '
        Me.BtnAjouter.BackColor = System.Drawing.Color.White
        Me.BtnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAjouter.Image = Global.GestionDesFormation.My.Resources.Resources.add_16
        Me.BtnAjouter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAjouter.Location = New System.Drawing.Point(560, 104)
        Me.BtnAjouter.Name = "BtnAjouter"
        Me.BtnAjouter.Size = New System.Drawing.Size(66, 29)
        Me.BtnAjouter.TabIndex = 7
        Me.BtnAjouter.Text = "&Ajouter"
        Me.BtnAjouter.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAjouter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnAjouter.UseVisualStyleBackColor = False
        '
        'LblFormation
        '
        Me.LblFormation.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LblFormation.Location = New System.Drawing.Point(115, 98)
        Me.LblFormation.Name = "LblFormation"
        Me.LblFormation.Size = New System.Drawing.Size(205, 25)
        Me.LblFormation.TabIndex = 20
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(47, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Formation :"
        '
        'CmbFormation
        '
        Me.CmbFormation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbFormation.FormattingEnabled = True
        Me.CmbFormation.Location = New System.Drawing.Point(115, 57)
        Me.CmbFormation.Name = "CmbFormation"
        Me.CmbFormation.Size = New System.Drawing.Size(69, 21)
        Me.CmbFormation.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(4, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Code du Formation :"
        '
        'CmbBeneficiaire
        '
        Me.CmbBeneficiaire.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbBeneficiaire.FormattingEnabled = True
        Me.CmbBeneficiaire.Location = New System.Drawing.Point(115, 15)
        Me.CmbBeneficiaire.Name = "CmbBeneficiaire"
        Me.CmbBeneficiaire.Size = New System.Drawing.Size(205, 21)
        Me.CmbBeneficiaire.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(71, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Nom :"
        '
        'PrDialog
        '
        Me.PrDialog.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrDialog.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrDialog.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrDialog.Enabled = True
        Me.PrDialog.Icon = CType(resources.GetObject("PrDialog.Icon"), System.Drawing.Icon)
        Me.PrDialog.Name = "PrDialog"
        Me.PrDialog.Visible = False
        '
        'FrmSuivre
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkOrange
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(700, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmSuivre"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DGV_Suivre, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BtnFermer As Button
    Friend WithEvents BtnImprimer As Button
    Friend WithEvents BtnSupprimer As Button
    Friend WithEvents BtnModifier As Button
    Friend WithEvents BtnAjouter As Button
    Friend WithEvents DGV_Suivre As DataGridView
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents DateFinF As DateTimePicker
    Friend WithEvents DateDebutF As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents LblFormation As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents CmbFormation As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents CmbBeneficiaire As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnAjouterFormation As Button
    Friend WithEvents BtnInitialiser As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents CmbDuree As ComboBox
    Friend WithEvents PrDoc As Printing.PrintDocument
    Friend WithEvents PrDialog As PrintPreviewDialog
    Friend WithEvents Col_CodeB As DataGridViewTextBoxColumn
    Friend WithEvents Col_Nom As DataGridViewTextBoxColumn
    Friend WithEvents Col_Libelle As DataGridViewTextBoxColumn
    Friend WithEvents Etat As DataGridViewTextBoxColumn
    Friend WithEvents Col_CodeF As DataGridViewTextBoxColumn
    Friend WithEvents Col_DateDebut As DataGridViewTextBoxColumn
    Friend WithEvents Col_DateFin As DataGridViewTextBoxColumn
End Class
