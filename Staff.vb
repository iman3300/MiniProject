Imports System.Data.OleDb

Public Class Staff

    Dim pos As Point

    Dim f7 As Login
    Dim Pro As String
    Dim ConnString As String
    Dim Command As String
    Dim Command1 As String
    Dim MyConn As OleDbConnection = New OleDbConnection
    Dim i As Integer
    Dim cmd3 As OleDbCommand
    Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\21220549_falcultyrecords\MiniProject\MiniProject\bin\Debug\MiniProject.accdb")



    Public Sub New(ByVal frm7 As Login)
        InitializeComponent()
        f7 = frm7
    End Sub
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGrid.CellContentClick

    End Sub

    Private Sub Staff_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Button9.Visible = False
        TextBox10.Visible = False

        TextBox1.Text = f7.txt_username.Text

        Dim mysql As String = "SELECT * FROM Customer"

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)

        DataGrid.DataSource = mydatatable
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Login.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Costumer.Show()
        Me.Hide()
    End Sub



    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Pro = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\21220549_falcultyrecords\MiniProject\MiniProject\bin\Debug\MiniProject.accdb"
        ConnString = Pro
        MyConn.ConnectionString = ConnString
        MyConn.Open()
        Command = "Delete FROM Customer where Number=" & TextBox2.Text & ""
        Dim cmd As OleDbCommand = New OleDbCommand(Command, MyConn)


        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            MyConn.Close()
            MsgBox("Delete Successfully !")



            Dim mysql As String = "SELECT * FROM Customer"

            Dim mydatatable As New DataTable

            Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

            myreader.Fill(mydatatable)

            DataGrid.DataSource = mydatatable

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        If TextBox1.Text = "iman" Then
            Button10.Visible = True
            Button11.Visible = True
            Button12.Visible = True
            TextBox11.Visible = True
            MsgBox("Highrisk Mode ON! Please do not abuse!!!", MessageBoxIcon.Warning)
        End If

        Dim mysql As String = "SELECT * FROM Customer"

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)

        DataGrid.DataSource = mydatatable


        Dim mysql1 As String = "SELECT * FROM Req_cancelOr"

        Dim mydatatable1 As New DataTable

        Dim myreader1 As New OleDb.OleDbDataAdapter(mysql1, myconnection)

        myreader.Fill(mydatatable1)

        DataGrid.DataSource = mydatatable1





    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click


        Panel1.Visible = False
        Button10.Visible = False
        Button11.Visible = False
        Button12.Visible = False
        TextBox11.Visible = False


        Dim mysql As String = "SELECT * FROM Req_cancelOr"

        Dim mydatatable1 As New DataTable

        Dim myreader1 As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader1.Fill(mydatatable1)

        DataGrid.DataSource = mydatatable1

        Button9.Visible = True
        TextBox10.Visible = True

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

        If conn.State = ConnectionState.Open Then
            conn.Close()

        End If

        If TextBox9.Text = "" Then
            MsgBox("Invalid")
        Else
            conn.Open()
            Try


                cmd3 = conn.CreateCommand()
                cmd3.CommandType = CommandType.Text
                cmd3.CommandText = "UPDATE Customer SET Staff_id='" + TextBox9.Text + "',Produk_id='" + TextBox7.Text + "',Nama='" + TextBox4.Text + "',Alamat='" + TextBox3.Text + "',No_Telefon='" + TextBox5.Text + "',Price='" + TextBox6.Text + "' WHERE Number=" & i & ""
                cmd3.ExecuteNonQuery()
                MsgBox("Update Successfully!")

                Dim mysql As String = "SELECT * FROM Customer"

                Dim mydatatable As New DataTable

                Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

                myreader.Fill(mydatatable)

                DataGrid.DataSource = mydatatable

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

    End Sub
    Private Sub DataGrid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGrid.CellClick
        If conn.State = ConnectionState.Open Then
            conn.Close()

        End If
        conn.Open()

        i = Convert.ToInt64(DataGrid.SelectedCells.Item(0).Value.ToString())

        MessageBox.Show(i.ToString())

        cmd3 = conn.CreateCommand()
        cmd3.CommandType = CommandType.Text
        cmd3.CommandText = "SELECT * FROM Customer WHERE Number=" & i & ""
        cmd3.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New OleDbDataAdapter(cmd3)
        da.Fill(dt)
        Dim dr As OleDbDataReader
        dr = cmd3.ExecuteReader(CommandBehavior.CloseConnection)
        While dr.Read

            TextBox8.Text = dr.GetString(2).ToString()
            TextBox9.Text = dr.GetString(1).ToString()
            TextBox7.Text = dr.GetString(3).ToString()
            TextBox4.Text = dr.GetString(4).ToString()
            TextBox3.Text = dr.GetString(5).ToString()
            TextBox5.Text = dr.GetString(6).ToString()
            TextBox6.Text = dr.GetString(7).ToString()
        End While
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click

        PictureBox2.Visible = False
        Panel1.Visible = True
        Button10.Visible = False
        Button11.Visible = False
        Button12.Visible = False
        TextBox11.Visible = False

        Dim mysql As String = "SELECT * FROM Customer"

        Dim mydatatable1 As New DataTable

        Dim myreader1 As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader1.Fill(mydatatable1)

        DataGrid.DataSource = mydatatable1

        Button9.Visible = False
        TextBox10.Visible = False
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Pro = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\21220549_falcultyrecords\MiniProject\MiniProject\bin\Debug\MiniProject.accdb"
        ConnString = Pro
        MyConn.ConnectionString = ConnString
        MyConn.Open()
        Command = "Delete FROM Req_cancelOr where Number=" & TextBox10.Text & ""
        Dim cmd As OleDbCommand = New OleDbCommand(Command, MyConn)


        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            MyConn.Close()


            MsgBox("Delete Successfully !")

            Dim mysql As String = "SELECT * FROM Req_cancelOr"

            Dim mydatatable As New DataTable

            Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

            myreader.Fill(mydatatable)

            DataGrid.DataSource = mydatatable

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        DestroyData.Show()

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        DestroyAcc.Show()

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click

        If TextBox11.Text = "senang" Then


            Dim mysql As String = "SELECT * FROM Account"

            Dim mydatatable1 As New DataTable

            Dim myreader1 As New OleDb.OleDbDataAdapter(mysql, myconnection)

            myreader1.Fill(mydatatable1)

            DataGrid.DataSource = mydatatable1

        Else
            MsgBox("Invalid!")

        End If

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        End
    End Sub

    Private Sub Staff_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.Location += Control.MousePosition - pos
        End If
        pos = Control.MousePosition
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click


        Panel1.Visible = False
        Button10.Visible = False
        Button11.Visible = False
        Button12.Visible = False
        TextBox11.Visible = False


        Dim mysql As String = "SELECT * FROM Contact"

        Dim mydatatable1 As New DataTable

        Dim myreader1 As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader1.Fill(mydatatable1)

        DataGrid.DataSource = mydatatable1
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            PictureBox2.Visible = True
        ElseIf CheckBox1.Checked = False Then
            PictureBox2.Visible = False
        End If
    End Sub
End Class
