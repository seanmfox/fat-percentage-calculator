'Name: Sean Fox
'Course: CIT-161-Z03B
'Date: 5-28-19
'Program Name: Fat Percentage Calculator
'Description: Chapter 4, Programming Challenge 3 - Create an application that calculates the percentage of calories that come from fat in a food

Public Class Form1
    Private Sub BtnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim dblTotalCalories As Double
        Dim dblFatGrams As Double

        If Double.TryParse(txtCalories.Text, dblTotalCalories) AndAlso Double.TryParse(txtFat.Text, dblFatGrams) Then
            Dim dblFatCalories As Double = dblFatGrams * 9
            If dblFatCalories <= dblTotalCalories AndAlso dblFatCalories >= 0 AndAlso dblTotalCalories >= 0 Then
                Dim dblPercentFromFat As Double = dblFatCalories / dblTotalCalories
                lblPercent.Text = dblPercentFromFat.ToString("p")
                If dblPercentFromFat < 0.3 Then
                    MessageBox.Show("The food is low in fat.")
                End If
            Else
                MessageBox.Show("Calories or fat grams have been entered incorrectly.")
            End If
        Else
            MessageBox.Show("Calories and fat can only be numeric inputs.")
        End If
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblPercent.Text = String.Empty
        txtCalories.Text = String.Empty
        txtFat.Text = String.Empty
        txtCalories.Focus()

    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

End Class
