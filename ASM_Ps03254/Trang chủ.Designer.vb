<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Trang_chủ
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Trang_chủ))
        Me.lblbanquyen = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ptbpicturesanpham = New System.Windows.Forms.PictureBox()
        Me.ptboppo = New System.Windows.Forms.PictureBox()
        Me.btndangkystaff = New System.Windows.Forms.Button()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.btnloginadmin = New System.Windows.Forms.Button()
        Me.lbltitle = New System.Windows.Forms.Label()
        Me.btnloginstaff = New System.Windows.Forms.Button()
        Me.ptblogo = New System.Windows.Forms.PictureBox()
        Me.ptbhome = New System.Windows.Forms.PictureBox()
        Me.Panel2.SuspendLayout()
        CType(Me.ptbpicturesanpham, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptboppo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptblogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptbhome, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblbanquyen
        '
        Me.lblbanquyen.BackColor = System.Drawing.SystemColors.Control
        Me.lblbanquyen.Location = New System.Drawing.Point(12, 431)
        Me.lblbanquyen.Name = "lblbanquyen"
        Me.lblbanquyen.Size = New System.Drawing.Size(816, 63)
        Me.lblbanquyen.TabIndex = 18
        Me.lblbanquyen.Text = "Phần mềm quản lý điện thoại Control Smart thuộc về @ Lê Thái Đạt" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Mọi hành vi sao" & _
    " chép điều là vi phạm pháp luật" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Chi tiết liên hệ 0916275xxx"
        Me.lblbanquyen.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.ptbpicturesanpham)
        Me.Panel2.Controls.Add(Me.ptboppo)
        Me.Panel2.Controls.Add(Me.btndangkystaff)
        Me.Panel2.Controls.Add(Me.btnclose)
        Me.Panel2.Controls.Add(Me.btnloginadmin)
        Me.Panel2.Controls.Add(Me.lbltitle)
        Me.Panel2.Controls.Add(Me.btnloginstaff)
        Me.Panel2.Location = New System.Drawing.Point(191, 122)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(637, 306)
        Me.Panel2.TabIndex = 17
        '
        'ptbpicturesanpham
        '
        Me.ptbpicturesanpham.BackgroundImage = CType(resources.GetObject("ptbpicturesanpham.BackgroundImage"), System.Drawing.Image)
        Me.ptbpicturesanpham.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ptbpicturesanpham.ErrorImage = Nothing
        Me.ptbpicturesanpham.InitialImage = Nothing
        Me.ptbpicturesanpham.Location = New System.Drawing.Point(419, 67)
        Me.ptbpicturesanpham.Name = "ptbpicturesanpham"
        Me.ptbpicturesanpham.Size = New System.Drawing.Size(122, 114)
        Me.ptbpicturesanpham.TabIndex = 27
        Me.ptbpicturesanpham.TabStop = False
        '
        'ptboppo
        '
        Me.ptboppo.BackgroundImage = CType(resources.GetObject("ptboppo.BackgroundImage"), System.Drawing.Image)
        Me.ptboppo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ptboppo.ErrorImage = Nothing
        Me.ptboppo.InitialImage = Nothing
        Me.ptboppo.Location = New System.Drawing.Point(82, 55)
        Me.ptboppo.Name = "ptboppo"
        Me.ptboppo.Size = New System.Drawing.Size(148, 126)
        Me.ptboppo.TabIndex = 17
        Me.ptboppo.TabStop = False
        '
        'btndangkystaff
        '
        Me.btndangkystaff.Location = New System.Drawing.Point(36, 271)
        Me.btndangkystaff.Name = "btndangkystaff"
        Me.btndangkystaff.Size = New System.Drawing.Size(218, 23)
        Me.btndangkystaff.TabIndex = 12
        Me.btndangkystaff.Text = "Đăng ký tài khoản Staff"
        Me.btndangkystaff.UseVisualStyleBackColor = True
        '
        'btnclose
        '
        Me.btnclose.Location = New System.Drawing.Point(493, 271)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(91, 23)
        Me.btnclose.TabIndex = 11
        Me.btnclose.Text = "Đóng ứng dụng"
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'btnloginadmin
        '
        Me.btnloginadmin.Location = New System.Drawing.Point(366, 187)
        Me.btnloginadmin.Name = "btnloginadmin"
        Me.btnloginadmin.Size = New System.Drawing.Size(218, 36)
        Me.btnloginadmin.TabIndex = 10
        Me.btnloginadmin.Text = "Đăng nhập bằng quyền quản lý Admin"
        Me.btnloginadmin.UseVisualStyleBackColor = True
        '
        'lbltitle
        '
        Me.lbltitle.AutoSize = True
        Me.lbltitle.Font = New System.Drawing.Font("Times New Roman", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitle.ForeColor = System.Drawing.Color.Red
        Me.lbltitle.Location = New System.Drawing.Point(121, 2)
        Me.lbltitle.Name = "lbltitle"
        Me.lbltitle.Size = New System.Drawing.Size(444, 62)
        Me.lbltitle.TabIndex = 9
        Me.lbltitle.Text = "Phần mềm quản lý bán điện thoại " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "                                      Control S" & _
    "mart"
        '
        'btnloginstaff
        '
        Me.btnloginstaff.Location = New System.Drawing.Point(36, 187)
        Me.btnloginstaff.Name = "btnloginstaff"
        Me.btnloginstaff.Size = New System.Drawing.Size(218, 36)
        Me.btnloginstaff.TabIndex = 4
        Me.btnloginstaff.Text = "Đăng nhập bằng quyền Staff"
        Me.btnloginstaff.UseVisualStyleBackColor = True
        '
        'ptblogo
        '
        Me.ptblogo.BackgroundImage = CType(resources.GetObject("ptblogo.BackgroundImage"), System.Drawing.Image)
        Me.ptblogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ptblogo.Location = New System.Drawing.Point(191, 12)
        Me.ptblogo.Name = "ptblogo"
        Me.ptblogo.Size = New System.Drawing.Size(637, 104)
        Me.ptblogo.TabIndex = 16
        Me.ptblogo.TabStop = False
        '
        'ptbhome
        '
        Me.ptbhome.BackgroundImage = CType(resources.GetObject("ptbhome.BackgroundImage"), System.Drawing.Image)
        Me.ptbhome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ptbhome.ErrorImage = Nothing
        Me.ptbhome.InitialImage = Nothing
        Me.ptbhome.Location = New System.Drawing.Point(12, 12)
        Me.ptbhome.Name = "ptbhome"
        Me.ptbhome.Size = New System.Drawing.Size(172, 416)
        Me.ptbhome.TabIndex = 15
        Me.ptbhome.TabStop = False
        '
        'Trang_chủ
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(840, 503)
        Me.Controls.Add(Me.lblbanquyen)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.ptblogo)
        Me.Controls.Add(Me.ptbhome)
        Me.Name = "Trang_chủ"
        Me.Text = "Trang_chủ"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.ptbpicturesanpham, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptboppo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptblogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptbhome, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblbanquyen As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btndangkystaff As System.Windows.Forms.Button
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents btnloginadmin As System.Windows.Forms.Button
    Friend WithEvents lbltitle As System.Windows.Forms.Label
    Friend WithEvents btnloginstaff As System.Windows.Forms.Button
    Friend WithEvents ptblogo As System.Windows.Forms.PictureBox
    Friend WithEvents ptbhome As System.Windows.Forms.PictureBox
    Friend WithEvents ptboppo As System.Windows.Forms.PictureBox
    Friend WithEvents ptbpicturesanpham As System.Windows.Forms.PictureBox
End Class
