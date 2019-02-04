Imports System.Runtime.InteropServices
Imports System.Text

Public Class NewPluginsTab
    Dim ptmcu, ptmnew, ptfcu, ptfnew As Point
    Dim aa As Boolean = False
    Dim SelectedButton As FlatButton

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

    <DllImport("KERNEL32.DLL")>
    Private Shared Function GetPrivateProfileString(section As String, key As String, def As String, retVal As StringBuilder, size As Integer, filePath As String) As Integer
    End Function

    <DllImport("KERNEL32.DLL")>
    Private Shared Function WritePrivateProfileString(section As String, key As String, val As String, filePath As String) As Long
    End Function

    Public Function GetIniValue(Section As String, Key As String, iniPath As String) As String
        Dim temp As New StringBuilder(255)
        Dim i As Integer = GetPrivateProfileString(Section, Key, "", temp, 255, iniPath)
        Return temp.ToString()
    End Function

    Public Sub SetIniValue(Section As String, Key As String, Value As String, iniPath As String)
        WritePrivateProfileString(Section, Key, Value, iniPath)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Not Me.Opacity = 1 Then
            Me.Opacity = Me.Opacity + 0.04
        Else : NewHome.Close()
            Timer1.Stop()
        End If
    End Sub

    Private Sub NewPluginsTab_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.MyIcon48
        Timer1.Start()
        servername.Text = GetIniValue("Slot" & SlotNumber.Text, "servername", "C:\KimuSoft\KuBukkit\Serverinfor.ini")
        If Not System.IO.Directory.Exists("C:\KimuSoft\KuBukkit\server\" + Replace(servername.Text, " ", "_") + "\plugins") Then
            MkDir("C:\KimuSoft\KuBukkit\server\" + Replace(servername.Text, " ", "_") + "\plugins")
        End If
        SelectedButton = PluginSer
        DirSerach()
        Dim PluginsINFO(5, 50, 4) As String ' 0 = Kor / 1 = Eng / 2 = URL / 3 = Version
        For a = 0 To 30
            PluginsINFO(1, a, 3) = "1.5.2"
            PluginsINFO(1, a, 4) = "?"
        Next
        For a = 0 To 30
            PluginsINFO(2, a, 3) = "1.6.4"
            PluginsINFO(2, a, 4) = "?"
        Next
        For a = 0 To 40
            PluginsINFO(3, a, 3) = "1.7.2"
            PluginsINFO(3, a, 4) = "?"
        Next
        For a = 1 To 40
            PluginsINFO(4, a, 3) = "1.8"
            PluginsINFO(4, a, 4) = "?"
        Next

        '1.5 Plugins

        Dim TwoNumber As Byte = 1
        PluginsINFO(1, TwoNumber, 0) = "Essentials" '1.5.2
        PluginsINFO(1, TwoNumber, 1) = "에센셜" 'ZIP 다운로드라서 직접링크 불가
        PluginsINFO(1, TwoNumber, 2) = "https://www.dropbox.com/s/l48nqplw8fctd01/%5B%201.5.2%20%5D%20Essentials.jar?dl=1"
        TwoNumber += 1
        PluginsINFO(1, TwoNumber, 0) = "EssentialsChat"
        PluginsINFO(1, TwoNumber, 1) = "에센셜 채팅" 'ZIP 다운로드라서 직접링크 불가
        PluginsINFO(1, TwoNumber, 2) = "https://www.dropbox.com/s/vbesquu8fbcbwuk/%5B%201.5.2%20%5D%20EssentialsChat.jar?dl=1"
        TwoNumber += 1
        PluginsINFO(1, TwoNumber, 0) = "EssentialsProtect"
        PluginsINFO(1, TwoNumber, 1) = "에센셜 프로텍트" 'ZIP 다운로드라서 직접링크 불가
        PluginsINFO(1, TwoNumber, 2) = "https://www.dropbox.com/s/auwf6ytxzh4342y/%5B%201.5.2%20%5D%20EssentialsProtect.jar?dl=1"
        TwoNumber += 1
        PluginsINFO(1, TwoNumber, 0) = "EssentialsSpawn"
        PluginsINFO(1, TwoNumber, 1) = "에센셜 스폰" 'ZIP 다운로드라서 직접링크 불가
        PluginsINFO(1, TwoNumber, 2) = "https://www.dropbox.com/s/qdkf9yi1coimxt1/%5B%201.5.2%20%5D%20EssentialsSpawn.jar?dl=1"
        TwoNumber += 1
        PluginsINFO(1, TwoNumber, 0) = "WorldEdit"
        PluginsINFO(1, TwoNumber, 1) = "월드에딧" '1단 압축 보안이라 직접링크 불가
        PluginsINFO(1, TwoNumber, 2) = "https://www.dropbox.com/s/o84taaih74segzx/%5B%201.5.2%20%5D%20worldedit-5.5.6.jar?dl=1"
        TwoNumber += 1
        PluginsINFO(1, TwoNumber, 0) = "AutoSaveWorld"
        PluginsINFO(1, TwoNumber, 1) = "자동저장" 'Curse 직접링크를 찾을 수 없음
        PluginsINFO(1, TwoNumber, 2) = "https://www.dropbox.com/s/c2ripbczznni7xx/%5B%201.5.2%20%5D%20AutoSaveWorld.jar?dl=1"
        TwoNumber += 1
        PluginsINFO(1, TwoNumber, 0) = "AuthMe"
        PluginsINFO(1, TwoNumber, 1) = "로그인" 'Curse 직접링크를 찾을 수 없음
        PluginsINFO(1, TwoNumber, 2) = "https://www.dropbox.com/s/54fmjs4ru6nhx8f/%5B%201.5.2%20%5D%20AuthMe%20-%20Korean.jar?dl=1"
        TwoNumber += 1
        PluginsINFO(1, TwoNumber, 0) = "Lockette"
        PluginsINFO(1, TwoNumber, 1) = "창고잠금"
        PluginsINFO(1, TwoNumber, 2) = "http://addons-origin.cursecdn.com/files/702/588/Lockette.jar"
        PluginsINFO(1, TwoNumber, 4) = "1.7.12"
        TwoNumber += 1
        PluginsINFO(1, TwoNumber, 0) = "NBTEditor"
        PluginsINFO(1, TwoNumber, 1) = "NBT 에딧"
        PluginsINFO(1, TwoNumber, 2) = "http://addons-origin.cursecdn.com/files/712/456/NBTEditor_v0.0.6.zip"
        PluginsINFO(1, TwoNumber, 4) = "Beta 0.0.6"
        TwoNumber += 1
        PluginsINFO(1, TwoNumber, 0) = "OwnBlock"
        PluginsINFO(1, TwoNumber, 1) = "블럭보호" 'Curse 직접링크를 찾을 수 없음
        PluginsINFO(1, TwoNumber, 2) = "https://www.dropbox.com/s/pj61ikk5413f65b/%5B%201.5.2%20%5D%20OwnBlocks.jar?dl=1"
        TwoNumber += 1
        PluginsINFO(1, TwoNumber, 0) = "RPGItem"
        PluginsINFO(1, TwoNumber, 1) = "RPG 아이템" 'Curse 직접링크를 찾았지만 맞는 지 모르겠음
        PluginsINFO(1, TwoNumber, 2) = "https://www.dropbox.com/s/ufe4vd6lb4glal1/%5B%201.5.2%20%5D%20rpgitems.jar?dl=1"
        TwoNumber += 1
        PluginsINFO(1, TwoNumber, 0) = "Shopkeepers"
        PluginsINFO(1, TwoNumber, 1) = "주민상점"
        PluginsINFO(1, TwoNumber, 2) = "http://addons-origin.cursecdn.com/files/713/777/Shopkeepers.jar"
        PluginsINFO(1, TwoNumber, 4) = "1.13.4"
        TwoNumber += 1
        PluginsINFO(1, TwoNumber, 0) = "OPLock"
        PluginsINFO(1, TwoNumber, 1) = "오피 불가능화"
        PluginsINFO(1, TwoNumber, 2) = "http://addons-origin.cursecdn.com/files/676/70/OPLock.jar"
        PluginsINFO(1, TwoNumber, 4) = "6.0"
        TwoNumber += 1
        PluginsINFO(1, TwoNumber, 0) = "Skychest"
        PluginsINFO(1, TwoNumber, 1) = "창고정리" 'Curse 직접링크를 찾을 수 없음
        PluginsINFO(1, TwoNumber, 2) = "https://www.dropbox.com/s/m4ndgnabur3ztlu/%5B%201.5.2%20%5D%20skychest.jar?dl=1"
        TwoNumber += 1
        PluginsINFO(1, TwoNumber, 0) = "TimTimEnchant"
        PluginsINFO(1, TwoNumber, 1) = "인챈트" 'Curse 직접링크를 찾을 수 없음, 티스토리 링크 사용 중
        PluginsINFO(1, TwoNumber, 2) = "http://kimustudio.tistory.com/attachment/cfile9.uf@2530364756D1375F0564AA.jar" '
        TwoNumber += 1
        PluginsINFO(1, TwoNumber, 0) = "TreeAssist"
        PluginsINFO(1, TwoNumber, 1) = "찹트리"
        PluginsINFO(1, TwoNumber, 2) = "http://addons-origin.cursecdn.com/files/686/119/TreeAssist.jar"
        PluginsINFO(1, TwoNumber, 4) = "4.2.1"
        TwoNumber += 1
        PluginsINFO(1, TwoNumber, 0) = "CMDBook"
        PluginsINFO(1, TwoNumber, 1) = "커맨드 북"
        PluginsINFO(1, TwoNumber, 2) = "http://addons-origin.cursecdn.com/files/714/775/cmdBook.jar"
        PluginsINFO(1, TwoNumber, 4) = "1.4.2"
        TwoNumber += 1
        PluginsINFO(1, TwoNumber, 0) = "SetRankPEX"
        PluginsINFO(1, TwoNumber, 1) = "펄미션 랭크조정"
        PluginsINFO(1, TwoNumber, 2) = "http://addons-origin.cursecdn.com/files/703/364/SetRankPEX.jar"
        PluginsINFO(1, TwoNumber, 4) = "1.7"

        '1.6 Plugins

        TwoNumber = 1
        PluginsINFO(2, TwoNumber, 0) = "NBTEditor" '1.6.2
        PluginsINFO(2, TwoNumber, 1) = "NBT 에딧"
        PluginsINFO(2, TwoNumber, 2) = "http://addons-origin.cursecdn.com/files/722/702/NBTEditor_v0.0.7.zip"
        PluginsINFO(2, TwoNumber, 3) = "1.6.2"
        PluginsINFO(2, TwoNumber, 4) = "Beta 0.0.7"
        TwoNumber += 1
        PluginsINFO(2, TwoNumber, 0) = "Shopkeeper"
        PluginsINFO(2, TwoNumber, 1) = "주민상점"
        PluginsINFO(2, TwoNumber, 2) = "http://addons-origin.cursecdn.com/files/719/878/Shopkeepers.jar"
        PluginsINFO(2, TwoNumber, 3) = "1.6.2"
        PluginsINFO(2, TwoNumber, 4) = "1.15.1"
        TwoNumber += 1
        PluginsINFO(2, TwoNumber, 0) = "TreeAssist"
        PluginsINFO(2, TwoNumber, 1) = "찹트리"
        PluginsINFO(2, TwoNumber, 2) = "http://addons-origin.cursecdn.com/files/728/99/TreeAssist.jar"
        PluginsINFO(2, TwoNumber, 3) = "1.6.2"
        PluginsINFO(2, TwoNumber, 4) = "4.3"
        TwoNumber += 1
        PluginsINFO(2, TwoNumber, 0) = "Regios"
        PluginsINFO(2, TwoNumber, 1) = "레지오스 지역보호"
        PluginsINFO(2, TwoNumber, 2) = "http://addons-origin.cursecdn.com/files/725/416/Regios.jar"
        PluginsINFO(2, TwoNumber, 3) = "1.6.2"
        PluginsINFO(2, TwoNumber, 4) = "5.9.9"
        TwoNumber += 1

        PluginsINFO(2, TwoNumber, 0) = "NBTEditor" '1.6.4
        PluginsINFO(2, TwoNumber, 1) = "NBT 에딧"
        PluginsINFO(2, TwoNumber, 2) = "http://addons-origin.cursecdn.com/files/761/241/nbteditor-1.0.zip"
        PluginsINFO(2, TwoNumber, 4) = "1.0"
        TwoNumber += 1
        PluginsINFO(2, TwoNumber, 0) = "WorldEdit" '
        PluginsINFO(2, TwoNumber, 1) = "월드에딧" '1단 압축 보안이라 직접링크 불가
        PluginsINFO(2, TwoNumber, 2) = "https://www.dropbox.com/s/ywc0fb4hntw2yu0/%5B%201.6.4%20%5D%20Worldedit.jar?dl=1"
        TwoNumber += 1
        PluginsINFO(2, TwoNumber, 0) = "Essentials"
        PluginsINFO(2, TwoNumber, 1) = "에센셜" 'ZIP 다운로드라서 직접링크 불가
        PluginsINFO(2, TwoNumber, 2) = "https://www.dropbox.com/s/zciofo3ys41osk7/Essentials.jar?dl=1"
        TwoNumber += 1
        PluginsINFO(2, TwoNumber, 0) = "EssentialsAntiBuild"
        PluginsINFO(2, TwoNumber, 1) = "에센셜 건축방지" 'ZIP 다운로드라서 직접링크 불가
        PluginsINFO(2, TwoNumber, 2) = "https://www.dropbox.com/s/v3hpg9j577inzxm/EssentialsAntiBuild.jar?dl=1"
        TwoNumber += 1
        PluginsINFO(2, TwoNumber, 0) = "EssentialsChat"
        PluginsINFO(2, TwoNumber, 1) = "에센셜 채팅" 'ZIP 다운로드라서 직접링크 불가
        PluginsINFO(2, TwoNumber, 2) = "https://www.dropbox.com/s/67pjeae1nq4p43b/EssentialsChat.jar?dl=1"
        TwoNumber += 1
        PluginsINFO(2, TwoNumber, 0) = "EssentialsProtect"
        PluginsINFO(2, TwoNumber, 1) = "에센셜 프로텍트" 'ZIP 다운로드라서 직접링크 불가
        PluginsINFO(2, TwoNumber, 2) = "https://www.dropbox.com/s/gl7x77mx8g6rrgy/EssentialsProtect.jar?dl=1"
        TwoNumber += 1
        PluginsINFO(2, TwoNumber, 0) = "EssentialsSpawn"
        PluginsINFO(2, TwoNumber, 1) = "에센셜 스폰" 'ZIP 다운로드라서 직접링크 불가
        PluginsINFO(2, TwoNumber, 2) = "https://www.dropbox.com/s/0qjvbe1q5rrt4x2/EssentialsSpawn.jar?dl=1"
        TwoNumber += 1
        PluginsINFO(2, TwoNumber, 0) = "Shopkeeper"
        PluginsINFO(2, TwoNumber, 1) = "주민상점"
        PluginsINFO(2, TwoNumber, 2) = "http://addons-origin.cursecdn.com/files/758/845/Shopkeepers.jar"
        PluginsINFO(2, TwoNumber, 4) = "1.16 beta2"
        TwoNumber += 1
        PluginsINFO(2, TwoNumber, 0) = "CMDBook"
        PluginsINFO(2, TwoNumber, 1) = "커맨드 북"
        PluginsINFO(2, TwoNumber, 2) = "http://addons-origin.cursecdn.com/files/744/3/cmdBook.jar"
        PluginsINFO(2, TwoNumber, 4) = "1.4.3"

        '1.7 Plugins

        TwoNumber = 1 ' 1.7.2
        PluginsINFO(3, TwoNumber, 0) = "AuthMe"
        PluginsINFO(3, TwoNumber, 1) = "로그인" 'Curse 직접링크를 찾을 수 없음
        PluginsINFO(3, TwoNumber, 2) = "https://www.dropbox.com/s/23aavj4im2esrtc/AuthMe.jar?dl=1"
        TwoNumber += 1
        PluginsINFO(3, TwoNumber, 0) = "NBTEditor"
        PluginsINFO(3, TwoNumber, 1) = "NBT 에딧"
        PluginsINFO(3, TwoNumber, 2) = "http://addons-origin.cursecdn.com/files/776/944/nbteditor-1.1.2.zip"
        PluginsINFO(3, TwoNumber, 4) = "1.1.2"
        TwoNumber += 1
        PluginsINFO(3, TwoNumber, 0) = "AutoSaveWorld"
        PluginsINFO(3, TwoNumber, 1) = "자동저장" 'Curse 직접링크를 찾을 수 없음
        PluginsINFO(3, TwoNumber, 2) = "https://www.dropbox.com/s/9w1f8vg6rt0ngyj/Autosave.jar?dl=1"
        TwoNumber += 1
        PluginsINFO(3, TwoNumber, 0) = "BackPack"
        PluginsINFO(3, TwoNumber, 1) = "가방추가" 'Curse 직접링크를 찾을 수 없음
        PluginsINFO(3, TwoNumber, 2) = "https://www.dropbox.com/s/qoyb9uh5gekhzop/Backpack.jar?dl=1"
        TwoNumber += 1
        PluginsINFO(3, TwoNumber, 0) = "BlockRegeneration"
        PluginsINFO(3, TwoNumber, 1) = "에메랄드 회복블럭화"
        PluginsINFO(3, TwoNumber, 2) = "http://addons-origin.cursecdn.com/files/791/7/BlockRegeneration.jar"
        PluginsINFO(3, TwoNumber, 4) = "2.0"
        TwoNumber += 1
        PluginsINFO(3, TwoNumber, 0) = "ChopTree"
        PluginsINFO(3, TwoNumber, 1) = "찹트리" 'Curse 직접링크를 찾을 수 없음
        PluginsINFO(3, TwoNumber, 2) = "https://www.dropbox.com/s/7v4xotmsiozj9gm/ChopTree2.jar?dl=1"
        TwoNumber += 1
        PluginsINFO(3, TwoNumber, 0) = "Iconomy Korean"
        PluginsINFO(3, TwoNumber, 1) = "이코노미" '한글판이라서 당연히 직접링크가 없음
        PluginsINFO(3, TwoNumber, 2) = "https://www.dropbox.com/s/67jtocf3ecfun7k/iconomy.jar?dl=1"
        TwoNumber += 1
        PluginsINFO(3, TwoNumber, 0) = "iZone"
        PluginsINFO(3, TwoNumber, 1) = "지역보호" 'Curse 직접링크를 찾을 수 없음
        PluginsINFO(3, TwoNumber, 2) = "https://www.dropbox.com/s/le9qd3bp4vw9f7i/IZone.jar?dl=1"
        TwoNumber += 1
        PluginsINFO(3, TwoNumber, 0) = "Lockette"
        PluginsINFO(3, TwoNumber, 1) = "창고잠금"
        PluginsINFO(3, TwoNumber, 2) = "https://www.dropbox.com/s/sb3uy9b5kgsqegz/lockette.jar?dl=1"
        TwoNumber += 1
        PluginsINFO(3, TwoNumber, 0) = "MobHealth"
        PluginsINFO(3, TwoNumber, 1) = "몹헬스"
        PluginsINFO(3, TwoNumber, 2) = "https://www.dropbox.com/s/28deqlnvnrwnlge/MobHealth%28ko%29.jar?dl=1"
        TwoNumber += 1
        PluginsINFO(3, TwoNumber, 0) = "MultiWorld"
        PluginsINFO(3, TwoNumber, 1) = "멀티월드"
        PluginsINFO(3, TwoNumber, 2) = "https://www.dropbox.com/s/vuckco5hmbmnn91/multiworld.jar?dl=1"
        TwoNumber += 1
        PluginsINFO(3, TwoNumber, 0) = "NBTEditor"
        PluginsINFO(3, TwoNumber, 1) = "NBT 에딧"
        PluginsINFO(3, TwoNumber, 2) = "https://www.dropbox.com/s/8d8inwj9gm017st/nbteditor.jar?dl=1"
        TwoNumber += 1
        PluginsINFO(3, TwoNumber, 0) = "OwnBlock"
        PluginsINFO(3, TwoNumber, 1) = "블럭보호"
        PluginsINFO(3, TwoNumber, 2) = "https://www.dropbox.com/s/pd6rypru51bq6xc/OwnBlocks.jar?dl=1"
        TwoNumber += 1
        PluginsINFO(3, TwoNumber, 0) = "PermissionEX"
        PluginsINFO(3, TwoNumber, 1) = "펄미션"
        PluginsINFO(3, TwoNumber, 2) = "https://www.dropbox.com/s/veezvu1ucnzwva6/PermissionsEx.jar?dl=1"
        TwoNumber += 1
        PluginsINFO(3, TwoNumber, 0) = "SetRankPEX"
        PluginsINFO(3, TwoNumber, 1) = "펄미션 랭크조정"
        PluginsINFO(3, TwoNumber, 2) = "http://addons-origin.cursecdn.com/files/781/768/SetRankPEX.jar"
        PluginsINFO(3, TwoNumber, 4) = "1.7.1"
        TwoNumber += 1
        PluginsINFO(3, TwoNumber, 0) = "RPGitem"
        PluginsINFO(3, TwoNumber, 1) = "RPG 아이템"
        PluginsINFO(3, TwoNumber, 2) = "https://www.dropbox.com/s/hrfvp9yhfnbqcom/rpgitems.jar?dl=1"
        TwoNumber += 1
        PluginsINFO(3, TwoNumber, 0) = "RPGSpawns"
        PluginsINFO(3, TwoNumber, 1) = "다중스폰"
        PluginsINFO(3, TwoNumber, 2) = "https://www.dropbox.com/s/rch5fa084ishbb5/RPGSpawns.jar?dl=1"
        TwoNumber += 1
        PluginsINFO(3, TwoNumber, 0) = "RPGStatsSystem"
        PluginsINFO(3, TwoNumber, 1) = "RPG스탯 시스템"
        PluginsINFO(3, TwoNumber, 2) = "https://www.dropbox.com/s/4me9yeporhz2vlb/RpgStatsSystem.jar?dl=1"
        TwoNumber += 1
        PluginsINFO(3, TwoNumber, 0) = "Shopkeepers"
        PluginsINFO(3, TwoNumber, 1) = "주민상점"
        PluginsINFO(3, TwoNumber, 2) = "https://www.dropbox.com/s/8w1f7mk2hmttz02/Shopkeepers.jar?dl=1"
        TwoNumber += 1
        PluginsINFO(3, TwoNumber, 0) = "Spectate"
        PluginsINFO(3, TwoNumber, 1) = "엿보기"
        PluginsINFO(3, TwoNumber, 2) = "https://www.dropbox.com/s/dm0ht4qucvf5mkd/spectate.jar?dl=1"
        TwoNumber += 1
        PluginsINFO(3, TwoNumber, 0) = "VariableTriggers"
        PluginsINFO(3, TwoNumber, 1) = "트리거"
        PluginsINFO(3, TwoNumber, 2) = "http://addons-origin.cursecdn.com/files/778/70/VariableTriggers-1.2.7.jar"
        PluginsINFO(3, TwoNumber, 4) = "1.2.7"
        TwoNumber += 1
        PluginsINFO(3, TwoNumber, 0) = "Vault"
        PluginsINFO(3, TwoNumber, 1) = "호환"
        PluginsINFO(3, TwoNumber, 2) = "https://www.dropbox.com/s/qqcf5vbrkexh6xp/Vault.jar?dl=1"
        TwoNumber += 1
        PluginsINFO(3, TwoNumber, 0) = "WorldEdit"
        PluginsINFO(3, TwoNumber, 1) = "월드에딧"
        PluginsINFO(3, TwoNumber, 2) = "https://www.dropbox.com/s/8o1n0cxicklb9j5/WorldEdit.jar?dl=1"
        TwoNumber += 1
        PluginsINFO(3, TwoNumber, 0) = "Essentials"
        PluginsINFO(3, TwoNumber, 1) = "에센셜"
        PluginsINFO(3, TwoNumber, 2) = "http://kimustudio.tistory.com/attachment/cfile30.uf@27111F4756D1375C1ABC9D.jar"
        TwoNumber += 1
        PluginsINFO(3, TwoNumber, 0) = "EssentialsAntiBuild"
        PluginsINFO(3, TwoNumber, 1) = "에센셜 건축방지"
        PluginsINFO(3, TwoNumber, 2) = "http://kimustudio.tistory.com/attachment/cfile26.uf@2220E64756D1375D0F1A80.jar"
        TwoNumber += 1
        PluginsINFO(3, TwoNumber, 0) = "EssentialChat"
        PluginsINFO(3, TwoNumber, 1) = "에센셜 채팅"
        PluginsINFO(3, TwoNumber, 2) = "http://kimustudio.tistory.com/attachment/cfile10.uf@25274F4756D1375E0BB39B.jar" '티스토리 링크
        TwoNumber += 1
        PluginsINFO(3, TwoNumber, 0) = "EssentialProtect"
        PluginsINFO(3, TwoNumber, 1) = "에센셜 프로텍트"
        PluginsINFO(3, TwoNumber, 2) = "http://kimustudio.tistory.com/attachment/cfile30.uf@2472004756D1375E2DC4A0.jar" '티스토리 링크
        TwoNumber += 1
        PluginsINFO(3, TwoNumber, 0) = "EssentialSpawn"
        PluginsINFO(3, TwoNumber, 1) = "에센셜 스폰"
        PluginsINFO(3, TwoNumber, 2) = "http://kimustudio.tistory.com/attachment/cfile9.uf@256BF04756D1375F33F29F.jar" '티스토리 링크
        TwoNumber += 1
        PluginsINFO(3, TwoNumber, 0) = "TreeAssist"
        PluginsINFO(3, TwoNumber, 1) = "찹트리"
        PluginsINFO(3, TwoNumber, 2) = "http://addons-origin.cursecdn.com/files/768/293/TreeAssist.jar"
        PluginsINFO(3, TwoNumber, 4) = "4.3.2alpha"
        TwoNumber += 1
        PluginsINFO(3, TwoNumber, 0) = "CMDBook"
        PluginsINFO(3, TwoNumber, 1) = "커맨드 북"
        PluginsINFO(3, TwoNumber, 2) = "http://addons-origin.cursecdn.com/files/765/825/cmdBook.jar"
        PluginsINFO(3, TwoNumber, 4) = "1.4.6"

        TwoNumber += 1 '1.7.4
        PluginsINFO(3, TwoNumber, 0) = "ClickWarp"
        PluginsINFO(3, TwoNumber, 1) = "클릭워프"
        PluginsINFO(3, TwoNumber, 2) = "http://addons-origin.cursecdn.com/files/699/352/ClickWarp_v1.3.5.jar"
        PluginsINFO(3, TwoNumber, 3) = "1.7.4"
        PluginsINFO(3, TwoNumber, 4) = "1.3.5"

        TwoNumber += 1 '1.7.9
        PluginsINFO(3, TwoNumber, 0) = "NBTEditor"
        PluginsINFO(3, TwoNumber, 1) = "NET 에딧"
        PluginsINFO(3, TwoNumber, 2) = "http://addons-origin.cursecdn.com/files/810/739/nbteditor-1.1.3.zip"
        PluginsINFO(3, TwoNumber, 3) = "1.7.9"
        PluginsINFO(3, TwoNumber, 4) = "1.1.3"
        TwoNumber += 1
        PluginsINFO(3, TwoNumber, 0) = "VillageShop"
        PluginsINFO(3, TwoNumber, 1) = "주민상점"
        PluginsINFO(3, TwoNumber, 2) = "http://addons-origin.cursecdn.com/files/837/511/Shopkeepers.jar"
        PluginsINFO(3, TwoNumber, 3) = "1.7.9"
        PluginsINFO(3, TwoNumber, 4) = "1.31"
        TwoNumber += 1
        PluginsINFO(3, TwoNumber, 0) = "VariableTriggers"
        PluginsINFO(3, TwoNumber, 1) = "트리거"
        PluginsINFO(3, TwoNumber, 2) = "http://addons-origin.cursecdn.com/files/808/372/VariableTriggers.jar"
        PluginsINFO(3, TwoNumber, 3) = "1.7.9"
        PluginsINFO(3, TwoNumber, 4) = "1.3.3.1"
        TwoNumber += 1
        PluginsINFO(3, TwoNumber, 0) = "BlockRegeneration"
        PluginsINFO(3, TwoNumber, 1) = "에메랄드 회복블럭화"
        PluginsINFO(3, TwoNumber, 2) = "http://addons-origin.cursecdn.com/files/830/2/BlockRegeneration.jar"
        PluginsINFO(3, TwoNumber, 3) = "1.7.9"
        PluginsINFO(3, TwoNumber, 4) = "2.4"

        TwoNumber += 1 '1.7.10
        PluginsINFO(3, TwoNumber, 0) = "ChestShop"
        PluginsINFO(3, TwoNumber, 1) = "체스트 샵"
        PluginsINFO(3, TwoNumber, 2) = "https://www.dropbox.com/s/p6is5zkk6026zy9/chestshop.jar?dl=1"
        PluginsINFO(3, TwoNumber, 3) = "1.7.10"
        TwoNumber += 1
        PluginsINFO(3, TwoNumber, 0) = "Iconomy"
        PluginsINFO(3, TwoNumber, 1) = "이코노미"
        PluginsINFO(3, TwoNumber, 2) = "https://www.dropbox.com/s/u8zmo0dbdaqincx/iConomy.jar?dl=1"
        PluginsINFO(3, TwoNumber, 3) = "1.7.10"
        TwoNumber += 1
        PluginsINFO(3, TwoNumber, 0) = "WorldEdit"
        PluginsINFO(3, TwoNumber, 1) = "월드에딧" '티스토리 링크
        PluginsINFO(3, TwoNumber, 2) = "http://kimustudio.tistory.com/attachment/cfile26.uf@243E843856D1924A1CAE03.jar"
        PluginsINFO(3, TwoNumber, 3) = "1.7.10"

        '1.8 Plugins

        TwoNumber = 1 ' 1.8
        PluginsINFO(4, TwoNumber, 0) = "Lockette"
        PluginsINFO(4, TwoNumber, 1) = "창고잠금"
        PluginsINFO(4, TwoNumber, 2) = "http://addons-origin.cursecdn.com/files/853/743/Lockette.jar"
        PluginsINFO(4, TwoNumber, 4) = "1.8.0"
        TwoNumber += 1
        PluginsINFO(4, TwoNumber, 0) = "NBTEditor"
        PluginsINFO(4, TwoNumber, 1) = "NET 에딧"
        PluginsINFO(4, TwoNumber, 2) = "http://addons-origin.cursecdn.com/files/855/196/nbteditor-1.2.zip"
        PluginsINFO(4, TwoNumber, 4) = "1.2"
        TwoNumber += 1
        PluginsINFO(4, TwoNumber, 0) = "Shopkeeper"
        PluginsINFO(4, TwoNumber, 1) = "주민상점"
        PluginsINFO(4, TwoNumber, 2) = "http://addons-origin.cursecdn.com/files/905/923/Shopkeepers.jar"
        PluginsINFO(4, TwoNumber, 4) = "1.68"
        TwoNumber += 1 ' 1.8.1
        PluginsINFO(4, TwoNumber, 0) = "Lockette"
        PluginsINFO(4, TwoNumber, 1) = "창고잠금"
        PluginsINFO(4, TwoNumber, 2) = "http://addons-origin.cursecdn.com/files/853/743/Lockette.jar"
        PluginsINFO(4, TwoNumber, 3) = "1.8.1"
        PluginsINFO(4, TwoNumber, 4) = "1.8.20"
        TwoNumber += 1
        PluginsINFO(4, TwoNumber, 0) = "Shopkeeper"
        PluginsINFO(4, TwoNumber, 1) = "주민상점"
        PluginsINFO(4, TwoNumber, 2) = "http://addons-origin.cursecdn.com/files/853/623/Shopkeepers.jar"
        PluginsINFO(4, TwoNumber, 3) = "1.8.1"
        PluginsINFO(4, TwoNumber, 4) = "1.43"
        TwoNumber += 1
        PluginsINFO(4, TwoNumber, 0) = "VariableTriggers"
        PluginsINFO(4, TwoNumber, 1) = "트리거"
        PluginsINFO(4, TwoNumber, 2) = "http://addons-origin.cursecdn.com/files/898/760/VariableTriggers.jar"
        PluginsINFO(4, TwoNumber, 3) = "1.8.1"
        PluginsINFO(4, TwoNumber, 4) = "2.0.4.2"
        TwoNumber += 1
        PluginsINFO(4, TwoNumber, 0) = "BlockRegeneration"
        PluginsINFO(4, TwoNumber, 1) = "에메랄드 회복블럭화"
        PluginsINFO(4, TwoNumber, 2) = "http://addons-origin.cursecdn.com/files/908/490/BlockRegeneration.jar"
        PluginsINFO(4, TwoNumber, 3) = "1.8.1"
        PluginsINFO(4, TwoNumber, 4) = "3.1"

        'ALL Version Plugins

        PluginsINFO(0, 1, 0) = "Motdcolor"
        PluginsINFO(0, 1, 1) = "슬로건 수정"
        PluginsINFO(0, 1, 2) = "https://www.dropbox.com/s/3yykcuaqxvx2krb/%5B%201.5.2%20~%201.7.10%20%5D%20motdcolor.jar?dl=1"
        PluginsINFO(0, 1, 3) = ".ALL"
        PluginsINFO(0, 1, 4) = "?"

        PluginsINFO(0, 2, 0) = "DynMap"
        PluginsINFO(0, 2, 1) = "인터넷 맵"
        PluginsINFO(0, 2, 2) = "https://www.dropbox.com/s/8b2ddio5asmbd15/%5B%201.5.2%20~%201.7.10%20%5D%20dynmap.jar?dl=1"
        PluginsINFO(0, 2, 3) = ".ALL"
        PluginsINFO(0, 2, 4) = "?"


        Dim PluginMaximum As Long
        Dim PluginVersionCuts As String
        For i = 0 To 4
            PluginMaximum = 1

            Do Until PluginsINFO(i, PluginMaximum, 0) = ""
                PluginVersionCuts = "1" & Split(PluginsINFO(i, 1, 3), ".")(1)
                Dim CreateFlatButtonNumber As New PluginsList
                CreateFlatButtonNumber.Name = "Plugin" & PluginVersionCuts & "_" & Replace(PluginsINFO(i, PluginMaximum, 0), " ", "_")
                CreateFlatButtonNumber.PluginEngName = PluginsINFO(i, PluginMaximum, 0)
                CreateFlatButtonNumber.PluginKorName = PluginsINFO(i, PluginMaximum, 1)
                CreateFlatButtonNumber.PluginURL = PluginsINFO(i, PluginMaximum, 2)
                CreateFlatButtonNumber.PluginVersion = PluginsINFO(i, PluginMaximum, 3)
                CreateFlatButtonNumber.OnlyPluginVer = PluginsINFO(i, PluginMaximum, 4)
                FlowLayoutPanel1.Controls.Add(CreateFlatButtonNumber)
                If System.IO.File.Exists("C:\KimuSoft\KuBukkit\server\" + Replace(servername.Text, " ", "_") + "\plugins\" + CreateFlatButtonNumber.PluginEngName + CreateFlatButtonNumber.PluginVersion + ".jar") Then
                    CreateFlatButtonNumber.PluginInstall = True
                Else CreateFlatButtonNumber.PluginInstall = False
                End If
                PluginMaximum += 1
            Loop
        Next
    End Sub

    Private Sub DirSerach()
        Dim Laugh As String = System.IO.Directory.GetFiles("C:\KimuSoft\KuBukkit\server\" + Replace(servername.Text, " ", "_") + "\plugins").Length
        SetIniValue("slot" + Me.SlotNumber.Text, "pluginsvalue", Laugh, "C:\KimuSoft\KuBukkit\Serverinfor.ini")
        Me.Label14.Text = Laugh + "개의 플러그인"
    End Sub

    Private Sub FlatStickyButton6_Click(sender As Object, e As EventArgs) Handles CloseForm.Click
        NewHome.Show()
        NewHome.Location = Me.Location
        Me.Close()
    End Sub

    Private Sub PluginSer_Click(sender As Object, e As EventArgs) Handles PluginSer.Click, Plugin15_.Click, Plugin16_.Click, Plugin17_.Click, Plugin18_.Click, Plugin1ALL_.Click
        PluginSer.BaseColor = Color.FromArgb(70, 70, 70)
        Plugin15_.BaseColor = Color.FromArgb(70, 70, 70)
        Plugin16_.BaseColor = Color.FromArgb(70, 70, 70)
        Plugin17_.BaseColor = Color.FromArgb(70, 70, 70)
        Plugin18_.BaseColor = Color.FromArgb(70, 70, 70)
        Plugin1ALL_.BaseColor = Color.FromArgb(70, 70, 70)
        TryCast(sender, FlatButton).BaseColor = Color.FromArgb(105, 105, 105)
        SelectedButton = TryCast(sender, FlatButton)
        PluginSer.Enabled = False
        PluginSer.Enabled = True
        Plugin15_.Enabled = False
        Plugin15_.Enabled = True
        Plugin16_.Enabled = False
        Plugin16_.Enabled = True
        Plugin17_.Enabled = False
        Plugin17_.Enabled = True
        Plugin18_.Enabled = False
        Plugin18_.Enabled = True
        Plugin1ALL_.Enabled = False
        Plugin1ALL_.Enabled = True
        PluginSer.Enabled = False
        PluginSer.Enabled = True
        Button1_Click(sender, e)
    End Sub

    Private Sub PictureBox5_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp, servername.MouseUp
        If e.Button = MouseButtons.Left Then
            aa = False
        End If
    End Sub

    Private Sub Label6_Mouseleave(sender As Object, e As EventArgs) Handles Label6.MouseLeave
        Label6.BackColor = Color.FromArgb(Label6.BackColor.R - 20, Label6.BackColor.G - 20, Label6.BackColor.B - 20)
    End Sub

    Private Sub Label2_Mouseleave(sender As Object, e As EventArgs) Handles Label6.MouseEnter
        Label6.BackColor = Color.FromArgb(Label6.BackColor.R + 20, Label6.BackColor.G + 20, Label6.BackColor.B + 20)
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        If Panel1.Location.X >= 0 Then
            MenuClose.Start()
            MenuOpen.Stop()
        ElseIf Panel1.Location.X <= -150 Then
            MenuOpen.Start()
            MenuClose.Stop()
        End If
    End Sub

    Private Sub MenuOpen_Tick(sender As Object, e As EventArgs) Handles MenuOpen.Tick
        If Panel1.Location.X <= 0 Then
            Panel1.Location = New Point(Panel1.Location.X + 6, 110)
        Else : MenuOpen.Stop()
        End If
    End Sub

    Private Sub MenuClose_Tick(sender As Object, e As EventArgs) Handles MenuClose.Tick
        If Panel1.Location.X >= -150 Then
            Panel1.Location = New Point(Panel1.Location.X - 6, 110)
        Else : MenuClose.Stop()
        End If
    End Sub

    Private Sub BukkitType_Click(sender As Object, e As EventArgs) Handles BukkitType.Click
        My.Computer.FileSystem.CreateDirectory("C:\KimuSoft\KuBukkit\server\" + Replace(servername.Text, " ", "_") + "\plugins")
        Shell("explorer C:\KimuSoft\KuBukkit\server\" + Replace(servername.Text, " ", "_") + "\plugins", vbNormalFocus)
        MenuClose.Start()
    End Sub

    Private Sub Inforing_Click(sender As Object, e As EventArgs) Handles Inforing.Click
        DirSerach()
        MenuClose.Start()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click, TextBox1.TextChanged, TextBox1.Click
        If Not TextBox1.Text = "" Then
            Label4.Visible = False
        Else : Label4.Visible = True
        End If
    End Sub

    Private Sub KeyVind(sender As Object, e As PreviewKeyDownEventArgs) Handles TextBox1.PreviewKeyDown
        If e.KeyCode = Keys.Enter Then
            Button1_Click(sender, e)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For Each c As Control In FlowLayoutPanel1.Controls
            If Replace(TryCast(c, PluginsList).PluginEngName, " ", "") = Replace(Replace(TryCast(c, PluginsList).PluginEngName, " ", ""), Replace(TextBox1.Text, " ", ""), "") And Replace(TryCast(c, PluginsList).PluginKorName, " ", "") = Replace(Replace(TryCast(c, PluginsList).PluginKorName, " ", ""), Replace(TextBox1.Text, " ", ""), "") And Not TextBox1.Text = "" Then
                TryCast(c, PluginsList).Visible = False
            Else : TryCast(c, PluginsList).Visible = True
            End If
        Next
        For Each c As Control In FlowLayoutPanel1.Controls
            If TryCast(c, PluginsList).Visible = True And Replace(TryCast(c, PluginsList).Name, SelectedButton.Name, "") = TryCast(c, PluginsList).Name And Not SelectedButton.Name = "PluginSer" Then
                TryCast(c, PluginsList).Visible = False
            End If
        Next
    End Sub
End Class