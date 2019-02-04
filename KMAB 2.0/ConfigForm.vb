Imports System.Runtime.InteropServices
Imports System.Text
Imports System.IO

Public Class ConfigForm
    Dim ptmcu, ptmnew, ptfcu, ptfnew As Point
    Dim aa As Boolean = False
    Dim GM, DF, Pl As String
    Dim Mytext As String
    Dim PlayerVa As String
    Dim Pageing As Long = 1

    Dim PagedVaule As Long

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

    Private Sub Sizer2_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox2.MouseDown
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

    Private Sub FlatStickyButton6_Click(sender As Object, e As EventArgs) Handles FlatStickyButton6.Click
        NewHome.Show()
        NewHome.Location = Me.Location
        Me.Close()
    End Sub

    Private Sub FlatButton1_Click_1(sender As Object, e As EventArgs) Handles FlatButton1.Click
        Shell("explorer C:\Kimusoft\KuBukkit\server\" + Replace(Servername.Text, " ", "_"), vbNormalFocus)
    End Sub

    Private Sub ConfigForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.MyIcon48
        Timer1.Start()
        Servername.Text = GetIniValue("Slot" & SlotNumber.Text, "servername", "C:\KimuSoft\KuBukkit\Serverinfor.ini")
        Verson.Text = GetIniValue("Slot" & SlotNumber.Text, "mcverson", "C:\KimuSoft\KuBukkit\Serverinfor.ini")
        BukkitType.Text = GetIniValue("Slot" & SlotNumber.Text, "bukkit", "C:\KimuSoft\KuBukkit\Serverinfor.ini")
        PluginV.Text = GetIniValue("Slot" & SlotNumber.Text, "pluginsvalue", "C:\KimuSoft\KuBukkit\Serverinfor.ini") + "개의 플러그인"
        ModV.Text = GetIniValue("Slot" & SlotNumber.Text, "modsvalue", "C:\KimuSoft\KuBukkit\Serverinfor.ini") + "개의 모드"
        ConfigLoad()
    End Sub

    Private Sub FlatTextBox3_TextChanged(sender As Object, e As EventArgs) Handles FlatTextBox3.TextChanged
        If FlatTextBox3.Text = "" Or Replace(FlatTextBox3.Text, " ", "") = "" Then
            TextCritical.Visible = True
            TextCritical.Text = "서버 이름을 빈 칸으로 설정할 수 없습니다."
        ElseIf Len(FlatTextBox3.Text) > 25 Then
            TextCritical.Visible = True
            TextCritical.Text = "서버 이름은 25자 이상으로 설정하실 수 없습니다."
        ElseIf Not FlatTextBox3.Text = Replace(FlatTextBox3.Text, "\", "") Or Not FlatTextBox3.Text = Replace(FlatTextBox3.Text, "?", "") Or Not FlatTextBox3.Text = Replace(FlatTextBox3.Text, "<", "") Or Not FlatTextBox3.Text = Replace(FlatTextBox3.Text, ">", "") Or Not FlatTextBox3.Text = Replace(FlatTextBox3.Text, "/", "") Or Not FlatTextBox3.Text = Replace(FlatTextBox3.Text, "|", "") Or Not FlatTextBox3.Text = Replace(FlatTextBox3.Text, ":", "") Or Not FlatTextBox3.Text = Replace(FlatTextBox3.Text, "*", "") Then
            TextCritical.Visible = True
            TextCritical.Text = "서버 이름에는 몇몇 특수문자를 사용하실 수 없습니다.."
        Else TextCritical.Visible = False
        End If
    End Sub

    Private Sub RightPlus_Tick(sender As Object, e As EventArgs) Handles RightPlus.Tick, Toright.Click
        RightPlus.Start()
        Toleft.Enabled = False
        Toright.Enabled = False
        If Panel1.Location.X > Pageing * -663 Then
            Panel1.Location = New Point(Panel1.Location.X - 17, 227)
        Else : RightPlus.Stop()
            Pageing = Pageing + 1
            InputText()
        End If
    End Sub

    Private Sub LeftMinus2_Tick(sender As Object, e As EventArgs) Handles LeftMinus.Tick, Toleft.Click
        LeftMinus.Start()
        Toleft.Enabled = False
        Toright.Enabled = False
        If Panel1.Location.X < (Pageing - 2) * -663 Then
            Panel1.Location = New Point(Panel1.Location.X + 17, 227)
        Else : LeftMinus.Stop()
            Pageing = Pageing - 1
            InputText()
        End If
    End Sub

    Private Sub InputText()
        Label20.Text = "Page " & Pageing
        Select Case Pageing
            Case 1
                Label13.Text = "기본 규칙 설정"
                Toleft.Text = "전 페이지가 없습니다."
                Toright.Text = "2 페이지 | 통신/도매인 설정"
                Toleft.Enabled = False
                Toright.Enabled = True
            Case 2
                Label13.Text = "통신 설정"
                Toleft.Text = "1 페이지 | 기본 규칙 설정"
                Toleft.Enabled = True
                Toright.Enabled = False
                Toright.Text = "다음 메뉴가 없습니다." '"3 페이지 | 맵 적용 / 추출"
                'Case 3
                '    Label13.Text = "맵 적용 / 추출"
                '    Toleft.Text = "2 페이지 | 통신/도매인 설정"
                '    Toright.Text = "마지막 페이지입니다."
                '    Toleft.Enabled = True
                '    Toright.Enabled = False
            Case Else
                Label13.Text = "UNKNOWN ROOM DATA"
                Toleft.Text = "UNKNOWN 페이지 | UNKNOWN"
                Toright.Text = "UNKNOWN 페이지 | UNKNOWN"
        End Select
    End Sub

    Private Sub Servername_Click(sender As Object, e As EventArgs) Handles FlatButton2.Click
        FlatTextBox3.Visible = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Not Me.Opacity = 1 Then
            Me.Opacity = Me.Opacity + 0.04
        Else : NewHome.Close()
            Timer1.Stop()
        End If
    End Sub

    Private Sub ConfigLoad()
        If Not System.IO.File.Exists("C:\KimuSoft\KuBukkit\server\" + Replace(Servername.Text, " ", "_") + "\server.properties") Then
            MsgBox("Server.Properties 파일이 존재하지 않습니다.")
            Exit Sub
        End If
        FlatTextBox3.Text = Servername.Text

        Mytext = File.ReadAllText("C:\KimuSoft\KuBukkit\server\" + Replace(Servername.Text, " ", "_") + "\server.properties")
        'SingleFlatButton
        If Split(Mid(Mytext, InStr(Mytext, "online-mode=") + Len("online-mode=")), "e")(0) + "e" = "True" Then
            Online.BaseColor = Color.OliveDrab
            Online.Text = "True"
        End If
        If Split(Mid(Mytext, InStr(Mytext, "hardcore=") + Len("hardcore=")), "e")(0) + "e" = "True" Then
            HardMode.BaseColor = Color.DarkRed
        End If
        If Split(Mid(Mytext, InStr(Mytext, "enable-command-block=") + Len("enable-command-block=")), "e")(0) + "e" = "False" Then
            CMDBlock.BaseColor = Color.FromArgb(50, 50, 50)
            CMDBlock.Text = "False"
        End If
        If Split(Mid(Mytext, InStr(Mytext, "allow-nether=") + Len("allow-nether=")), "e")(0) + "e" = "False" Then
            GotoNether.BaseColor = Color.FromArgb(50, 50, 50)
            GotoNether.Text = "False"
        End If
        If Split(Mid(Mytext, InStr(Mytext, "spawn-npcs=") + Len("spawn-npcs=")), "e")(0) + "e" = "False" Then
            NPCSpawn.BaseColor = Color.FromArgb(50, 50, 50)
            NPCSpawn.Text = "False"
        End If
        If Split(Mid(Mytext, InStr(Mytext, "spawn-animals=") + Len("spawn-animals=")), "e")(0) + "e" = "False" Then
            AnimalSpawn.BaseColor = Color.FromArgb(50, 50, 50)
            AnimalSpawn.Text = "False"
        End If
        If Split(Mid(Mytext, InStr(Mytext, "pvp=") + Len("pvp=")), "e")(0) + "e" = "False" Then
            PVP.BaseColor = Color.FromArgb(50, 50, 50)
            PVP.Text = "False"
        End If
        If Split(Mid(Mytext, InStr(Mytext, "spawn-monsters=") + Len("spawn-monsters=")), "e")(0) + "e" = "False" Then
            MonsterSpawn.BaseColor = Color.FromArgb(50, 50, 50)
            MonsterSpawn.Text = "False"
        End If
        If Not Split(Mid(Mytext, InStr(Mytext, "server-ip=") + Len("server-ip=")), vbCrLf)(0) = "" + vbCrLf + "" Or Split(Mid(Mytext, InStr(Mytext, "server-ip=") + Len("server-ip=")), vbCrLf)(0) = "" Then
            IPAuto.BaseColor = Color.FromArgb(50, 50, 50)
            IPHand.BaseColor = Color.OliveDrab
            IPTextBox.Visible = True
            IPTextBox.Text = Split(Mid(Mytext, InStr(Mytext, "server-ip=") + Len("server-ip=")), vbCrLf)(0)
        End If

        'MultiFlatButton
        GM0.BaseColor = Color.FromArgb(50, 50, 50)
        GM1.BaseColor = Color.FromArgb(50, 50, 50)
        GM2.BaseColor = Color.FromArgb(50, 50, 50)
        If Not Mid(Split(Mytext, "gamemode=")(1), 1, 1) = "f" And Not Mid(Split(Mytext, "gamemode=")(1), 1, 1) = "t" Then
            Select Case Mid(Split(Mytext, "gamemode=")(1), 1, 1)
                Case "0"
                    GM0.BaseColor = Color.OliveDrab
                Case "1"
                    GM1.BaseColor = Color.OliveDrab
                Case "2"
                    GM2.BaseColor = Color.OliveDrab
            End Select
        Else Select Case Mid(Split(Mytext, "gamemode=")(2), 1, 1)
                Case "0"
                    GM0.BaseColor = Color.OliveDrab
                Case "1"
                    GM1.BaseColor = Color.OliveDrab
                Case "2"
                    GM2.BaseColor = Color.OliveDrab
            End Select
        End If

        DF0.BaseColor = Color.FromArgb(50, 50, 50)
        DF1.BaseColor = Color.FromArgb(50, 50, 50)
        DF2.BaseColor = Color.FromArgb(50, 50, 50)
        DF3.BaseColor = Color.FromArgb(50, 50, 50)

        Select Case Mid(Split(Mytext, "difficulty=")(1), 1, 1)
            Case "0"
                DF0.BaseColor = Color.OliveDrab
            Case "1"
                DF1.BaseColor = Color.OliveDrab
            Case "2"
                DF2.BaseColor = Color.OliveDrab
            Case "3"
                DF3.BaseColor = Color.OliveDrab
        End Select

        Player5.BaseColor = Color.FromArgb(50, 50, 50)
        Player10.BaseColor = Color.FromArgb(50, 50, 50)
        Player20.BaseColor = Color.FromArgb(50, 50, 50)
        Player50.BaseColor = Color.FromArgb(50, 50, 50)
        Player95.BaseColor = Color.FromArgb(50, 50, 50)
        PlayerOther.BaseColor = Color.FromArgb(50, 50, 50)

            Select Case Mid(Split(Mytext, "max-players=")(1), 1, 2)
                Case "5"
                    Player5.BaseColor = Color.OliveDrab
                Case "20"
                    Player20.BaseColor = Color.OliveDrab
                Case "50"
                    Player50.BaseColor = Color.OliveDrab
                Case "100"
                    Player95.BaseColor = Color.OliveDrab
                Case Else
                    PlayerOther.BaseColor = Color.OliveDrab
            End Select
            PlayerVa = Mid(Split(Mytext, "max-players=")(1), 1, 2)
    End Sub

    Private Sub HardMode_Click(sender As Object, e As EventArgs) Handles HardMode.Click
        If HardMode.BaseColor = Color.FromArgb(50, 50, 50) Then
            HardMode.BaseColor = Color.DarkRed
        Else HardMode.BaseColor = Color.FromArgb(50, 50, 50)
        End If
    End Sub

    Private Sub FlatStickyButton1_Click(sender As Object, e As EventArgs) Handles FlatStickyButton1.Click
        If TextCritical.Visible = True Then
            MsgBox("서버 이름을 조건에 맞춰 수정 해 주세요.", vbCritical)
        Else : Dim HardCore, Difficulty, Gamemode As String
            If GM0.BaseColor = Color.OliveDrab Then
                Gamemode = "0"
            ElseIf GM1.BaseColor = Color.OliveDrab Then
                Gamemode = "1"
            Else Gamemode = "2"
            End If
            If HardMode.BaseColor = Color.DarkRed Then
                HardCore = "True"
            Else HardCore = "False"
            End If
            If DF0.BaseColor = Color.OliveDrab Then
                Difficulty = "0"
            ElseIf DF1.BaseColor = Color.OliveDrab Then
                Difficulty = "1"
            ElseIf DF2.BaseColor = Color.OliveDrab Then
                Difficulty = "2"
            Else Difficulty = "3"
            End If
            File.WriteAllText("C:\KimuSoft\KuBukkit\server\" + Replace(Servername.Text, " ", "_") + "\server.properties",
        "#KuBukkit Write" & vbCrLf &
        "online-mode=" & Online.Text & vbCrLf &
        "hardcore=" & HardCore & vbCrLf &
        "enable-command-block=" & CMDBlock.Text & vbCrLf &
        "generator-settings=" & vbCrLf &
        "allow-nether=" & GotoNether.Text & vbCrLf &
        "level-Name=world" & vbCrLf &
        "enable-query=False" & vbCrLf &
        "allow-flight=False" & vbCrLf &
        "server-port=25565" & vbCrLf &
        "level-type=DEFAULT" & vbCrLf &
        "enable-rcon=False" & vbCrLf &
        "level-seed=" & vbCrLf &
        "server-ip=" & IPTextBox.Text & vbCrLf &
        "max-build-height=256" & vbCrLf &
        "spawn-npcs=" & NPCSpawn.Text & vbCrLf &
        "white-List=False" & vbCrLf &
        "spawn-animals=" & AnimalSpawn.Text & vbCrLf &
        "snooper-Enabled=True" & vbCrLf &
        "texture-pack=" & vbCrLf &
        "pvp=" & PVP.Text & vbCrLf &
        "difficulty=" & Difficulty & vbCrLf &
        "gamemode=" & Gamemode & vbCrLf &
        "max-players=" & PlayerVa & vbCrLf &
        "spawn-monsters=" & MonsterSpawn.Text & vbCrLf &
        "generate-structures=True" & vbCrLf &
        "View-distance=10" & vbCrLf &
        "motd=A Minecraft Server")
            SetIniValue("slot" + SlotNumber.Text, "servername", FlatTextBox3.Text, "C:\KimuSoft\KuBukkit\Serverinfor.ini")
            If Not Servername.Text = FlatTextBox3.Text Then
                My.Computer.FileSystem.RenameDirectory("C:\KimuSoft\KuBukkit\server\" + Replace(Servername.Text, " ", "_"), Replace(FlatTextBox3.Text, " ", "_"))
            End If
            Servername.Text = FlatTextBox3.Text
            Servername.Enabled = False
            Servername.Enabled = True
            FlatTextBox3.Visible = False
            MsgBox("설정이 모두 저장되었습니다.", vbInformation)
        End If
    End Sub

    Private Sub BooleanButton_Click(sender As Object, e As EventArgs) Handles NPCSpawn.Click, AnimalSpawn.Click, PVP.Click, CMDBlock.Click, MonsterSpawn.Click, GotoNether.Click, Online.Click
        If TryCast(sender, FlatButton).Text = "False" Then
            TryCast(sender, FlatButton).Text = "True"
            TryCast(sender, FlatButton).BaseColor = Color.OliveDrab
        Else TryCast(sender, FlatButton).Text = "False"
            TryCast(sender, FlatButton).BaseColor = Color.FromArgb(50, 50, 50)
        End If
    End Sub

    Private Sub MultiButton1_Click(sender As Object, e As EventArgs) Handles GM0.Click, GM1.Click, GM2.Click, DF0.Click, DF1.Click, DF2.Click, DF3.Click, Player5.Click, Player10.Click, Player20.Click, Player50.Click, Player95.Click, IPAuto.Click, IPHand.Click
        Select Case Mid(TryCast(sender, FlatButton).Name, 1, 2)
            Case "GM"
                GM0.BaseColor = Color.FromArgb(50, 50, 50)
                GM1.BaseColor = Color.FromArgb(50, 50, 50)
                GM2.BaseColor = Color.FromArgb(50, 50, 50)
                GM = Mid(TryCast(sender, FlatButton).Name, 3, 1)
            Case "DF"
                DF0.BaseColor = Color.FromArgb(50, 50, 50)
                DF1.BaseColor = Color.FromArgb(50, 50, 50)
                DF2.BaseColor = Color.FromArgb(50, 50, 50)
                DF3.BaseColor = Color.FromArgb(50, 50, 50)
                GM = Mid(TryCast(sender, FlatButton).Name, 3, 1)
            Case "Pl"
                Player5.BaseColor = Color.FromArgb(50, 50, 50)
                Player10.BaseColor = Color.FromArgb(50, 50, 50)
                Player20.BaseColor = Color.FromArgb(50, 50, 50)
                Player50.BaseColor = Color.FromArgb(50, 50, 50)
                Player95.BaseColor = Color.FromArgb(50, 50, 50)
                PlayerOther.BaseColor = Color.FromArgb(50, 50, 50)
            Case "IP"
                IPHand.BaseColor = Color.FromArgb(50, 50, 50)
                IPAuto.BaseColor = Color.FromArgb(50, 50, 50)
                If TryCast(sender, FlatButton).Name = "IPHand" Then
                    IPTextBox.Visible = True
                Else IPTextBox.Text = ""
                    IPTextBox.Visible = False
                End If
        End Select

        TryCast(sender, FlatButton).BaseColor = Color.OliveDrab

        Select Case Mid(TryCast(sender, FlatButton).Name, 1, 2)
            Case "GM"
                GM0.Enabled = False
                GM1.Enabled = False
                GM2.Enabled = False
                GM0.Enabled = True
                GM1.Enabled = True
                GM2.Enabled = True
            Case "DF"
                DF0.Enabled = False
                DF1.Enabled = False
                DF2.Enabled = False
                DF3.Enabled = False
                DF0.Enabled = True
                DF1.Enabled = True
                DF2.Enabled = True
                DF3.Enabled = True
            Case "Pl"
                PlayerVa = Replace(TryCast(sender, FlatButton).Name, "Player", "")
                Player5.Enabled = False
                Player10.Enabled = False
                Player20.Enabled = False
                Player50.Enabled = False
                Player95.Enabled = False
                PlayerOther.Enabled = False
                Player5.Enabled = True
                Player10.Enabled = True
                Player20.Enabled = True
                Player50.Enabled = True
                Player95.Enabled = True
                PlayerOther.Enabled = True
            Case "IP"
                IPHand.Enabled = False
                IPHand.Enabled = True
                IPAuto.Enabled = False
                IPAuto.Enabled = True
        End Select
    End Sub
End Class