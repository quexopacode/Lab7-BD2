
'Angel Chung
'Alejandro Mosquera
'Luis Murcia
Public Class FormularioReserva
    Private reserva As New Reserva()
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            ' Capturamos los valores del formulario
            Dim nombre As String = txtNombre.Text
            Dim fechaEntrada As Date = dtpFechaEntrada.Value
            Dim fechaSalida As Date = dtpFechaSalida.Value
            Dim tipoHabitacion As String = cmbTipoHabitacion.SelectedItem.ToString()

            ' Validaciones de entrada
            If String.IsNullOrEmpty(nombre) Then
                Throw New Exception("El nombre no puede estar vacío.")
            End If
            If fechaSalida <= fechaEntrada Then
                Throw New Exception("La fecha de salida debe ser posterior a la fecha de entrada.")
            End If
            If String.IsNullOrEmpty(tipoHabitacion) Then
                Throw New Exception("Debe seleccionar un tipo de habitación.")
            End If

            ' Llamamos a la capa lógica para insertar la reserva
            reserva.InsertarReserva(nombre, fechaEntrada, fechaSalida, tipoHabitacion)

            ' Informamos al usuario que la reserva fue exitosa
            MessageBox.Show("Reserva agregada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            ' Mostrar el error al usuario en caso de fallo
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnReporte_Click(sender As Object, e As EventArgs) Handles btnReporte.Click
        ReporteReservas.Show()
        Me.Hide()
    End Sub
End Class
