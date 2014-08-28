Imports ShreeEducation.connection
Imports ShreeEducation.Email_Verification_Module
Imports System.Data.Odbc


Public Class Add_User
    Public userName As String
    Public password As String
    Public securityQuestion As String
    Public answer As String

    Private Sub Add_User_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If con.State = ConnectionState.Open Then
            con.Close()
        End If


        resetFields() ' function call to reset fields
        Try
            con.Open()

            Dim cmd As OdbcCommand
            cmd = New OdbcCommand("select S_Question from security_question_table ", con)
            Dim dr As OdbcDataReader
            dr = cmd.ExecuteReader

            While dr.Read
                securityQuestionComboBox.Items.Add(dr.Item(0))
            End While
            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString())

        End Try
        


    End Sub

    Private Sub resetNewPasswordButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addUserButton.Click
        userName = newUserNameTextBox.Text
        password = newPasswordTextBox.Text
        securityQuestion = securityQuestionComboBox.Text
        answer = answerTextBox.Text


        Try
            If Not con.State = ConnectionState.Open Then
                con.Open()
            End If


        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try

        Dim cmd1 As OdbcCommand

        cmd1 = New OdbcCommand("select User_Id from login where User_Id = '" + userName + "'", con)

        Try
            If newUserNameTextBox.Text = "" Or newPasswordTextBox.Text = "" Or answerTextBox.Text = "" Then
                MsgBox("Some Fields are blank")
            ElseIf cmd1.ExecuteNonQuery > 0 Then
                MsgBox("User already exist. Select a different user ")
                resetFields() ' function call to reset fields
                

            ElseIf newUserNameTextBox.Text <> "" And newPasswordTextBox.Text <> "" And securityQuestionComboBox.SelectedIndex >= 0 And answerTextBox.Text <> "" Then
                
                Verification_By_Email.Show()
                Me.Hide()
            Else
                MsgBox("Please select the security question ")
                newUserNameTextBox.Focus()
            End If

            con.Close()
            
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
        

    End Sub
    Private Sub resetFields()
        newUserNameTextBox.Clear()
        newPasswordTextBox.Clear()
        answerTextBox.Clear()
        newUserNameTextBox.Focus()
        securityQuestionComboBox.Text = "Select the security question"
    End Sub

End Class