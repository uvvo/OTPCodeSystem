Imports System.Data  'Data base connection
Imports System.Data.SqlClient
Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As SqlConnection = New SqlConnection("Data Source=DESKTOP-QEHRE75\SQLEXPRESS01;Initial Catalog=forgetvb;Integrated Security=True")
        Dim cmd As SqlCommand = New SqlCommand("select * from loginforget where username='" + TextBox1.Text + "'and password='" + TextBox2.Text + "'", con)
        Dim sda As SqlDataAdapter = New SqlDataAdapter(cmd)
        Dim dt As DataTable = New DataTable()
        sda.Fill(dt)

        If (dt.Rows.Count > 0) Then
            MessageBox.Show("Login sucess")
        Else
            MessageBox.Show("Sorry, try again!")
        End If
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Dim sc As Sendcode = New Sendcode()
        sc.Show()
        Dim a As Form1 = New Form1()
        a.Hide()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
    End Sub
End Class
