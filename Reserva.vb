Imports System.Data.SqlClient

Public Class Reserva
    Private connectionString As String = "Data Source=localhost;Initial Catalog=HotelDB;Integrated Security=True"

    Public Function CalcularCostoTotal(tipoHabitacion As String, fechaEntrada As Date, fechaSalida As Date) As Decimal
        Try
            Dim precioPorDia As Decimal

            Select Case tipoHabitacion
                Case "Individual"
                    precioPorDia = 50D
                Case "Doble"
                    precioPorDia = 75D
                Case "Suite"
                    precioPorDia = 120D
                Case Else
                    Throw New Exception("Tipo de habitación no válido.")
            End Select

            ' Calcular los días de la estadía
            Dim diasEstadia As Integer = (fechaSalida - fechaEntrada).Days

            ' Calcular el costo total
            Return precioPorDia * diasEstadia
        Catch ex As Exception
            ' Manejo de errores específicos en el cálculo del costo
            Throw New Exception("Error al calcular el costo total: " & ex.Message)
        End Try
    End Function

    ' Función para insertar una reserva (llama al procedimiento almacenado)
    Public Sub InsertarReserva(nombre As String, fechaEntrada As Date, fechaSalida As Date, tipoHabitacion As String)

        Try
            ' Primero calculamos el costo total
            Dim costoTotal As Decimal = CalcularCostoTotal(tipoHabitacion, fechaEntrada, fechaSalida)

            ' Luego realizamos la inserción en la base de datos
            Using con As New SqlConnection(connectionString)
                Using cmd As New SqlCommand("InsertarReserva", con)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.AddWithValue("@Nombre", nombre)
                    cmd.Parameters.AddWithValue("@FechaEntrada", fechaEntrada)
                    cmd.Parameters.AddWithValue("@FechaSalida", fechaSalida)
                    cmd.Parameters.AddWithValue("@TipoHabitacion", tipoHabitacion)
                    cmd.Parameters.AddWithValue("@CostoTotal", costoTotal)

                    con.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using
        Catch sqlEx As SqlException
            ' Manejo específico para errores relacionados con SQL
            Throw New Exception("Error en la base de datos al insertar la reserva: " & sqlEx.Message)
        Catch ex As Exception
            ' Manejo general de excepciones
            Throw New Exception("Error al insertar la reserva: " & ex.Message)
        End Try
    End Sub


    Public Function ObtenerReservasPorTipo() As DataTable
        Dim dt As New DataTable()

        Try
            Using con As New SqlConnection(connectionString)
                Using cmd As New SqlCommand("ReporteReservasPorTipo", con)
                    cmd.CommandType = CommandType.StoredProcedure
                    Using adapter As New SqlDataAdapter(cmd)
                        adapter.Fill(dt)
                    End Using
                End Using
            End Using
        Catch sqlEx As SqlException
            ' Manejo específico para errores relacionados con SQL
            Throw New Exception("Error al obtener reservas por tipo: " & sqlEx.Message)
        Catch ex As Exception
            ' Manejo general de excepciones
            Throw New Exception("Error al obtener reservas: " & ex.Message)
        End Try

        Return dt
    End Function

End Class
