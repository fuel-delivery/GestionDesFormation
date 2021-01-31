<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmAjouterFormation
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ChkPlusieurs = New System.Windows.Forms.CheckBox()
        Me.BtnAnnuler = New System.Windows.Forms.Button()
        Me.BtnAjouter = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtNom = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtCode = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.DarkOrange
        Me.GroupBox1.Controls.Add(Me.ChkPlusieurs)
        Me.GroupBox1.Controls.Add(Me.BtnAnnuler)
        Me.GroupBox1.Controls.Add(Me.BtnAjouter)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TxtNom)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TxtCode)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(400, 200)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'ChkPlusieurs
        '
        Me.ChkPlusieurs.AutoSize = True
        Me.ChkPlusieurs.Location = New System.Drawing.Point(157, 149)
        Me.ChkPlusieurs.Name = "ChkPlusieurs"
        Me.ChkPlusieurs.Size = New System.Drawing.Size(68, 17)
        Me.ChkPlusieurs.TabIndex = 20
        Me.ChkPlusieurs.Text = "Plusieurs"
        Me.ChkPlusieurs.UseVisualStyleBackColor = True
        '
        'BtnAnnuler
        '
        Me.BtnAnnuler.BackColor = System.Drawing.Color.Salmon
        Me.BtnAnnuler.Image = Global.GestionDesFormation.My.Resources.Resources.cancel_16
        Me.BtnAnnuler.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAnnuler.Location = New System.Drawing.Point(300, 143)
        Me.BtnAnnuler.Name = "BtnAnnuler"
        Me.BtnAnnuler.Size = New System.Drawing.Size(72, 29)
        Me.BtnAnnuler.TabIndex = 22
        Me.BtnAnnuler.Text = "&Annuler"
        Me.BtnAnnuler.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAnnuler.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnAnnuler.UseVisualStyleBackColor = False
        '
        'BtnAjouter
        '
        Me.BtnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAjouter.Image = Global.GestionDesFormation.My.Resources.Resources.add_fr_16
        Me.BtnAjouter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAjouter.Location = New System.Drawing.Point(228, 143)
        Me.BtnAjouter.Name = "BtnAjouter"
        Me.BtnAjouter.Size = New System.Drawing.Size(69, 29)
        Me.BtnAjouter.TabIndex = 21
        Me.BtnAjouter.Text = "&Ajouter"
        Me.BtnAjouter.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAjouter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnAjouter.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 13)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Nom de la formation :"
        '
        'TxtNom
        '
        Me.TxtNom.Location = New System.Drawing.Point(142, 86)
        Me.TxtNom.Multiline = True
        Me.TxtNom.Name = "TxtNom"
        Me.TxtNom.Size = New System.Drawing.Size(236, 29)
        Me.TxtNom.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 13)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Code du Formation :"
        '
        'TxtCode
        '
        Me.TxtCode.Location = New System.Drawing.Point(142, 29)
        Me.TxtCode.Multiline = True
        Me.TxtCode.Name = "TxtCode"
        Me.TxtCode.Size = New System.Drawing.Size(86, 29)
        Me.TxtCode.TabIndex = 18
        '
        'FrmAjouterFormation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(400, 200)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmAjouterFormation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FrmAjouterFormation"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ChkPlusieurs As CheckBox
    Friend WithEvents BtnAnnuler As Button
    Friend WithEvents BtnAjouter As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtNom As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtCode As TextBox
End Class
