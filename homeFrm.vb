Imports System.Runtime.CompilerServices

Public Class homeFrm
    Sub cambiarPanel(ByVal panel As Form)
        mainPanel.Controls.Clear()
        panel.TopLevel = False
        mainPanel.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub presentacionBtn_Click(sender As Object, e As EventArgs)
        cambiarPanel(presentacionFrm)
    End Sub

    Private Sub adminBtn_Click(sender As Object, e As EventArgs)
        cambiarPanel(adminForm)
    End Sub

    Private Sub salirBtn_Click(sender As Object, e As EventArgs)
        Close()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub AlmacenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlmacenToolStripMenuItem.Click
        cambiarPanel(adminForm)
    End Sub

    Private Sub InicioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InicioToolStripMenuItem.Click
        cambiarPanel(presentacionFrm)
    End Sub

    Private Sub presentacionGroup_Enter(sender As Object, e As EventArgs) Handles presentacionGroup.Enter

    End Sub

    Private Sub homeFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub
End Class
