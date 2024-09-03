Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar

Public Class Form1
    Dim num1 As Decimal
    Dim num2 As Decimal
    Dim Operations As Integer


    Dim Operator_Selector As Boolean = False

    Private Sub Button4_Click(ByVal sender As Object, e As EventArgs) Handles one.Click
        Dim v = TextBox1.Text <> "1"
        TextBox1.Text += "1"


    End Sub

    Private Sub tow_Click(ByVal sender As Object, e As EventArgs) Handles two.Click
        Dim v = TextBox1.Text <> "2"
        TextBox1.Text += "2"

    End Sub


    Private Sub three_Click(ByVal sender As Object, e As EventArgs) Handles three.Click
        Dim v = TextBox1.Text <> "3"
        TextBox1.Text += "3"

    End Sub

    Private Sub four_Click(ByVal sender As Object, e As EventArgs) Handles four.Click
        Dim v = TextBox1.Text <> "4"
        TextBox1.Text += "4"

    End Sub

    Private Sub five_Click(ByVal sender As Object, e As EventArgs) Handles five.Click
        Dim v = TextBox1.Text <> "5"
        TextBox1.Text += "5"

    End Sub

    Private Sub six_Click(ByVal sender As Object, e As EventArgs) Handles six.Click
        Dim v = TextBox1.Text <> "5"
        TextBox1.Text += "6"

    End Sub

    Private Sub seven_Click(ByVal sender As Object, e As EventArgs) Handles seven.Click
        Dim v = TextBox1.Text <> "7"
        TextBox1.Text += "7"

    End Sub

    Private Sub eight_Click(ByVal sender As Object, e As EventArgs) Handles eight.Click
        Dim v = TextBox1.Text <> "8"
        TextBox1.Text += "8"
    End Sub

    Private Sub nine_Click(sender As Object, e As EventArgs) Handles nine.Click
        Dim v = TextBox1.Text <> "9"
        TextBox1.Text += "9"


    End Sub

    Private Sub zero_Click(ByVal sender As Object, e As EventArgs) Handles zero.Click
        Dim v = TextBox1.Text <> "0"
        TextBox1.Text = "0"


    End Sub

    Private Sub clear_Click(sender As Object, e As EventArgs) Handles clear.Click
        ' TextBox1.Text = ""
        If TextBox1.Text.Length > 0 Then

        End If
        TextBox1.Text = TextBox1.Text.Remove(TextBox1.Text.Length - 1)

    End Sub

    Private Sub dot_Click(ByVal sender As Object, e As EventArgs) Handles dot.Click
        If Not (TextBox1.Text.Contains(".")) Then
            TextBox1.Text += "."
        End If
    End Sub

    Private Sub deivde_Click(ByVal sender As Object, e As EventArgs) Handles deivde.Click
        num1 = TextBox1.Text
        TextBox1.Text = "0"
        Operator_Selector = True
        Operations = 4 ' = / 
    End Sub

    Private Sub pluss_Click(ByVal sender As Object, e As EventArgs) Handles pluss.Click
        num1 = TextBox1.Text
        TextBox1.Text = "0"
        Operator_Selector = True
        Operations = 1 ' = +


    End Sub

    Private Sub minus_Click(ByVal sender As Object, e As EventArgs) Handles minus.Click
        num1 = TextBox1.Text
        TextBox1.Text = "0"
        Operator_Selector = True
        Operations = 2 ' = -
    End Sub

    Private Sub times_Click(ByVal sender As Object, e As EventArgs) Handles times.Click
        num1 = TextBox1.Text
        TextBox1.Text = "0"
        Operator_Selector = True
        Operations = 3 ' = *
    End Sub

    Private Sub equals_Click(ByVal sender As Object, e As EventArgs) Handles equals.Click
        If Operator_Selector = True Then



            num2 = TextBox1.Text
            If Operations = 1 Then
                TextBox1.Text = num1 + num2

            ElseIf Operations = 2 Then
                TextBox1.Text = num1 - num2
            ElseIf Operations = 3 Then
                TextBox1.Text = num1 * num2
            ElseIf Operations = 4 Then
                TextBox1.Text = num1 * num2 / 100
            Else
                If num2 = 0 Then
                    TextBox1.Text = "ERROR!"
                Else
                    TextBox1.Text = num1 / num2
                End If

            End If
            Operator_Selector = False

        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub modolus_Click(sender As Object, e As EventArgs) Handles modolus.Click
        num1 = TextBox1.Text
        TextBox1.Text = "0"
        Operator_Selector = True
        Operations = 4 '% = *
    End Sub

    Private Sub clearall_Click(sender As Object, e As EventArgs) Handles clearall.Click
        TextBox1.Text = ""
    End Sub
End Class
