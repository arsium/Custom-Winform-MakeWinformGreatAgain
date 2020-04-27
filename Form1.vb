Imports System.Security.AccessControl

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Fade_In(Me)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        '  Custom_Form.Shake_Anime(Me)
        '   Custom_Form.Slide_Anim_Ver(240, Panel1)
        'Custom_Form.Slide_Anim_Hori(610, Panel1)
        '  Custom_Form.Fade_Out(Me)
        Fade_In(Form3)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Fade_Out(Form3)
    End Sub
End Class