<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class print_labelform
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Guna2TabControl1 = New Guna.UI2.WinForms.Guna2TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.datagrid1 = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.boxcol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.lbl_mold = New System.Windows.Forms.Label()
        Me.lbl_partcode = New System.Windows.Forms.Label()
        Me.lbl_partname = New System.Windows.Forms.Label()
        Me.num_count = New Guna.UI2.WinForms.Guna2NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmb_shift = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_serial = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_materiallot = New Guna.UI2.WinForms.Guna2TextBox()
        Me.num_qty = New Guna.UI2.WinForms.Guna2NumericUpDown()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.txt_lotnumber = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.datagrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel1.SuspendLayout()
        Me.Guna2Panel2.SuspendLayout()
        CType(Me.num_count, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num_qty, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(3, 3)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1143, 678)
        Me.CrystalReportViewer1.TabIndex = 1
        '
        'Guna2TabControl1
        '
        Me.Guna2TabControl1.Controls.Add(Me.TabPage1)
        Me.Guna2TabControl1.Controls.Add(Me.TabPage2)
        Me.Guna2TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2TabControl1.ItemSize = New System.Drawing.Size(180, 40)
        Me.Guna2TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2TabControl1.Name = "Guna2TabControl1"
        Me.Guna2TabControl1.SelectedIndex = 0
        Me.Guna2TabControl1.Size = New System.Drawing.Size(1157, 732)
        Me.Guna2TabControl1.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty
        Me.Guna2TabControl1.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Guna2TabControl1.TabButtonHoverState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Guna2TabControl1.TabButtonHoverState.ForeColor = System.Drawing.Color.White
        Me.Guna2TabControl1.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Guna2TabControl1.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty
        Me.Guna2TabControl1.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Guna2TabControl1.TabButtonIdleState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Guna2TabControl1.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.Guna2TabControl1.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Guna2TabControl1.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty
        Me.Guna2TabControl1.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Guna2TabControl1.TabButtonSelectedState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Guna2TabControl1.TabButtonSelectedState.ForeColor = System.Drawing.Color.White
        Me.Guna2TabControl1.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TabControl1.TabButtonSize = New System.Drawing.Size(180, 40)
        Me.Guna2TabControl1.TabIndex = 3
        Me.Guna2TabControl1.TabMenuBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.Guna2TabControl1.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.datagrid1)
        Me.TabPage1.Controls.Add(Me.Guna2Panel1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 44)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1149, 684)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Create Label"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'datagrid1
        '
        Me.datagrid1.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.datagrid1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datagrid1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.datagrid1.ColumnHeadersHeight = 19
        Me.datagrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.datagrid1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.boxcol, Me.Column1})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.datagrid1.DefaultCellStyle = DataGridViewCellStyle3
        Me.datagrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.datagrid1.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.datagrid1.Location = New System.Drawing.Point(3, 187)
        Me.datagrid1.Name = "datagrid1"
        Me.datagrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datagrid1.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.datagrid1.RowHeadersVisible = False
        Me.datagrid1.Size = New System.Drawing.Size(1143, 494)
        Me.datagrid1.TabIndex = 4
        Me.datagrid1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.datagrid1.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.datagrid1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.datagrid1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.datagrid1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.datagrid1.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.datagrid1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.datagrid1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.datagrid1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.datagrid1.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datagrid1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.datagrid1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.datagrid1.ThemeStyle.HeaderStyle.Height = 19
        Me.datagrid1.ThemeStyle.ReadOnly = False
        Me.datagrid1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.datagrid1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.datagrid1.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datagrid1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.datagrid1.ThemeStyle.RowsStyle.Height = 22
        Me.datagrid1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.datagrid1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'boxcol
        '
        Me.boxcol.HeaderText = "Box No."
        Me.boxcol.Name = "boxcol"
        '
        'Column1
        '
        Me.Column1.HeaderText = "QRcode"
        Me.Column1.Name = "Column1"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.txt_lotnumber)
        Me.Guna2Panel1.Controls.Add(Me.Guna2Button1)
        Me.Guna2Panel1.Controls.Add(Me.Guna2Panel2)
        Me.Guna2Panel1.Controls.Add(Me.num_count)
        Me.Guna2Panel1.Controls.Add(Me.Label6)
        Me.Guna2Panel1.Controls.Add(Me.Label5)
        Me.Guna2Panel1.Controls.Add(Me.cmb_shift)
        Me.Guna2Panel1.Controls.Add(Me.Label4)
        Me.Guna2Panel1.Controls.Add(Me.txt_serial)
        Me.Guna2Panel1.Controls.Add(Me.Label2)
        Me.Guna2Panel1.Controls.Add(Me.Label1)
        Me.Guna2Panel1.Controls.Add(Me.txt_materiallot)
        Me.Guna2Panel1.Controls.Add(Me.num_qty)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(1143, 184)
        Me.Guna2Panel1.TabIndex = 3
        '
        'Guna2Button1
        '
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.FillColor = System.Drawing.Color.DarkSlateBlue
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.Location = New System.Drawing.Point(678, 87)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Size = New System.Drawing.Size(125, 54)
        Me.Guna2Button1.TabIndex = 16
        Me.Guna2Button1.Text = "Create"
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.Controls.Add(Me.lbl_mold)
        Me.Guna2Panel2.Controls.Add(Me.lbl_partcode)
        Me.Guna2Panel2.Controls.Add(Me.lbl_partname)
        Me.Guna2Panel2.FillColor = System.Drawing.Color.White
        Me.Guna2Panel2.Location = New System.Drawing.Point(14, 19)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.ShadowDecoration.Color = System.Drawing.Color.Silver
        Me.Guna2Panel2.ShadowDecoration.Enabled = True
        Me.Guna2Panel2.Size = New System.Drawing.Size(233, 83)
        Me.Guna2Panel2.TabIndex = 15
        '
        'lbl_mold
        '
        Me.lbl_mold.AutoSize = True
        Me.lbl_mold.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_mold.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lbl_mold.Location = New System.Drawing.Point(17, 53)
        Me.lbl_mold.Name = "lbl_mold"
        Me.lbl_mold.Size = New System.Drawing.Size(35, 15)
        Me.lbl_mold.TabIndex = 18
        Me.lbl_mold.Text = "mold"
        '
        'lbl_partcode
        '
        Me.lbl_partcode.AutoSize = True
        Me.lbl_partcode.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_partcode.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lbl_partcode.Location = New System.Drawing.Point(17, 38)
        Me.lbl_partcode.Name = "lbl_partcode"
        Me.lbl_partcode.Size = New System.Drawing.Size(54, 15)
        Me.lbl_partcode.TabIndex = 17
        Me.lbl_partcode.Text = "Partcode"
        '
        'lbl_partname
        '
        Me.lbl_partname.AutoSize = True
        Me.lbl_partname.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_partname.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lbl_partname.Location = New System.Drawing.Point(16, 14)
        Me.lbl_partname.Name = "lbl_partname"
        Me.lbl_partname.Size = New System.Drawing.Size(79, 21)
        Me.lbl_partname.TabIndex = 16
        Me.lbl_partname.Text = "Partname"
        '
        'num_count
        '
        Me.num_count.BackColor = System.Drawing.Color.Transparent
        Me.num_count.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.num_count.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.num_count.Location = New System.Drawing.Point(286, 105)
        Me.num_count.Name = "num_count"
        Me.num_count.Size = New System.Drawing.Size(125, 36)
        Me.num_count.TabIndex = 14
        Me.num_count.UpDownButtonFillColor = System.Drawing.Color.DarkSlateBlue
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label6.Location = New System.Drawing.Point(283, 87)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 15)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Label count"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label5.Location = New System.Drawing.Point(675, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 15)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Shift"
        '
        'cmb_shift
        '
        Me.cmb_shift.BackColor = System.Drawing.Color.Transparent
        Me.cmb_shift.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmb_shift.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_shift.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmb_shift.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmb_shift.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmb_shift.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmb_shift.ItemHeight = 30
        Me.cmb_shift.Items.AddRange(New Object() {"Day", "Night"})
        Me.cmb_shift.Location = New System.Drawing.Point(678, 37)
        Me.cmb_shift.Name = "cmb_shift"
        Me.cmb_shift.Size = New System.Drawing.Size(125, 36)
        Me.cmb_shift.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label4.Location = New System.Drawing.Point(452, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 15)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "serial"
        '
        'txt_serial
        '
        Me.txt_serial.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_serial.DefaultText = ""
        Me.txt_serial.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_serial.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_serial.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_serial.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_serial.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_serial.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_serial.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_serial.Location = New System.Drawing.Point(455, 105)
        Me.txt_serial.Name = "txt_serial"
        Me.txt_serial.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_serial.PlaceholderText = ""
        Me.txt_serial.SelectedText = ""
        Me.txt_serial.Size = New System.Drawing.Size(200, 36)
        Me.txt_serial.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(452, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 15)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Material Lot"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(283, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 15)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Qty"
        '
        'txt_materiallot
        '
        Me.txt_materiallot.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_materiallot.DefaultText = ""
        Me.txt_materiallot.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_materiallot.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_materiallot.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_materiallot.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_materiallot.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_materiallot.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_materiallot.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_materiallot.Location = New System.Drawing.Point(455, 37)
        Me.txt_materiallot.Name = "txt_materiallot"
        Me.txt_materiallot.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_materiallot.PlaceholderText = ""
        Me.txt_materiallot.SelectedText = ""
        Me.txt_materiallot.Size = New System.Drawing.Size(200, 36)
        Me.txt_materiallot.TabIndex = 3
        '
        'num_qty
        '
        Me.num_qty.BackColor = System.Drawing.Color.Transparent
        Me.num_qty.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.num_qty.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.num_qty.Location = New System.Drawing.Point(286, 37)
        Me.num_qty.Name = "num_qty"
        Me.num_qty.Size = New System.Drawing.Size(125, 36)
        Me.num_qty.TabIndex = 2
        Me.num_qty.UpDownButtonFillColor = System.Drawing.Color.DarkSlateBlue
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.CrystalReportViewer1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 44)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1149, 684)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Preview"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'txt_lotnumber
        '
        Me.txt_lotnumber.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_lotnumber.DefaultText = ""
        Me.txt_lotnumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_lotnumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_lotnumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_lotnumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_lotnumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_lotnumber.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_lotnumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_lotnumber.Location = New System.Drawing.Point(14, 108)
        Me.txt_lotnumber.Name = "txt_lotnumber"
        Me.txt_lotnumber.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_lotnumber.PlaceholderText = "Lotnumber..."
        Me.txt_lotnumber.SelectedText = ""
        Me.txt_lotnumber.Size = New System.Drawing.Size(233, 36)
        Me.txt_lotnumber.TabIndex = 17
        '
        'print_labelform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1157, 732)
        Me.Controls.Add(Me.Guna2TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "print_labelform"
        Me.Text = "print_label"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Guna2TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.datagrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        CType(Me.num_count, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num_qty, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Guna2TabControl1 As Guna.UI2.WinForms.Guna2TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents datagrid1 As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents num_count As Guna.UI2.WinForms.Guna2NumericUpDown
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cmb_shift As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_serial As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_materiallot As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents num_qty As Guna.UI2.WinForms.Guna2NumericUpDown
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lbl_mold As Label
    Friend WithEvents lbl_partcode As Label
    Friend WithEvents lbl_partname As Label
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents boxcol As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents txt_lotnumber As Guna.UI2.WinForms.Guna2TextBox
End Class
