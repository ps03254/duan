Public Class Mã_bảo_vệ_Admin

    

    Private Sub btnchontruycap_Click(sender As Object, e As EventArgs) Handles btnchontruycap.Click
        Trang_chủ.Show()
        Me.Hide()
    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        End
    End Sub

  
    Private Sub btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn1.Click, btn2.Click, btn3.Click, btn4.Click, btn5.Click, btn6.Click, btn7.Click, btn8.Click, btn9.Click, btn0.Click
        If txtsecurity.Text.Length < 4 Then
            txtsecurity.Text += CType(sender, Button).Text
        End If
    End Sub

    Private Sub btnthang_Click(sender As Object, e As EventArgs) Handles btnthang.Click
        If txtsecurity.Text.Length < 4 Then
            MessageBox.Show( _
                        " Vui lòng nhập đủ 4 số ", _
                        " Thông báo ", MessageBoxButtons.OK, _
                        MessageBoxIcon.Error)
        End If

        Dim accessCode As Integer ' lưu mã truy cập được nhập vào
        Dim message As String ' hiển thị trạng thái truy cập

        accessCode = Val(txtsecurity.Text)
        txtsecurity.Clear()

        Select Case accessCode ' kiểm tra mã truy cập
            Case Is < 10 ' mã truy cập nhỏ hơn 10
                message = "Assistance Requested"
            Case 1645 To 1689 ' mã truy cập nằm giữa 1645 và 1689
                message = "technicians"
            Case 8345 ' mã truy cạp bằng 8345
                message = "Custodians"
            Case 9998, 1006 To 1008 ' 9998 hặc nằm giữa 1006 và 1008
                message = "Scientists"
            Case Else ' nếu không có trường hợp nào ở trên đúng
                message = "Access Denied"
        End Select

        ' hiện thị thời gian và thông báo trên Listbox
        lstaccesslog.Items.Insert(0, Date.Now & " " & message)

        Quan_ly_khach_hang_admin.Show()
        Me.Hide()
    End Sub
End Class