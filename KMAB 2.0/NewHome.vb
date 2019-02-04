Imports System.Net
Imports System.Text
Imports System.Runtime.InteropServices
Imports System.IO

Public Class NewHome
    Dim ptmcu, ptmnew, ptfcu, ptfnew As Point
    Dim NewVerson As String
    Dim aa As Boolean = False
    Dim SelectSlot As ServerSlot
    Dim VerSer As New WebClient
    Dim MyVersion As String
    Dim javaPath As String = Nothing

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

    Private Sub DownOK()
        NewVerson = File.ReadAllText("C:\KimuSoft\KuBukkit\Newest Version.txt")
        NEWVer.Text = NewVerson
        If NEWVer.Text > MyVersion Then
            If MessageBox.Show("최신 버전이 발견되었습니다!" + vbCr + "업데이트 하시겠습니까?", "최신 키뮤버킷 알림", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = vbYes Then
                UpdateForm.Show()
                UpdateForm.Location = Me.Location
                Me.Close()
            Else : UpdateINFO.Text = "업데이트 하기!"
                UpdateINFO.Enabled = True
                UpdateINFO.BaseColor = Color.OliveDrab
            End If
        ElseIf NEWVer.Text < MyVersion Then
            'MsgBox("왜인지 모르겠지만 최신 버전보다 지금 버전이 높네요..." & vbCr & "뭐 제작자의 귀찮음 때문이겠죠!", vbInformation)
        End If
    End Sub

    '슬롯 인식 소스

    Private Sub NewHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MyVersion = Label7.Text
        NEWVer.Text = MyVersion
        Me.Icon = My.Resources.MyIcon48
        System.IO.Directory.CreateDirectory("C:\KimuSoft\KuBukkit\bukkitspawner")
        System.IO.Directory.CreateDirectory("C:\KimuSoft\KuBukkit\modlib")
        System.IO.Directory.CreateDirectory("C:\KimuSoft\KuBukkit\pluginslib")
        System.IO.Directory.CreateDirectory("C:\KimuSoft\KuBukkit\server")
        SetIniValue("Kubukkit", "usebukkitdataversion", Replace(MyVersion, ".", ""), "C:\KimuSoft\KuBukkit\bukkitdownloaddata.ini") '#
        If Not System.IO.File.Exists(GetIniValue("KuBukkit", "java", "C:\KimuSoft\KuBukkit\bukkitdownloaddata.ini")) Or GetIniValue("KuBukkit", "java", "C:\KimuSoft\KuBukkit\bukkitdownloaddata.ini") = "" Then
            Javacheck()
        End If

        AddHandler VerSer.DownloadFileCompleted, AddressOf DownOK
        Try
            VerSer.DownloadFileAsync(New Uri("https://www.dropbox.com/s/8prceaptfp3z3c5/updatedata.txt?dl=1"), "C:\KimuSoft\KuBukkit\Newest Version.txt")
        Catch ex As Exception
        End Try

        If Not System.IO.File.Exists("C:\KimuSoft\KuBukkit\URLdata" + Replace(MyVersion, ".", "") + ".ini") Then
            My.Computer.FileSystem.WriteAllText("C:\KimuSoft\KuBukkit\URLdata" + Replace(MyVersion, ".", "") + ".ini", My.Resources.URLdata, 1)
        End If

        If Not System.IO.File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Fonts) + "\나눔고딕.ttf") And Not System.IO.File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Fonts) + "\NanumGothic.ttf") Then
            If MessageBox.Show("이 버킷은 나눔고딕 글꼴을 기본 폰트로 권장하고 있습니다." & vbCr & "나눔고딕 설치 페이지로 이동하시겠습니까?", "나눔고딕이 설치되어 있지 않은 듯 합니다..", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = vbYes Then
                Shell("explorer http://software.naver.com/software/summary.nhn?softwareId=GWS_000322")
            End If
        End If

        Dim RealSev As Byte = 0
        For i As Integer = 1 To 1000 'System.IO.Directory.GetDirectories("C:\KimuSoft\KuBukkit\server").Length 'i는 폴더 수만큼까지 
            If RealSev >= System.IO.Directory.GetDirectories("C:\KimuSoft\KuBukkit\server").Length Then
                Exit For
            End If
            If GetIniValue("Slot" & i, "fill", "C:\KimuSoft\KuBukkit\Serverinfor.ini") = "true" Then
                Dim MakeSlot As New ServerSlot
                With MakeSlot
                    .Name = "ServerSlot" & i
                    .NameOfServer = GetIniValue("Slot" & i, "servername", "C:\KimuSoft\KuBukkit\Serverinfor.ini")
                    .PluginsValue = GetIniValue("Slot" & i, "pluginsvalue", "C:\KimuSoft\KuBukkit\Serverinfor.ini")
                    .ModsValue = GetIniValue("Slot" & i, "modsvalue", "C:\KimuSoft\KuBukkit\Serverinfor.ini")
                    .TypeOfBukkit = GetIniValue("Slot" & i, "bukkit", "C:\KimuSoft\KuBukkit\Serverinfor.ini")
                    .BukkitVersion = GetIniValue("Slot" & i, "mcverson", "C:\KimuSoft\KuBukkit\Serverinfor.ini")


                End With

                System.IO.Directory.CreateDirectory("C:\KimuSoft\KuBukkit\server\" + Replace(MakeSlot.NameOfServer, " ", "_"))
                If Not System.IO.File.Exists("C:\KimuSoft\KuBukkit\server\" + Replace(MakeSlot.NameOfServer, " ", "_") + "\server-icon.png") Then
                    Try

                        My.Resources.DefaultIcon.Save("C:\KimuSoft\KuBukkit\server\" + Replace(MakeSlot.NameOfServer, " ", "_") + "\server-icon.png")
                        MakeSlot.SerIcon = My.Resources.DefaultIcon
                        My.Resources.DefaultIcon.Dispose()
                    Catch ex As Exception
                        MakeSlot.SerIcon = My.Resources.error_icon
                    End Try
                Else
                    Try
                        Dim A As String
                        A = "C:\KimuSoft\KuBukkit\server\" + Replace(MakeSlot.NameOfServer, " ", "_") + "\server-icon.png"
                        Dim Data As Byte() = System.IO.File.ReadAllBytes(A)
                        Dim B As New System.IO.MemoryStream()
                        B.Write(Data, 0, Data.Length)
                        MakeSlot.SerIcon = Image.FromStream(B)
                    Catch ex As Exception
                        MakeSlot.SerIcon = My.Resources.error_icon
                    End Try
                End If
                If GetIniValue(MakeSlot.TypeOfBukkit, "canmod", "C:\KimuSoft\KuBukkit\URLdata" + Replace(MyVersion, ".", "") + ".ini") = "true" Then
                    MakeSlot.CanMod = True
                ElseIf GetIniValue(MakeSlot.TypeOfBukkit, "canmod", "C:\KimuSoft\KuBukkit\URLdata" + Replace(MyVersion, ".", "") + ".ini") = "false" Then
                    MakeSlot.CanMod = False
                Else
                    MsgBox(MakeSlot.TypeOfBukkit + " 버킷은 데이터 상 존재하지 않습니다." & vbCr & "모드 가능 옵션은 비활성화, 멀티폴더 옵션도 비활성화입니다.", vbCritical)
                    MakeSlot.CanMod = False
                End If
                FlowLayoutPanel1.Controls.Add(MakeSlot)
                RealSev += 1
            End If
        Next
        If GetIniValue("Kubukkit", "ram", "C:\KimuSoft\KuBukkit\bukkitdownloaddata.ini") = "" Or GetIniValue("Kubukkit", "smallram", "C:\KimuSoft\KuBukkit\bukkitdownloaddata.ini") = "" Then
            NumericUpDown1.Value = Split(My.Computer.Info.TotalPhysicalMemory / 1024 / 1024 / 2, ".")(0)
            SetIniValue("Kubukkit", "ram", NumericUpDown1.Value, "C:\KimuSoft\KuBukkit\bukkitdownloaddata.ini")
            SetIniValue("Kubukkit", "smallram", NumericUpDown1.Value, "C:\KimuSoft\KuBukkit\bukkitdownloaddata.ini")
        End If

        Dim VVV As Long = Split(My.Computer.Info.TotalPhysicalMemory / 1024 / 1024, ".")(0)
        Dim VV As Long = GetIniValue("Kubukkit", "ram", "C:\KimuSoft\KuBukkit\bukkitdownloaddata.ini")
        SetIniValue("Kubukkit", "ram", VV, "C:\KimuSoft\KuBukkit\bukkitdownloaddata.ini")
        NumericUpDown1.Maximum = VVV
        NumericUpDown1.Value = VV

        If Not Replace(javaPath, "(x86)", "") = javaPath Then
            MsgBox("64bit 컴퓨터로 32bit 자바를 사용하고 계신 듯 합니다." + vbCr + "램 할당량은 최대 1024MB로 고정되고, 서버에서 조금씩 끊김이 있을 수 있습니다.", vbInformation)
            NumericUpDown1.Maximum = 1024
            NumericUpDown1.Value = 1024
        End If

        SetIniValue("Kubukkit", "ram", NumericUpDown1.Value, "C:\KimuSoft\KuBukkit\bukkitdownloaddata.ini")
    End Sub

    Private Sub Javacheck()
        Try


            Using rk As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("SOFTWARE\JavaSoft\Java Runtime Environment\")

                Dim currentVersion As String = rk.GetValue("CurrentVersion").ToString()
                Using key As Microsoft.Win32.RegistryKey = rk.OpenSubKey(currentVersion)
                    javaPath = key.GetValue("JavaHome").ToString() + "\bin\java.exe"
                End Using
            End Using
            SetIniValue("KuBukkit", "java", javaPath, "C:\KimuSoft\KuBukkit\bukkitdownloaddata.ini")
        Catch ex As Exception
            Try
                If Directory.Exists("C:\Program Files\Java") Then

                    Dim DI As New DirectoryInfo("C:\Program Files\Java")
                    Dim d As DirectoryInfo() = DI.GetDirectories()
                    d.Reverse

                    If d.Length <> 0 Then
                        For Each DInfo As DirectoryInfo In d
                            If DInfo.Name.Contains("jre") = True Then
                                javaPath = DInfo.FullName + "\java.exe"
                                Exit For
                            End If
                        Next
                    End If
                ElseIf Directory.Exists("C:\Program Files (x86)\Java") Then
                    Dim DI As New DirectoryInfo("C:\Program Files (x86)\Java")
                    Dim d As DirectoryInfo() = DI.GetDirectories()
                    d.Reverse
                    If d.Length <> 0 Then
                        For Each Dinfo As DirectoryInfo In d
                            If Dinfo.Name.Contains("jre") = True Then
                                javaPath = Dinfo.FullName + "\java.exe"
                                Exit For
                            End If
                        Next
                    End If
                End If

            Catch ax As Exception

            End Try
        End Try

        If Not System.IO.File.Exists(javaPath) Then
            MsgBox("자바 인식에 실패하였습니다. 만약 자바가 설치되어 있다면 Java.exe의 경로를 직접 지정해 주세요.", vbCritical)
            If (JavaSearch.ShowDialog() = DialogResult.OK) Then
                If System.IO.File.Exists(JavaSearch.FileName) Then
                    SetIniValue("KuBukkit", "java", JavaSearch.FileName, "C:\KimuSoft\KuBukkit\bukkitdownloaddata.ini")
                    MsgBox(JavaSearch.FileName + "경로로 설정되었습니다.", vbInformation)
                Else : MsgBox("잘못된 경로입니다.", vbCritical)
                End If
            End If
        End If
    End Sub

    '서버 검색 관련 소스

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click, TextBox1.TextChanged, TextBox1.Click
        If Not TextBox1.Text = "" Then
            Label4.Visible = False
        Else : Label4.Visible = True
        End If
        Button1_Click(sender, e)
    End Sub

    Private Sub KeyVind(sender As Object, e As PreviewKeyDownEventArgs) Handles TextBox1.PreviewKeyDown
        If e.KeyCode = Keys.Enter Then
            Button1_Click(sender, e)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        For Each c As Control In FlowLayoutPanel1.Controls
            If Replace(TryCast(c, ServerSlot).NameOfServer, " ", "") = Replace(Replace(TryCast(c, ServerSlot).NameOfServer, " ", ""), Replace(TextBox1.Text, " ", ""), "") And Replace(TryCast(c, ServerSlot).NameOfServer, " ", "") = Replace(Replace(TryCast(c, ServerSlot).NameOfServer, " ", ""), Replace(TextBox1.Text, " ", ""), "") And Not TextBox1.Text = "" Then
                TryCast(c, ServerSlot).Visible = False
            Else : TryCast(c, ServerSlot).Visible = True
            End If
        Next
    End Sub

    Private Sub FlatButton1_Click(sender As Object, e As EventArgs) Handles ToOpen.Click
        FormMove(NewForm22)
    End Sub

    Private Sub ToNewPluginsTab_Click(sender As Object, e As EventArgs) Handles ToPlugin.Click
        FormMove(PTab)
    End Sub

    Private Sub ToModsTab_Click(sender As Object, e As EventArgs) Handles ToMod.Click
        FormMove(ModTab)
    End Sub

    Private Sub ToServerConfig_Click(sender As Object, e As EventArgs) Handles ToConfig.Click
        FormMove(ConfigForm)
    End Sub

    Private Sub FormMove(J As Form)
        For Each c As Control In FlowLayoutPanel1.Controls
            If TryCast(c, ServerSlot).Selected = True Then
                Select Case J.Name
                    Case "NewForm22"
                        NewForm22.SlotNumber.Text = Replace(TryCast(c, ServerSlot).Name, "ServerSlot", "")
                        NewForm22.Size = Me.Size
                        NewForm22.FormBorderStyle = Me.FormBorderStyle
                        If Me.FormBorderStyle = FormBorderStyle.None Then
                            NewForm22.FlatStickyButton4.BaseColor = Color.FromArgb(100, 100, 115)
                        End If
                    Case "PTab"
                        PTab.SlotNumber.Text = Replace(TryCast(c, ServerSlot).Name, "ServerSlot", "")
                    Case "ModTab"
                        ModTab.SlotNumber.Text = Replace(TryCast(c, ServerSlot).Name, "ServerSlot", "")
                    Case "ConfigForm"
                        ConfigForm.SlotNumber.Text = Replace(TryCast(c, ServerSlot).Name, "ServerSlot", "")
                End Select
                J.Show()
                J.Location = Me.Location
                LogoExit.Start()
                Exit For
            End If
        Next
    End Sub

    Private Sub FlatStickyButton6_Click(sender As Object, e As EventArgs) Handles FlatStickyButton6.Click
        Me.Close()
    End Sub

    Private Sub FlatStickyButton7_Click(sender As Object, e As EventArgs) Handles FlatStickyButton7.Click
        NewDownloadtab2.Show()
        NewDownloadtab2.Location = Me.Location
    End Sub

    '애니메이션 소스

    Private Sub Label26_Click(sender As Object, e As EventArgs) Handles FlatButton6.Click
        If PictureBox2.Visible = True Then
            PictureBox2.Visible = False
            FlatButton6.BaseColor = Color.OliveDrab
        ElseIf PictureBox2.Visible = False Then
            PictureBox2.Visible = True
            FlatButton6.BaseColor = Color.FromArgb(70, 70, 79)
        End If
        FlatButton6.Enabled = False
        FlatButton6.Enabled = True
    End Sub

    Private Sub LogoExit_Tick(sender As Object, e As EventArgs) Handles LogoExit.Tick
        PictureBox2.Location = New Point(PictureBox2.Location.X - 12, PictureBox2.Location.Y)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Not Me.Opacity = 1 Then
            Me.Opacity = Me.Opacity + 0.04
        Else : Timer1.Stop()
        End If
    End Sub

    Private Sub FlatButton5_Click(sender As Object, e As EventArgs) Handles ServerDelete.Click
        If MessageBox.Show("이 서버를 삭제하시겠습니까?", "서버 삭제", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = vbYes Then
            If MessageBox.Show("정말이죠? 다시는 복구할 수 없습니다!", "서버 삭제", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = vbYes Then
                If MessageBox.Show("저는 경고 했습니다! 진짜로 삭제할꺼죠?", "서버 삭제", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = vbYes Then
                    If MessageBox.Show("진짜로요? 잘못 누르신 거 아니죠?", "서버 삭제", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = vbYes Then
                        Dim ANAME As Byte = 0
                        For Each c As Control In FlowLayoutPanel1.Controls
                            If TryCast(c, ServerSlot).Selected = True Then
                                c.Visible = False
                                TryCast(c, ServerSlot).SerIcon.Dispose()
                                ANAME = Mid(c.Name, 11, 3)
                                Exit For
                            End If
                        Next
                        Shell("cmd /k rd /s /q C:\KimuSoft\KuBukkit\server\" + Replace(GetIniValue("Slot" & ANAME.ToString, "servername", "C:\KimuSoft\KuBukkit\Serverinfor.ini"), " ", "_"), vbHide)
                        SetIniValue("Slot" & ANAME.ToString, "fill", "false", "C:\KimuSoft\KuBukkit\Serverinfor.ini")
                        SetIniValue("Slot" & ANAME.ToString, "pluginsvalue", "0", "C:\KimuSoft\KuBukkit\Serverinfor.ini")
                        SetIniValue("Slot" & ANAME.ToString, "modsvalue", "0", "C:\KimuSoft\KuBukkit\Serverinfor.ini")
                        MsgBox("' " + GetIniValue("Slot" & ANAME.ToString, "servername", "C:\KimuSoft\KuBukkit\Serverinfor.ini") + " ' 서버 삭제가 완료되었습니다.")
                        DownTimer.Start()
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub MyRAM_Click(sender As Object, e As EventArgs) Handles MyRAM.Click
        NumericUpDown1.Value = Split(My.Computer.Info.TotalPhysicalMemory / 1024 / 1024 / 2, ".")(0)
        SetIniValue("Kubukkit", "ram", NumericUpDown1.Value, "C:\KimuSoft\KuBukkit\bukkitdownloaddata.ini")
    End Sub

    Private Sub FlatButton2_Click(sender As Object, e As EventArgs) Handles FlatButton2.Click
        Javacheck()
        MsgBox("새로 인식된 자바의 경로는 ' " + javaPath + " '" + "입니다.", vbInformation)
    End Sub

    Private Sub FlatButton1_Click_1(sender As Object, e As EventArgs)
        NewLauncherTab.Show()
        NewLauncherTab.Location = Me.Location
    End Sub

    Private Sub FlatButton9_Click(sender As Object, e As EventArgs) Handles NEWVer.Click, FlatButton4.Click
        MsgBox("최신 버전 정보를 불러옵니다...", vbInformation)
        NewVerson = VerSer.DownloadString("https://www.dropbox.com/s/8prceaptfp3z3c5/updatedata.txt?dl=1")
        NEWVer.Text = NewVerson
        If NEWVer.Text > MyVersion Then
            If MessageBox.Show("최신 버전이 발견되었습니다!" + vbCr + "업데이트 하시겠습니까?", "최신 키뮤버킷 알림", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = vbYes Then
                UpdateForm.Show()
                UpdateForm.Location = Me.Location
                Me.Close()
            Else : UpdateINFO.Text = "업데이트 하기!"
                UpdateINFO.Enabled = True
                UpdateINFO.BaseColor = Color.OliveDrab
                UpdateINFO.Enabled = False
                UpdateINFO.Enabled = True
            End If
        End If
        NEWVer.Enabled = True
        NEWVer.Enabled = False
        MsgBox("최신 버전 정보를 불러왔습니다!", vbInformation)
    End Sub

    Private Sub FlatButton11_Click(sender As Object, e As EventArgs) Handles FlatButton11.Click
        Shell("explorer http://blog.naver.com/hon20ke")
    End Sub

    Private Sub FlatButton12_Click(sender As Object, e As EventArgs)
        Shell("explorer http://cafe.naver.com/kcsgamer")
    End Sub

    Private Sub FlatButton3_Click(sender As Object, e As EventArgs) Handles FlatButton3.Click
        Shell("explorer C:\KimuSoft\KuBukkit", vbNormalFocus)
    End Sub

    Private Sub UpdateINFO_Click(sender As Object, e As EventArgs) Handles UpdateINFO.Click
        UpdateForm.Show()
        UpdateForm.Location = Me.Location
        Me.Close()
    End Sub

    Private Sub FlatButton1_Click_2(sender As Object, e As EventArgs) Handles FlatButton1.Click
        If Me.FormBorderStyle = FormBorderStyle.None Then
            Me.FormBorderStyle = FormBorderStyle.Sizable
            FlatButton1.BaseColor = Color.OliveDrab
        Else : Me.FormBorderStyle = FormBorderStyle.None
            FlatButton1.BaseColor = Color.FromArgb(50, 50, 59)
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        NewLauncherTab.Show()
        NewLauncherTab.Location = Me.Location
        Me.Close()
    End Sub

    Private Sub FlatButton5_Click_1(sender As Object, e As EventArgs) Handles FlatButton5.Click
        SetIniValue("Kubukkit", "ram", NumericUpDown1.Value, "C:\KimuSoft\KuBukkit\bukkitdownloaddata.ini")
        MsgBox("램 설정이 적용되었습니다.", vbInformation)
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub VersionLabel_Click(sender As Object, e As EventArgs) Handles VersionLabel.Click

    End Sub

    '창 이동 소스

    Private Sub picturebox3_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox2.MouseDown, Me.MouseDown
        If e.Button = MouseButtons.Left Then
            aa = True
            ptmcu = Control.MousePosition
            ptfcu = Me.Location
        End If
    End Sub

    Private Sub PictureBox3_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox2.MouseMove, Me.MouseMove
        If aa = True Then
            ptmnew = Control.MousePosition
            ptfnew.X = ptmnew.X - ptmcu.X + ptfcu.X
            ptfnew.Y = ptmnew.Y - ptmcu.Y + ptfcu.Y
            Me.Location = ptfnew
            ptfcu = ptfnew
            ptmcu = ptmnew
        End If
    End Sub

    Private Sub PictureBox3_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox2.MouseUp, Me.MouseUp

        If e.Button = MouseButtons.Left Then
            aa = False
        End If
    End Sub
End Class