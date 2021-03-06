﻿Imports System.Data.SqlClient
Imports System.Data
Public Class Quản_lý_bán_hàng_cho_Staff
    Dim chuoiketnoi As String = "workstation id=Quanlybanhangdatltps03254.mssql.somee.com;packet size=4096;user id=datltps03254_SQLLogin_1;pwd=n2ndsjbr2j;data source=Quanlybanhangdatltps03254.mssql.somee.com;persist security info=False;initial catalog=Quanlybanhangdatltps03254"
    'local "workstation id=Quanlybanhangdatltps03254.mssql.somee.com;packet size=4096;user id=datltps03254_SQLLogin_1;pwd=n2ndsjbr2j;data source=Quanlybanhangdatltps03254.mssql.somee.com;persist security info=False;initial catalog=Quanlybanhangdatltps03254"
    Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
    Dim db As New DataTable
    Private Sub btntrovestaff_Click(sender As Object, e As EventArgs) Handles btntrovestaff.Click
        Trang_chủ.Show()
        Me.Hide()
    End Sub

    Private Sub btnseach_Click(sender As Object, e As EventArgs) Handles btnseach.Click
        Dim connect As SqlConnection = New SqlConnection(chuoiketnoi)
        connect.Open()
        Dim xem As SqlDataAdapter = New SqlDataAdapter("select MaKH  as 'Mã Khách Hàng' ,TenKH as 'Tên Khách Hàng', DiaChi as 'Địa chỉ', SDT as 'SĐT' from KHACHHANG where MaKH='" & txtmakhachhang.Text & "'", connect)
        Try
            If txtmakhachhang.Text = "" Then
                MessageBox.Show("Bạn cần nhập MaKH", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)

            Else
                db.Clear()
                dgvhienthistaff.DataSource = Nothing
                xem.Fill(db)
                If db.Rows.Count > 0 Then
                    dgvhienthistaff.DataSource = db.DefaultView
                    txtmakhachhang.Text = Nothing
                Else
                    MessageBox.Show("Không tìm thấy")
                    txtmakhachhang.Text = Nothing
                End If
            End If
            connect.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub dgvKH_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvhienthistaff.CellContentClick
        Dim click As Integer = dgvhienthistaff.CurrentCell.RowIndex
        txtmakhachhang.Text = dgvhienthistaff.Item(0, click).Value
        txttenkhachhang.Text = dgvhienthistaff.Item(1, click).Value
        txtdiachi.Text = dgvhienthistaff.Item(2, click).Value
        txtsodienthoaikh.Text = dgvhienthistaff.Item(3, click).Value
    End Sub

    Private Sub btnaddstaff_Click(sender As Object, e As EventArgs) Handles btnaddstaff.Click
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim query As String = "insert into KHACHHANG values(@MaKH,@TenKH,@Diachi,@SDT)"
        Dim save As SqlCommand = New SqlCommand(query, conn)
        conn.Open()
        Try
            txtmakhachhang.Focus()
            If txtmakhachhang.Text = "" Then
                MessageBox.Show("Bạn chưa nhập Mã Khách hàng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Else
                txttenkhachhang.Focus()
                If txttenkhachhang.Text = "" Then
                    MessageBox.Show("Bạn chưa nhập tên khách hàng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                Else
                    txtdiachi.Focus()
                    If txtsodienthoaikh.Text = "" Then
                        MessageBox.Show("Bạn chưa nhập số điện thoại", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                    Else
                        save.Parameters.AddWithValue("@MaKH", txtmakhachhang.Text)
                        save.Parameters.AddWithValue("@TenKH", txttenkhachhang.Text)
                        save.Parameters.AddWithValue("@DiaChi", txtdiachi.Text)
                        save.Parameters.AddWithValue("@SDT", txtsodienthoaikh.Text)
                        save.ExecuteNonQuery()
                        MessageBox.Show("Lưu thành công")
                        'Sau khi nhập thành công, tự động làm mới các khung textbox, combox và date....
                        txtmakhachhang.Text = Nothing
                        txttenkhachhang.Text = Nothing
                        txtdiachi.Text = Nothing
                        txtdiachi.Text = Nothing
                    End If
                End If
            End If
        Catch ex As Exception  'Ngược lại báo lỗi
            MessageBox.Show("Không được trùng mã khách hàng", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try

        'Làm mới lại bảng sau khi lưu thành công
        Dim refesh As SqlDataAdapter = New SqlDataAdapter("select MaKH  as 'Mã Khách Hàng' ,TenKH as 'Tên Khách Hàng', DiaChi as 'Địa chỉ', SDT as 'SĐT' from KHACHHANG", conn)
        db.Clear()
        refesh.Fill(db)
        dgvhienthistaff.DataSource = db.DefaultView
    End Sub

    Private Sub btndelstaff_Click(sender As Object, e As EventArgs) Handles btndelstaff.Click
        Dim delquery As String = "delete from KHACHHANG where MaKH=@MaKH"
        Dim delete As SqlCommand = New SqlCommand(delquery, conn)
        Dim resulft As DialogResult = MessageBox.Show("Bạn muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        conn.Open()
        Try
            If txtmakhachhang.Text = "" Then
                MessageBox.Show("Bạn cần nhập mã khách hàng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                txtmakhachhang.Focus()
            Else
                If resulft = Windows.Forms.DialogResult.Yes Then
                    delete.Parameters.AddWithValue("@MaKH", txtmakhachhang.Text)
                    delete.ExecuteNonQuery()
                    conn.Close()
                    MessageBox.Show("Xóa thành công")
                    'Sau khi xóa thành công, tự động làm mới các khung textbox, combox và date....
                    txtmakhachhang.Text = Nothing
                    txttenkhachhang.Text = Nothing
                    txtdiachi.Text = Nothing
                    txtsodienthoaikh.Text = Nothing
                    txtmakhachhang.Focus()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Nhập đúng mã khách hàng cần xóa", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try

        'làm mới bảng
        db.Clear()
        dgvhienthistaff.DataSource = db
        dgvhienthistaff.DataSource = Nothing
        LoadData()
    End Sub
    Private Sub LoadData()
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim load As SqlDataAdapter = New SqlDataAdapter("select MaKH  as 'Mã Khách Hàng' ,TenKH as 'Tên Khách Hàng', DiaChi as 'Địa chỉ', SDT as 'SĐT' from KHACHHANG", conn)

        conn.Open()
        load.Fill(db)
        dgvhienthistaff.DataSource = db.DefaultView
    End Sub

    Private Sub btneditstaff_Click(sender As Object, e As EventArgs) Handles btneditstaff.Click
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim updatequery As String = "update KHACHHANG set MaKH=@MaKH, TenKH=@TENKH, DiaChi=@DIACHI, SDT=@SDT, where MaKH=@MaKH"
        Dim addupdate As SqlCommand = New SqlCommand(updatequery, conn)
        conn.Open()
        Try
            txtmakhachhang.Focus()
            If txtmakhachhang.Text = "" Then
                MessageBox.Show("Bạn chưa nhập mã khách hàng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Else
                txtmakhachhang.Focus()
                If txttenkhachhang.Text = "" Then
                    MessageBox.Show("Bạn chưa nhập tên khách hàng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                Else
                    txttenkhachhang.Focus()
                    If txtdiachi.Text = "" Then
                        MessageBox.Show("Bạn chưa nhập địa chỉ khách hàng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                    Else
                        txtdiachi.Focus()
                        If txtsodienthoaikh.Text = "" Then
                            MessageBox.Show("Bạn chưa nhập số điện thoại", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                        Else
                            txtsodienthoaikh.Focus()

                            addupdate.Parameters.AddWithValue("@MaKH", txtmakhachhang.Text)
                            addupdate.Parameters.AddWithValue("@TenKH", txttenkhachhang.Text)
                            addupdate.Parameters.AddWithValue("@DiaChi", txtdiachi.Text)
                            addupdate.Parameters.AddWithValue("@SDT", txtsodienthoaikh.Text)
                            addupdate.ExecuteNonQuery()
                                conn.Close() 'đóng kết nối
                                MessageBox.Show("Cập nhật thành công")
                            txtmakhachhang.Text = Nothing
                            txttenkhachhang.Text = Nothing
                            txtdiachi.Text = Nothing
                            txtsodienthoaikh.Text = Nothing
                        End If
                        End If
                    End If
                End If
        Catch ex As Exception
            MessageBox.Show("Không thành công", "Lỗi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try

        'Sau khi cập nhật xong sẽ tự làm mới lại bảng
        db.Clear()
        dgvhienthistaff.DataSource = db
        dgvhienthistaff.DataSource = Nothing
        LoadData()
    End Sub

    Private Sub Quản_lý_bán_hàng_cho_Staff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim load As SqlDataAdapter = New SqlDataAdapter("select MaKH  as 'Mã Khách Hàng' ,TenKH as 'Tên Khách Hàng', DiaChi as 'Địa chỉ', SDT as 'SĐT' from KHACHHANG", conn)

        conn.Open()
        load.Fill(db)
        dgvhienthistaff.DataSource = db.DefaultView
    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        End
    End Sub
End Class