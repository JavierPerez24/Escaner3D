Public Class FRLuz
    Private Sub FRLuz_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SPEscaner.Open()
    End Sub

    Private Sub CBAlto_CheckedChanged(sender As Object, e As EventArgs) Handles CBAlto.CheckedChanged
        SPEscaner.Write(1)
    End Sub

    Private Sub CBMedio_CheckedChanged(sender As Object, e As EventArgs) Handles CBMedio.CheckedChanged
        SPEscaner.Write(2)
    End Sub

    Private Sub CBBajo_CheckedChanged(sender As Object, e As EventArgs) Handles CBBajo.CheckedChanged
        SPEscaner.Write(3)
    End Sub

    Private Sub CBManual_CheckedChanged(sender As Object, e As EventArgs) Handles CBManual.CheckedChanged
        SPEscaner.Write(4)
        TBLuz.Enabled

    End Sub

    Private Sub TBLuz_Scroll(sender As Object, e As EventArgs) Handles TBLuz.Scroll
        SPEscaner.Write(TBLuz.Value)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form3.Show()
    End Sub
End Class