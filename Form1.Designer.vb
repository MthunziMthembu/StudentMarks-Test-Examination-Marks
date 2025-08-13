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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        txtName = New TextBox()
        txtTest = New TextBox()
        txtAssignment = New TextBox()
        btnClick = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 20F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(108, 96)
        Label1.Name = "Label1"
        Label1.Size = New Size(419, 45)
        Label1.TabIndex = 0
        Label1.Text = "ENTER YOUR NAME"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Times New Roman", 20F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(108, 171)
        Label2.Name = "Label2"
        Label2.Size = New Size(407, 45)
        Label2.TabIndex = 1
        Label2.Text = "ENTER TEST MARK"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Times New Roman", 20F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(108, 230)
        Label3.Name = "Label3"
        Label3.Size = New Size(573, 45)
        Label3.TabIndex = 2
        Label3.Text = "ENTER ASSIGNMENT MARK"
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(699, 106)
        txtName.Name = "txtName"
        txtName.Size = New Size(214, 31)
        txtName.TabIndex = 3
        ' 
        ' txtTest
        ' 
        txtTest.Location = New Point(705, 167)
        txtTest.Name = "txtTest"
        txtTest.Size = New Size(208, 31)
        txtTest.TabIndex = 4
        ' 
        ' txtAssignment
        ' 
        txtAssignment.Location = New Point(705, 230)
        txtAssignment.Name = "txtAssignment"
        txtAssignment.Size = New Size(208, 31)
        txtAssignment.TabIndex = 5
        ' 
        ' btnClick
        ' 
        btnClick.Font = New Font("Times New Roman", 20F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClick.Location = New Point(108, 385)
        btnClick.Name = "btnClick"
        btnClick.Size = New Size(766, 135)
        btnClick.TabIndex = 6
        btnClick.Text = "DO YOU QUALIFY FOR AN EXCURSION?"
        btnClick.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(944, 581)
        Controls.Add(btnClick)
        Controls.Add(txtAssignment)
        Controls.Add(txtTest)
        Controls.Add(txtName)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtTest As TextBox
    Friend WithEvents txtAssignment As TextBox
    Friend WithEvents btnClick As Button

End Class
