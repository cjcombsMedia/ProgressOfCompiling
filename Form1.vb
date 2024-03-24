Imports System.Runtime.InteropServices

Public Class Form1


    ' Import the SetCursorPos function from user32.dll
    <DllImport("user32.dll", SetLastError:=True)>
    Private Shared Function SetCursorPos(ByVal X As Integer, ByVal Y As Integer) As Boolean
    End Function

    <DllImport("user32.dll", SetLastError:=True)>
    Private Shared Sub mouse_event(dwFlags As Integer, dx As Integer, dy As Integer, dwData As Integer, dwExtraInfo As Integer)
    End Sub

    Private Const MOUSEEVENTF_LEFTDOWN As Integer = &H2
    Private Const MOUSEEVENTF_LEFTUP As Integer = &H4

    Private random As New Random()

    Private Sub MoveMouseTo(ByVal x As Integer, ByVal y As Integer)
        ' Set the cursor position to the specified coordinates
        SetCursorPos(x, y)
    End Sub
    Private Sub MoveMouseRandomly()
        ' Generate random X and Y coordinates within the screen bounds
        Dim screenWidth As Integer = Screen.PrimaryScreen.Bounds.Width
        Dim screenHeight As Integer = Screen.PrimaryScreen.Bounds.Height
        Dim randomX As Integer = random.Next(screenWidth)
        Dim randomY As Integer = random.Next(screenHeight)

        ' Move the mouse to the random coordinates
        MoveMouseTo(randomX, randomY)
    End Sub

    Private Sub SimulateMouseClick()
        ' Simulate a left mouse button down event
        mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0)
        ' Simulate a left mouse button up event
        mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0)
    End Sub

    Private Const TotalMinutes As Integer = 95 ' Total duration in minutes
    Private progressIncrement As Double = 100 / (TotalMinutes * 60) ' Increment per second to complete 100% in TotalMinutes minutes
    Private progressValue As Double = 0 ' Initial progress value
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' Update the progress value
        progressValue += progressIncrement

        ' Update the progress bar
        If progressValue <= 100 Then
            ProgressBar1.Value = CInt(Math.Round(progressValue)) ' Round the progress value to an integer
            Label2.Text = $"Progress: {ProgressBar1.Value}%"
        Else
            Timer1.Stop() ' Stop the timer when progress reaches 100%
            Timer2.Stop()
            ' Hide or disable the progress bar
            ProgressBar1.Style = ProgressBarStyle.Continuous
            ProgressBar1.Value = 100
            'ProgressBar1.Visible = False ' Or ProgressBar1.Enabled = False
            ' Optionally, perform any other actions you need
            Label2.Text = "Complile and DB Cleanup completed!"
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProgressBar1.MarqueeAnimationSpeed = 0
        TextBox1.Text = ""
        startBtn.Enabled = False

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Application.Exit()
    End Sub


    Private Sub UpdateProgressBar(progressValue As Integer)
        ' Update the progress bar value
        ProgressBar1.Value = progressValue

        ' Check if progress reached 100%
        If progressValue >= 100 Then
            ' Stop the animation
            Timer1.Enabled = False ' Assuming you are using a Timer to update the progress bar
            ' Hide or disable the progress bar
            ProgressBar1.Visible = False ' Or ProgressBar1.Enabled = False
            ' Optionally, perform any other actions you need
            Label2.Text = "Complile and DB Cleanup completed!"
            ProgressBar1.MarqueeAnimationSpeed = 0
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        ' Trigger mouse movement every 30 seconds
        If disableMMchk.Checked = True Then
            'Do nothing
        Else
            MoveMouseRandomly()
            SimulateMouseClick()
        End If

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        startBtn.Enabled = True
        ' Check if the entered character is a digit or backspace
        If Not Char.IsDigit(e.KeyChar) AndAlso Not e.KeyChar = ChrW(Keys.Back) Then
            e.Handled = True ' Ignore the key press
            Return
        End If

        ' Check if the entered number is within the allowed range (1-99)
        Dim newText As String = TextBox1.Text & e.KeyChar
        If Not String.IsNullOrEmpty(newText) Then
            Dim number As Integer
            If Integer.TryParse(newText, number) AndAlso (number < 1 OrElse number > 99) Then
                e.Handled = True ' Ignore the key press
            End If
        End If
    End Sub

    Private Sub startBtn_Click(sender As Object, e As EventArgs) Handles startBtn.Click
        ProgressBar1.MarqueeAnimationSpeed = 30
        Timer1.Start() ' Start the timer when the form loads
        ' Start the timer when the form loads
        Timer2.Interval = 30000 ' 30 seconds
        Timer2.Start()
        startBtn.Enabled = False
    End Sub
End Class
