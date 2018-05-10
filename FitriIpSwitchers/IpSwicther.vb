Namespace FitriKHCode
    Public Class IpSwicther
        Private Sub IpSwicther_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        End Sub

        Private Sub SwitchMyIp()
            Dim metode As New vbMethodIpSwicth
            Dim hasil As String = metode.IpSwitchTo("192.168.0.10", "255.255.255.0", "192.168.0.1")
            MsgBox(hasil)
        End Sub

        Private Sub BtnSwicth_Click(sender As Object, e As EventArgs) Handles BtnSwicth.Click
            SwitchMyIp()
        End Sub
    End Class
End Namespace
