<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class NewDownloadtab4
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
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Step1Animation = New System.Windows.Forms.Timer(Me.components)
        Me.ColorMation = New System.Windows.Forms.Timer(Me.components)
        Me.ColorDownMation = New System.Windows.Forms.Timer(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Agree = New KMAB_2._0.FlatButton()
        Me.BukkitVer = New KMAB_2._0.FlatButton()
        Me.Bukkittype = New KMAB_2._0.FlatButton()
        Me.Servername = New KMAB_2._0.FlatButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Progresses = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.URLize = New System.Windows.Forms.Label()
        Me.progressTimer = New System.Windows.Forms.Timer(Me.components)
        Me.FlatProgressBar1 = New KMAB_2._0.FlatProgressBar()
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 14)
        Me.Label1.TabIndex = 80
        Me.Label1.Text = "<<ServerName>>"
        Me.Label1.Visible = False
        '
        'Timer2
        '
        Me.Timer2.Interval = 1
        '
        'Timer3
        '
        Me.Timer3.Interval = 1
        '
        'Agree
        '
        Me.Agree.BackColor = System.Drawing.Color.Transparent
        Me.Agree.BaseColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Agree.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Agree.Enabled = False
        Me.Agree.Font = New System.Drawing.Font("나눔고딕", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agree.Location = New System.Drawing.Point(0, 441)
        Me.Agree.Name = "Agree"
        Me.Agree.Rounded = False
        Me.Agree.Size = New System.Drawing.Size(669, 40)
        Me.Agree.TabIndex = 83
        Me.Agree.Text = "서버 생성 중..."
        Me.Agree.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'BukkitVer
        '
        Me.BukkitVer.BackColor = System.Drawing.Color.Transparent
        Me.BukkitVer.BaseColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.BukkitVer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BukkitVer.Enabled = False
        Me.BukkitVer.Font = New System.Drawing.Font("나눔고딕", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.BukkitVer.Location = New System.Drawing.Point(547, 7)
        Me.BukkitVer.Margin = New System.Windows.Forms.Padding(4)
        Me.BukkitVer.Name = "BukkitVer"
        Me.BukkitVer.Rounded = False
        Me.BukkitVer.Size = New System.Drawing.Size(113, 33)
        Me.BukkitVer.TabIndex = 8
        Me.BukkitVer.Tag = "9"
        Me.BukkitVer.Text = "1.4.7"
        Me.BukkitVer.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'Bukkittype
        '
        Me.Bukkittype.BackColor = System.Drawing.Color.Transparent
        Me.Bukkittype.BaseColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.Bukkittype.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Bukkittype.Enabled = False
        Me.Bukkittype.Font = New System.Drawing.Font("나눔고딕", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Bukkittype.Location = New System.Drawing.Point(547, 42)
        Me.Bukkittype.Margin = New System.Windows.Forms.Padding(4)
        Me.Bukkittype.Name = "Bukkittype"
        Me.Bukkittype.Rounded = False
        Me.Bukkittype.Size = New System.Drawing.Size(113, 34)
        Me.Bukkittype.TabIndex = 104
        Me.Bukkittype.Tag = "9"
        Me.Bukkittype.Text = "Spigot"
        Me.Bukkittype.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'Servername
        '
        Me.Servername.BackColor = System.Drawing.Color.Transparent
        Me.Servername.BaseColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.Servername.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Servername.Enabled = False
        Me.Servername.Font = New System.Drawing.Font("나눔고딕", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Servername.Location = New System.Drawing.Point(0, 412)
        Me.Servername.Margin = New System.Windows.Forms.Padding(4)
        Me.Servername.Name = "Servername"
        Me.Servername.Rounded = False
        Me.Servername.Size = New System.Drawing.Size(660, 30)
        Me.Servername.TabIndex = 105
        Me.Servername.Tag = "9"
        Me.Servername.Text = "새로운 서버"
        Me.Servername.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(368, 242)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 14)
        Me.Label2.TabIndex = 107
        Me.Label2.Text = "생성 중"
        '
        'Progresses
        '
        Me.Progresses.Font = New System.Drawing.Font("나눔고딕", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Progresses.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Progresses.Location = New System.Drawing.Point(251, 219)
        Me.Progresses.Name = "Progresses"
        Me.Progresses.Size = New System.Drawing.Size(125, 43)
        Me.Progresses.TabIndex = 108
        Me.Progresses.Text = "100%"
        Me.Progresses.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("나눔고딕", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(238, 262)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(187, 21)
        Me.Label4.TabIndex = 109
        Me.Label4.Text = "파일 다운로드 작업 중"
        '
        'URLize
        '
        Me.URLize.AutoSize = True
        Me.URLize.Font = New System.Drawing.Font("나눔고딕", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.URLize.Location = New System.Drawing.Point(12, 75)
        Me.URLize.Name = "URLize"
        Me.URLize.Size = New System.Drawing.Size(57, 14)
        Me.URLize.TabIndex = 111
        Me.URLize.Text = "<<URL>>"
        Me.URLize.Visible = False
        '
        'progressTimer
        '
        Me.progressTimer.Interval = 1
        '
        'FlatProgressBar1
        '
        Me.FlatProgressBar1.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.FlatProgressBar1.DarkerProgress = System.Drawing.Color.OliveDrab
        Me.FlatProgressBar1.Location = New System.Drawing.Point(1, 370)
        Me.FlatProgressBar1.Maximum = 100
        Me.FlatProgressBar1.Name = "FlatProgressBar1"
        Me.FlatProgressBar1.ProgressColor = System.Drawing.Color.OliveDrab
        Me.FlatProgressBar1.Size = New System.Drawing.Size(658, 42)
        Me.FlatProgressBar1.TabIndex = 112
        Me.FlatProgressBar1.Text = "FlatProgressBar1"
        Me.FlatProgressBar1.Value = 0
        '
        'NewDownloadtab4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(660, 480)
        Me.Controls.Add(Me.BukkitVer)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Servername)
        Me.Controls.Add(Me.Bukkittype)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Agree)
        Me.Controls.Add(Me.Progresses)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.URLize)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.FlatProgressBar1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("나눔고딕", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "NewDownloadtab4"
        Me.Opacity = 0R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Step1Animation As Timer
    Friend WithEvents ColorMation As Timer
    Friend WithEvents ColorDownMation As Timer
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents Agree As FlatButton
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Timer3 As Timer
    Friend WithEvents BukkitVer As FlatButton
    Friend WithEvents Bukkittype As FlatButton
    Friend WithEvents Servername As FlatButton
    Friend WithEvents Label2 As Label
    Friend WithEvents Progresses As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents URLize As Label
    Friend WithEvents progressTimer As Timer
    Friend WithEvents FlatProgressBar1 As FlatProgressBar
End Class
