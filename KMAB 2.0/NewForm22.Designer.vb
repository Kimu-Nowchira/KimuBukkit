<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class NewForm22
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.servername = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.SlotNumber = New System.Windows.Forms.Label()
        Me.MenuOpen = New System.Windows.Forms.Timer(Me.components)
        Me.Label14 = New System.Windows.Forms.Label()
        Me.FlatButton8 = New KMAB_2._0.FlatButton()
        Me.SmallVer = New KMAB_2._0.FlatButton()
        Me.BukkitType = New KMAB_2._0.FlatButton()
        Me.Verson = New KMAB_2._0.FlatButton()
        Me.RamValue = New KMAB_2._0.FlatButton()
        Me.MenuClose = New System.Windows.Forms.Timer(Me.components)
        Me.ColorMation = New System.Windows.Forms.Timer(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.FlatButton1 = New KMAB_2._0.FlatButton()
        Me.FlatStickyButton6 = New KMAB_2._0.FlatStickyButton()
        Me.FlatStickyButton1 = New KMAB_2._0.FlatStickyButton()
        Me.Confignational_Button = New KMAB_2._0.FlatStickyButton()
        Me.FlatStickyButton4 = New KMAB_2._0.FlatStickyButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.FlatMax1 = New KMAB_2._0.FlatMax()
        Me.FlatMini1 = New KMAB_2._0.FlatMini()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FlatStickyButton7 = New KMAB_2._0.FlatStickyButton()
        Me.Flatbutton3 = New KMAB_2._0.FlatStickyButton()
        Me.FontOption = New KMAB_2._0.FlatStickyButton()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("나눔고딕", 9.75!)
        Me.TextBox1.ForeColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(9, 41)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(628, 15)
        Me.TextBox1.TabIndex = 83
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PictureBox1.Location = New System.Drawing.Point(0, 31)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(660, 37)
        Me.PictureBox1.TabIndex = 84
        Me.PictureBox1.TabStop = False
        '
        'servername
        '
        Me.servername.AutoSize = True
        Me.servername.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.servername.Font = New System.Drawing.Font("나눔고딕", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.servername.ForeColor = System.Drawing.Color.White
        Me.servername.Location = New System.Drawing.Point(31, 33)
        Me.servername.Name = "servername"
        Me.servername.Size = New System.Drawing.Size(169, 43)
        Me.servername.TabIndex = 88
        Me.servername.Text = "서버 이름" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.PictureBox2.Location = New System.Drawing.Point(20, 96)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(569, 5)
        Me.PictureBox2.TabIndex = 89
        Me.PictureBox2.TabStop = False
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.RichTextBox1.HideSelection = False
        Me.RichTextBox1.Location = New System.Drawing.Point(12, 107)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.RichTextBox1.Size = New System.Drawing.Size(640, 319)
        Me.RichTextBox1.TabIndex = 111
        Me.RichTextBox1.Text = ""
        '
        'SlotNumber
        '
        Me.SlotNumber.AutoSize = True
        Me.SlotNumber.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.SlotNumber.Font = New System.Drawing.Font("나눔고딕", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.SlotNumber.ForeColor = System.Drawing.Color.White
        Me.SlotNumber.Location = New System.Drawing.Point(17, 79)
        Me.SlotNumber.Name = "SlotNumber"
        Me.SlotNumber.Size = New System.Drawing.Size(15, 15)
        Me.SlotNumber.TabIndex = 113
        Me.SlotNumber.Text = "0"
        Me.SlotNumber.Visible = False
        '
        'MenuOpen
        '
        Me.MenuOpen.Interval = 1
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Label14.ForeColor = System.Drawing.Color.Gray
        Me.Label14.Location = New System.Drawing.Point(523, 79)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(54, 14)
        Me.Label14.TabIndex = 121
        Me.Label14.Text = "서버 닫힘"
        '
        'FlatButton8
        '
        Me.FlatButton8.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.FlatButton8.BaseColor = System.Drawing.Color.Maroon
        Me.FlatButton8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton8.Font = New System.Drawing.Font("나눔고딕", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.FlatButton8.Location = New System.Drawing.Point(15, 110)
        Me.FlatButton8.Margin = New System.Windows.Forms.Padding(0)
        Me.FlatButton8.Name = "FlatButton8"
        Me.FlatButton8.Rounded = True
        Me.FlatButton8.Size = New System.Drawing.Size(44, 29)
        Me.FlatButton8.TabIndex = 135
        Me.FlatButton8.Text = "F.T."
        Me.FlatButton8.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'SmallVer
        '
        Me.SmallVer.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.SmallVer.BaseColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.SmallVer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SmallVer.Font = New System.Drawing.Font("나눔고딕", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.SmallVer.Location = New System.Drawing.Point(382, 110)
        Me.SmallVer.Margin = New System.Windows.Forms.Padding(0)
        Me.SmallVer.Name = "SmallVer"
        Me.SmallVer.Rounded = False
        Me.SmallVer.Size = New System.Drawing.Size(82, 29)
        Me.SmallVer.TabIndex = 130
        Me.SmallVer.Text = "#RAM"
        Me.SmallVer.TextColor = System.Drawing.Color.WhiteSmoke
        '
        'BukkitType
        '
        Me.BukkitType.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BukkitType.BaseColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.BukkitType.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BukkitType.Font = New System.Drawing.Font("나눔고딕", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.BukkitType.Location = New System.Drawing.Point(59, 110)
        Me.BukkitType.Margin = New System.Windows.Forms.Padding(0)
        Me.BukkitType.Name = "BukkitType"
        Me.BukkitType.Rounded = False
        Me.BukkitType.Size = New System.Drawing.Size(157, 29)
        Me.BukkitType.TabIndex = 114
        Me.BukkitType.Text = "#BukkitType"
        Me.BukkitType.TextColor = System.Drawing.Color.WhiteSmoke
        '
        'Verson
        '
        Me.Verson.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Verson.BaseColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.Verson.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Verson.Font = New System.Drawing.Font("나눔고딕", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Verson.Location = New System.Drawing.Point(216, 110)
        Me.Verson.Margin = New System.Windows.Forms.Padding(0)
        Me.Verson.Name = "Verson"
        Me.Verson.Rounded = False
        Me.Verson.Size = New System.Drawing.Size(166, 29)
        Me.Verson.TabIndex = 115
        Me.Verson.Text = "#Version"
        Me.Verson.TextColor = System.Drawing.Color.WhiteSmoke
        '
        'RamValue
        '
        Me.RamValue.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.RamValue.BaseColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.RamValue.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RamValue.Font = New System.Drawing.Font("나눔고딕", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.RamValue.Location = New System.Drawing.Point(464, 110)
        Me.RamValue.Margin = New System.Windows.Forms.Padding(0)
        Me.RamValue.Name = "RamValue"
        Me.RamValue.Rounded = False
        Me.RamValue.Size = New System.Drawing.Size(84, 29)
        Me.RamValue.TabIndex = 116
        Me.RamValue.Text = "#RAM"
        Me.RamValue.TextColor = System.Drawing.Color.WhiteSmoke
        '
        'MenuClose
        '
        Me.MenuClose.Interval = 1
        '
        'ColorMation
        '
        Me.ColorMation.Interval = 1
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("나눔고딕", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Silver
        Me.Label3.Location = New System.Drawing.Point(13, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 15)
        Me.Label3.TabIndex = 123
        Me.Label3.Text = "명령어 입력 후 엔터"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("나눔고딕", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Firebrick
        Me.Label4.Location = New System.Drawing.Point(7, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(272, 15)
        Me.Label4.TabIndex = 124
        Me.Label4.Text = "버킷 콘솔 명령어 사용 시 ""/""를 붙이지 않습니다."
        Me.Label4.Visible = False
        '
        'FlatButton1
        '
        Me.FlatButton1.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FlatButton1.Font = New System.Drawing.Font("나눔고딕", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.FlatButton1.Location = New System.Drawing.Point(0, 364)
        Me.FlatButton1.Name = "FlatButton1"
        Me.FlatButton1.Rounded = False
        Me.FlatButton1.Size = New System.Drawing.Size(660, 48)
        Me.FlatButton1.TabIndex = 90
        Me.FlatButton1.Text = "서버 열기"
        Me.FlatButton1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatStickyButton6
        '
        Me.FlatStickyButton6.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.FlatStickyButton6.BaseColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.FlatStickyButton6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatStickyButton6.Font = New System.Drawing.Font("나눔고딕", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.FlatStickyButton6.Location = New System.Drawing.Point(94, -1)
        Me.FlatStickyButton6.Name = "FlatStickyButton6"
        Me.FlatStickyButton6.Rounded = True
        Me.FlatStickyButton6.Size = New System.Drawing.Size(61, 34)
        Me.FlatStickyButton6.TabIndex = 106
        Me.FlatStickyButton6.Text = "Home"
        Me.FlatStickyButton6.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatStickyButton1
        '
        Me.FlatStickyButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlatStickyButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.FlatStickyButton1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.FlatStickyButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatStickyButton1.Font = New System.Drawing.Font("나눔고딕", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatStickyButton1.Location = New System.Drawing.Point(612, 31)
        Me.FlatStickyButton1.Name = "FlatStickyButton1"
        Me.FlatStickyButton1.Rounded = True
        Me.FlatStickyButton1.Size = New System.Drawing.Size(45, 37)
        Me.FlatStickyButton1.TabIndex = 87
        Me.FlatStickyButton1.Text = "Cmd"
        Me.FlatStickyButton1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'Confignational_Button
        '
        Me.Confignational_Button.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Confignational_Button.BaseColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Confignational_Button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Confignational_Button.Font = New System.Drawing.Font("나눔고딕", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Confignational_Button.Location = New System.Drawing.Point(94, 33)
        Me.Confignational_Button.Name = "Confignational_Button"
        Me.Confignational_Button.Rounded = True
        Me.Confignational_Button.Size = New System.Drawing.Size(61, 34)
        Me.Confignational_Button.TabIndex = 125
        Me.Confignational_Button.Text = "Menu"
        Me.Confignational_Button.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatStickyButton4
        '
        Me.FlatStickyButton4.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.FlatStickyButton4.BaseColor = System.Drawing.Color.OliveDrab
        Me.FlatStickyButton4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatStickyButton4.Font = New System.Drawing.Font("나눔고딕", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.FlatStickyButton4.Location = New System.Drawing.Point(66, -1)
        Me.FlatStickyButton4.Name = "FlatStickyButton4"
        Me.FlatStickyButton4.Rounded = True
        Me.FlatStickyButton4.Size = New System.Drawing.Size(28, 34)
        Me.FlatStickyButton4.TabIndex = 126
        Me.FlatStickyButton4.Text = "↔"
        Me.FlatStickyButton4.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.FlatMax1)
        Me.Panel2.Controls.Add(Me.FlatMini1)
        Me.Panel2.Controls.Add(Me.Confignational_Button)
        Me.Panel2.Controls.Add(Me.FlatStickyButton4)
        Me.Panel2.Controls.Add(Me.FlatStickyButton6)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(505, 1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(156, 75)
        Me.Panel2.TabIndex = 128
        '
        'FlatMax1
        '
        Me.FlatMax1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlatMax1.BackColor = System.Drawing.Color.White
        Me.FlatMax1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FlatMax1.Font = New System.Drawing.Font("Marlett", 12.0!)
        Me.FlatMax1.Location = New System.Drawing.Point(42, 5)
        Me.FlatMax1.Name = "FlatMax1"
        Me.FlatMax1.Size = New System.Drawing.Size(18, 18)
        Me.FlatMax1.TabIndex = 143
        Me.FlatMax1.Text = "FlatMax1"
        Me.FlatMax1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatMini1
        '
        Me.FlatMini1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlatMini1.BackColor = System.Drawing.Color.White
        Me.FlatMini1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FlatMini1.Font = New System.Drawing.Font("Marlett", 12.0!)
        Me.FlatMini1.Location = New System.Drawing.Point(20, 5)
        Me.FlatMini1.Name = "FlatMini1"
        Me.FlatMini1.Size = New System.Drawing.Size(18, 18)
        Me.FlatMini1.TabIndex = 144
        Me.FlatMini1.Text = "FlatMini1"
        Me.FlatMini1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("나눔고딕", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(63, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 19)
        Me.Label1.TabIndex = 128
        Me.Label1.Text = "Log"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FlatStickyButton7
        '
        Me.FlatStickyButton7.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.FlatStickyButton7.BaseColor = System.Drawing.Color.Maroon
        Me.FlatStickyButton7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatStickyButton7.Font = New System.Drawing.Font("나눔고딕", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatStickyButton7.Location = New System.Drawing.Point(4, 5)
        Me.FlatStickyButton7.Name = "FlatStickyButton7"
        Me.FlatStickyButton7.Rounded = True
        Me.FlatStickyButton7.Size = New System.Drawing.Size(28, 34)
        Me.FlatStickyButton7.TabIndex = 130
        Me.FlatStickyButton7.Text = "Off"
        Me.FlatStickyButton7.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.FlatStickyButton7.Visible = False
        '
        'Flatbutton3
        '
        Me.Flatbutton3.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Flatbutton3.BaseColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.Flatbutton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Flatbutton3.Font = New System.Drawing.Font("나눔고딕", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Flatbutton3.Location = New System.Drawing.Point(588, 110)
        Me.Flatbutton3.Name = "Flatbutton3"
        Me.Flatbutton3.Rounded = True
        Me.Flatbutton3.Size = New System.Drawing.Size(45, 29)
        Me.Flatbutton3.TabIndex = 129
        Me.Flatbutton3.Text = "Clear"
        Me.Flatbutton3.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FontOption
        '
        Me.FontOption.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.FontOption.BaseColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.FontOption.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FontOption.Font = New System.Drawing.Font("나눔고딕", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FontOption.Location = New System.Drawing.Point(550, 110)
        Me.FontOption.Name = "FontOption"
        Me.FontOption.Rounded = True
        Me.FontOption.Size = New System.Drawing.Size(38, 29)
        Me.FontOption.TabIndex = 128
        Me.FontOption.Text = "Font"
        Me.FontOption.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.FlatStickyButton1)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.TextBox1)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 412)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(660, 68)
        Me.Panel3.TabIndex = 129
        Me.Panel3.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Label5.ForeColor = System.Drawing.Color.Gray
        Me.Label5.Location = New System.Drawing.Point(106, 139)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 14)
        Me.Label5.TabIndex = 136
        Me.Label5.Text = "버킷의 종류"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Label6.ForeColor = System.Drawing.Color.Gray
        Me.Label6.Location = New System.Drawing.Point(251, 139)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 14)
        Me.Label6.TabIndex = 137
        Me.Label6.Text = "마인크래프트 버전"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Label7.ForeColor = System.Drawing.Color.Gray
        Me.Label7.Location = New System.Drawing.Point(401, 139)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 14)
        Me.Label7.TabIndex = 138
        Me.Label7.Text = "최소 램"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Label8.ForeColor = System.Drawing.Color.Gray
        Me.Label8.Location = New System.Drawing.Point(487, 139)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 14)
        Me.Label8.TabIndex = 139
        Me.Label8.Text = "최대 램"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Label9.ForeColor = System.Drawing.Color.Maroon
        Me.Label9.Location = New System.Drawing.Point(10, 139)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 14)
        Me.Label9.TabIndex = 140
        Me.Label9.Text = "강제종료"
        '
        'ListView1
        '
        Me.ListView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListView1.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListView1.Cursor = System.Windows.Forms.Cursors.Cross
        Me.ListView1.Font = New System.Drawing.Font("나눔고딕", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.ListView1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.ListView1.LargeImageList = Me.ImageList1
        Me.ListView1.Location = New System.Drawing.Point(12, 162)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(636, 266)
        Me.ListView1.TabIndex = 142
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(64, 64)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'NewForm22
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(660, 480)
        Me.ControlBox = False
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.Flatbutton3)
        Me.Controls.Add(Me.FlatStickyButton7)
        Me.Controls.Add(Me.SlotNumber)
        Me.Controls.Add(Me.FontOption)
        Me.Controls.Add(Me.FlatButton1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.FlatButton8)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.servername)
        Me.Controls.Add(Me.SmallVer)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.RamValue)
        Me.Controls.Add(Me.BukkitType)
        Me.Controls.Add(Me.Verson)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Panel2)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("나눔고딕", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.HelpButton = True
        Me.MaximumSize = New System.Drawing.Size(1680, 1050)
        Me.MinimumSize = New System.Drawing.Size(660, 480)
        Me.Name = "NewForm22"
        Me.Opacity = 0R
        Me.Text = "KimuBukkitN by Kimustudio"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
    Friend WithEvents FlatStickyButton1 As KMAB_2._0.FlatStickyButton
    Friend WithEvents servername As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents FlatButton1 As KMAB_2._0.FlatButton
    Friend WithEvents FlatStickyButton6 As KMAB_2._0.FlatStickyButton
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents SlotNumber As Label
    Friend WithEvents BukkitType As FlatButton
    Friend WithEvents Verson As FlatButton
    Friend WithEvents RamValue As FlatButton
    Friend WithEvents MenuOpen As Timer
    Friend WithEvents Label14 As Label
    Friend WithEvents MenuClose As Timer
    Friend WithEvents ColorMation As Timer
    Friend WithEvents SmallVer As FlatButton
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents FlatButton8 As FlatButton
    Friend WithEvents Confignational_Button As FlatStickyButton
    Friend WithEvents FlatStickyButton4 As FlatStickyButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents FontOption As FlatStickyButton
    Friend WithEvents Flatbutton3 As FlatStickyButton
    Friend WithEvents FlatStickyButton7 As FlatStickyButton
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ListView1 As ListView
    Friend WithEvents FlatMax1 As FlatMax
    Friend WithEvents FlatMini1 As FlatMini
    Friend WithEvents ImageList1 As ImageList
End Class
