Imports System.Data.OleDb
Public Class Mouse

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



    Private Sub Mouse_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.Open()
        Dim mysql As New OleDbCommand("SELECT Mouse FROM Mouse", conn)
        Dim myreader As OleDb.OleDbDataReader = mysql.ExecuteReader
        ComboBox1.Items.Clear()
        While myreader.Read()
            ComboBox1.Items.Add(myreader("Mouse"))
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
            Viper_V2_Pro.Visible = True
        ElseIf ComboBox1.SelectedIndex = 1 Then
            Viper_V2_Pro.Visible = False
        ElseIf ComboBox1.SelectedIndex = 2 Then
            Viper_V2_Pro.Visible = False
        ElseIf ComboBox1.SelectedIndex = 3 Then
            Viper_V2_Pro.Visible = False
        ElseIf ComboBox1.SelectedIndex = 4 Then
            Viper_V2_Pro.Visible = False
        ElseIf ComboBox1.SelectedIndex = 5 Then
            Viper_V2_Pro.Visible = False
        ElseIf ComboBox1.SelectedIndex = 6 Then
            Viper_V2_Pro.Visible = False
        ElseIf ComboBox1.SelectedIndex = 7 Then
            Viper_V2_Pro.Visible = False
        ElseIf ComboBox1.SelectedIndex = 8 Then
            Viper_V2_Pro.Visible = False
        ElseIf ComboBox1.SelectedIndex = 9 Then
            Viper_V2_Pro.Visible = False
        End If

        If ComboBox1.SelectedIndex = 1 Then
            Deathadder_v2_pro.Visible = True
        ElseIf ComboBox1.SelectedIndex = 0 Then
            Deathadder_v2_pro.Visible = False
        ElseIf ComboBox1.SelectedIndex = 2 Then
            Deathadder_v2_pro.Visible = False
        ElseIf ComboBox1.SelectedIndex = 3 Then
            Deathadder_v2_pro.Visible = False
        ElseIf ComboBox1.SelectedIndex = 4 Then
            Deathadder_v2_pro.Visible = False
        ElseIf ComboBox1.SelectedIndex = 5 Then
            Deathadder_v2_pro.Visible = False
        ElseIf ComboBox1.SelectedIndex = 6 Then
            Deathadder_v2_pro.Visible = False
        ElseIf ComboBox1.SelectedIndex = 7 Then
            Deathadder_v2_pro.Visible = False
        ElseIf ComboBox1.SelectedIndex = 8 Then
            Deathadder_v2_pro.Visible = False
        ElseIf ComboBox1.SelectedIndex = 9 Then
            Deathadder_v2_pro.Visible = False
        End If

        If ComboBox1.SelectedIndex = 2 Then
            Naga_Pro.Visible = True
        ElseIf ComboBox1.SelectedIndex = 0 Then
            Naga_Pro.Visible = False
        ElseIf ComboBox1.SelectedIndex = 1 Then
            Naga_Pro.Visible = False
        ElseIf ComboBox1.SelectedIndex = 3 Then
            Naga_Pro.Visible = False
        ElseIf ComboBox1.SelectedIndex = 4 Then
            Naga_Pro.Visible = False
        ElseIf ComboBox1.SelectedIndex = 5 Then
            Naga_Pro.Visible = False
        ElseIf ComboBox1.SelectedIndex = 6 Then
            Naga_Pro.Visible = False
        ElseIf ComboBox1.SelectedIndex = 7 Then
            Naga_Pro.Visible = False
        ElseIf ComboBox1.SelectedIndex = 8 Then
            Naga_Pro.Visible = False
        ElseIf ComboBox1.SelectedIndex = 9 Then
            Naga_Pro.Visible = False
        End If

        If ComboBox1.SelectedIndex = 3 Then
            Basilik_v3_Pro.Visible = True
        ElseIf ComboBox1.SelectedIndex = 0 Then
            Basilik_v3_Pro.Visible = False
        ElseIf ComboBox1.SelectedIndex = 1 Then
            Basilik_v3_Pro.Visible = False
        ElseIf ComboBox1.SelectedIndex = 2 Then
            Basilik_v3_Pro.Visible = False
        ElseIf ComboBox1.SelectedIndex = 4 Then
            Basilik_v3_Pro.Visible = False
        ElseIf ComboBox1.SelectedIndex = 5 Then
            Basilik_v3_Pro.Visible = False
        ElseIf ComboBox1.SelectedIndex = 6 Then
            Basilik_v3_Pro.Visible = False
        ElseIf ComboBox1.SelectedIndex = 7 Then
            Basilik_v3_Pro.Visible = False
        ElseIf ComboBox1.SelectedIndex = 8 Then
            Basilik_v3_Pro.Visible = False
        ElseIf ComboBox1.SelectedIndex = 9 Then
            Basilik_v3_Pro.Visible = False
        End If

        If ComboBox1.SelectedIndex = 4 Then
            Basilik_Ultimate.Visible = True
        ElseIf ComboBox1.SelectedIndex = 0 Then
            Basilik_Ultimate.Visible = False
        ElseIf ComboBox1.SelectedIndex = 1 Then
            Basilik_Ultimate.Visible = False
        ElseIf ComboBox1.SelectedIndex = 2 Then
            Basilik_Ultimate.Visible = False
        ElseIf ComboBox1.SelectedIndex = 3 Then
            Basilik_Ultimate.Visible = False
        ElseIf ComboBox1.SelectedIndex = 5 Then
            Basilik_Ultimate.Visible = False
        ElseIf ComboBox1.SelectedIndex = 6 Then
            Basilik_Ultimate.Visible = False
        ElseIf ComboBox1.SelectedIndex = 7 Then
            Basilik_Ultimate.Visible = False
        ElseIf ComboBox1.SelectedIndex = 8 Then
            Basilik_Ultimate.Visible = False
        ElseIf ComboBox1.SelectedIndex = 9 Then
            Basilik_Ultimate.Visible = False
        End If

        If ComboBox1.SelectedIndex = 5 Then
            Viper_Ultimate.Visible = True
        ElseIf ComboBox1.SelectedIndex = 0 Then
            Viper_Ultimate.Visible = False
        ElseIf ComboBox1.SelectedIndex = 1 Then
            Viper_Ultimate.Visible = False
        ElseIf ComboBox1.SelectedIndex = 2 Then
            Viper_Ultimate.Visible = False
        ElseIf ComboBox1.SelectedIndex = 3 Then
            Viper_Ultimate.Visible = False
        ElseIf ComboBox1.SelectedIndex = 4 Then
            Viper_Ultimate.Visible = False
        ElseIf ComboBox1.SelectedIndex = 6 Then
            Viper_Ultimate.Visible = False
        ElseIf ComboBox1.SelectedIndex = 7 Then
            Viper_Ultimate.Visible = False
        ElseIf ComboBox1.SelectedIndex = 8 Then
            Viper_Ultimate.Visible = False
        ElseIf ComboBox1.SelectedIndex = 9 Then
            Viper_Ultimate.Visible = False
        End If

        If ComboBox1.SelectedIndex = 6 Then
            Spatha_X.Visible = True
        ElseIf ComboBox1.SelectedIndex = 0 Then
            Spatha_X.Visible = False
        ElseIf ComboBox1.SelectedIndex = 1 Then
            Spatha_X.Visible = False
        ElseIf ComboBox1.SelectedIndex = 2 Then
            Spatha_X.Visible = False
        ElseIf ComboBox1.SelectedIndex = 3 Then
            Spatha_X.Visible = False
        ElseIf ComboBox1.SelectedIndex = 4 Then
            Spatha_X.Visible = False
        ElseIf ComboBox1.SelectedIndex = 5 Then
            Spatha_X.Visible = False
        ElseIf ComboBox1.SelectedIndex = 7 Then
            Spatha_X.Visible = False
        ElseIf ComboBox1.SelectedIndex = 8 Then
            Spatha_X.Visible = False
        ElseIf ComboBox1.SelectedIndex = 9 Then
            Spatha_X.Visible = False
        End If

        If ComboBox1.SelectedIndex = 7 Then
            G502_hero.Visible = True
        ElseIf ComboBox1.SelectedIndex = 0 Then
            G502_hero.Visible = False
        ElseIf ComboBox1.SelectedIndex = 1 Then
            G502_hero.Visible = False
        ElseIf ComboBox1.SelectedIndex = 2 Then
            G502_hero.Visible = False
        ElseIf ComboBox1.SelectedIndex = 3 Then
            G502_hero.Visible = False
        ElseIf ComboBox1.SelectedIndex = 4 Then
            G502_hero.Visible = False
        ElseIf ComboBox1.SelectedIndex = 5 Then
            G502_hero.Visible = False
        ElseIf ComboBox1.SelectedIndex = 6 Then
            G502_hero.Visible = False
        ElseIf ComboBox1.SelectedIndex = 8 Then
            G502_hero.Visible = False
        ElseIf ComboBox1.SelectedIndex = 9 Then
            G502_hero.Visible = False
        End If

        If ComboBox1.SelectedIndex = 8 Then
            Xlite_x2.Visible = True
        ElseIf ComboBox1.SelectedIndex = 0 Then
            Xlite_x2.Visible = False
        ElseIf ComboBox1.SelectedIndex = 1 Then
            Xlite_x2.Visible = False
        ElseIf ComboBox1.SelectedIndex = 2 Then
            Xlite_x2.Visible = False
        ElseIf ComboBox1.SelectedIndex = 3 Then
            Xlite_x2.Visible = False
        ElseIf ComboBox1.SelectedIndex = 4 Then
            Xlite_x2.Visible = False
        ElseIf ComboBox1.SelectedIndex = 5 Then
            Xlite_x2.Visible = False
        ElseIf ComboBox1.SelectedIndex = 6 Then
            Xlite_x2.Visible = False
        ElseIf ComboBox1.SelectedIndex = 7 Then
            Xlite_x2.Visible = False
        ElseIf ComboBox1.SelectedIndex = 9 Then
            Xlite_x2.Visible = False
        End If

        If ComboBox1.SelectedIndex = 9 Then
            Starlight_12_oseidon.Visible = True
        ElseIf ComboBox1.SelectedIndex = 0 Then
            Starlight_12_oseidon.Visible = False
        ElseIf ComboBox1.SelectedIndex = 1 Then
            Starlight_12_oseidon.Visible = False
        ElseIf ComboBox1.SelectedIndex = 2 Then
            Starlight_12_oseidon.Visible = False
        ElseIf ComboBox1.SelectedIndex = 3 Then
            Starlight_12_oseidon.Visible = False
        ElseIf ComboBox1.SelectedIndex = 4 Then
            Starlight_12_oseidon.Visible = False
        ElseIf ComboBox1.SelectedIndex = 5 Then
            Starlight_12_oseidon.Visible = False
        ElseIf ComboBox1.SelectedIndex = 6 Then
            Starlight_12_oseidon.Visible = False
        ElseIf ComboBox1.SelectedIndex = 7 Then
            Starlight_12_oseidon.Visible = False
        ElseIf ComboBox1.SelectedIndex = 8 Then
            Starlight_12_oseidon.Visible = False

        End If

        conn.Open()
        Dim mysql2 As New OleDbCommand("SELECT Mou_id FROM Mouse Where Mouse='" + ComboBox1.Text + "'", conn)
        Dim myreader2 As OleDb.OleDbDataReader = mysql2.ExecuteReader
        ListBox1.Items.Clear()
        idproduct.Items.Clear()
        While myreader2.Read()
            ListBox1.Items.Add(myreader2("Mou_id"))
            idproduct.Items.Add(myreader2("Mou_id"))

        End While
        conn.Close()

        conn.Open()
        Dim mysql3 As New OleDbCommand("SELECT Battery_Life FROM Mouse Where Mouse='" + ComboBox1.Text + "'", conn)
        Dim myreader3 As OleDb.OleDbDataReader = mysql3.ExecuteReader
        ListBox2.Items.Clear()
        While myreader3.Read()
            ListBox2.Items.Add(myreader3("Battery_Life"))


        End While
        conn.Close()

        conn.Open()
        Dim mysql4 As New OleDbCommand("SELECT Switch_life_span FROM Mouse Where Mouse='" + ComboBox1.Text + "'", conn)
        Dim myreader4 As OleDb.OleDbDataReader = mysql4.ExecuteReader
        ListBox3.Items.Clear()
        While myreader4.Read()
            ListBox3.Items.Add(myreader4("Switch_life_span"))

        End While
        conn.Close()

        conn.Open()
        Dim mysql5 As New OleDbCommand("SELECT Weight FROM Mouse Where Mouse='" + ComboBox1.Text + "'", conn)
        Dim myreader5 As OleDb.OleDbDataReader = mysql5.ExecuteReader
        ListBox4.Items.Clear()
        While myreader5.Read()
            ListBox4.Items.Add(myreader5("Weight"))

        End While
        conn.Close()

        conn.Open()
        Dim mysql6 As New OleDbCommand("SELECT Price FROM Mouse Where Mouse='" + ComboBox1.Text + "'", conn)
        Dim myreader6 As OleDb.OleDbDataReader = mysql6.ExecuteReader
        ListBox5.Items.Clear()
        price.Items.Clear()
        While myreader6.Read()
            ListBox5.Items.Add(myreader6("Price"))
            price.Items.Add(myreader6("Price"))
        End While
        conn.Close()
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
        ElseIf idproduct.Text = "" Then
            MsgBox("Please Produk ID")
        ElseIf ComboBox4.Text = "" Then
            MsgBox("Please Enter Choose Random")
        ElseIf price.Text = "" Then
            MsgBox("Please Enter Price")
        Else
            Pro = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\21220549_falcultyrecords\MiniProject\MiniProject\bin\Debug\MiniProject.accdb"
            ConnString = Pro
            MyConn.ConnectionString = ConnString
            MyConn.Open()
            Command = "INSERT INTO Customer (Staff_id, Customour_id, Produk_id, Nama, Alamat, No_Telefon, Price) VALUES ('" & ComboBox4.Text & "','" & AutoNumber.Text & "','" & idproduct.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & price.Text & "')"
            Dim cmd As OleDbCommand = New OleDbCommand(Command, MyConn)
            cmd.Parameters.Add(New OleDbParameter("Staff_id", CType(ComboBox4.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("Customour_id", CType(AutoNumber.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("Produk_id", CType(idproduct.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("Nama", CType(TextBox2.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("Alamat", CType(TextBox3.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("No_Telefon", CType(TextBox4.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("Price", CType(price.Text, String)))

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

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        generate()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim f3 As New receiptMou(Me)
        f3.Show()
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
        exitMou.Show()


    End Sub

    Private Sub Mouse_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.Location += Control.MousePosition - pos
        End If
        pos = Control.MousePosition
    End Sub
End Class