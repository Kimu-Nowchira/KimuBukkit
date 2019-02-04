<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class NewHome
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
    '코드 편집기에서는 수정하지 마세요.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.UpTimer = New System.Windows.Forms.Timer(Me.components)
        Me.DownTimer = New System.Windows.Forms.Timer(Me.components)
        Me.LogoExit = New System.Windows.Forms.Timer(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.NumberUP = New System.Windows.Forms.Timer(Me.components)
        Me.JavaSearch = New System.Windows.Forms.OpenFileDialog()
        Me.FlatButton1 = New KMAB_2._0.FlatButton()
        Me.FlatButton6 = New KMAB_2._0.FlatButton()
        Me.FlatButton3 = New KMAB_2._0.FlatButton()
        Me.FlatStickyButton6 = New KMAB_2._0.FlatStickyButton()
        Me.ToMod = New KMAB_2._0.FlatStickyButton()
        Me.ToPlugin = New KMAB_2._0.FlatStickyButton()
        Me.ToConfig = New KMAB_2._0.FlatStickyButton()
        Me.ToOpen = New KMAB_2._0.FlatStickyButton()
        Me.ServerDelete = New KMAB_2._0.FlatButton()
        Me.FlatStickyButton7 = New KMAB_2._0.FlatStickyButton()
        Me.FlatButton11 = New KMAB_2._0.FlatButton()
        Me.UpdateINFO = New KMAB_2._0.FlatButton()
        Me.NEWVer = New KMAB_2._0.FlatButton()
        Me.MyRAM = New KMAB_2._0.FlatButton()
        Me.FlatButton2 = New KMAB_2._0.FlatButton()
        Me.FlatButton4 = New KMAB_2._0.FlatButton()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.FlatButton5 = New KMAB_2._0.FlatButton()
        Me.VersionLabel = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Image = Global.KMAB_2._0.My.Resources.Resources.Logo
        Me.PictureBox2.Location = New System.Drawing.Point(-3, -5)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(674, 135)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 95
        Me.PictureBox2.TabStop = False
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlowLayoutPanel1.AutoScroll = True
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(33, 174)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(658, 217)
        Me.FlowLayoutPanel1.TabIndex = 98
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("나눔고딕", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkGray
        Me.Label4.Location = New System.Drawing.Point(19, 143)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 15)
        Me.Label4.TabIndex = 148
        Me.Label4.Text = "찾을 서버를 입력"
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("나눔고딕", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.TextBox1.Location = New System.Drawing.Point(16, 143)
        Me.TextBox1.MaxLength = 40
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(628, 19)
        Me.TextBox1.TabIndex = 147
        '
        'PictureBox3
        '
        Me.PictureBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.PictureBox3.Location = New System.Drawing.Point(8, 135)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(683, 34)
        Me.PictureBox3.TabIndex = 149
        Me.PictureBox3.TabStop = False
        '
        'UpTimer
        '
        Me.UpTimer.Interval = 1
        '
        'DownTimer
        '
        Me.DownTimer.Interval = 1
        '
        'LogoExit
        '
        Me.LogoExit.Interval = 1
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("나눔고딕", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(379, 36)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 23)
        Me.Label6.TabIndex = 163
        Me.Label6.Text = "Website"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("나눔고딕", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(55, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 22)
        Me.Label2.TabIndex = 155
        Me.Label2.Text = "RAM"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("나눔고딕", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(472, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 20)
        Me.Label3.TabIndex = 156
        Me.Label3.Text = "JAVA"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("나눔고딕", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(199, 37)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(174, 20)
        Me.Label5.TabIndex = 168
        Me.Label5.Text = "Lastet Kimubukkit N"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NumberUP
        '
        Me.NumberUP.Interval = 1
        '
        'JavaSearch
        '
        Me.JavaSearch.FileName = "C:\Program Files"
        Me.JavaSearch.Filter = "자바 파일 [ java.exe ]|java.exe"
        Me.JavaSearch.Title = "자바 경로 찾기"
        '
        'FlatButton1
        '
        Me.FlatButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlatButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.FlatButton1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.FlatButton1.Cursor = System.Windows.Forms.Cursors.Default
        Me.FlatButton1.Font = New System.Drawing.Font("나눔고딕", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.FlatButton1.Location = New System.Drawing.Point(663, 35)
        Me.FlatButton1.Name = "FlatButton1"
        Me.FlatButton1.Rounded = True
        Me.FlatButton1.Size = New System.Drawing.Size(35, 25)
        Me.FlatButton1.TabIndex = 172
        Me.FlatButton1.Text = "↔"
        Me.FlatButton1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatButton6
        '
        Me.FlatButton6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlatButton6.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.FlatButton6.BaseColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.FlatButton6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton6.Font = New System.Drawing.Font("나눔고딕", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.FlatButton6.Location = New System.Drawing.Point(663, 89)
        Me.FlatButton6.Name = "FlatButton6"
        Me.FlatButton6.Rounded = True
        Me.FlatButton6.Size = New System.Drawing.Size(35, 25)
        Me.FlatButton6.TabIndex = 171
        Me.FlatButton6.Text = "메뉴"
        Me.FlatButton6.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatButton3
        '
        Me.FlatButton3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlatButton3.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.FlatButton3.BaseColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.FlatButton3.Cursor = System.Windows.Forms.Cursors.Default
        Me.FlatButton3.Font = New System.Drawing.Font("나눔고딕", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.FlatButton3.Location = New System.Drawing.Point(663, 62)
        Me.FlatButton3.Name = "FlatButton3"
        Me.FlatButton3.Rounded = True
        Me.FlatButton3.Size = New System.Drawing.Size(35, 25)
        Me.FlatButton3.TabIndex = 167
        Me.FlatButton3.Text = "폴더"
        Me.FlatButton3.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatStickyButton6
        '
        Me.FlatStickyButton6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlatStickyButton6.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.FlatStickyButton6.BaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.FlatStickyButton6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatStickyButton6.Font = New System.Drawing.Font("Segoe UI Symbol", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatStickyButton6.Location = New System.Drawing.Point(663, -4)
        Me.FlatStickyButton6.Name = "FlatStickyButton6"
        Me.FlatStickyButton6.Rounded = True
        Me.FlatStickyButton6.Size = New System.Drawing.Size(35, 37)
        Me.FlatStickyButton6.TabIndex = 122
        Me.FlatStickyButton6.Text = "×"
        Me.FlatStickyButton6.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'ToMod
        '
        Me.ToMod.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ToMod.BackColor = System.Drawing.Color.Transparent
        Me.ToMod.BaseColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.ToMod.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ToMod.Font = New System.Drawing.Font("나눔고딕", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.ToMod.Location = New System.Drawing.Point(550, 395)
        Me.ToMod.Margin = New System.Windows.Forms.Padding(1)
        Me.ToMod.Name = "ToMod"
        Me.ToMod.Rounded = False
        Me.ToMod.Size = New System.Drawing.Size(141, 40)
        Me.ToMod.TabIndex = 178
        Me.ToMod.Text = "모드 관리하기"
        Me.ToMod.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.ToMod.Visible = False
        '
        'ToPlugin
        '
        Me.ToPlugin.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ToPlugin.BackColor = System.Drawing.Color.Transparent
        Me.ToPlugin.BaseColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.ToPlugin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ToPlugin.Font = New System.Drawing.Font("나눔고딕", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.ToPlugin.Location = New System.Drawing.Point(378, 395)
        Me.ToPlugin.Margin = New System.Windows.Forms.Padding(1)
        Me.ToPlugin.Name = "ToPlugin"
        Me.ToPlugin.Rounded = False
        Me.ToPlugin.Size = New System.Drawing.Size(170, 40)
        Me.ToPlugin.TabIndex = 177
        Me.ToPlugin.Text = "플러그인 관리하기"
        Me.ToPlugin.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.ToPlugin.Visible = False
        '
        'ToConfig
        '
        Me.ToConfig.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ToConfig.BackColor = System.Drawing.Color.Transparent
        Me.ToConfig.BaseColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.ToConfig.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ToConfig.Font = New System.Drawing.Font("나눔고딕", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.ToConfig.Location = New System.Drawing.Point(207, 395)
        Me.ToConfig.Margin = New System.Windows.Forms.Padding(1)
        Me.ToConfig.Name = "ToConfig"
        Me.ToConfig.Rounded = False
        Me.ToConfig.Size = New System.Drawing.Size(169, 40)
        Me.ToConfig.TabIndex = 176
        Me.ToConfig.Text = "서버 설정하기"
        Me.ToConfig.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.ToConfig.Visible = False
        '
        'ToOpen
        '
        Me.ToOpen.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ToOpen.BackColor = System.Drawing.Color.Transparent
        Me.ToOpen.BaseColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.ToOpen.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ToOpen.Font = New System.Drawing.Font("나눔고딕", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.ToOpen.Location = New System.Drawing.Point(35, 395)
        Me.ToOpen.Margin = New System.Windows.Forms.Padding(1)
        Me.ToOpen.Name = "ToOpen"
        Me.ToOpen.Rounded = False
        Me.ToOpen.Size = New System.Drawing.Size(170, 40)
        Me.ToOpen.TabIndex = 175
        Me.ToOpen.Text = "서버 구동하기"
        Me.ToOpen.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.ToOpen.Visible = False
        '
        'ServerDelete
        '
        Me.ServerDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ServerDelete.BaseColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ServerDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ServerDelete.Enabled = False
        Me.ServerDelete.Font = New System.Drawing.Font("나눔고딕", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ServerDelete.Location = New System.Drawing.Point(8, 271)
        Me.ServerDelete.Name = "ServerDelete"
        Me.ServerDelete.Rounded = False
        Me.ServerDelete.Size = New System.Drawing.Size(20, 94)
        Me.ServerDelete.TabIndex = 129
        Me.ServerDelete.Text = "-"
        Me.ServerDelete.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatStickyButton7
        '
        Me.FlatStickyButton7.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.FlatStickyButton7.BaseColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.FlatStickyButton7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatStickyButton7.Font = New System.Drawing.Font("나눔고딕", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.FlatStickyButton7.Location = New System.Drawing.Point(8, 175)
        Me.FlatStickyButton7.Name = "FlatStickyButton7"
        Me.FlatStickyButton7.Rounded = False
        Me.FlatStickyButton7.Size = New System.Drawing.Size(20, 94)
        Me.FlatStickyButton7.TabIndex = 123
        Me.FlatStickyButton7.Text = "+"
        Me.FlatStickyButton7.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatButton11
        '
        Me.FlatButton11.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.FlatButton11.BaseColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.FlatButton11.Cursor = System.Windows.Forms.Cursors.Default
        Me.FlatButton11.Font = New System.Drawing.Font("나눔고딕", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatButton11.Location = New System.Drawing.Point(379, 60)
        Me.FlatButton11.Name = "FlatButton11"
        Me.FlatButton11.Rounded = False
        Me.FlatButton11.Size = New System.Drawing.Size(83, 34)
        Me.FlatButton11.TabIndex = 164
        Me.FlatButton11.Text = "블로그"
        Me.FlatButton11.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'UpdateINFO
        '
        Me.UpdateINFO.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.UpdateINFO.BaseColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.UpdateINFO.Cursor = System.Windows.Forms.Cursors.Default
        Me.UpdateINFO.Enabled = False
        Me.UpdateINFO.Font = New System.Drawing.Font("나눔고딕", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.UpdateINFO.Location = New System.Drawing.Point(202, 60)
        Me.UpdateINFO.Margin = New System.Windows.Forms.Padding(0)
        Me.UpdateINFO.Name = "UpdateINFO"
        Me.UpdateINFO.Rounded = False
        Me.UpdateINFO.Size = New System.Drawing.Size(174, 34)
        Me.UpdateINFO.TabIndex = 162
        Me.UpdateINFO.Text = "새로고침을 눌러주세요"
        Me.UpdateINFO.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'NEWVer
        '
        Me.NEWVer.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.NEWVer.BaseColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.NEWVer.Cursor = System.Windows.Forms.Cursors.Default
        Me.NEWVer.Font = New System.Drawing.Font("나눔고딕", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NEWVer.Location = New System.Drawing.Point(131, 60)
        Me.NEWVer.Name = "NEWVer"
        Me.NEWVer.Rounded = False
        Me.NEWVer.Size = New System.Drawing.Size(71, 34)
        Me.NEWVer.TabIndex = 161
        Me.NEWVer.Text = "???"
        Me.NEWVer.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'MyRAM
        '
        Me.MyRAM.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.MyRAM.BaseColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.MyRAM.Cursor = System.Windows.Forms.Cursors.Default
        Me.MyRAM.Font = New System.Drawing.Font("나눔고딕", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MyRAM.Location = New System.Drawing.Point(90, 59)
        Me.MyRAM.Name = "MyRAM"
        Me.MyRAM.Rounded = False
        Me.MyRAM.Size = New System.Drawing.Size(35, 34)
        Me.MyRAM.TabIndex = 152
        Me.MyRAM.Text = "MB"
        Me.MyRAM.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatButton2
        '
        Me.FlatButton2.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.FlatButton2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.FlatButton2.Cursor = System.Windows.Forms.Cursors.Default
        Me.FlatButton2.Font = New System.Drawing.Font("나눔고딕", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.FlatButton2.Location = New System.Drawing.Point(468, 60)
        Me.FlatButton2.Name = "FlatButton2"
        Me.FlatButton2.Rounded = False
        Me.FlatButton2.Size = New System.Drawing.Size(72, 34)
        Me.FlatButton2.TabIndex = 166
        Me.FlatButton2.Text = "재인식"
        Me.FlatButton2.TextColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        '
        'FlatButton4
        '
        Me.FlatButton4.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.FlatButton4.BaseColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.FlatButton4.Cursor = System.Windows.Forms.Cursors.Default
        Me.FlatButton4.Font = New System.Drawing.Font("나눔고딕", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.FlatButton4.Location = New System.Drawing.Point(131, 36)
        Me.FlatButton4.Name = "FlatButton4"
        Me.FlatButton4.Rounded = False
        Me.FlatButton4.Size = New System.Drawing.Size(71, 27)
        Me.FlatButton4.TabIndex = 170
        Me.FlatButton4.Text = "새로 고침"
        Me.FlatButton4.TextColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.PictureBox4.Location = New System.Drawing.Point(22, 58)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(89, 36)
        Me.PictureBox4.TabIndex = 181
        Me.PictureBox4.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("나눔고딕", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Silver
        Me.Label1.Location = New System.Drawing.Point(13, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 14)
        Me.Label1.TabIndex = 179
        Me.Label1.Text = "고급 램 설정"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.BackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.NumericUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.NumericUpDown1.Cursor = System.Windows.Forms.Cursors.Default
        Me.NumericUpDown1.Font = New System.Drawing.Font("나눔고딕", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.NumericUpDown1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.NumericUpDown1.Increment = New Decimal(New Integer() {512, 0, 0, 0})
        Me.NumericUpDown1.Location = New System.Drawing.Point(22, 65)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {16384, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(67, 22)
        Me.NumericUpDown1.TabIndex = 182
        Me.NumericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NumericUpDown1.ThousandsSeparator = True
        Me.NumericUpDown1.Value = New Decimal(New Integer() {1020, 0, 0, 0})
        '
        'FlatButton5
        '
        Me.FlatButton5.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.FlatButton5.BaseColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.FlatButton5.Cursor = System.Windows.Forms.Cursors.Default
        Me.FlatButton5.Font = New System.Drawing.Font("나눔고딕", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.FlatButton5.Location = New System.Drawing.Point(22, 36)
        Me.FlatButton5.Name = "FlatButton5"
        Me.FlatButton5.Rounded = False
        Me.FlatButton5.Size = New System.Drawing.Size(36, 27)
        Me.FlatButton5.TabIndex = 183
        Me.FlatButton5.Text = "저장"
        Me.FlatButton5.TextColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        '
        'VersionLabel
        '
        Me.VersionLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.VersionLabel.Font = New System.Drawing.Font("나눔고딕", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.VersionLabel.ForeColor = System.Drawing.Color.White
        Me.VersionLabel.Location = New System.Drawing.Point(5, 117)
        Me.VersionLabel.Name = "VersionLabel"
        Me.VersionLabel.Size = New System.Drawing.Size(65, 16)
        Me.VersionLabel.TabIndex = 163
        Me.VersionLabel.Text = "KμBukkit"
        Me.VersionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("나눔고딕", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(61, 117)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 16)
        Me.Label7.TabIndex = 163
        Me.Label7.Text = "8.2"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'NewHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(700, 440)
        Me.ControlBox = False
        Me.Controls.Add(Me.FlatButton1)
        Me.Controls.Add(Me.FlatButton6)
        Me.Controls.Add(Me.FlatButton3)
        Me.Controls.Add(Me.FlatStickyButton6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.VersionLabel)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.FlatButton5)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ToMod)
        Me.Controls.Add(Me.ToPlugin)
        Me.Controls.Add(Me.ToConfig)
        Me.Controls.Add(Me.ToOpen)
        Me.Controls.Add(Me.ServerDelete)
        Me.Controls.Add(Me.FlatStickyButton7)
        Me.Controls.Add(Me.FlatButton11)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.UpdateINFO)
        Me.Controls.Add(Me.NEWVer)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.MyRAM)
        Me.Controls.Add(Me.FlatButton2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.FlatButton4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.PictureBox4)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MinimumSize = New System.Drawing.Size(700, 440)
        Me.Name = "NewHome"
        Me.Opacity = 0R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NewHome"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents PictureBox18 As PictureBox
    Friend WithEvents Label24 As Label
    Friend WithEvents PictureBox19 As PictureBox
    Friend WithEvents FlatStickyButton7 As FlatStickyButton
    Friend WithEvents FlatStickyButton6 As FlatStickyButton
    Friend WithEvents ServerDelete As FlatButton
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents UpTimer As Timer
    Friend WithEvents DownTimer As Timer
    Friend WithEvents LogoExit As Timer
    Friend WithEvents Timer1 As Timer
    Friend WithEvents FlatButton11 As FlatButton
    Friend WithEvents Label6 As Label
    Friend WithEvents UpdateINFO As FlatButton
    Friend WithEvents NEWVer As FlatButton
    Friend WithEvents Label3 As Label
    Friend WithEvents MyRAM As FlatButton
    Friend WithEvents Label2 As Label
    Friend WithEvents NumberUP As Timer
    Friend WithEvents FlatButton2 As FlatButton
    Friend WithEvents FlatButton3 As FlatButton
    Friend WithEvents Label5 As Label
    Friend WithEvents FlatButton4 As FlatButton
    Friend WithEvents FlatButton6 As FlatButton
    Friend WithEvents FlatButton1 As FlatButton
    Friend WithEvents ToOpen As FlatStickyButton
    Friend WithEvents ToConfig As FlatStickyButton
    Friend WithEvents ToPlugin As FlatStickyButton
    Friend WithEvents ToMod As FlatStickyButton
    Friend WithEvents JavaSearch As OpenFileDialog
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents FlatButton5 As FlatButton
    Friend WithEvents VersionLabel As Label
    Friend WithEvents Label7 As Label
End Class
