Imports System.Runtime.InteropServices
Imports System.Text

Public Class NewLauncherTab
    Dim ptmcu, ptmnew, ptfcu, ptfnew As Point
    Dim aa As Boolean = False
    Dim RAMval As Long

    <DllImport("KERNEL32.DLL")>
    Private Shared Function GetPrivateProfileString(section As [String], key As [String], def As [String], retVal As StringBuilder, size As Integer, filePath As [String]) As Integer
    End Function

    <DllImport("KERNEL32.DLL")> _
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

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Not Me.Opacity = 1 Then
            Me.Opacity = Me.Opacity + 0.04
        Else : NewHome.close
            Timer1.Stop()
        End If
    End Sub

    Private Sub picturebox8_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox8.MouseDown
        If e.Button = MouseButtons.Left Then
            aa = True
            ptmcu = Control.MousePosition
            ptfcu = Me.Location
        End If
    End Sub

    Private Sub PictureBox8_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox8.MouseMove
        If aa = True Then
            ptmnew = Control.MousePosition
            ptfnew.X = ptmnew.X - ptmcu.X + ptfcu.X
            ptfnew.Y = ptmnew.Y - ptmcu.Y + ptfcu.Y
            Me.Location = ptfnew
            ptfcu = ptfnew
            ptmcu = ptmnew
        End If
    End Sub

    Private Sub PictureBox8_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox8.MouseUp
        If e.Button = MouseButtons.Left Then
            aa = False
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.MyIcon48
        Timer1.Start()

        Select Case GetIniValue("Kubukkit", "smallramoption", "C:\KimuSoft\KuBukkit\bukkitdownloaddata.ini")
            Case "2"
                RadioButton2.Checked = False
                RadioButton3.Checked = True
            Case "3"
                RadioButton2.Checked = False
                RadioButton1.Checked = True
        End Select
        RamVaule.Text = Split(My.Computer.Info.TotalPhysicalMemory / 1024 / 1024 / 10 * (FlatTrackBar1.Value + 2), ".")(0)
        Label13.Text = (FlatTrackBar1.Value + 2) * 10
        allmyram.Text = Split(My.Computer.Info.TotalPhysicalMemory / 1024 / 1024, ".")(0)
    End Sub

    Private Sub FlatTrackBar1_Scroll(sender As Object) Handles FlatTrackBar1.Scroll
        RamVaule.Text = Split(My.Computer.Info.TotalPhysicalMemory / 1024 / 1024 / 10 * (FlatTrackBar1.Value + 2), ".")(0)
        Label13.Text = (FlatTrackBar1.Value + 2) * 10
        If RamVaule.Text < 512 Then
            Critical512.Visible = True
        Else Critical512.Visible = False
        End If
    End Sub

    Private Sub FlatStickyButton6_Click(sender As Object, e As EventArgs) Handles FlatStickyButton6.Click
        NewHome.Show()
        NewHome.Location = Me.Location
        Me.Close()
    End Sub

    Private Sub FlatStickyButton7_Click(sender As Object, e As EventArgs) Handles FlatStickyButton7.Click
        SetIniValue("Kubukkit", "ram", RamVaule.Text, "C:\KimuSoft\KuBukkit\bukkitdownloaddata.ini")
        Dim smallRam As Long = RamVaule.Text
        Dim RadioChecked As Long = 1
        If RadioButton3.Checked = True Then
            RadioChecked = 2
            smallRam = smallRam / 2
        ElseIf RadioButton1.Checked = True Then
            RadioChecked = 3
            smallRam = 512
        End If
        SetIniValue("Kubukkit", "smallram", smallRam.ToString, "C:\KimuSoft\KuBukkit\bukkitdownloaddata.ini")
        SetIniValue("Kubukkit", "smallramoption", RadioChecked.ToString, "C:\KimuSoft\KuBukkit\bukkitdownloaddata.ini")
        MsgBox("변경사항을 저장하였습니다.", vbInformation)
    End Sub
End Class
