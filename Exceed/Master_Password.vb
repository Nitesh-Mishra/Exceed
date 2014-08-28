Imports ShreeEducation.connection
Imports System.Data.Odbc


Public Class Master_Password


    Private Sub resetNewPasswordButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles resetNewPasswordButton.Click
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        Try
            'isTextBoxEmpty is the function for validation in connection module
            If isTextBoxEmpty(masterPasswordTextBox, "Password") > 0 Then

                If Not con.State = 1 Then
                    con.Open()
                End If
                Dim userName = "Master"
                Dim cmd As OdbcCommand
                cmd = New OdbcCommand("select * from login where User_Id='" + userName + "' and Password='" + masterPasswordTextBox.Text + "'", con)

                If cmd.ExecuteNonQuery > 0 Then
                    con.Close()
                    Me.Hide()
                    Ask_Add_Delete_User.Show()
                Else
                    MsgBox("Wrong password! System wake up after 30 seconds", MsgBoxStyle.Critical)
                    Threading.Thread.Sleep(30000)
                    masterPasswordTextBox.Focus()

                End If

                con.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
        




    End Sub

    Private Sub Master_Password_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        masterPasswordTextBox.Focus()
    End Sub
End Class