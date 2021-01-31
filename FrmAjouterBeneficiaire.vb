Imports System.Data.OleDb
Imports Microsoft.SqlServer.Server

Public Class FrmAjouterBeneficiaire
    Public DateNow As Date
    Private Sub BtnAnnuler_Click(sender As Object, e As EventArgs) Handles BtnAnnuler.Click
        FrmPrincipale.Size = New Size(715, 485)
        ChangerForm(FrmGestionBeneficiaire) : FrmPrincipale.Text = "Gestion des beneficiaires"
        Me.Dispose()
    End Sub

    Private Sub BtnAjouter_Click(sender As Object, e As EventArgs) Handles BtnAjouter.Click
        If TxtCode.Text = "" Or TxtNom.Text = "" Or TxtPrenom.Text = "" Or CmbVille.SelectedIndex = -1 Or DateNais.Value = DateNow Then
            MsgBox("Remplir Tous Les Champs !", vbCritical, "Erreur")
            Exit Sub
        End If
        Dim CmdAjtB As New OleDbCommand
        Dim CodeV As Integer
        CodeV = Microsoft.VisualBasic.Right(CmbVille.Text, 4)
        CmdAjtB.CommandText = "Insert Into T_Beneficiaire (CodeB, Nom, Prenom, Ville, Date_nais)
                            Values ('" & TxtCode.Text & "','" & TxtNom.Text & "',
                                    '" & TxtPrenom.Text & "'," & CodeV & ",'" & DateNais.Value & "')"
        CmdAjtB.Connection = CN
        CmdAjtB.ExecuteNonQuery()
        CmdAjtB.Dispose()
        If ChkPlusieurs.Checked = False Then
            FrmPrincipale.Size = New Size(730, 485)
            ChangerForm(FrmGestionBeneficiaire) : FrmPrincipale.Text = "Gestion des beneficiaires"
            FrmGestionBeneficiaire.Remplir_ListeB_Critere("", 0)
            Me.Dispose()
        Else
            TxtCode.Text = Nothing : TxtNom.Text = Nothing : TxtPrenom.Text = Nothing
            CmbVille.SelectedIndex = -1 : DateNais.Value = Date.Now : TxtCode.Focus()
        End If
    End Sub
    Private Sub TxtCode_LostFocus(sender As Object, e As EventArgs) Handles TxtCode.LostFocus
        Dim cmdCheckCode As New OleDbCommand
        cmdCheckCode.CommandText = "Select CodeB From T_Beneficiaire Where CodeB='" & TxtCode.Text.Trim & "'"
        cmdCheckCode.Connection = CN
        Dim DRCheckCode As OleDbDataReader = cmdCheckCode.ExecuteReader
        If DRCheckCode.HasRows = True Then
            MsgBox("le code existe déjà.", vbCritical, "Erreur")
            TxtCode.Text = Nothing : TxtCode.Focus()

        End If
        cmdCheckCode.Dispose() : DRCheckCode.Close()
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
    Private Sub FrmAjouterBeneficiaire_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateNow = DateNais.Value
        Remplir_Combo_Ville(True)
    End Sub

    Private Sub BtnInitialiser_Click(sender As Object, e As EventArgs) Handles BtnInitialiser.Click
        TxtCode.Text = Nothing : TxtNom.Text = Nothing : TxtPrenom.Text = Nothing
        CmbVille.SelectedIndex = -1 : DateNais.Value = Date.Now : DateNow = DateNais.Value
    End Sub
End Class