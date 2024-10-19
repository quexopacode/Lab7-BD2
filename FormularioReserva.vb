
'Angel Chung
'Alejandro Mosquera
'Luis Murcia
Public Class FormularioReserva
    Private Sub FormularioReserva_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpFechaEntrada.Value = DateTime.Now
        dtpFechaSalida.Value = DateTime.Now.AddDays(1)
    End Sub
    Private reserva As New Reserva()
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            If String.IsNullOrEmpty(txtNombre.Text) Then
                Throw New Exception("El nombre no puede estar vacío.")
            End If
            If dtpFechaSalida.Value <= dtpFechaEntrada.Value Then
                Throw New Exception("La fecha de salida debe ser posterior a la fecha de entrada.")
            End If
            If cmbTipoHabitacion.SelectedIndex = -1 Then
                Throw New Exception("Debe seleccionar un tipo de habitación.")
            End If

            Dim nombre As String = txtNombre.Text
            Dim fechaEntrada As Date = dtpFechaEntrada.Value
            Dim fechaSalida As Date = dtpFechaSalida.Value
            Dim tipoHabitacion As String = cmbTipoHabitacion.SelectedItem.ToString()

            reserva.InsertarReserva(nombre, fechaEntrada, fechaSalida, tipoHabitacion)
            MessageBox.Show("Reserva agregada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtNombre.Clear()
            cmbTipoHabitacion.SelectedIndex = -1
            dtpFechaEntrada.Value = DateTime.Now
            dtpFechaSalida.Value = DateTime.Now.AddDays(1)
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
