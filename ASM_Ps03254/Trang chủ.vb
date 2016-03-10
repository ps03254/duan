Public Class Trang_chủ

    Private Sub Trang_chủ_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub btnloginuser_Click(sender As Object, e As EventArgs) Handles btnloginstaff.Click
        GiaodienloginStaff.Show()
        Me.Hide()
    End Sub

    Private Sub btnloginshop_Click(sender As Object, e As EventArgs) Handles btnloginadmin.Click
        GiaodienloginchoAdmin.Show()
        Me.Hide()
    End Sub

    Private Sub btndangkyuser_Click(sender As Object, e As EventArgs) Handles btndangkystaff.Click
        Đăng_kí_tài_khoản_Staff.Show()
        Me.Hide()
    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        End
    End Sub
End Class