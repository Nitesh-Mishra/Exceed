Imports ShreeEducation.connection
Imports System.Data.Odbc

Public Class loginForm

    Dim con As New OdbcConnection("DSN=exceed")
    Dim Attempt As Integer = 3

    

    Private Sub loginForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
        logintxt.Focus()
        operatorRadioButton.Checked = True

    End Sub

    Private Sub Login_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Login.Click
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        Try
            con.Open()
            Dim login, pwd, usertype As String
            login = logintxt.Text
            pwd = password.Text
            If adminRadioButton.Checked = True Then
                usertype = adminRadioButton.Text
            End If
            If operatorRadioButton.Checked = True Then
                usertype = operatorRadioButton.Text
            End If
            Dim cmd As OdbcCommand
            cmd = New OdbcCommand("select * from login where User_Id='" + login + "' and Password='" + pwd + "' and user_type='" + usertype + "'", con)


            If logintxt.Text = "" Or password.Text = "" Then
                MsgBox("UserID or Password are missing")
                logintxt.Focus()
                logintxt.SelectAll()


            ElseIf cmd.ExecuteNonQuery > 0 Then
                If adminRadioButton.Checked = True Then
                    Module1.musertype = adminRadioButton.Text
                Else
                    Module1.musertype = operatorRadioButton.Text
                End If
                Me.Hide()
                Select_Action.Show()
            Else
                MsgBox("UserId or Password is incorrect, you have '" & Attempt - 1 & "' Attempts Remaining", MsgBoxStyle.Critical)
                Attempt = Attempt - 1
                logintxt.Text = ""
                password.Text = ""
                logintxt.Focus()
            End If

            If Attempt = 0 Then
                MsgBox("Wait for 30 seconds before next attempt")
                Threading.Thread.Sleep(3000)
                UseWaitCursor = False
                Attempt = 3
            End If

        Catch ex As Exception

        End Try

        con.Close()
    End Sub


    Private Sub cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cancel.Click
        Me.Dispose()
    End Sub

    Private Sub forgotPasswordLinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles forgotPasswordLinkLabel.LinkClicked
        Me.Hide()
        ShreeEducation.FogortPasswordForm.Show()

    End Sub



    Private Sub masterLinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles masterLinkLabel.LinkClicked
        Me.Hide()
        Master_Password.Show()
    End Sub
End Class