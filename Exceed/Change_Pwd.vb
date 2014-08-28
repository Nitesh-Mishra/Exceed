Imports System.Data.Odbc

Public Class Change_Pwd
    Dim con As New OdbcConnection("DSN=exceed")
    Private Sub save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles save.Click
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        Try
            con.Open()
            Dim op, np, rp As String
            op = opwd.Text
            np = npwd.Text
            rp = rpwd.Text
            Dim cmd As New OdbcCommand
            cmd = New OdbcCommand("select Password from login where Password = '" + op + "'", con)
            If cmd.ExecuteNonQuery > 0 Then
                If (np = rp) Then
                    Dim cmd1 As OdbcCommand
                    cmd1 = New OdbcCommand("update login set Password='" + np + "'", con)
                    cmd1.ExecuteNonQuery()
                    MsgBox("Password Changed Successfully", MsgBoxStyle.Information)
                    opwd.Clear()
                    npwd.Clear()
                    rpwd.Clear()
                Else
                    MsgBox("Password not matched", MsgBoxStyle.Critical)
                End If
            Else
                MsgBox("Enter correct Password", MsgBoxStyle.Critical)
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        con.Close()
    End Sub

    Private Sub Back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Back.Click
        Me.Hide()
        loginForm.Show()
    End Sub

    Private Sub Change_Pwd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        opwd.Focus()
    End Sub
End Class