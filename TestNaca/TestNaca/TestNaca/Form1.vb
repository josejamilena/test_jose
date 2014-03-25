Public Class FormularioPrincipal

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles pBTest.Click
        Dim c As System.Net.Sockets.TcpClient = Nothing
        Dim p As Integer = 8000
        c = New Net.Sockets.TcpClient
        Try
            Try
                Integer.TryParse(pTBPort.Text, p)
            Catch ex As Exception
                MsgBox("Parámetro erroneo")
            End Try
            c.Connect("localhost", p)
            If c.Connected Then
                pImageBox.Image = Global.TestNaca.My.Resources.Resources.th
                pImageBox.Visible = True
                pBTest.Enabled = False
            End If
        Catch exp As Exception
            c = Nothing
            pImageBox.Image = Global.TestNaca.My.Resources.Resources.aplauso
            pImageBox.Visible = True
        End Try
    End Sub

End Class
