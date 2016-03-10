Public Class GiaodienloginStaff

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        If txtaccount.Text = "datlt" And txtpass.Text = "lethaidat" And txtmsnv.Text = "ps03254" Then
            MessageBox.Show("Đăng nhập thành công", "Thông báo đăng nhập", MessageBoxButtons.OK)
            Quản_lý_bán_hàng_cho_Staff.Show()
            Me.Hide()
        Else
            MessageBox.Show("Không thành công", "Lỗi", MessageBoxButtons.OK)
        End If

        ' giới hạn chữ trong tài khoản và mật khẩu
        If txtaccount.Text.Length < 7 Then
            If txtpass.Text.Length < 18 Then

                ' nếu chưa nhập tên tài khoản, mật khẩu, check Box, hiển thị thông báo
                If (txtaccount.Text = "") OrElse _
                    (txtpass.Text = "" OrElse _
                     chkforhuman.Checked = False OrElse _
                     txtmsnv.Text = "") Then
                    ' hiển thị thông báo lỗi trên hộp thoại
                    MessageBox.Show(
                        "Bạn chưa nhập đầy đủ thông tin", _
                        "Missing Information", MessageBoxButtons.OK,
                        MessageBoxIcon.Error)
                End If
            End If
        End If
    End Sub

    Private Sub btnchontruycap_Click(sender As Object, e As EventArgs) Handles btnchontruycap.Click
        Trang_chủ.Show()
        Me.Hide()
    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        End
    End Sub
End Class