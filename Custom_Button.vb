Imports System.Drawing.Drawing2D
Imports System.Runtime.InteropServices

Public Class Custom_Button
    Inherits Panel
    Sub New()
        SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.OptimizedDoubleBuffer Or ControlStyles.ResizeRedraw Or ControlStyles.UserPaint, True)
        DoubleBuffered = True
        '   Me.FlatStyle = FlatStyle.Flat
    End Sub
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








        'with the help of microsoft  : https://docs.microsoft.com/en-us/dotnet/framework/winforms/advanced/how-to-align-drawn-text

        Using sf = New StringFormat()
            sf.Alignment = StringAlignment.Center

            Using headerFont = New Font("Microsoft Sans Serif", 9, FontStyle.Bold)

                Dim jk As String = "TestSirSir"


                Dim flags As TextFormatFlags = TextFormatFlags.HorizontalCenter Or
        TextFormatFlags.VerticalCenter Or TextFormatFlags.WordBreak Or TextFormatFlags.GlyphOverhangPadding


                Dim text2 As String = TextBtn

                Dim font2 As New Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point)


                ' e.Graphics.DrawString(jk, headerFont, Brushes.Black, New RectangleF(Me.Width / (jk.Count / 2), Me.Height / 2, 30, headerFont.Height), sf)
                TextRenderer.DrawText(e.Graphics, text2, font2, ClientRectangle, Color.Black, flags)
            End Using
        End Using



        '  ControlPaint.DrawBorder(e.Graphics, Me.ClientRectangle, Color_B, ButtonBorderStyle.Solid)



        MyBase.OnPaint(e)
    End Sub


    <DllImport("Gdi32.dll", EntryPoint:="CreateRoundRectRgn")>
    Private Shared Function CreateRoundRectRgn(ByVal nLeftRect As Integer, ByVal nTopRect As Integer, ByVal nRightRect As Integer, ByVal nBottomRect As Integer, ByVal nWidthEllipse As Integer, ByVal nHeightEllipse As Integer) As IntPtr

    End Function





    Private Txt As String = "Custom_Button"
    Property TextBtn As String
        Get
            Return Txt
            Me.Refresh()
        End Get
        Set(value As String)
            Txt = value
            Me.Refresh()
        End Set
    End Property



    Private Radius_AZ As Integer = 50
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

    '  Private Color_B As Color = Color.DeepSkyBlue
    '   Property ColorBorders As Color
    ' Get
    ' Return Color_B
    ' Me.Refresh()
    '     End Get
    ' Set(value As Color)
    '        Color_B = value
    'Me.Refresh()
    'End Set
    ' End Property



    Private MouseOVC As Color = Color.BlueViolet
    Property MouseOver As Color
        Get
            Return MouseOVC
        End Get
        Set(value As Color)
            MouseOVC = value
        End Set
    End Property


    Private MouseOVCL As Color = Color.White
    Property MouseLeaveCL As Color
        Get
            Return MouseOVCL
        End Get
        Set(value As Color)
            MouseOVCL = value
        End Set
    End Property
    Private Sub MOUSEOHVHANDLER(ByVal sender As Object, e As EventArgs) Handles Me.MouseHover
        Me.BackColor = MouseOVC
    End Sub


    Private Sub MOUSEOHVLHANDLER(ByVal sender As Object, e As EventArgs) Handles Me.MouseLeave
        Me.BackColor = Me.MouseOVCL
    End Sub

End Class
