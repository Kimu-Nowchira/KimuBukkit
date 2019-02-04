<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ServerSlot
    Inherits System.Windows.Forms.UserControl

    'UserControl은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.pluginvalue = New System.Windows.Forms.Label()
        Me.Type = New System.Windows.Forms.Label()
        Me.Version = New System.Windows.Forms.Label()
        Me.Iconing = New System.Windows.Forms.PictureBox()
        Me.ServerName = New System.Windows.Forms.Label()
        Me.Modvalue = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.Iconing, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pluginvalue
        '
        Me.pluginvalue.AutoSize = True
        Me.pluginvalue.Font = New System.Drawing.Font("나눔고딕", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.pluginvalue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.pluginvalue.Location = New System.Drawing.Point(72, 55)
        Me.pluginvalue.Name = "pluginvalue"
        Me.pluginvalue.Size = New System.Drawing.Size(56, 14)
        Me.pluginvalue.TabIndex = 11
        Me.pluginvalue.Text = "0 Plugins"
        '
        'Type
        '
        Me.Type.Font = New System.Drawing.Font("나눔고딕", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Type.ForeColor = System.Drawing.Color.Gray
        Me.Type.Location = New System.Drawing.Point(68, 72)
        Me.Type.Name = "Type"
        Me.Type.Size = New System.Drawing.Size(153, 17)
        Me.Type.TabIndex = 10
        Me.Type.Text = "CraftBukkit"
        Me.Type.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Version
        '
        Me.Version.AutoSize = True
        Me.Version.Font = New System.Drawing.Font("나눔고딕", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Version.ForeColor = System.Drawing.Color.Gray
        Me.Version.Location = New System.Drawing.Point(70, 35)
        Me.Version.Name = "Version"
        Me.Version.Size = New System.Drawing.Size(137, 19)
        Me.Version.TabIndex = 8
        Me.Version.Text = "Minecraft 1.7.10"
        '
        'Iconing
        '
        Me.Iconing.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.Iconing.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Iconing.Location = New System.Drawing.Point(1, 30)
        Me.Iconing.Name = "Iconing"
        Me.Iconing.Size = New System.Drawing.Size(64, 64)
        Me.Iconing.TabIndex = 6
        Me.Iconing.TabStop = False
        '
        'ServerName
        '
        Me.ServerName.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.ServerName.Font = New System.Drawing.Font("나눔고딕", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.ServerName.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.ServerName.Location = New System.Drawing.Point(15, 0)
        Me.ServerName.Name = "ServerName"
        Me.ServerName.Size = New System.Drawing.Size(215, 30)
        Me.ServerName.TabIndex = 7
        Me.ServerName.Text = "Servername"
        Me.ServerName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Modvalue
        '
        Me.Modvalue.AutoSize = True
        Me.Modvalue.Font = New System.Drawing.Font("나눔고딕", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Modvalue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.Modvalue.Location = New System.Drawing.Point(133, 55)
        Me.Modvalue.Name = "Modvalue"
        Me.Modvalue.Size = New System.Drawing.Size(48, 14)
        Me.Modvalue.TabIndex = 12
        Me.Modvalue.Text = "0 Mods"
        Me.Modvalue.Visible = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "PNG 이미지 파일|*.png"
        Me.OpenFileDialog1.Title = "서버 아이콘 변경하기"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(15, 30)
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'ServerSlot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Controls.Add(Me.ServerName)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Modvalue)
        Me.Controls.Add(Me.pluginvalue)
        Me.Controls.Add(Me.Type)
        Me.Controls.Add(Me.Version)
        Me.Controls.Add(Me.Iconing)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Margin = New System.Windows.Forms.Padding(1)
        Me.Name = "ServerSlot"
        Me.Size = New System.Drawing.Size(230, 94)
        CType(Me.Iconing, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pluginvalue As Label
    Friend WithEvents Type As Label
    Friend WithEvents Version As Label
    Friend WithEvents Iconing As PictureBox
    Friend WithEvents ServerName As Label
    Friend WithEvents Modvalue As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents PictureBox1 As PictureBox
End Class
