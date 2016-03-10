<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Quản_lý_bán_hàng_cho_Staff
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Quản_lý_bán_hàng_cho_Staff))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgvhienthistaff = New System.Windows.Forms.DataGridView()
        Me.btntrovestaff = New System.Windows.Forms.Button()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtmakhachhang = New System.Windows.Forms.TextBox()
        Me.txttenkhachhang = New System.Windows.Forms.TextBox()
        Me.txtdiachi = New System.Windows.Forms.TextBox()
        Me.txtsodienthoaikh = New System.Windows.Forms.TextBox()
        Me.ptbavatar = New System.Windows.Forms.PictureBox()
        Me.btnseach = New System.Windows.Forms.Button()
        Me.btnaddstaff = New System.Windows.Forms.Button()
        Me.btndelstaff = New System.Windows.Forms.Button()
        Me.btneditstaff = New System.Windows.Forms.Button()
        CType(Me.dgvhienthistaff, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptbavatar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(749, 284)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 33
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(289, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 13)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Mã  khách hàng:"
        '
        'dgvhienthistaff
        '
        Me.dgvhienthistaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvhienthistaff.Location = New System.Drawing.Point(14, 242)
        Me.dgvhienthistaff.Name = "dgvhienthistaff"
        Me.dgvhienthistaff.Size = New System.Drawing.Size(636, 238)
        Me.dgvhienthistaff.TabIndex = 30
        '
        'btntrovestaff
        '
        Me.btntrovestaff.Location = New System.Drawing.Point(614, 12)
        Me.btntrovestaff.Name = "btntrovestaff"
        Me.btntrovestaff.Size = New System.Drawing.Size(117, 23)
        Me.btntrovestaff.TabIndex = 42
        Me.btntrovestaff.Text = "Trở về Trang Chủ"
        Me.btntrovestaff.UseVisualStyleBackColor = True
        '
        'btnclose
        '
        Me.btnclose.Location = New System.Drawing.Point(737, 12)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(91, 23)
        Me.btnclose.TabIndex = 41
        Me.btnclose.Text = "Đóng ứng dụng"
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(288, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 13)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Tên khách hàng:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(288, 111)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Địa chỉ:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(288, 146)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 13)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "Số điện thoại:"
        '
        'txtmakhachhang
        '
        Me.txtmakhachhang.Location = New System.Drawing.Point(393, 34)
        Me.txtmakhachhang.Name = "txtmakhachhang"
        Me.txtmakhachhang.Size = New System.Drawing.Size(154, 20)
        Me.txtmakhachhang.TabIndex = 43
        '
        'txttenkhachhang
        '
        Me.txttenkhachhang.Location = New System.Drawing.Point(393, 71)
        Me.txttenkhachhang.Name = "txttenkhachhang"
        Me.txttenkhachhang.Size = New System.Drawing.Size(154, 20)
        Me.txttenkhachhang.TabIndex = 43
        '
        'txtdiachi
        '
        Me.txtdiachi.Location = New System.Drawing.Point(393, 108)
        Me.txtdiachi.Name = "txtdiachi"
        Me.txtdiachi.Size = New System.Drawing.Size(154, 20)
        Me.txtdiachi.TabIndex = 43
        '
        'txtsodienthoaikh
        '
        Me.txtsodienthoaikh.Location = New System.Drawing.Point(393, 143)
        Me.txtsodienthoaikh.Name = "txtsodienthoaikh"
        Me.txtsodienthoaikh.Size = New System.Drawing.Size(154, 20)
        Me.txtsodienthoaikh.TabIndex = 43
        '
        'ptbavatar
        '
        Me.ptbavatar.BackgroundImage = CType(resources.GetObject("ptbavatar.BackgroundImage"), System.Drawing.Image)
        Me.ptbavatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ptbavatar.ErrorImage = Nothing
        Me.ptbavatar.InitialImage = Nothing
        Me.ptbavatar.Location = New System.Drawing.Point(14, 12)
        Me.ptbavatar.Name = "ptbavatar"
        Me.ptbavatar.Size = New System.Drawing.Size(200, 205)
        Me.ptbavatar.TabIndex = 37
        Me.ptbavatar.TabStop = False
        '
        'btnseach
        '
        Me.btnseach.Image = Global.ASM_Ps03254.My.Resources.Resources.Untitled_5
        Me.btnseach.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnseach.Location = New System.Drawing.Point(718, 242)
        Me.btnseach.Name = "btnseach"
        Me.btnseach.Size = New System.Drawing.Size(108, 53)
        Me.btnseach.TabIndex = 36
        Me.btnseach.Text = "Seach"
        Me.btnseach.UseVisualStyleBackColor = True
        '
        'btnaddstaff
        '
        Me.btnaddstaff.Image = CType(resources.GetObject("btnaddstaff.Image"), System.Drawing.Image)
        Me.btnaddstaff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnaddstaff.Location = New System.Drawing.Point(718, 309)
        Me.btnaddstaff.Name = "btnaddstaff"
        Me.btnaddstaff.Size = New System.Drawing.Size(108, 53)
        Me.btnaddstaff.TabIndex = 36
        Me.btnaddstaff.Text = "Add"
        Me.btnaddstaff.UseVisualStyleBackColor = True
        '
        'btndelstaff
        '
        Me.btndelstaff.Image = CType(resources.GetObject("btndelstaff.Image"), System.Drawing.Image)
        Me.btndelstaff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btndelstaff.Location = New System.Drawing.Point(718, 427)
        Me.btndelstaff.Name = "btndelstaff"
        Me.btndelstaff.Size = New System.Drawing.Size(108, 53)
        Me.btndelstaff.TabIndex = 32
        Me.btndelstaff.Text = "Delete"
        Me.btndelstaff.UseVisualStyleBackColor = True
        '
        'btneditstaff
        '
        Me.btneditstaff.Image = CType(resources.GetObject("btneditstaff.Image"), System.Drawing.Image)
        Me.btneditstaff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btneditstaff.Location = New System.Drawing.Point(718, 368)
        Me.btneditstaff.Name = "btneditstaff"
        Me.btneditstaff.Size = New System.Drawing.Size(108, 53)
        Me.btneditstaff.TabIndex = 31
        Me.btneditstaff.Text = "Edit"
        Me.btneditstaff.UseVisualStyleBackColor = True
        '
        'Quản_lý_bán_hàng_cho_Staff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(840, 503)
        Me.Controls.Add(Me.txtsodienthoaikh)
        Me.Controls.Add(Me.txtdiachi)
        Me.Controls.Add(Me.txttenkhachhang)
        Me.Controls.Add(Me.txtmakhachhang)
        Me.Controls.Add(Me.btntrovestaff)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.ptbavatar)
        Me.Controls.Add(Me.btnseach)
        Me.Controls.Add(Me.btnaddstaff)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btndelstaff)
        Me.Controls.Add(Me.btneditstaff)
        Me.Controls.Add(Me.dgvhienthistaff)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "Quản_lý_bán_hàng_cho_Staff"
        Me.Text = "Quản lý khách hàng"
        CType(Me.dgvhienthistaff, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptbavatar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ptbavatar As System.Windows.Forms.PictureBox
    Friend WithEvents btnaddstaff As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btndelstaff As System.Windows.Forms.Button
    Friend WithEvents btneditstaff As System.Windows.Forms.Button
    Friend WithEvents dgvhienthistaff As System.Windows.Forms.DataGridView
    Friend WithEvents btntrovestaff As System.Windows.Forms.Button
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtmakhachhang As System.Windows.Forms.TextBox
    Friend WithEvents txttenkhachhang As System.Windows.Forms.TextBox
    Friend WithEvents txtdiachi As System.Windows.Forms.TextBox
    Friend WithEvents txtsodienthoaikh As System.Windows.Forms.TextBox
    Friend WithEvents btnseach As System.Windows.Forms.Button
End Class
