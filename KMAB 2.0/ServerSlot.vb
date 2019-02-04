Imports System.ComponentModel

Public Class ServerSlot
    Private SelectTrue As Boolean = False
    Private ModTrue As Boolean = False
    Private SName As String = "Servername"
    Private PluginDefault As Byte = 0
    Private ModDefault As Byte = 0
    Private BukkitType As String = "CraftBukkit"
    Private MCVerVal As String = "1.0.0"
    Private DefaultIconing As Image
    Dim MainColor As Color = Color.FromArgb(23, 55, 94)

    <Category("SlotOption")>
    Public Property Selected As Boolean
        Get
            Return SelectTrue
        End Get
        Set(ByVal value As Boolean)
            For Each c As Control In NewHome.FlowLayoutPanel1.Controls
                If TryCast(c, ServerSlot).Selected = True And Not TryCast(c, ServerSlot).Name = Me.Name Then
                    TryCast(c, ServerSlot).Selected = False
                End If
            Next
            SelectTrue = value
            NewHome.ToMod.Visible = Me.CanMod
            Select Case Me.Selected
                Case True
                    ServerName.BackColor = MainColor 'Color.FromArgb(225, 125, 5)
                    Version.ForeColor = Color.WhiteSmoke
                    Type.ForeColor = Color.WhiteSmoke
                    'NewHome.ServerInfo.ForeColor = Color.WhiteSmoke
                    'NewHome.ServerInfo.Text = "' " + Me.NameOfServer + " ' 가 선택되었습니다."
                    NewHome.ToOpen.Visible = True
                    NewHome.ToPlugin.Visible = True
                    NewHome.ToConfig.Visible = True
                    NewHome.ServerDelete.BaseColor = Color.Maroon
                    NewHome.ServerDelete.Enabled = True
                Case False
                    ServerName.BackColor = Color.FromArgb(63, 63, 67)
                    Version.ForeColor = Color.Gray
                    Type.ForeColor = Color.Gray
                    'NewHome.ServerInfo.ForeColor = Color.Gray
                    'NewHome.ServerInfo.Text = "선택 된 서버가 없습니다. 서버를 선택 해 주세요."
                    NewHome.ToMod.Visible = False
                    NewHome.ToOpen.Visible = False
                    NewHome.ToPlugin.Visible = False
                    NewHome.ToConfig.Visible = False
                    NewHome.ServerDelete.BaseColor = Color.FromArgb(50, 50, 50)
                    NewHome.ServerDelete.Enabled = False
            End Select
        End Set
    End Property

    <Category("SlotOption")>
    Public Property CanMod As Boolean
        Get
            Return ModTrue
        End Get
        Set(ByVal value As Boolean)
            ModTrue = value
            Modvalue.Visible = Me.ModTrue
        End Set
    End Property

    <Category("SlotOption")>
    Public Property NameOfServer As String
        Get
            Return SName
        End Get
        Set(ByVal value As String)
            SName = value
            ServerName.Text = Me.NameOfServer
        End Set
    End Property

    <Category("SlotOption")>
    Public Property PluginsValue As Byte
        Get
            Return PluginDefault
        End Get
        Set(ByVal value As Byte)
            PluginDefault = value
            pluginvalue.Text = Me.PluginsValue.ToString + " Plugins"
        End Set
    End Property

    <Category("SlotOption")>
    Public Property ModsValue As Byte
        Get
            Return ModDefault
        End Get
        Set(ByVal value As Byte)
            ModDefault = value
            Modvalue.Text = Me.ModsValue.ToString + " Mods"
        End Set
    End Property

    <Category("SlotOption")>
    Public Property TypeOfBukkit As String
        Get
            Return BukkitType
        End Get
        Set(ByVal value As String)
            BukkitType = value
            Type.Text = Me.TypeOfBukkit
        End Set
    End Property

    <Category("SlotOption")>
    Public Property BukkitVersion As String
        Get
            Return MCVerVal
        End Get
        Set(ByVal value As String)
            MCVerVal = value
            Version.Text = "MineCraft " + Me.BukkitVersion
        End Set
    End Property

    <Category("SlotOption")>
    Public Property SerIcon As Image
        Get
            Return DefaultIconing
        End Get
        Set(ByVal value As Image)
            DefaultIconing = value
            Iconing.Image = SerIcon
        End Set
    End Property

    Private Sub ServerSlot_Enter(sender As Object, e As EventArgs) Handles MyBase.MouseEnter, Modvalue.MouseEnter, pluginvalue.MouseEnter, Version.MouseEnter, Type.MouseEnter, ServerName.MouseEnter
        Me.BackColor = Color.FromArgb(Me.BackColor.R + 5, Me.BackColor.G + 5, Me.BackColor.B + 5)
        ServerName.BackColor = Color.FromArgb(ServerName.BackColor.R + 5, ServerName.BackColor.G + 5, ServerName.BackColor.B + 5)
    End Sub

    Private Sub ServerSlot_Exit(sender As Object, e As EventArgs) Handles MyBase.MouseLeave, Modvalue.MouseLeave, pluginvalue.MouseLeave, Version.MouseLeave, Type.MouseLeave, ServerName.MouseLeave
        Me.BackColor = Color.FromArgb(Me.BackColor.R - 5, Me.BackColor.G - 5, Me.BackColor.B - 5)
        ServerName.BackColor = Color.FromArgb(ServerName.BackColor.R - 5, ServerName.BackColor.G - 5, ServerName.BackColor.B - 5)
    End Sub

    Private Sub ServerSlot_Load(sender As Object, e As EventArgs) Handles MyBase.Click, Modvalue.Click, pluginvalue.Click, Version.Click, Type.Click, ServerName.Click
        Select Case Me.Selected
            Case True
                Selected = False
            Case False
                Selected = True
        End Select
    End Sub

    Private Sub Iconing_Click(sender As Object, e As EventArgs) Handles Iconing.MouseEnter
        Iconing.BackColor = Color.FromArgb(73, 73, 77)
    End Sub

    Private Sub Iconing_Leave(sender As Object, e As EventArgs) Handles Iconing.MouseLeave
        Iconing.BackColor = Color.FromArgb(63, 63, 67)
    End Sub

    Private Sub Iconing_Click_1(sender As Object, e As EventArgs) Handles Iconing.Click
        If (OpenFileDialog1.ShowDialog() = DialogResult.OK) Then
            If Image.FromFile(OpenFileDialog1.FileName).Size = New Size(64, 64) Then
                My.Computer.FileSystem.CopyFile(OpenFileDialog1.FileName, "C:\KimuSoft\KuBukkit\server\" + Replace(ServerName.Text, " ", "_") + "\server-icon.png", True)
                Iconing.Image.Dispose()
                Iconing.Image = Image.FromFile("C:\KimuSoft\KuBukkit\server\" + Replace(ServerName.Text, " ", "_") + "\server-icon.png")
                Image.FromFile(OpenFileDialog1.FileName).Dispose()
            Else : MsgBox("서버 아이콘은 PNG 형식이고" + vbCr + "64 * 64 크기여야 합니다.", vbCritical)
            End If
        End If
    End Sub
End Class
