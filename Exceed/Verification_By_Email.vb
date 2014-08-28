Imports ShreeEducation.Add_User
Imports System.Data.Odbc
Imports ShreeEducation.Email_Verification_Module
Public Class Verification_By_Email

    Private Sub verifyButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles verifyButton.Click
        Try
            If Not con.State = ConnectionState.Open Then
                con.Open()
            End If
            Dim userName = Add_User.userName
            Dim password = Add_User.password
            Dim securityQuestion = Add_User.securityQuestion
            Dim answer = Add_User.answer


            Dim cmd As OdbcCommand

            cmd = New OdbcCommand("insert into login values('" + userName + "','" + password + "','" + securityQuestion + "','" + answer + "')", con)
            If verificationCode = verifyCodeTextBox.Text And ShreeEducation.FogortPasswordForm.forgotFlag = True Then
                Me.Hide()
                forgotChangePassword.Show()
            ElseIf verificationCode = verifyCodeTextBox.Text Then

                cmd.ExecuteNonQuery()
                MsgBox("User Added Successfully ")
                Me.Hide()
                loginForm.Show()

            Else
                MsgBox("Wrong code !Please check the code ", MsgBoxStyle.Critical)
            End If

        Catch ex As Exception
            MsgBox(ex.ToString())

        End Try

        

    End Sub

   
    Private Sub Verification_By_Email_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        verificationCode = GenerateVerificationCode(6)
        emailTheAdmin(verificationCode)
    End Sub

    Private Sub sendAgainLinkLabel_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles sendAgainLinkLabel.LinkClicked
        emailTheAdmin(verificationCode)
    End Sub

    Public Sub emailTheAdmin(ByVal verificationCode)
        Dim body As String
        Dim emailId As String
        Dim subject As String

        subject = "Your email verification code "
        emailId = "nitesh.mishra143@gmail.com"
        
        body = " Hello Admin, You are welcome! This is your verification code ' " + verificationCode + " '. If you not sent this message please see someone was trying to reset your passowrd"
        SendEmail(subject, emailId, body)

    End Sub
End Class