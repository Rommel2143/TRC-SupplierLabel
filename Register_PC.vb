﻿Imports MySql.Data.MySqlClient
Public Class Register_PC
    Private Sub Register_PC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtpcname.Text = PCname
        txtpcmac.Text = PCmac
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        If txtuser.Text = "PTRCI" And txtpassword.Text = "redhorsE" And cmblocation.Text IsNot "" Then
            con.Close()
            con.Open()
            Dim cmdselect As New MySqlCommand("INSERT INTO `computer_location`(`PCname`, `PCmac`, `location`) VALUES ('" & PCname & "','" & PCmac & "','" & cmblocation.Text & "')", con)
            cmdselect.ExecuteNonQuery()
            Dim result As DialogResult = MessageBox.Show("Machine Verified!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            If result = DialogResult.OK Then
                With Login
                    .Refresh()
                    .TopLevel = False
                    Mainframe.Panel1.Controls.Add(Login)
                    .txtpclocation.Text = cmblocation.Text
                    .txtbarcode.Enabled = True
                    .txtbarcode.Focus()
                    .BringToFront()
                    .Show()
                    PClocation = cmblocation.Text
                End With
            End If
        Else
            MessageBox.Show("Invalid Credentials", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class