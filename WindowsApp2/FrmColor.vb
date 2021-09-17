Public Class FrmColor
    Dim iCount As Integer ' Counter

    Private Sub HSRed_Scroll(sender As Object, e As ScrollEventArgs) Handles HSRed.Scroll
        'Color.FromArgb(Red 0 to 255, Green 0 to 255,  Blue 0 to 255)
        LblColor.BackColor = Color.FromArgb(HSRed.Value, HSGreen.Value, HSBlue.Value)
        LblRed.Text = HSRed.Value ' Red Scroll Value
    End Sub

    Private Sub HSGreen_Scroll(sender As Object, e As ScrollEventArgs) Handles HSGreen.Scroll
        LblColor.BackColor = Color.FromArgb(HSRed.Value, HSGreen.Value, HSBlue.Value)
        LblGreen.Text = HSGreen.Value ' Green Scroll Value
    End Sub

    Private Sub HSBlue_Scroll(sender As Object, e As ScrollEventArgs) Handles HSBlue.Scroll
        LblColor.BackColor = Color.FromArgb(HSRed.Value, HSGreen.Value, HSBlue.Value)
        LblBlue.Text = HSBlue.Value ' Blue Scroll Value
    End Sub

    Private Sub BtnSignR_Click(sender As Object, e As EventArgs) Handles BtnSignR.Click
        ' Move Text Right = Last & All but Last
        LblMarquee.Text = Mid(LblMarquee.Text, Len(LblMarquee.Text), 1) _
    & Mid(LblMarquee.Text, 1, Len(LblMarquee.Text) - 1)
    End Sub

    Private Sub BtnSignL_Click(sender As Object, e As EventArgs) Handles BtnSignL.Click
        iCount = 0  ' Set counter to Zero
        TimSign.Start() ' Start timer
    End Sub

    Private Sub TimSign_Tick(sender As Object, e As EventArgs) Handles TimSign.Tick
        ' Move Text Left = All but first & First
        LblMarquee.Text = Mid(LblMarquee.Text, 2, Len(LblMarquee.Text) - 1) _
        & Mid(LblMarquee.Text, 1, 1)
        iCount += 1   ' Add one to counter
        ' Check counter to change Marquee color
        If iCount = 1 Then LblMarquee.BackColor = Color.HotPink
        If iCount = 20 Then LblMarquee.BackColor = Color.LawnGreen
        If iCount = 40 Then LblMarquee.BackColor = Color.LightBlue
        ' Reset counter when it reaches 60
        If iCount = 60 Then iCount = 0
    End Sub
End Class