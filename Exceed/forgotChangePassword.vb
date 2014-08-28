Imports ShreeEducation.connection
Imports System.Data.Odbc

Public Class forgotChangePassword

    Dim userName As String

    Private Sub resetNewPasswordButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles resetNewPasswordButton.Click

        Try
            If Not connection.con.State = 1 Then
                con.Open()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try


        Dim newPassword, retypePassword As String
        newPassword = newPasswordTextBox.Text
        retypePassword = retypePasswordTextBox.Text

        

        Dim cmd As New OdbcCommand
        Dim cmd1 As OdbcCommand
        cmd = New OdbcCommand("select Password from login where User_Id = '" + userName + "'", con)
        cmd1 = New OdbcCommand("update login set Password='" + newPassword + "'", con)

        Try
            If newPassword = "" Or retypePassword = "" Then
                MsgBox("Fields are missing/blank")
                newPasswordTextBox.Focus()

            ElseIf newPassword <> retypePassword Then
                MsgBox("Passwords do not match")
                newPasswordTextBox.Clear()
                retypePasswordTextBox.Clear()
                newPasswordTextBox.Focus()
            ElseIf cmd.ExecuteNonQuery > 0 Then


                'checking for correctness of both passwords
                If newPassword = retypePassword Then

                    ' executing update password query
                    If cmd1.ExecuteNonQuery() Then
                        MsgBox("Password Changed Successfully", MsgBoxStyle.Information)



                        'closing current form and showing login form
                        Me.Close()
                        con.Close()
                        loginForm.Show()
                    End If

                End If


            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
        
    End Sub

    Private Sub forgotChangePassword_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
        userName = ShreeEducation.FogortPasswordForm.userName
        ShreeEducation.FogortPasswordForm.forgotFlag = False

    End Sub

    Private Sub cancelButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cancelButton.Click
        con.Close()
        Me.Close()

        loginForm.Show()
    End Sub
End Class