<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PluginsList
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
        Me.Instmov = New KMAB_2._0.FlatButton()
        Me.Version = New KMAB_2._0.FlatButton()
        Me.NameButton = New KMAB_2._0.FlatButton()
        Me.SuspendLayout()
        '
        'Instmov
        '
        Me.Instmov.BackColor = System.Drawing.Color.Transparent
        Me.Instmov.BaseColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Instmov.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Instmov.Font = New System.Drawing.Font("나눔고딕", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Instmov.Location = New System.Drawing.Point(560, 1)
        Me.Instmov.Name = "Instmov"
        Me.Instmov.Rounded = False
        Me.Instmov.Size = New System.Drawing.Size(61, 30)
        Me.Instmov.TabIndex = 136
        Me.Instmov.Text = "설치"
        Me.Instmov.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'Version
        '
        Me.Version.BackColor = System.Drawing.Color.Transparent
        Me.Version.BaseColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.Version.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Version.Font = New System.Drawing.Font("나눔고딕", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Version.Location = New System.Drawing.Point(0, 1)
        Me.Version.Margin = New System.Windows.Forms.Padding(0)
        Me.Version.Name = "Version"
        Me.Version.Rounded = False
        Me.Version.Size = New System.Drawing.Size(74, 30)
        Me.Version.TabIndex = 135
        Me.Version.Text = "1.5.2"
        Me.Version.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'NameButton
        '
        Me.NameButton.BackColor = System.Drawing.Color.Transparent
        Me.NameButton.BaseColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.NameButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NameButton.Font = New System.Drawing.Font("나눔고딕", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameButton.Location = New System.Drawing.Point(74, 1)
        Me.NameButton.Margin = New System.Windows.Forms.Padding(0)
        Me.NameButton.Name = "NameButton"
        Me.NameButton.Rounded = False
        Me.NameButton.Size = New System.Drawing.Size(487, 30)
        Me.NameButton.TabIndex = 134
        Me.NameButton.Text = "EnglishName / KoreanName"
        Me.NameButton.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'PluginsList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Controls.Add(Me.Instmov)
        Me.Controls.Add(Me.Version)
        Me.Controls.Add(Me.NameButton)
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "PluginsList"
        Me.Size = New System.Drawing.Size(624, 34)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Instmov As FlatButton
    Friend WithEvents Version As FlatButton
    Friend WithEvents NameButton As FlatButton
End Class
