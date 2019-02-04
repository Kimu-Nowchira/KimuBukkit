Imports System.Runtime.InteropServices
Imports System.Text

Public Class NewForm22
    Dim ptmcu, ptmnew, ptfcu, ptfnew As Point
    Dim aa As Boolean = False
    Dim Java As String
    Dim versonname As String
    Dim IsEnable As Boolean
    Dim Data As String
    Dim ServerError As Boolean = False
    Dim HowError As Long = 0

    <DllImport("KERNEL32.DLL")>
    Private Shared Function GetPrivateProfileString(section As [String], key As [String], def As [String], retVal As StringBuilder, size As Integer, filePath As [String]) As Integer
    End Function
    ' SetIniValue를 위해
    <DllImport("KERNEL32.DLL")>
    Private Shared Function WritePrivateProfileString(section As [String], key As [String], val As [String], filePath As [String]) As Long
    End Function

    Public Function GetIniValue(Section As [String], Key As [String], iniPath As [String]) As [String]
        Dim temp As New StringBuilder(255)
        Dim i As Integer = GetPrivateProfileString(Section, Key, "", temp, 255, iniPath)
        Return temp.ToString()
    End Function
    ' INI 값 설정

    Public Sub SetIniValue(Section As [String], Key As [String], Value As [String], iniPath As [String])
        WritePrivateProfileString(Section, Key, Value, iniPath)
    End Sub

    Private Sub picturebox5_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown, servername.MouseDown
        If e.Button = MouseButtons.Left Then
            aa = True
            ptmcu = Control.MousePosition
            ptfcu = Me.Location
        End If
    End Sub
    Private Sub PictureBox5_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove, servername.MouseMove
        If aa = True Then
            ptmnew = Control.MousePosition
            ptfnew.X = ptmnew.X - ptmcu.X + ptfcu.X
            ptfnew.Y = ptmnew.Y - ptmcu.Y + ptfcu.Y
            Me.Location = ptfnew
            ptfcu = ptfnew
            ptmcu = ptmnew
        End If
    End Sub
    Private Sub PictureBox5_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp, servername.MouseUp
        If e.Button = MouseButtons.Left Then
            aa = False
        End If
    End Sub

    Dim start As New Process
    Public Event ErrorDataReceived As DataReceivedEventHandler
    Public Event OutputDataReceived As DataReceivedEventHandler

    Private Sub Textbox1_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles TextBox1.PreviewKeyDown
        If e.KeyCode = Keys.Enter Then
            start.StandardInput.WriteLine(TextBox1.Text)
            TextBox1.Clear()
        End If
    End Sub

    Private Sub error_output(ByVal sendingProcess As Object, ByVal e As DataReceivedEventArgs)
        If IsEnable = True Then
            Data = e.Data
            CheckForIllegalCrossThreadCalls = False
            Try
                RichTextBox1.AppendText((Environment.NewLine & e.Data.ToString))
            Catch ex As Exception
                RichTextBox1.AppendText((Environment.NewLine & "[ KuBukkit New : ERROR ]: 뭔가 약간의 오류가 생겼지만 무시하겠습니다."))
            End Try
            If Not e.Data = Replace(e.Data, "! For help, type ""help"" or ""?""", "") Then 'Mid(e.Data, 10, 11) = "[정보] Done (" Or Mid(e.Data, 10, 13) = "[INFO] Done (" Or Mid(e.Data, 11, 13) = "INFO]: Done (" Then
                Label14.ForeColor = Color.OliveDrab
                Label14.Text = "서버 열림"
                RichTextBox1.AppendText((Environment.NewLine & "[ KuBukkit New : INFO ]: 서버가 열렸습니다! 즐거운 마인크래프트 하세요!"))
                ScreenColor("[ KuBukkit New : INFO ]: 서버가 열렸습니다! 즐거운 마인크래프트 하세요!", Color.WhiteSmoke, True)
            ElseIf Not e.Data = Replace(e.Data, " WARN]: **** FAILED TO BIND TO PORT!", "") Then
                ServerError = True
                PictureBox2.BackColor = Color.DarkRed
                RichTextBox1.Clear()
                start.StandardInput.WriteLine("Stop")
                RichTextBox1.AppendText((Environment.NewLine & "[ KuBukkit New : ERROR ]: 포트 오류가 발생했습니다! 서버가 자동으로 종료됩니다." & vbCr &
                                        "[ KuBukkit New : ERROR ] 1. 이 서버에 서버 IP 설정을 했었다면 자동 인식으로 맞춰 주세요." & vbCr &
                                        "[ KuBukkit New : ERROR ] 2. 이 서버에 서버 IP 설정을 안 했었다면 서버 IP에 하마치 아이피나 도매인을 입력해주세요." & vbCr &
                                        "[ KuBukkit New : ERROR ] 3. 위에 대처를 모두 해도 계속 오류가 뜬다면 작업관리자에서 자바 프로세스를 종료 해 보세요.."))
                ScreenColor("[ KuBukkit New : ERROR ]:", Color.Red, True)
            End If
        End If

        CheckForIllegalCrossThreadCalls = False
        Try
            If Data.Contains("UUID of player ") Then
                Dim PlayerName As String = Split(Mid(Data, InStr(Data, "UUID of player ") + Len("UUID of player ")), " is")(0)
                'ListBox1.Items.Add(PlayerName)
                ListView1.Items.Add(PlayerName)
                Dim Head As New Net.WebClient
                ImageList1.Images.Add(Image.FromStream(New IO.MemoryStream(Head.DownloadData("http://mc-heads.net/avatar/" & PlayerName))))
                ListView1.Items.Item(ListView1.Items.Count - 1).ImageIndex = ImageList1.Images.Count - 1
            ElseIf Data.Contains(" left the game") Then
                For i = 0 To ListView1.Items.Count - 1
                    If Data.Contains(ListView1.Items.Item(i).Text) Then
                        ListView1.Items.RemoveAt(i)
                        Exit For
                    End If
                Next i
            End If
        Catch ex As Exception
            Try
                RichTextBox1.AppendText(vbCr & "키뮤버킷 ERROR")
            Catch ex3 As Exception

            End Try
        End Try
    End Sub

    Private Sub Textbox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.Click, TextBox1.TextChanged
        If TextBox1.Text = "" Then
            Label3.Visible = True
        Else Label3.Visible = False
        End If
        If Mid(TextBox1.Text, 1, 1) = "/" Then
            Label4.Visible = True
        Else : Label4.Visible = False
        End If
    End Sub

    Private Sub FlatStickyButton1_Click(sender As Object, e As EventArgs) Handles FlatStickyButton1.Click
        NewCMDForm.Show()
        NewCMDForm.Location = Me.Location
        Me.Hide()
    End Sub

    Private Sub FlatButton1_Click_1(sender As Object, e As EventArgs) Handles FlatButton1.Click
        If Not System.IO.File.Exists("C:\KimuSoft\KuBukkit\bukkitspawner\" + versonname) Then
            MsgBox("해당 버킷 버전의 서버 파일이 존재하지 않습니다.", vbCritical)
            Exit Sub
        End If
        If System.IO.File.Exists(Java) Then
            FlatButton1.Visible = False
            FlatStickyButton7.Visible = True
            RichTextBox1.Enabled = True
            PictureBox2.BackColor = Color.FromArgb(69, 70, 70)
            ColorMation.Start()
            Label14.Text = "열리는 중..."
            Label14.ForeColor = Color.Gray
            FlatButton1.Text = "서버 열기"
            FlatButton1.BaseColor = Color.FromArgb(64, 64, 64)
            Panel3.Visible = True
            Try
                Server_Start()
            Catch ex As InvalidOperationException
                start.Dispose()
                start = New Process
                Server_Start()
            End Try
        Else MsgBox(("KuBukkit Error #0001" + vbCr + "자바 설정이 잘못되었습니다." + vbCr + Java), vbCritical)
        End If
    End Sub

    Private Sub FlatStickyButton6_Click(sender As Object, e As EventArgs) Handles FlatStickyButton6.Click
        NewHome.Show()
        NewHome.Location = Me.Location
        Me.Close()
    End Sub

    Private Sub Server_Start()
        RichTextBox1.Clear()
        FlatStickyButton6.Enabled = False
        IsEnable = True
        AddHandler start.Exited, AddressOf ExitProcess ' 얘가 조종
        With start
            With .StartInfo
                .FileName = "" + Java + ""
                .Arguments = "-Djline.terminal=jline.UnsupportedTerminal -Xmx" + Replace(RamValue.Text, "MB", "") + "M -Xms" & Replace(SmallVer.Text, "MB", "") & "M -jar C:\KimuSoft\KuBukkit\bukkitspawner\" + versonname
                .CreateNoWindow = True
                .UseShellExecute = False
                .RedirectStandardError = True
                .RedirectStandardInput = True
                .RedirectStandardOutput = True
                .WorkingDirectory = "C:\KimuSoft\KuBukkit\server\" + Replace(servername.Text, " ", "_")
                start.EnableRaisingEvents = True
            End With
            AddHandler .OutputDataReceived, New DataReceivedEventHandler(AddressOf error_output)
            AddHandler .ErrorDataReceived, New DataReceivedEventHandler(AddressOf error_output)
            .Start()
            .BeginErrorReadLine()
            .BeginOutputReadLine()
        End With
    End Sub

    Private Sub ExitProcess()
        ListView1.Clear()
        FlatStickyButton7.Visible = False
        IsEnable = False
        FlatStickyButton6.Enabled = True
        FlatButton1.Show()
        Panel3.Visible = False
        FlatButton1.Visible = True
        Label4.Visible = False
        start.Dispose()
        If Label14.Text = "열리는 중..." Then
            Panel2.Show()
            ColorMation.Stop()
            PictureBox2.BackColor = Color.DarkRed
            Label14.ForeColor = Color.Red
            Label14.Text = "서버 오류"
            FlatButton1.Text = "서버 다시 열기"
            FlatButton1.BaseColor = Color.DarkRed
            FlatButton1.Enabled = False
            FlatButton1.Enabled = True
            HowError += 1
            RichTextBox1.AppendText((Environment.NewLine & "[ KuBukkit New : INFO ]: 오류 해결을 위한 추가 정보 입니다. 오류를 문의하실 때는 꼭 같이 적어 주세요."))
            RichTextBox1.AppendText((Environment.NewLine & "[ KuBukkit New : INFO ]: RAMXmx : " + RamValue.Text))
            RichTextBox1.AppendText((Environment.NewLine & "[ KuBukkit New : INFO ]: RAMXms : " + SmallVer.Text))
            RichTextBox1.AppendText((Environment.NewLine & "[ KuBukkit New : INFO ]: BukkitType : " + BukkitType.Text))
            RichTextBox1.AppendText((Environment.NewLine & "[ KuBukkit New : INFO ]: BukkitVersion : " + Verson.Text))
            RichTextBox1.AppendText((Environment.NewLine & "[ KuBukkit New : INFO ]: Java : " + GetIniValue("Kubukkit", "java", "C:\KimuSoft\KuBukkit\bukkitdownloaddata.ini")))
            MsgBox("서버가 비정상적으로 닫혔습니다. 로그 내용을 보존합니다...", vbCritical)
        Else : RichTextBox1.Clear()
            PictureBox2.BackColor = Color.FromArgb(69, 70, 70)
            Label14.ForeColor = Color.Gray
            Label14.Text = "서버 닫힘"
        End If
    End Sub

    Private Sub NewForm2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.MyIcon48
        Dim CAUJAVA(1) As Long
        CAUJAVA(0) = GetIniValue("Kubukkit", "ram", "C:\KimuSoft\KuBukkit\bukkitdownloaddata.ini")
        CAUJAVA(1) = GetIniValue("Kubukkit", "smallram", "C:\KimuSoft\KuBukkit\bukkitdownloaddata.ini")
        If CAUJAVA(0) < 0 Or CAUJAVA(1) < 0 Then
            MsgBox("메모리 할당량은 음수값일 수 없습니다." + vbCr + "기본량인 1024MB 로 자동조정합니다.", vbCritical)
            SetIniValue("Kubukkit", "smallram", "1024", "C:\KimuSoft\KuBukkit\bukkitdownloaddata.ini")
            SetIniValue("Kubukkit", "ram", "1024", "C:\KimuSoft\KuBukkit\bukkitdownloaddata.ini")
        ElseIf CAUJAVA(0) < 512 Then
            MsgBox("메모리 할당량은 최소 512MB 이상을 권장드립니다.", vbCritical)
        End If
        If CAUJAVA(0) < CAUJAVA(1) Then
            MsgBox("최소 램 할당이 최대보다 큽니다. 1024MB로 자동조정 합니다.", vbCritical)
            SetIniValue("Kubukkit", "smallram", "1024", "C:\KimuSoft\KuBukkit\bukkitdownloaddata.ini")
            SetIniValue("Kubukkit", "ram", "1024", "C:\KimuSoft\KuBukkit\bukkitdownloaddata.ini")
        End If
        CAUJAVA(0) = GetIniValue("Kubukkit", "ram", "C:\KimuSoft\KuBukkit\bukkitdownloaddata.ini")
        CAUJAVA(1) = GetIniValue("Kubukkit", "smallram", "C:\KimuSoft\KuBukkit\bukkitdownloaddata.ini")
        Timer1.Start()
        servername.Text = GetIniValue("Slot" & SlotNumber.Text, "servername", "C:\KimuSoft\KuBukkit\Serverinfor.ini")
        Verson.Text = GetIniValue("Slot" & SlotNumber.Text, "mcverson", "C:\KimuSoft\KuBukkit\Serverinfor.ini")
        BukkitType.Text = GetIniValue("Slot" & SlotNumber.Text, "bukkit", "C:\KimuSoft\KuBukkit\Serverinfor.ini")
        RamValue.Text = CAUJAVA(0).ToString & "MB"
        Java = GetIniValue("Kubukkit", "java", "C:\KimuSoft\KuBukkit\bukkitdownloaddata.ini")
        SmallVer.Text = CAUJAVA(1).ToString & "MB"
        If SmallVer.Text = "MB" Or SmallVer.Text = "0MB" Then
            SmallVer.Text = RamValue.Text
            SetIniValue("Kubukkit", "smallram", Replace(RamValue.Text, "MB", ""), "C:\KimuSoft\KuBukkit\bukkitdownloaddata.ini")
        End If
        If RamValue.Text = "MB" Then
            RamValue.Text = "1024MB"
            SetIniValue("Kubukkit", "ram", "1024", "C:\KimuSoft\KuBukkit\bukkitdownloaddata.ini")
        End If
        If Java = "" Or Not System.IO.File.Exists(Java) Then
            MsgBox(("KuBukkit Error" + vbCr + "자바 값에 대한 자바가 존재하지 않습니다. 자동으로 임시 설정값인 'Java' 로 대체됩니다." + vbCr + Java), vbCritical)
            Java = "java"
        End If
        If Not GetIniValue(BukkitType.Text, "plusdir", "C:\KimuSoft\KuBukkit\URLdata.ini") = "true" Then 'Replace(BukkitType.Text, "/Mod", "") = BukkitType.Text And Not BukkitType.Text = "KCauldron" And Not BukkitType.Text = "Sponge" Then
            versonname = BukkitType.Text + Replace(Verson.Text, ".", "") + ".jar"
        Else versonname = BukkitType.Text + Replace(Verson.Text, ".", "") + "\" + BukkitType.Text + Replace(Verson.Text, ".", "") + ".jar"
        End If
        BukkitType.Text = Replace(GetIniValue("Slot" & SlotNumber.Text, "bukkit", "C:\KimuSoft\KuBukkit\Serverinfor.ini"), "/Mod", "")
    End Sub


    Private Sub NewForm2_Close() Handles MyBase.FormClosed
        If IsEnable = True Then
            MsgBox("서버를 강제종료 하셨습니다. 나중에 안 열린다면 작업관리자에서 자바 프로세스를 끈 뒤 다시 해보세요.", vbCritical)
        End If
    End Sub

    Private Sub Step1Animation_Tick(sender As Object, e As EventArgs) Handles ColorMation.Tick
        If Not PictureBox2.BackColor = Color.FromArgb(107, 142, 35) Then
            If PictureBox2.BackColor.R < 107 Then
                PictureBox2.BackColor = Color.FromArgb(PictureBox2.BackColor.R + 2, PictureBox2.BackColor.G, PictureBox2.BackColor.B)
            End If
            If PictureBox2.BackColor.G < 142 Then
                PictureBox2.BackColor = Color.FromArgb(PictureBox2.BackColor.R, PictureBox2.BackColor.G + 4, PictureBox2.BackColor.B)
            End If
            If PictureBox2.BackColor.B > 35 Then
                PictureBox2.BackColor = Color.FromArgb(PictureBox2.BackColor.R, PictureBox2.BackColor.G, PictureBox2.BackColor.B - 1)
            End If
        Else : ColorMation.Stop()
        End If
    End Sub

    Private Sub FontOption_Click(sender As Object, e As EventArgs) Handles FontOption.Click
        FontDialog1.ShowDialog()
        RichTextBox1.Font = FontDialog1.Font
        ListView1.Font = FontDialog1.Font
    End Sub

    Private Sub FlatButton3_Click(sender As Object, e As EventArgs) Handles Flatbutton3.Click
        MenuClose.Start()
        MenuOpen.Stop()
        MsgBox(Len(RichTextBox1.Text) & "자의 텍스트를 정리했습니다.", vbInformation)
        RichTextBox1.Clear()
    End Sub

    'Private Sub FlatButton7_Click(sender As Object, e As EventArgs)
    '    SetIniValue("Kubukkit", "smallram", "1024", "C:\KimuSoft\KuBukkit\bukkitdownloaddata.ini")
    '    SetIniValue("Kubukkit", "ram", "1024", "C:\KimuSoft\KuBukkit\bukkitdownloaddata.ini")
    '    FlatButton7.Text = "램 할당을 1GB 로 설정 ( 적용됨 )"
    '    RamValue.Text = "1024MB"
    '    FlatButton7.BaseColor = Color.FromArgb(FlatButton7.BaseColor.R - 10, FlatButton7.BaseColor.G - 10, FlatButton7.BaseColor.B - 10)
    '    FlatButton7.Enabled = False
    'End Sub

    'Private Sub FlatButton5_Click(sender As Object, e As EventArgs)
    '    SetIniValue("Kubukkit", "java", "java", "C:\KimuSoft\KuBukkit\bukkitdownloaddata.ini")
    '    FlatButton5.Text = "자바를 기본 값으로 설정 ( 적용됨 )"
    '    FlatButton5.BaseColor = Color.FromArgb(FlatButton7.BaseColor.R - 10, FlatButton7.BaseColor.G - 10, FlatButton7.BaseColor.B - 10)
    '    FlatButton5.Enabled = False
    'End Sub

    'Private Sub FlatButton6_Click(sender As Object, e As EventArgs)
    '    If MessageBox.Show("이 동작은 당신의 다른 자바 프로그램을 종료 할 수도 있습니다.( 예/마인크래프트 )" + vbCr + "괜찮겠습니까?", "Hold it!", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = vbNo Then
    '        Exit Sub
    '    End If
    '    Shell("taskkill /im java.exe /f")
    '    FlatButton6.Text = "자바 프로세스를 종료하기 ( 적용됨 )"
    '    FlatButton6.BaseColor = Color.FromArgb(FlatButton7.BaseColor.R - 10, FlatButton7.BaseColor.G - 10, FlatButton7.BaseColor.B - 10)
    '    FlatButton6.Enabled = False
    'End Sub

    Private Sub FlatButton8_Click(sender As Object, e As EventArgs) Handles FlatButton8.Click
        If MessageBox.Show("강제종료를 하면 서버에 데이터가 소실될 수 있습니다." + vbCr + "서버가 멈춘 상황이 아니면 되도록 사용하지 마세요.", "Hold it!", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = vbNo Then
            Exit Sub
        End If
        start.Dispose()
        Shell("taskkill /im java.exe /f")
        ExitProcess()
        MsgBox("강제적으로 서버를 종료했습니다.", vbInformation)
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub FlatStickyButton5_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub FlatStickyButton4_Click(sender As Object, e As EventArgs) Handles FlatStickyButton4.Click
        If Me.FormBorderStyle = FormBorderStyle.Sizable Then
            Me.FormBorderStyle = FormBorderStyle.None
            FlatStickyButton4.BaseColor = Color.FromArgb(100, 100, 115)
            FlatStickyButton4.Enabled = False
            FlatStickyButton4.Enabled = True
        ElseIf Me.FormBorderStyle = FormBorderStyle.None Then
            Me.FormBorderStyle = FormBorderStyle.Sizable
            FlatStickyButton4.BaseColor = Color.OliveDrab
            FlatStickyButton4.Enabled = False
            FlatStickyButton4.Enabled = True
        End If
    End Sub

    Private Sub Flatbutton3_Click_1(sender As Object, e As EventArgs) Handles Flatbutton3.Click

    End Sub

    Private Sub FlatStickyButton7_Click(sender As Object, e As EventArgs) Handles FlatStickyButton7.Click
        If IsEnable = False Then
            MsgBox("서버가 이미 닫혀있어 서버를 닫을 수 없습니다.", vbCritical)
            Exit Sub
        End If
        start.StandardInput.WriteLine("stop")
        MenuClose.Start()
        MenuOpen.Stop()
    End Sub

    Private Sub Confignational_Button_Click(sender As Object, e As EventArgs) Handles Confignational_Button.Click
        If RichTextBox1.Visible = True Then
            RichTextBox1.Visible = False
            Confignational_Button.BaseColor = Color.OliveDrab
        ElseIf RichTextBox1.Visible = False Then
            RichTextBox1.Visible = True
            Confignational_Button.BaseColor = Color.FromArgb(70, 70, 70)
        End If
        Confignational_Button.Enabled = False
        Confignational_Button.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Not Me.Opacity = 1 Then
            Me.Opacity = Me.Opacity + 0.04
        Else : NewHome.Close()
            Timer1.Stop()
        End If
    End Sub

    'Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged
    '    If IsEnable = True Then
    '        ScreenColor("info", Color.WhiteSmoke, True)
    '        ScreenColor("warn", Color.WhiteSmoke, True)
    '        ScreenColor("error", Color.FromArgb(255, 200, 200), True)
    '        ScreenColor("정보", Color.WhiteSmoke, True)
    '        ScreenColor("경고", Color.FromArgb(255, 200, 200), True)
    '        ScreenColor("심각", Color.FromArgb(255, 140, 0), True)
    '        ScreenColor("위험", Color.FromArgb(245, 190, 190), True)
    '    End If
    'End Sub

    Private Sub ScreenColor(Type As String, TextColor As Color, Lower As Boolean)
        Try
            Dim IsLower As String
            If Lower Then
                IsLower = Data.ToLower
            Else
                IsLower = Data
            End If
            If IsLower.Contains(Type) Then
                With RichTextBox1
                    .Select(.Text.Length - Data.Length, Data.Length)
                    .SelectionColor = TextColor
                    .Select(.Text.Length, 0)
                End With
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub FlatStickyButton3_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class

