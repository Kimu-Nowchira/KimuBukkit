Imports System.Net
Public Class UpdateForm
    Dim ptmcu, ptmnew, ptfcu, ptfnew As Point
    Dim aa As Boolean = False
    Dim Client As New WebClient
    Dim Pio As Long

    Private Sub picturebox3_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox2.MouseDown
        If e.Button = MouseButtons.Left Then
            aa = True
            ptmcu = Control.MousePosition
            ptfcu = Me.Location
        End If
    End Sub

    Private Sub PictureBox3_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox2.MouseMove
        If aa = True Then
            ptmnew = Control.MousePosition
            ptfnew.X = ptmnew.X - ptmcu.X + ptfcu.X
            ptfnew.Y = ptmnew.Y - ptmcu.Y + ptfcu.Y
            Me.Location = ptfnew
            ptfcu = ptfnew
            ptmcu = ptmnew
        End If
    End Sub

    Private Sub PictureBox3_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox2.MouseUp
        If e.Button = MouseButtons.Left Then
            aa = False
        End If
    End Sub

    Private Sub UpdateForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.MyIcon48
        Label5.Text = NewHome.NEWVer.Text
        AddHandler Client.DownloadProgressChanged, AddressOf down
        AddHandler Client.DownloadFileCompleted, AddressOf DownOK
        Pio = 1
        Timer1.Start()
        Client.DownloadFileAsync(New Uri("https://www.dropbox.com/s/r5ax30f31r2y9r4/KuBukkit%20New.exe?dl=1"), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\KuBukkit New v" + Label5.Text + ".exe")
    End Sub

    Private Sub down(sender As Object, e As DownloadProgressChangedEventArgs)
        FlatProgressBar1.Maximum = 100
        FlatProgressBar1.Value = e.ProgressPercentage
        Label9.Text = String.Format("{3} %", CStr(e.UserState), e.BytesReceived, e.TotalBytesToReceive, e.ProgressPercentage)
    End Sub

    Private Sub DownOK(sender As Object, e As System.ComponentModel.AsyncCompletedEventArgs)
        If MsgBox("최신 버전의 다운로드가 끝났습니다." & vbCr & "최신 버전을 실행하시겠습니까?", vbYesNo, vbInformation) = vbYes Then
            Shell(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\KuBukkit New v" + Label5.Text + ".exe")
        End If
        Shell("explorer http://blog.naver.com/hon20ke")
        Shell("explorer https://www.fmforum.net/346152")
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Pio = 1 Then
            a.ForeColor = Color.Blue
            b.ForeColor = Color.White
            c.ForeColor = Color.White
        ElseIf Pio = 2 Then
            a.ForeColor = Color.White
            b.ForeColor = Color.Blue
            c.ForeColor = Color.White
        ElseIf Pio = 3 Then
            a.ForeColor = Color.White
            b.ForeColor = Color.White
            c.ForeColor = Color.Blue
        End If
        If Not Pio = 3 Then
            Pio = Pio + 1
        Else : Pio = 1
        End If
        Timer1.Start()
    End Sub
End Class