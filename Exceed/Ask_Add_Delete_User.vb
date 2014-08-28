Imports ShreeEducation.connection
Imports System.Data.Odbc
Public Class Ask_Add_Delete_User

    Private Sub Ask_Add_Delete_User_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        deleteUserComboBox.Text = "Select the user name to be deleted "
        Try
            If Not con.State > 0 Then
                con.Open()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
       

        Try
            Dim cmd As OdbcCommand
            cmd = New OdbcCommand("select User_Id from login ", con)
            Dim dr As OdbcDataReader
            dr = cmd.ExecuteReader

            While dr.Read
                deleteUserComboBox.Items.Add(dr.Item(0))
            End While
            con.Close()

        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
        

    End Sub

   

    Private Sub deleteUserButton_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles deleteUserButton.Click
        addUserButton.Visible = False
        deleteUserButton.Visible = False
        deleteUserComboBox.Visible = True
        deleteButton.Visible = True
        deleteButton.Location = New Point(181, 38)

        
    End Sub

    Private Sub deleteButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles deleteButton.Click
        Dim userNameToBeDeleted As String
        userNameToBeDeleted = deleteUserComboBox.Text
        Try
            If Not con.State > 0 Then
                con.Open()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try

        Try
            If deleteUserComboBox.SelectedIndex >= 0 Then
                Dim msgBoxResult = MsgBox("Are You sure you want to delete " + userNameToBeDeleted + "user permanently", MsgBoxStyle.YesNo)
                If msgBoxResult = msgBoxResult.Yes Then
                    Dim cmd As OdbcCommand
                    cmd = New OdbcCommand("delete from login where User_Id = '" + userNameToBeDeleted + "'", con)
                    If cmd.ExecuteNonQuery() > 0 Then
                        MsgBox("user " + userNameToBeDeleted + " deleted succesfully")
                    Else
                        deleteUserComboBox.Focus()
                    End If


                End If
            End If


        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try

        
    End Sub

    Private Sub addUserButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addUserButton.Click
        con.Close()
        Me.Hide()
        Add_User.Show()
    End Sub
End Class