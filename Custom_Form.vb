Imports System.Drawing.Drawing2D
Imports System.Drawing.Imaging
Imports System.Runtime.InteropServices


'Author  : https://github.com/arsium
'Make Winform Great Again
Public Class Custom_Form
    Inherits Form

    Sub New()
        SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.OptimizedDoubleBuffer Or ControlStyles.ResizeRedraw Or ControlStyles.UserPaint Or ControlStyles.SupportsTransparentBackColor Or ControlStyles.ContainerControl, True)
        DoubleBuffered = True
        ''
        ''
    End Sub
    Protected Overrides Sub CreateHandle()
        MyBase.CreateHandle()

    End Sub
    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        Dim B As New Bitmap(Width, Height)
        Dim g As Graphics = Graphics.FromImage(B)

        e.Graphics.DrawImage(B.Clone, 0, 0)
        '  e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.HighQuality

        e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
        Dim k As New SolidBrush(Color.FromArgb(250, Color.DeepSkyBlue))





        If ColoredBorders Then

            Dim myPen As Pen
            myPen = New Pen(Drawing.Color.DeepSkyBlue, RadiusC)
            e.Graphics.DrawRectangle(myPen, 1, 1, Me.Width - 3, Me.Height - 3)



            Dim myPean As SolidBrush
            myPean = New SolidBrush(Drawing.Color.DeepSkyBlue)
            e.Graphics.FillRectangle(myPean, 10, 10, Me.Width - 22, 30)


        Else


            Dim myPean As SolidBrush
            myPean = New SolidBrush(Drawing.Color.DeepSkyBlue)
            e.Graphics.FillRectangle(myPean, -1, -1, Me.Width + 2, 30)


        End If
   e.Graphics.DrawString(FormText, New Font(FontFamily.GenericSansSerif, 8, FontStyle.Regular), New SolidBrush(Color.Black), New PointF(10, 7.5))
        Me.Text = FormText

        If RoundedB Then
            'Me.FormBorderStyle = FormBorderStyle.None  | TODO
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, Radius, Radius))
            '   End If

        End If









        g.Dispose() : B.Dispose()

        MyBase.OnPaint(e)
    End Sub



    Private TextF As String = "Custom_Form"
    Property FormText As String
        Get
            Return TextF
        End Get
        Set(value As String)
            TextF = value
        End Set
    End Property

    Private ColoredBorders As Boolean = True
    Property PaintedBorders As Boolean
        Get
            Return ColoredBorders
        End Get
        Set(value As Boolean)
            ColoredBorders = value
        End Set
    End Property








    Private RadiusC As Integer = 3
    Property RadiusColorBorder As Integer
        Get
            Return RadiusC
        End Get
        Set(value As Integer)
            RadiusC = value
        End Set
    End Property


    Private Radius As Integer = 20
    Property RadiusRoundedBorder As Integer
        Get
            Return Radius
        End Get
        Set(value As Integer)
            Radius = value
        End Set
    End Property

    Private RoundedB As Boolean = True
    Property RoundedBorder As Boolean
        Get
            Return RoundedB
        End Get
        Set(value As Boolean)
            RoundedB = value
        End Set
    End Property








    ''From : https://stackoverflow.com/questions/18822067/rounded-corners-in-c-sharp-windows-forms

    <DllImport("Gdi32.dll", EntryPoint:="CreateRoundRectRgn")>
    Private Shared Function CreateRoundRectRgn(ByVal nLeftRect As Integer, ByVal nTopRect As Integer, ByVal nRightRect As Integer, ByVal nBottomRect As Integer, ByVal nWidthEllipse As Integer, ByVal nHeightEllipse As Integer) As IntPtr

    End Function










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
            MyBase.OnMouseDown(e)
        End If
    End Sub


    Private DragB As Boolean = True
    Property Draggable As Boolean
        Get
            Return DragB
        End Get
        Set(value As Boolean)
            DragB = value
        End Set
    End Property

    Private MouseOVC As Color = Color.BlueViolet
    Property MouseOver As Color
        Get
            Return MouseOVC
        End Get
        Set(value As Color)
            MouseOVC = value
        End Set
    End Property
    Private Sub MOUSEOHVHANDLER(ByVal sender As Object, e As EventArgs) Handles Me.MouseHover
        Me.BackColor = MouseOVC
    End Sub



    Private MouseOVCL As Color = Color.White
    Property MouseOut As Color
        Get
            Return MouseOVCL
        End Get
        Set(value As Color)
            MouseOVCL = value
        End Set
    End Property
    Private Sub MOUSEOHVLHANDLER(ByVal sender As Object, e As EventArgs) Handles Me.MouseLeave
        Me.BackColor = Me.MouseOVCL
    End Sub

End Class

