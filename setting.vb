Imports System.Data.OleDb
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Data.SqlClient
Imports System.Collections.ObjectModel

Public Class setting



    Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\21220549_falcultyrecords\MiniProject\MiniProject\bin\Debug\MiniProject.accdb")

    Dim f99 As Costumer
    Dim myConnectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\21220549_falcultyrecords\MiniProject\MiniProject\bin\Debug\MiniProject.accdb"

    Dim myConnection As New OleDbConnection(myConnectionString)

    Dim rows As Integer



    Public Sub New(ByVal frm99 As Costumer)
        InitializeComponent()
        f99 = frm99
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Costumer.Show()
        Me.Hide()

    End Sub

    Private Sub setting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label5.Text = f99.Label2.Text

        conn.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\21220549_falcultyrecords\MiniProject\MiniProject\bin\Debug\MiniProject.accdb")
        conn.Open()

        Dim strsql As String
        strsql = "SELECT * FROM Account WHERE Username='" & Label5.Text & "'"
        Dim Cmd As New OleDbCommand(strsql, conn)
        Dim myreader As OleDbDataReader

        myreader = Cmd.ExecuteReader
        myreader.Read()

        TextBox1.Text = myreader("Username")
        TextBox2.Text = myreader("Email")
        TextBox3.Text = myreader("Password")
        ComboBox1.Text = myreader("Gender")


        conn.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim myCommand As OleDbCommand = myconnection.CreateCommand()



        Try

            ' Open Connection

            myconnection.Open()

            ' Execute NonQuery To Create Table

            myCommand.CommandText = "UPDATE Account SET Username = '" & TextBox1.Text & "' ,Email = '" & TextBox2.Text & "' ,Password = '" & TextBox3.Text & "' ,Gender = '" & ComboBox1.Text & "' WHERE Username = '" & Label5.Text & "'"

            rows = myCommand.ExecuteNonQuery()



        Catch ex As SqlException

            ' handle error

        Finally

            ' Close Connection

            myconnection.Close()

        End Try


    End Sub
End Class