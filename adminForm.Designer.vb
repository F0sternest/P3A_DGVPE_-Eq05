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
        Me.filasTxt = New System.Windows.Forms.TextBox()
        Me.numeroFilasLbl = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.almacenBtn = New System.Windows.Forms.Button()
        Me.seleccionGroup = New System.Windows.Forms.GroupBox()
        Me.columnaTxt = New System.Windows.Forms.TextBox()
        Me.columnaLbl = New System.Windows.Forms.Label()
        Me.mayorRbtn = New System.Windows.Forms.RadioButton()
        Me.promedioRbtn = New System.Windows.Forms.RadioButton()
        Me.menorRbtn = New System.Windows.Forms.RadioButton()
        Me.totalRbtn = New System.Windows.Forms.RadioButton()
        Me.ejecutarSelecBtn = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.seleccionGroup.SuspendLayout()
        Me.SuspendLayout()
        '
        'cantidadFilasLbl
        '
        Me.cantidadFilasLbl.AutoSize = True
        Me.cantidadFilasLbl.Location = New System.Drawing.Point(27, 24)
        Me.cantidadFilasLbl.Name = "cantidadFilasLbl"
        Me.cantidadFilasLbl.Size = New System.Drawing.Size(88, 13)
        Me.cantidadFilasLbl.TabIndex = 0
        Me.cantidadFilasLbl.Text = "Cantidad de Filas"
        '
        'filasTxt
        '
        Me.filasTxt.Location = New System.Drawing.Point(121, 21)
        Me.filasTxt.Name = "filasTxt"
        Me.filasTxt.Size = New System.Drawing.Size(100, 20)
        Me.filasTxt.TabIndex = 1
        '
        'numeroFilasLbl
        '
        Me.numeroFilasLbl.AutoSize = True
        Me.numeroFilasLbl.Location = New System.Drawing.Point(25, 40)
        Me.numeroFilasLbl.Name = "numeroFilasLbl"
        Me.numeroFilasLbl.Size = New System.Drawing.Size(92, 13)
        Me.numeroFilasLbl.TabIndex = 2
        Me.numeroFilasLbl.Text = "(Diseñado para #)"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(30, 72)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(616, 150)
        Me.DataGridView1.TabIndex = 3
        '
        'almacenBtn
        '
        Me.almacenBtn.Location = New System.Drawing.Point(487, 24)
        Me.almacenBtn.Name = "almacenBtn"
        Me.almacenBtn.Size = New System.Drawing.Size(133, 23)
        Me.almacenBtn.TabIndex = 4
        Me.almacenBtn.Text = "Identificar Almacen"
        Me.almacenBtn.UseVisualStyleBackColor = True
        '
        'seleccionGroup
        '
        Me.seleccionGroup.Controls.Add(Me.totalRbtn)
        Me.seleccionGroup.Controls.Add(Me.menorRbtn)
        Me.seleccionGroup.Controls.Add(Me.promedioRbtn)
        Me.seleccionGroup.Controls.Add(Me.mayorRbtn)
        Me.seleccionGroup.Controls.Add(Me.columnaTxt)
        Me.seleccionGroup.Controls.Add(Me.columnaLbl)
        Me.seleccionGroup.Location = New System.Drawing.Point(30, 237)
        Me.seleccionGroup.Name = "seleccionGroup"
        Me.seleccionGroup.Size = New System.Drawing.Size(292, 135)
        Me.seleccionGroup.TabIndex = 5
        Me.seleccionGroup.TabStop = False
        Me.seleccionGroup.Text = "Seleccion"
        '
        'columnaTxt
        '
        Me.columnaTxt.Location = New System.Drawing.Point(121, 24)
        Me.columnaTxt.Name = "columnaTxt"
        Me.columnaTxt.Size = New System.Drawing.Size(100, 20)
        Me.columnaTxt.TabIndex = 3
        '
        'columnaLbl
        '
        Me.columnaLbl.AutoSize = True
        Me.columnaLbl.Location = New System.Drawing.Point(6, 27)
        Me.columnaLbl.Name = "columnaLbl"
        Me.columnaLbl.Size = New System.Drawing.Size(92, 13)
        Me.columnaLbl.TabIndex = 2
        Me.columnaLbl.Text = "Columna deseada"
        '
        'mayorRbtn
        '
        Me.mayorRbtn.AutoSize = True
        Me.mayorRbtn.Location = New System.Drawing.Point(61, 61)
        Me.mayorRbtn.Name = "mayorRbtn"
        Me.mayorRbtn.Size = New System.Drawing.Size(54, 17)
        Me.mayorRbtn.TabIndex = 4
        Me.mayorRbtn.TabStop = True
        Me.mayorRbtn.Text = "Mayor"
        Me.mayorRbtn.UseVisualStyleBackColor = True
        '
        'promedioRbtn
        '
        Me.promedioRbtn.AutoSize = True
        Me.promedioRbtn.Location = New System.Drawing.Point(61, 95)
        Me.promedioRbtn.Name = "promedioRbtn"
        Me.promedioRbtn.Size = New System.Drawing.Size(69, 17)
        Me.promedioRbtn.TabIndex = 5
        Me.promedioRbtn.TabStop = True
        Me.promedioRbtn.Text = "Promedio"
        Me.promedioRbtn.UseVisualStyleBackColor = True
        '
        'menorRbtn
        '
        Me.menorRbtn.AutoSize = True
        Me.menorRbtn.Location = New System.Drawing.Point(146, 61)
        Me.menorRbtn.Name = "menorRbtn"
        Me.menorRbtn.Size = New System.Drawing.Size(55, 17)
        Me.menorRbtn.TabIndex = 6
        Me.menorRbtn.TabStop = True
        Me.menorRbtn.Text = "Menor"
        Me.menorRbtn.UseVisualStyleBackColor = True
        '
        'totalRbtn
        '
        Me.totalRbtn.AutoSize = True
        Me.totalRbtn.Location = New System.Drawing.Point(146, 95)
        Me.totalRbtn.Name = "totalRbtn"
        Me.totalRbtn.Size = New System.Drawing.Size(49, 17)
        Me.totalRbtn.TabIndex = 7
        Me.totalRbtn.TabStop = True
        Me.totalRbtn.Text = "Total"
        Me.totalRbtn.UseVisualStyleBackColor = True
        '
        'ejecutarSelecBtn
        '
        Me.ejecutarSelecBtn.Location = New System.Drawing.Point(465, 296)
        Me.ejecutarSelecBtn.Name = "ejecutarSelecBtn"
        Me.ejecutarSelecBtn.Size = New System.Drawing.Size(124, 23)
        Me.ejecutarSelecBtn.TabIndex = 6
        Me.ejecutarSelecBtn.Text = "Ejecutar Seleccion"
        Me.ejecutarSelecBtn.UseVisualStyleBackColor = True
        '
        'adminForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(677, 375)
        Me.Controls.Add(Me.ejecutarSelecBtn)
        Me.Controls.Add(Me.seleccionGroup)
        Me.Controls.Add(Me.almacenBtn)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.numeroFilasLbl)
        Me.Controls.Add(Me.filasTxt)
        Me.Controls.Add(Me.cantidadFilasLbl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "adminForm"
        Me.Text = "Administrar"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.seleccionGroup.ResumeLayout(False)
        Me.seleccionGroup.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cantidadFilasLbl As Label
    Friend WithEvents filasTxt As TextBox
    Friend WithEvents numeroFilasLbl As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents almacenBtn As Button
    Friend WithEvents seleccionGroup As GroupBox
    Friend WithEvents totalRbtn As RadioButton
    Friend WithEvents menorRbtn As RadioButton
    Friend WithEvents promedioRbtn As RadioButton
    Friend WithEvents mayorRbtn As RadioButton
    Friend WithEvents columnaTxt As TextBox
    Friend WithEvents columnaLbl As Label
    Friend WithEvents ejecutarSelecBtn As Button
End Class
