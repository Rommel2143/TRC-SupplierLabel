Imports MySql.Data.MySqlClient
Imports QRCoder
Imports System.IO
Public Class print_labelform
    Dim partno As String
    Dim partname As String
    Dim model As String
    Dim process As String
    Dim material As String
    Dim moldno As String
    Dim supplier As String
    Dim dt_records As New DataTable
    Dim lotnumber As String

    Dim qrcode As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public Sub loaddata(idno As Integer)
        viewdata("SELECT * FROM `item_masterlist` WHERE id = '" & idno & "'")
        If dr.Read = True Then
            partno = dr.GetString("partno")
            partname = dr.GetString("partname")
            model = dr.GetString("model")
            process = dr.GetString("process")
            material = dr.GetString("material")
            moldno = dr.GetInt32("moldno").ToString
            supplier = dr.GetString("supplier")
        End If


        lbl_partcode.Text = partno
        lbl_partname.Text = partname
        lbl_mold.Text = "Mold: " & moldno
    End Sub
    Private Sub loadrpt()
        'Dim myrpt As New print_serial
        Dim myrpt As New print_label
        ' Check if dt_records contains data
        If dt_records Is Nothing OrElse dt_records.Rows.Count = 0 Then
            MessageBox.Show("No data available for the report.")
            Exit Sub
        End If

        ' Clear existing report source
        CrystalReportViewer1.ReportSource = Nothing

        Try
            ' Get the table from the report
            Dim reportTable As CrystalDecisions.CrystalReports.Engine.Table = myrpt.Database.Tables("item_masterlist")
            If reportTable Is Nothing Then
                MessageBox.Show("Table 'resin_serial' not found in the report.")
                Exit Sub
            End If

            ' Set the DataSource for the report
            reportTable.SetDataSource(dt_records)
            CrystalReportViewer1.ReportSource = myrpt
        Catch ex As Exception
            MessageBox.Show("Error setting report data source: " & ex.Message)
        End Try
    End Sub
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click

        Try
            ' Clear the DataGridView and DataTable rows
            datagrid1.Rows.Clear()
            ' Clear only rows, columns are already added

            dt_records.Clear()
            ' Initialize the DataTable columns only once during form load
            If dt_records.Columns.Count = 0 Then
                dt_records.Columns.Add("partno", GetType(String))
                dt_records.Columns.Add("partname", GetType(String))
                dt_records.Columns.Add("model", GetType(String))
                dt_records.Columns.Add("process", GetType(String))
                dt_records.Columns.Add("material", GetType(String))
                dt_records.Columns.Add("moldno", GetType(String))
                dt_records.Columns.Add("supplier", GetType(String))
                dt_records.Columns.Add("qty", GetType(Integer))
                dt_records.Columns.Add("lot", GetType(String))
                dt_records.Columns.Add("box", GetType(Integer))
                dt_records.Columns.Add("proddate", GetType(Date))
                dt_records.Columns.Add("materialname", GetType(String))
                dt_records.Columns.Add("serial", GetType(String))
                dt_records.Columns.Add("shift", GetType(String))
                dt_records.Columns.Add("serial2", GetType(String))
                dt_records.Columns.Add("qrcode", GetType(Byte()))
            End If
            dt_records.Rows.Clear()
            ' Input validation
            If String.IsNullOrEmpty(txt_materiallot.Text) OrElse String.IsNullOrEmpty(txt_serial.Text) Then
                MessageBox.Show("Please ensure all required fields are filled.")
                Exit Sub
            End If

            ' Get the quantity input from num_qty
            For i As Integer = 1 To num_count.Value
                Dim qrcode As String = $"{partno}  {num_qty.Value}    {txt_lotnumber.Text}   {txt_materiallot.Text}    {moldno}     {i}       {Date.Now.ToString("dd/MM/yyyy")}{material}        {txt_serial.Text}     {cmb_shift.Text}        {txt_serial.Text}"

                ' Generate the QR code and convert it to a byte array
                Dim qrImage As Image = GenerateQRCode(qrcode)
                Dim qrImageBytes As Byte() = ImageToByteArray(qrImage)

                ' Add the data and QR code to the DataTable
                dt_records.Rows.Add(partno, partname, model, process, txt_materiallot.Text, moldno, supplier, num_qty.Value, txt_lotnumber.Text, i, datedb, material, txt_serial.Text, cmb_shift.Text, txt_serial.Text, qrImageBytes)

                ' Also add to the DataGridView for visual confirmation
                datagrid1.Rows.Add(i, qrcode)
            Next

            ' Load the report
            loadrpt()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            ' Close the connection only if it was opened
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Sub


    Private Function GenerateQRCode(serial As String) As Bitmap
        Dim qrGenerator As New QRCodeGenerator()
        Dim qrCodeData As QRCodeData = qrGenerator.CreateQrCode(serial, QRCodeGenerator.ECCLevel.Q)
        Dim qrCode As New QRCode(qrCodeData)
        Return qrCode.GetGraphic(20)
    End Function
    Private Function ImageToByteArray(image As Image) As Byte()
        Using ms As New MemoryStream()
            image.Save(ms, System.Drawing.Imaging.ImageFormat.Png)
            Return ms.ToArray()
        End Using
    End Function

    Private Sub Guna2Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel1.Paint

    End Sub
End Class