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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        ProgressBar1 = New ProgressBar()
        Timer1 = New Timer(components)
        Label1 = New Label()
        Label2 = New Label()
        Button1 = New Button()
        Timer2 = New Timer(components)
        disableMMchk = New CheckBox()
        TextBox1 = New TextBox()
        Label3 = New Label()
        startBtn = New Button()
        TextBox2 = New TextBox()
        Label4 = New Label()
        SuspendLayout()
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.Enabled = False
        ProgressBar1.Location = New Point(8, 43)
        ProgressBar1.Margin = New Padding(2)
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(543, 20)
        ProgressBar1.Style = ProgressBarStyle.Marquee
        ProgressBar1.TabIndex = 0
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 1000
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(8, 5)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(480, 32)
        Label1.TabIndex = 1
        Label1.Text = "Azure Account Checks for Storage Accounts"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(8, 58)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(116, 32)
        Label2.TabIndex = 2
        Label2.Text = "Progress: "
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(473, 151)
        Button1.Margin = New Padding(2)
        Button1.Name = "Button1"
        Button1.Size = New Size(78, 26)
        Button1.TabIndex = 3
        Button1.Text = "Quit"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Timer2
        ' 
        Timer2.Interval = 1000
        ' 
        ' disableMMchk
        ' 
        disableMMchk.AutoSize = True
        disableMMchk.Location = New Point(14, 160)
        disableMMchk.Margin = New Padding(2)
        disableMMchk.Name = "disableMMchk"
        disableMMchk.Size = New Size(145, 19)
        disableMMchk.TabIndex = 4
        disableMMchk.Text = "Disable MMDB Checks"
        disableMMchk.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(99, 134)
        TextBox1.Margin = New Padding(2)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(56, 23)
        TextBox1.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(8, 136)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(77, 15)
        Label3.TabIndex = 6
        Label3.Text = "Amount in #:"
        ' 
        ' startBtn
        ' 
        startBtn.Location = New Point(247, 151)
        startBtn.Margin = New Padding(2)
        startBtn.Name = "startBtn"
        startBtn.Size = New Size(78, 26)
        startBtn.TabIndex = 7
        startBtn.Text = "Start"
        startBtn.UseVisualStyleBackColor = True
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox2.Location = New Point(99, 111)
        TextBox2.Margin = New Padding(2)
        TextBox2.Name = "TextBox2"
        TextBox2.PasswordChar = "*"c
        TextBox2.Size = New Size(115, 22)
        TextBox2.TabIndex = 8
        TextBox2.Text = "28bduhauh2eugwkgdhu"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(8, 113)
        Label4.Margin = New Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(88, 15)
        Label4.TabIndex = 9
        Label4.Text = "Azure Account:"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(560, 185)
        Controls.Add(ProgressBar1)
        Controls.Add(TextBox2)
        Controls.Add(Label4)
        Controls.Add(startBtn)
        Controls.Add(Label3)
        Controls.Add(TextBox1)
        Controls.Add(disableMMchk)
        Controls.Add(Button1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(2)
        Name = "Form1"
        Text = "DB Compile and Move Tool"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Timer2 As Timer
    Friend WithEvents disableMMchk As CheckBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents startBtn As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label4 As Label

End Class
