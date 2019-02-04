Imports System.Net
Imports System.Runtime.InteropServices
Imports System.Text

Public Class NewDownloadtab4
    Dim ptmcu, ptmnew, ptfcu, ptfnew As Point
    Dim aa As Boolean = False
    Dim slot As Byte
    Dim slotst As String
    Dim Library, LibraryExity As String
    Dim Turm As Integer = 1
    Dim Maximumgresses As Byte = 1
    Dim Client, ModClient, LibClient As New WebClient

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

    Private Sub NewDownloadtab4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.MyIcon48
        AddHandler Client.DownloadProgressChanged, AddressOf down
        AddHandler Client.DownloadFileCompleted, AddressOf DownOK
        System.IO.Directory.CreateDirectory("C:\KimuSoft\KuBukkit\server\" + Replace(Servername.Text, " ", "_"))
        'MsgBox(URLize.Text)
        Timer1.Start()
    End Sub

    Private Sub down(sender As Object, e As DownloadProgressChangedEventArgs)
        FlatProgressBar1.Value = e.ProgressPercentage
        Progresses.Text = e.ProgressPercentage & "%"
    End Sub


    ' 일반 코드는 여기부터입니다.

    Private Sub FlatStickyButton4_Click(sender As Object, e As EventArgs) Handles Agree.Click
        NewHome.Show()
        NewHome.Location = Me.Location
        Me.Close()
    End Sub

    Private Sub DownOK()
        My.Computer.FileSystem.WriteAllText("C:\KimuSoft\KuBukkit\server\" + Replace(Servername.Text, " ", "_") + "\eula.txt", My.Resources.eula, 1)
        My.Computer.FileSystem.WriteAllText("C:\KimuSoft\KuBukkit\server\" + Replace(Servername.Text, " ", "_") + "\server.properties", My.Resources.server, 1)
        SlotSearch()
        SetIniValue("slot" + slotst, "fill", "true", "C:\KimuSoft\KuBukkit\Serverinfor.ini")
        SetIniValue("slot" + slotst, "mcverson", BukkitVer.Text, "C:\KimuSoft\KuBukkit\Serverinfor.ini")
        SetIniValue("slot" + slotst, "servername", Servername.Text, "C:\KimuSoft\KuBukkit\Serverinfor.ini")
        SetIniValue("slot" + slotst, "bukkit", Bukkittype.Text, "C:\KimuSoft\KuBukkit\Serverinfor.ini")
        SetIniValue("slot" + slotst, "pluginsvalue", "0", "C:\KimuSoft\KuBukkit\Serverinfor.ini")
        SetIniValue("slot" + slotst, "modsvalue", "0", "C:\KimuSoft\KuBukkit\Serverinfor.ini")
        MsgBox(" 서버 생성이 완료되었습니다." + vbCr + " 홈 화면으로 돌아가기를 눌러주세요.", vbInformation)
        Dim Toggling(2) As String
        Dim A As String = My.Resources.server
        'If HardCoreToggle.BackColor = Color.OliveDrab Or HardCoreToggle.BackColor = Color.Cyan Then
        '    Toggling(0) = "true"
        'Else Toggling(0) = "false"
        'End If
        'If OnlineToggle.BackColor = Color.OliveDrab Or OnlineToggle.BackColor = Color.Cyan Then
        '    Toggling(1) = "true"
        'Else Toggling(1) = "false"
        'End If
        'If CMDToggle.BackColor = Color.OliveDrab Or CMDToggle.BackColor = Color.Cyan Then
        '    Toggling(2) = "true"
        'Else Toggling(2) = "false"
        'End If

        '        File.WriteAllText("C:\KimuSoft\KuBukkit\server\" + Replace(Servername.Text, " ", "_") + "\server.properties",
        '"op-permission-level=4" & vbCrLf &
        '"allow-nether=true" & vbCrLf &
        '"resource-pack-hash=" & vbCrLf &
        '"level-name=world" & vbCrLf &
        '"enable-query=false" & vbCrLf &
        '"allow-flight=false" & vbCrLf &
        '"announce-player-achievements=true" & vbCrLf &
        '"server-port=25565" & vbCrLf &
        '"max-world-size=29999984" & vbCrLf &
        '"level-type=DEFAULT" & vbCrLf &
        '"enable-rcon=false" & vbCrLf &
        '"level-seed=" & vbCrLf &
        '"force-gamemode=false" & vbCrLf &
        '"server-ip=" & vbCrLf &
        '"network-compression-threshold=256" & vbCrLf &
        '"max-build-height=256" & vbCrLf &
        '"spawn-npcs=true" & vbCrLf &
        '"white-list=false" & vbCrLf &
        '"spawn-animals=true" & vbCrLf &
        '"snooper-enabled=true" & vbCrLf &
        '"hardcore=" & Toggling(0) & vbCrLf &
        '"online-mode=" & Toggling(1) & vbCrLf &
        '"resource-pack=" & vbCrLf &
        '"pvp=true" & vbCrLf &
        '"difficulty=1" & vbCrLf &
        '"enable-command-block=" & Toggling(2) & vbCrLf &
        '"gamemode=0" & vbCrLf &
        '"player-idle-timeout=0" & vbCrLf &
        '"max-players=20" & vbCrLf &
        '"spawn-monsters=true" & vbCrLf &
        '"motd=A Minecraft Server" & vbCrLf)

        Agree.BaseColor = Color.OliveDrab
        Agree.Text = "서버 생성 완료, 홈으로 돌아가기"

        Agree.Enabled = True

    End Sub

    '특별 메소드는 여기부터입니다.

    Private Sub SlotSearch()
        slot = 1
        slotst = slot
        Do
            If GetIniValue("slot" + slotst, "fill", "C:\KimuSoft\KuBukkit\Serverinfor.ini") = "" Or GetIniValue("slot" + slotst, "fill", "C:\KimuSoft\KuBukkit\Serverinfor.ini") = "false" Then
                slot = 0
            Else : slot = slot + 1
                slotst = slot
            End If
        Loop Until slot = 0
    End Sub

    Private Sub Downstart()
        ' MsgBox("C:\KimuSoft\KuBukkit\bukkitspawner\" & Bukkittype.Text & (Replace(BukkitVer.Text, ",", "") & ".jar"))
        Client.DownloadFileAsync(New Uri(URLize.Text), "C:\KimuSoft\KuBukkit\bukkitspawner\" & Bukkittype.Text & Replace(BukkitVer.Text, ".", "") & ".jar")
    End Sub

    '애니메이션 코드는 여기부터입니다.

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Not Me.Opacity = 1 Then
            Me.Opacity = Me.Opacity + 0.04
        Else : NewDownloadtab5.Close()
            Timer1.Stop()
            Downstart()
        End If
    End Sub
End Class