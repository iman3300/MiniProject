Imports System.Data.OleDb

Public Class Earbuds

    Dim pos As Point

    Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\21220549_falcultyrecords\MiniProject\MiniProject\bin\Debug\MiniProject.accdb")

    Dim x As String = ""
    Dim rand As Random = New Random()

    Dim Pro As String
    Dim ConnString As String
    Dim Command As String
    Dim MyConn As OleDbConnection = New OleDbConnection





    Sub generate()
        For y As Integer = 1 To 4
            x = Date.Now.Year
            If y = 4 Then
                x += "0"
            End If
        Next

        For y As Integer = 1 To 4
            x += Convert.ToString(rand.Next(0, 9))
        Next
        AutoNumber.Text = x
        If AutoNumber.Text = x Then
            x = Nothing
        End If
    End Sub
    Private Sub Earbuds_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        conn.Open()
        Dim mysql As New OleDbCommand("SELECT Earbuds FROM Earbuds", conn)
        Dim myreader As OleDb.OleDbDataReader = mysql.ExecuteReader
        ComboBox1.Items.Clear()
        While myreader.Read()
            ComboBox1.Items.Add(myreader("Earbuds"))
        End While
        conn.Close()

        conn.Open()
        Dim mysql9 As New OleDbCommand("SELECT Staff_id FROM Seller", conn)
        Dim myreader9 As OleDb.OleDbDataReader = mysql9.ExecuteReader
        ComboBox2.Items.Clear()
        While myreader9.Read()
            ComboBox2.Items.Add(myreader9("Staff_id"))
        End While
        conn.Close()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Costumer.Show()
        Me.Hide()
    End Sub



    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        conn.Open()
        Dim mysql2 As New OleDbCommand("SELECT Ear_id FROM Earbuds Where Earbuds='" + ComboBox1.Text + "'", conn)
        Dim myreader2 As OleDb.OleDbDataReader = mysql2.ExecuteReader
        ListBox1.Items.Clear()
        ComboBox3.Items.Clear()

        If ComboBox1.SelectedIndex = 0 Then
            WF_1000XM4.Visible = True
        ElseIf ComboBox1.SelectedIndex = 1 Then
            WF_1000XM4.Visible = False
        ElseIf ComboBox1.SelectedIndex = 2 Then
            WF_1000XM4.Visible = False
        ElseIf ComboBox1.SelectedIndex = 3 Then
            WF_1000XM4.Visible = False
        ElseIf ComboBox1.SelectedIndex = 4 Then
            WF_1000XM4.Visible = False
        ElseIf ComboBox1.SelectedIndex = 5 Then
            WF_1000XM4.Visible = False
        ElseIf ComboBox1.SelectedIndex = 6 Then
            WF_1000XM4.Visible = False
        ElseIf ComboBox1.SelectedIndex = 7 Then
            WF_1000XM4.Visible = False
        ElseIf ComboBox1.SelectedIndex = 8 Then
            WF_1000XM4.Visible = False
        ElseIf ComboBox1.SelectedIndex = 9 Then
            WF_1000XM4.Visible = False
        End If

        If ComboBox1.SelectedIndex = 1 Then
            Quantum_TWS.Visible = True
        ElseIf ComboBox1.SelectedIndex = 0 Then
            Quantum_TWS.Visible = False
        ElseIf ComboBox1.SelectedIndex = 2 Then
            Quantum_TWS.Visible = False
        ElseIf ComboBox1.SelectedIndex = 3 Then
            Quantum_TWS.Visible = False
        ElseIf ComboBox1.SelectedIndex = 4 Then
            Quantum_TWS.Visible = False
        ElseIf ComboBox1.SelectedIndex = 5 Then
            Quantum_TWS.Visible = False
        ElseIf ComboBox1.SelectedIndex = 6 Then
            Quantum_TWS.Visible = False
        ElseIf ComboBox1.SelectedIndex = 7 Then
            Quantum_TWS.Visible = False
        ElseIf ComboBox1.SelectedIndex = 8 Then
            Quantum_TWS.Visible = False
        ElseIf ComboBox1.SelectedIndex = 9 Then
            Quantum_TWS.Visible = False
        End If

        If ComboBox1.SelectedIndex = 2 Then
            AirPod_pro_2.Visible = True
        ElseIf ComboBox1.SelectedIndex = 0 Then
            AirPod_pro_2.Visible = False
        ElseIf ComboBox1.SelectedIndex = 1 Then
            AirPod_pro_2.Visible = False
        ElseIf ComboBox1.SelectedIndex = 3 Then
            AirPod_pro_2.Visible = False
        ElseIf ComboBox1.SelectedIndex = 4 Then
            AirPod_pro_2.Visible = False
        ElseIf ComboBox1.SelectedIndex = 5 Then
            AirPod_pro_2.Visible = False
        ElseIf ComboBox1.SelectedIndex = 6 Then
            AirPod_pro_2.Visible = False
        ElseIf ComboBox1.SelectedIndex = 7 Then
            AirPod_pro_2.Visible = False
        ElseIf ComboBox1.SelectedIndex = 8 Then
            AirPod_pro_2.Visible = False
        ElseIf ComboBox1.SelectedIndex = 9 Then
            AirPod_pro_2.Visible = False
        End If

        If ComboBox1.SelectedIndex = 3 Then
            Airpod_2.Visible = True
        ElseIf ComboBox1.SelectedIndex = 0 Then
            Airpod_2.Visible = False
        ElseIf ComboBox1.SelectedIndex = 1 Then
            Airpod_2.Visible = False
        ElseIf ComboBox1.SelectedIndex = 2 Then
            Airpod_2.Visible = False
        ElseIf ComboBox1.SelectedIndex = 4 Then
            Airpod_2.Visible = False
        ElseIf ComboBox1.SelectedIndex = 5 Then
            Airpod_2.Visible = False
        ElseIf ComboBox1.SelectedIndex = 6 Then
            Airpod_2.Visible = False
        ElseIf ComboBox1.SelectedIndex = 7 Then
            Airpod_2.Visible = False
        ElseIf ComboBox1.SelectedIndex = 8 Then
            Airpod_2.Visible = False
        ElseIf ComboBox1.SelectedIndex = 9 Then
            Airpod_2.Visible = False
        End If

        If ComboBox1.SelectedIndex = 4 Then
            Buds2_Pro.Visible = True
        ElseIf ComboBox1.SelectedIndex = 0 Then
            Buds2_Pro.Visible = False
        ElseIf ComboBox1.SelectedIndex = 1 Then
            Buds2_Pro.Visible = False
        ElseIf ComboBox1.SelectedIndex = 2 Then
            Buds2_Pro.Visible = False
        ElseIf ComboBox1.SelectedIndex = 3 Then
            Buds2_Pro.Visible = False
        ElseIf ComboBox1.SelectedIndex = 5 Then
            Buds2_Pro.Visible = False
        ElseIf ComboBox1.SelectedIndex = 6 Then
            Buds2_Pro.Visible = False
        ElseIf ComboBox1.SelectedIndex = 7 Then
            Buds2_Pro.Visible = False
        ElseIf ComboBox1.SelectedIndex = 8 Then
            Buds2_Pro.Visible = False
        ElseIf ComboBox1.SelectedIndex = 9 Then
            Buds2_Pro.Visible = False
        End If

        If ComboBox1.SelectedIndex = 5 Then
            QuietComfort.Visible = True
        ElseIf ComboBox1.SelectedIndex = 0 Then
            QuietComfort.Visible = False
        ElseIf ComboBox1.SelectedIndex = 1 Then
            QuietComfort.Visible = False
        ElseIf ComboBox1.SelectedIndex = 2 Then
            QuietComfort.Visible = False
        ElseIf ComboBox1.SelectedIndex = 3 Then
            QuietComfort.Visible = False
        ElseIf ComboBox1.SelectedIndex = 4 Then
            QuietComfort.Visible = False
        ElseIf ComboBox1.SelectedIndex = 6 Then
            QuietComfort.Visible = False
        ElseIf ComboBox1.SelectedIndex = 7 Then
            QuietComfort.Visible = False
        ElseIf ComboBox1.SelectedIndex = 8 Then
            QuietComfort.Visible = False
        ElseIf ComboBox1.SelectedIndex = 9 Then
            QuietComfort.Visible = False
        End If

        If ComboBox1.SelectedIndex = 6 Then
            Momentum.Visible = True
        ElseIf ComboBox1.SelectedIndex = 0 Then
            Momentum.Visible = False
        ElseIf ComboBox1.SelectedIndex = 1 Then
            Momentum.Visible = False
        ElseIf ComboBox1.SelectedIndex = 2 Then
            Momentum.Visible = False
        ElseIf ComboBox1.SelectedIndex = 3 Then
            Momentum.Visible = False
        ElseIf ComboBox1.SelectedIndex = 4 Then
            Momentum.Visible = False
        ElseIf ComboBox1.SelectedIndex = 5 Then
            Momentum.Visible = False
        ElseIf ComboBox1.SelectedIndex = 7 Then
            Momentum.Visible = False
        ElseIf ComboBox1.SelectedIndex = 8 Then
            Momentum.Visible = False
        ElseIf ComboBox1.SelectedIndex = 9 Then
            Momentum.Visible = False
        End If

        If ComboBox1.SelectedIndex = 7 Then
            Aonic_215_TW2.Visible = True
        ElseIf ComboBox1.SelectedIndex = 0 Then
            Aonic_215_TW2.Visible = False
        ElseIf ComboBox1.SelectedIndex = 1 Then
            Aonic_215_TW2.Visible = False
        ElseIf ComboBox1.SelectedIndex = 2 Then
            Aonic_215_TW2.Visible = False
        ElseIf ComboBox1.SelectedIndex = 3 Then
            Aonic_215_TW2.Visible = False
        ElseIf ComboBox1.SelectedIndex = 4 Then
            Aonic_215_TW2.Visible = False
        ElseIf ComboBox1.SelectedIndex = 5 Then
            Aonic_215_TW2.Visible = False
        ElseIf ComboBox1.SelectedIndex = 6 Then
            Aonic_215_TW2.Visible = False
        ElseIf ComboBox1.SelectedIndex = 8 Then
            Aonic_215_TW2.Visible = False
        ElseIf ComboBox1.SelectedIndex = 9 Then
            Aonic_215_TW2.Visible = False
        End If

        If ComboBox1.SelectedIndex = 8 Then
            Fit_pro.Visible = True
        ElseIf ComboBox1.SelectedIndex = 0 Then
            Fit_pro.Visible = False
        ElseIf ComboBox1.SelectedIndex = 1 Then
            Fit_pro.Visible = False
        ElseIf ComboBox1.SelectedIndex = 2 Then
            Fit_pro.Visible = False
        ElseIf ComboBox1.SelectedIndex = 3 Then
            Fit_pro.Visible = False
        ElseIf ComboBox1.SelectedIndex = 4 Then
            Fit_pro.Visible = False
        ElseIf ComboBox1.SelectedIndex = 5 Then
            Fit_pro.Visible = False
        ElseIf ComboBox1.SelectedIndex = 6 Then
            Fit_pro.Visible = False
        ElseIf ComboBox1.SelectedIndex = 7 Then
            Fit_pro.Visible = False
        ElseIf ComboBox1.SelectedIndex = 9 Then
            Fit_pro.Visible = False
        End If

        If ComboBox1.SelectedIndex = 9 Then
            Elite85t.Visible = True
        ElseIf ComboBox1.SelectedIndex = 0 Then
            Elite85t.Visible = False
        ElseIf ComboBox1.SelectedIndex = 1 Then
            Elite85t.Visible = False
        ElseIf ComboBox1.SelectedIndex = 2 Then
            Elite85t.Visible = False
        ElseIf ComboBox1.SelectedIndex = 3 Then
            Elite85t.Visible = False
        ElseIf ComboBox1.SelectedIndex = 4 Then
            Elite85t.Visible = False
        ElseIf ComboBox1.SelectedIndex = 5 Then
            Elite85t.Visible = False
        ElseIf ComboBox1.SelectedIndex = 6 Then
            Elite85t.Visible = False
        ElseIf ComboBox1.SelectedIndex = 7 Then
            Elite85t.Visible = False
        ElseIf ComboBox1.SelectedIndex = 8 Then
            Elite85t.Visible = False

        End If

        While myreader2.Read()
            ListBox1.Items.Add(myreader2("Ear_id"))
            ComboBox3.Items.Add(myreader2("Ear_id"))

        End While
        conn.Close()

        conn.Open()
        Dim mysql3 As New OleDbCommand("SELECT Battery_duration FROM Earbuds Where Earbuds='" + ComboBox1.Text + "'", conn)
        Dim myreader3 As OleDb.OleDbDataReader = mysql3.ExecuteReader
        ListBox2.Items.Clear()
        While myreader3.Read()
            ListBox2.Items.Add(myreader3("Battery_duration"))

        End While
        conn.Close()

        conn.Open()
        Dim mysql4 As New OleDbCommand("SELECT Connection_type FROM Earbuds Where Earbuds='" + ComboBox1.Text + "'", conn)
        Dim myreader4 As OleDb.OleDbDataReader = mysql4.ExecuteReader
        ListBox3.Items.Clear()
        While myreader4.Read()
            ListBox3.Items.Add(myreader4("Connection_type"))

        End While
        conn.Close()

        conn.Open()
        Dim mysql5 As New OleDbCommand("SELECT Maximum_frequency_response FROM Earbuds Where Earbuds='" + ComboBox1.Text + "'", conn)
        Dim myreader5 As OleDb.OleDbDataReader = mysql5.ExecuteReader
        ListBox4.Items.Clear()
        While myreader5.Read()
            ListBox4.Items.Add(myreader5("Maximum_frequency_response"))

        End While
        conn.Close()

        conn.Open()
        Dim mysql6 As New OleDbCommand("SELECT Minimum_Frequency_response FROM Earbuds Where Earbuds='" + ComboBox1.Text + "'", conn)
        Dim myreader6 As OleDb.OleDbDataReader = mysql6.ExecuteReader
        ListBox5.Items.Clear()
        While myreader6.Read()
            ListBox5.Items.Add(myreader6("Minimum_Frequency_response"))
        End While
        conn.Close()

        conn.Open()
        Dim mysql7 As New OleDbCommand("SELECT Price FROM Earbuds Where Earbuds='" + ComboBox1.Text + "'", conn)
        Dim myreader7 As OleDb.OleDbDataReader = mysql7.ExecuteReader
        ListBox6.Items.Clear()
        ComboBox4.Items.Clear()
        While myreader7.Read()
            ListBox6.Items.Add(myreader7("Price"))
            ComboBox4.Items.Add(myreader7("Price"))
        End While
        conn.Close()
    End Sub



    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        generate()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        If AutoNumber.Text = "" Then
            MsgBox("Please Enter Your Customer ID")
        ElseIf txt_name.Text = "" Then
            MsgBox("Please Enter Your Name")
        ElseIf txt_alamat.Text = "" Then
            MsgBox("Please Enter Your Address")
        ElseIf txt_Pnum.Text = "" Then
            MsgBox("Please Enter Your Phone Number")
        ElseIf ComboBox2.Text = "" Then
            MsgBox("Please Produk ID")
        ElseIf ComboBox4.Text = "" Then
            MsgBox("Please Enter Choose Random")
        ElseIf ComboBox3.Text = "" Then
            MsgBox("Please Enter Price")
        Else
            Pro = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\21220549_falcultyrecords\MiniProject\MiniProject\bin\Debug\MiniProject.accdb"
            ConnString = Pro
            MyConn.ConnectionString = ConnString
            MyConn.Open()
            Command = "INSERT INTO Customer (Staff_id, Customour_id, Produk_id, Nama, Alamat, No_Telefon, Price) VALUES ('" & ComboBox2.Text & "','" & AutoNumber.Text & "','" & ComboBox3.Text & "','" & txt_name.Text & "','" & txt_alamat.Text & "','" & txt_Pnum.Text & "','" & ComboBox4.Text & "')"
            Dim cmd As OleDbCommand = New OleDbCommand(Command, MyConn)
            cmd.Parameters.Add(New OleDbParameter("Staff_id", CType(ComboBox2.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("Customour_id", CType(AutoNumber.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("Produk_id", CType(ComboBox3.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("Nama", CType(txt_name.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("Alamat", CType(txt_alamat.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("No_Telefon", CType(txt_Pnum.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("Price", CType(ComboBox4.Text, String)))

            Try
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                MyConn.Close()
                ComboBox2.Refresh()

                ComboBox3.Refresh()


                ComboBox4.Refresh()

                MsgBox("Order complete !")

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ListBox7_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox4.SelectedIndexChanged

    End Sub

    Private Sub Button3_Click()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim f5 As New receiptEar(Me)

        f5.Show()
        Me.Hide()
    End Sub

    Private Sub Button6_Click_1(sender As Object, e As EventArgs) Handles Button6.Click
        Pro = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\21220549_falcultyrecords\MiniProject\MiniProject\bin\Debug\MiniProject.accdb"
        ConnString = Pro
        MyConn.ConnectionString = ConnString
        MyConn.Open()
        Command = "INSERT INTO Req_cancelOr (Customer_id,Name ,Alamat ,No_Telefon) VALUES ('" & AutoNumber.Text & "','" & txt_name.Text & "','" & txt_alamat.Text & "','" & txt_Pnum.Text & "')"
        Dim cmd As OleDbCommand = New OleDbCommand(Command, MyConn)
        cmd.Parameters.Add(New OleDbParameter("Customer_id", CType(AutoNumber.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Name", CType(txt_name.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Alamat", CType(txt_alamat.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("No_Telefon", CType(txt_Pnum.Text, String)))


        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            MyConn.Close()

            MsgBox("Cancel Order Has Been Requested!")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        exitEar.Show()


    End Sub

    Private Sub Earbuds_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.Location += Control.MousePosition - pos
        End If
        pos = Control.MousePosition
    End Sub
End Class