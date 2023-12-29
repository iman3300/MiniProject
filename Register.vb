Imports System.Data.OleDb
Imports System.Text.RegularExpressions
Public Class Register

    Dim pos As Point

    Dim Pro As String
    Dim ConnString As String
    Dim Command As String
    Dim MyConn As OleDbConnection = New OleDbConnection
    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Login.Show()
        Me.Hide()
    End Sub

    Private Sub Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim email As Boolean
        email = Regex.IsMatch(TextBox2.Text, "^[^@\s]+@[^@\s]+\.[^@\s]+$", RegexOptions.IgnoreCase)

        Dim Pass As Boolean
        Pass = Regex.IsMatch(TextBox3.Text, "^.*(?=.{8,})(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[!@#$%^&+=]).*$", RegexOptions.IgnoreCase)

        Dim t1, t2, t4 As String

        t1 = TextBox1.Text
        t2 = TextBox2.Text
        t4 = ComboBox1.Text



        If TextBox1.Text = "Username" Then
            MsgBox("Please Enter your Username")
        ElseIf Not email Then
            MsgBox("Please Enter Your E-mail Corretly!")
        ElseIf TextBox3.Text = "Password" Then
            MsgBox("Please Enter your Password")

        ElseIf Not Pass Then
            MsgBox("Must have 8-10 character long with at least one numeric character,uppercase,lowercase and Special character", MessageBoxButtons.OK)
        ElseIf ComboBox1.Text = "" Then
            MsgBox("Please choose your Gender")
        Else
            MsgBox("Username: " + t1 + vbCrLf + "Email: " + t2 + vbCrLf + vbCrLf + "Gender: " + t4 + vbCrLf + "SignIn Successfull!")
            Dim mysql As String = "INSERT INTO Account VALUES ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & ComboBox1.Text & "')"
            Dim mysql2 As String = "INSERT INTO customer_Cart (Username) VALUES ('" & TextBox1.Text & "')"
            Dim mywriter As New OleDb.OleDbCommand(mysql, tenet)
            Dim mywriter2 As New OleDb.OleDbCommand(mysql2, tenet)

            Try

                mywriter.Connection.Open()
                mywriter.ExecuteNonQuery()
                mywriter.Connection.Close()

                mywriter2.Connection.Open()
                mywriter2.ExecuteNonQuery()
                mywriter2.Connection.Close()

                Login.Show()
                Me.Hide()


            Catch ex As Exception

                Beep()
                MsgBox("There is a mistake in the data you entered, as shown below" & vbCrLf & vbCrLf & ex.Message)

                mywriter.Connection.Close()
            End Try
        End If

    End Sub


    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TextBox3.PasswordChar = ""
        ElseIf CheckBox1.Checked = False Then
            TextBox3.PasswordChar = "*"
        End If
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Login.Show()
        Me.Hide()

    End Sub

    Private Sub Register_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.Location += Control.MousePosition - pos
        End If
        pos = Control.MousePosition
    End Sub
End Class