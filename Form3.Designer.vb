<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Custom_Button1 = New TestAnim.Custom_Button()
        Me.Custom_Panel1 = New TestAnim.Custom_Panel()
        Me.CustomTabControl1 = New TestAnim.CustomTabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.CustomTabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'Custom_Button1
        '
        Me.Custom_Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Custom_Button1.ColorBottom = System.Drawing.Color.Empty
        Me.Custom_Button1.ColorLeft = System.Drawing.Color.Empty
        Me.Custom_Button1.ColorRight = System.Drawing.Color.Empty
        Me.Custom_Button1.ColorTop = System.Drawing.Color.Empty
        Me.Custom_Button1.Location = New System.Drawing.Point(462, 344)
        Me.Custom_Button1.MouseLeaveCL = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Custom_Button1.MouseOver = System.Drawing.Color.BlueViolet
        Me.Custom_Button1.Name = "Custom_Button1"
        Me.Custom_Button1.Padding = New System.Windows.Forms.Padding(0, 29, 0, 0)
        Me.Custom_Button1.RadiusRoundedBorder = 50
        Me.Custom_Button1.RoundedBorder = True
        Me.Custom_Button1.Size = New System.Drawing.Size(207, 94)
        Me.Custom_Button1.TabIndex = 4
        Me.Custom_Button1.TextBtn = "This is Custom Buttn Sir"
        '
        'Custom_Panel1
        '
        Me.Custom_Panel1.BackColor = System.Drawing.Color.Red
        Me.Custom_Panel1.ColorBorders = System.Drawing.Color.Empty
        Me.Custom_Panel1.ColorBottom = System.Drawing.Color.Empty
        Me.Custom_Panel1.ColorLeft = System.Drawing.Color.Empty
        Me.Custom_Panel1.ColorRight = System.Drawing.Color.Empty
        Me.Custom_Panel1.ColorTop = System.Drawing.Color.Empty
        Me.Custom_Panel1.Draggable = True
        Me.Custom_Panel1.Location = New System.Drawing.Point(427, 101)
        Me.Custom_Panel1.Name = "Custom_Panel1"
        Me.Custom_Panel1.Padding = New System.Windows.Forms.Padding(0, 29, 0, 0)
        Me.Custom_Panel1.RadiusRoundedBorder = 50
        Me.Custom_Panel1.RoundedBorder = True
        Me.Custom_Panel1.Size = New System.Drawing.Size(340, 178)
        Me.Custom_Panel1.TabIndex = 3
        '
        'CustomTabControl1
        '
        Me.CustomTabControl1.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.CustomTabControl1.Controls.Add(Me.TabPage1)
        Me.CustomTabControl1.Controls.Add(Me.TabPage2)
        Me.CustomTabControl1.ItemSize = New System.Drawing.Size(30, 120)
        Me.CustomTabControl1.Location = New System.Drawing.Point(12, 118)
        Me.CustomTabControl1.MouseOver = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CustomTabControl1.MouseOverSleep = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.CustomTabControl1.Multiline = True
        Me.CustomTabControl1.Name = "CustomTabControl1"
        Me.CustomTabControl1.SelectedIndex = 0
        Me.CustomTabControl1.Size = New System.Drawing.Size(200, 264)
        Me.CustomTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.CustomTabControl1.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.Location = New System.Drawing.Point(124, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(72, 256)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(124, 4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(72, 256)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1183, 573)
        Me.Controls.Add(Me.Custom_Button1)
        Me.Controls.Add(Me.Custom_Panel1)
        Me.Controls.Add(Me.CustomTabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.CustomTabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents CustomTabControl1 As CustomTabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Custom_Panel1 As Custom_Panel
    Friend WithEvents Custom_Button1 As Custom_Button
End Class
