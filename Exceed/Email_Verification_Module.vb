Imports System.Net.Mail
Module Email_Verification_Module
    Public verificationCode As String

    Public Sub SendEmail(ByVal subject As String, ByVal listOfEmail As String, ByVal body As String)
        Dim email As New MailMessage
        email.Subject = subject
        email.To.Add(listOfEmail)
        email.From = New MailAddress("nitesh.mishra143@gmail.com")
        email.Body = body
        Dim smtp As New SmtpClient("smtp.gmail.com")
        smtp.EnableSsl = True
        smtp.Credentials = New System.Net.NetworkCredential("nmmishra.iipsmca@gmail.com", "786sunitamishra786 ")
        smtp.Port = "587"
        smtp.Send(email)

    End Sub




    Public Function GenerateVerificationCode(ByRef iLength As Integer) As String
        Dim rdm As New Random()
        Dim allowChrs() As Char = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLOMNOPQRSTUVWXYZ0123456789".ToCharArray()
        Dim sResult As String = ""

        For i As Integer = 0 To iLength - 1
            sResult += allowChrs(rdm.Next(0, allowChrs.Length))
        Next

        Return sResult
    End Function




End Module
