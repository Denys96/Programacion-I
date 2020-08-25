Public Class Form1
    Dim objestadistica As New estadistica
    Private Sub Btnmediaaritmetica_Click(sender As Object, e As EventArgs) Handles Btnmediaaritmetica.Click
        lblrespuestamedia.Text = objestadistica.calcularmedia(txtserie.Text.Split(","))
        lblrespuestavarianza.Text = objestadistica.calcularvarianza(txtserie.Text.Split(","))
        lblrespuestadesviacion.Text = objestadistica.calculardesvtipica(txtserie.Text.Split(","))

    End Sub

    Private Sub grdestadisticas_KeyUp(sender As Object, e As KeyEventArgs) Handles grdestadisticas.KeyUp
        Dim nfilas = grdestadisticas.Rows.Count - 1,
        totalF1 = 0,
        totalX1xF1 = 0.0,
        totalX21xF1 = 0.0

        Dim fila As New DataGridViewRow
        For i = 0 To nfilas - 1
            fila = grdestadisticas.Rows(i)
            Dim X1 = 0, F1 = 0
            If fila.Cells("X1").Value <> "" Then
                X1 = Integer.Parse(fila.Cells("X1").Value.ToString())
            End If
            If fila.Cells("F1").Value <> "" Then
                F1 = Integer.Parse(fila.Cells("F1").Value.ToString())
            End If
            totalF1 += F1
            totalX1xF1 += X1 * F1
            totalX21xF1 += X1 ^ 2 * F1

            fila.Cells("N1").Value = totalF1.ToString()
            fila.Cells("X1xF1").Value = (X1 * F1).ToString
            fila.Cells("X21xF1").Value = (X1 ^ 2 * F1).ToString

        Next
        lbltotalf1.Text = totalF1.ToString()
        lbltotalx1xf1.Text = totalX1xF1.ToString()
        lbltotalx21f1.Text = totalX21xF1.ToString

        Dim media = Math.Round(totalX1xF1 / totalF1, 2),
          varianza = Math.Round(totalX21xF1 / totalF1 - media ^ 2, 2)
        lblrespuestamedia.Text = media.ToString()
        lblrespuestavarianza.Text = varianza.ToString()
        lblrespuestadesviacion.Text = Math.Round(Math.Sqrt(varianza), 2).ToString()
    End Sub
End Class