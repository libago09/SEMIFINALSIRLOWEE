Public Class Form1

    Dim snake(1000) As PictureBox
    Dim ctrArray As Integer = -1
    Dim lastKeyPressed As String = ""
    Dim imageLoc1 As String = "C:\Users\Ryzen 5\Desktop\circle-png-15279.png"
    Dim imageLoc2 As String = "C:\Users\Ryzen 5\Desktop\circle-png-15287.png"
    Dim imageLoc3 As String = "C:\Users\Ryzen 5\Desktop\60-606864_apple-png.png"
    Dim food As New PictureBox

    Private Sub snakeHead()
        ctrArray += 1

        snake(ctrArray) = New PictureBox
        With snake(ctrArray)
            .Height = 20
            .Width = 20
            .BackColor = PictureBox1.BackColor
            .Image = Image.FromFile(imageLoc1)
            .SizeMode = PictureBoxSizeMode.StretchImage
            .Top = (PictureBox1.Bottom + PictureBox1.Top) / 2
            .Left = (PictureBox1.Left + PictureBox1.Right) / 2
        End With
        Me.Controls.Add(snake(ctrArray))
        snake(ctrArray).BringToFront()
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        snakeHead()
        createFood()
        Timer1.Start()

    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown

        If ctrArray = 0 Then

            If e.KeyCode = Keys.W Then     'can go a to d or s to w vice versa in ( without tail )
                lastKeyPressed = "W"
            End If
            If e.KeyCode = Keys.A Then
                lastKeyPressed = "A"
            End If
            If e.KeyCode = Keys.S Then
                lastKeyPressed = "S"
            End If
            If e.KeyCode = Keys.D Then
                lastKeyPressed = "D"
            End If
        Else
            If e.KeyCode = Keys.W And String.Equals(lastKeyPressed, "S") = False Then
                lastKeyPressed = "W"
            End If
            If e.KeyCode = Keys.A And String.Equals(lastKeyPressed, "D") = False Then
                lastKeyPressed = "A"
            End If
            If e.KeyCode = Keys.S And String.Equals(lastKeyPressed, "W") = False Then
                lastKeyPressed = "S"
            End If
            If e.KeyCode = Keys.D And String.Equals(lastKeyPressed, "A") = False Then
                lastKeyPressed = "D"
            End If

        End If



    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        checkWalls()
        snakeEatsFood()
        moveTail()
        Select Case lastKeyPressed
            Case "W"
                snake(0).Top -= 20
            Case "A"
                snake(0).Left -= 20
            Case "S"
                snake(0).Top += 20
            Case "D"
                snake(0).Left += 20
        End Select

        checkIfBitesItself()
        If ctrArray = 5 Then
            Storm1.Visible = True
            Storm2.Visible = True
            Storm3.Visible = True
            Timer2.Start()

        End If
    End Sub

    Private Sub addTail()
        ctrArray = ctrArray + 1
        snake(ctrArray) = New PictureBox
        With snake(ctrArray)
            .Height = 20
            .Width = 20
            .BackColor = Color.White
            '   .Image = Image.FromFile(imageLoc2)
            .SizeMode = PictureBoxSizeMode.StretchImage
        End With
        Me.Controls.Add(snake(ctrArray))
        snake(ctrArray).BringToFront()
    End Sub

    Private Sub moveTail()
        Dim i As Integer

        For i = ctrArray To 1 Step -1
            snake(i).Top = snake(i - 1).Top
            snake(i).Left = snake(i - 1).Left
        Next
    End Sub

    Private Sub checkWalls()
        If snake(0).Left < PictureBox1.Left Then
            Timer1.Stop()
        End If
        If snake(0).Right > PictureBox1.Right Then
            Timer1.Stop()
        End If
        If snake(0).Top < PictureBox1.Top Then
            Timer1.Stop()
        End If
        If snake(0).Bottom > PictureBox1.Bottom Then
            Timer1.Stop()
        End If

    End Sub

    Private Sub createFood()

        Dim rdn As New Random
        With food
            .Width = 30
            .Height = 30
            .Top = rdn.Next(40, PictureBox1.Bottom)
            .Left = rdn.Next(40, PictureBox1.Right)
            .BackColor = Color.Green
            .Image = Image.FromFile(imageLoc3)
            .SizeMode = PictureBoxSizeMode.StretchImage
        End With

        Me.Controls.Add(food)
        food.BringToFront()
    End Sub

    Private Sub snakeEatsFood()
        Dim rdn As New Random
        If snake(0).Bounds.IntersectsWith(food.Bounds) Then
            food.Top = rdn.Next(60, PictureBox1.Bottom - 60)
            food.Left = rdn.Next(60, PictureBox1.Right - 60)
            addTail()
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick


        Storm1.Top -= 10
            Storm2.Left -= 10
        Storm3.Left -= (snake(0).Left - 10)
        Storm3.Top -= (snake(0).Top - 10)
    End Sub

    Private Sub checkIfBitesItself()
        Dim x As Integer
        For x = 1 To ctrArray
            If snake(0).Bounds.IntersectsWith(snake(x).Bounds) Then
                Timer1.Stop()
                Timer2.Stop()
                MsgBox("You bit your own tail! GGWP!!")
            End If
        Next
    End Sub
End Class
