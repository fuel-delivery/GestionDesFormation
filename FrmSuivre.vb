Imports System.Data.OleDb
Public Class FrmSuivre
    Dim CodeBChoisie As String = ""
    Dim CodeFchoisie As String = ""
    Public BeneficiaireDGVChoisie As String = ""
    Public FormationDGVChoisie As String = ""
    Public CodeBDGVChoisie As String = ""
    Public CodeFDGVChoisie As String = ""
    Private Bitmap As Bitmap
    Private Sub FrmSuivre_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Remplir_Combo_Beneficiaire()
        Remplir_Combo_Formation()
        Remplir_Liste_Suivre(CodeBChoisie, CodeFchoisie)
    End Sub
    Private Sub BtnFermer_Click(sender As Object, e As EventArgs) Handles BtnFermer.Click
        FrmPrincipale.Size = New Size(495, 475)
        ChangerForm(FrmAdmin) : FrmPrincipale.Text = "Administration"
        Me.Dispose()
    End Sub
    Private Sub BtnAjouterFormation_Click(sender As Object, e As EventArgs) Handles BtnAjouterFormation.Click
        FrmPrincipale.Size = New Size(425, 220)
        ChangerForm(FrmAjouterFormation) : FrmPrincipale.Text = "Ajouter une formation"
    End Sub
    Private Sub BtnInitialiser_Click(sender As Object, e As EventArgs) Handles BtnInitialiser.Click
        CmbBeneficiaire.SelectedIndex = -1 : CmbFormation.SelectedIndex = -1 : DGV_Suivre.ClearSelection()
        DateDebutF.Value = Now : DateFinF.Value = Now : CmbDuree.SelectedIndex = -1
        Remplir_Liste_Suivre("", "")
    End Sub
    Private Sub BtnAjouter_Click(sender As Object, e As EventArgs) Handles BtnAjouter.Click
        If CmbBeneficiaire.SelectedIndex = -1 Then
            MsgBox("Choisissez un bénéficiaire", vbCritical, "Erreur")
            Exit Sub
        ElseIf CmbFormation.SelectedIndex = -1 Then
            MsgBox("Choisissez une formation", vbCritical, "Erreur")
            Exit Sub
        ElseIf DateDebutF.Value = DateFinF.Value Then
            MsgBox("Spécifié les dates", vbCritical, "Erreur")
            Exit Sub
        End If
        CodeBChoisie = Beneficiaire_choisie(CmbBeneficiaire.SelectedItem.ToString)
        CodeFchoisie = CmbFormation.SelectedItem.ToString
        If CheckDoubleFormation() = False Then
            Dim CmdSuivre As New OleDbCommand
            CmdSuivre.Connection = CN
            CmdSuivre.CommandText = "Insert Into T_Suivre (CodeF, CodeB, DateDebut , DateFin)
                            Values ('" & CodeFchoisie & "','" & CodeBChoisie & "','" & DateDebutF.Value & "','" & DateFinF.Value & "')"
            CmdSuivre.ExecuteNonQuery()
            CmdSuivre.Dispose()
            Remplir_Liste_Suivre(CodeBChoisie, "")
            CmbFormation.SelectedIndex = -1
            DateDebutF.Value = Date.Now
            DateFinF.Value = Date.Now
        Else
            CmbFormation.SelectedIndex = -1
        End If
    End Sub
    Private Sub CmbBeneficiaire_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbBeneficiaire.SelectedIndexChanged
        If CmbBeneficiaire.SelectedIndex > -1 Then
            Remplir_Liste_Suivre(Beneficiaire_choisie(CmbBeneficiaire.SelectedItem.ToString), CmbFormation.SelectedItem)
        End If
        CmbFormation.SelectedIndex = -1
        DateDebutF.Value = Date.Now
        DateFinF.Value = Date.Now
    End Sub
    Private Sub CmbFormation_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbFormation.SelectedIndexChanged
        If CmbFormation.SelectedIndex >= 0 Then
            Remplir_Lbl_Formation()
            Dim Bchoisie As String = ""
            If CmbBeneficiaire.SelectedIndex > -1 Then
                Bchoisie = CmbBeneficiaire.SelectedItem.ToString()
            End If
            Remplir_Liste_Suivre(Beneficiaire_choisie(Bchoisie), CmbFormation.SelectedItem)
        Else
            LblFormation.Text = Nothing
        End If
    End Sub
    Private Sub DGV_Suivre_SelectionChanged(sender As Object, e As EventArgs) Handles DGV_Suivre.SelectionChanged
        With DGV_Suivre
            If .SelectedRows.Count > 1 Then
                .SelectedRows(.SelectedRows.Count - 1).Selected = False
            End If
            If .SelectedRows.Count = 0 Then
                BeneficiaireDGVChoisie = "" : CodeBDGVChoisie = ""
                FormationDGVChoisie = "" : CodeFDGVChoisie = ""
                BtnModifier.Enabled = False : BtnSupprimer.Enabled = False
            Else
                CodeBDGVChoisie = .Item(Col_CodeB.Index, .CurrentCell.RowIndex).Value
                CodeFDGVChoisie = .Item(Col_CodeF.Index, .CurrentCell.RowIndex).Value
                BeneficiaireDGVChoisie = .Item(Col_Nom.Index, .CurrentCell.RowIndex).Value
                FormationDGVChoisie = .Item(Col_Libelle.Index, .CurrentCell.RowIndex).Value
                BtnModifier.Enabled = True : BtnSupprimer.Enabled = True
                BtnModifier.Focus()
            End If
        End With
    End Sub

    Private Sub BtnSupprimer_Click(sender As Object, e As EventArgs) Handles BtnSupprimer.Click
        Dim Msg As String = "Le bénéficiaire " & BeneficiaireDGVChoisie & " ne participera plus à la formation " & FormationDGVChoisie & ""
        If MsgBox(Msg, vbInformation + MsgBoxStyle.YesNo, "Confirmation de la suppression") = MsgBoxResult.Yes Then
            Dim CmdSuppS As New OleDbCommand
            CmdSuppS.CommandText = ("Update T_Suivre Set Supprimer = True WHERE CodeB='" & CodeBDGVChoisie & "' And CodeF='" & CodeFDGVChoisie & "'")
            CmdSuppS.Connection = CN
            CmdSuppS.ExecuteNonQuery()
            CmdSuppS.Dispose()
            For Each row As DataGridViewRow In DGV_Suivre.SelectedRows
                DGV_Suivre.Rows.Remove(row)
            Next
        Else

        End If
    End Sub
    Sub Remplir_Combo_Beneficiaire()
        Dim CmdComboB = New OleDbCommand()
        CmdComboB.Connection = CN
        CmdComboB.CommandText = "Select * From T_Beneficiaire"
        Dim DRComboB As OleDbDataReader = CmdComboB.ExecuteReader
        'Lire les enregistrements du DR2
        Dim I As Integer = 0
        CmbBeneficiaire.Items.Clear()
        Do While DRComboB.Read() = True
            CmbBeneficiaire.Items.Add(DRComboB("Nom") + Space(1) + DRComboB("Prenom"))
            I = I + 1
        Loop
        CmdComboB.Dispose() : DRComboB.Close()
    End Sub
    Sub Remplir_Lbl_Formation()
        Dim CmdLblF = New OleDbCommand()
        CmdLblF.Connection = CN
        CmdLblF.CommandText = "Select Libelle From T_Formation Where CodeF= '" & CmbFormation.SelectedItem.ToString & "'"
        Dim DRLblF As OleDbDataReader = CmdLblF.ExecuteReader
        DRLblF.Read()
        LblFormation.Text = DRLblF("Libelle").ToString()
        CmdLblF.Dispose() : DRLblF.Close()
    End Sub
    Sub Remplir_Combo_Formation()
        Dim CmdComboF As New OleDbCommand
        CmdComboF.Connection = CN
        CmdComboF.CommandText = "Select * From T_Formation"
        Dim DRComboF As OleDbDataReader = CmdComboF.ExecuteReader
        'Lire les enregistrements du DR2
        Dim I As Integer = 0
        CmbFormation.Items.Clear()
        Do While DRComboF.Read() = True
            CmbFormation.Items.Add(DRComboF("CodeF"))
            I = I + 1
        Loop
        CmdComboF.Dispose() : DRComboF.Close()
    End Sub
    Sub Remplir_Combo_Ville()
        Dim CmdComboVille As New OleDbCommand
        CmdComboVille.Connection = CN
        CmdComboVille.CommandText = "Select * From T_Formation"
        Dim DRComboVille As OleDbDataReader = CmdComboVille.ExecuteReader
        'Lire les enregistrements du DR2
        CmbFormation.Items.Clear()
        Do While DRComboVille.Read() = True
            CmbFormation.Items.Add(DRComboVille("CodeF"))
        Loop
        CmdComboVille.Dispose() : DRComboVille.Close()
    End Sub
    Sub Remplir_Liste_Suivre(ByVal Bchoisie As String, ByVal Fchoisie As String)
        Dim Commandtxt As String = ""
        If Fchoisie = "" And Bchoisie = "" Then
            Commandtxt = "SELECT * From R_Suivre"
        ElseIf Fchoisie = "" Then
            Commandtxt = "SELECT * From R_Suivre WHERE R_Suivre.CodeB='" & Bchoisie & "'"
        ElseIf Bchoisie = "" Then
            Commandtxt = "SELECT * From R_Suivre WHERE R_Suivre.CodeF='" & Fchoisie & "'"
        Else
            Commandtxt = "SELECT * From R_Suivre WHERE R_Suivre.CodeB='" & Bchoisie & "' AND R_Suivre.CodeF='" & Fchoisie & "'"
        End If
        Dim CmdListeSuivre = New OleDbCommand()
        CmdListeSuivre.Connection = CN
        CmdListeSuivre.CommandText = Commandtxt
        Dim DRListeSuivre As OleDbDataReader = CmdListeSuivre.ExecuteReader
        If DRListeSuivre.HasRows = False Then
            DGV_Suivre.Rows.Clear()
            CmdListeSuivre.Dispose() : DRListeSuivre.Close()
            Exit Sub
        End If
        Dim I As Integer = 0
        'Initialiser et vider l'objet DataGridView
        DGV_Suivre.Rows.Clear()
        Do While DRListeSuivre.Read() = True
            With DGV_Suivre
                .Rows.Add()  'Ajouter une nouvelle Ligne
                .Item("Col_CodeB", I).Value = DRListeSuivre("CodeB")
                .Item("Col_CodeF", I).Value = DRListeSuivre("CodeF")
                .Item("Col_Nom", I).Value = DRListeSuivre("Nom")
                .Item("Col_Libelle", I).Value = DRListeSuivre("Libelle")
                .Item("Col_DateDebut", I).Value = FormatDateTime(DRListeSuivre("DateDebut"), DateFormat.ShortDate)
                .Item("Col_DateFin", I).Value = FormatDateTime(DRListeSuivre("DateFin"), DateFormat.ShortDate)
                I = I + 1
            End With
        Loop
        CmdListeSuivre.Dispose() : DRListeSuivre.Close()
    End Sub
    Private Function Beneficiaire_choisie(ByVal Beneficiare As String) As String
        Dim CodeBChoisie As String = ""
        Dim CmdBChoisie = New OleDbCommand()
        CmdBChoisie.Connection = CN
        CmdBChoisie.CommandText = "Select * From T_Beneficiaire"
        Dim DRBChoisie As OleDbDataReader = CmdBChoisie.ExecuteReader
        Do While DRBChoisie.Read()
            If Beneficiare = (DRBChoisie("Nom").ToString + Space(1) + DRBChoisie("Prenom").ToString) Then
                CodeBChoisie = DRBChoisie("CodeB").ToString
            Else
            End If
        Loop
        CmdBChoisie.Dispose() : DRBChoisie.Close()
        Return CodeBChoisie
    End Function
    Private Function CheckDoubleFormation() As Boolean
        Dim ExistDeja As Boolean = False
        Dim CmdCheck As New OleDbCommand
        CmdCheck.Connection = CN
        CmdCheck.CommandText = "Select * From T_Suivre Where T_Suivre.CodeB='" & CodeBChoisie & "' And T_Suivre.CodeF='" & CodeFchoisie & "'"
        Dim DRCheck As OleDbDataReader = CmdCheck.ExecuteReader
        If DRCheck.HasRows = True Then
            MsgBox("Le Beneficiaire " & CmbBeneficiaire.SelectedItem & "  participe déjà à cette formation (" & LblFormation.Text & ").", vbCritical, "Important!")
            ExistDeja = True
        End If
        CmdCheck.Dispose() : DRCheck.Close()
        Return ExistDeja
    End Function

    Private Sub CmbDuree_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbDuree.SelectedIndexChanged
        If CmbDuree.SelectedIndex > -1 Then
            Dim DureeSelectionner As String = Microsoft.VisualBasic.Right(CmbDuree.SelectedItem, 3)
            If Microsoft.VisualBasic.Right(CmbDuree.SelectedItem, 1) = "j" Then
                DateFinF.Value = DateDebutF.Value.AddDays(15)
            ElseIf Microsoft.VisualBasic.Right(CmbDuree.SelectedItem, 1) = "m" Then
                DateFinF.Value = DateDebutF.Value.AddMonths(Microsoft.VisualBasic.Left(DureeSelectionner, 2))
            ElseIf Microsoft.VisualBasic.Right(CmbDuree.SelectedItem, 1) = "a" Then
                DateFinF.Value = DateDebutF.Value.AddYears(Microsoft.VisualBasic.Left(DureeSelectionner, 2))
            End If
            DateFinF.Enabled = False
        Else
            DateFinF.Enabled = True
        End If
    End Sub

    'Private Sub BtnImprimer_Click(sender As Object, e As EventArgs) Handles BtnImprimer.Click
    '    Dim Height As Integer = DGV_Suivre.Height
    '    DGV_Suivre.Height = DGV_Suivre.RowCount * DGV_Suivre.RowTemplate.Height
    '    Bitmap = New Bitmap(Me.DGV_Suivre.Width, Me.DGV_Suivre.Height)
    '    DGV_Suivre.DrawToBitmap(Bitmap, New Rectangle(0, 0, Me.DGV_Suivre.Width, Me.DGV_Suivre.Height))
    '    PrDialog.Document = PrDoc
    '    PrDialog.PrintPreviewControl.Zoom = 1
    '    PrDialog.ShowDialog()
    '    DGV_Suivre.Height = Height
    'End Sub

    'Private Sub prdoc_printpage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrDoc.PrintPage
    '    e.Graphics.DrawImage(Bitmap, 0, 0)
    '    Dim rectprint As RectangleF = e.PageSettings.PrintableArea
    '    If Me.DGV_Suivre.Height - rectprint.Height > 0 Then e.HasMorePages = True
    'End Sub
End Class