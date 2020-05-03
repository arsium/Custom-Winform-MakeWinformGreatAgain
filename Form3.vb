Public Class Form3

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)



        '  ControlPaint.DrawBorder(e.Graphics, Me.ClientRectangle, Color.DeepSkyBlue, ButtonBorderStyle.Solid)



        MyBase.OnPaint(e)
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

    End Sub



    Private Sub Custom_Button1_Click(sender As Object, e As EventArgs) Handles Custom_Button1.Click
        Form4.Show()
    End Sub
End Class