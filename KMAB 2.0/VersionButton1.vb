Imports System.ComponentModel

Public Class VersionButton1
    Private SelectTrue As Boolean = False
    Private Doubleop As Boolean = False
    Private URLdt As String = "None"
    Private myverwhat As String = "0.0.0"
    Private URL As String = "null"

    <Category("SlotOption")>
    Public Property Selected As Boolean
        Get
            Return SelectTrue
        End Get
        Set(ByVal value As Boolean)
            SelectTrue = value
            Select Case Me.Selected
                Case True
                    FlatButton1.BaseColor = Color.OliveDrab
                Case False
                    FlatButton1.BaseColor = Color.FromArgb(50, 50, 53)
            End Select
            FlatButton1.Enabled = False
            FlatButton1.Enabled = True
        End Set
    End Property

    <Category("SlotOption")>
    Public Property Doubleopt As Boolean
        Get
            Return Doubleop
        End Get
        Set(ByVal value As Boolean)
            Doubleop = value
            Select Case value
                Case True
                    Me.Size = New Size(226, 35)
                    FlatButton1.Size = New Size(226, 35)
                Case False
                    Me.Size = New Size(90, 35)
                    FlatButton1.Size = New Size(90, 35)
            End Select
        End Set
    End Property

    <Category("SlotOption")>
    Public Property URLdating As String
        Get
            Return URLdt
        End Get
        Set(ByVal value As String)
            URLdt = value
        End Set
    End Property

    <Category("SlotOption")>
    Public Property MyVersion As String
        Get
            Return myverwhat
        End Get
        Set(ByVal value As String)
            FlatButton1.Text = value
            myverwhat = value
        End Set
    End Property

    Private Sub ServerSlot_Load(sender As Object, e As EventArgs)
        Select Case Me.Selected
            Case True
                Selected = False
            Case False
                Selected = True
        End Select
    End Sub

    Private Sub FlatButton1_Click(sender As Object, e As EventArgs) Handles FlatButton1.Click
        For Each c As Control In NewDownloadtab5.VersionListPanel.Controls
            TryCast(c, VersionButton1).Selected = False
        Next
        Me.Selected = True
    End Sub
End Class

