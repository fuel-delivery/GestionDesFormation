Imports System.ComponentModel

Public Class FrmPrincipale
    'Public dx As Integer
    'Public dy As Integer
    Private Sub FrmPrincipale_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Size = New Size(410, 290)
        ChangerForm(FrmLogin)
        'dx = My.Computer.Screen.Bounds.Width
        'dy = My.Computer.Screen.Bounds.Height
    End Sub
    Private Sub FrmPrincipale_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        EcranDemarrage.Close()
    End Sub

    Private Sub FrmPrincipale_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        'Dim x, y As Integer

        'x = Me.Width / 2

        'y = Me.Height / 2

        'Me.Location = New Point(dx / 2 - x, dy / 2 - y)
        Me.CenterToScreen()
    End Sub
End Class
