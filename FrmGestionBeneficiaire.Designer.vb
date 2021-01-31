<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmGestionBeneficiaire
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmGestionBeneficiaire))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DGV_Beneficiaires = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnFermer = New System.Windows.Forms.Button()
        Me.BtnImprimer = New System.Windows.Forms.Button()
        Me.BtnSupprimer = New System.Windows.Forms.Button()
        Me.BtnModifier = New System.Windows.Forms.Button()
        Me.BtnAjouter = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnInitialiser = New System.Windows.Forms.Button()
        Me.CmbVille = New System.Windows.Forms.ComboBox()
        Me.TxtRechercher = New System.Windows.Forms.TextBox()
        Me.PrDialog = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrDoc = New System.Drawing.Printing.PrintDocument()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DGV_Beneficiaires, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DGV_Beneficiaires)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox2.Location = New System.Drawing.Point(0, 60)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(700, 324)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Liste :"
        '
        'DGV_Beneficiaires
        '
        Me.DGV_Beneficiaires.AllowUserToAddRows = False
        Me.DGV_Beneficiaires.AllowUserToDeleteRows = False
        Me.DGV_Beneficiaires.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV_Beneficiaires.BackgroundColor = System.Drawing.Color.White
        Me.DGV_Beneficiaires.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Beneficiaires.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV_Beneficiaires.Location = New System.Drawing.Point(3, 16)
        Me.DGV_Beneficiaires.Name = "DGV_Beneficiaires"
        Me.DGV_Beneficiaires.ReadOnly = True
        Me.DGV_Beneficiaires.Size = New System.Drawing.Size(694, 305)
        Me.DGV_Beneficiaires.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.BtnFermer)
        Me.GroupBox1.Controls.Add(Me.BtnImprimer)
        Me.GroupBox1.Controls.Add(Me.BtnSupprimer)
        Me.GroupBox1.Controls.Add(Me.BtnModifier)
        Me.GroupBox1.Controls.Add(Me.BtnAjouter)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(700, 60)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        '
        'BtnFermer
        '
        Me.BtnFermer.BackColor = System.Drawing.Color.Salmon
        Me.BtnFermer.Image = Global.GestionDesFormation.My.Resources.Resources.cancel_16
        Me.BtnFermer.Location = New System.Drawing.Point(621, 19)
        Me.BtnFermer.Name = "BtnFermer"
        Me.BtnFermer.Size = New System.Drawing.Size(66, 29)
        Me.BtnFermer.TabIndex = 8
        Me.BtnFermer.Text = "&Fermer"
        Me.BtnFermer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnFermer.UseVisualStyleBackColor = False
        '
        'BtnImprimer
        '
        Me.BtnImprimer.Image = Global.GestionDesFormation.My.Resources.Resources.printer_16
        Me.BtnImprimer.Location = New System.Drawing.Point(316, 19)
        Me.BtnImprimer.Name = "BtnImprimer"
        Me.BtnImprimer.Size = New System.Drawing.Size(84, 29)
        Me.BtnImprimer.TabIndex = 7
        Me.BtnImprimer.Text = "&Imprimer"
        Me.BtnImprimer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnImprimer.UseVisualStyleBackColor = True
        '
        'BtnSupprimer
        '
        Me.BtnSupprimer.Image = Global.GestionDesFormation.My.Resources.Resources.add_trash_161
        Me.BtnSupprimer.Location = New System.Drawing.Point(200, 19)
        Me.BtnSupprimer.Name = "BtnSupprimer"
        Me.BtnSupprimer.Size = New System.Drawing.Size(84, 29)
        Me.BtnSupprimer.TabIndex = 5
        Me.BtnSupprimer.Text = "&Supprimer"
        Me.BtnSupprimer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnSupprimer.UseVisualStyleBackColor = True
        '
        'BtnModifier
        '
        Me.BtnModifier.CausesValidation = False
        Me.BtnModifier.Image = Global.GestionDesFormation.My.Resources.Resources.Beneficiaire___Modifier_16
        Me.BtnModifier.Location = New System.Drawing.Point(110, 19)
        Me.BtnModifier.Name = "BtnModifier"
        Me.BtnModifier.Size = New System.Drawing.Size(84, 29)
        Me.BtnModifier.TabIndex = 4
        Me.BtnModifier.Text = "&Modifier"
        Me.BtnModifier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnModifier.UseVisualStyleBackColor = True
        '
        'BtnAjouter
        '
        Me.BtnAjouter.CausesValidation = False
        Me.BtnAjouter.Image = Global.GestionDesFormation.My.Resources.Resources.add_Beneficiaire_161
        Me.BtnAjouter.Location = New System.Drawing.Point(21, 19)
        Me.BtnAjouter.Name = "BtnAjouter"
        Me.BtnAjouter.Size = New System.Drawing.Size(84, 29)
        Me.BtnAjouter.TabIndex = 6
        Me.BtnAjouter.TabStop = False
        Me.BtnAjouter.Text = "&Ajouter"
        Me.BtnAjouter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnAjouter.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.BtnInitialiser)
        Me.GroupBox3.Controls.Add(Me.CmbVille)
        Me.GroupBox3.Controls.Add(Me.TxtRechercher)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox3.Location = New System.Drawing.Point(0, 384)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(700, 79)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Rechercher par :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(64, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Nom :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(339, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Ville :"
        '
        'BtnInitialiser
        '
        Me.BtnInitialiser.Image = Global.GestionDesFormation.My.Resources.Resources.Reset_16
        Me.BtnInitialiser.Location = New System.Drawing.Point(621, 24)
        Me.BtnInitialiser.Name = "BtnInitialiser"
        Me.BtnInitialiser.Size = New System.Drawing.Size(30, 30)
        Me.BtnInitialiser.TabIndex = 3
        Me.BtnInitialiser.UseVisualStyleBackColor = True
        '
        'CmbVille
        '
        Me.CmbVille.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbVille.FormattingEnabled = True
        Me.CmbVille.Location = New System.Drawing.Point(394, 29)
        Me.CmbVille.Name = "CmbVille"
        Me.CmbVille.Size = New System.Drawing.Size(185, 21)
        Me.CmbVille.TabIndex = 2
        '
        'TxtRechercher
        '
        Me.TxtRechercher.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TxtRechercher.Location = New System.Drawing.Point(123, 29)
        Me.TxtRechercher.Name = "TxtRechercher"
        Me.TxtRechercher.Size = New System.Drawing.Size(185, 20)
        Me.TxtRechercher.TabIndex = 1
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
        'FrmGestionBeneficiaire
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkOrange
        Me.ClientSize = New System.Drawing.Size(700, 460)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmGestionBeneficiaire"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DGV_Beneficiaires, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents RdbNom As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RdbVille As RadioButton
    Friend WithEvents DGV_Beneficiaires As DataGridView
    Friend WithEvents BtnImprimer As Button
    Friend WithEvents BtnAjouter As Button
    Friend WithEvents BtnModifier As Button
    Friend WithEvents BtnSupprimer As Button
    Friend WithEvents BtnFermer As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnInitialiser As Button
    Friend WithEvents CmbVille As ComboBox
    Friend WithEvents TxtRechercher As TextBox
    Friend WithEvents PrDialog As PrintPreviewDialog
    Friend WithEvents PrDoc As Printing.PrintDocument
End Class
