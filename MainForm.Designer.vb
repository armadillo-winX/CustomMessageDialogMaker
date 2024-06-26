<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MessageTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TitleTextBox = New System.Windows.Forms.TextBox()
        Me.OKButton = New System.Windows.Forms.Button()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.IconComboBox = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "メッセージ"
        '
        'MessageTextBox
        '
        Me.MessageTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MessageTextBox.Location = New System.Drawing.Point(16, 44)
        Me.MessageTextBox.Multiline = True
        Me.MessageTextBox.Name = "MessageTextBox"
        Me.MessageTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.MessageTextBox.Size = New System.Drawing.Size(307, 59)
        Me.MessageTextBox.TabIndex = 1
        Me.MessageTextBox.Text = "Hello World!"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "タイトル"
        '
        'TitleTextBox
        '
        Me.TitleTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TitleTextBox.Location = New System.Drawing.Point(16, 147)
        Me.TitleTextBox.MaxLength = 15
        Me.TitleTextBox.Name = "TitleTextBox"
        Me.TitleTextBox.Size = New System.Drawing.Size(307, 23)
        Me.TitleTextBox.TabIndex = 3
        Me.TitleTextBox.Text = "Sample"
        '
        'OKButton
        '
        Me.OKButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OKButton.Location = New System.Drawing.Point(167, 265)
        Me.OKButton.Name = "OKButton"
        Me.OKButton.Size = New System.Drawing.Size(75, 26)
        Me.OKButton.TabIndex = 5
        Me.OKButton.Text = "OK"
        Me.OKButton.UseVisualStyleBackColor = True
        '
        'CloseButton
        '
        Me.CloseButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CloseButton.Location = New System.Drawing.Point(248, 265)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(75, 26)
        Me.CloseButton.TabIndex = 6
        Me.CloseButton.Text = "閉じる"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 192)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 15)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "アイコンの選択:"
        '
        'IconComboBox
        '
        Me.IconComboBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IconComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.IconComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.IconComboBox.FormattingEnabled = True
        Me.IconComboBox.Items.AddRange(New Object() {"Information", "Exclamation", "Error", "Question", "None"})
        Me.IconComboBox.Location = New System.Drawing.Point(103, 189)
        Me.IconComboBox.Name = "IconComboBox"
        Me.IconComboBox.Size = New System.Drawing.Size(220, 23)
        Me.IconComboBox.TabIndex = 8
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(335, 303)
        Me.Controls.Add(Me.IconComboBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.OKButton)
        Me.Controls.Add(Me.TitleTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.MessageTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Meiryo UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents MessageTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TitleTextBox As TextBox
    Friend WithEvents OKButton As Button
    Friend WithEvents CloseButton As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents IconComboBox As ComboBox
End Class
