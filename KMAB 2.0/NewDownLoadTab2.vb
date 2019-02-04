Imports System.Runtime.InteropServices
Imports System.Text

Public Class NewDownloadtab2
    Dim ptmcu, ptmnew, ptfcu, ptfnew As Point
    Dim aa As Boolean = False
    Dim Turm As Integer = 1

    <DllImport("KERNEL32.DLL")>
    Private Shared Function GetPrivateProfileString(section As [String], key As [String], def As [String], retVal As StringBuilder, size As Integer, filePath As [String]) As Integer
    End Function

    <DllImport("KERNEL32.DLL")>
    Private Shared Function WritePrivateProfileString(section As [String], key As [String], val As [String], filePath As [String]) As Long
    End Function

    Public Function GetIniValue(Section As [String], Key As [String], iniPath As [String]) As [String]
        Dim temp As New StringBuilder(255)
        Dim i As Integer = GetPrivateProfileString(Section, Key, "", temp, 255, iniPath)
        Return temp.ToString()
    End Function

    Public Sub SetIniValue(Section As [String], Key As [String], Value As [String], iniPath As [String])
        WritePrivateProfileString(Section, Key, Value, iniPath)
    End Sub

    Private Sub picturebox5_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox2.MouseDown
        If e.Button = MouseButtons.Left Then
            aa = True
            ptmcu = Control.MousePosition
            ptfcu = Me.Location
        End If
    End Sub

    Private Sub PictureBox5_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox2.MouseMove
        If aa = True Then
            ptmnew = Control.MousePosition
            ptfnew.X = ptmnew.X - ptmcu.X + ptfcu.X
            ptfnew.Y = ptmnew.Y - ptmcu.Y + ptfcu.Y
            Me.Location = ptfnew
            ptfcu = ptfnew
            ptmcu = ptmnew
        End If
    End Sub

    Private Sub PictureBox5_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox2.MouseUp
        If e.Button = MouseButtons.Left Then
            aa = False
        End If
    End Sub


    ' 일반 코드는 여기부터입니다.

    Private Sub Downio()
        Label14.Text = "설정 중..."
        Label14.ForeColor = Color.Gray
        PictureBox1.BackColor = Color.FromArgb(69, 70, 70)
        CreateServer.Enabled = False
        ColorMation.Stop()
        ColorDownMation.Start()
        Agree.Text = "설정 중..."
        Agree.BaseColor = Color.FromArgb(50, 50, 50)
        Agree.Enabled = False
    End Sub

    Private Sub CollectData(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text = "" Then
            NewInfo.Text = ""
            Downio()
        ElseIf Len(TextBox1.Text) > 25 Then
            NewInfo.Text = "서버 이름은 25자 이내로 적어주시기 바랍니다!"
            Downio()
        ElseIf Replace(TextBox1.Text, " ", "") = "" Then
            NewInfo.Text = "서버 이름은 띄어쓰기만으로 이루어질 수 없습니다."
            Downio()
        ElseIf Not TextBox1.Text = Replace(TextBox1.Text, "\", "") Or Not TextBox1.Text = Replace(TextBox1.Text, "?", "") Or Not TextBox1.Text = Replace(TextBox1.Text, "<", "") Or Not TextBox1.Text = Replace(TextBox1.Text, ">", "") Or Not TextBox1.Text = Replace(TextBox1.Text, "/", "") Or Not TextBox1.Text = Replace(TextBox1.Text, "|", "") Or Not TextBox1.Text = Replace(TextBox1.Text, ":", "") Or Not TextBox1.Text = Replace(TextBox1.Text, "*", "") Then
            NewInfo.Text = "서버 이름에는 특수 문자를 사용하실 수 없습니다."
            Downio()
        ElseIf System.IO.Directory.Exists("C:\KimuSoft\KuBukkit\server\" + Replace(TextBox1.Text, " ", "_")) Then
            NewInfo.Text = "이미 같은 이름인 서버가 존재합니다."
            Downio()
        ElseIf Not EulaToggle.BackColor = Color.OliveDrab Then
            NewInfo.Text = "EULA에 동의해주세요."
            Downio()
        Else
            If Not PictureBox1.BackColor = Color.FromArgb(107, 142, 35) Then
                Step1Animation.Start()
            End If
            NewInfo.Text = ""
            ColorDownMation.Stop()
            ColorMation.Start()
            CreateServer.Enabled = True
            Agree.Text = "다음"
            Agree.BaseColor = Color.OliveDrab
            Agree.Enabled = True
        End If
    End Sub

    Private Sub FlatStickyButton4_Click(sender As Object, e As EventArgs) Handles NonAgge.Click
        NewHome.Show()
        NewHome.Location = Me.Location
        Me.Close()
    End Sub

    Private Sub NewDownloadtab_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Size = New Size(660, 480)
        Me.Icon = My.Resources.MyIcon48
        Timer1.Start()
        If System.IO.Directory.Exists("C:\KimuSoft\KuBukkit\server\새로운_서버") Then
            For i = 2 To 256
                If Not System.IO.Directory.Exists("C:\KimuSoft\KuBukkit\server\새로운_서버_" & i.ToString) Then
                    TextBox1.Text = "새로운 서버 " & i.ToString
                    Exit For
                End If
            Next
        End If
        CollectData(sender, e)
    End Sub

    '특별 메소드는 여기부터입니다.


    Private Sub FlatReload(ReloadFlat As FlatButton, ReloadFlatSt As FlatStickyButton)
        ReloadFlat.Enabled = False
        ReloadFlat.Enabled = True
        ReloadFlatSt.Enabled = False
        ReloadFlatSt.Enabled = True
    End Sub

    Private Sub Agree_Click(sender As Object, e As EventArgs) Handles Agree.Click
        NewDownloadtab5.servername.Text = TextBox1.Text
        Step1Timer.Start()
    End Sub

    Private Sub Step1Timer_Tick(sender As Object, e As EventArgs) Handles Step1Timer.Tick
        If Panel1.Location.X > -700 Then
            Panel1.Location = New Point(Panel1.Location.X - Turm * 1.1 ^ Turm - 1, Panel1.Location.Y)
            Turm += 1
        Else
            NewDownloadtab5.Show()
            NewDownloadtab5.Location = Me.Location
        End If
    End Sub

    '애니메이션 코드는 여기부터입니다.

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Not Me.Opacity = 1 Then
            Me.Opacity = Me.Opacity + 0.04
        Else : NewHome.Close()
            Timer1.Stop()
        End If
    End Sub

    Private Sub FlatButton1_Click(sender As Object, e As EventArgs) Handles FlatButton1.Click
        MsgBox("EULA 동의 옵션은 끄실 수 없습니다.", vbCritical)
    End Sub

    Private Sub FlatButton2_Click(sender As Object, e As EventArgs) Handles FlatButton2.Click
        '여기여기
        If MessageBox.Show("서버 리스트 URL 데이터를 초기화하시겠습니까?" + vbCr + "사용자가 추가한 버킷 URL 데이터가 초기화될 수 있습니다.", "사용자 데이터 초기화", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = vbYes Then
            System.IO.File.Delete("C:\KimuSoft\KuBukkit\URLdata" + Replace(GetIniValue("Kubukkit", "usebukkitdataversion", "C:\KimuSoft\KuBukkit\bukkitdownloaddata.ini"), ".", "") + ".ini")
            My.Computer.FileSystem.WriteAllText("C:\KimuSoft\KuBukkit\URLdata" + Replace(GetIniValue("Kubukkit", "usebukkitdataversion", "C:\KimuSoft\KuBukkit\bukkitdownloaddata.ini"), ".", "") + ".ini", My.Resources.URLdata, 1)
            MsgBox("서버 사용자 추가 URL 데이터 초기화가 완료되었습니다.", vbInformation)
        End If
    End Sub

    Private Sub Step1Animation_Tick(sender As Object, e As EventArgs) Handles Step1Animation.Tick
        If Not PictureBox1.BackColor = Color.FromArgb(107, 142, 35) Then
            If PictureBox1.BackColor.R < 107 Then
                PictureBox1.BackColor = Color.FromArgb(PictureBox1.BackColor.R + 2, PictureBox1.BackColor.G, PictureBox1.BackColor.B)
            End If
            If PictureBox1.BackColor.G < 142 Then
                PictureBox1.BackColor = Color.FromArgb(PictureBox1.BackColor.R, PictureBox1.BackColor.G + 4, PictureBox1.BackColor.B)
            End If
            If PictureBox1.BackColor.B > 35 Then
                PictureBox1.BackColor = Color.FromArgb(PictureBox1.BackColor.R, PictureBox1.BackColor.G, PictureBox1.BackColor.B - 1)
            End If
        Else : Step1Animation.Stop()
        End If
    End Sub

    Private Sub ColorMation_Tick(sender As Object, e As EventArgs) Handles ColorMation.Tick
        If Not CreateServer.BaseColor = Color.FromArgb(70, 70, 70) Or CreateServer.BaseColor.R < 70 Then
            CreateServer.BaseColor = Color.FromArgb(CreateServer.BaseColor.R + 5, CreateServer.BaseColor.G + 5, CreateServer.BaseColor.B + 5)
        End If
        If Not CreateServer.TextColor = Color.FromArgb(240, 240, 240) Then
            CreateServer.TextColor = Color.FromArgb(CreateServer.TextColor.R + 8, CreateServer.TextColor.G + 8, CreateServer.TextColor.B + 8)
        Else : ColorMation.Stop()
        End If
        FlatReload(MC1_0_0, CreateServer)
    End Sub

    Private Sub ColorDownMation_Tick(sender As Object, e As EventArgs) Handles ColorDownMation.Tick
        If Not CreateServer.BaseColor = Color.FromArgb(40, 40, 40) Or CreateServer.BaseColor.R > 40 Then
            CreateServer.BaseColor = Color.FromArgb(CreateServer.BaseColor.R - 5, CreateServer.BaseColor.G - 5, CreateServer.BaseColor.B - 5)
        End If
        If Not CreateServer.TextColor = Color.FromArgb(40, 40, 40) Then
            CreateServer.TextColor = Color.FromArgb(CreateServer.TextColor.R - 8, CreateServer.TextColor.G - 8, CreateServer.TextColor.B - 8)
        Else : Step1Animation.Stop()
        End If
        FlatReload(MC1_0_0, CreateServer)
        CreateServer.Enabled = False
    End Sub
End Class