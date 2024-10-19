Public Class ReporteReservas
    Private reserva As New Reserva()
    Private Sub CargarReservas()
        Try
            Dim dtReservas As DataTable = Reserva.ObtenerReservasPorTipo() ' Asegúrate de que 'reserva' sea una instancia de tu clase Reserva.
            dgtReservas.DataSource = dtReservas
        Catch ex As Exception
            MessageBox.Show("Error al cargar reservas: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            CargarReservas()
        Catch ex As Exception
            MsgBox("Error al cargar los libros: " & ex.Message)
        End Try
    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        FormularioReserva.Show()
        Me.Hide()

    End Sub
End Class