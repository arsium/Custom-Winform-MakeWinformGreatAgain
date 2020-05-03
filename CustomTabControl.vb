''https://www.youtube.com/watch?v=0jQFVIhVQtc Adapted By Arsium
Public Class CustomTabControl
    Inherits TabControl
    Sub New()
        SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.OptimizedDoubleBuffer Or ControlStyles.ResizeRedraw Or ControlStyles.UserPaint, True)
        DoubleBuffered = True
        SizeMode = TabSizeMode.Fixed
        ItemSize = New Size(30, 120)
    End Sub
    Protected Overrides Sub CreateHandle()
        MyBase.CreateHandle()
        Alignment = TabAlignment.Left
    End Sub

    Private MouseOVC As Color = Color.FromArgb(100, 88, 255)
    Private MouseOVC2 As Color = Color.FromArgb(37, 37, 37)
    Property MouseOver As Color
        Get
            Return MouseOVC
        End Get
        Set(value As Color)
            MouseOVC = value
        End Set
    End Property
    Property MouseOverSleep As Color
        Get
            Return MouseOVC2
        End Get
        Set(value As Color)
            MouseOVC2 = value
        End Set
    End Property

    Private Sub MOUSEOHVHANDLER(ByVal sender As Object, e As EventArgs) Handles Me.MouseHover
        Me.ssl = New SolidBrush(MouseOVC)
        Me.ssl2 = New SolidBrush(MouseOVC2)
    End Sub


    Public ssl2 As SolidBrush = New SolidBrush(MouseOVC2)

    Public ssl As SolidBrush = New SolidBrush(MouseOVC)

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        Dim B As New Bitmap(Width, Height)
        Dim g As Graphics = Graphics.FromImage(B)
        g.Clear(Color.FromArgb(37, 37, 37))

        '' Dim ssl = New SolidBrush(Color.FromArgb(37, 37, 37))

        '    ssl = New SolidBrush(Color.FromArgb(37, 37, 37))

        Dim k As New SolidBrush(Color.FromArgb(0, 188, 50))

        For i = 0 To TabCount - 1
            Dim TabRectrangle As Rectangle = GetTabRect(i)

            If i = SelectedIndex Then
                g.FillRectangle(ssl, TabRectrangle)

            Else
                g.FillRectangle(ssl2, TabRectrangle)

            End If

            g.DrawString(TabPages(i).Text, Font, Brushes.White, TabRectrangle, New StringFormat With {.Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center})

            If (TabPages(i).ImageIndex >= 0) AndAlso (ImageList IsNot Nothing) AndAlso (ImageList.Images(TabPages(i).ImageIndex) IsNot Nothing) Then


                Dim img As Image = ImageList.Images(TabPages(i).ImageIndex)



                Dim rimage As New Rectangle(TabRectrangle.X + 4, TabRectrangle.Y + 4, img.Width - 6, img.Height - 6)

                ' adjust rectangles


                rimage.Y += ((TabRectrangle.Height - img.Height) / 2)


                ' draw icon
                g.DrawImage(img, rimage)


            End If

        Next
        e.Graphics.DrawImage(B.Clone, 0, 0)
        e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.HighQuality


        g.Dispose() : B.Dispose()







        MyBase.OnPaint(e)
    End Sub
End Class
