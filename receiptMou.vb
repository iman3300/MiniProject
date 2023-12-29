Public Class receiptMou

    Dim pos As Point

    Dim f3 As Mouse
    Public Sub New(ByVal frm3 As Mouse)
        InitializeComponent()
        f3 = frm3
    End Sub
    Private Sub receiptMou_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = f3.AutoNumber.Text
        TextBox2.Text = f3.price.Text
        TextBox3.Text = f3.ComboBox1.Text
        TextBox4.Text = f3.idproduct.Text
        TextBox5.Text = f3.ComboBox4.Text
        TextBox7.Text = f3.price.Text

        Dim current_date As String = Date.Now
        Label15.Text = current_date
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Mouse.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        End
    End Sub

    Private Sub receiptMou_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.Location += Control.MousePosition - pos
        End If
        pos = Control.MousePosition
    End Sub
End Class