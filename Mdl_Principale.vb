Imports System.Data.OleDb
Module Mdl_Principale
    Public CN As OleDbConnection
    Public MaBd As String = Application.StartupPath & "\Db_Formation.accdb"
    Public Sub Se_connecter()
        CN = New OleDbConnection
        CN.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;
                            Data source='" & MaBd & "'"
        Try
            CN.Open()
        Catch ex As Exception
            MsgBox("Erreur declenchée lors du connexion a la base du données !", vbCritical, "Erreur")
            End
        End Try
    End Sub
    Public Sub ChangerForm(ByVal Panel As Form)
        FrmPrincipale.Panel1.Controls.Clear()
        Panel.TopLevel = False
        FrmPrincipale.Panel1.Controls.Add(Panel)
        Panel.Dock = DockStyle.Fill
        Panel.Show()
    End Sub
End Module
