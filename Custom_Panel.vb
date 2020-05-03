Imports System.Drawing.Drawing2D
Imports System.Runtime.InteropServices

Public Class Custom_Panel
    Inherits Panel
    'https://www.youtube.com/watch?v=pYdPs1ZXUPY
    Public Property ColorTop As Color
    Public Property ColorBottom As Color


    Public Property ColorLeft As Color
    Public Property ColorRight As Color



    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        Dim lgb As LinearGradientBrush = New LinearGradientBrush(Me.ClientRectangle, Me.ColorTop, Me.ColorBottom, 90.0F)
        Dim g As Graphics = e.Graphics
        g.FillRectangle(lgb, Me.ClientRectangle)


        Dim lgbs As LinearGradientBrush = New LinearGradientBrush(Me.ClientRectangle, Me.ColorRight, Me.ColorLeft, 180.0F)
        Dim gs As Graphics = e.Graphics
        gs.FillRectangle(lgbs, Me.ClientRectangle)



        If RoundedB Then
            'Me.FormBorderStyle = FormBorderStyle.None
            ' Dim myPen As Pen
            ' myPen = New Pen(ColorB, RadiusC)
            '  e.Graphics.DrawRectangle(myPen, 1, 1, Me.Width - 4, Me.Height - 3)
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, Radius_AZ, Radius_AZ))
            Me.Padding = New Padding(0, 29, 0, 0)

            '   End If
            '   Me.Refresh()
        End If



        ControlPaint.DrawBorder(e.Graphics, Me.ClientRectangle, Color_B, ButtonBorderStyle.Solid)



        MyBase.OnPaint(e)
    End Sub





    Private Radius_AZ As Integer = 20
    Property RadiusRoundedBorder As Integer
        Get
            Return Radius_AZ
            Me.Refresh()
        End Get
        Set(value As Integer)
            Radius_AZ = value
            Me.Refresh()
        End Set
    End Property

    Private RoundedB As Boolean = True
    Property RoundedBorder As Boolean
        Get
            Return RoundedB
            Me.Refresh()
        End Get
        Set(value As Boolean)
            RoundedB = value
            Me.Refresh()
        End Set
    End Property


    <DllImport("Gdi32.dll", EntryPoint:="CreateRoundRectRgn")>
    Private Shared Function CreateRoundRectRgn(ByVal nLeftRect As Integer, ByVal nTopRect As Integer, ByVal nRightRect As Integer, ByVal nBottomRect As Integer, ByVal nWidthEllipse As Integer, ByVal nHeightEllipse As Integer) As IntPtr

    End Function








    Private Color_B As Color = Color.DeepSkyBlue
    Property ColorBorders As Color
        Get
            Return Color_B
            Me.Refresh()
        End Get
        Set(value As Color)
            Color_B = value
            Me.Refresh()
        End Set
    End Property





    ''Native API adpated from  : https://github.com/RiyadPathan/DragControl/blob/master/DragControl.vb
    <DllImport("user32.dll")>
    Public Shared Function SendMessage(ByVal a As IntPtr, ByVal msg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
    End Function
    <DllImport("user32.dll")>
    Public Shared Function ReleaseCapture() As Boolean


    End Function

    Protected Overrides Sub OnMouseDown(e As MouseEventArgs)

        If Draggable = True Then
            Dim flag As Boolean = e.Button = MouseButtons.Left

            If flag Then

                Custom_Form.ReleaseCapture()

                Custom_Form.SendMessage(Me.FindForm().Handle, 161, 2, 0)
            End If

        End If
    End Sub

    Private DragB As Boolean = True
    Property Draggable As Boolean
        Get
            Return DragB
            Me.Refresh()
        End Get
        Set(value As Boolean)
            DragB = value
            Me.Refresh()
        End Set
    End Property
End Class
