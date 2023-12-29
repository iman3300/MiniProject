Public Class receiptGra

    Dim pos As Point

    Dim f1 As Grafik_kad
    Public Sub New(ByVal frm1 As Grafik_kad)
        InitializeComponent()
        f1 = frm1
    End Sub

    Public Sub receiptGra_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Grafik Kad
        TextBox1.Text = f1.AutoNumber.Text 'id cus
        TextBox2.Text = f1.ComboBox3.Text  'price
        TextBox3.Text = f1.ComboBox1.Text  'produk
        TextBox4.Text = f1.ComboBox2.Text  'idProduk
        TextBox5.Text = f1.ComboBox4.Text  'Staff id
        TextBox7.Text = f1.ComboBox3.Text

        Dim current_date As String = Date.Now
        Label15.Text = current_date
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Grafik_kad.Show()
        Me.Hide()

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        End
    End Sub

    Private Sub receiptGra_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.Location += Control.MousePosition - pos
        End If
        pos = Control.MousePosition
    End Sub
End Class