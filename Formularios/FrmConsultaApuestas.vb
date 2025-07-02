Imports System.Data.SqlClient

Public Class FrmConsultaApuestas

    Private Sub FrmConsultaApuestas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtDesde.Value = DateTime.Today.AddDays(-7)
        dtHasta.Value = DateTime.Today

        Try
            AbrirConexion()
            Dim cmd As New SqlCommand("SELECT Id, Nombre FROM TiposApuesta", conexion)
            Dim dt As New DataTable()
            dt.Load(cmd.ExecuteReader())

            cbTipoFiltro.DataSource = dt
            cbTipoFiltro.DisplayMember = "Nombre"
            cbTipoFiltro.ValueMember = "Id"
            cbTipoFiltro.SelectedIndex = -1
        Catch ex As Exception
            MessageBox.Show("Error al cargar tipos de apuesta: " & ex.Message)
        Finally
            CerrarConexion()
        End Try
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            AbrirConexion()

            Dim query As String = "SELECT A.Fecha, T.Nombre AS Tipo, A.Numero, A.Monto, A.Estado
                                   FROM Apuestas A
                                   INNER JOIN TiposApuesta T ON A.TipoApuestaId = T.Id
                                   WHERE A.Fecha BETWEEN @desde AND @hasta"

            If cbTipoFiltro.SelectedIndex <> -1 Then
                query &= " AND T.Id = @tipoId"
            End If

            Dim cmd As New SqlCommand(query, conexion)
            cmd.Parameters.AddWithValue("@desde", dtDesde.Value.Date)
            cmd.Parameters.AddWithValue("@hasta", dtHasta.Value.Date.AddDays(1).AddSeconds(-1))

            If cbTipoFiltro.SelectedIndex <> -1 Then
                cmd.Parameters.AddWithValue("@tipoId", cbTipoFiltro.SelectedValue)
            End If

            Dim dt As New DataTable()
            dt.Load(cmd.ExecuteReader())

            dgApuestas.DataSource = dt
            dgApuestas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        Catch ex As Exception
            MessageBox.Show("Error al buscar apuestas: " & ex.Message)
        Finally
            CerrarConexion()
        End Try
    End Sub

    Private Sub EstilizarTabla()
        With dgApuestas
            .Font = New Font("Segoe UI", 10)
            .ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 10, FontStyle.Bold)
            .RowTemplate.Height = 28
            .GridColor = Color.LightGray
            .BackgroundColor = Color.WhiteSmoke
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .MultiSelect = False
            .ReadOnly = True
            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
            .AllowUserToResizeRows = False
        End With
    End Sub

End Class
