Public Class Quan_ly_nhap_hang
    Dim baocao(0 To 9, 0 To 6) As Integer
    Dim mathang As Integer
    Dim thu2, thu3, thu4, thu5, thu6 As Integer
    Dim ten As String
    Private Sub btnnhap_Click(sender As Object, e As EventArgs) Handles btnnhap.Click
        thu2 = Val(txtthu2.Text)
        thu3 = Val(txtthu3.Text)
        thu4 = Val(txtthu4.Text)
        thu5 = Val(txtthu5.Text)
        thu6 = Val(txtthu6.Text)
        ten = txtmathang.Text
        Dim tong As Integer
        baocao(mathang, 0) = thu2
        baocao(mathang, 1) = thu3
        baocao(mathang, 2) = thu4
        baocao(mathang, 3) = thu5
        baocao(mathang, 4) = thu6
        tong = thu2 + thu3 + thu4 + thu5 + thu6
        lstbaocao.Items.Add(ten & ControlChars.Tab & thu2 & ControlChars.Tab & _
                           thu3 & ControlChars.Tab & thu4 & ControlChars.Tab & _
                           thu5 & ControlChars.Tab & thu6 & ControlChars.Tab & tong)
    End Sub

    Private Sub Quan_ly_nhap_hang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstbaocao.Items.Add("Tên" & ControlChars.Tab & "Thứ 2" & ControlChars.Tab & "Thứ 3" & ControlChars.Tab & _
                         "Thứ 4" & ControlChars.Tab & "Thứ 5" & ControlChars.Tab & "Thứ 6" & ControlChars.Tab & "Tổng")
    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        End
    End Sub

    Private Sub btntroveadmin_Click(sender As Object, e As EventArgs) Handles btntrovetrangchu.Click
        Trang_chủ.Show()
        Me.Hide()
    End Sub

    Private Sub btntroveadmin_Click_1(sender As Object, e As EventArgs) Handles btntroveadmin.Click
        Quan_ly_khach_hang_admin.Show()
        Me.Hide()
    End Sub
End Class