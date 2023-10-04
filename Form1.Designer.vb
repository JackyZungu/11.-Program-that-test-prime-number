<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btnCheck = New Button()
        txtNumber = New TextBox()
        lbEnterNumber = New Label()
        lbResult = New Label()
        txtResult = New TextBox()
        Label1 = New Label()
        btnCheckP = New Button()
        SuspendLayout()
        ' 
        ' btnCheck
        ' 
        btnCheck.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        btnCheck.Location = New Point(173, 230)
        btnCheck.Name = "btnCheck"
        btnCheck.Size = New Size(164, 49)
        btnCheck.TabIndex = 0
        btnCheck.Text = "Check EvenOrOdd"
        btnCheck.UseVisualStyleBackColor = True
        ' 
        ' txtNumber
        ' 
        txtNumber.Location = New Point(266, 84)
        txtNumber.Name = "txtNumber"
        txtNumber.Size = New Size(58, 27)
        txtNumber.TabIndex = 1
        ' 
        ' lbEnterNumber
        ' 
        lbEnterNumber.AutoSize = True
        lbEnterNumber.Location = New Point(136, 87)
        lbEnterNumber.Name = "lbEnterNumber"
        lbEnterNumber.Size = New Size(113, 20)
        lbEnterNumber.TabIndex = 2
        lbEnterNumber.Text = "Enter a Number"
        ' 
        ' lbResult
        ' 
        lbResult.AutoSize = True
        lbResult.Location = New Point(141, 130)
        lbResult.Name = "lbResult"
        lbResult.Size = New Size(49, 20)
        lbResult.TabIndex = 3
        lbResult.Text = "Result"
        ' 
        ' txtResult
        ' 
        txtResult.Location = New Point(266, 130)
        txtResult.Name = "txtResult"
        txtResult.Size = New Size(262, 27)
        txtResult.TabIndex = 4
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label1.Location = New Point(100, 26)
        Label1.Name = "Label1"
        Label1.Size = New Size(609, 28)
        Label1.TabIndex = 5
        Label1.Text = "THIS PROGRAM IF A NUMBER IS A(N) PRIME, EVEN AND ODD !"
        ' 
        ' btnCheckP
        ' 
        btnCheckP.Font = New Font("Segoe UI", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        btnCheckP.Location = New Point(419, 230)
        btnCheckP.Name = "btnCheckP"
        btnCheckP.Size = New Size(166, 49)
        btnCheckP.TabIndex = 6
        btnCheckP.Text = "Check Prime"
        btnCheckP.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnCheckP)
        Controls.Add(Label1)
        Controls.Add(txtResult)
        Controls.Add(lbResult)
        Controls.Add(lbEnterNumber)
        Controls.Add(txtNumber)
        Controls.Add(btnCheck)
        Name = "Form1"
        Text = "Check Number"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnCheck As Button
    Friend WithEvents txtNumber As TextBox
    Friend WithEvents lbEnterNumber As Label
    Friend WithEvents lbResult As Label
    Friend WithEvents txtResult As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCheckP As Button
End Class
