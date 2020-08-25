Public Class Form1
    Dim objestadistica As New estadistica
    Private Sub Btnmediaaritmetica_Click(sender As Object, e As EventArgs) Handles Btnmediaaritmetica.Click
        lblrespuestamedia.Text = objestadistica.calcularmedia(txtserie.Text.Split(","))
        lblrespuestavarianza.Text = objestadistica.calcularvarianza(txtserie.Text.Split(","))
        lblrespuestadesviacion.Text = objestadistica.calculardesvtipica(txtserie.Text.Split(","))

    End Sub
End Class