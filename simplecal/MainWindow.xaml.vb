Class MainWindow
    Dim firstnum As Decimal
    Dim secondnum As Decimal
    Dim operations As Integer
    Dim operator_selector As Boolean = False


    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        If textbox1.Text <> "0" Then
            textbox1.Text += "1"
        Else
            textbox1.Text = "1"
        End If
    End Sub

    Private Sub Button_Click_1(sender As Object, e As RoutedEventArgs)
        If textbox1.Text <> "0" Then
            textbox1.Text += "2"
        Else
            textbox1.Text = "2"
        End If
    End Sub

    Private Sub Button_Click_2(sender As Object, e As RoutedEventArgs)
        If Not textbox1.Text <> "0" Then
            textbox1.Text = "3"
        Else
            textbox1.Text += "3"
        End If
    End Sub

    Private Sub Button_Click_3(sender As Object, e As RoutedEventArgs)
        If textbox1.Text Is "0" Then
            textbox1.Text = "4"
        Else
            textbox1.Text += "4"
        End If
    End Sub

    Private Sub Button_Click_4(sender As Object, e As RoutedEventArgs)
        If textbox1.Text <> "0" Then
            textbox1.Text += "5"
        Else
            textbox1.Text = "5"
        End If
    End Sub

    Private Sub Button_Click_5(sender As Object, e As RoutedEventArgs)
        If textbox1.Text <> "0" Then
            textbox1.Text += "6"
        Else
            textbox1.Text = "6"
        End If
    End Sub

    Private Sub Button_Click_6(sender As Object, e As RoutedEventArgs)
        If textbox1.Text <> "0" Then
            textbox1.Text += "7"
        Else
            textbox1.Text = "7"
        End If
    End Sub

    Private Sub Button_Click_7(sender As Object, e As RoutedEventArgs)
        If textbox1.Text <> "0" Then
            textbox1.Text += "8"
        Else
            textbox1.Text = "8"
        End If
    End Sub

    Private Sub Button_Click_8(sender As Object, e As RoutedEventArgs)
        If textbox1.Text <> "0" Then
            textbox1.Text += "9"
        Else
            textbox1.Text = "9"
        End If
    End Sub

    Private Sub Button_Click_9(sender As Object, e As RoutedEventArgs)
        If textbox1.Text <> "0" Then
            textbox1.Text += "0"

        End If

    End Sub

    Private Sub Button_Click_10(sender As Object, e As RoutedEventArgs)
        If Not (textbox1.Text.Contains(".")) Then
            textbox1.Text += "."
        End If
    End Sub

    Private Sub Button_Click_11(sender As Object, e As RoutedEventArgs)

        textbox1.Text = "0"

    End Sub

    Private Sub Button_Click_12(sender As Object, e As RoutedEventArgs)
        firstnum = textbox1.Text
        textbox1.Text = "0"
        operator_selector = True
        operations = 1 ' =+
    End Sub

    Private Sub Button_Click_13(sender As Object, e As RoutedEventArgs)
        firstnum = textbox1.Text
        textbox1.Text = "0"
        operator_selector = True
        operations = 2 ' =-
    End Sub

    Private Sub Button_Click_14(sender As Object, e As RoutedEventArgs)
        firstnum = textbox1.Text
        textbox1.Text = "0"
        operator_selector = True
        operations = 3 ' =*
    End Sub

    Private Sub Button_Click_15(sender As Object, e As RoutedEventArgs)
        firstnum = textbox1.Text
        textbox1.Text = "0"
        operator_selector = True
        operations = 4 ' =/
    End Sub

    Private Sub Button_Click_16(sender As Object, e As RoutedEventArgs)
        If operator_selector = True Then
            secondnum = textbox1.Text
            If operations = 1 Then
                textbox1.Text = firstnum + secondnum
            ElseIf operations = 2 Then
                textbox1.Text = firstnum - secondnum
            ElseIf operations = 3 Then
                textbox1.Text = firstnum * secondnum
            Else
                If secondnum = 0 Then
                    textbox1.Text = "error"
                Else
                    textbox1.Text = firstnum / secondnum
                End If
            End If
            operator_selector = False


        End If
    End Sub
End Class
