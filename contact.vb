Imports System.Text.RegularExpressions
Public Class contact

    Dim pos As Point

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim email As Boolean
        email = Regex.IsMatch(TextBox1.Text, "^[^@\s]+@[^@\s]+\.[^@\s]+$", RegexOptions.IgnoreCase)

        If Not email Then
            MsgBox("Please Enter Your E-mail Corretly!")
        Else
            Dim mysql As String = "INSERT INTO Contact VALUES ('" & TextBox1.Text & "','" & ComboBox1.Text & "','" & RichTextBox1.Text & "')"

            Dim mywriter As New OleDb.OleDbCommand(mysql, tenet)
            If ComboBox1.Text = "Forget Password" Then
                MsgBox("Your Password Will be reset to !1Aabcde within 24 Hours!")

                Try

                    mywriter.Connection.Open()
                    mywriter.ExecuteNonQuery()
                    mywriter.Connection.Close()

                    Login.Show()
                    Me.Hide()


                Catch ex As Exception

                    Beep()
                    MsgBox("There is a mistake in the data you entered, as shown below" & vbCrLf & vbCrLf & ex.Message)

                    mywriter.Connection.Close()
                End Try
            ElseIf ComboBox1.Text = "Bug" Then
                MsgBox("Thanks For The Bug Report!")
                Try

                    mywriter.Connection.Open()
                    mywriter.ExecuteNonQuery()
                    mywriter.Connection.Close()

                    Login.Show()
                    Me.Hide()


                Catch ex As Exception

                    Beep()
                    MsgBox("There is a mistake in the data you entered, as shown below" & vbCrLf & vbCrLf & ex.Message)

                    mywriter.Connection.Close()
                End Try
            ElseIf ComboBox1.Text = "Other" Then
                MsgBox("Thank For The Report")


                Try

                    mywriter.Connection.Open()
                    mywriter.ExecuteNonQuery()
                    mywriter.Connection.Close()

                    Login.Show()
                    Me.Hide()


                Catch ex As Exception

                    Beep()
                    MsgBox("There is a mistake in the data you entered, as shown below" & vbCrLf & vbCrLf & ex.Message)

                    mywriter.Connection.Close()
                End Try
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Login.Show()
        Me.Hide()

    End Sub

    Private Sub contact_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub contact_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.Location += Control.MousePosition - pos
        End If
        pos = Control.MousePosition
    End Sub
End Class