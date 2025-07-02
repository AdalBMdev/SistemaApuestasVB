Imports System.Data.SqlClient

Public Class FrmSortearResultado

    Private Sub FrmSortearResultado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtFechaSorteo.Value = DateTime.Today
        Try
            AbrirConexion()
            Dim cmd As New SqlCommand("SELECT Id, Nombre FROM TiposApuesta", conexion)
            Dim dt As New DataTable()
            dt.Load(cmd.ExecuteReader())
            cbTipoSorteo.DataSource = dt
            cbTipoSorteo.DisplayMember = "Nombre"
            cbTipoSorteo.ValueMember = "Id"
        Catch ex As Exception
            MessageBox.Show("Error al cargar tipos de apuesta: " & ex.Message)
        Finally
            CerrarConexion()
        End Try
    End Sub

    Private Sub btnSortear_Click(sender As Object, e As EventArgs) Handles btnSortear.Click
        If cbTipoSorteo.SelectedIndex = -1 Then
            MessageBox.Show("Selecciona un tipo de apuesta.")
            Exit Sub
        End If

        Dim tipoId As Integer = cbTipoSorteo.SelectedValue
        Dim cantidadNumeros As Integer = 0
        Dim rangoMin As Integer = 0
        Dim rangoMax As Integer = 0

        Try
            AbrirConexion()

            Dim cmdConfig As New SqlCommand("SELECT CantidadNumeros, RangoMin, RangoMax FROM TiposApuesta WHERE Id = @id", conexion)
            cmdConfig.Parameters.AddWithValue("@id", tipoId)
            Dim reader = cmdConfig.ExecuteReader()
            If reader.Read() Then
                cantidadNumeros = CInt(reader("CantidadNumeros"))
                rangoMin = CInt(reader("RangoMin"))
                rangoMax = CInt(reader("RangoMax"))
            Else
                MessageBox.Show("No se encontró configuración.")
                Exit Sub
            End If
            reader.Close()

            Dim rand As New Random()
            Dim ganadores As New List(Of String)
            While ganadores.Count < cantidadNumeros
                Dim num = rand.Next(rangoMin, rangoMax + 1).ToString("00")
                If Not ganadores.Contains(num) Then
                    ganadores.Add(num)
                End If
            End While

            Dim resultadoFinal = String.Join(", ", ganadores)
            txtResultado.Text = resultadoFinal

            Dim cmdInsert As New SqlCommand("INSERT INTO Resultados (TipoApuestaId, NumeroGanador, Fecha) VALUES (@tipo, @numero, @fecha)", conexion)
            cmdInsert.Parameters.AddWithValue("@tipo", tipoId)
            cmdInsert.Parameters.AddWithValue("@numero", resultadoFinal)
            cmdInsert.Parameters.AddWithValue("@fecha", dtFechaSorteo.Value.Date)
            cmdInsert.ExecuteNonQuery()

            EvaluarApuestas(tipoId, resultadoFinal, dtFechaSorteo.Value.Date)

            MessageBox.Show("🎉 Sorteo realizado y apuestas evaluadas.")
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            CerrarConexion()
        End Try
    End Sub

    Private Sub EvaluarApuestas(tipoId As Integer, resultado As String, fecha As Date)
        Dim numerosGanadores = resultado.Split(","c).Select(Function(n) n.Trim()).ToList()

        Dim cmdSelect As New SqlCommand("SELECT Id, Numero FROM Apuestas WHERE TipoApuestaId = @tipo AND CONVERT(DATE, Fecha) = @fecha AND Estado = 'Pendiente'", conexion)
        cmdSelect.Parameters.AddWithValue("@tipo", tipoId)
        cmdSelect.Parameters.AddWithValue("@fecha", fecha)

        Dim tabla As New DataTable()
        tabla.Load(cmdSelect.ExecuteReader())

        For Each row As DataRow In tabla.Rows
            Dim apuestaId = CInt(row("Id"))
            Dim numerosApuesta = row("Numero").ToString().Split(","c).Select(Function(n) n.Trim()).ToList()

            Dim aciertos As Integer = 0
            For Each num In numerosApuesta
                If numerosGanadores.Contains(num) Then
                    aciertos += 1
                End If
            Next

            Dim estado As String = If(aciertos = numerosApuesta.Count, "Premiada", "Perdida")

            Dim cmdUpdate As New SqlCommand("UPDATE Apuestas SET Estado = @estado WHERE Id = @id", conexion)
            cmdUpdate.Parameters.AddWithValue("@estado", estado)
            cmdUpdate.Parameters.AddWithValue("@id", apuestaId)
            cmdUpdate.ExecuteNonQuery()
        Next
    End Sub
End Class
