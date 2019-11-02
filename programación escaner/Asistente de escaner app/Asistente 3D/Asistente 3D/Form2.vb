Public Class FRLuz
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SPEscaner.Open()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        SPEscaner.Write("a")
    End Sub
End Class