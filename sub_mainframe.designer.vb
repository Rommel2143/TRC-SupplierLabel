<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sub_mainframe
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(sub_mainframe))
        Me.userstrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateSystemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PrintLabelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.error_panel = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.btn_close = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2PictureBox3 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.lbl_error = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Guna2PictureBox2 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.lbl_calendar = New System.Windows.Forms.Label()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.lbl_tittle = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.error_panel.SuspendLayout()
        CType(Me.btn_close, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'userstrip
        '
        Me.userstrip.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.userstrip.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem4, Me.UpdateSystemToolStripMenuItem, Me.ToolStripMenuItem5, Me.ToolStripMenuItem2, Me.ToolStripMenuItem3})
        Me.userstrip.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.userstrip.Image = CType(resources.GetObject("userstrip.Image"), System.Drawing.Image)
        Me.userstrip.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.userstrip.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.userstrip.Margin = New System.Windows.Forms.Padding(0, 0, 10, 0)
        Me.userstrip.Name = "userstrip"
        Me.userstrip.Size = New System.Drawing.Size(86, 37)
        Me.userstrip.Text = "User"
        Me.userstrip.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.userstrip.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripMenuItem4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ToolStripMenuItem4.Image = CType(resources.GetObject("ToolStripMenuItem4.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(232, 38)
        Me.ToolStripMenuItem4.Text = "Suggest to improve"
        '
        'UpdateSystemToolStripMenuItem
        '
        Me.UpdateSystemToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.UpdateSystemToolStripMenuItem.Image = CType(resources.GetObject("UpdateSystemToolStripMenuItem.Image"), System.Drawing.Image)
        Me.UpdateSystemToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.UpdateSystemToolStripMenuItem.Name = "UpdateSystemToolStripMenuItem"
        Me.UpdateSystemToolStripMenuItem.Size = New System.Drawing.Size(232, 38)
        Me.UpdateSystemToolStripMenuItem.Text = "Update System"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ToolStripMenuItem5.Image = CType(resources.GetObject("ToolStripMenuItem5.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(232, 38)
        Me.ToolStripMenuItem5.Text = "Device info."
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripMenuItem2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ToolStripMenuItem2.Image = CType(resources.GetObject("ToolStripMenuItem2.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(232, 38)
        Me.ToolStripMenuItem2.Text = "Logout"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripMenuItem3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ToolStripMenuItem3.Image = CType(resources.GetObject("ToolStripMenuItem3.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(232, 38)
        Me.ToolStripMenuItem3.Text = "Exit"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.userstrip, Me.PrintLabelToolStripMenuItem})
        Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1044, 41)
        Me.MenuStrip1.TabIndex = 13
        '
        'PrintLabelToolStripMenuItem
        '
        Me.PrintLabelToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.PrintLabelToolStripMenuItem.Image = CType(resources.GetObject("PrintLabelToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PrintLabelToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.PrintLabelToolStripMenuItem.Name = "PrintLabelToolStripMenuItem"
        Me.PrintLabelToolStripMenuItem.Size = New System.Drawing.Size(128, 37)
        Me.PrintLabelToolStripMenuItem.Text = "Print Label"
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 92)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1044, 696)
        Me.Panel1.TabIndex = 14
        '
        'error_panel
        '
        Me.error_panel.Controls.Add(Me.btn_close)
        Me.error_panel.Controls.Add(Me.Guna2PictureBox3)
        Me.error_panel.Controls.Add(Me.lbl_error)
        Me.error_panel.Dock = System.Windows.Forms.DockStyle.Top
        Me.error_panel.FillColor = System.Drawing.Color.Red
        Me.error_panel.FillColor2 = System.Drawing.Color.Salmon
        Me.error_panel.Location = New System.Drawing.Point(0, 65)
        Me.error_panel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.error_panel.Name = "error_panel"
        Me.error_panel.Size = New System.Drawing.Size(1044, 27)
        Me.error_panel.TabIndex = 34
        Me.error_panel.Visible = False
        '
        'btn_close
        '
        Me.btn_close.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btn_close.BackColor = System.Drawing.Color.Transparent
        Me.btn_close.Image = CType(resources.GetObject("btn_close.Image"), System.Drawing.Image)
        Me.btn_close.ImageRotate = 0!
        Me.btn_close.Location = New System.Drawing.Point(1020, 5)
        Me.btn_close.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(15, 15)
        Me.btn_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_close.TabIndex = 2
        Me.btn_close.TabStop = False
        '
        'Guna2PictureBox3
        '
        Me.Guna2PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox3.Image = CType(resources.GetObject("Guna2PictureBox3.Image"), System.Drawing.Image)
        Me.Guna2PictureBox3.ImageRotate = 0!
        Me.Guna2PictureBox3.Location = New System.Drawing.Point(12, 2)
        Me.Guna2PictureBox3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Guna2PictureBox3.Name = "Guna2PictureBox3"
        Me.Guna2PictureBox3.Size = New System.Drawing.Size(23, 23)
        Me.Guna2PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox3.TabIndex = 1
        Me.Guna2PictureBox3.TabStop = False
        '
        'lbl_error
        '
        Me.lbl_error.AutoSize = True
        Me.lbl_error.BackColor = System.Drawing.Color.Transparent
        Me.lbl_error.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_error.ForeColor = System.Drawing.Color.White
        Me.lbl_error.Location = New System.Drawing.Point(41, 6)
        Me.lbl_error.Name = "lbl_error"
        Me.lbl_error.Size = New System.Drawing.Size(119, 17)
        Me.lbl_error.TabIndex = 0
        Me.lbl_error.Text = "Invalid Credentials"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Panel2.Controls.Add(Me.Guna2PictureBox2)
        Me.Panel2.Controls.Add(Me.lbl_calendar)
        Me.Panel2.Controls.Add(Me.Guna2PictureBox1)
        Me.Panel2.Controls.Add(Me.lbl_tittle)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 41)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1044, 24)
        Me.Panel2.TabIndex = 33
        '
        'Guna2PictureBox2
        '
        Me.Guna2PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox2.Image = CType(resources.GetObject("Guna2PictureBox2.Image"), System.Drawing.Image)
        Me.Guna2PictureBox2.ImageRotate = 0!
        Me.Guna2PictureBox2.Location = New System.Drawing.Point(19, 3)
        Me.Guna2PictureBox2.Name = "Guna2PictureBox2"
        Me.Guna2PictureBox2.Size = New System.Drawing.Size(20, 18)
        Me.Guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox2.TabIndex = 4
        Me.Guna2PictureBox2.TabStop = False
        '
        'lbl_calendar
        '
        Me.lbl_calendar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_calendar.AutoSize = True
        Me.lbl_calendar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_calendar.ForeColor = System.Drawing.Color.White
        Me.lbl_calendar.Location = New System.Drawing.Point(933, 6)
        Me.lbl_calendar.Name = "lbl_calendar"
        Me.lbl_calendar.Size = New System.Drawing.Size(99, 15)
        Me.lbl_calendar.TabIndex = 3
        Me.lbl_calendar.Text = "MMMM-dd-yyyy"
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(907, 3)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(20, 18)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 2
        Me.Guna2PictureBox1.TabStop = False
        '
        'lbl_tittle
        '
        Me.lbl_tittle.AutoSize = True
        Me.lbl_tittle.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tittle.ForeColor = System.Drawing.Color.White
        Me.lbl_tittle.Location = New System.Drawing.Point(43, 2)
        Me.lbl_tittle.Name = "lbl_tittle"
        Me.lbl_tittle.Size = New System.Drawing.Size(0, 20)
        Me.lbl_tittle.TabIndex = 0
        '
        'sub_mainframe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1044, 788)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.error_panel)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "sub_mainframe"
        Me.Text = "sub_mainframe"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.error_panel.ResumeLayout(False)
        Me.error_panel.PerformLayout()
        CType(Me.btn_close, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents userstrip As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents UpdateSystemToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents Panel1 As Panel
    Friend WithEvents error_panel As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents btn_close As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2PictureBox3 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents lbl_error As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Guna2PictureBox2 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents lbl_calendar As Label
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents lbl_tittle As Label
    Friend WithEvents PrintLabelToolStripMenuItem As ToolStripMenuItem
End Class
