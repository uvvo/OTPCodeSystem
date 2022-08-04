Imports System.Net      'Email connection
Imports System.Net.Mail

Public Class Sendcode
    Dim randomCode As String
    Public Shared toUser As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim from, pass, messageBody As String
        Dim rand As Random = New Random()
        randomCode = (rand.Next(999999)).ToString()
        Dim message As MailMessage = New MailMessage()
        toUser = TextBox1.Text
        from = "haroldmenor25@gmail.com"
        pass = "wvnsruxxmujnfdmi"
        messageBody = "your reset code is" + randomCode
        message.To.Add(toUser)
        message.From = New MailAddress(from)
        message.Body = messageBody
        message.Subject = "Password reset code"

        Dim smtp As SmtpClient = New SmtpClient("smtp.gmail.com")
        smtp.EnableSsl = True
        smtp.Port = 587
        smtp.DeliveryMethod = smtp.DeliveryMethod.Network
        smtp.Credentials = New NetworkCredential(from, pass)

        Try
            smtp.Send(message)
            MessageBox.Show("Please check your Email!")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If (TextBox2.Text.Equals(randomCode)) Then
            Dim Reset As Reset = New Reset()
            Reset.Show()
            Dim sc As Sendcode = New Sendcode()
            sc.Hide()
        Else
            MessageBox.Show(" Sorry wrong code!")
        End If
    End Sub
End Class