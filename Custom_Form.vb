Imports System.Drawing.Drawing2D
Imports System.Drawing.Imaging
Imports System.Runtime.InteropServices
Imports System.Threading

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


    Private Sub Me_Pressed(ByVal sender As Object, e As MouseEventArgs) Handles Me.MouseDown

    End Sub
    Private Sub Me_Up(ByVal sender As Object, e As EventArgs) Handles Me.MouseUp
        '   Me.BackColor = Color_A
    End Sub



    Private ColorB As Color = Color.DeepSkyBlue
    Property ColorBorder As Color
        Get
            Return ColorB
            Me.Refresh()
        End Get
        Set(value As Color)
            ColorB = value
            Me.Refresh()
        End Set
    End Property

    Private FontC As Color = Color.White
    Property FontColor As Color
        Get
            Return FontC
            Me.Refresh()
        End Get
        Set(value As Color)
            FontC = value
            Me.Refresh()
        End Set
    End Property



    ' Private Sub Custom_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    ' If ShakeP = True Then
    '        Shaking_Effect()
    ' End If


    Public WithEvents Container_ As New Panel
    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        Dim B As New Bitmap(Width, Height)
        Dim g As Graphics = Graphics.FromImage(B)

        e.Graphics.DrawImage(B.Clone, 0, 0)
        '  e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.HighQuality

        e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
        Dim k As New SolidBrush(Color.FromArgb(250, Color.DeepSkyBlue))

        '  t = New Panel


        Container_.Name = "ContainerSir"

        Container_.TabIndex = 4500

        Container_.Size = New Size(Me.Width - 14, Me.Height - 36)
        Container_.Location = (New Point(7, 29))

        'Container_.Size = New Size(500, 500)
        'Container_.BackColor = Color.Black
        ' t.Dock = DockStyle.Fill
        't.Height = 100
        't.Width = 100








        'Radius color border  :5
        '  Me.Padding = New Padding(0, 29, 0, 0)
        If ColoredBorders = true Then





            Dim myPean As SolidBrush
            myPean = New SolidBrush(ColorB)
            ' e.Graphics.FillRectangle(myPean, 10, 10, Me.Width - 22, 30)  | OLD
            e.Graphics.FillRectangle(myPean, -1, -1, Me.Width + 2, 30)

            e.Graphics.DrawString(FormText, New Font(FontFamily.GenericSansSerif, 8, FontStyle.Regular), New SolidBrush(FontC), New PointF(10, 7.5)) '' New PointF(10, 15)   |   OLD
            ' Me.Padding = New Padding(RadiusC - 1, 29, RadiusC - 1, RadiusC - 1)

            If RoundedB Then

                Dim myPen As Pen
                myPen = New Pen(ColorB, RadiusC)
                e.Graphics.DrawRectangle(myPen, 3, -2, Me.Width - 8, Me.Height - 2)
                ' e.Graphics.DrawRectangle(myPen, 3, -2, Me.Width - 7, Me.Height - 2)

                ''TO CORRECT

                '  Container_.Size = New Size(Me.Width - 11, Me.Height - 34)


                Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, Radius_AZ, Radius_AZ))
                '   Me.Padding = New Padding(5, 29, 6, 6)
                Me.Padding = New Padding(5, 29, 6, 5)

            Else

                Dim myPen As Pen
                myPen = New Pen(ColorB, RadiusC)
                e.Graphics.DrawRectangle(myPen, 3, -2, Me.Width - 7, Me.Height - 2)
                '    Me.Padding = New Padding(5, 29, 6, 5)



            End If

        Else


            '   Me.Padding = New Padding(0, 29, 0, 0)


            Dim myPean As SolidBrush
            myPean = New SolidBrush(ColorB)
            e.Graphics.FillRectangle(myPean, -1, -1, Me.Width + 2, 30)
            e.Graphics.DrawString(FormText, New Font(FontFamily.GenericSansSerif, 8, FontStyle.Regular), New SolidBrush(FontC), New PointF(10, 7.5))

            Container_.Location = (New Point(0, 29))
            Container_.Size = New Size(Me.Width, Me.Height - 30)

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


        End If

        ' Dim ag As Graphics = Me.CreateGraphics()

        'ag.DrawString(FormText, New Font(FontFamily.GenericSansSerif, 8, FontStyle.Regular), New SolidBrush(Color.Black), New PointF(10, 7.5))
        '  e.Graphics.DrawString(FormText, New Font(FontFamily.GenericSansSerif, 8, FontStyle.Regular), New SolidBrush(Color.Black), New PointF(10, 7.5))
        Me.Text = FormText


        '  ControlPaint.DrawBorder(e.Graphics, Me.ClientRectangle, Color.DeepSkyBlue, ButtonBorderStyle.Solid, )
        ' e.Graphics.FillRectangle(k, mp)
        '  If RoundedB Then

        If RoundedB Then



            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, Radius_AZ, Radius_AZ))



        End If

        If PolyB Then

            'Mesures from : https://stackoverflow.com/questions/40570607/drawing-hexagon-in-vb-net
            Dim p(5) As Point

            Dim v As Integer = CInt(Me.Height / 2 * Math.Sin(30 * Math.PI / 180))
            p(0) = New Point(0, Me.Height \ 2)

            p(1) = New Point(v, Me.Height)
            p(2) = New Point(Me.Width - v, Me.Height)
            p(3) = New Point(Me.Width, Me.Height \ 2)
            p(4) = New Point(Me.Width - v, 0)
            p(5) = New Point(v, 0)


            Region = System.Drawing.Region.FromHrgn(CreatePolygonRgn(p, 6, 2))




            '   Dim ndj As Region = System.Drawing.Region.FromHrgn(CreatePolygonRgn(p, 6, 2))

            e.Graphics.DrawPolygon(New Pen(New SolidBrush(Color.DeepSkyBlue), 10), p)

            RoundedB = False

        End If




        Me.Controls.Add(Container_)



        g.Dispose() : B.Dispose()

        MyBase.OnPaint(e)
    End Sub




