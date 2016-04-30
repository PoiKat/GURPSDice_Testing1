Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lstResults.Items.Clear()
        txtQuantRolls.Text = 1
        ClearRolls()
    End Sub

    Private Sub btnRoll_Click(sender As Object, e As EventArgs) Handles btnRoll.Click
        Dim die1, die2, die3, roll, skill, bonPen, result, final As Integer
        Dim msg1, msgSuccess, msgFail, msgRightOn As String
        For i As Integer = 1 To Val(txtQuantRolls.Text)
            skill = Val(txtSkill.Text)
            bonPen = Val(txtBonPen.Text)
            Dim rand As New Random
            die1 = rand.Next(1, 6)
            die2 = rand.Next(1, 6)
            die3 = rand.Next(1, 6)
            roll = die1 + die2 + die3
            result = skill + bonPen
            final = result - roll
            msg1 = "Your roll was " & roll & "."
            msgSuccess = "You made your effective skill by " & Math.Abs(final) & "."
            msgFail = "You missed your effective skill by " & Math.Abs(final) & "."
            msgRightOn = "You made your effective skill right on!"
            lstResults.Items.Add(msg1)
            If result > roll Then
                lstResults.Items.Add(msgSuccess)
                lstResults.Items.Add("")
            ElseIf result < roll Then
                lstResults.Items.Add(msgFail)
                lstResults.Items.Add("")
            Else

            End If
        Next
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()
        txtBonPen.Text = 0
        txtSkill.Text = 0
        txtQuantRolls.Text = 1
    End Sub
    Private Sub ClearRolls()
        txtBonPen.Text = 0
        txtSkill.Text = 0
        txtSkill.Focus()
    End Sub
End Class
