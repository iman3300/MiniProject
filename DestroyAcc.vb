Imports System.Data.OleDb
Public Class DestroyAcc

    Dim pos As Point

    Dim Pro As String
    Dim ConnString As String
    Dim Command As String
    Dim Command1 As String
    Dim MyConn As OleDbConnection = New OleDbConnection
    Private Sub DestroyAcc_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If TextBox1.Text = "2022" Then


            Pro = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\21220549_falcultyrecords\MiniProject\MiniProject\bin\Debug\MiniProject.accdb"
            ConnString = Pro
            MyConn.ConnectionString = ConnString
            MyConn.Open()
            Command1 = "Delete * FROM Account"
            Dim cmd As OleDbCommand = New OleDbCommand(Command1, MyConn)

            Try
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                MyConn.Close()
                MsgBox("All Account Has Been Delete!!!")

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
    End Sub

    Private Sub DestroyAcc_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.Location += Control.MousePosition - pos
        End If
        pos = Control.MousePosition
    End Sub
End Class