Public NotInheritable Class EcranDemarrage
    Private Sub EcranDemarrage_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Timer1.Enabled = True
        Timer1.Interval = 5000
        Timer1.Start()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        Timer1.Enabled = False
        FrmPrincipale.ShowDialog()
    End Sub
End Class
