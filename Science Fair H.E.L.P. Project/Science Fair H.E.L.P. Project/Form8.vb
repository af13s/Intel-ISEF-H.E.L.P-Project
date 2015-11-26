Public Class Form8

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)



    End Sub

    Private Sub LinkLabel3_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked

        Process.Start("http://support.amd.com/us/gpudownload/windows/Pages/auto_detect.aspx")

    End Sub

    Private Sub LinkLabel4_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        Process.Start("http://www.nvidia.com/Download/Scan.aspx")
    End Sub
End Class