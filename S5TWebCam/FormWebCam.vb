Public Class FormWebCam
    Private Sub btnCapturar_Click(sender As Object, e As EventArgs) Handles btnCapturar.Click

    End Sub

    Private Sub FormWebCam_Load(sender As Object, e As EventArgs) Handles Me.Load
        CameraControl1.Start()
    End Sub
End Class