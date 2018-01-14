Public Class formCountdown

    Private displayedNumber As Integer

    Friend Sub countdownFrom(ByVal seconds As Integer)
        'Performs the countdown with the given number of seconds.
        lblCountdown.Text = seconds
        displayedNumber = seconds
        timerCountdown.Start()
    End Sub

    Private Sub timerCountdown_Tick(sender As System.Object, e As System.EventArgs) Handles timerCountdown.Tick
        displayedNumber -= 1
        lblCountdown.Text = displayedNumber

        If displayedNumber = 0 Then
            timerCountdown.Stop()
            formMulti.Show()
            Me.Close()
        End If
    End Sub

End Class