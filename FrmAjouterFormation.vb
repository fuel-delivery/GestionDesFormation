Imports System.Data.OleDb
Public Class FrmAjouterFormation
    Private Sub BtnAnnuler_Click(sender As Object, e As EventArgs) Handles BtnAnnuler.Click
        FrmPrincipale.Size = New Size(715, 485)
        ChangerForm(FrmSuivre) : FrmPrincipale.Text = "Gestion des formations"
        Me.Dispose()
    End Sub

    Private Sub BtnAjouter_Click(sender As Object, e As EventArgs) Handles BtnAjouter.Click
        If TxtCode.Text = Nothing Or TxtNom.Text = Nothing Then
            MsgBox("Remplir tous les zones de texte.", vbCritical, "Important!")
            If TxtCode.Text = Nothing Then
                TxtCode.Focus() : Exit Sub
            Else
                TxtNom.Focus() : Exit Sub
            End If
        Else
            Dim NomFormation As String = Chr(34) & TxtNom.Text & Chr(34)
            Dim CmdAjtF As New OleDbCommand
            CmdAjtF.CommandText = "Insert Into T_Formation (CodeF, Libelle)
                            Values ('" & TxtCode.Text & "'," & NomFormation & ")"
            CmdAjtF.Connection = CN
            CmdAjtF.ExecuteNonQuery()
            CmdAjtF.Dispose()
        End If
        If ChkPlusieurs.Checked = False Then
            FrmPrincipale.Size = New Size(715, 485)
            ChangerForm(FrmSuivre) : FrmPrincipale.Text = "Gestion des formations"
            Me.Dispose()
        Else
            TxtCode.Text = Nothing : TxtNom.Text = Nothing
        End If
        FrmSuivre.Remplir_Combo_Formation()
    End Sub
End Class