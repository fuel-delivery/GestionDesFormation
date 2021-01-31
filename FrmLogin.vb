Imports System.Data.OleDb
Public Class FrmLogin
    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EcranDemarrage.Hide()
        FrmPrincipale.Text = "Connexion"
        Se_connecter()
    End Sub

    Private Sub TxtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnLogin.PerformClick()
        End If
    End Sub

    Private Sub BtnAfficherMP_MouseHover(sender As Object, e As EventArgs) Handles BtnAfficherMP.MouseHover
        TxtPassword.UseSystemPasswordChar = False
    End Sub

    Private Sub BtnAfficherMP_MouseLeave(sender As Object, e As EventArgs) Handles BtnAfficherMP.MouseLeave
        TxtPassword.UseSystemPasswordChar = True
    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Dim CmdLogin As New OleDbCommand
        CmdLogin.CommandText = "Select * FROM T_Admin WHERE Login='" & TxtLogin.Text & "'"
        CmdLogin.Connection = CN
        Dim DRLogin As OleDbDataReader = CmdLogin.ExecuteReader
        DRLogin.Read()
        If DRLogin.HasRows = True Then
            If DRLogin("Password") <> TxtPassword.Text Then
                MsgBox("Le mot de passe n'est pas correct!", vbCritical, "Erreur")
                DRLogin.Close() : CmdLogin.Dispose()
                Exit Sub
            Else
                FrmPrincipale.Size = New Size(495, 395) : FrmPrincipale.Text = "Adminisration" : ChangerForm(FrmAdmin) : Me.Dispose()
            End If
        Else
            MsgBox("Nom d'utilisateur et mot de passe incorrects", vbCritical, "Erreur")
            DRLogin.Close() : CmdLogin.Dispose()
            Exit Sub
        End If

        DRLogin.Close() : CmdLogin.Dispose()
    End Sub

    Private Sub BtnAnnuler_Click(sender As Object, e As EventArgs) Handles BtnAnnuler.Click
        CN.Close() : Me.Dispose() : FrmPrincipale.Dispose()
    End Sub
End Class