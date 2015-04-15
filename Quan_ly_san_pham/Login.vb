
Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class Login

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btn_login.Click
        Dim chuoiconnect As String = "workstation id=binhlmps02350.mssql.somee.com;packet size=4096;user id=binhlmps02350_SQLLogin_2;pwd=miu1uvixcs;data source=binhlmps02350.mssql.somee.com;persist security info=False;initial catalog=binhlmps02350"
        Dim connect As SqlConnection = New SqlConnection(chuoiconnect)
        Dim sqlAdapter As New SqlDataAdapter("select * from Thong_tin_dang_nhap where ID ='" & TextBox1.Text & "'and Pass ='" & TextBox2.Text & "' ", connect)
        Dim table As New DataTable
        Try
            connect.Open()
            sqlAdapter.Fill(table)
            If table.Rows.Count > 0 Then
                MessageBox.Show("Đã Kết nối")
                Main.Show()
                Me.Hide()
            Else
                MessageBox.Show(" Sai ID or Password")
            End If

        Catch ex As Exception

        End Try


    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