#Region "Animations Zone"


    '''From https://www.youtube.com/watch?v=i_ypbKLU4zY
    Private Shake As Integer = 0
    Sub Shake_Anime(ByVal Shake_C As Control)
        If Shake >= 150 Then
            Shake = 0
        End If
        Do Until Shake = 150
            Shake_C.Left -= 4
            Shake_C.Left += 4
            Shake += 1
        Loop
    End Sub


    Shared Sub Slide_Anim_Ver(ByVal heightToGo As Integer, ByVal Slide_C As Control)
        Dim k As New Thread(Sub() SL_ANim(heightToGo, Slide_C))
        k.Start()

    End Sub


    '''From  : https://www.youtube.com/watch?v=MYss77nWr5A
    Private Shared Sub SL_ANim(ByVal heightToGo As Integer, ByVal Slide_C As Control)
        Do Until Slide_C.Height = heightToGo
            Slide_C.Height += 1
            Thread.Sleep(20)
        Loop
    End Sub


    Shared Sub Slide_Anim_Hori(ByVal WidthToGo As Integer, ByVal Slide_C As Control)
        Dim k As New Thread(Sub() SL_ANim_Hori(WidthToGo, Slide_C))
        k.Start()

    End Sub

    Private Shared Sub SL_ANim_Hori(ByVal WidthToGo As Integer, ByVal Slide_C As Control)
        Do Until Slide_C.Width = WidthToGo
            Slide_C.Width += 1
            Thread.Sleep(20)
        Loop
    End Sub



    '''Adapted from https://www.youtube.com/watch?v=yAbQBURIv9E&vl=en-US
    Shared Sub Fade_In(ByVal Fade_I_Control As Form, Optional time As Integer = 15)
        Dim k As New Thread(Sub() Fade_In_S(Fade_I_Control, time))
        Fade_I_Control.Opacity = 0
        Fade_I_Control.Show()
        k.Start()
    End Sub
    Private Shared Sub Fade_In_S(ByVal Fade_I_Control As Form, Optional time As Integer = 15)

        Dim a As Integer
        For a = 10 To 100 Step +1
            Fade_I_Control.Opacity = a / 100
            Fade_I_Control.Refresh()
            Threading.Thread.Sleep(time)
        Next
        Fade_I_Control.Opacity = 100
    End Sub

    Shared Sub Fade_Out(ByVal Fade_O_Control As Form, Optional time As Integer = 15)
        Dim k As New Thread(Sub() Fade_Out_S(Fade_O_Control, time))
        k.Start()
    End Sub
    Private Shared Sub Fade_Out_S(ByVal Fade_O_Control As Form, Optional time As Integer = 15)
        Dim a As Integer
        For a = 100 To 10 Step -1
            Fade_O_Control.Opacity = a / 100
            Fade_O_Control.Refresh()
            Threading.Thread.Sleep(time)
        Next
        Fade_O_Control.Close()
    End Sub

#End Region




    Private PolyB As Boolean = False


    Property HexagonForm As Boolean
        Get
            Return PolyB
            Me.Refresh()
        End Get
        Set(value As Boolean)
            PolyB = value
            Me.Refresh()
        End Set
    End Property

    Private TextF As String = "Custom_Form"
    Property FormText As String
        Get
            Return TextF
            Me.Refresh()
        End Get
        Set(value As String)
            TextF = value
            Me.Refresh()
        End Set
    End Property

    Private ColoredBorders As Boolean = True
    Property PaintedBorders As Boolean
        Get
            Return ColoredBorders
            Me.Refresh()
        End Get
        Set(value As Boolean)
            ColoredBorders = value
            Me.Refresh()
        End Set
    End Property








    Private RadiusC As Integer = 8
    '  Property RadiusColorBorder As Integer
    '  Get
    '  Return RadiusC
    ' Me.Refresh()
    ' End Get
    ' Set(value As Integer)
    '        RadiusC = value
    'Me.Refresh()
    'End Set
    '  End Property


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


#Region "NativeAPI"

    <DllImport("gdi32.dll")>
    Private Shared Function CreatePolygonRgn(ByVal lppt As Point(), ByVal cPoints As Integer, ByVal fnPolyFillMode As Integer) As IntPtr

    End Function

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

        End If
    End Sub


    Private Sub Container_MouseDown(sender As Object, e As MouseEventArgs) Handles Container_.MouseDown

        If Draggable = True Then
            Dim flag As Boolean = e.Button = MouseButtons.Left

            If flag Then

                Custom_Form.ReleaseCapture()

                Custom_Form.SendMessage(Me.FindForm().Handle, 161, 2, 0)
            End If

        End If
    End Sub


#End Region

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

    Private MouseOVC As Color = Color.BlueViolet
    Property MouseOver As Color
        Get
            Return MouseOVC
            Me.Refresh()
        End Get
        Set(value As Color)
            MouseOVC = value
            Me.Refresh()
        End Set
    End Property
    Private Sub MOUSEOHVHANDLER(ByVal sender As Object, e As EventArgs) Handles Me.MouseHover
        Me.BackColor = MouseOVC
    End Sub
    Private MouseOVCL As Color = Color.White
    Property MouseOut As Color
        Get
            Return MouseOVCL
            Me.Refresh()
        End Get
        Set(value As Color)
            MouseOVCL = value
            Me.Refresh()
        End Set
    End Property
    Private Sub MOUSEOHVLHANDLER(ByVal sender As Object, e As EventArgs) Handles Me.MouseLeave
        Me.BackColor = Me.MouseOVCL

    End Sub



    Private Sub MOUSEOHVHANDLERContainer_(ByVal sender As Object, e As EventArgs) Handles Container_.MouseHover
        Container_.BackColor = MouseOVC
    End Sub



    Private Sub MOUSEOHVLHANDLERContainer_(ByVal sender As Object, e As EventArgs) Handles Container_.MouseLeave
        Container_.BackColor = Me.MouseOVCL

    End Sub

End Class

