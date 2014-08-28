Imports ShreeEducation.connection
Imports ShreeEducation.Email_Verification_Module
Imports System.Data.Odbc

Public Class FogortPasswordForm
    Public userName As String
    Public forgotFlag As Boolean

    Private Sub FogortPasswordForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            con.Open()
            Dim selectSecurityQuestionQuery, selectUserNameQuery As String
            Dim cmd, cmd2 As OdbcCommand
            selectSecurityQuestionQuery = "select S_Question from security_question_table "
            selectUserNameQuery = "select User_Id from login"
            cmd = New OdbcCommand(selectSecurityQuestionQuery, con)
            cmd2 = New OdbcCommand(selectUserNameQuery, con)
            Dim dr As OdbcDataReader
            Dim dr1 As OdbcDataReader

            dr = cmd.ExecuteReader
            dr1 = cmd2.ExecuteReader

            While dr.Read
                selectSecurityQuestionComboBox.Items.Add(dr.Item(0))
            End While

            While dr1.Read
                selectUserNameComboBox.Items.Add(dr1.Item(0))
            End While

            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
        


    End Sub

   
    Private Sub nextButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nextButton.Click
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        Try
            con.Open()
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
        Try
            userName = selectUserNameComboBox.Text
            Dim securityQuestion = selectSecurityQuestionComboBox.Text
            Dim answer = securityQuestionAnswerTextBox.Text


            Dim cmd As OdbcCommand
            Dim authenticateQuery = "select * from login where User_Id = '" + userName + "' and S_Question ='" + securityQuestion + "' and S_Question_Answer = '" + answer + "' "
            Dim dr As OdbcDataReader
            cmd = New OdbcCommand(authenticateQuery, con)
            dr = cmd.ExecuteReader
            If dr.HasRows() = True Then

                forgotFlag = True ' used to tell verification by email form that this form is active
                Verification_By_Email.Show()
                Me.Hide()
            Else
                MsgBox("Wrong information !", MsgBoxStyle.Exclamation)


            End If



            con.Close()


        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try

        


    End Sub
End Class