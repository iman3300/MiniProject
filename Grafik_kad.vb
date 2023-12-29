Imports System.Data.OleDb
Public Class Grafik_kad

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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Costumer.Show()
        Me.Hide()
    End Sub



    Private Sub Grafik_kad_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        conn.Open()
        Dim mysql As New OleDbCommand("SELECT Grafik_Kad FROM Grafik_Kad", conn)
        Dim myreader As OleDb.OleDbDataReader = mysql.ExecuteReader
        ComboBox1.Items.Clear()
        While myreader.Read()
            ComboBox1.Items.Add(myreader("Grafik_Kad"))
        End While
        conn.Close()

        conn.Open()
        Dim mysql9 As New OleDbCommand("SELECT Staff_id FROM Seller", conn)
        Dim myreader9 As OleDb.OleDbDataReader = mysql9.ExecuteReader
        ComboBox4.Items.Clear()
        While myreader9.Read()
            ComboBox4.Items.Add(myreader9("Staff_id"))
        End While
        conn.Close()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

        If ComboBox1.SelectedIndex = 0 Then
            RTX_4090.Visible = True
        ElseIf ComboBox1.SelectedIndex = 1 Then
            RTX_4090.Visible = False
        ElseIf ComboBox1.SelectedIndex = 2 Then
            RTX_4090.Visible = False
        ElseIf ComboBox1.SelectedIndex = 3 Then
            RTX_4090.Visible = False
        ElseIf ComboBox1.SelectedIndex = 4 Then
            RTX_4090.Visible = False
        ElseIf ComboBox1.SelectedIndex = 5 Then
            RTX_4090.Visible = False
        ElseIf ComboBox1.SelectedIndex = 6 Then
            RTX_4090.Visible = False
        ElseIf ComboBox1.SelectedIndex = 7 Then
            RTX_4090.Visible = False
        ElseIf ComboBox1.SelectedIndex = 8 Then
            RTX_4090.Visible = False
        ElseIf ComboBox1.SelectedIndex = 9 Then
            RTX_4090.Visible = False
        End If

        If ComboBox1.SelectedIndex = 1 Then
            RTX_4080_TI.Visible = True
        ElseIf ComboBox1.SelectedIndex = 0 Then
            RTX_4080_TI.Visible = False
        ElseIf ComboBox1.SelectedIndex = 2 Then
            RTX_4080_TI.Visible = False
        ElseIf ComboBox1.SelectedIndex = 3 Then
            RTX_4080_TI.Visible = False
        ElseIf ComboBox1.SelectedIndex = 4 Then
            RTX_4080_TI.Visible = False
        ElseIf ComboBox1.SelectedIndex = 5 Then
            RTX_4080_TI.Visible = False
        ElseIf ComboBox1.SelectedIndex = 6 Then
            RTX_4080_TI.Visible = False
        ElseIf ComboBox1.SelectedIndex = 7 Then
            RTX_4080_TI.Visible = False
        ElseIf ComboBox1.SelectedIndex = 8 Then
            RTX_4080_TI.Visible = False
        ElseIf ComboBox1.SelectedIndex = 9 Then
            RTX_4080_TI.Visible = False
        End If

        If ComboBox1.SelectedIndex = 2 Then
            RTX_3090_TI.Visible = True
        ElseIf ComboBox1.SelectedIndex = 0 Then
            RTX_3090_TI.Visible = False
        ElseIf ComboBox1.SelectedIndex = 1 Then
            RTX_3090_TI.Visible = False
        ElseIf ComboBox1.SelectedIndex = 3 Then
            RTX_3090_TI.Visible = False
        ElseIf ComboBox1.SelectedIndex = 4 Then
            RTX_3090_TI.Visible = False
        ElseIf ComboBox1.SelectedIndex = 5 Then
            RTX_3090_TI.Visible = False
        ElseIf ComboBox1.SelectedIndex = 6 Then
            RTX_3090_TI.Visible = False
        ElseIf ComboBox1.SelectedIndex = 7 Then
            RTX_3090_TI.Visible = False
        ElseIf ComboBox1.SelectedIndex = 8 Then
            RTX_3090_TI.Visible = False
        ElseIf ComboBox1.SelectedIndex = 9 Then
            RTX_3090_TI.Visible = False
        End If

        If ComboBox1.SelectedIndex = 3 Then
            RTX_3090.Visible = True
        ElseIf ComboBox1.SelectedIndex = 0 Then
            RTX_3090.Visible = False
        ElseIf ComboBox1.SelectedIndex = 1 Then
            RTX_3090.Visible = False
        ElseIf ComboBox1.SelectedIndex = 2 Then
            RTX_3090.Visible = False
        ElseIf ComboBox1.SelectedIndex = 4 Then
            RTX_3090.Visible = False
        ElseIf ComboBox1.SelectedIndex = 5 Then
            RTX_3090.Visible = False
        ElseIf ComboBox1.SelectedIndex = 6 Then
            RTX_3090.Visible = False
        ElseIf ComboBox1.SelectedIndex = 7 Then
            RTX_3090.Visible = False
        ElseIf ComboBox1.SelectedIndex = 8 Then
            RTX_3090.Visible = False
        ElseIf ComboBox1.SelectedIndex = 9 Then
            RTX_3090.Visible = False
        End If

        If ComboBox1.SelectedIndex = 4 Then
            RTX_3080_TI.Visible = True
        ElseIf ComboBox1.SelectedIndex = 0 Then
            RTX_3080_TI.Visible = False
        ElseIf ComboBox1.SelectedIndex = 1 Then
            RTX_3080_TI.Visible = False
        ElseIf ComboBox1.SelectedIndex = 2 Then
            RTX_3080_TI.Visible = False
        ElseIf ComboBox1.SelectedIndex = 3 Then
            RTX_3080_TI.Visible = False
        ElseIf ComboBox1.SelectedIndex = 5 Then
            RTX_3080_TI.Visible = False
        ElseIf ComboBox1.SelectedIndex = 6 Then
            RTX_3080_TI.Visible = False
        ElseIf ComboBox1.SelectedIndex = 7 Then
            RTX_3080_TI.Visible = False
        ElseIf ComboBox1.SelectedIndex = 8 Then
            RTX_3080_TI.Visible = False
        ElseIf ComboBox1.SelectedIndex = 9 Then
            RTX_3080_TI.Visible = False
        End If

        If ComboBox1.SelectedIndex = 5 Then
            RTX_3080.Visible = True
        ElseIf ComboBox1.SelectedIndex = 0 Then
            RTX_3080.Visible = False
        ElseIf ComboBox1.SelectedIndex = 1 Then
            RTX_3080.Visible = False
        ElseIf ComboBox1.SelectedIndex = 2 Then
            RTX_3080.Visible = False
        ElseIf ComboBox1.SelectedIndex = 3 Then
            RTX_3080.Visible = False
        ElseIf ComboBox1.SelectedIndex = 4 Then
            RTX_3080.Visible = False
        ElseIf ComboBox1.SelectedIndex = 6 Then
            RTX_3080.Visible = False
        ElseIf ComboBox1.SelectedIndex = 7 Then
            RTX_3080.Visible = False
        ElseIf ComboBox1.SelectedIndex = 8 Then
            RTX_3080.Visible = False
        ElseIf ComboBox1.SelectedIndex = 9 Then
            RTX_3080.Visible = False
        End If

        If ComboBox1.SelectedIndex = 6 Then
            RTX_3070_TI.Visible = True
        ElseIf ComboBox1.SelectedIndex = 0 Then
            RTX_3070_TI.Visible = False
        ElseIf ComboBox1.SelectedIndex = 1 Then
            RTX_3070_TI.Visible = False
        ElseIf ComboBox1.SelectedIndex = 2 Then
            RTX_3070_TI.Visible = False
        ElseIf ComboBox1.SelectedIndex = 3 Then
            RTX_3070_TI.Visible = False
        ElseIf ComboBox1.SelectedIndex = 4 Then
            RTX_3070_TI.Visible = False
        ElseIf ComboBox1.SelectedIndex = 5 Then
            RTX_3070_TI.Visible = False
        ElseIf ComboBox1.SelectedIndex = 7 Then
            RTX_3070_TI.Visible = False
        ElseIf ComboBox1.SelectedIndex = 8 Then
            RTX_3070_TI.Visible = False
        ElseIf ComboBox1.SelectedIndex = 9 Then
            RTX_3070_TI.Visible = False
        End If

        If ComboBox1.SelectedIndex = 7 Then
            RTX_3070.Visible = True
        ElseIf ComboBox1.SelectedIndex = 0 Then
            RTX_3070.Visible = False
        ElseIf ComboBox1.SelectedIndex = 1 Then
            RTX_3070.Visible = False
        ElseIf ComboBox1.SelectedIndex = 2 Then
            RTX_3070.Visible = False
        ElseIf ComboBox1.SelectedIndex = 3 Then
            RTX_3070.Visible = False
        ElseIf ComboBox1.SelectedIndex = 4 Then
            RTX_3070.Visible = False
        ElseIf ComboBox1.SelectedIndex = 5 Then
            RTX_3070.Visible = False
        ElseIf ComboBox1.SelectedIndex = 6 Then
            RTX_3070.Visible = False
        ElseIf ComboBox1.SelectedIndex = 8 Then
            RTX_3070.Visible = False
        ElseIf ComboBox1.SelectedIndex = 9 Then
            RTX_3070.Visible = False
        End If

        If ComboBox1.SelectedIndex = 8 Then
            RTX_3060_TI.Visible = True
        ElseIf ComboBox1.SelectedIndex = 0 Then
            RTX_3060_TI.Visible = False
        ElseIf ComboBox1.SelectedIndex = 1 Then
            RTX_3060_TI.Visible = False
        ElseIf ComboBox1.SelectedIndex = 2 Then
            RTX_3060_TI.Visible = False
        ElseIf ComboBox1.SelectedIndex = 3 Then
            RTX_3060_TI.Visible = False
        ElseIf ComboBox1.SelectedIndex = 4 Then
            RTX_3060_TI.Visible = False
        ElseIf ComboBox1.SelectedIndex = 5 Then
            RTX_3060_TI.Visible = False
        ElseIf ComboBox1.SelectedIndex = 6 Then
            RTX_3060_TI.Visible = False
        ElseIf ComboBox1.SelectedIndex = 7 Then
            RTX_3060_TI.Visible = False
        ElseIf ComboBox1.SelectedIndex = 9 Then
            RTX_3060_TI.Visible = False
        End If

        If ComboBox1.SelectedIndex = 9 Then
            RTX_3060.Visible = True
        ElseIf ComboBox1.SelectedIndex = 0 Then
            RTX_3060.Visible = False
        ElseIf ComboBox1.SelectedIndex = 1 Then
            RTX_3060.Visible = False
        ElseIf ComboBox1.SelectedIndex = 2 Then
            RTX_3060.Visible = False
        ElseIf ComboBox1.SelectedIndex = 3 Then
            RTX_3060.Visible = False
        ElseIf ComboBox1.SelectedIndex = 4 Then
            RTX_3060.Visible = False
        ElseIf ComboBox1.SelectedIndex = 5 Then
            RTX_3060.Visible = False
        ElseIf ComboBox1.SelectedIndex = 6 Then
            RTX_3060.Visible = False
        ElseIf ComboBox1.SelectedIndex = 7 Then
            RTX_3060.Visible = False
        ElseIf ComboBox1.SelectedIndex = 8 Then
            RTX_3060.Visible = False

        End If

        conn.Open()
        Dim mysql2 As New OleDbCommand("SELECT Gra_id FROM Grafik_Kad Where Grafik_Kad='" + ComboBox1.Text + "'", conn)
        Dim myreader2 As OleDb.OleDbDataReader = mysql2.ExecuteReader
        ListBox1.Items.Clear()
        ComboBox2.Items.Clear()

        While myreader2.Read()
            ListBox1.Items.Add(myreader2("Gra_id"))
            ComboBox2.Items.Add(myreader2("Gra_id"))

        End While
        conn.Close()

        conn.Open()
        Dim mysql3 As New OleDbCommand("SELECT Average_1080P_FPS FROM Grafik_Kad Where Grafik_Kad='" + ComboBox1.Text + "'", conn)
        Dim myreader3 As OleDb.OleDbDataReader = mysql3.ExecuteReader
        ListBox2.Items.Clear()
        While myreader3.Read()
            ListBox2.Items.Add(myreader3("Average_1080P_FPS"))

        End While
        conn.Close()

        conn.Open()
        Dim mysql4 As New OleDbCommand("SELECT Average_1440P_FPS FROM Grafik_Kad Where Grafik_Kad='" + ComboBox1.Text + "'", conn)
        Dim myreader4 As OleDb.OleDbDataReader = mysql4.ExecuteReader
        ListBox3.Items.Clear()
        While myreader4.Read()
            ListBox3.Items.Add(myreader4("Average_1440P_FPS"))

        End While
        conn.Close()

        conn.Open()
        Dim mysql5 As New OleDbCommand("SELECT Average_4K_FPS FROM Grafik_Kad Where Grafik_Kad='" + ComboBox1.Text + "'", conn)
        Dim myreader5 As OleDb.OleDbDataReader = mysql5.ExecuteReader
        ListBox4.Items.Clear()
        While myreader5.Read()
            ListBox4.Items.Add(myreader5("Average_4K_FPS"))

        End While
        conn.Close()

        conn.Open()
        Dim mysql6 As New OleDbCommand("SELECT Price FROM Grafik_Kad Where Grafik_Kad='" + ComboBox1.Text + "'", conn)
        Dim myreader6 As OleDb.OleDbDataReader = mysql6.ExecuteReader
        ListBox5.Items.Clear()
        ComboBox3.Items.Clear()

        While myreader6.Read()
            ListBox5.Items.Add(myreader6("Price"))
            ComboBox3.Items.Add(myreader6("Price"))

        End While
        conn.Close()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        generate()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If AutoNumber.Text = "" Then
            MsgBox("Please Enter Your Customer ID")
        ElseIf TextBox2.Text = "" Then
            MsgBox("Please Enter Your Name")
        ElseIf TextBox3.Text = "" Then
            MsgBox("Please Enter Your Address")
        ElseIf TextBox4.Text = "" Then
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
            Command = "INSERT INTO Customer (Staff_id, Customour_id, Produk_id, Nama, Alamat, No_Telefon, Price) VALUES ('" & ComboBox4.Text & "','" & AutoNumber.Text & "','" & ComboBox2.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & ComboBox3.Text & "')"
            Dim cmd As OleDbCommand = New OleDbCommand(Command, MyConn)
            cmd.Parameters.Add(New OleDbParameter("Staff_id", CType(ComboBox4.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("Customour_id", CType(AutoNumber.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("Produk_id", CType(ComboBox2.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("Nama", CType(TextBox2.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("Alamat", CType(TextBox3.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("No_Telefon", CType(TextBox4.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("Price", CType(ComboBox4.Text, String)))

            Try
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                MyConn.Close()
                MsgBox("Order complete !")



            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim f2 As New receiptGra(Me)
        f2.Show()
        Me.Hide()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Pro = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\21220549_falcultyrecords\MiniProject\MiniProject\bin\Debug\MiniProject.accdb"
        ConnString = Pro
        MyConn.ConnectionString = ConnString
        MyConn.Open()
        Command = "INSERT INTO Req_cancelOr (Customer_id,Name ,Alamat ,No_Telefon) VALUES ('" & AutoNumber.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "')"
        Dim cmd As OleDbCommand = New OleDbCommand(Command, MyConn)
        cmd.Parameters.Add(New OleDbParameter("Customer_id", CType(AutoNumber.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Name", CType(TextBox2.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Alamat", CType(TextBox3.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("No_Telefon", CType(TextBox4.Text, String)))


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
        exitGra.Show()

    End Sub

    Private Sub Grafik_kad_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.Location += Control.MousePosition - pos
        End If
        pos = Control.MousePosition
    End Sub


End Class