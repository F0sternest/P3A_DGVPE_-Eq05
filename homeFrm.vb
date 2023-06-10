Public Class homeFrm
    Sub cambiarPanel(ByVal panel As Form)
        mainPanel.Controls.Clear()
        panel.TopLevel = False
        mainPanel.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub presentacionBtn_Click(sender As Object, e As EventArgs) Handles presentacionBtn.Click
        cambiarPanel(presentacionFrm)
    End Sub

    Private Sub adminBtn_Click(sender As Object, e As EventArgs) Handles adminBtn.Click
        cambiarPanel(adminForm)
    End Sub

    Private Sub salirBtn_Click(sender As Object, e As EventArgs) Handles salirBtn.Click
        Close()
    End Sub
End Class
