Public Class adminForm

    Dim n As Integer
    Private Sub almacenBtn_Click(sender As Object, e As EventArgs) Handles almacenBtn.Click
        Dim cant_almacenes As Integer = InputBox("Ingrese la cantidad de almacenes", "Almacenes", "")
        Dim aux(,) As Integer 'Arreglo llamado aux
        Dim filas, columnas, i As Integer
        n = cant_almacenes

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
        Dim promedio As Double
        filas = Val(n) - 1
        'columnas = filas
        columnas = 4
        ReDim aux(filas, columnas)

        For indexFilas = 0 To filas
            For indexColumna = 0 To columnas
                aux(indexFilas, indexColumna) = dgvM.Rows(indexFilas).Cells(indexColumna).Value
            Next indexColumna
        Next indexFilas

        For i = 0 To filas
            For j = 0 To columnas
                aux(i, j) = dgvM.Rows(i).Cells(j).Value
            Next j
        Next i


        columnasPosicion = Val(columnaTxt.Text) - 1

        If totalRbtn.Checked = True Then
            mayor = aux(1, columnasPosicion)
            For f = 0 To filas
                total = aux(f, columnasPosicion) + total
            Next f
            respuesta.Text = "Total"
            tbrespuesta.Text = total
        ElseIf mayorRbtn.Checked = True Then
            mayor = aux(f, columnasPosicion)
            For f = 0 To filas
                If mayor < aux(f, columnasPosicion) Then
                    mayor = aux(f, columnasPosicion)
                End If
            Next f
            respuesta.Text = "Promedio"
            tbrespuesta.Text = promedio
        ElseIf menorRbtn.Checked = True Then
            menor = aux(f, columnasPosicion)
            For f = 0 To filas
                If menor > aux(f, columnasPosicion) Then
                    menor = aux(f, columnasPosicion)
                End If
                respuesta.Text = "Menor"
                tbrespuesta.Text = menor
            Next

        End If




    End Sub

    Private Sub adminForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub dgvM_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvM.CellContentClick

    End Sub
End Class