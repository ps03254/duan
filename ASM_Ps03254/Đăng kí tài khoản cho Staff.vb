Public Class Đăng_kí_tài_khoản_Staff

    Private Sub Đăng_kí_tài_khoản_Staff_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ptblogo_Click(sender As Object, e As EventArgs) Handles ptblogo.Click

    End Sub

    Private Sub btndangky_Click(sender As Object, e As EventArgs) Handles btndangky.Click
        ' nếu chưa nhập tên tài khoản, mật khẩu, xác nhận mật khẩu, tên người dùng, địa chỉ, số điện thoại
        If (txtdiachistaff.Text = "") OrElse _
            (txthotenstaff.Text = "" OrElse _
             txtpassstaff.Text = "" OrElse _
             txtphonestaff.Text = "" OrElse _
             chkdongyuser.Checked = False OrElse _
             txttaikhoanstaff.Text = "" OrElse _
             txtxacnhanpassstaff.Text = "") Then
            ' hiển thị thông báo lỗi trên hộp thoại
            MessageBox.Show(
                "Bạn chưa nhập đầy đủ thông tin", _
                "Missing Information", MessageBoxButtons.OK,
                MessageBoxIcon.Error)
        End If
        GiaodienloginStaff.Show()
        Me.Hide()
    End Sub

    Private Sub btnquayvehome_Click(sender As Object, e As EventArgs) Handles btnquayvehome.Click
        Trang_chủ.Show()
        Me.Hide()
    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        End
    End Sub
End Class