Imports System.Data   'Data base connection
Imports System.Data.SqlClient

Public Class Reset
    Dim username As String = Sendcode.toUser

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (TextBox2.Text.Equals(TextBox1.Text)) Then
            Dim con As SqlConnection = New SqlConnection("Data Source=DESKTOP-QEHRE75\SQLEXPRESS01;Initial Catalog=forgetvb;Integrated Security=True")
            Dim cmd As SqlCommand = New SqlCommand("
UPDATE [dbo].[loginforget]
   SET [username] = '" + username + "',>
      ,[password] = '" + TextBox1.Text + "'
 WHERE [username] ='" + username + "'", con)
            con.Open()
            cmd.ExecuteNonQuery()
            MessageBox.Show("password reseted successfully", "information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            con.Close()
        Else
            MessageBox.Show("Enter the same password")
        End If

    End Sub
    Private Sub Reset_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class