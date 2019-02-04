Public Class NewCMDForm
    Dim ptmcu As Point
    Dim ptmnew As Point
    Dim ptfcu As Point
    Dim ptfnew As Point
    Dim aa As Boolean = False
    Dim A, B, C, D, E, F, M As String
    Dim SelectForm As Panel

    Private Sub picturebox3_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown, Label1.MouseDown, Label2.MouseDown
        If e.Button = MouseButtons.Left Then
            aa = True
            ptmcu = Control.MousePosition
            ptfcu = Me.Location
        End If
    End Sub

    Private Sub PictureBox3_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove, Label1.MouseMove, Label2.MouseMove
        If aa = True Then
            ptmnew = Control.MousePosition
            ptfnew.X = ptmnew.X - ptmcu.X + ptfcu.X
            ptfnew.Y = ptmnew.Y - ptmcu.Y + ptfcu.Y
            Me.Location = ptfnew
            ptfcu = ptfnew
            ptmcu = ptmnew
        End If
    End Sub

    Private Sub PictureBox3_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp, Label1.MouseUp, Label2.MouseUp
        If e.Button = MouseButtons.Left Then
            aa = False
        End If
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Select Case ListBox1.SelectedItem
            Case "서버 공지 ( /Say )"
                A = "/Say"
                DataClean()
                Says.Visible = True
            Case "서버 닫기 ( /Stop )"
                A = "/Stop"
                DataClean()
            Case "서버 재시작 ( /Reload )"
                A = "/Reload"
                DataClean()
            Case "귓속말 ( /Tell )"
                A = "/Tell"
                DataClean()
                ToWho.Visible = True
                Says.Visible = True
            Case "텔레포트 ( /TP )"
                A = "/TP"
                DataClean()
                Who.Visible = True
                ToWho.Visible = True
            Case "닉네임 추방 ( /Ban )"
                A = "/Ban"
                DataClean()
                Who.Visible = True
            Case "IP 추방 ( /IP-Ban )"
                A = "/IP-Ban"
                DataClean()
                Who.Visible = True
            Case "월드 저장 ( /Save-ALL )"
                A = "/Save-ALL"
                DataClean()
            Case "절대 권한 ( /OP )"
                A = "/OP"
                DataClean()
                ToWho.Visible = True
            Case "권한 뺏기 ( /DeOP )"
                A = "/DeOP"
                DataClean()
                Who.Visible = True
            Case "버킷 창 클리어 ( /cleartext )"
                A = "/cleartext"
                DataClean()
            Case "서버 맵 열기 ( /openmap )"
                A = "/openmap"
                DataClean()
        End Select
    End Sub

    Private Sub DataClean()
        Who.Visible = False
        ToWho.Visible = False
        What.Visible = False
        Val.Visible = False
        Says.Visible = False
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        M = A

        FlatButton1.Text = A
        FlatButton1.Enabled = False
        FlatButton1.Enabled = True
    End Sub

    Private Sub NewCMDForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = My.Resources.MyIcon48
    End Sub

    Private Sub ReloadText()
        FlatButton1.Enabled = False
        FlatButton1.Enabled = True
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
        Select Case ListBox1.SelectedItem
            Case "서버 공지 ( /Say )"
                F = TextBox5.Text
                M = A + " " + F
                FlatButton1.Text = M
                ReloadText()
            Case "귓속말 ( /Tell )"
                F = TextBox5.Text
                M = A + " " + C + " " + F
                FlatButton1.Text = M
                ReloadText()
        End Select
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        Select Case ListBox1.SelectedItem
            Case "귓속말 ( /Tell )"
                C = TextBox2.Text
                M = A + " " + C + " " + F
                FlatButton1.Text = M
                ReloadText()
            Case "텔레포트 ( /TP )"
                C = TextBox2.Text
                M = A + " " + B + " " + C
                FlatButton1.Text = M
                ReloadText()
            Case "절대 권한 ( /OP )"
                C = TextBox2.Text
                M = A + " " + C
                FlatButton1.Text = M
                ReloadText()
            Case "권한 뺏기 ( /DeOP )"
                C = TextBox2.Text
                M = A + " " + C
                FlatButton1.Text = M
                ReloadText()
        End Select
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Select Case ListBox1.SelectedItem
            Case "텔레포트 ( /TP )"
                B = TextBox1.Text
                M = A + " " + B + " " + C
                FlatButton1.Text = M
                ReloadText()
            Case "닉네임 추방 ( /Ban )"
                B = TextBox1.Text
                M = A + " " + B
                FlatButton1.Text = M
                ReloadText()
            Case "IP 추방 ( /IP-Ban )"
                B = TextBox1.Text
                M = A + " " + B
                FlatButton1.Text = M
                ReloadText()
        End Select
    End Sub

    'Private Sub NewCMDForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    Timer1.Start()
    'End Sub

    'Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
    '    Panel1.Location = New Point(Panel1.Location.X + 1, 0)
    '    Timer1.Interval = Timer1.Interval - 1
    'End Sub

    Private Sub FlatButton1_Click(sender As Object, e As EventArgs) Handles FlatButton1.Click
        M = Replace(M, "/", "")
        NewForm22.TextBox1.Text = M
        NewForm22.Show()
        NewForm22.Location = Me.Location
        Me.Close()
    End Sub

    Private Sub FlatStickyButton6_Click(sender As Object, e As EventArgs) Handles FlatStickyButton6.Click
        NewForm22.Show()
        Me.Close()
    End Sub
End Class