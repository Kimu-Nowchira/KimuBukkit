Imports System.ComponentModel
Imports System.Runtime.InteropServices
Imports System.Text

Public Class BukkitType
    Private SelectTrue As Boolean = False
    Private BukkitTrue As String = "DefaultName"
    Dim usedatingver As String = Replace(GetIniValue("Kubukkit", "usebukkitdataversion", "C:\KimuSoft\KuBukkit\bukkitdownloaddata.ini"), ".", "")

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

    <Category("SlotOption")>
    Public Property Selected As Boolean
        Get
            Return SelectTrue
        End Get
        Set(ByVal value As Boolean)
            'For Each c As Control In NewDownloadtab5.VersionListPanel.Controls
            '    If TryCast(c, VersionButton1).Selected = True And Not TryCast(c, VersionButton1).Name = Me.Name Then
            '        TryCast(c, VersionButton1).Selected = False
            '    End If
            'Next
            SelectTrue = value
            Select Case Me.Selected
                Case True
                    OpenMyV()
                    PictureBox1.BackColor = Color.OliveDrab
                Case False
                    PictureBox1.BackColor = Color.FromArgb(80, 80, 87)
            End Select
        End Set
    End Property

    <Category("SlotOption")>
    Public Property BukkitName As String
        Get
            Return BukkitTrue
        End Get
        Set(ByVal value As String)
            Me.FlatButton1.Text = value
            Me.FlatButton1.Enabled = False
            Me.FlatButton1.Enabled = True
            BukkitTrue = value
        End Set
    End Property

    Private Sub FlatButton1_Click(sender As Object, e As EventArgs) Handles FlatButton1.Click
        For Each c As Control In NewDownloadtab5.FlowLayoutPanel1.Controls
            TryCast(c, BukkitType).Selected = False
        Next
        Me.Selected = True
    End Sub

    Private Sub OpenMyV()
        For Each c As Control In NewDownloadtab5.VersionListPanel.Controls
            TryCast(c, VersionButton1).Selected = False
        Next
        For Each c As Control In NewDownloadtab5.VersionListPanel.Controls
            TryCast(c, VersionButton1).Visible = False
            TryCast(c, VersionButton1).Dispose()
            TryCast(c, VersionButton1).Controls.Clear()

        Next

        NewDownloadtab5.VersionListPanel.Controls.Clear()

        For i As Integer = 1 To 1000
            If GetIniValue(Me.FlatButton1.Text, "ver" & i.ToString, "C:\KimuSoft\KuBukkit\URLdata" + usedatingver + ".ini") = "" Or GetIniValue(Me.FlatButton1.Text, "ver" & i, "C:\KimuSoft\KuBukkit\URLdata" + usedatingver + ".ini") = "null" Then
                Exit For
            End If
            Dim MakeSlot As New VersionButton1
            With MakeSlot
                .Name = "BukkitTyping" & i
                .URLdating = Split(GetIniValue(Me.FlatButton1.Text, "ver" & i, "C:\KimuSoft\KuBukkit\URLdata" + usedatingver + ".ini"), "\")(1)
                .MyVersion = Split(GetIniValue(Me.FlatButton1.Text, "ver" & i, "C:\KimuSoft\KuBukkit\URLdata" + usedatingver + ".ini"), "\")(0)
                .Selected = False

            End With
            If GetIniValue(Me.FlatButton1.Text, "twoblock", "C:\KimuSoft\KuBukkit\URLdata" + usedatingver + ".ini") = "true" Then
                MakeSlot.Doubleopt = True
            End If

            If i = 1 Then
                MakeSlot.Selected = True
            End If
            NewDownloadtab5.VersionListPanel.Controls.Add(MakeSlot)
        Next
    End Sub
End Class
