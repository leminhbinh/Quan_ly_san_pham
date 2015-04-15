Public Class Main

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub ĐăngXuấtToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ĐăngXuấtToolStripMenuItem.Click
        Login.Show()
        Me.Hide()
        MessageBox.Show("Đã đăng xuất thành công", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
        MessageBox.Show("Bạn rất may mắn khi thoát khỏi nguy hiểm", "Chúc mừng", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Sub

    
    Private Sub SảnPhẩmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SảnPhẩmToolStripMenuItem.Click
        quanlysanpham.Show()
    End Sub

    Private Sub KháchHàngToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KháchHàngToolStripMenuItem.Click
        quanlykhachhang.Show()
    End Sub

    Private Sub NhânViênToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NhânViênToolStripMenuItem.Click
        quanlynhanvien.Show()
    End Sub

    Private Sub HóaĐơnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HóaĐơnToolStripMenuItem.Click
        quanlyhoadon.Show()
    End Sub
End Class