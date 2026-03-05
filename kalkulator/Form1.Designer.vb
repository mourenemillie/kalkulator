<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btn0 = New Button()
        btnKurang = New Button()
        btnClear = New Button()
        btnBagi = New Button()
        btnKali = New Button()
        btnTambah = New Button()
        btnSamaDengan = New Button()
        btn9 = New Button()
        btn8 = New Button()
        btn7 = New Button()
        btn6 = New Button()
        btn5 = New Button()
        btn4 = New Button()
        btn3 = New Button()
        btn2 = New Button()
        btn1 = New Button()
        txtDisplay = New TextBox()
        SuspendLayout()
        ' 
        ' btn0
        ' 
        btn0.Location = New Point(269, 355)
        btn0.Name = "btn0"
        btn0.Size = New Size(133, 68)
        btn0.TabIndex = 0
        btn0.Text = "0"
        btn0.UseVisualStyleBackColor = True
        ' 
        ' btnKurang
        ' 
        btnKurang.Location = New Point(561, 265)
        btnKurang.Name = "btnKurang"
        btnKurang.Size = New Size(133, 68)
        btnKurang.TabIndex = 1
        btnKurang.Text = "-"
        btnKurang.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(125, 355)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(133, 68)
        btnClear.TabIndex = 2
        btnClear.Text = "C"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btnBagi
        ' 
        btnBagi.Location = New Point(561, 86)
        btnBagi.Name = "btnBagi"
        btnBagi.Size = New Size(133, 68)
        btnBagi.TabIndex = 3
        btnBagi.Text = "/"
        btnBagi.UseVisualStyleBackColor = True
        ' 
        ' btnKali
        ' 
        btnKali.Location = New Point(561, 355)
        btnKali.Name = "btnKali"
        btnKali.Size = New Size(133, 68)
        btnKali.TabIndex = 4
        btnKali.Text = "x"
        btnKali.UseVisualStyleBackColor = True
        ' 
        ' btnTambah
        ' 
        btnTambah.Location = New Point(561, 174)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(133, 68)
        btnTambah.TabIndex = 5
        btnTambah.Text = "+"
        btnTambah.UseVisualStyleBackColor = True
        ' 
        ' btnSamaDengan
        ' 
        btnSamaDengan.Location = New Point(412, 355)
        btnSamaDengan.Name = "btnSamaDengan"
        btnSamaDengan.Size = New Size(133, 68)
        btnSamaDengan.TabIndex = 6
        btnSamaDengan.Text = "="
        btnSamaDengan.UseVisualStyleBackColor = True
        ' 
        ' btn9
        ' 
        btn9.Location = New Point(410, 86)
        btn9.Name = "btn9"
        btn9.Size = New Size(133, 68)
        btn9.TabIndex = 7
        btn9.Text = "9"
        btn9.UseVisualStyleBackColor = True
        ' 
        ' btn8
        ' 
        btn8.Location = New Point(269, 86)
        btn8.Name = "btn8"
        btn8.Size = New Size(133, 68)
        btn8.TabIndex = 8
        btn8.Text = "8"
        btn8.UseVisualStyleBackColor = True
        ' 
        ' btn7
        ' 
        btn7.Location = New Point(125, 86)
        btn7.Name = "btn7"
        btn7.Size = New Size(133, 68)
        btn7.TabIndex = 9
        btn7.Text = "7"
        btn7.UseVisualStyleBackColor = True
        ' 
        ' btn6
        ' 
        btn6.Location = New Point(410, 174)
        btn6.Name = "btn6"
        btn6.Size = New Size(133, 68)
        btn6.TabIndex = 10
        btn6.Text = "6"
        btn6.UseVisualStyleBackColor = True
        btn6.UseWaitCursor = True
        ' 
        ' btn5
        ' 
        btn5.Location = New Point(269, 174)
        btn5.Name = "btn5"
        btn5.Size = New Size(133, 68)
        btn5.TabIndex = 11
        btn5.Text = "5"
        btn5.UseVisualStyleBackColor = True
        ' 
        ' btn4
        ' 
        btn4.Location = New Point(125, 174)
        btn4.Name = "btn4"
        btn4.Size = New Size(133, 68)
        btn4.TabIndex = 12
        btn4.Text = "4"
        btn4.UseVisualStyleBackColor = True
        ' 
        ' btn3
        ' 
        btn3.Location = New Point(412, 265)
        btn3.Name = "btn3"
        btn3.Size = New Size(133, 68)
        btn3.TabIndex = 13
        btn3.Text = "3"
        btn3.UseVisualStyleBackColor = True
        ' 
        ' btn2
        ' 
        btn2.Location = New Point(269, 265)
        btn2.Name = "btn2"
        btn2.Size = New Size(133, 68)
        btn2.TabIndex = 14
        btn2.Text = "2"
        btn2.UseVisualStyleBackColor = True
        ' 
        ' btn1
        ' 
        btn1.Location = New Point(125, 265)
        btn1.Name = "btn1"
        btn1.Size = New Size(133, 68)
        btn1.TabIndex = 15
        btn1.Text = "1"
        btn1.UseVisualStyleBackColor = True
        ' 
        ' txtDisplay
        ' 
        txtDisplay.Location = New Point(125, 15)
        txtDisplay.Name = "txtDisplay"
        txtDisplay.Size = New Size(569, 27)
        txtDisplay.TabIndex = 16
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txtDisplay)
        Controls.Add(btn1)
        Controls.Add(btn2)
        Controls.Add(btn3)
        Controls.Add(btn4)
        Controls.Add(btn5)
        Controls.Add(btn6)
        Controls.Add(btn7)
        Controls.Add(btn8)
        Controls.Add(btn9)
        Controls.Add(btnSamaDengan)
        Controls.Add(btnTambah)
        Controls.Add(btnKali)
        Controls.Add(btnBagi)
        Controls.Add(btnClear)
        Controls.Add(btnKurang)
        Controls.Add(btn0)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btn0 As Button
    Friend WithEvents btnKurang As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnBagi As Button
    Friend WithEvents btnKali As Button
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnSamaDengan As Button
    Friend WithEvents btn9 As Button
    Friend WithEvents btn8 As Button
    Friend WithEvents btn7 As Button
    Friend WithEvents btn6 As Button
    Friend WithEvents btn5 As Button
    Friend WithEvents btn4 As Button
    Friend WithEvents btn3 As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents btn1 As Button
    Friend WithEvents txtDisplay As TextBox

End Class
