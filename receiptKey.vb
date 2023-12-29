Public Class receiptKey

    Dim pos As Point

    Dim f4 As L
    Public Sub New(ByVal frm4 As L)
        InitializeComponent()
        f4 = frm4
    End Sub
    Private Sub receiptKey_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = f4.AutoNumber.Text
        TextBox2.Text = f4.price.Text
        TextBox3.Text = f4.ComboBox1.Text
        TextBox4.Text = f4.idproduct.Text
        TextBox5.Text = f4.ComboBox4.Text
        TextBox7.Text = f4.price.Text

        Dim current_date As String = Date.Now
        Label15.Text = current_date
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        L.Show()
        Me.Hide()

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Panel19_Paint(sender As Object, e As PaintEventArgs) Handles Panel19.Paint

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub receiptKey_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.Location += Control.MousePosition - pos
        End If
        pos = Control.MousePosition
    End Sub
End Class