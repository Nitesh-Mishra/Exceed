
Imports System.Data.Odbc
Module connection

    Public con As New OdbcConnection("DSN=exceed")
    Public Function isTextBoxEmpty(ByVal thisTextField, ByVal missingFieldName)
        If thisTextField.Text = "" Then
            MsgBox(missingFieldName + " field missing")
            Return 0
        End If
        Return 1
    End Function
End Module
