Imports System.Data.OleDb
Public Class Login
    Dim pos As Point
    Dim cmd As String
    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        Dim f8 As New Costumer
        f8.byname = txt_username.Text

        Dim f6 As New Staff(Me)

        If txt_username.Text = "Airil" And txt_password.Text = "airil12" Then
            MsgBox("!Login Successfully")
            f6.Show()
            Me.Hide()
            MsgBox("Welcome Back Airil!")
        ElseIf txt_username.Text = "iman" And txt_password.Text = "1234" Then
            MsgBox("!Login Successfully")

            f6.Show()
            Me.Hide()

            MsgBox("Welcome Back Boss!")

        ElseIf txt_username.Text = "Discordia" And txt_password.Text = "mirapanjang" Then
            MsgBox("!Login Successfully")
            f6.Show()
            Me.Hide()
            MsgBox("Welcome Back Discordia!")
        End If

        If tenet.State = ConnectionState.Closed Then
            tenet.Open()

        End If


        Using Command As New OleDbCommand("SELECT COUNT(*) From Account WHERE Username=@Username AND Password=@Password ", tenet)
            Command.Parameters.AddWithValue("@Username", OleDbType.VarChar).Value = txt_username.Text.Trim
            Command.Parameters.AddWithValue("@Password", OleDbType.VarChar).Value = txt_password.Text.Trim

            Dim count = Convert.ToInt64(Command.ExecuteScalar())

            If count > 0 Then
                MessageBox.Show("Login Successfully!")
                f8.Show()
                Me.Hide()
            ElseIf txt_username.Text = "Airil" And txt_password.Text = "airil12" Then

                f6.Show()
                Me.Hide()

            ElseIf txt_username.Text = "iman" And txt_password.Text = "1234" Then

                f6.Show()
                Me.Hide()

            ElseIf txt_username.Text = "Discordia" And txt_password.Text = "mirapanjang" Then

                f6.Show()
                Me.Hide()
            ElseIf txt_username.Text = "segitiga" And txt_password.Text = "iluminati" Then
                MsgBox("ALERT :GET READY FOR THE JUMP SCARE!!!")
                Secret.Show()
                Me.Hide()
            Else
                MsgBox("Wrong Username or Password! Please Kindly Click Report Button For Further Assistance.")
            End If


        End Using
        tenet.Close
    End Sub

    Public Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub
    Public Sub Button1_Click(sender As Object, e As EventArgs)
        Refresh()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles Button1.Click
        Register.Show()
        Me.Hide()
    End Sub

    Private Sub txt_username_TextChanged(sender As Object, e As EventArgs) Handles txt_username.TextChanged

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            txt_password.PasswordChar = ""
        ElseIf CheckBox1.Checked = False Then
            txt_password.PasswordChar = "*"
        End If

    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        exitlogin.Show()



    End Sub

    Private Sub Login_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.Location += Control.MousePosition - pos
        End If
        pos = Control.MousePosition
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Process.Start("https://www.twitter.com/")
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Process.Start("https://www.facebook.com/")
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Process.Start("https://www.google.com/")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        contact.Show()
        Me.Hide()

    End Sub
End Class
