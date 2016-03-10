<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GiaodienloginchoAdmin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GiaodienloginchoAdmin))
        Me.lblbanquyen = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.btnchontruycap = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtpassadmin = New System.Windows.Forms.TextBox()
        Me.txtaccountadmin = New System.Windows.Forms.TextBox()
        Me.chkforhumanshop = New System.Windows.Forms.CheckBox()
        Me.btnloginshop = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ptblogo = New System.Windows.Forms.PictureBox()
        Me.ptboppo = New System.Windows.Forms.PictureBox()
        Me.Panel2.SuspendLayout()
        CType(Me.ptblogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptboppo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblbanquyen
        '
        Me.lblbanquyen.BackColor = System.Drawing.Color.White
        Me.lblbanquyen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblbanquyen.Location = New System.Drawing.Point(12, 429)
        Me.lblbanquyen.Name = "lblbanquyen"
        Me.lblbanquyen.Size = New System.Drawing.Size(816, 63)
        Me.lblbanquyen.TabIndex = 18
        Me.lblbanquyen.Text = "Phần mềm quản lý điện thoại Control Smart thuộc về @ Lê Thái Đạt" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Mọi hành vi sao" & _
    " chép điều là vi phạm pháp luật" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Chi tiết liên hệ 0916275xxx"
        Me.lblbanquyen.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnclose)
        Me.Panel2.Controls.Add(Me.btnchontruycap)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.txtpassadmin)
        Me.Panel2.Controls.Add(Me.txtaccountadmin)
        Me.Panel2.Controls.Add(Me.chkforhumanshop)
        Me.Panel2.Controls.Add(Me.btnloginshop)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(191, 120)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(637, 306)
        Me.Panel2.TabIndex = 17
        '
        'btnclose
        '
        Me.btnclose.Location = New System.Drawing.Point(477, 248)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(91, 23)
        Me.btnclose.TabIndex = 17
        Me.btnclose.Text = "Đóng ứng dụng"
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'btnchontruycap
        '
        Me.btnchontruycap.Location = New System.Drawing.Point(354, 248)
        Me.btnchontruycap.Name = "btnchontruycap"
        Me.btnchontruycap.Size = New System.Drawing.Size(117, 23)
        Me.btnchontruycap.TabIndex = 16
        Me.btnchontruycap.Text = "Chọn quyền sử dụng"
        Me.btnchontruycap.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(129, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(444, 62)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Phần mềm quản lý bán điện thoại " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "                                      Control S" & _
    "mart"
        '
        'txtpassadmin
        '
        Me.txtpassadmin.Location = New System.Drawing.Point(137, 145)
        Me.txtpassadmin.MaxLength = 7
        Me.txtpassadmin.Name = "txtpassadmin"
        Me.txtpassadmin.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpassadmin.Size = New System.Drawing.Size(431, 20)
        Me.txtpassadmin.TabIndex = 8
        '
        'txtaccountadmin
        '
        Me.txtaccountadmin.Location = New System.Drawing.Point(137, 106)
        Me.txtaccountadmin.MaxLength = 7
        Me.txtaccountadmin.Name = "txtaccountadmin"
        Me.txtaccountadmin.Size = New System.Drawing.Size(431, 20)
        Me.txtaccountadmin.TabIndex = 7
        '
        'chkforhumanshop
        '
        Me.chkforhumanshop.AutoSize = True
        Me.chkforhumanshop.Location = New System.Drawing.Point(403, 205)
        Me.chkforhumanshop.Name = "chkforhumanshop"
        Me.chkforhumanshop.Size = New System.Drawing.Size(159, 17)
        Me.chkforhumanshop.TabIndex = 6
        Me.chkforhumanshop.Text = "Tôi không phải là người máy"
        Me.chkforhumanshop.UseVisualStyleBackColor = True
        '
        'btnloginshop
        '
        Me.btnloginshop.Location = New System.Drawing.Point(273, 248)
        Me.btnloginshop.Name = "btnloginshop"
        Me.btnloginshop.Size = New System.Drawing.Size(75, 23)
        Me.btnloginshop.TabIndex = 4
        Me.btnloginshop.Text = "Đăng nhập"
        Me.btnloginshop.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 148)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Mật khẩu:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Tài khoản:"
        '
        'ptblogo
        '
        Me.ptblogo.BackgroundImage = CType(resources.GetObject("ptblogo.BackgroundImage"), System.Drawing.Image)
        Me.ptblogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ptblogo.Location = New System.Drawing.Point(191, 10)
        Me.ptblogo.Name = "ptblogo"
        Me.ptblogo.Size = New System.Drawing.Size(637, 104)
        Me.ptblogo.TabIndex = 16
        Me.ptblogo.TabStop = False
        '
        'ptboppo
        '
        Me.ptboppo.BackgroundImage = CType(resources.GetObject("ptboppo.BackgroundImage"), System.Drawing.Image)
        Me.ptboppo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ptboppo.ErrorImage = Nothing
        Me.ptboppo.InitialImage = Nothing
        Me.ptboppo.Location = New System.Drawing.Point(12, 10)
        Me.ptboppo.Name = "ptboppo"
        Me.ptboppo.Size = New System.Drawing.Size(172, 416)
        Me.ptboppo.TabIndex = 15
        Me.ptboppo.TabStop = False
        '
        'GiaodienloginchoAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(840, 503)
        Me.Controls.Add(Me.lblbanquyen)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.ptblogo)
        Me.Controls.Add(Me.ptboppo)
        Me.Name = "GiaodienloginchoAdmin"
        Me.Text = "GiaodienloginchoAdmin"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.ptblogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptboppo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblbanquyen As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents btnchontruycap As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtpassadmin As System.Windows.Forms.TextBox
    Friend WithEvents txtaccountadmin As System.Windows.Forms.TextBox
    Friend WithEvents chkforhumanshop As System.Windows.Forms.CheckBox
    Friend WithEvents btnloginshop As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ptblogo As System.Windows.Forms.PictureBox
    Friend WithEvents ptboppo As System.Windows.Forms.PictureBox
End Class
