Public Class Form3

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim Turn As New Random
        Dim TurnResult As Integer
        TurnResult = Turn.Next(1, 3)

        If TurnResult = 1 Then
            PlayerTurnLabel.Text = "Red Turn"
            PlayerTurnLabel.ForeColor = Color.Red
        Else
            PlayerTurnLabel.Text = “Blue Turn"
            PlayerTurnLabel.ForeColor = Color.Blue
        End If

        OvalShape1.Visible = False
        OvalShape2.Visible = False
        OvalShape3.Visible = False
        OvalShape4.Visible = False
        OvalShape5.Visible = False
        OvalShape6.Visible = False
        OvalShape7.Visible = False
        OvalShape8.Visible = False
        OvalShape9.Visible = False
        LineShape1.Visible = False
        LineShape2.Visible = False
        LineShape3.Visible = False
        LineShape4.Visible = False
        LineShape5.Visible = False
        LineShape6.Visible = False
        LineShape7.Visible = False
        LineShape8.Visible = False
        LineShape9.Visible = False
        LineShape10.Visible = False
        LineShape11.Visible = False
        LineShape12.Visible = False
        LineShape13.Visible = False
        LineShape14.Visible = False
        LineShape15.Visible = False
        LineShape16.Visible = False
        LineShape17.Visible = False
        LineShape18.Visible = False

    End Sub

    Private Sub RectangleShape1_Click(sender As Object, e As EventArgs) Handles RectangleShape1.Click

        If PlayerTurnLabel.Text = "Red Turn" Then
            LineShape1.Visible = True
            LineShape2.Visible = True
        ElseIf PlayerTurnLabel.Text = "Blue Turn" Then
            OvalShape1.Visible = True
        End If

        If PlayerTurnLabel.Text = "Red Turn" Then
            PlayerTurnLabel.Text = "Blue Turn"
            PlayerTurnLabel.ForeColor = Color.Blue
        ElseIf PlayerTurnLabel.Text = "Blue Turn" Then
            PlayerTurnLabel.Text = "Red Turn"
            PlayerTurnLabel.ForeColor = Color.Red
        End If

        If LineShape1.Visible = True Then
            RectangleShape1.Enabled = False
        ElseIf OvalShape1.Visible = True Then
            RectangleShape1.Enabled = False
        End If

    End Sub

    Private Sub RectangleShape2_Click(sender As Object, e As EventArgs) Handles RectangleShape2.Click

        If PlayerTurnLabel.Text = "Red Turn" Then
            LineShape3.Visible = True
            LineShape4.Visible = True
        ElseIf PlayerTurnLabel.Text = "Blue Turn" Then
            OvalShape2.Visible = True
        End If

        If PlayerTurnLabel.Text = "Red Turn" Then
            PlayerTurnLabel.Text = "Blue Turn"
            PlayerTurnLabel.ForeColor = Color.Blue
        ElseIf PlayerTurnLabel.Text = "Blue Turn" Then
            PlayerTurnLabel.Text = "Red Turn"
            PlayerTurnLabel.ForeColor = Color.Red
        End If

        If LineShape3.Visible = True Then
            RectangleShape2.Enabled = False
        ElseIf OvalShape2.Visible = True Then
            RectangleShape2.Enabled = False
        End If

    End Sub

    Private Sub RectangleShape3_Click(sender As Object, e As EventArgs) Handles RectangleShape3.Click

        If PlayerTurnLabel.Text = "Red Turn" Then
            LineShape5.Visible = True
            LineShape6.Visible = True
        ElseIf PlayerTurnLabel.Text = "Blue Turn" Then
            OvalShape3.Visible = True
        End If

        If PlayerTurnLabel.Text = "Red Turn" Then
            PlayerTurnLabel.Text = "Blue Turn"
            PlayerTurnLabel.ForeColor = Color.Blue
        ElseIf PlayerTurnLabel.Text = "Blue Turn" Then
            PlayerTurnLabel.Text = "Red Turn"
            PlayerTurnLabel.ForeColor = Color.Red
        End If

        If LineShape5.Visible = True Then
            RectangleShape3.Enabled = False
        ElseIf OvalShape3.Visible = True Then
            RectangleShape3.Enabled = False
        End If

    End Sub

    Private Sub RectangleShape4_Click(sender As Object, e As EventArgs) Handles RectangleShape4.Click

        If PlayerTurnLabel.Text = "Red Turn" Then
            LineShape7.Visible = True
            LineShape8.Visible = True
        ElseIf PlayerTurnLabel.Text = "Blue Turn" Then
            OvalShape4.Visible = True
        End If

        If PlayerTurnLabel.Text = "Red Turn" Then
            PlayerTurnLabel.Text = "Blue Turn"
            PlayerTurnLabel.ForeColor = Color.Blue
        ElseIf PlayerTurnLabel.Text = "Blue Turn" Then
            PlayerTurnLabel.Text = "Red Turn"
            PlayerTurnLabel.ForeColor = Color.Red
        End If

        If LineShape7.Visible = True Then
            RectangleShape4.Enabled = False
        ElseIf OvalShape4.Visible = True Then
            RectangleShape4.Enabled = False
        End If

    End Sub

    Private Sub RectangleShape5_Click(sender As Object, e As EventArgs) Handles RectangleShape5.Click

        If PlayerTurnLabel.Text = "Red Turn" Then
            LineShape9.Visible = True
            LineShape10.Visible = True
        ElseIf PlayerTurnLabel.Text = "Blue Turn" Then
            OvalShape5.Visible = True
        End If

        If PlayerTurnLabel.Text = "Red Turn" Then
            PlayerTurnLabel.Text = "Blue Turn"
            PlayerTurnLabel.ForeColor = Color.Blue
        ElseIf PlayerTurnLabel.Text = "Blue Turn" Then
            PlayerTurnLabel.Text = "Red Turn"
            PlayerTurnLabel.ForeColor = Color.Red
        End If

        If LineShape9.Visible = True Then
            RectangleShape5.Enabled = False
        ElseIf OvalShape5.Visible = True Then
            RectangleShape5.Enabled = False
        End If

    End Sub

    Private Sub RectangleShape6_Click(sender As Object, e As EventArgs) Handles RectangleShape6.Click

        If PlayerTurnLabel.Text = "Red Turn" Then
            LineShape11.Visible = True
            LineShape12.Visible = True
        ElseIf PlayerTurnLabel.Text = "Blue Turn" Then
            OvalShape6.Visible = True
        End If

        If PlayerTurnLabel.Text = "Red Turn" Then
            PlayerTurnLabel.Text = "Blue Turn"
            PlayerTurnLabel.ForeColor = Color.Blue
        ElseIf PlayerTurnLabel.Text = "Blue Turn" Then
            PlayerTurnLabel.Text = "Red Turn"
            PlayerTurnLabel.ForeColor = Color.Red
        End If

        If LineShape11.Visible = True Then
            RectangleShape6.Enabled = False
        ElseIf OvalShape6.Visible = True Then
            RectangleShape6.Enabled = False
        End If

    End Sub

    Private Sub RectangleShape7_Click(sender As Object, e As EventArgs) Handles RectangleShape7.Click

        If PlayerTurnLabel.Text = "Red Turn" Then
            LineShape13.Visible = True
            LineShape14.Visible = True
        ElseIf PlayerTurnLabel.Text = "Blue Turn" Then
            OvalShape7.Visible = True
        End If

        If PlayerTurnLabel.Text = "Red Turn" Then
            PlayerTurnLabel.Text = "Blue Turn"
            PlayerTurnLabel.ForeColor = Color.Blue
        ElseIf PlayerTurnLabel.Text = "Blue Turn" Then
            PlayerTurnLabel.Text = "Red Turn"
            PlayerTurnLabel.ForeColor = Color.Red
        End If

        If LineShape13.Visible = True Then
            RectangleShape7.Enabled = False
        ElseIf OvalShape7.Visible = True Then
            RectangleShape7.Enabled = False
        End If

    End Sub

    Private Sub RectangleShape8_Click(sender As Object, e As EventArgs) Handles RectangleShape8.Click

        If PlayerTurnLabel.Text = "Red Turn" Then
            LineShape15.Visible = True
            LineShape16.Visible = True
        ElseIf PlayerTurnLabel.Text = "Blue Turn" Then
            OvalShape8.Visible = True
        End If

        If PlayerTurnLabel.Text = "Red Turn" Then
            PlayerTurnLabel.Text = "Blue Turn"
            PlayerTurnLabel.ForeColor = Color.Blue
        ElseIf PlayerTurnLabel.Text = "Blue Turn" Then
            PlayerTurnLabel.Text = "Red Turn"
            PlayerTurnLabel.ForeColor = Color.Red
        End If

        If LineShape15.Visible = True Then
            RectangleShape8.Enabled = False
        ElseIf OvalShape8.Visible = True Then
            RectangleShape8.Enabled = False
        End If

    End Sub

    Private Sub RectangleShape9_Click(sender As Object, e As EventArgs) Handles RectangleShape9.Click

        If PlayerTurnLabel.Text = "Red Turn" Then
            LineShape17.Visible = True
            LineShape18.Visible = True
        ElseIf PlayerTurnLabel.Text = "Blue Turn" Then
            OvalShape9.Visible = True
        End If

        If PlayerTurnLabel.Text = "Red Turn" Then
            PlayerTurnLabel.Text = "Blue Turn"
            PlayerTurnLabel.ForeColor = Color.Blue
        ElseIf PlayerTurnLabel.Text = "Blue Turn" Then
            PlayerTurnLabel.Text = "Red Turn"
            PlayerTurnLabel.ForeColor = Color.Red
        End If

        If LineShape17.Visible = True Then
            RectangleShape9.Enabled = False
        ElseIf OvalShape9.Visible = True Then
            RectangleShape9.Enabled = False
        End If

    End Sub

    Private Sub RoundWin_Show(sender As System.Object, e As System.EventArgs) Handles Me.MouseMove

        Dim BlueWin, RedWin As String
        BlueWin = Val(BlueWinCounter.Text) + 1
        RedWin = Val(RedWinCounter.Text) + 1

        If OvalShape1.Visible = True And OvalShape2.Visible = True And OvalShape3.Visible = True Then
            BlueWinCounter.Text = BlueWin
        End If

        If OvalShape4.Visible = True And OvalShape5.Visible = True And OvalShape6.Visible = True Then
            BlueWinCounter.Text = BlueWin
        End If

        If OvalShape7.Visible = True And OvalShape8.Visible = True And OvalShape9.Visible = True Then
            BlueWinCounter.Text = BlueWin
        End If

        If OvalShape1.Visible = True And OvalShape4.Visible = True And OvalShape7.Visible = True Then
            BlueWinCounter.Text = BlueWin
        End If

        If OvalShape2.Visible = True And OvalShape5.Visible = True And OvalShape8.Visible = True Then
            BlueWinCounter.Text = BlueWin
        End If

        If OvalShape3.Visible = True And OvalShape6.Visible = True And OvalShape9.Visible = True Then
            BlueWinCounter.Text = BlueWin
        End If

        If OvalShape1.Visible = True And OvalShape5.Visible = True And OvalShape9.Visible = True Then
            BlueWinCounter.Text = BlueWin
        End If

        If OvalShape3.Visible = True And OvalShape5.Visible = True And OvalShape7.Visible = True Then
            BlueWinCounter.Text = BlueWin
        End If

        If LineShape1.Visible = True And LineShape3.Visible = True And LineShape5.Visible = True Then
            RedWinCounter.Text = RedWin
        End If

        If LineShape7.Visible = True And LineShape9.Visible = True And LineShape11.Visible = True Then
            RedWinCounter.Text = RedWin
        End If

        If LineShape13.Visible = True And LineShape15.Visible = True And LineShape17.Visible = True Then
            RedWinCounter.Text = RedWin
        End If

        If LineShape1.Visible = True And LineShape7.Visible = True And LineShape13.Visible = True Then
            RedWinCounter.Text = RedWin
        End If

        If LineShape3.Visible = True And LineShape9.Visible = True And LineShape15.Visible = True Then
            RedWinCounter.Text = RedWin
        End If

        If LineShape5.Visible = True And LineShape11.Visible = True And LineShape17.Visible = True Then
            RedWinCounter.Text = RedWin
        End If

        If LineShape1.Visible = True And LineShape9.Visible = True And LineShape17.Visible = True Then
            RedWinCounter.Text = RedWin
        End If

        If LineShape5.Visible = True And LineShape9.Visible = True And LineShape13.Visible = True Then
            RedWinCounter.Text = RedWin
        End If

        If OvalShape1.Visible = True And OvalShape2.Visible = True And OvalShape3.Visible = True Or
        OvalShape4.Visible = True And OvalShape5.Visible = True And OvalShape6.Visible = True Or
        OvalShape7.Visible = True And OvalShape8.Visible = True And OvalShape9.Visible = True Or
        OvalShape1.Visible = True And OvalShape4.Visible = True And OvalShape7.Visible = True Or
        OvalShape2.Visible = True And OvalShape5.Visible = True And OvalShape8.Visible = True Or
        OvalShape3.Visible = True And OvalShape6.Visible = True And OvalShape9.Visible = True Or
        OvalShape1.Visible = True And OvalShape5.Visible = True And OvalShape9.Visible = True Or
        OvalShape3.Visible = True And OvalShape5.Visible = True And OvalShape7.Visible = True Or
        LineShape1.Visible = True And LineShape3.Visible = True And LineShape5.Visible = True Or
        LineShape7.Visible = True And LineShape9.Visible = True And LineShape11.Visible = True Or
        LineShape13.Visible = True And LineShape15.Visible = True And LineShape17.Visible = True Or
        LineShape1.Visible = True And LineShape7.Visible = True And LineShape13.Visible = True Or
        LineShape3.Visible = True And LineShape9.Visible = True And LineShape15.Visible = True Or
        LineShape5.Visible = True And LineShape11.Visible = True And LineShape17.Visible = True Or
        LineShape1.Visible = True And LineShape9.Visible = True And LineShape17.Visible = True Or
        LineShape5.Visible = True And LineShape9.Visible = True And LineShape13.Visible = True Or
        RectangleShape1.Enabled = False And RectangleShape2.Enabled = False And RectangleShape3.Enabled = False And
        RectangleShape4.Enabled = False And RectangleShape5.Enabled = False And RectangleShape6.Enabled = False And
        RectangleShape7.Enabled = False And RectangleShape8.Enabled = False And RectangleShape9.Enabled = False Then
            OvalShape1.Visible = False
            OvalShape2.Visible = False
            OvalShape3.Visible = False
            OvalShape4.Visible = False
            OvalShape5.Visible = False
            OvalShape6.Visible = False
            OvalShape7.Visible = False
            OvalShape8.Visible = False
            OvalShape9.Visible = False
            LineShape1.Visible = False
            LineShape2.Visible = False
            LineShape3.Visible = False
            LineShape4.Visible = False
            LineShape5.Visible = False
            LineShape6.Visible = False
            LineShape7.Visible = False
            LineShape8.Visible = False
            LineShape9.Visible = False
            LineShape10.Visible = False
            LineShape11.Visible = False
            LineShape12.Visible = False
            LineShape13.Visible = False
            LineShape14.Visible = False
            LineShape15.Visible = False
            LineShape16.Visible = False
            LineShape17.Visible = False
            LineShape18.Visible = False
            RectangleShape1.Enabled = True
            RectangleShape2.Enabled = True
            RectangleShape3.Enabled = True
            RectangleShape4.Enabled = True
            RectangleShape5.Enabled = True
            RectangleShape6.Enabled = True
            RectangleShape7.Enabled = True
            RectangleShape8.Enabled = True
            RectangleShape9.Enabled = True
        End If

        If Val(BlueWinCounter.Text) = 3 Then
            AboutBox1.TextBoxDescription.Text = "Blue Win!"
            Me.Hide()
            AboutBox1.Show()

        ElseIf Val(RedWinCounter.Text) = 3 Then
            AboutBox1.TextBoxDescription.Text = "Red Win!"
            Me.Hide()
            AboutBox1.Show()
        End If

    End Sub

End Class