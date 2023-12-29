Public Class receiptEar

    Dim pos As Point

    Dim f5 As Earbuds
    Public Sub New(ByVal frm5 As Earbuds)
        InitializeComponent()
        f5 = frm5
    End Sub
    Private Sub receiptEar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = f5.AutoNumber.Text
        TextBox2.Text = f5.ComboBox4.Text
        TextBox3.Text = f5.ComboBox1.Text
        TextBox4.Text = f5.ComboBox3.Text
        TextBox5.Text = f5.ComboBox2.Text
        TextBox7.Text = f5.ComboBox4.Text

        Dim current_date As String = Date.Now
        Label15.Text = current_date
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Earbuds.Show()
        Me.Hide()

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        End
    End Sub

    Private Sub receiptEar_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.Location += Control.MousePosition - pos
        End If
        pos = Control.MousePosition
    End Sub
End Class