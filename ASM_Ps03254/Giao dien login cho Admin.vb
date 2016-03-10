Public Class GiaodienloginchoAdmin

    Private Sub btnloginshop_Click(sender As Object, e As EventArgs) Handles btnloginshop.Click
        If txtaccountadmin.Text = "admin" And txtpassadmin.Text = "admin" Then
            MessageBox.Show("Đăng nhập thành công", "Thông báo đăng nhập", MessageBoxButtons.OK)
            Mã_bảo_vệ_Admin.Show()
            Me.Hide()
        Else
            MessageBox.Show("Không thành công", "Lỗi", MessageBoxButtons.OK)
        End If
        ' giới hạn chữ trong tài khoản và mật khẩu
        If txtaccountadmin.Text.Length < 7 Then
            If txtpassadmin.Text.Length < 7 Then

                ' nếu chưa nhập tên tài khoản, mật khẩu, check Box, hiển thị thông báo
                If (txtaccountadmin.Text = "") OrElse _
                    (txtpassadmin.Text = "" OrElse _
                     chkforhumanshop.Checked = False) Then

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