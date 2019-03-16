Option Strict On
''' <summary>
''' Victoria Valdron 100548556
''' NET DEVELOPMENT LAB 3
''' 2019-01-25
''' In this lab we have to create an application that takes in the input for 7 days, and calculate the average of all 7 inputs.
''' After this has been completed, we have to do this process 2 more times using 2d arrays to get the averages of 2 more employees.
''' The last step will be to calculate the average of all three employee's averages.
''' </summary>


Public Class FrmAverageShipped

    'Variables'
    Dim dayNumber As Integer = 1
    Const TOTAL_DAYS As Integer = 7
    Dim ifInteger As Integer
    Dim totalAvg(2) As Double

    Dim day(2, 6) As Integer '2d array'

    Dim empNum As Integer = 1
    Dim average As Double
    Const MAX_NUM As Integer = 1000
    Const MIN_NUM As Integer = 0
    Const EMPLOYEE As Integer = 3

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        'ends the application'
        Application.Exit()


    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click

        Dim displayName As String = "TxtDisplay"
        Dim outputName As String = "LblOutput"



        TxtInput.Clear()





        For index = 0 To EMPLOYEE - 1

            DirectCast(Controls.Find(displayName, True)(0), TextBox).Clear()
            DirectCast(Controls.Find(outputName, True)(0), Label).Text = ""
            displayName = "TxtDisplay" & (index + 2)
            outputName = "LblOutput" & (index + 2)
        Next

        LblAverage.Text = ""
        dayNumber = 1
        LblDay.Text = "Day" & dayNumber


    End Sub

    Private Sub BtnEnter_Click(sender As Object, e As EventArgs) Handles BtnEnter.Click
        'finds the right textbox/label for the right employee number'
        Dim outputCtr As Label
        Dim displayCtr As TextBox

        If empNum = 1 Then

            displayCtr = TxtDisplay
            outputCtr = LblOutput

        ElseIf (empNum <= EMPLOYEE) Then

            displayCtr = DirectCast(Controls.Find("TxtDisplay" & empNum, True)(0), TextBox)
            outputCtr = DirectCast(Controls.Find("LblOutput" & empNum, True)(0), Label)

        End If
        If Integer.TryParse(TxtInput.Text, ifInteger) Then
            ' Testing to see if the input is an integer '
            If (ifInteger >= MIN_NUM And ifInteger <= MAX_NUM) Then





                'excecute if above condition is true'
                If (dayNumber < TOTAL_DAYS) Then

                    'putting inputs into the array'
                    day(empNum - 1, dayNumber - 1) = ifInteger



                    'Allow number of days to increase with each hit of the enter button'
                    dayNumber += 1

                    'Takes input of the txtInput and displays it into the txDisplay'
                    displayCtr.AppendText(ifInteger & Environment.NewLine)


                    'For 7th day, I created an else if so that once I press enter for the 7th day, it will automatically calculate the average in the bottom box'
                ElseIf (dayNumber = TOTAL_DAYS) Then


                    If (empNum <= EMPLOYEE) Then

                        day(empNum - 1, dayNumber - 1) = ifInteger

                        displayCtr.AppendText(ifInteger & Environment.NewLine)

                        average = 0
                        'Calculating the average of the inputs'

                        For index = 0 To day.GetUpperBound(1)

                            average += day(empNum - 1, index)



                        Next
                        totalAvg(empNum - 1) = average

                        average /= day.GetLength(1)



                        'Display average to the output label'
                        outputCtr.Text = "Average: " & average


                        If (empNum = EMPLOYEE) Then

                            average = totalAvg.Sum() / totalAvg.Count()
                            dayNumber += 1

                            LblAverage.Text = "Average per Day: " & average


                        ElseIf empNum < EMPLOYEE Then

                            dayNumber = 1
                            empNum += 1

                        End If



                    End If



                End If

                LblDay.Text = "Day " & dayNumber

                If (dayNumber > TOTAL_DAYS) Then

                    LblDay.Text = "Day " & dayNumber - 1

                End If
                ' If the input is above 1000 or below 0 it will be considered out of range '
            Else MessageBox.Show("Input out of range, please try again.")
            End If

            ' If the input is not an integer value, it will be an error '
        Else MessageBox.Show("Input is not an integer, please try again.")

        End If






    End Sub


End Class
