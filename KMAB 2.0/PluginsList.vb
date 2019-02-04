Imports System.ComponentModel
Imports System.Net
Imports System.Runtime.InteropServices
Imports System.Text

Public Class PluginsList
    Shared Property PluginDown As New WebClient
    Private PluginURLDefault As String = "http://"
    Private PlguinEnglish As String = "EnglishName"
    Private PluginKorean As String = "KoreanName"
    Private PluginVersionIS As String = "1.5.2"
    Private PluginInstalled As Boolean = False
    Private OnlyPlguinsVersionValue As String = "?"

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

    <Category("PlusOption")>
    Public Property PluginKorName As String
        Get
            Return PluginKorean
        End Get
        Set(ByVal value As String)
            PluginKorean = value
            NameButton.Text = Me.PluginEngName + " / " + Me.PluginKorName + " ( " + Me.OnlyPluginVer + " )"
        End Set
    End Property

    <Category("PlusOption")>
    Public Property PluginEngName As String
        Get
            Return PlguinEnglish
        End Get
        Set(ByVal value As String)
            PlguinEnglish = value
            NameButton.Text = Me.PluginEngName + " / " + Me.PluginKorName + " ( " + Me.OnlyPluginVer + " )"
        End Set
    End Property

    <Category("PlusOption")>
    Public Property PluginVersion As String
        Get
            Return PluginVersionIS
        End Get
        Set(ByVal value As String)
            PluginVersionIS = value
            Version.Text = Me.PluginVersion
        End Set
    End Property

    <Category("PlusOption")>
    Public Property PluginInstall As Boolean
        Get
            Return PluginInstalled
        End Get
        Set(ByVal value As Boolean)
            PluginInstalled = value
            Select Case value
                Case True
                    Instmov.BaseColor = Color.OliveDrab
                    Instmov.Text = "삭제"
                Case False
                    Instmov.BaseColor = Color.FromArgb(80, 80, 80)
                    Instmov.Text = "설치"
            End Select
        End Set
    End Property

    <Category("PlusOption")>
    Public Property PluginURL As String
        Get
            Return PluginURLDefault
        End Get
        Set(ByVal value As String)
            PluginURLDefault = value
        End Set
    End Property

    <Category("PlusOption")>
    Public Property OnlyPluginVer As String
        Get
            Return OnlyPlguinsVersionValue
        End Get
        Set(ByVal value As String)
            OnlyPlguinsVersionValue = value
            NameButton.Text = Me.PluginEngName + " / " + Me.PluginKorName + " ( " + Me.OnlyPluginVer + " )"
        End Set
    End Property

    Private Sub Instmov_Click(sender As Object, e As EventArgs) Handles Instmov.Click
        If Me.PluginInstall = False Then
            If System.IO.File.Exists("C:\KimuSoft\KuBukkit\pluginslib\" & Me.PluginEngName & Me.PluginVersion & ".jar") Then
                DownOK()
                Exit Sub
            End If

            AddHandler PluginDown.DownloadProgressChanged, AddressOf DownLoading
            AddHandler PluginDown.DownloadFileCompleted, AddressOf DownOK
            NewPluginsTab.FlowLayoutPanel1.Enabled = False
            NewPluginsTab.CloseForm.Enabled = False
            NewPluginsTab.PictureBox2.BackColor = Color.OliveDrab
            NewPluginsTab.Label14.Text = "다운 중..."
            My.Computer.FileSystem.CreateDirectory("C:\KimuSoft\KuBukkit\server\" + Replace(NewPluginsTab.servername.Text, " ", "_") + "\plugins")
            Try
                PluginDown.DownloadFileAsync(New Uri(Me.PluginURL), "C:\KimuSoft\KuBukkit\pluginslib\" & Me.PluginEngName & Me.PluginVersion & ".jar")
            Catch ex As Exception
                MsgBox(ex.Message, vbCritical)
            End Try
        Else Dim Exi2 As String = Me.PlguinEnglish + Me.PluginVersion + ".jar"
            If System.IO.File.Exists("C:\KimuSoft\KuBukkit\server\" + Replace(NewPluginsTab.servername.Text, " ", "_") + "\plugins\" + Exi2) Then
                Kill("C:\KimuSoft\KuBukkit\server\" + Replace(NewPluginsTab.servername.Text, " ", "_") + "\plugins\" + Exi2)
            End If
            DirSerach()
                Me.PluginInstall = False
            End If
    End Sub

    Private Sub DownLoading(sender As Object, e As DownloadProgressChangedEventArgs)
        NewPluginsTab.FlatProgressBar1.Maximum = e.TotalBytesToReceive
        NewPluginsTab.FlatProgressBar1.Value = e.BytesReceived
    End Sub

    Private Sub DownOK()
        Dim Exi2 As String = Me.PlguinEnglish + Me.PluginVersion + ".jar"
        My.Computer.FileSystem.CopyFile("C:\KimuSoft\KuBukkit\pluginslib\" & Me.PluginEngName & Me.PluginVersion & ".jar", "C:\KimuSoft\KuBukkit\server\" + Replace(NewPluginsTab.servername.Text, " ", "_") + "\plugins\" + Exi2, True)
        NewPluginsTab.FlowLayoutPanel1.Enabled = True
        NewPluginsTab.CloseForm.Enabled = True
        Me.PluginInstall = True
        NewPluginsTab.FlatProgressBar1.Value = 0
        RemoveHandler PluginDown.DownloadProgressChanged, AddressOf DownLoading
        NewPluginsTab.PictureBox2.BackColor = Color.FromArgb(69, 70, 70)
        Me.Enabled = False
        Me.Enabled = True
        DirSerach()
    End Sub

    Private Sub DirSerach()
        Dim Laugh As String = System.IO.Directory.GetFiles("C:\KimuSoft\KuBukkit\server\" + Replace(NewPluginsTab.servername.Text, " ", "_") + "\plugins").Length
        SetIniValue("slot" + NewPluginsTab.SlotNumber.Text, "pluginsvalue", Laugh, "C:\KimuSoft\KuBukkit\Serverinfor.ini")
        NewPluginsTab.Label14.Text = Laugh + "개의 플러그인"
    End Sub

    Private Sub NameButton_Click(sender As Object, e As EventArgs) Handles NameButton.Click

    End Sub
End Class
