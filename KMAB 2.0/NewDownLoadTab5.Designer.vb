<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class NewDownloadtab5
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기를 사용하여 수정하지 마십시오.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.NewInfo = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Step1Animation = New System.Windows.Forms.Timer(Me.components)
        Me.VersionListPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.ColorMation = New System.Windows.Forms.Timer(Me.components)
        Me.ColorDownMation = New System.Windows.Forms.Timer(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.servername = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.NonAgge = New KMAB_2._0.FlatButton()
        Me.Agree = New KMAB_2._0.FlatButton()
        Me.ReDownC = New KMAB_2._0.FlatCheckBox()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Image = Global.KMAB_2._0.My.Resources.Resources.Logo
        Me.PictureBox2.Location = New System.Drawing.Point(0, 5)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(540, 106)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 39
        Me.PictureBox2.TabStop = False
        '
        'NewInfo
        '
        Me.NewInfo.AutoSize = True
        Me.NewInfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.NewInfo.ForeColor = System.Drawing.Color.LightGray
        Me.NewInfo.Location = New System.Drawing.Point(133, 19)
        Me.NewInfo.Name = "NewInfo"
        Me.NewInfo.Size = New System.Drawing.Size(0, 14)
        Me.NewInfo.TabIndex = 62
        '
        'ToolTip1
        '
        Me.ToolTip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.ToolTipTitle = "키뮤버킷 팁"
        '
        'Step1Animation
        '
        Me.Step1Animation.Interval = 2
        '
        'VersionListPanel
        '
        Me.VersionListPanel.AutoScroll = True
        Me.VersionListPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.VersionListPanel.Location = New System.Drawing.Point(181, 127)
        Me.VersionListPanel.Name = "VersionListPanel"
        Me.VersionListPanel.Size = New System.Drawing.Size(472, 295)
        Me.VersionListPanel.TabIndex = 71
        '
        'ColorMation
        '
        Me.ColorMation.Interval = 1
        '
        'ColorDownMation
        '
        Me.ColorDownMation.Interval = 1
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'servername
        '
        Me.servername.AutoSize = True
        Me.servername.Location = New System.Drawing.Point(9, 13)
        Me.servername.Name = "servername"
        Me.servername.Size = New System.Drawing.Size(104, 14)
        Me.servername.TabIndex = 80
        Me.servername.Text = "<<ServerName>>"
        Me.servername.Visible = False
        '
        'Timer2
        '
        Me.Timer2.Interval = 1
        '
        'Timer3
        '
        Me.Timer3.Interval = 1
        '
        'NonAgge
        '
        Me.NonAgge.BackColor = System.Drawing.Color.Transparent
        Me.NonAgge.BaseColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.NonAgge.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NonAgge.Font = New System.Drawing.Font("나눔고딕", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NonAgge.Location = New System.Drawing.Point(1, 441)
        Me.NonAgge.Name = "NonAgge"
        Me.NonAgge.Rounded = False
        Me.NonAgge.Size = New System.Drawing.Size(333, 40)
        Me.NonAgge.TabIndex = 84
        Me.NonAgge.Text = "홈으로 돌아가기"
        Me.NonAgge.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'Agree
        '
        Me.Agree.BackColor = System.Drawing.Color.Transparent
        Me.Agree.BaseColor = System.Drawing.Color.OliveDrab
        Me.Agree.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Agree.Font = New System.Drawing.Font("나눔고딕", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agree.Location = New System.Drawing.Point(328, 441)
        Me.Agree.Name = "Agree"
        Me.Agree.Rounded = False
        Me.Agree.Size = New System.Drawing.Size(341, 40)
        Me.Agree.TabIndex = 83
        Me.Agree.Text = "서버 생성"
        Me.Agree.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'ReDownC
        '
        Me.ReDownC.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ReDownC.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.ReDownC.BorderColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.ReDownC.Checked = False
        Me.ReDownC.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ReDownC.Font = New System.Drawing.Font("나눔고딕", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.ReDownC.ForeColor = System.Drawing.Color.Gray
        Me.ReDownC.Location = New System.Drawing.Point(633, 5)
        Me.ReDownC.Name = "ReDownC"
        Me.ReDownC.Options = KMAB_2._0.FlatCheckBox._Options.Style1
        Me.ReDownC.Size = New System.Drawing.Size(20, 22)
        Me.ReDownC.TabIndex = 79
        Me.ReDownC.Visible = False
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoScroll = True
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(12, 127)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(163, 295)
        Me.FlowLayoutPanel1.TabIndex = 85
        '
        'NewDownloadtab5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(660, 480)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.NewInfo)
        Me.Controls.Add(Me.NonAgge)
        Me.Controls.Add(Me.Agree)
        Me.Controls.Add(Me.VersionListPanel)
        Me.Controls.Add(Me.ReDownC)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.servername)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("나눔고딕", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "NewDownloadtab5"
        Me.Opacity = 0R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "*"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents NewInfo As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Step1Animation As Timer
    Friend WithEvents VersionListPanel As FlowLayoutPanel
    Friend WithEvents ColorMation As Timer
    Friend WithEvents ColorDownMation As Timer
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ReDownC As FlatCheckBox
    Friend WithEvents servername As Label
    Friend WithEvents NonAgge As FlatButton
    Friend WithEvents Agree As FlatButton
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Timer3 As Timer
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
End Class
