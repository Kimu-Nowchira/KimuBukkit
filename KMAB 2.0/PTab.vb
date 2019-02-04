Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Text

Public Class PTab
    Dim ptmcu, ptmnew, ptfcu, ptfnew As Point
    Dim aa As Boolean = False
    Dim Filename As String
    Dim Ess As String
    Dim PlT152 As String
    Dim A As String
    Dim Pio As Long

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

    Private Sub pluginsTab_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.MyIcon48
        Servername.Text = GetIniValue("Slot" & SlotNumber.Text, "servername", "C:\KimuSoft\KuBukkit\Serverinfor.ini")
        Timer1.Start()
        If Not System.IO.Directory.Exists("C:\KimuSoft\KuBukkit\server\" + Replace(Servername.Text, " ", "_") + "\plugins") Then
            MkDir("C:\KimuSoft\KuBukkit\server\" + Replace(Servername.Text, " ", "_") + "\plugins")
        End If
        DirSer()
        FlatButton4.Text = GetIniValue("slot1", "pluginsvalue", "C:\KimuSoft\KuBukkit\Serverinfor.ini") + " plugins"
        Dim Laugh As String = System.IO.Directory.GetFiles("C:\KimuSoft\KuBukkit\server\" + Replace(Servername.Text, " ", "_") + "\plugins").Length
        SetIniValue("slot" + SlotNumber.Text, "pluginsvalue", Laugh, "C:\KimuSoft\KuBukkit\Serverinfor.ini")
        FlatButton4.Text = Laugh + " Plugins"
        FlatButton4.Enabled = False
        FlatButton4.Enabled = True
    End Sub

    Private Sub DirSer()
        ListView1.Clear()
        Dim Dl As String
        Dim di As New IO.DirectoryInfo("C:\KimuSoft\KuBukkit\server\" + Replace(Servername.Text, " ", "_") + "\plugins")
        Dim diar1 As IO.FileInfo() = di.GetFiles()
        Dim dra As IO.FileInfo
        For Each dra In diar1
            Dl = dra.ToString
            If Not Replace(Dl, ".zip", "") = Dl Then  '이미지 파일 확장자에 이 파일이 포함될 때
                ListView1.Items.Add(Dl)
                ImageList1.Images.Add(My.Resources.ICON_ZIP)
                ListView1.Items.Item(ListView1.Items.Count - 1).ImageIndex = ImageList1.Images.Count - 1
            ElseIf Not Replace(Dl, ".jar", "") = Dl Then
                ListView1.Items.Add(Dl)
                ImageList1.Images.Add(My.Resources.ICON_JAR)
                ListView1.Items.Item(ListView1.Items.Count - 1).ImageIndex = ImageList1.Images.Count - 1
            Else
                ListView1.Items.Add(Dl)
                ImageList1.Images.Add(My.Resources.error_icon)
                ListView1.Items.Item(ListView1.Items.Count - 1).ImageIndex = ImageList1.Images.Count - 1
            End If
        Next

        Dim Laugh As String = System.IO.Directory.GetFiles("C:\KimuSoft\KuBukkit\server\" + Replace(Servername.Text, " ", "_") + "\plugins").Length
        SetIniValue("slot" + SlotNumber.Text, "pluginsvalue", Laugh, "C:\KimuSoft\KuBukkit\Serverinfor.ini")
        FlatButton4.Text = Laugh + " Plugins"
        FlatButton4.Enabled = False
        FlatButton4.Enabled = True
    End Sub

    Private Sub FlatStickyButton6_Click(sender As Object, e As EventArgs) Handles FlatStickyButton6.Click
        NewHome.Show()
        NewHome.Location = Me.Location
        Me.Close()
    End Sub

    'Private Sub FlatButton6_Click(sender As Object, e As EventArgs) Handles FlatButton6.Click
    '    Dim A As String = FlatListBox2.SelectedItem
    '    If Not A = "" Then
    '        Kill("C:\KimuSoft\KuBukkit\server\" + Replace(Servername.Text, " ", "_") + "\plugins\" + A)
    '        DirSer()
    '    ElseIf A = "" Then
    '        MsgBox("삭제할 플러그인을 선택 해주세요.", vbInformation)
    '    ElseIf Not System.IO.File.Exists("C:\KimuSoft\KuBukkit\server\" + Replace(Servername.Text, " ", "_") + "\plugins\" + A) Then
    '        MsgBox("지정한 모드가 존재하지 않습니다.")
    '        DirSer()
    '    End If
    'End Sub

    Private Sub FlatButton2_Click(sender As Object, e As EventArgs) Handles FlatButton2.Click
        DirSer()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Not Me.Opacity = 1 Then
            Me.Opacity = Me.Opacity + 0.04
        Else : NewHome.Close()
            Timer1.Stop()
        End If
    End Sub

    Private Sub Label6_Mouseleave(sender As Object, e As EventArgs) Handles Label6.MouseLeave
        Label6.BackColor = Color.FromArgb(Label6.BackColor.R - 20, Label6.BackColor.G - 20, Label6.BackColor.B - 20)
    End Sub

    Private Sub FlatButton6_Click(sender As Object, e As EventArgs) Handles FlatButton6.Click
        For Each Item As ListViewItem In ListView1.SelectedItems
            File.Delete("C:\KimuSoft\KuBukkit\server\" + Replace(Servername.Text, " ", "_") + "\plugins\" + Item.Text.ToString())
            Item.Remove()
        Next
        DirSer()
    End Sub

    Private Sub FlatButton3_Click(sender As Object, e As EventArgs) Handles FlatButton3.Click
        Shell("explorer C:\Kimusoft\KuBukkit\server\" + Replace(Servername.Text, " ", "_") + "\plugins", vbNormalFocus)
    End Sub

    Private Sub FlatButton1_Click(sender As Object, e As EventArgs) Handles FlatButton1.Click
        If (OpenFileDialog1.ShowDialog() = DialogResult.OK) Then
            If System.IO.File.Exists("C:\KimuSoft\KuBukkit\server\" + Replace(Servername.Text, " ", "_") + "\plugins\" + OpenFileDialog1.SafeFileName) Then
                MsgBox("아무래도, 이미 적용된 모드인 것 같습니다.", vbInformation)
                Exit Sub
            End If
            My.Computer.FileSystem.CopyFile(OpenFileDialog1.FileName, "C:\KimuSoft\KuBukkit\server\" + Replace(Servername.Text, " ", "_") + "\plugins\" + OpenFileDialog1.SafeFileName)
            DirSer()
        End If
        'If System.IO.File.Exists(OpenFileDialog1.FileName) Then
        '    Dim ini As Long = GetIniValue("slot" + SlotNumber.Text, "pluginsvalue", "C:\KimuSoft\KuBukkit\Serverinfor.ini")
        '    SetIniValue("slot" + SlotNumber.Text, "pluginsvalue", ini + 1, "C:\KimuSoft\KuBukkit\Serverinfor.ini")
        '    FlatButton4.Text = GetIniValue("slot" + SlotNumber.Text, "pluginsvalue", "C:\KimuSoft\KuBukkit\Serverinfor.ini") + " plugins"
        'End If
    End Sub

    Private Sub Label2_Mouseleave(sender As Object, e As EventArgs) Handles Label6.MouseEnter
        Label6.BackColor = Color.FromArgb(Label6.BackColor.R + 20, Label6.BackColor.G + 20, Label6.BackColor.B + 20)
    End Sub

    Private Sub ListView1_DragDrop(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles ListView1.DragDrop
        Dim drop As String() = CType(e.Data.GetData(DataFormats.FileDrop), String())
        For Each Filename As String In drop
            Dim fileExtension As String = Path.GetExtension(Filename)
            If System.IO.File.Exists("C:\KimuSoft\KuBukkit\server\" + Replace(Servername.Text, " ", "_") + "\plugins\" + Path.GetFileName(Filename)) Then
                MsgBox("아무래도 이미 적용된 모드인 것 같습니다.", vbInformation)
                Exit Sub
            End If
            If Not fileExtension = ".jar" Or Not fileExtension = ".zip" Then
                If MessageBox.Show("이 확장자는 올바른 모드 파일에 대한 확장자가 아닙니다." + vbCr + "그래도 추가하시겠습니까?", "알림", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) = vbOK Then
                Else : Exit Sub
                End If
            End If
            My.Computer.FileSystem.CopyFile(Filename, "C:\KimuSoft\KuBukkit\server\" + Replace(Servername.Text, " ", "_") + "\plugins\" + Path.GetFileName(Filename))
            'Dim fileExtension As String = Path.GetExtension(Filename)
            'If fileExtension = ".zip" Then '이미지 파일 확장자에 이 파일이 포함될 때
            '    ListView1.Items.Add(Path.GetFileNameWithoutExtension(Filename))
            '    ImageList1.Images.Add(My.Resources.ICON_ZIP)
            '    ListView1.Items.Item(ListView1.Items.Count - 1).ImageIndex = ImageList1.Images.Count - 1
            'ElseIf fileExtension = ".jar" Then
            '    ListView1.Items.Add(Path.GetFileNameWithoutExtension(Filename))
            '    ImageList1.Images.Add(My.Resources.ICON_JAR)
            '    ListView1.Items.Item(ListView1.Items.Count - 1).ImageIndex = ImageList1.Images.Count - 1
            'Else ListView1.Items.Add(Path.GetFileNameWithoutExtension(Filename))
            'End If
        Next
        DirSer()
    End Sub

    Private Sub ListBox1_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles ListView1.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub
End Class
