<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GiaodienloginStaff
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GiaodienloginStaff))
        Me.lblbanquyen = New System.Windows.Forms.Label()
        Me.pnldanhsach = New System.Windows.Forms.Panel()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.btnchontruycap = New System.Windows.Forms.Button()
        Me.txtmsnv = New System.Windows.Forms.TextBox()
        Me.lblchude = New System.Windows.Forms.Label()
        Me.txtpass = New System.Windows.Forms.TextBox()
        Me.txtaccount = New System.Windows.Forms.TextBox()
        Me.chkforhuman = New System.Windows.Forms.CheckBox()
        Me.btnlogin = New System.Windows.Forms.Button()
        Me.lbldongdienthoai = New System.Windows.Forms.Label()
        Me.lblmatkhau = New System.Windows.Forms.Label()
        Me.lbltaikhoan = New System.Windows.Forms.Label()
        Me.ptblogo = New System.Windows.Forms.PictureBox()
        Me.ptboppo = New System.Windows.Forms.PictureBox()
        Me.pnldanhsach.SuspendLayout()
        CType(Me.ptblogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptboppo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblbanquyen
        '
        Me.lblbanquyen.BackColor = System.Drawing.Color.White
        Me.lblbanquyen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblbanquyen.Location = New System.Drawing.Point(12, 431)
        Me.lblbanquyen.Name = "lblbanquyen"
        Me.lblbanquyen.Size = New System.Drawing.Size(816, 63)
        Me.lblbanquyen.TabIndex = 14
        Me.lblbanquyen.Text = "Phần mềm quản lý điện thoại Control Smart thuộc về @ Lê Thái Đạt" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Mọi hành vi sao" & _
    " chép điều là vi phạm pháp luật" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Chi tiết liên hệ 0916275xxx"
        Me.lblbanquyen.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'pnldanhsach
        '
        Me.pnldanhsach.Controls.Add(Me.btnclose)
        Me.pnldanhsach.Controls.Add(Me.btnchontruycap)
        Me.pnldanhsach.Controls.Add(Me.txtmsnv)
        Me.pnldanhsach.Controls.Add(Me.lblchude)
        Me.pnldanhsach.Controls.Add(Me.txtpass)
        Me.pnldanhsach.Controls.Add(Me.txtaccount)
        Me.pnldanhsach.Controls.Add(Me.chkforhuman)
        Me.pnldanhsach.Controls.Add(Me.btnlogin)
        Me.pnldanhsach.Controls.Add(Me.lbldongdienthoai)
        Me.pnldanhsach.Controls.Add(Me.lblmatkhau)
        Me.pnldanhsach.Controls.Add(Me.lbltaikhoan)
        Me.pnldanhsach.Location = New System.Drawing.Point(191, 122)
        Me.pnldanhsach.Name = "pnldanhsach"
        Me.pnldanhsach.Size = New System.Drawing.Size(637, 306)
        Me.pnldanhsach.TabIndex = 13
        '
        'btnclose
        '
        Me.btnclose.Location = New System.Drawing.Point(471, 248)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(91, 23)
        Me.btnclose.TabIndex = 12
        Me.btnclose.Text = "Đóng ứng dụng"
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'btnchontruycap
        '
        Me.btnchontruycap.Location = New System.Drawing.Point(348, 248)
        Me.btnchontruycap.Name = "btnchontruycap"
        Me.btnchontruycap.Size = New System.Drawing.Size(117, 23)
        Me.btnchontruycap.TabIndex = 16
        Me.btnchontruycap.Text = "Chọn quyền sử dụng"
        Me.btnchontruycap.UseVisualStyleBackColor = True
        '
        'txtmsnv
        '
        Me.txtmsnv.Location = New System.Drawing.Point(131, 158)
        Me.txtmsnv.Name = "txtmsnv"
        Me.txtmsnv.Size = New System.Drawing.Size(100, 20)
        Me.txtmsnv.TabIndex = 10
        '
        'lblchude
        '
        Me.lblchude.AutoSize = True
        Me.lblchude.Font = New System.Drawing.Font("Times New Roman", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblchude.ForeColor = System.Drawing.Color.Red
        Me.lblchude.Location = New System.Drawing.Point(129, 9)
        Me.lblchude.Name = "lblchude"
        Me.lblchude.Size = New System.Drawing.Size(444, 62)
        Me.lblchude.TabIndex = 9
        Me.lblchude.Text = "Phần mềm quản lý điện thoại " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "                                      Control Smart" & _
    ""
        '
        'txtpass
        '
        Me.txtpass.Location = New System.Drawing.Point(131, 117)
        Me.txtpass.MaxLength = 18
        Me.txtpass.Name = "txtpass"
        Me.txtpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpass.Size = New System.Drawing.Size(431, 20)
        Me.txtpass.TabIndex = 8
        '
        'txtaccount
        '
        Me.txtaccount.Location = New System.Drawing.Point(131, 78)
        Me.txtaccount.MaxLength = 7
        Me.txtaccount.Name = "txtaccount"
        Me.txtaccount.Size = New System.Drawing.Size(431, 20)
        Me.txtaccount.TabIndex = 7
        '
        'chkforhuman
        '
        Me.chkforhuman.AutoSize = True
        Me.chkforhuman.Location = New System.Drawing.Point(403, 205)
        Me.chkforhuman.Name = "chkforhuman"
        Me.chkforhuman.Size = New System.Drawing.Size(159, 17)
        Me.chkforhuman.TabIndex = 6
        Me.chkforhuman.Text = "Tôi không phải là người máy"
        Me.chkforhuman.UseVisualStyleBackColor = True
        '
        'btnlogin
        '
        Me.btnlogin.Location = New System.Drawing.Point(267, 248)
        Me.btnlogin.Name = "btnlogin"
        Me.btnlogin.Size = New System.Drawing.Size(75, 23)
        Me.btnlogin.TabIndex = 4
        Me.btnlogin.Text = "Đăng nhập"
        Me.btnlogin.UseVisualStyleBackColor = True
        '
        'lbldongdienthoai
        '
        Me.lbldongdienthoai.AutoSize = True
        Me.lbldongdienthoai.Location = New System.Drawing.Point(18, 161)
        Me.lbldongdienthoai.Name = "lbldongdienthoai"
        Me.lbldongdienthoai.Size = New System.Drawing.Size(41, 13)
        Me.lbldongdienthoai.TabIndex = 2
        Me.lbldongdienthoai.Text = "MSNV:"
        '
        'lblmatkhau
        '
        Me.lblmatkhau.AutoSize = True
        Me.lblmatkhau.Location = New System.Drawing.Point(18, 120)
        Me.lblmatkhau.Name = "lblmatkhau"
        Me.lblmatkhau.Size = New System.Drawing.Size(55, 13)
        Me.lblmatkhau.TabIndex = 1
        Me.lblmatkhau.Text = "Mật khẩu:"
        '
        'lbltaikhoan
        '
        Me.lbltaikhoan.AutoSize = True
        Me.lbltaikhoan.Location = New System.Drawing.Point(18, 81)
        Me.lbltaikhoan.Name = "lbltaikhoan"
        Me.lbltaikhoan.Size = New System.Drawing.Size(58, 13)
        Me.lbltaikhoan.TabIndex = 0
        Me.lbltaikhoan.Text = "Tài khoản:"
        '
        'ptblogo
        '
        Me.ptblogo.BackgroundImage = CType(resources.GetObject("ptblogo.BackgroundImage"), System.Drawing.Image)
        Me.ptblogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ptblogo.Location = New System.Drawing.Point(191, 12)
        Me.ptblogo.Name = "ptblogo"
        Me.ptblogo.Size = New System.Drawing.Size(637, 104)
        Me.ptblogo.TabIndex = 12
        Me.ptblogo.TabStop = False
        '
        'ptboppo
        '
        Me.ptboppo.BackgroundImage = CType(resources.GetObject("ptboppo.BackgroundImage"), System.Drawing.Image)
        Me.ptboppo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ptboppo.ErrorImage = Nothing
        Me.ptboppo.InitialImage = Nothing
        Me.ptboppo.Location = New System.Drawing.Point(12, 12)
        Me.ptboppo.Name = "ptboppo"
        Me.ptboppo.Size = New System.Drawing.Size(172, 416)
        Me.ptboppo.TabIndex = 11
        Me.ptboppo.TabStop = False
        '
        'GiaodienloginStaff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(840, 503)
        Me.Controls.Add(Me.lblbanquyen)
        Me.Controls.Add(Me.pnldanhsach)
        Me.Controls.Add(Me.ptblogo)
        Me.Controls.Add(Me.ptboppo)
        Me.Name = "GiaodienloginStaff"
        Me.Text = "GiaodienloginStaff"
        Me.pnldanhsach.ResumeLayout(False)
        Me.pnldanhsach.PerformLayout()
        CType(Me.ptblogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptboppo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblbanquyen As System.Windows.Forms.Label
    Friend WithEvents pnldanhsach As System.Windows.Forms.Panel
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents btnchontruycap As System.Windows.Forms.Button
    Friend WithEvents txtmsnv As System.Windows.Forms.TextBox
    Friend WithEvents lblchude As System.Windows.Forms.Label
    Friend WithEvents txtpass As System.Windows.Forms.TextBox
    Friend WithEvents txtaccount As System.Windows.Forms.TextBox
    Friend WithEvents chkforhuman As System.Windows.Forms.CheckBox
    Friend WithEvents btnlogin As System.Windows.Forms.Button
    Friend WithEvents lbldongdienthoai As System.Windows.Forms.Label
    Friend WithEvents lblmatkhau As System.Windows.Forms.Label
    Friend WithEvents lbltaikhoan As System.Windows.Forms.Label
    Friend WithEvents ptblogo As System.Windows.Forms.PictureBox
    Friend WithEvents ptboppo As System.Windows.Forms.PictureBox
End Class
