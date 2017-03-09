Public Class Leaderboard

    Private Sub LogOutButton_Click(sender As Object, e As EventArgs) Handles LogOutButton.Click
        Me.Hide()
        Login.Show()

    End Sub

    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
        Me.Hide()
        HomeUser.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        leaderboardInfoPopup.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AddFriend.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FriendRequest.Show()

    End Sub

    Private Sub ResumeQuizToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResumeQuizToolStripMenuItem.Click
        ResumeQuiz.Show()
    End Sub
End Class