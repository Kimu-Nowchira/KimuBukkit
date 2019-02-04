Imports System.Net
Imports System.Runtime.InteropServices
Imports System.Text

Public Class NewDownloadtab3
    Dim MyProcess1 As New System.Diagnostics.Process
    Dim Process1 As New ProcessStartInfo
    Dim ptmcu, ptmnew, ptfcu, ptfnew As Point
    Dim aa As Boolean = False
    Dim Client, ModClient, LibClient As New WebClient
    Dim GreenButton As FlatStickyButton = CraftBukkit
    Dim SelectVersion As FlatButton = MC1_4_7
    Dim slot As Byte
    Dim slotst As String
    Dim Greentype As String = "Spigot"
    Dim Library, LibraryExity As String
    Dim VersonNumber, TypeNumber As Byte
    Dim BukkitInfoURL(8, 101) As String ' ( 버킷 종류, 버전넘버 )
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

    Private Sub UnCOM(A As String)
        System.IO.Directory.CreateDirectory("C:\KimuSoft\KuBukkit\bukkitspawner\" & A)
        Process1.FileName = "C:\KimuSoft\KuBukkit\7z.exe"
        Process1.Arguments = "x -y " & """" & "C:\KimuSoft\KuBukkit\KimuLib.7z""" & " -o" & """" & "C:\KimuSoft\KuBukkit\bukkitspawner\" & A & """"
        Process1.WindowStyle = ProcessWindowStyle.Hidden
        MyProcess1 = Process.Start(Process1)
        MyProcess1.WaitForExit()
        If Not System.IO.Directory.Exists("C:\KimuSoft\KuBukkit\bukkitspawner\" & A & "\libraries") Then
            MsgBox("압축 풀기 과정을 하는 도중 실패한 것 같다." & "언젠가 이 서버를 열 때 오류 날 모습을 생각하며 당신의 의지가 가득 찼다.", "UNDERTAIL")
        End If
    End Sub

    Private Sub SelectingB(sender As Object, e As EventArgs) 'Handles _
        'MC1_0_0.Click, MC1_1_0.Click, MC1_2_2.Click, MC1_2_5.Click, MC1_3_1.Click, MC1_3_2.Click, MC1_4_5.Click, MC1_4_6.Click, MC1_4_7.Click, MC1_5_2.Click, MC1_6_2.Click, MC1_6_4.Click, MC1_7_10.Click, MC1_7_2.Click, MC1_8.Click, MC1_8_3.Click, MC1_8_4.Click, MC1_8_5.Click, MC1_8_6.Click, MC1_8_7.Click, MC1_8_8.Click, MC1_8_9.Click, MC1_9.Click, MC1_9_2.Click
        AllBlack()
        TryCast(sender, FlatButton).BaseColor = Color.OliveDrab
        SelectVersion = TryCast(sender, FlatButton)
        VersionListPanel.Enabled = False
        VersionListPanel.Enabled = True
        If Greentype = "KCauldron" Or Greentype = "Sponge" Then
            Select Case TryCast(sender, FlatButton).TabIndex + 1
                Case 15 : Greentype = "Sponge"
                Case 22 : Greentype = "Sponge"
                Case Else : Greentype = "KCauldron"
            End Select
        End If
    End Sub

    Private Sub MultiButton1(sender As Object, e As EventArgs) Handles CraftBukkit.Click, Spigot.Click, MCPC.Click, Thermos.Click, Rainbow.Click, PaperSpigot.Click
        GreenButton = TryCast(sender, FlatStickyButton)
        Greentype = TryCast(sender, FlatStickyButton).Name
        CraftbukkitON.BackColor = Color.FromArgb(50, 50, 50)
        SpigotON.BackColor = Color.FromArgb(50, 50, 50)
        MCPCON.BackColor = Color.FromArgb(50, 50, 50)
        RainbowON.BackColor = Color.FromArgb(50, 50, 50)
        ThermosON.BackColor = Color.FromArgb(50, 50, 50)
        PaperSpigotON.BackColor = Color.FromArgb(50, 50, 50)
        For Each c As Control In VersionListPanel.Controls
            TryCast(c, FlatButton).Visible = False
        Next
        Select Case TryCast(sender, FlatStickyButton).Name
            Case "CraftBukkit"
                MC1_0_0.Visible = True
                MC1_1_0.Visible = True
                MC1_2_2.Visible = True
                MC1_2_5.Visible = True
                MC1_3_1.Visible = True
                MC1_3_2.Visible = True
                MC1_4_5.Visible = True
                MC1_4_6.Visible = True
                MC1_4_7.Visible = True
                MC1_5_2.Visible = True
                MC1_6_2.Visible = True
                MC1_6_4.Visible = True
                MC1_7_2.Visible = True
                MC1_7_10.Visible = True
                Greentype = "Craftbukkit" '예외
                CraftbukkitON.BackColor = Color.OliveDrab
                AllBlack()
                MC1_0_0.BaseColor = Color.OliveDrab
                SelectVersion = MC1_0_0
                VersionListPanel.Enabled = False
                VersionListPanel.Enabled = True
            Case "Spigot"
                MC1_4_7.Visible = True
                MC1_5_2.Visible = True
                MC1_6_2.Visible = True
                MC1_6_4.Visible = True
                MC1_7_2.Visible = True
                MC1_7_10.Visible = True
                MC1_8.Visible = True
                MC1_8_3.Visible = True
                MC1_8_4.Visible = True
                MC1_8_6.Visible = True
                MC1_8_7.Visible = True
                MC1_8_8.Visible = True
                MC1_8_9.Visible = True
                MC1_9.Visible = True
                MC1_9_2.Visible = True
                MC1_9_4.Visible = True
                MC1_10_0.Visible = True
                MC1_10_2.Visible = True
                MC1_11_0.Visible = True
                'MC1_10_4.Visible = True
                SpigotON.BackColor = Color.OliveDrab
                AllBlack()
                MC1_4_7.BaseColor = Color.OliveDrab
                SelectVersion = MC1_4_7
                VersionListPanel.Enabled = False
                VersionListPanel.Enabled = True
            Case "MCPC"
                MC1_2_5.Visible = True
                MC1_4_7.Visible = True
                MC1_5_2.Visible = True
                'MC1_6_2.Visible = True
                'MC1_6_4.Visible = True
                MCPCON.BackColor = Color.OliveDrab
                Greentype = "MCPC+" '예외
                AllBlack()
                MC1_2_5.BaseColor = Color.OliveDrab
                SelectVersion = MC1_2_5
                VersionListPanel.Enabled = False
                VersionListPanel.Enabled = True

            Case "PaperSpigot"
                MC1_7_10.Visible = True
                MC1_8.Visible = True
                MC1_8_3.Visible = True
                MC1_8_4.Visible = True
                MC1_8_5.Visible = True
                MC1_8_6.Visible = True
                MC1_8_7.Visible = True
                'MC1_8_8.Visible = True
                PaperSpigotON.BackColor = Color.OliveDrab
                AllBlack()
                MC1_7_10.BaseColor = Color.OliveDrab
                SelectVersion = MC1_7_10
                VersionListPanel.Enabled = False
                VersionListPanel.Enabled = True

            Case "Thermos"
                MC1_7_10F1558.Visible = True
                ThermosON.BackColor = Color.OliveDrab
                Greentype = "Thermos" '예외
                AllBlack()
                MC1_7_10F1558.BaseColor = Color.OliveDrab
                SelectVersion = MC1_7_10F1558
                VersionListPanel.Enabled = False
                VersionListPanel.Enabled = True

            Case "Rainbow"
                MC1_8_4.Visible = True
                MC1_8_5.Visible = True
                MC1_8_6.Visible = True
                MC1_8_7.Visible = True
                MC1_8_8.Visible = True
                RainbowON.BackColor = Color.OliveDrab
                AllBlack()
                MC1_8_4.BaseColor = Color.OliveDrab
                SelectVersion = MC1_8_4
                VersionListPanel.Enabled = False
                VersionListPanel.Enabled = True
        End Select
        FlatReload(MC1_0_0, CraftBukkit)
        FlatReload(MC1_0_0, Spigot)
        FlatReload(MC1_0_0, MCPC)
        FlatReload(MC1_0_0, Rainbow)
        'FlatReload(MC1_0_0, KCauldron)
        'FlatReload(MC1_0_0, Forge)
    End Sub

    Private Sub NewDownloadtab3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.MyIcon48
        SelectVersion = MC1_11_0
        'VersionListPanel.Location = New Point(VersionListPanel.Size.Width * -1, VersionListPanel.Location.Y)
        'ServerListPanel.Location = New Point(ServerListPanel.Size.Width * -1, ServerListPanel.Location.Y)
        Timer1.Start()
        For Each c As Control In VersionListPanel.Controls
            AddHandler c.Click, AddressOf SelectingB
        Next

        For i As Integer = 1 To 1000
            Dim MakeSlot As New ServerSlot
            With MakeSlot
                .Name = "ServerSlot" & i
                .NameOfServer = GetIniValue("Slot" & i, "servername", "C:\KimuSoft\KuBukkit\Serverinfor.ini")
                .PluginsValue = GetIniValue("Slot" & i, "pluginsvalue", "C:\KimuSoft\KuBukkit\Serverinfor.ini")
                .ModsValue = GetIniValue("Slot" & i, "modsvalue", "C:\KimuSoft\KuBukkit\Serverinfor.ini")
                .TypeOfBukkit = GetIniValue("Slot" & i, "bukkit", "C:\KimuSoft\KuBukkit\Serverinfor.ini")
                .BukkitVersion = GetIniValue("Slot" & i, "mcverson", "C:\KimuSoft\KuBukkit\Serverinfor.ini")
            End With
        Next
    End Sub

    Private Sub Agree_Click(sender As Object, e As EventArgs) Handles Agree.Click
        If MessageBox.Show("' " + servername.Text + " ' 서버를 만드시겠습니까?", "마인크래프트 서버를 만드시겠습니까?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = MsgBoxResult.Cancel Then
            Exit Sub
        End If
        VersonNumber = SelectVersion.TabIndex + 1

        Select Case Greentype
            Case "Craftbukkit"
                TypeNumber = 1
            Case "Spigot"
                TypeNumber = 2
            Case "MCPC+"
                TypeNumber = 3
            Case "KCauldron"
                TypeNumber = 4
            Case "Rainbow"
                TypeNumber = 5
            Case "PaperSpigot"
                TypeNumber = 6
            Case "Sponge"
                TypeNumber = 7
            Case "Thermos"
                TypeNumber = 8
        End Select
        VersonNumber = SelectVersion.TabIndex + 1

        NewDownloadtab4.Bukkittype.Text = Greentype
        NewDownloadtab4.BukkitVer.Text = SelectVersion.Text
        NewDownloadtab4.URLize.Text = BukkitInfoURL(TypeNumber, VersonNumber)

        NewDownloadtab4.Servername.Text = servername.Text
        NewDownloadtab4.Show()
        NewDownloadtab4.Location = Me.Location
    End Sub

    'Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
    '    If ServerListPanel.Location.X < 0 Then
    '        ServerListPanel.Location = New Point(ServerListPanel.Location.X + 1.1 ^ Turm, ServerListPanel.Location.Y)
    '    Else ServerListPanel.Location = New Point(0, ServerListPanel.Location.Y)
    '        Timer2.Stop()
    '        Turm = 2
    '        VersionListPanel.Location = New Point(VersionListPanel.Size.Width * -1 + 100, VersionListPanel.Location.Y)
    '        Timer3.Start()
    '    End If
    '    Turm += 1
    'End Sub

    'Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
    '    If VersionListPanel.Location.X < 185 Then
    '        VersionListPanel.Location = New Point(VersionListPanel.Location.X + 1.1 ^ Turm, VersionListPanel.Location.Y)
    '    Else Timer3.Stop()
    '        VersionListPanel.Location = New Point(185, VersionListPanel.Location.Y)
    '    End If

    '    Turm += 1
    'End Sub

    Private Sub NonAgge_Click(sender As Object, e As EventArgs) Handles NonAgge.Click
        NewHome.Show()
        NewHome.Location = Me.Location
        Me.Close()
    End Sub

    Private Sub FlatStickyButton4_Click(sender As Object, e As EventArgs)
        NewHome.Show()
        NewHome.Location = Me.Location
        Me.Close()
    End Sub

    '특별 메소드는 여기부터입니다.


    Private Sub FlatReload(ReloadFlat As FlatButton, ReloadFlatSt As FlatStickyButton)
        ReloadFlat.Enabled = False
        ReloadFlat.Enabled = True
        ReloadFlatSt.Enabled = False
        ReloadFlatSt.Enabled = True
    End Sub

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

    Private Sub AllBlack()
        For Each c As Control In VersionListPanel.Controls
            TryCast(c, FlatButton).BaseColor = Color.FromArgb(50, 50, 53)
        Next
    End Sub

    Private Sub ToggleChanged(ChangeFlat As PictureBox)
        If ChangeFlat.BackColor = Color.OliveDrab Then
            ChangeFlat.BackColor = Color.FromArgb(50, 50, 50)
        Else ChangeFlat.BackColor = Color.OliveDrab
        End If
    End Sub

    '다운로드 코드는 여기부터입니다.

    Private Sub NewDownLoad(sender As Object, e As EventArgs) Handles Me.Load

        'CraftBukkit - Code 1
        BukkitInfoURL(1, 0) = "CraftBukkit"
        BukkitInfoURL(2, 0) = "Spigot"
        BukkitInfoURL(3, 0) = "MCPC+"
        BukkitInfoURL(4, 0) = "KCauldron"
        BukkitInfoURL(5, 0) = "Rainbow"
        BukkitInfoURL(1, 1) = "https://www.dropbox.com/s/afcjw8cjeu1h2c5/craftbukkit%20-%201.0.0.jar?dl=1" '1.0.0
        BukkitInfoURL(1, 2) = "https://www.dropbox.com/s/qyjmpb4mwq6yiiq/craftbukkit%20-%201.1.0.jar?dl=1" '1.1.0
        BukkitInfoURL(1, 3) = "https://www.dropbox.com/s/k1ivxj51bfoi0x4/craftbukkit%20-%201.2.2%20R0.1.jar?dl=1" '1.2.2
        BukkitInfoURL(1, 4) = "https://www.dropbox.com/s/it0g0suow5ekwnw/craftbukkit%20-%201.2.5%20R2.0.jar?dl=1" '1.2.5
        BukkitInfoURL(1, 5) = "https://www.dropbox.com/s/urv30r9fgz5jdl0/craftbukkit%20-%201.3.1%20R2.0.jar?dl=1" '1.3.1
        BukkitInfoURL(1, 6) = "https://www.dropbox.com/s/urv30r9fgz5jdl0/craftbukkit%20-%201.3.1%20R2.0.jar?dl=1" '1.3.2
        BukkitInfoURL(1, 7) = "http://tcpr.ca/files/craftbukkit/craftbukkit-1.4.5-R1.1-SNAPSHOT.jar" '1.4.5
        BukkitInfoURL(1, 8) = "http://tcpr.ca/files/craftbukkit/craftbukkit-1.4.6-R0.1-20121220.181004-1.jar" '1.4.6
        BukkitInfoURL(1, 9) = "http://tcpr.ca/files/craftbukkit/craftbukkit-1.4.6-R0.1-20121220.181004-1.jar" '1.4.7
        BukkitInfoURL(1, 10) = "https://www.dropbox.com/s/2q0edv8udwtvaq0/craftbukkit%20-%201.5.2%20R0.3.jar?dl=1" '1.5.2
        BukkitInfoURL(1, 11) = "https://www.dropbox.com/s/x134cxl46ixas7g/craftbukkit%20-%201.6.2.jar?dl=1" '1.6.2
        BukkitInfoURL(1, 12) = "https://www.dropbox.com/s/zoyesavuydng7c5/craftbukkit%20-%201.6.4.jar?dl=1" '1.6.4
        BukkitInfoURL(1, 13) = "http://tcpr.ca/files/craftbukkit/craftbukkit-1.7.2-R0.4-20140216.012104-3.jar" '1.7.2
        BukkitInfoURL(1, 14) = "http://tcpr.ca/files/craftbukkit/craftbukkit-1.7.10-R0.1-20140808.005431-8.jar" '1.7.10

        'Spigot - Code 2
        BukkitInfoURL(2, 9) = "http://tcpr.ca/files/spigot/spigot-1.4.7-R1.1-SNAPSHOT.jar" '1.4.7
        BukkitInfoURL(2, 10) = "http://tcpr.ca/files/spigot/spigot-1.5.2-R1.1-SNAPSHOT.jar" '1.5.2
        BukkitInfoURL(2, 11) = "http://tcpr.ca/files/spigot/spigot-1.6.2-R1.1-SNAPSHOT.jar" '1.6.2
        BukkitInfoURL(2, 12) = "http://tcpr.ca/files/spigot/spigot-1.6.4-R2.1-SNAPSHOT.jar" '1.6.4
        BukkitInfoURL(2, 13) = "http://tcpr.ca/files/spigot/spigot-1.7.2-R0.4-SNAPSHOT-1339.jar" '1.7.2
        BukkitInfoURL(2, 14) = "http://tcpr.ca/files/spigot/spigot-1.7.10-SNAPSHOT-b1657.jar" '1.7.10
        BukkitInfoURL(2, 15) = "http://tcpr.ca/files/spigot/spigot-1.8-R0.1-SNAPSHOT-latest.jar" '1.8
        BukkitInfoURL(2, 16) = "http://tcpr.ca/files/spigot/spigot-1.8.3-R0.1-SNAPSHOT-latest.jar" '1.8.3
        BukkitInfoURL(2, 17) = "http://tcpr.ca/files/spigot/spigot-api-1.8.4-R0.1-SNAPSHOT-latest-shaded.jar" '1.8.4
        BukkitInfoURL(2, 19) = "http://tcpr.ca/files/spigot/spigot-1.8.6-R0.1-SNAPSHOT-latest.jar" '1.8.6
        BukkitInfoURL(2, 20) = "http://tcpr.ca/files/spigot/spigot-1.8.7-R0.1-SNAPSHOT-latest.jar" '1.8.7
        BukkitInfoURL(2, 21) = "http://tcpr.ca/files/spigot/spigot-1.8.8-R0.1-SNAPSHOT-latest.jar" '1.8.8
        BukkitInfoURL(2, 22) = "https://www.dropbox.com/s/irkuy7vf7fqs3ne/Spigot%20-%201.8.9.jar?dl=1" '1.8.9
        BukkitInfoURL(2, 23) = "https://www.dropbox.com/s/57fy6zhswuaxmqc/SG19.jar?dl=1" '1.9
        BukkitInfoURL(2, 24) = "https://www.dropbox.com/s/9htchaaco1urgju/SG192.jar?dl=1" '1.9.2
        BukkitInfoURL(2, 25) = "http://tcpr.ca/files/spigot/spigot-api-1.9.4-R0.1-SNAPSHOT-latest-shaded.jar" ' 1.9.4
        BukkitInfoURL(2, 26) = "http://tcpr.ca/files/spigot/spigot-1.10-R0.1-SNAPSHOT-latest.jar" ' 1.10.0
        BukkitInfoURL(2, 27) = "http://tcpr.ca/files/spigot/spigot-1.10.2-R0.1-SNAPSHOT-latest.jar" ' 1.10.2
        BukkitInfoURL(2, 28) = "http://tcpr.ca/files/spigot/spigot-1.11-R0.1-SNAPSHOT-latest.jar" '1.11.0

        'MCPC+ - Code 3
        BukkitInfoURL(3, 4) = "http://tcpr.ca/files/mcpc/craftbukkitplusplus-1.2.5-R4.1-MCPC-SNAPSHOT.jar"
        BukkitInfoURL(3, 9) = "http://tcpr.ca/files/mcpc/mcpc-plus-1.4.7-R1.1-SNAPSHOT-f534-L0-authfix1.jar"
        BukkitInfoURL(3, 10) = "http://tcpr.ca/files/mcpc/mcpc-plus-1.5.2-R1.1-forge738-B653.jar"
        BukkitInfoURL(3, 11) = "http://tcpr.ca/files/mcpc/mcpc-plus-1.6.2-R0.1-forge804-B39.jar"
        BukkitInfoURL(3, 12) = "http://tcpr.ca/files/mcpc/mcpc-plus-1.6.4-R0.1-forge933-B101.jar"


        'KCauldron - Code 4
        BukkitInfoURL(4, 12) = "http://downloads.sourceforge.net/project/cauldron-unofficial/1.6.4/libraries-1.965.21.zip" 'Caulron 1.6.4 LIB
        BukkitInfoURL(4, 14) = "http://jaist.dl.sourceforge.net/project/cauldron-unofficial/kcauldron/libraries-4.1403.65.zip" 'KCaulron 1.7.10 LIB
        BukkitInfoURL(4, 15) = "" 'Sponge 1.8 LIB
        BukkitInfoURL(4, 22) = "https://www.dropbox.com/s/6lolc95frez4vyw/Sg189.7z?dl=1" 'Sponge 1.8.9 LIB

        BukkitInfoURL(4, 0) = "http://tcpr.ca/files/cauldron/cauldron-1.6.4-1.965.21.204-server.jar" 'Cauldron 1.6.4 JAR
        BukkitInfoURL(4, 1) = "http://jaist.dl.sourceforge.net/project/cauldron-unofficial/kcauldron/kcauldron-1.7.10-4.1403.65-server.jar" 'KCauldron 1.7.10 JAR
        BukkitInfoURL(4, 2) = "" 'Sponge 1.8
        BukkitInfoURL(4, 3) = "http://kimustudio.tistory.com/attachment/cfile24.uf@2121DA4657139FD0228AD8.jar" 'Sponge 1.8.9

        'Rainbow - Code 5
        BukkitInfoURL(5, 17) = "https://www.dropbox.com/s/iooo5022w9pif7m/Rainbow%20-%201.8.4.jar?dl=1"
        BukkitInfoURL(5, 18) = "https://www.dropbox.com/s/aqbw3q35976rdrk/Rainbow%20-%201.8.5.jar?dl=1"
        BukkitInfoURL(5, 19) = "https://www.dropbox.com/s/urgkimu4b6m09fd/Rainbow%20-%201.8.6.jar?dl=1"
        BukkitInfoURL(5, 20) = "https://www.dropbox.com/s/hicmaf45cr5oa4h/Rainbow%20-%201.8.7.jar?dl=1"
        BukkitInfoURL(5, 21) = "https://www.dropbox.com/s/7r1jq2od2sw9qpg/Rainbow%20-%201.8.8.jar?dl=1"

        'PaperSpigot - Code 6
        BukkitInfoURL(6, 14) = "http://tcpr.ca/files/paperspigot/PaperSpigot-1.7.10-R0.1-SNAPSHOT-latest.jar" '1.7.10
        BukkitInfoURL(6, 15) = "http://tcpr.ca/files/paperspigot/PaperSpigot-1.8-R0.1-SNAPSHOT-b235.jar" '1.8
        BukkitInfoURL(6, 16) = "http://tcpr.ca/files/paperspigot/PaperSpigot-1.8.3-R0.1-SNAPSHOT-latest.jar" '1.8.3
        BukkitInfoURL(6, 17) = "http://tcpr.ca/files/paperspigot/PaperSpigot-1.8.4-R0.1-SNAPSHOT-latest.jar" '1.8.4
        BukkitInfoURL(6, 18) = "http://tcpr.ca/files/paperspigot/PaperSpigot-1.8.5-R0.1-SNAPSHOT-latest.jar" '1.8.5
        BukkitInfoURL(6, 19) = "http://tcpr.ca/files/paperspigot/PaperSpigot-1.8.6-R0.1-SNAPSHOT-latest.jar" '1.8.6
        BukkitInfoURL(6, 20) = "http://tcpr.ca/files/paperspigot/PaperSpigot-1.8.7-R0.1-SNAPSHOT-latest.jar" '1.8.7
        'BukkitInfoURL(6, 21) = "http://tcpr.ca/files/paperspigot/PaperSpigot-api-1.8.8-R0.1-SNAPSHOT-latest.jar" '1.8.8

        'Sponge - Code 7
        BukkitInfoURL(7, 0) = ""
        BukkitInfoURL(7, 0) = ""
        BukkitInfoURL(7, 0) = ""
        BukkitInfoURL(7, 0) = ""
        BukkitInfoURL(7, 0) = ""
        BukkitInfoURL(7, 0) = ""

        'Thermos - Code 8
        BukkitInfoURL(8, 0) = ""
        BukkitInfoURL(8, 0) = ""
        BukkitInfoURL(8, 0) = ""
        BukkitInfoURL(8, 0) = ""
        BukkitInfoURL(8, 0) = ""
        BukkitInfoURL(8, 0) = ""
    End Sub

    '애니메이션 코드는 여기부터입니다.

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Not Me.Opacity = 1 Then
            Me.Opacity = Me.Opacity + 0.04
        Else : NewDownloadtab2.Close()
            Timer1.Stop()
            Timer2.Start()
        End If
    End Sub
End Class