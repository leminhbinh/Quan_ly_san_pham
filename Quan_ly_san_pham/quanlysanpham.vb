Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class quanlysanpham
    Dim table As New DataTable
    Dim connect As String = "workstation id=binhlmps02350.mssql.somee.com;packet size=4096;user id=binhlmps02350_SQLLogin_2;pwd=miu1uvixcs;data source=binhlmps02350.mssql.somee.com;persist security info=False;initial catalog=binhlmps02350"
    Public Sub Loaddata()
        Dim Load As New SqlConnection(connect)
        Dim them As New SqlDataAdapter(" insert into San_pham values ('" & txtmsp.Text & "','" & txttsp.Text & "','" & txtmlsp.Text & "','" & txtsl.Text & "')", Load)
        Try
            Load.Open()
            them.Fill(table)
        Catch ex As Exception

        End Try
        DataGridView1.DataSource = table
        Load.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim load As New SqlConnection(connect)
        Dim data As New SqlDataAdapter(" select * from San_pham", load)
        Try
            load.Open()
            data.Fill(table)

        Catch ex As Exception

        End Try
        DataGridView1.DataSource = table
        load.Close()
    End Sub

    
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim load As New SqlConnection(connect)
        Dim them As New SqlDataAdapter(" insert into San_pham values(' & txtmsp.Text & ',' & txttsp.Text & ',' & txtmlsp.Text & ',' & txtsl.Text & ')", load)
        Try
            load.Open()
            them.Fill(table)

        Catch ex As Exception
            MessageBox.Show(" Add thành công")
        End Try
        DataGridView1.DataSource = table
        load.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim data As Integer = DataGridView1.CurrentCell.RowIndex
        txtmsp.Text = DataGridView1.Item(0, data).Value
        txttsp.Text = DataGridView1.Item(1, data).Value
        txtmlsp.Text = DataGridView1.Item(2, data).Value
        txtsl.Text = DataGridView1.Item(3, data).Value


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim load As New SqlConnection(connect)
        load.Open()
        Dim edit As String = " Update San_pham set Ten_san_pham = @Ten_san_pham, Ma_loai_san_pham = @Ma_loai_san_pham, So_luong = @So_luong where  Ma_san_pham = @Ma_san_pham"
        Dim cmd As New SqlCommand(edit, load)
        Try
            cmd.Parameters.AddWithValue("@Ma_san_pham", txtmsp.Text)
            cmd.Parameters.AddWithValue("@Ten_san_pham", txttsp.Text)
            cmd.Parameters.AddWithValue("@Ma_loai_san_pham", txtmlsp.Text)
            cmd.Parameters.AddWithValue("@So_luong", txtsl.Text)
            cmd.ExecuteNonQuery()
            load.Close()

        Catch ex As Exception
            MessageBox.Show(" Edit hoàn thành")

        End Try
        table.Clear()
        DataGridView1.DataSource = table
        DataGridView1.DataSource = Nothing
        Loaddata()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim delete As New SqlConnection(connect)
        delete.Open()
        Dim thuchien As String = "delete from San_pham where Ten_san_pham = @Ten_san_pham"
        Dim cmd As New SqlCommand(thuchien, delete)
        Try
            cmd.Parameters.AddWithValue(" Ten_san_pham", txttsp.Text)
            cmd.ExecuteNonQuery()
            delete.Close()

        Catch ex As Exception
            MessageBox.Show(" Delete thành công")

        End Try
        table.Clear()
        DataGridView1.DataSource = table
        DataGridView1.DataSource = Nothing
        Loaddata()

    End Sub
End Class