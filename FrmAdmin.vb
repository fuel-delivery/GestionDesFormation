Public Class FrmAdmin
    Private Sub LblGestionBeneficiaire_Click(sender As Object, e As EventArgs) Handles LblGestionBeneficiaire.Click
        FrmPrincipale.Size = New Size(715, 485)
        ChangerForm(FrmGestionBeneficiaire) : FrmPrincipale.Text = "Gestion des beneficiaires"
    End Sub

    Private Sub LblGestionFormation_Click(sender As Object, e As EventArgs) Handles LblGestionFormation.Click
        FrmPrincipale.Size = New Size(715, 485)
        ChangerForm(FrmSuivre) : FrmPrincipale.Text = "Gestion des formations"
    End Sub

    Private Sub BtnFermer_Click(sender As Object, e As EventArgs) Handles BtnFermer.Click
        Me.Dispose() : CN.Close() : FrmPrincipale.Dispose()
    End Sub
End Class