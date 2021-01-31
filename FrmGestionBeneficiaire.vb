Imports System.Data.OleDb
Public Class FrmGestionBeneficiaire
    Public BeneficiaireChoisie As String = ""
    Private Bitmap As Bitmap
    Private Sub BtnAjouter_Click(sender As Object, e As EventArgs) Handles BtnAjouter.Click
        FrmPrincipale.Size = New Size(525, 430)
        ChangerForm(FrmAjouterBeneficiaire) : FrmPrincipale.Text = "Ajouter un beneficiaire"
    End Sub

    Private Sub BtnFermer_Click(sender As Object, e As EventArgs) Handles BtnFermer.Click
        FrmPrincipale.Size = New Size(495, 475)
        ChangerForm(FrmAdmin) : FrmPrincipale.Text = "Administration"
        Me.Dispose()
    End Sub
    Private Sub FrmGestionBeneficiaire_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Remplir_ListeB_Critere("", 0) : Remplir_Combo_Ville(False)
    End Sub

    Private Sub BtnSupprimer_Click(sender As Object, e As EventArgs) Handles BtnSupprimer.Click
        Dim Msg As String = "êtes-vous sûr de vouloir supprimer le bénéficiaire qui a le code: '" & BeneficiaireChoisie & "'"
        If MsgBox(Msg, vbInformation + MsgBoxStyle.YesNo, "Confirmation de la suppression") = MsgBoxResult.Yes Then
            Dim CmdSuppB As New OleDbCommand
            CmdSuppB.CommandText = ("Update T_Beneficiaire Set Supprimer = True WHERE CodeB='" & BeneficiaireChoisie & "'")
            CmdSuppB.Connection = CN
            CmdSuppB.ExecuteNonQuery()
            CmdSuppB.Dispose()
            For Each row As DataGridViewRow In DGV_Beneficiaires.SelectedRows
                DGV_Beneficiaires.Rows.Remove(row)
            Next
        End If
    End Sub

    Sub Remplir_Combo_Ville(ByVal Tous As Boolean)
        Dim Requete As String
        If Tous = True Then
            Requete = "Select * From T_Ville"
        Else
            Requete = "Select *  From R_Villes_Existe"
        End If
        Dim CmdComboVille As New OleDbCommand
        CmdComboVille.Connection = CN
        CmdComboVille.CommandText = Requete
        Dim DRComboVille As OleDbDataReader = CmdComboVille.ExecuteReader
        'Lire les enregistrements du DR2
        CmbVille.Items.Clear()
        Do While DRComboVille.Read() = True
            CmbVille.Items.Add(DRComboVille("Libelle") & Space(100) & DRComboVille("CodeV"))
        Loop
        CmdComboVille.Dispose() : DRComboVille.Close()
    End Sub

    Sub Remplir_ListeB_Critere(ByVal Nom As String, ByVal Ville As Integer)
        Dim Requete As String
        Dim NomDonner As String = "%" + Nom.Trim + "%"
        If Ville <> 0 Then
            If Nom <> "" Then
                Requete = "SELECT * From R_Beneficiaire Where R_Beneficiaire.CodeV = " & Ville & " And R_Beneficiaire.Nom Like '" & NomDonner & "'"
            Else
                Requete = "SELECT * From R_Beneficiaire WHERE R_Beneficiaire.CodeV = " & Ville & ""
            End If
        Else
            If Nom <> "" Then
                Requete = "SELECT * From R_Beneficiaire WHERE R_Beneficiaire.Nom Like '" & NomDonner & "'"
            Else
                Requete = "SELECT * From R_Beneficiaire"
            End If
        End If
        Dim CmdListeB = New OleDbCommand(Requete, CN)
        Dim DRListeB As OleDbDataReader = CmdListeB.ExecuteReader
        DGV_Beneficiaires.Rows.Clear()
        If DRListeB.HasRows = True Then
            'Dim dtBeneficiaire As New DataTable
            'dtBeneficiaire.Load(DRListeB)
            'DGV_Beneficiaires.DataSource = dtBeneficiaire
            Dim I As Integer = 0
            Do While DRListeB.Read() = True
                With DGV_Beneficiaires
                    .Rows.Add()
                    .Item("Col_CodeB", I).Value = DRListeB("CodeB")
                    .Item("Col_Nom", I).Value = DRListeB("Nom")
                    .Item("Col_Prenom", I).Value = DRListeB("Prenom")
                    .Item("Col_Date_nais", I).Value = FormatDateTime(DRListeB("Date_nais"), DateFormat.ShortDate)
                    .Item("Col_Ville", I).Value = DRListeB("Libelle")
                    I = I + 1
                End With
            Loop
        Else
            MsgBox("Le critère spécifié ne correspond à aucun bénéficiaire!", vbInformation, "Information")
            TxtRechercher.Text = "" : TxtRechercher.Focus()
            CmdListeB.Dispose() : DRListeB.Close()
            Exit Sub
        End If
        CmdListeB.Dispose() : DRListeB.Close()
    End Sub

    Private Sub RdbNom_CheckedChanged(sender As Object, e As EventArgs) Handles RdbNom.CheckedChanged
        TxtRechercher.Text = Nothing
        If RdbNom.Checked = True Then TxtRechercher.Focus()
    End Sub

    Private Sub RdbVille_CheckedChanged(sender As Object, e As EventArgs) Handles RdbVille.CheckedChanged
        TxtRechercher.Text = Nothing
        If RdbVille.Checked = True Then TxtRechercher.Focus()
    End Sub

    Private Sub BtnModifier_Click(sender As Object, e As EventArgs) Handles BtnModifier.Click
        FrmPrincipale.Size = New Size(525, 430)
        ChangerForm(FrmModifierBeneficiaire) : FrmPrincipale.Text = "Modifier Le Beneficiaire : " & BeneficiaireChoisie
    End Sub

    Private Sub DGV_Beneficiaires_SelectionChanged(sender As Object, e As EventArgs) Handles DGV_Beneficiaires.SelectionChanged
        With DGV_Beneficiaires
            If .SelectedRows.Count > 1 Then
                .SelectedRows(.SelectedRows.Count - 1).Selected = False
            End If
            If .SelectedRows.Count = 0 Then
                BeneficiaireChoisie = "" : BtnModifier.Enabled = False : BtnSupprimer.Enabled = False
            Else
                BeneficiaireChoisie = .Item(1, .CurrentCell.RowIndex).Value
                BtnModifier.Enabled = True : BtnSupprimer.Enabled = True
                BtnModifier.Focus()
            End If
        End With
    End Sub

    Private Sub TxtRechercher_TextChanged(sender As Object, e As EventArgs) Handles TxtRechercher.TextChanged
        If TxtRechercher.Text <> "" Then
            If CmbVille.SelectedIndex > -1 Then
                Dim CodeV As Integer
                CodeV = Microsoft.VisualBasic.Right(CmbVille.Text, 4)
                Remplir_ListeB_Critere(TxtRechercher.Text, CodeV)
            Else
                Remplir_ListeB_Critere(TxtRechercher.Text, 0)
            End If
        ElseIf TxtRechercher.Text = "" Then
            If CmbVille.SelectedIndex > -1 Then
                Dim CodeV As Integer
                CodeV = Microsoft.VisualBasic.Right(CmbVille.Text, 4)
                Remplir_ListeB_Critere("", CodeV)
            Else
                Remplir_ListeB_Critere("", 0)
            End If
        End If
    End Sub

    Private Sub CmbVille_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbVille.SelectedIndexChanged
        If TxtRechercher.Text <> "" Then
            If CmbVille.SelectedIndex > -1 Then
                Dim CodeV As Integer
                CodeV = Microsoft.VisualBasic.Right(CmbVille.Text, 4)
                Remplir_ListeB_Critere(TxtRechercher.Text, CodeV)
            Else
                Remplir_ListeB_Critere(TxtRechercher.Text, 0)
            End If
        ElseIf TxtRechercher.Text = "" Then
            If CmbVille.SelectedIndex > -1 Then
                Dim CodeV As Integer
                CodeV = Microsoft.VisualBasic.Right(CmbVille.Text, 4)
                Remplir_ListeB_Critere("", CodeV)
            Else
                Remplir_ListeB_Critere("", 0)
            End If
        End If
    End Sub

    Private Sub BtnInitialiser_Click(sender As Object, e As EventArgs) Handles BtnInitialiser.Click
        TxtRechercher.Text = "" : CmbVille.SelectedIndex = -1 : DGV_Beneficiaires.ClearSelection()
    End Sub
    'Private Sub BtnImprimer_Click(sender As Object, e As EventArgs) Handles BtnImprimer.Click
    '    Dim Height As Integer = DGV_Beneficiaires.Height
    '    DGV_Beneficiaires.Height = DGV_Beneficiaires.RowCount * DGV_Beneficiaires.RowTemplate.Height
    '    Bitmap = New Bitmap(Me.DGV_Beneficiaires.Width, Me.DGV_Beneficiaires.Height)
    '    DGV_Beneficiaires.DrawToBitmap(Bitmap, New Rectangle(0, 0, Me.DGV_Beneficiaires.Width, Me.DGV_Beneficiaires.Height))
    '    PrDialog.Document = PrDoc
    '    PrDialog.PrintPreviewControl.Zoom = 1
    '    PrDialog.ShowDialog()
    '    DGV_Beneficiaires.Height = Height
    'End Sub
    'Private Sub PrDoc_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrDoc.PrintPage
    '    e.Graphics.DrawImage(Bitmap, 0, 0)
    '    Dim rectPrint As RectangleF = e.PageSettings.PrintableArea
    '    If Me.DGV_Beneficiaires.Height - rectPrint.Height > 0 Then e.HasMorePages = True
    'End Sub
End Class