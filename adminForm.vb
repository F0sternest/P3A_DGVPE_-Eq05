Public Class adminForm
    Private Sub almacenBtn_Click(sender As Object, e As EventArgs) Handles almacenBtn.Click
        Dim cant_almacenes As Integer = InputBox("Ingrese la cantidad de almacenes", "Almacenes", "")
        Dim aux(,) As Integer 'Arreglo llamado aux
        Dim filas, columnas, i As Integer

        filas = Val(cant_almacenes) - 1
        columnas = 4
        ReDim aux(filas, columnas)

        Me.dgvM.RowHeadersWidth = 120
        dgvM.RowCount = filas + 1
        dgvM.ColumnCount = columnas + 1

        For i = 0 To filas
            dgvM.Rows(0 + i).HeaderCell.Value = InputBox("Nombre del almacen número" & i + 1, "Almacenes", "")
        Next

        'dgvM.Rows(0).HeaderCell.Value = "San Miguelito"
        'dgvM.Rows(1).HeaderCell.Value = "San Miguelito 1"
        'dgvM.Rows(2).HeaderCell.Value = "San Miguelito 2"
    End Sub

    Private Sub ejecutarSelecBtn_Click(sender As Object, e As EventArgs) Handles ejecutarSelecBtn.Click
        Dim aux(,) As Integer 'Arreglo llamado aux
        Dim filas, columnas, index, f, columnasPosicion, mayor, menor, total As Integer
        filas = Val(filas)
        columnas = filas
        ReDim aux(filas, columnas)

        For indexFilas = 0 To filas
            For indexColumna = 0 To columnas
                aux(indexFilas, indexColumna) = dgvM.Rows(indexFilas).Cells(indexColumna).Value
            Next indexColumna
        Next indexFilas


        columnasPosicion = Val(columnaTxt.Text)

        If totalRbtn.Checked Then
            mayor = aux(1, columnasPosicion)
            For f = 0 To filas
                If mayor < aux(f, columnasPosicion) Then
                    mayor = aux(f, columnasPosicion)
                End If
            Next f
            dgvM.Rows(filas + 1).Cells(0).Value = ""
            dgvM.Rows(filas + 1).Cells(1).Value = ""
            dgvM.Rows(filas + 1).Cells(2).Value = ""
            dgvM.Rows(filas + 1).Cells(columnasPosicion).Value = mayor
            dgvM.Rows(filas + 1).HeaderCell.Value = ""
        End If
    End Sub

    Private Sub adminForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub dgvM_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvM.CellContentClick

    End Sub
End Class