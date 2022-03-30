<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form, bileşen listesini temizlemeyi bırakmayı geçersiz kılar.
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

    'Windows Form Tasarımcısı tarafından gerektirilir
    Private components As System.ComponentModel.IContainer

    'NOT: Aşağıdaki yordam Windows Form Tasarımcısı için gereklidir
    'Windows Form Tasarımcısı kullanılarak değiştirilebilir.  
    'Kod düzenleyicisini kullanarak değiştirmeyin.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RedWinCounter = New System.Windows.Forms.TextBox()
        Me.BlueWinCounter = New System.Windows.Forms.TextBox()
        Me.PlayerTurnLabel = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.OvalShape9 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.LineShape18 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape17 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.OvalShape8 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.LineShape16 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape15 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.OvalShape7 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.LineShape14 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape13 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.OvalShape6 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.LineShape12 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape11 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.OvalShape5 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.LineShape10 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape9 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.OvalShape4 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.LineShape8 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape7 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.OvalShape3 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.LineShape6 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape5 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.OvalShape2 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.LineShape4 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.OvalShape1 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.RectangleShape9 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape8 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape7 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape4 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape5 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape6 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape3 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(60, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Red"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(360, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Blue"
        '
        'RedWinCounter
        '
        Me.RedWinCounter.Location = New System.Drawing.Point(25, 62)
        Me.RedWinCounter.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RedWinCounter.Name = "RedWinCounter"
        Me.RedWinCounter.Size = New System.Drawing.Size(100, 22)
        Me.RedWinCounter.TabIndex = 2
        Me.RedWinCounter.Text = "0"
        '
        'BlueWinCounter
        '
        Me.BlueWinCounter.Location = New System.Drawing.Point(325, 62)
        Me.BlueWinCounter.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BlueWinCounter.Name = "BlueWinCounter"
        Me.BlueWinCounter.Size = New System.Drawing.Size(100, 22)
        Me.BlueWinCounter.TabIndex = 3
        Me.BlueWinCounter.Text = "0"
        '
        'PlayerTurnLabel
        '
        Me.PlayerTurnLabel.AutoSize = True
        Me.PlayerTurnLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold)
        Me.PlayerTurnLabel.Location = New System.Drawing.Point(176, 42)
        Me.PlayerTurnLabel.Name = "PlayerTurnLabel"
        Me.PlayerTurnLabel.Size = New System.Drawing.Size(95, 29)
        Me.PlayerTurnLabel.TabIndex = 4
        Me.PlayerTurnLabel.Text = "Label3"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.OvalShape9, Me.LineShape18, Me.LineShape17, Me.OvalShape8, Me.LineShape16, Me.LineShape15, Me.OvalShape7, Me.LineShape14, Me.LineShape13, Me.OvalShape6, Me.LineShape12, Me.LineShape11, Me.OvalShape5, Me.LineShape10, Me.LineShape9, Me.OvalShape4, Me.LineShape8, Me.LineShape7, Me.OvalShape3, Me.LineShape6, Me.LineShape5, Me.OvalShape2, Me.LineShape4, Me.LineShape3, Me.LineShape2, Me.LineShape1, Me.OvalShape1, Me.RectangleShape9, Me.RectangleShape8, Me.RectangleShape7, Me.RectangleShape4, Me.RectangleShape5, Me.RectangleShape6, Me.RectangleShape3, Me.RectangleShape2, Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(521, 464)
        Me.ShapeContainer1.TabIndex = 5
        Me.ShapeContainer1.TabStop = False
        '
        'OvalShape9
        '
        Me.OvalShape9.BorderColor = System.Drawing.SystemColors.MenuHighlight
        Me.OvalShape9.BorderWidth = 9
        Me.OvalShape9.Location = New System.Drawing.Point(268, 268)
        Me.OvalShape9.Name = "OvalShape9"
        Me.OvalShape9.Size = New System.Drawing.Size(50, 50)
        '
        'LineShape18
        '
        Me.LineShape18.BorderColor = System.Drawing.Color.Red
        Me.LineShape18.BorderWidth = 9
        Me.LineShape18.Name = "LineShape18"
        Me.LineShape18.X1 = 263
        Me.LineShape18.X2 = 314
        Me.LineShape18.Y1 = 263
        Me.LineShape18.Y2 = 312
        '
        'LineShape17
        '
        Me.LineShape17.BorderColor = System.Drawing.Color.Red
        Me.LineShape17.BorderWidth = 9
        Me.LineShape17.Name = "LineShape17"
        Me.LineShape17.X1 = 319
        Me.LineShape17.X2 = 273
        Me.LineShape17.Y1 = 266
        Me.LineShape17.Y2 = 312
        '
        'OvalShape8
        '
        Me.OvalShape8.BorderColor = System.Drawing.SystemColors.MenuHighlight
        Me.OvalShape8.BorderWidth = 9
        Me.OvalShape8.Location = New System.Drawing.Point(191, 270)
        Me.OvalShape8.Name = "OvalShape8"
        Me.OvalShape8.Size = New System.Drawing.Size(50, 50)
        '
        'LineShape16
        '
        Me.LineShape16.BorderColor = System.Drawing.Color.Red
        Me.LineShape16.BorderWidth = 9
        Me.LineShape16.Name = "LineShape16"
        Me.LineShape16.X1 = 186
        Me.LineShape16.X2 = 237
        Me.LineShape16.Y1 = 265
        Me.LineShape16.Y2 = 314
        '
        'LineShape15
        '
        Me.LineShape15.BorderColor = System.Drawing.Color.Red
        Me.LineShape15.BorderWidth = 9
        Me.LineShape15.Name = "LineShape15"
        Me.LineShape15.X1 = 242
        Me.LineShape15.X2 = 196
        Me.LineShape15.Y1 = 268
        Me.LineShape15.Y2 = 314
        '
        'OvalShape7
        '
        Me.OvalShape7.BorderColor = System.Drawing.SystemColors.MenuHighlight
        Me.OvalShape7.BorderWidth = 9
        Me.OvalShape7.Location = New System.Drawing.Point(114, 273)
        Me.OvalShape7.Name = "OvalShape7"
        Me.OvalShape7.Size = New System.Drawing.Size(50, 50)
        '
        'LineShape14
        '
        Me.LineShape14.BorderColor = System.Drawing.Color.Red
        Me.LineShape14.BorderWidth = 9
        Me.LineShape14.Name = "LineShape14"
        Me.LineShape14.X1 = 109
        Me.LineShape14.X2 = 160
        Me.LineShape14.Y1 = 268
        Me.LineShape14.Y2 = 317
        '
        'LineShape13
        '
        Me.LineShape13.BorderColor = System.Drawing.Color.Red
        Me.LineShape13.BorderWidth = 9
        Me.LineShape13.Name = "LineShape13"
        Me.LineShape13.X1 = 165
        Me.LineShape13.X2 = 119
        Me.LineShape13.Y1 = 271
        Me.LineShape13.Y2 = 317
        '
        'OvalShape6
        '
        Me.OvalShape6.BorderColor = System.Drawing.SystemColors.MenuHighlight
        Me.OvalShape6.BorderWidth = 9
        Me.OvalShape6.Location = New System.Drawing.Point(264, 198)
        Me.OvalShape6.Name = "OvalShape6"
        Me.OvalShape6.Size = New System.Drawing.Size(50, 50)
        '
        'LineShape12
        '
        Me.LineShape12.BorderColor = System.Drawing.Color.Red
        Me.LineShape12.BorderWidth = 9
        Me.LineShape12.Name = "LineShape12"
        Me.LineShape12.X1 = 259
        Me.LineShape12.X2 = 310
        Me.LineShape12.Y1 = 193
        Me.LineShape12.Y2 = 242
        '
        'LineShape11
        '
        Me.LineShape11.BorderColor = System.Drawing.Color.Red
        Me.LineShape11.BorderWidth = 9
        Me.LineShape11.Name = "LineShape11"
        Me.LineShape11.X1 = 315
        Me.LineShape11.X2 = 269
        Me.LineShape11.Y1 = 196
        Me.LineShape11.Y2 = 242
        '
        'OvalShape5
        '
        Me.OvalShape5.BorderColor = System.Drawing.SystemColors.MenuHighlight
        Me.OvalShape5.BorderWidth = 9
        Me.OvalShape5.Location = New System.Drawing.Point(188, 196)
        Me.OvalShape5.Name = "OvalShape5"
        Me.OvalShape5.Size = New System.Drawing.Size(50, 50)
        '
        'LineShape10
        '
        Me.LineShape10.BorderColor = System.Drawing.Color.Red
        Me.LineShape10.BorderWidth = 9
        Me.LineShape10.Name = "LineShape10"
        Me.LineShape10.X1 = 183
        Me.LineShape10.X2 = 234
        Me.LineShape10.Y1 = 191
        Me.LineShape10.Y2 = 240
        '
        'LineShape9
        '
        Me.LineShape9.BorderColor = System.Drawing.Color.Red
        Me.LineShape9.BorderWidth = 9
        Me.LineShape9.Name = "LineShape9"
        Me.LineShape9.X1 = 239
        Me.LineShape9.X2 = 193
        Me.LineShape9.Y1 = 194
        Me.LineShape9.Y2 = 240
        '
        'OvalShape4
        '
        Me.OvalShape4.BorderColor = System.Drawing.SystemColors.MenuHighlight
        Me.OvalShape4.BorderWidth = 9
        Me.OvalShape4.Location = New System.Drawing.Point(111, 200)
        Me.OvalShape4.Name = "OvalShape4"
        Me.OvalShape4.Size = New System.Drawing.Size(50, 50)
        '
        'LineShape8
        '
        Me.LineShape8.BorderColor = System.Drawing.Color.Red
        Me.LineShape8.BorderWidth = 9
        Me.LineShape8.Name = "LineShape8"
        Me.LineShape8.X1 = 106
        Me.LineShape8.X2 = 157
        Me.LineShape8.Y1 = 195
        Me.LineShape8.Y2 = 244
        '
        'LineShape7
        '
        Me.LineShape7.BorderColor = System.Drawing.Color.Red
        Me.LineShape7.BorderWidth = 9
        Me.LineShape7.Name = "LineShape7"
        Me.LineShape7.X1 = 162
        Me.LineShape7.X2 = 116
        Me.LineShape7.Y1 = 198
        Me.LineShape7.Y2 = 244
        '
        'OvalShape3
        '
        Me.OvalShape3.BorderColor = System.Drawing.SystemColors.MenuHighlight
        Me.OvalShape3.BorderWidth = 9
        Me.OvalShape3.Location = New System.Drawing.Point(266, 122)
        Me.OvalShape3.Name = "OvalShape3"
        Me.OvalShape3.Size = New System.Drawing.Size(50, 50)
        '
        'LineShape6
        '
        Me.LineShape6.BorderColor = System.Drawing.Color.Red
        Me.LineShape6.BorderWidth = 9
        Me.LineShape6.Name = "LineShape6"
        Me.LineShape6.X1 = 261
        Me.LineShape6.X2 = 318
        Me.LineShape6.Y1 = 117
        Me.LineShape6.Y2 = 168
        '
        'LineShape5
        '
        Me.LineShape5.BorderColor = System.Drawing.Color.Red
        Me.LineShape5.BorderWidth = 9
        Me.LineShape5.Name = "LineShape5"
        Me.LineShape5.X1 = 317
        Me.LineShape5.X2 = 271
        Me.LineShape5.Y1 = 120
        Me.LineShape5.Y2 = 166
        '
        'OvalShape2
        '
        Me.OvalShape2.BorderColor = System.Drawing.SystemColors.MenuHighlight
        Me.OvalShape2.BorderWidth = 9
        Me.OvalShape2.Location = New System.Drawing.Point(189, 125)
        Me.OvalShape2.Name = "OvalShape2"
        Me.OvalShape2.Size = New System.Drawing.Size(50, 50)
        '
        'LineShape4
        '
        Me.LineShape4.BorderColor = System.Drawing.Color.Red
        Me.LineShape4.BorderWidth = 9
        Me.LineShape4.Name = "LineShape4"
        Me.LineShape4.X1 = 184
        Me.LineShape4.X2 = 235
        Me.LineShape4.Y1 = 120
        Me.LineShape4.Y2 = 169
        '
        'LineShape3
        '
        Me.LineShape3.BorderColor = System.Drawing.Color.Red
        Me.LineShape3.BorderWidth = 9
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 240
        Me.LineShape3.X2 = 194
        Me.LineShape3.Y1 = 123
        Me.LineShape3.Y2 = 169
        '
        'LineShape2
        '
        Me.LineShape2.BorderColor = System.Drawing.Color.Red
        Me.LineShape2.BorderWidth = 9
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 166
        Me.LineShape2.X2 = 120
        Me.LineShape2.Y1 = 118
        Me.LineShape2.Y2 = 164
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.Color.Red
        Me.LineShape1.BorderWidth = 9
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 110
        Me.LineShape1.X2 = 161
        Me.LineShape1.Y1 = 115
        Me.LineShape1.Y2 = 164
        '
        'OvalShape1
        '
        Me.OvalShape1.BorderColor = System.Drawing.SystemColors.MenuHighlight
        Me.OvalShape1.BorderWidth = 9
        Me.OvalShape1.Location = New System.Drawing.Point(115, 120)
        Me.OvalShape1.Name = "OvalShape1"
        Me.OvalShape1.Size = New System.Drawing.Size(50, 50)
        '
        'RectangleShape9
        '
        Me.RectangleShape9.Location = New System.Drawing.Point(253, 257)
        Me.RectangleShape9.Name = "RectangleShape9"
        Me.RectangleShape9.Size = New System.Drawing.Size(75, 75)
        '
        'RectangleShape8
        '
        Me.RectangleShape8.Location = New System.Drawing.Point(177, 257)
        Me.RectangleShape8.Name = "RectangleShape8"
        Me.RectangleShape8.Size = New System.Drawing.Size(75, 75)
        '
        'RectangleShape7
        '
        Me.RectangleShape7.Location = New System.Drawing.Point(101, 257)
        Me.RectangleShape7.Name = "RectangleShape7"
        Me.RectangleShape7.Size = New System.Drawing.Size(75, 75)
        '
        'RectangleShape4
        '
        Me.RectangleShape4.Location = New System.Drawing.Point(101, 183)
        Me.RectangleShape4.Name = "RectangleShape4"
        Me.RectangleShape4.Size = New System.Drawing.Size(75, 75)
        '
        'RectangleShape5
        '
        Me.RectangleShape5.Location = New System.Drawing.Point(177, 183)
        Me.RectangleShape5.Name = "RectangleShape5"
        Me.RectangleShape5.Size = New System.Drawing.Size(75, 75)
        '
        'RectangleShape6
        '
        Me.RectangleShape6.Location = New System.Drawing.Point(253, 183)
        Me.RectangleShape6.Name = "RectangleShape6"
        Me.RectangleShape6.Size = New System.Drawing.Size(75, 75)
        '
        'RectangleShape3
        '
        Me.RectangleShape3.Location = New System.Drawing.Point(253, 107)
        Me.RectangleShape3.Name = "RectangleShape3"
        Me.RectangleShape3.Size = New System.Drawing.Size(75, 75)
        '
        'RectangleShape2
        '
        Me.RectangleShape2.Location = New System.Drawing.Point(177, 107)
        Me.RectangleShape2.Name = "RectangleShape2"
        Me.RectangleShape2.Size = New System.Drawing.Size(75, 75)
        '
        'RectangleShape1
        '
        Me.RectangleShape1.Location = New System.Drawing.Point(101, 107)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(75, 75)
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(521, 464)
        Me.Controls.Add(Me.PlayerTurnLabel)
        Me.Controls.Add(Me.BlueWinCounter)
        Me.Controls.Add(Me.RedWinCounter)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tic Tac Toe"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents RedWinCounter As TextBox
    Friend WithEvents BlueWinCounter As TextBox
    Friend WithEvents PlayerTurnLabel As Label
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape4 As PowerPacks.RectangleShape
    Friend WithEvents RectangleShape5 As PowerPacks.RectangleShape
    Friend WithEvents RectangleShape6 As PowerPacks.RectangleShape
    Friend WithEvents RectangleShape3 As PowerPacks.RectangleShape
    Friend WithEvents RectangleShape2 As PowerPacks.RectangleShape
    Friend WithEvents RectangleShape1 As PowerPacks.RectangleShape
    Friend WithEvents OvalShape9 As PowerPacks.OvalShape
    Friend WithEvents LineShape18 As PowerPacks.LineShape
    Friend WithEvents LineShape17 As PowerPacks.LineShape
    Friend WithEvents OvalShape8 As PowerPacks.OvalShape
    Friend WithEvents LineShape16 As PowerPacks.LineShape
    Friend WithEvents LineShape15 As PowerPacks.LineShape
    Friend WithEvents OvalShape7 As PowerPacks.OvalShape
    Friend WithEvents LineShape14 As PowerPacks.LineShape
    Friend WithEvents LineShape13 As PowerPacks.LineShape
    Friend WithEvents OvalShape6 As PowerPacks.OvalShape
    Friend WithEvents LineShape12 As PowerPacks.LineShape
    Friend WithEvents LineShape11 As PowerPacks.LineShape
    Friend WithEvents OvalShape5 As PowerPacks.OvalShape
    Friend WithEvents LineShape10 As PowerPacks.LineShape
    Friend WithEvents LineShape9 As PowerPacks.LineShape
    Friend WithEvents OvalShape4 As PowerPacks.OvalShape
    Friend WithEvents LineShape8 As PowerPacks.LineShape
    Friend WithEvents LineShape7 As PowerPacks.LineShape
    Friend WithEvents OvalShape3 As PowerPacks.OvalShape
    Friend WithEvents LineShape6 As PowerPacks.LineShape
    Friend WithEvents LineShape5 As PowerPacks.LineShape
    Friend WithEvents OvalShape2 As PowerPacks.OvalShape
    Friend WithEvents LineShape4 As PowerPacks.LineShape
    Friend WithEvents LineShape3 As PowerPacks.LineShape
    Friend WithEvents LineShape2 As PowerPacks.LineShape
    Friend WithEvents LineShape1 As PowerPacks.LineShape
    Friend WithEvents OvalShape1 As PowerPacks.OvalShape
    Friend WithEvents RectangleShape9 As PowerPacks.RectangleShape
    Friend WithEvents RectangleShape8 As PowerPacks.RectangleShape
    Friend WithEvents RectangleShape7 As PowerPacks.RectangleShape
End Class
