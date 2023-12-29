Imports System.Data.OleDb

Public Class L

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
    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        Costumer.Show()
        Me.Hide()
    End Sub



    Private Sub Keybord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.Open()
        Dim mysql As New OleDbCommand("SELECT Keybord FROM Keybord", conn)
        Dim myreader As OleDb.OleDbDataReader = mysql.ExecuteReader
        ComboBox1.Items.Clear()
        While myreader.Read()
            ComboBox1.Items.Add(myreader("Keybord"))
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
            Keycult_no_2.Visible = True
        ElseIf ComboBox1.SelectedIndex = 1 Then
            Keycult_no_2.Visible = False
        ElseIf ComboBox1.SelectedIndex = 2 Then
            Keycult_no_2.Visible = False
        ElseIf ComboBox1.SelectedIndex = 3 Then
            Keycult_no_2.Visible = False
        ElseIf ComboBox1.SelectedIndex = 4 Then
            Keycult_no_2.Visible = False
        ElseIf ComboBox1.SelectedIndex = 5 Then
            Keycult_no_2.Visible = False
        ElseIf ComboBox1.SelectedIndex = 6 Then
            Keycult_no_2.Visible = False
        ElseIf ComboBox1.SelectedIndex = 7 Then
            Keycult_no_2.Visible = False
        ElseIf ComboBox1.SelectedIndex = 8 Then
            Keycult_no_2.Visible = False
        ElseIf ComboBox1.SelectedIndex = 9 Then
            Keycult_no_2.Visible = False
        End If

        If ComboBox1.SelectedIndex = 1 Then
            TGR_jane_CE.Visible = True
        ElseIf ComboBox1.SelectedIndex = 0 Then
            TGR_jane_CE.Visible = False
        ElseIf ComboBox1.SelectedIndex = 2 Then
            TGR_jane_CE.Visible = False
        ElseIf ComboBox1.SelectedIndex = 3 Then
            TGR_jane_CE.Visible = False
        ElseIf ComboBox1.SelectedIndex = 4 Then
            TGR_jane_CE.Visible = False
        ElseIf ComboBox1.SelectedIndex = 5 Then
            TGR_jane_CE.Visible = False
        ElseIf ComboBox1.SelectedIndex = 6 Then
            TGR_jane_CE.Visible = False
        ElseIf ComboBox1.SelectedIndex = 7 Then
            TGR_jane_CE.Visible = False
        ElseIf ComboBox1.SelectedIndex = 8 Then
            TGR_jane_CE.Visible = False
        ElseIf ComboBox1.SelectedIndex = 9 Then
            TGR_jane_CE.Visible = False
        End If

        If ComboBox1.SelectedIndex = 2 Then
            TGR_jane_ME.Visible = True
        ElseIf ComboBox1.SelectedIndex = 0 Then
            TGR_jane_ME.Visible = False
        ElseIf ComboBox1.SelectedIndex = 1 Then
            TGR_jane_ME.Visible = False
        ElseIf ComboBox1.SelectedIndex = 3 Then
            TGR_jane_ME.Visible = False
        ElseIf ComboBox1.SelectedIndex = 4 Then
            TGR_jane_ME.Visible = False
        ElseIf ComboBox1.SelectedIndex = 5 Then
            TGR_jane_ME.Visible = False
        ElseIf ComboBox1.SelectedIndex = 6 Then
            TGR_jane_ME.Visible = False
        ElseIf ComboBox1.SelectedIndex = 7 Then
            TGR_jane_ME.Visible = False
        ElseIf ComboBox1.SelectedIndex = 8 Then
            TGR_jane_ME.Visible = False
        ElseIf ComboBox1.SelectedIndex = 9 Then
            TGR_jane_ME.Visible = False
        End If

        If ComboBox1.SelectedIndex = 3 Then
            Link65.Visible = True
        ElseIf ComboBox1.SelectedIndex = 0 Then
            Link65.Visible = False
        ElseIf ComboBox1.SelectedIndex = 1 Then
            Link65.Visible = False
        ElseIf ComboBox1.SelectedIndex = 2 Then
            Link65.Visible = False
        ElseIf ComboBox1.SelectedIndex = 4 Then
            Link65.Visible = False
        ElseIf ComboBox1.SelectedIndex = 5 Then
            Link65.Visible = False
        ElseIf ComboBox1.SelectedIndex = 6 Then
            Link65.Visible = False
        ElseIf ComboBox1.SelectedIndex = 7 Then
            Link65.Visible = False
        ElseIf ComboBox1.SelectedIndex = 8 Then
            Link65.Visible = False
        ElseIf ComboBox1.SelectedIndex = 9 Then
            Link65.Visible = False
        End If

        If ComboBox1.SelectedIndex = 4 Then
            Ikki68.Visible = True
        ElseIf ComboBox1.SelectedIndex = 0 Then
            Ikki68.Visible = False
        ElseIf ComboBox1.SelectedIndex = 1 Then
            Ikki68.Visible = False
        ElseIf ComboBox1.SelectedIndex = 2 Then
            Ikki68.Visible = False
        ElseIf ComboBox1.SelectedIndex = 3 Then
            Ikki68.Visible = False
        ElseIf ComboBox1.SelectedIndex = 5 Then
            Ikki68.Visible = False
        ElseIf ComboBox1.SelectedIndex = 6 Then
            Ikki68.Visible = False
        ElseIf ComboBox1.SelectedIndex = 7 Then
            Ikki68.Visible = False
        ElseIf ComboBox1.SelectedIndex = 8 Then
            Ikki68.Visible = False
        ElseIf ComboBox1.SelectedIndex = 9 Then
            Ikki68.Visible = False
        End If

        If ComboBox1.SelectedIndex = 5 Then
            TGR_Police.Visible = True
        ElseIf ComboBox1.SelectedIndex = 0 Then
            TGR_Police.Visible = False
        ElseIf ComboBox1.SelectedIndex = 1 Then
            TGR_Police.Visible = False
        ElseIf ComboBox1.SelectedIndex = 2 Then
            TGR_Police.Visible = False
        ElseIf ComboBox1.SelectedIndex = 3 Then
            TGR_Police.Visible = False
        ElseIf ComboBox1.SelectedIndex = 4 Then
            TGR_Police.Visible = False
        ElseIf ComboBox1.SelectedIndex = 6 Then
            TGR_Police.Visible = False
        ElseIf ComboBox1.SelectedIndex = 7 Then
            TGR_Police.Visible = False
        ElseIf ComboBox1.SelectedIndex = 8 Then
            TGR_Police.Visible = False
        ElseIf ComboBox1.SelectedIndex = 9 Then
            TGR_Police.Visible = False
        End If

        If ComboBox1.SelectedIndex = 6 Then
            qk65.Visible = True
        ElseIf ComboBox1.SelectedIndex = 0 Then
            qk65.Visible = False
        ElseIf ComboBox1.SelectedIndex = 1 Then
            qk65.Visible = False
        ElseIf ComboBox1.SelectedIndex = 2 Then
            qk65.Visible = False
        ElseIf ComboBox1.SelectedIndex = 3 Then
            qk65.Visible = False
        ElseIf ComboBox1.SelectedIndex = 4 Then
            qk65.Visible = False
        ElseIf ComboBox1.SelectedIndex = 5 Then
            qk65.Visible = False
        ElseIf ComboBox1.SelectedIndex = 7 Then
            qk65.Visible = False
        ElseIf ComboBox1.SelectedIndex = 8 Then
            qk65.Visible = False
        ElseIf ComboBox1.SelectedIndex = 9 Then
            qk65.Visible = False
        End If

        If ComboBox1.SelectedIndex = 7 Then
            zoom65.Visible = True
        ElseIf ComboBox1.SelectedIndex = 0 Then
            zoom65.Visible = False
        ElseIf ComboBox1.SelectedIndex = 1 Then
            zoom65.Visible = False
        ElseIf ComboBox1.SelectedIndex = 2 Then
            zoom65.Visible = False
        ElseIf ComboBox1.SelectedIndex = 3 Then
            zoom65.Visible = False
        ElseIf ComboBox1.SelectedIndex = 4 Then
            zoom65.Visible = False
        ElseIf ComboBox1.SelectedIndex = 5 Then
            zoom65.Visible = False
        ElseIf ComboBox1.SelectedIndex = 6 Then
            zoom65.Visible = False
        ElseIf ComboBox1.SelectedIndex = 8 Then
            zoom65.Visible = False
        ElseIf ComboBox1.SelectedIndex = 9 Then
            zoom65.Visible = False
        End If

        If ComboBox1.SelectedIndex = 8 Then
            promise87.Visible = True
        ElseIf ComboBox1.SelectedIndex = 0 Then
            promise87.Visible = False
        ElseIf ComboBox1.SelectedIndex = 1 Then
            promise87.Visible = False
        ElseIf ComboBox1.SelectedIndex = 2 Then
            promise87.Visible = False
        ElseIf ComboBox1.SelectedIndex = 3 Then
            promise87.Visible = False
        ElseIf ComboBox1.SelectedIndex = 4 Then
            promise87.Visible = False
        ElseIf ComboBox1.SelectedIndex = 5 Then
            promise87.Visible = False
        ElseIf ComboBox1.SelectedIndex = 6 Then
            promise87.Visible = False
        ElseIf ComboBox1.SelectedIndex = 7 Then
            promise87.Visible = False
        ElseIf ComboBox1.SelectedIndex = 9 Then
            promise87.Visible = False
        End If

        If ComboBox1.SelectedIndex = 9 Then
            Tiger80_Lite.Visible = True
        ElseIf ComboBox1.SelectedIndex = 0 Then
            Tiger80_Lite.Visible = False
        ElseIf ComboBox1.SelectedIndex = 1 Then
            Tiger80_Lite.Visible = False
        ElseIf ComboBox1.SelectedIndex = 2 Then
            Tiger80_Lite.Visible = False
        ElseIf ComboBox1.SelectedIndex = 3 Then
            Tiger80_Lite.Visible = False
        ElseIf ComboBox1.SelectedIndex = 4 Then
            Tiger80_Lite.Visible = False
        ElseIf ComboBox1.SelectedIndex = 5 Then
            Tiger80_Lite.Visible = False
        ElseIf ComboBox1.SelectedIndex = 6 Then
            Tiger80_Lite.Visible = False
        ElseIf ComboBox1.SelectedIndex = 7 Then
            Tiger80_Lite.Visible = False
        ElseIf ComboBox1.SelectedIndex = 8 Then
            Tiger80_Lite.Visible = False

        End If

        conn.Open()
        Dim mysql2 As New OleDbCommand("SELECT Price FROM Keybord Where Keybord='" + ComboBox1.Text + "'", conn)
        Dim myreader2 As OleDb.OleDbDataReader = mysql2.ExecuteReader
        ListBox1.Items.Clear()
        price.Items.Clear()

        While myreader2.Read()
            ListBox1.Items.Add(myreader2("Price"))
            price.Items.Add(myreader2("Price"))

        End While
        conn.Close()

        conn.Open()
        Dim mysql3 As New OleDbCommand("SELECT Key_id FROM Keybord Where Keybord='" + ComboBox1.Text + "'", conn)
        Dim myreader3 As OleDb.OleDbDataReader = mysql3.ExecuteReader
        ListBox2.Items.Clear()
        idproduct.Items.Clear()
        While myreader3.Read()
            ListBox2.Items.Add(myreader3("Key_id"))
            idproduct.Items.Add(myreader3("Key_id"))
        End While
        conn.Close()

        conn.Open()
        Dim mysql4 As New OleDbCommand("SELECT Mount FROM Keybord Where Keybord='" + ComboBox1.Text + "'", conn)
        Dim myreader4 As OleDb.OleDbDataReader = mysql4.ExecuteReader
        ListBox3.Items.Clear()
        While myreader4.Read()
            ListBox3.Items.Add(myreader4("Mount"))

        End While
        conn.Close()

        conn.Open()
        Dim mysql5 As New OleDbCommand("SELECT Material FROM Keybord Where Keybord='" + ComboBox1.Text + "'", conn)
        Dim myreader5 As OleDb.OleDbDataReader = mysql5.ExecuteReader
        ListBox4.Items.Clear()
        While myreader5.Read()
            ListBox4.Items.Add(myreader5("Material"))

        End While
        conn.Close()

        conn.Open()
        Dim mysql6 As New OleDbCommand("SELECT Typing_Angle FROM Keybord Where Keybord='" + ComboBox1.Text + "'", conn)
        Dim myreader6 As OleDb.OleDbDataReader = mysql6.ExecuteReader
        ListBox5.Items.Clear()
        While myreader6.Read()
            ListBox5.Items.Add(myreader6("Typing_Angle"))

        End While
        conn.Close()

        conn.Open()
        Dim mysql7 As New OleDbCommand("SELECT Weight FROM Keybord Where Keybord='" + ComboBox1.Text + "'", conn)
        Dim myreader7 As OleDb.OleDbDataReader = mysql7.ExecuteReader
        ListBox6.Items.Clear()

        While myreader7.Read()
            ListBox6.Items.Add(myreader7("Weight"))

        End While
        conn.Close()

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

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

                MsgBox("Done")

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub AutoNumber_TextChanged(sender As Object, e As EventArgs) Handles AutoNumber.TextChanged

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        generate()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim f4 As New receiptKey(Me)
        f4.Show()
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

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        exittKey.Show()


    End Sub

    Private Sub L_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.Location += Control.MousePosition - pos
        End If
        pos = Control.MousePosition
    End Sub
End Class