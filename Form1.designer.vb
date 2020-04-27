<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits Custom_Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Container_.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Container_
        '
        Me.Container_.BackColor = System.Drawing.Color.White
        Me.Container_.Controls.Add(Me.Panel2)
        Me.Container_.Location = New System.Drawing.Point(7, 29)
        Me.Container_.Size = New System.Drawing.Size(1186, 694)
        Me.Container_.TabIndex = 4500
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(19, 15)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(198, 38)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "FadeIn_Form3"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(255, 15)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(198, 38)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "FadeOut_Form3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkGray
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.Button3)
        Me.Panel2.Location = New System.Drawing.Point(57, 34)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(994, 589)
        Me.Panel2.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1200, 730)
        Me.ColorBorder = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Controls.Add(Me.Container_)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.FormText = "Hello Good Sir"
        Me.MouseOver = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.Name = "Form1"
        Me.Padding = New System.Windows.Forms.Padding(5, 29, 6, 5)
        Me.Text = "Hello Good Sir"
        Me.Container_.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Panel2 As Panel
End Class
