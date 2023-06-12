<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class adminForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.cantidadFilasLbl = New System.Windows.Forms.Label()
        Me.dgvM = New System.Windows.Forms.DataGridView()
        Me.columnaArena = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnaPiedra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnaCemento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Clavos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ladrillos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.almacenBtn = New System.Windows.Forms.Button()
        Me.seleccionGroup = New System.Windows.Forms.GroupBox()
        Me.totalRbtn = New System.Windows.Forms.RadioButton()
        Me.menorRbtn = New System.Windows.Forms.RadioButton()
        Me.promedioRbtn = New System.Windows.Forms.RadioButton()
        Me.mayorRbtn = New System.Windows.Forms.RadioButton()
        Me.columnaTxt = New System.Windows.Forms.TextBox()
        Me.columnaLbl = New System.Windows.Forms.Label()
        Me.ejecutarSelecBtn = New System.Windows.Forms.Button()
        Me.respuesta = New System.Windows.Forms.Label()
        Me.tbrespuesta = New System.Windows.Forms.TextBox()
        CType(Me.dgvM, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.seleccionGroup.SuspendLayout()
        Me.SuspendLayout()
        '
        'cantidadFilasLbl
        '
        Me.cantidadFilasLbl.AutoSize = True
        Me.cantidadFilasLbl.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cantidadFilasLbl.Location = New System.Drawing.Point(9, 9)
        Me.cantidadFilasLbl.Name = "cantidadFilasLbl"
        Me.cantidadFilasLbl.Size = New System.Drawing.Size(249, 32)
        Me.cantidadFilasLbl.TabIndex = 0
        Me.cantidadFilasLbl.Text = "Para ingresar el nombre de los almacenes" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "y el numero de filas presione el botón:" &
    ""
        Me.cantidadFilasLbl.UseWaitCursor = True
        '
        'dgvM
        '
        Me.dgvM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvM.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.columnaArena, Me.columnaPiedra, Me.columnaCemento, Me.Clavos, Me.Ladrillos})
        Me.dgvM.Location = New System.Drawing.Point(12, 59)
        Me.dgvM.Name = "dgvM"
        Me.dgvM.Size = New System.Drawing.Size(331, 154)
        Me.dgvM.TabIndex = 3
        Me.dgvM.UseWaitCursor = True
        '
        'columnaArena
        '
        Me.columnaArena.HeaderText = "Arena (0)"
        Me.columnaArena.Name = "columnaArena"
        '
        'columnaPiedra
        '
        Me.columnaPiedra.HeaderText = "Piedra (1)"
        Me.columnaPiedra.Name = "columnaPiedra"
        '
        'columnaCemento
        '
        Me.columnaCemento.HeaderText = "Cemento (2)"
        Me.columnaCemento.Name = "columnaCemento"
        '
        'Clavos
        '
        Me.Clavos.HeaderText = "Clavos(3)"
        Me.Clavos.Name = "Clavos"
        '
        'Ladrillos
        '
        Me.Ladrillos.HeaderText = "Ladrillos(4)"
        Me.Ladrillos.Name = "Ladrillos"
        '
        'almacenBtn
        '
        Me.almacenBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.almacenBtn.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.almacenBtn.Location = New System.Drawing.Point(264, 9)
        Me.almacenBtn.Name = "almacenBtn"
        Me.almacenBtn.Size = New System.Drawing.Size(79, 32)
        Me.almacenBtn.TabIndex = 4
        Me.almacenBtn.Text = "Ingresar "
        Me.almacenBtn.UseVisualStyleBackColor = False
        Me.almacenBtn.UseWaitCursor = True
        '
        'seleccionGroup
        '
        Me.seleccionGroup.Controls.Add(Me.totalRbtn)
        Me.seleccionGroup.Controls.Add(Me.menorRbtn)
        Me.seleccionGroup.Controls.Add(Me.promedioRbtn)
        Me.seleccionGroup.Controls.Add(Me.mayorRbtn)
        Me.seleccionGroup.Controls.Add(Me.columnaTxt)
        Me.seleccionGroup.Controls.Add(Me.columnaLbl)
        Me.seleccionGroup.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.seleccionGroup.Location = New System.Drawing.Point(349, 9)
        Me.seleccionGroup.Name = "seleccionGroup"
        Me.seleccionGroup.Size = New System.Drawing.Size(179, 126)
        Me.seleccionGroup.TabIndex = 5
        Me.seleccionGroup.TabStop = False
        Me.seleccionGroup.Text = "Seleccion"
        Me.seleccionGroup.UseWaitCursor = True
        '
        'totalRbtn
        '
        Me.totalRbtn.AutoSize = True
        Me.totalRbtn.Location = New System.Drawing.Point(96, 95)
        Me.totalRbtn.Name = "totalRbtn"
        Me.totalRbtn.Size = New System.Drawing.Size(54, 20)
        Me.totalRbtn.TabIndex = 7
        Me.totalRbtn.TabStop = True
        Me.totalRbtn.Text = "Total"
        Me.totalRbtn.UseVisualStyleBackColor = True
        Me.totalRbtn.UseWaitCursor = True
        '
        'menorRbtn
        '
        Me.menorRbtn.AutoSize = True
        Me.menorRbtn.Location = New System.Drawing.Point(96, 61)
        Me.menorRbtn.Name = "menorRbtn"
        Me.menorRbtn.Size = New System.Drawing.Size(61, 20)
        Me.menorRbtn.TabIndex = 6
        Me.menorRbtn.TabStop = True
        Me.menorRbtn.Text = "Menor"
        Me.menorRbtn.UseVisualStyleBackColor = True
        Me.menorRbtn.UseWaitCursor = True
        '
        'promedioRbtn
        '
        Me.promedioRbtn.AutoSize = True
        Me.promedioRbtn.Location = New System.Drawing.Point(9, 95)
        Me.promedioRbtn.Name = "promedioRbtn"
        Me.promedioRbtn.Size = New System.Drawing.Size(79, 20)
        Me.promedioRbtn.TabIndex = 5
        Me.promedioRbtn.TabStop = True
        Me.promedioRbtn.Text = "Promedio"
        Me.promedioRbtn.UseVisualStyleBackColor = True
        Me.promedioRbtn.UseWaitCursor = True
        '
        'mayorRbtn
        '
        Me.mayorRbtn.AutoSize = True
        Me.mayorRbtn.Location = New System.Drawing.Point(9, 61)
        Me.mayorRbtn.Name = "mayorRbtn"
        Me.mayorRbtn.Size = New System.Drawing.Size(60, 20)
        Me.mayorRbtn.TabIndex = 4
        Me.mayorRbtn.TabStop = True
        Me.mayorRbtn.Text = "Mayor"
        Me.mayorRbtn.UseVisualStyleBackColor = True
        Me.mayorRbtn.UseWaitCursor = True
        '
        'columnaTxt
        '
        Me.columnaTxt.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.columnaTxt.Location = New System.Drawing.Point(121, 27)
        Me.columnaTxt.Name = "columnaTxt"
        Me.columnaTxt.Size = New System.Drawing.Size(49, 23)
        Me.columnaTxt.TabIndex = 3
        Me.columnaTxt.UseWaitCursor = True
        '
        'columnaLbl
        '
        Me.columnaLbl.AutoSize = True
        Me.columnaLbl.Location = New System.Drawing.Point(6, 27)
        Me.columnaLbl.Name = "columnaLbl"
        Me.columnaLbl.Size = New System.Drawing.Size(109, 16)
        Me.columnaLbl.TabIndex = 2
        Me.columnaLbl.Text = "Columna deseada"
        Me.columnaLbl.UseWaitCursor = True
        '
        'ejecutarSelecBtn
        '
        Me.ejecutarSelecBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ejecutarSelecBtn.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ejecutarSelecBtn.Location = New System.Drawing.Point(394, 142)
        Me.ejecutarSelecBtn.Name = "ejecutarSelecBtn"
        Me.ejecutarSelecBtn.Size = New System.Drawing.Size(92, 41)
        Me.ejecutarSelecBtn.TabIndex = 6
        Me.ejecutarSelecBtn.Text = "Ejecutar Seleccion"
        Me.ejecutarSelecBtn.UseVisualStyleBackColor = False
        Me.ejecutarSelecBtn.UseWaitCursor = True
        '
        'respuesta
        '
        Me.respuesta.AutoSize = True
        Me.respuesta.Location = New System.Drawing.Point(391, 200)
        Me.respuesta.Name = "respuesta"
        Me.respuesta.Size = New System.Drawing.Size(10, 13)
        Me.respuesta.TabIndex = 7
        Me.respuesta.Text = "-"
        Me.respuesta.UseWaitCursor = True
        '
        'tbrespuesta
        '
        Me.tbrespuesta.Location = New System.Drawing.Point(448, 193)
        Me.tbrespuesta.Name = "tbrespuesta"
        Me.tbrespuesta.Size = New System.Drawing.Size(51, 20)
        Me.tbrespuesta.TabIndex = 8
        Me.tbrespuesta.UseWaitCursor = True
        '
        'adminForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(554, 242)
        Me.Controls.Add(Me.tbrespuesta)
        Me.Controls.Add(Me.respuesta)
        Me.Controls.Add(Me.ejecutarSelecBtn)
        Me.Controls.Add(Me.seleccionGroup)
        Me.Controls.Add(Me.almacenBtn)
        Me.Controls.Add(Me.dgvM)
        Me.Controls.Add(Me.cantidadFilasLbl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "adminForm"
        Me.Text = "Administrar"
        Me.UseWaitCursor = True
        CType(Me.dgvM, System.ComponentModel.ISupportInitialize).EndInit()
        Me.seleccionGroup.ResumeLayout(False)
        Me.seleccionGroup.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cantidadFilasLbl As Label
    Friend WithEvents dgvM As DataGridView
    Friend WithEvents almacenBtn As Button
    Friend WithEvents seleccionGroup As GroupBox
    Friend WithEvents totalRbtn As RadioButton
    Friend WithEvents menorRbtn As RadioButton
    Friend WithEvents promedioRbtn As RadioButton
    Friend WithEvents mayorRbtn As RadioButton
    Friend WithEvents columnaTxt As TextBox
    Friend WithEvents columnaLbl As Label
    Friend WithEvents ejecutarSelecBtn As Button
    Friend WithEvents columnaArena As DataGridViewTextBoxColumn
    Friend WithEvents columnaPiedra As DataGridViewTextBoxColumn
    Friend WithEvents columnaCemento As DataGridViewTextBoxColumn
    Friend WithEvents Clavos As DataGridViewTextBoxColumn
    Friend WithEvents Ladrillos As DataGridViewTextBoxColumn
    Friend WithEvents respuesta As Label
    Friend WithEvents tbrespuesta As TextBox
End Class
