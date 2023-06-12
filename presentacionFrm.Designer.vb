<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class presentacionFrm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(presentacionFrm))
        Me.presentacionGroup = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pb_almacen = New System.Windows.Forms.PictureBox()
        Me.presentacionGroup.SuspendLayout()
        CType(Me.pb_almacen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'presentacionGroup
        '
        Me.presentacionGroup.BackColor = System.Drawing.Color.White
        Me.presentacionGroup.Controls.Add(Me.pb_almacen)
        Me.presentacionGroup.Controls.Add(Me.Label5)
        Me.presentacionGroup.Controls.Add(Me.Label4)
        Me.presentacionGroup.Controls.Add(Me.Label8)
        Me.presentacionGroup.Controls.Add(Me.Label3)
        Me.presentacionGroup.Controls.Add(Me.Label6)
        Me.presentacionGroup.Controls.Add(Me.Label7)
        Me.presentacionGroup.Controls.Add(Me.Label10)
        Me.presentacionGroup.Controls.Add(Me.Label9)
        Me.presentacionGroup.Controls.Add(Me.Label2)
        Me.presentacionGroup.Controls.Add(Me.Label1)
        Me.presentacionGroup.Location = New System.Drawing.Point(3, 12)
        Me.presentacionGroup.Name = "presentacionGroup"
        Me.presentacionGroup.Size = New System.Drawing.Size(850, 493)
        Me.presentacionGroup.TabIndex = 4
        Me.presentacionGroup.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(73, 312)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 19)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Integrantes:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(669, 359)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 19)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Equipo: #5"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(71, 379)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(212, 19)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Kevin Rodriguez 8-973-2498"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(645, 312)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 19)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Grupo: 1IL132"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(71, 343)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(223, 19)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Natasha Urdaneta E-8-171454"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(23, 283)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(0, 13)
        Me.Label7.TabIndex = 25
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(73, 220)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(686, 57)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = resources.GetString("Label10.Text")
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(73, 80)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(221, 19)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Cambios inmediatos en textos"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(73, 130)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 19)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Práctica 2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(73, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(323, 19)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Herramientas de Programacion Aplicadas III"
        '
        'pb_almacen
        '
        Me.pb_almacen.Image = Global.P3A_DGVPE__Eq05.My.Resources.Resources.almacen
        Me.pb_almacen.Location = New System.Drawing.Point(489, 31)
        Me.pb_almacen.Name = "pb_almacen"
        Me.pb_almacen.Size = New System.Drawing.Size(270, 152)
        Me.pb_almacen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_almacen.TabIndex = 28
        Me.pb_almacen.TabStop = False
        '
        'presentacionFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(850, 788)
        Me.Controls.Add(Me.presentacionGroup)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "presentacionFrm"
        Me.Text = "presentacionFrm"
        Me.presentacionGroup.ResumeLayout(False)
        Me.presentacionGroup.PerformLayout()
        CType(Me.pb_almacen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents presentacionGroup As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents pb_almacen As PictureBox
End Class
