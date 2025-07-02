Imports System.Data.SqlClient

Public Class FrmApuestas

    Private numeroActual As String = ""
    Private cantidadPermitida As Integer = 1
    Private rangoMin As Integer = 0
    Private rangoMax As Integer = 99
    Private tieneNumeroExtra As Boolean = False
    Private Sub FrmApuestas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            AbrirConexion()
            Dim cmd As New SqlCommand("SELECT Id, Nombre FROM TiposApuesta", conexion)
            Dim reader As SqlDataReader = cmd.ExecuteReader()
            Dim dt As New DataTable()
            dt.Load(reader)

            cbTipoApuesta.DataSource = dt
            cbTipoApuesta.DisplayMember = "Nombre"
            cbTipoApuesta.ValueMember = "Id"
        Catch ex As Exception
            MessageBox.Show("Error al cargar tipos de apuesta: " & ex.Message)
        Finally
            CerrarConexion()
        End Try

    End Sub


    Private Sub cbTipoApuesta_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbTipoApuesta.SelectionChangeCommitted
        Try
            AbrirConexion()
            Dim cmd As New SqlCommand("SELECT CantidadNumeros, RangoMin, RangoMax, TieneNumeroExtra FROM TiposApuesta WHERE Id = @id", conexion)
            cmd.Parameters.AddWithValue("@id", cbTipoApuesta.SelectedValue)
            Dim reader As SqlDataReader = cmd.ExecuteReader()

            If reader.Read() Then
                cantidadPermitida = CInt(reader("CantidadNumeros"))
                rangoMin = CInt(reader("RangoMin"))
                rangoMax = CInt(reader("RangoMax"))
                tieneNumeroExtra = CBool(reader("TieneNumeroExtra"))
            End If
            reader.Close()

            txtNumero.Text = ""
            txtMonto.Text = ""
            numeroActual = ""

        Catch ex As Exception
            MessageBox.Show("Error al cargar configuración de apuesta: " & ex.Message)
        Finally
            CerrarConexion()
        End Try
    End Sub

    Private Sub AgregarNumero(digito As String)
        numeroActual &= digito

        If numeroActual.Length = 2 Then
            Dim valor As Integer = CInt(numeroActual)

            If valor < rangoMin OrElse valor > rangoMax Then
                MessageBox.Show("Número fuera de rango permitido (" & rangoMin & "–" & rangoMax & ")")
                numeroActual = ""
                Exit Sub
            End If

            Dim maxCantidad As Integer = cantidadPermitida + If(tieneNumeroExtra, 1, 0)
            Dim listaActual As List(Of String) = If(txtNumero.Text = "", New List(Of String), txtNumero.Text.Split(","c).Select(Function(n) n.Trim()).ToList())

            If listaActual.Count >= maxCantidad Then
                MessageBox.Show("Ya ingresaste el máximo de números permitidos (" & maxCantidad & ")")
                numeroActual = ""
                Exit Sub
            End If

            Dim esDuplicado As Boolean = listaActual.Contains(numeroActual)

            If esDuplicado Then
                If Not tieneNumeroExtra OrElse listaActual.Count < maxCantidad - 1 Then
                    MessageBox.Show("Este número ya fue ingresado.")
                    numeroActual = ""
                    Exit Sub
                End If
            End If

            If txtNumero.Text <> "" Then
                txtNumero.Text &= ", "
            End If
            txtNumero.Text &= numeroActual
            numeroActual = ""
        End If
    End Sub


    Private Sub btnNum0_Click(sender As Object, e As EventArgs) Handles btnNum0.Click
        AgregarNumero("0")
    End Sub

    Private Sub btnNum1_Click(sender As Object, e As EventArgs) Handles btnNum1.Click
        AgregarNumero("1")
    End Sub

    Private Sub btnNum2_Click(sender As Object, e As EventArgs) Handles btnNum2.Click
        AgregarNumero("2")
    End Sub

    Private Sub btnNum3_Click(sender As Object, e As EventArgs) Handles btnNum3.Click
        AgregarNumero("3")
    End Sub

    Private Sub btnNum4_Click(sender As Object, e As EventArgs) Handles btnNum4.Click
        AgregarNumero("4")
    End Sub

    Private Sub btnNum5_Click(sender As Object, e As EventArgs) Handles btnNum5.Click
        AgregarNumero("5")
    End Sub

    Private Sub btnNum6_Click(sender As Object, e As EventArgs) Handles btnNum6.Click
        AgregarNumero("6")
    End Sub

    Private Sub btnNum7_Click(sender As Object, e As EventArgs) Handles btnNum7.Click
        AgregarNumero("7")
    End Sub

    Private Sub btnNum8_Click(sender As Object, e As EventArgs) Handles btnNum8.Click
        AgregarNumero("8")
    End Sub

    Private Sub btnNum9_Click(sender As Object, e As EventArgs) Handles btnNum9.Click
        AgregarNumero("9")
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If numeroActual.Length > 0 Then
            numeroActual = ""
            Exit Sub
        End If

        If txtNumero.Text.Contains(",") Then
            Dim partes As String() = txtNumero.Text.Split(","c)
            txtNumero.Text = String.Join(", ", partes, 0, partes.Length - 1).Trim()
        Else
            txtNumero.Text = ""
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtNumero.Text = ""
        txtMonto.Text = ""
        numeroActual = ""
    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        If cbTipoApuesta.SelectedIndex = -1 Or txtNumero.Text = "" Or txtMonto.Text = "" Then
            MessageBox.Show("Completa todos los campos.")
            Exit Sub
        End If

        Dim monto As Decimal
        If Not Decimal.TryParse(txtMonto.Text, monto) Then
            MessageBox.Show("Monto inválido.")
            Exit Sub
        End If

        Try
            AbrirConexion()
            Dim cmd As New SqlCommand("INSERT INTO Apuestas (UsuarioId, TipoApuestaId, Numero, Monto) VALUES (@UsuarioId, @TipoApuestaId, @Numero, @Monto)", conexion)
            cmd.Parameters.AddWithValue("@UsuarioId", 1)
            cmd.Parameters.AddWithValue("@TipoApuestaId", cbTipoApuesta.SelectedValue)
            cmd.Parameters.AddWithValue("@Numero", txtNumero.Text)
            cmd.Parameters.AddWithValue("@Monto", monto)
            cmd.ExecuteNonQuery()

            MessageBox.Show("✅ Apuesta registrada correctamente.")
            txtNumero.Text = ""
            txtMonto.Text = ""
            numeroActual = ""
        Catch ex As Exception
            MessageBox.Show("Error al registrar la apuesta: " & ex.Message)
        Finally
            CerrarConexion()
        End Try
    End Sub

    Private Sub btnVer_Click(sender As Object, e As EventArgs) Handles btnVer.Click
        Dim frm As New FrmConsultaApuestas()
        frm.ShowDialog()
    End Sub

    Private Sub btnSorteo_Click(sender As Object, e As EventArgs) Handles btnSorteo.Click
        Dim frm As New FrmSortearResultado()
        frm.ShowDialog()
    End Sub

End Class
