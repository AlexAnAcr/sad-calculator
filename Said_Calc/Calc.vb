Public Class Calc
    Dim number_1 As String = "0", number_2 As String = "0", two_number As Boolean = False, otvet As Boolean = False, operate As Short = 1, result As String = "0", er As Boolean = False, memory As String = ""
    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        If er = True Then
            Exit Sub
        End If
        If two_number = False Then
            If number_1.IndexOf(",") = -1 Then
                number_1 &= ","
            End If
            Renovate_TextBox(0, False)
        Else
            If number_2.IndexOf(",") = -1 Then
                number_2 &= ","
            End If
            Renovate_TextBox(1, False)
        End If
    End Sub
    Private Sub Calc_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Said.Show()
        If Said.parametrs(0) > 50 Then
            Said.Button5.Enabled = True
        Else
            Said.Button5.Enabled = False
        End If
    End Sub
    Private Sub Calc_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        number_1 = "0"
        number_2 = "0"
        two_number = False
        operate = 1
        memory = ""
        Renovate_TextBox(0, False)
        TextBox1.Select(1, 0)
    End Sub
    Private Sub TextBox1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TextBox1.MouseMove
        If e.Button = MouseButtons.Left Then
            TextBox1.Select(1, 0)
        End If
    End Sub
    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        If er = True Then
            Exit Sub
        End If
        If two_number = False Then
            If number_1 <> "0" Then
                number_1 &= 0
            End If
            Renovate_TextBox(0, False)
        Else
            If number_2 <> "0" Then
                number_2 &= 0
            End If
            Renovate_TextBox(1, False)
        End If
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If er = True Then
            Exit Sub
        End If
        If two_number = False Then
            If number_1 = "0" Then
                number_1 = ""
            End If
            number_1 &= 1
            Renovate_TextBox(0, False)
        Else
            If number_2 = "0" Then
                number_2 = ""
            End If
            number_2 &= 1
            Renovate_TextBox(1, False)
        End If
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If er = True Then
            Exit Sub
        End If
        If two_number = False Then
            If number_1 = "0" Then
                number_1 = ""
            End If
            number_1 &= 2
            Renovate_TextBox(0, False)
        Else
            If number_2 = "0" Then
                number_2 = ""
            End If
            number_2 &= 2
            Renovate_TextBox(1, False)
        End If
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If er = True Then
            Exit Sub
        End If
        If two_number = False Then
            If number_1 = "0" Then
                number_1 = ""
            End If
            number_1 &= 3
            Renovate_TextBox(0, False)
        Else
            If number_2 = "0" Then
                number_2 = ""
            End If
            number_2 &= 3
            Renovate_TextBox(1, False)
        End If
    End Sub
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If er = True Then
            Exit Sub
        End If
        If two_number = False Then
            If number_1 = "0" Then
                number_1 = ""
            End If
            number_1 &= 4
            Renovate_TextBox(0, False)
        Else
            If number_2 = "0" Then
                number_2 = ""
            End If
            number_2 &= 4
            Renovate_TextBox(1, False)
        End If
    End Sub
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If er = True Then
            Exit Sub
        End If
        If two_number = False Then
            If number_1 = "0" Then
                number_1 = ""
            End If
            number_1 &= 5
            Renovate_TextBox(0, False)
        Else
            If number_2 = "0" Then
                number_2 = ""
            End If
            number_2 &= 5
            Renovate_TextBox(1, False)
        End If
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If er = True Then
            Exit Sub
        End If
        If two_number = False Then
            If number_1 = "0" Then
                number_1 = ""
            End If
            number_1 &= 6
            Renovate_TextBox(0, False)
        Else
            If number_2 = "0" Then
                number_2 = ""
            End If
            number_2 &= 6
            Renovate_TextBox(1, False)
        End If
    End Sub
    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        If er = True Then
            Exit Sub
        End If
        If two_number = False Then
            If number_1 = "0" Then
                number_1 = ""
            End If
            number_1 &= 7
            Renovate_TextBox(0, False)
        Else
            If number_2 = "0" Then
                number_2 = ""
            End If
            number_2 &= 7
            Renovate_TextBox(1, False)
        End If
    End Sub
    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        If er = True Then
            Exit Sub
        End If
        If two_number = False Then
            If number_1 = "0" Then
                number_1 = ""
            End If
            number_1 &= 8
            Renovate_TextBox(0, False)
        Else
            If number_2 = "0" Then
                number_2 = ""
            End If
            number_2 &= 8
            Renovate_TextBox(1, False)
        End If
    End Sub
    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        If er = True Then
            Exit Sub
        End If
        If two_number = False Then
            If number_1 = "0" Then
                number_1 = ""
            End If
            number_1 &= 9
            Renovate_TextBox(0, False)
        Else
            If number_2 = "0" Then
                number_2 = ""
            End If
            number_2 &= 9
            Renovate_TextBox(1, False)
        End If
    End Sub
    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        If er = True Or otvet = True Then
            Exit Sub
        End If
        If two_number = False Then
            If number_1.Length > 0 Then
                number_1 = Mid(number_1, 1, number_1.Length - 1)
                If number_1 = "" Then
                    number_1 = 0
                End If
                Renovate_TextBox(0, False)
            End If
        Else
            If number_2.Length > 0 Then
                number_2 = Mid(number_2, 1, number_2.Length - 1)
                If number_2 = "" Then
                    number_2 = 0
                End If
                Renovate_TextBox(1, False)
            End If
        End If
    End Sub
    Private Sub Renovate_TextBox(ByVal renovate_livel As Short, ByVal iserr As Boolean)
        Dim erradd As String = ""
        If iserr = True Then
            erradd = " E"
        End If
        If renovate_livel = 0 Then
            If number_1.Length > 18 Then
                If number_1.Length > 0 Then
                    number_1 = Mid(number_1, 1, 18)
                End If
                MsgBox("Область вычислений полна!", , "Сообщение")
            Else
                TextBox1.Text = number_1 & erradd
            End If
        ElseIf renovate_livel = 1 Then
            If number_2.Length > 18 Then
                If number_2.Length > 0 Then
                    number_2 = Mid(number_2, 1, 18)
                End If
                MsgBox("Область вычислений полна!", , "Сообщение")
            Else
                If operate = 1 Then
                    TextBox1.Text = number_1 & " + " & number_2 & erradd
                ElseIf operate = 2 Then
                    TextBox1.Text = number_1 & " - " & number_2 & erradd
                ElseIf operate = 3 Then
                    TextBox1.Text = number_1 & " x " & number_2 & erradd
                ElseIf operate = 4 Then
                    TextBox1.Text = number_1 & " : " & number_2 & erradd
                End If
            End If
        ElseIf renovate_livel = 2 Then
            If result.Length > 18 Then
                If Int(result.Length) > 18 Then
                    TextBox1.Text = "= " & Mid(result, 1, 18) & " E"
                    er = True
                    MsgBox("Произошла ошибка: переполнение области вычислений!", , "Ошибка")
                Else
                    TextBox1.Text = Mid(result, 1, 18)
                End If
            Else
                If operate = 1 Then
                    TextBox1.Text = number_1 & " + " & number_2 & " = " & result & erradd
                ElseIf operate = 2 Then
                    TextBox1.Text = number_1 & " - " & number_2 & " = " & result & erradd
                ElseIf operate = 3 Then
                    TextBox1.Text = number_1 & " x " & number_2 & " = " & result & erradd
                ElseIf operate = 4 Then
                    TextBox1.Text = number_1 & " : " & number_2 & " = " & result & erradd
                End If
            End If
        End If
        TextBox1.Select(TextBox1.Text.Length, 0)
    End Sub
    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click
        If er = True Then
            Exit Sub
        End If
        If two_number = False Then
            If number_1 <> "0" Then
                number_1 &= "00"
            End If
            Renovate_TextBox(0, False)
        Else
            If number_2 <> "0" Then
                number_2 &= "00"
            End If
            Renovate_TextBox(1, False)
        End If
    End Sub
    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        If er = True Or otvet = True Then
            Exit Sub
        End If
        If two_number = False Then
            number_1 = 0
            Renovate_TextBox(0, False)
        Else
            number_2 = 0
            Renovate_TextBox(1, False)
        End If
    End Sub
    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        number_1 = 0
        number_2 = 0
        two_number = False
        otvet = False
        er = False
        operate = 1
        Renovate_TextBox(0, False)
    End Sub
    Private Sub Button26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button26.Click
        If er = True Then
            Exit Sub
        End If
        If otvet = False Then
            If two_number = False Then
                If number_1 = "0" Then
                    number_1 = "-"
                ElseIf number_1 = "-" Then
                    number_1 = "0"
                Else
                    number_1 = -number_1
                End If
                Renovate_TextBox(0, False)
            Else
                If number_2 = "0" Then
                    number_2 = "-"
                ElseIf number_2 = "-" Then
                    number_2 = "0"
                Else
                    number_2 = -number_2
                End If
                Renovate_TextBox(1, False)
            End If
        End If
    End Sub
    Private Sub Button23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button23.Click
        If er = True Then
            Exit Sub
        End If
        If otvet = True Then
            memory = result
        Else
            If two_number = False Then
                memory = number_1
            Else
                memory = number_2
            End If
        End If
    End Sub
    Private Sub Button24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button24.Click
        memory = ""
    End Sub
    Private Sub Button25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button25.Click
        If er = True Then
            Exit Sub
        End If
        If otvet = False Then
            If two_number = False Then
                If number_1 = "0" Then
                    number_1 = memory
                Else
                    number_1 &= memory
                End If
                Renovate_TextBox(0, False)
            Else
                If number_2 = "0" Then
                    number_2 = memory
                Else
                    number_2 &= memory
                End If
                Renovate_TextBox(1, False)
            End If
        End If
    End Sub
    Private Sub КопироватьToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles КопироватьToolStripMenuItem.Click
        If otvet = True Then
            My.Computer.Clipboard.SetText(result)
        Else
            If two_number = False Then
                My.Computer.Clipboard.SetText(number_1)
            Else
                My.Computer.Clipboard.SetText(number_2)
            End If
        End If
    End Sub
    Private Sub ВставитьToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ВставитьToolStripMenuItem.Click
        If er = True Or My.Computer.Clipboard.ContainsText = False Then
            Exit Sub
        End If
        If otvet = False Then
            Try
                If two_number = False Then
                    If number_1 = "0" Then
                        number_1 = CType(My.Computer.Clipboard.GetText, Double) * 1
                    Else
                        number_1 &= CType(My.Computer.Clipboard.GetText, Double) * 1
                    End If
                    Renovate_TextBox(0, False)
                Else
                    If number_2 = "0" Then
                        number_2 = CType(My.Computer.Clipboard.GetText, Double) * 1
                    Else
                        number_2 &= CType(My.Computer.Clipboard.GetText, Double) * 1
                    End If
                    Renovate_TextBox(1, False)
                End If
            Catch
                If two_number = False Then
                    Renovate_TextBox(0, True)
                Else
                    Renovate_TextBox(1, True)
                End If
                er = True
                MsgBox("Произошла ошибка: невозможно обработать данное выражение!", , "Ошибка")
            End Try
        End If
    End Sub
    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        If er = True Then
            Exit Sub
        End If
        If otvet = True Then
            number_1 = result
            two_number = True
            operate = 1
            otvet = False
            number_2 = 0
            Renovate_TextBox(1, False)
        Else
            If two_number = False Then
                operate = 1
                two_number = True
                Renovate_TextBox(1, False)
            Else
                If Said.parametrs(0) < 20 Then
                    Me.Close()
                ElseIf Said.parametrs(0) < 30 Then
                    mode_wait = 3
                    Wait.Interval = 20000
                    Wait.Start()
                ElseIf Said.parametrs(0) < 40 Then
                    mode_wait = 3
                    Wait.Interval = 15000
                    Wait.Start()
                ElseIf Said.parametrs(0) < 50 Then
                    mode_wait = 3
                    Wait.Interval = 10000
                    Wait.Start()
                ElseIf Said.parametrs(0) < 80 Then
                    mode_wait = 3
                    Wait.Interval = 5000
                    Wait.Start()
                Else
                    Try
                        If operate = 1 Then
                            number_1 = CType(number_1, Double) + CType(number_2, Double)
                        ElseIf operate = 2 Then
                            number_1 = CType(number_1, Double) - CType(number_2, Double)
                        ElseIf operate = 3 Then
                            number_1 = CType(number_1, Double) * CType(number_2, Double)
                        ElseIf operate = 4 Then
                            number_1 = CType(number_1, Double) / CType(number_2, Double)
                            If number_1 = "бесконечность" Then Error 1
                            If number_1 = "бесконечность" Then number_1 = 0
                        End If
                        otvet = True
                        Renovate_TextBox(1, False)
                    Catch
                        Renovate_TextBox(1, True)
                        er = True
                        MsgBox("Произошла ошибка: невозможно обработать данное выражение!", , "Ошибка")
                    End Try
                    operate = 1
                End If
                Said.parametrs(0) -= 2
                Said.parametrs(5) += 1
                Said.Renov_Paramet()
            End If
        End If
    End Sub
    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        If Said.parametrs(0) < 20 Then
            Me.Close()
        ElseIf Said.parametrs(0) < 30 Then
            mode_wait = 1
            Wait.Interval = 20000
            Wait.Start()
        ElseIf Said.parametrs(0) < 40 Then
            mode_wait = 1
            Wait.Interval = 15000
            Wait.Start()
        ElseIf Said.parametrs(0) < 50 Then
            mode_wait = 1
            Wait.Interval = 10000
            Wait.Start()
        ElseIf Said.parametrs(0) < 80 Then
            mode_wait = 1
            Wait.Interval = 5000
            Wait.Start()
        Else
            If er = True Or two_number = False Then
                Exit Sub
            End If
            If otvet = True Then
                Try
                    number_1 = result
                    If operate = 1 Then
                        result = CType(number_1, Double) + CType(number_2, Double)
                    ElseIf operate = 2 Then
                        result = CType(number_1, Double) - CType(number_2, Double)
                    ElseIf operate = 3 Then
                        result = CType(number_1, Double) * CType(number_2, Double)
                    ElseIf operate = 4 Then
                        result = CType(number_1, Double) / CType(number_2, Double)
                        If result = "бесконечность" Then Error 1
                        If result = "бесконечность" Then result = 0
                    End If
                    Renovate_TextBox(2, False)
                Catch
                    Renovate_TextBox(1, True)
                    er = True
                    MsgBox("Произошла ошибка: невозможно обработать данное выражение!", , "Ошибка")
                End Try
            Else
                Try
                    If operate = 1 Then
                        result = CType(number_1, Double) + CType(number_2, Double)
                    ElseIf operate = 2 Then
                        result = CType(number_1, Double) - CType(number_2, Double)
                    ElseIf operate = 3 Then
                        result = CType(number_1, Double) * CType(number_2, Double)
                    ElseIf operate = 4 Then
                        result = CType(number_1, Double) / CType(number_2, Double)
                        If result = "бесконечность" Then Error 1
                        If result = "бесконечность" Then result = 0
                    End If
                    otvet = True
                    Renovate_TextBox(2, False)
                Catch
                    Renovate_TextBox(1, True)
                    er = True
                    MsgBox("Произошла ошибка: невозможно обработать данное выражение!", , "Ошибка")
                End Try
            End If
        End If
        Said.parametrs(0) -= 1
        Said.parametrs(5) += 1
        Said.Renov_Paramet()
    End Sub
    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click
        If er = True Then
            Exit Sub
        End If
        If otvet = True Then
            number_1 = result
            two_number = True
            operate = 2
            otvet = False
            number_2 = 0
            Renovate_TextBox(1, False)
        Else
            If two_number = False Then
                operate = 2
                two_number = True
                Renovate_TextBox(1, False)
            Else
                If Said.parametrs(0) < 20 Then
                    Me.Close()
                ElseIf Said.parametrs(0) < 30 Then
                    mode_wait = 4
                    Wait.Interval = 20000
                    Wait.Start()
                ElseIf Said.parametrs(0) < 40 Then
                    mode_wait = 4
                    Wait.Interval = 15000
                    Wait.Start()
                ElseIf Said.parametrs(0) < 50 Then
                    mode_wait = 4
                    Wait.Interval = 10000
                    Wait.Start()
                ElseIf Said.parametrs(0) < 80 Then
                    mode_wait = 4
                    Wait.Interval = 5000
                    Wait.Start()
                Else
                    Try
                        If operate = 1 Then
                            number_1 = CType(number_1, Double) + CType(number_2, Double)
                        ElseIf operate = 2 Then
                            number_1 = CType(number_1, Double) - CType(number_2, Double)
                        ElseIf operate = 3 Then
                            number_1 = CType(number_1, Double) * CType(number_2, Double)
                        ElseIf operate = 4 Then
                            number_1 = CType(number_1, Double) / CType(number_2, Double)
                            If number_1 = "бесконечность" Then Error 1
                            If number_1 = "бесконечность" Then number_1 = 0
                        End If
                        otvet = True
                        Renovate_TextBox(1, False)
                    Catch
                        Renovate_TextBox(1, True)
                        er = True
                        MsgBox("Произошла ошибка: невозможно обработать данное выражение!", , "Ошибка")
                    End Try
                    operate = 2
                End If
                Said.parametrs(0) -= 2
                Said.parametrs(5) += 1
                Said.Renov_Paramet()
            End If
        End If
    End Sub
    Private Sub Button19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button19.Click
        If er = True Then
            Exit Sub
        End If
        If otvet = True Then
            number_1 = result
            two_number = True
            operate = 3
            otvet = False
            number_2 = 0
            Renovate_TextBox(1, False)
        Else
            If two_number = False Then
                operate = 3
                two_number = True
                Renovate_TextBox(1, False)
            Else
                If Said.parametrs(0) < 20 Then
                    Me.Close()
                ElseIf Said.parametrs(0) < 30 Then
                    mode_wait = 5
                    Wait.Interval = 20000
                    Wait.Start()
                ElseIf Said.parametrs(0) < 40 Then
                    mode_wait = 5
                    Wait.Interval = 15000
                    Wait.Start()
                ElseIf Said.parametrs(0) < 50 Then
                    mode_wait = 5
                    Wait.Interval = 10000
                    Wait.Start()
                ElseIf Said.parametrs(0) < 80 Then
                    mode_wait = 5
                    Wait.Interval = 5000
                    Wait.Start()
                Else
                    Try
                        If operate = 1 Then
                            number_1 = CType(number_1, Double) + CType(number_2, Double)
                        ElseIf operate = 2 Then
                            number_1 = CType(number_1, Double) - CType(number_2, Double)
                        ElseIf operate = 3 Then
                            number_1 = CType(number_1, Double) * CType(number_2, Double)
                        ElseIf operate = 4 Then
                            number_1 = CType(number_1, Double) / CType(number_2, Double)
                            If number_1 = "бесконечность" Then Error 1
                            If number_1 = "бесконечность" Then number_1 = 0
                        End If
                        otvet = True
                        Renovate_TextBox(1, False)
                    Catch
                        Renovate_TextBox(1, True)
                        er = True
                        MsgBox("Произошла ошибка: невозможно обработать данное выражение!", , "Ошибка")
                    End Try
                    operate = 3
                End If
                Said.parametrs(0) -= 2
                Said.parametrs(5) += 1
                Said.Renov_Paramet()
            End If
        End If
    End Sub
    Private Sub Button20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button20.Click
        If er = True Then
            Exit Sub
        End If
        If otvet = True Then
            number_1 = result
            two_number = True
            operate = 4
            otvet = False
            number_2 = 0
            Renovate_TextBox(1, False)
        Else
            If two_number = False Then
                operate = 4
                two_number = True
                Renovate_TextBox(1, False)
            Else
                If Said.parametrs(0) < 20 Then
                    Me.Close()
                ElseIf Said.parametrs(0) < 30 Then
                    mode_wait = 6
                    Wait.Interval = 20000
                    Wait.Start()
                ElseIf Said.parametrs(0) < 40 Then
                    mode_wait = 6
                    Wait.Interval = 15000
                    Wait.Start()
                ElseIf Said.parametrs(0) < 50 Then
                    mode_wait = 6
                    Wait.Interval = 10000
                    Wait.Start()
                ElseIf Said.parametrs(0) < 80 Then
                    mode_wait = 6
                    Wait.Interval = 5000
                    Wait.Start()
                Else
                    Try
                        If operate = 1 Then
                            number_1 = CType(number_1, Double) + CType(number_2, Double)
                        ElseIf operate = 2 Then
                            number_1 = CType(number_1, Double) - CType(number_2, Double)
                        ElseIf operate = 3 Then
                            number_1 = CType(number_1, Double) * CType(number_2, Double)
                        ElseIf operate = 4 Then
                            number_1 = CType(number_1, Double) / CType(number_2, Double)
                            If number_1 = "бесконечность" Then Error 1
                            If number_1 = "бесконечность" Then number_1 = 0
                        End If
                        otvet = True
                        Renovate_TextBox(1, False)
                    Catch
                        Renovate_TextBox(1, True)
                        er = True
                        MsgBox("Произошла ошибка: невозможно обработать данное выражение!", , "Ошибка")
                    End Try
                    operate = 4
                End If
                Said.parametrs(0) -= 2
                Said.parametrs(5) += 1
                Said.Renov_Paramet()
            End If
        End If
    End Sub
    Private Sub Button21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button21.Click
        If Said.parametrs(0) < 20 Then
            Me.Close()
        ElseIf Said.parametrs(0) < 30 Then
            mode_wait = 7
            Wait.Interval = 20000
            Wait.Start()
        ElseIf Said.parametrs(0) < 40 Then
            mode_wait = 7
            Wait.Interval = 15000
            Wait.Start()
        ElseIf Said.parametrs(0) < 50 Then
            mode_wait = 7
            Wait.Interval = 10000
            Wait.Start()
        ElseIf Said.parametrs(0) < 80 Then
            mode_wait = 7
            Wait.Interval = 5000
            Wait.Start()
        Else
            If er = True Or two_number = False Then
                Exit Sub
            End If
            If otvet = True Then
                Try
                    number_1 = result
                    result = CType(number_1, Double) / 100 * CType(number_2, Double)
                    If operate = 1 Then
                        result = CType(number_1, Double) + result
                    ElseIf operate = 2 Then
                        result = CType(number_1, Double) - result
                    ElseIf operate = 3 Then
                        result = CType(number_1, Double) * result
                    ElseIf operate = 4 Then
                        result = CType(number_1, Double) / result
                        If result = "бесконечность" Then Error 1
                        If result = "бесконечность" Then result = 0
                    End If
                    If result.Length > 18 Then
                        If Int(result.Length) > 18 Then
                            TextBox1.Text = "= " & Mid(result, 1, 18) & " E"
                            er = True
                            MsgBox("Произошла ошибка: переполнение области вычислений!", , "Ошибка")
                        Else
                            TextBox1.Text = Mid(result, 1, 18)
                        End If
                    Else
                        TextBox1.Text = number_1 & " + " & number_2 & "% = " & result
                    End If
                Catch
                    Renovate_TextBox(1, True)
                    er = True
                    MsgBox("Произошла ошибка: невозможно обработать данное выражение!", , "Ошибка")
                End Try
            Else
                Try
                    result = CType(number_1, Double) / 100 * CType(number_2, Double)
                    If operate = 1 Then
                        result = CType(number_1, Double) + result
                    ElseIf operate = 2 Then
                        result = CType(number_1, Double) - result
                    ElseIf operate = 3 Then
                        result = CType(number_1, Double) * result
                    ElseIf operate = 4 Then
                        result = CType(number_1, Double) / result
                        If result = "бесконечность" Then Error 1
                        If result = "бесконечность" Then result = 0
                    End If
                    otvet = True
                    If result.Length > 18 Then
                        If Int(result.Length) > 18 Then
                            TextBox1.Text = "= " & Mid(result, 1, 18) & " E"
                            er = True
                            MsgBox("Произошла ошибка: переполнение области вычислений!", , "Ошибка")
                        Else
                            TextBox1.Text = Mid(result, 1, 18)
                        End If
                    Else
                        TextBox1.Text = number_1 & " + " & number_2 & "% = " & result
                    End If
                Catch
                    Renovate_TextBox(1, True)
                    er = True
                    MsgBox("Произошла ошибка: невозможно обработать данное выражение!", , "Ошибка")
                End Try
            End If
        End If
        Said.parametrs(0) -= 3
        Said.parametrs(5) += 2
        Said.Renov_Paramet()
    End Sub
    Private Sub ВКонецToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ВКонецToolStripMenuItem.Click
        TextBox1.Select(0, 0)
    End Sub
    Private Sub ВНачалоToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ВНачалоToolStripMenuItem.Click
        TextBox1.Select(TextBox1.Text.Length, 0)
    End Sub
    Private Sub ВСерединуToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ВСерединуToolStripMenuItem.Click
        TextBox1.Select(TextBox1.Text.Length / 2, 0)
    End Sub
    Private Sub Button22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button22.Click
        If Said.parametrs(0) < 20 Then
            Me.Close()
        ElseIf Said.parametrs(0) < 30 Then
            mode_wait = 2
            Wait.Interval = 20000
            Wait.Start()
        ElseIf Said.parametrs(0) < 40 Then
            mode_wait = 2
            Wait.Interval = 15000
            Wait.Start()
        ElseIf Said.parametrs(0) < 50 Then
            mode_wait = 2
            Wait.Interval = 10000
            Wait.Start()
        ElseIf Said.parametrs(0) < 80 Then
            mode_wait = 2
            Wait.Interval = 5000
            Wait.Start()
        Else
            If er = True Then
                Exit Sub
            End If
            If otvet = True Then
                number_1 = result
                number_2 = 0
                result = Math.Sqrt(result)
                operate = 4
                If result = "NaN" Then
                    TextBox1.Text = "√" & number_1 & " E"
                    er = True
                    MsgBox("Произошла ошибка: невозможно обработать данное выражение!", , "Ошибка")
                Else
                    If result.Length > 18 Then
                        If Int(result.Length) > 18 Then
                            TextBox1.Text = "= " & Mid(result, 1, 18) & " E"
                            er = True
                            MsgBox("Произошла ошибка: переполнение области вычислений!", , "Ошибка")
                        Else
                            TextBox1.Text = Mid(result, 1, 18)
                        End If
                    Else
                        TextBox1.Text = "√" & number_1 & " = " & result
                    End If
                End If
            Else
                If two_number = True Then
                    MsgBox("Второе число не будет использовано для извлечения квадратного корня!", , "Сообщение")
                End If
                otvet = True
                number_2 = 0
                result = Math.Sqrt(number_1)
                operate = 4
                If result = "NaN" Then
                    TextBox1.Text = "√" & number_1 & " E"
                    er = True
                    MsgBox("Произошла ошибка: невозможно обработать данное выражение!", , "Ошибка")
                Else
                    If result.Length > 18 Then
                        If Int(result.Length) > 18 Then
                            TextBox1.Text = "= " & Mid(result, 1, 18) & " E"
                            er = True
                            MsgBox("Произошла ошибка: переполнение области вычислений!", , "Ошибка")
                        Else
                            TextBox1.Text = Mid(result, 1, 18)
                        End If
                    Else
                        TextBox1.Text = "√" & number_1 & " = " & result
                    End If
                End If
            End If
        End If
        Said.parametrs(0) -= 4
        Said.parametrs(5) += 2
        Said.Renov_Paramet()
    End Sub
    Dim mode_wait As Short = 0
    Private Sub Wait_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Wait.Tick
        If mode_wait = 1 Then
            If er = True Or two_number = False Then
                Exit Sub
            End If
            If otvet = True Then
                Try
                    number_1 = result
                    If operate = 1 Then
                        result = CType(number_1, Double) + CType(number_2, Double)
                    ElseIf operate = 2 Then
                        result = CType(number_1, Double) - CType(number_2, Double)
                    ElseIf operate = 3 Then
                        result = CType(number_1, Double) * CType(number_2, Double)
                    ElseIf operate = 4 Then
                        result = CType(number_1, Double) / CType(number_2, Double)
                        If result = "бесконечность" Then Error 1
                        If result = "бесконечность" Then result = 0
                    End If
                    Renovate_TextBox(2, False)
                Catch
                    Renovate_TextBox(1, True)
                    er = True
                    MsgBox("Произошла ошибка: невозможно обработать данное выражение!", , "Ошибка")
                End Try
            Else
                Try
                    If operate = 1 Then
                        result = CType(number_1, Double) + CType(number_2, Double)
                    ElseIf operate = 2 Then
                        result = CType(number_1, Double) - CType(number_2, Double)
                    ElseIf operate = 3 Then
                        result = CType(number_1, Double) * CType(number_2, Double)
                    ElseIf operate = 4 Then
                        result = CType(number_1, Double) / CType(number_2, Double)
                        If result = "бесконечность" Then Error 1
                        If result = "бесконечность" Then result = 0
                    End If
                    otvet = True
                    Renovate_TextBox(2, False)
                Catch
                    Renovate_TextBox(1, True)
                    er = True
                    MsgBox("Произошла ошибка: невозможно обработать данное выражение!", , "Ошибка")
                End Try
            End If
        ElseIf mode_wait = 2 Then
            If er = True Then
                Exit Sub
            End If
            If otvet = True Then
                number_1 = result
                number_2 = 0
                result = Math.Sqrt(result)
                operate = 4
                If result = "NaN" Then
                    TextBox1.Text = "√" & number_1 & " E"
                    er = True
                    MsgBox("Произошла ошибка: невозможно обработать данное выражение!", , "Ошибка")
                Else
                    If result.Length > 18 Then
                        If Int(result.Length) > 18 Then
                            TextBox1.Text = "= " & Mid(result, 1, 18) & " E"
                            er = True
                            MsgBox("Произошла ошибка: переполнение области вычислений!", , "Ошибка")
                        Else
                            TextBox1.Text = Mid(result, 1, 18)
                        End If
                    Else
                        TextBox1.Text = "√" & number_1 & " = " & result
                    End If
                End If
            Else
                If two_number = True Then
                    MsgBox("Второе число не будет использовано для извлечения квадратного корня!", , "Сообщение")
                End If
                otvet = True
                number_2 = 0
                result = Math.Sqrt(number_1)
                operate = 4
                If result = "NaN" Then
                    TextBox1.Text = "√" & number_1 & " E"
                    er = True
                    MsgBox("Произошла ошибка: невозможно обработать данное выражение!", , "Ошибка")
                Else
                    If result.Length > 18 Then
                        If Int(result.Length) > 18 Then
                            TextBox1.Text = "= " & Mid(result, 1, 18) & " E"
                            er = True
                            MsgBox("Произошла ошибка: переполнение области вычислений!", , "Ошибка")
                        Else
                            TextBox1.Text = Mid(result, 1, 18)
                        End If
                    Else
                        TextBox1.Text = "√" & number_1 & " = " & result
                    End If
                End If
            End If
        ElseIf mode_wait = 3 Then
            Try
                If operate = 1 Then
                    number_1 = CType(number_1, Double) + CType(number_2, Double)
                ElseIf operate = 2 Then
                    number_1 = CType(number_1, Double) - CType(number_2, Double)
                ElseIf operate = 3 Then
                    number_1 = CType(number_1, Double) * CType(number_2, Double)
                ElseIf operate = 4 Then
                    number_1 = CType(number_1, Double) / CType(number_2, Double)
                    If number_1 = "бесконечность" Then Error 1
                    If number_1 = "бесконечность" Then number_1 = 0
                End If
                otvet = True
                Renovate_TextBox(1, False)
            Catch
                Renovate_TextBox(1, True)
                er = True
                MsgBox("Произошла ошибка: невозможно обработать данное выражение!", , "Ошибка")
            End Try
            operate = 1
        ElseIf mode_wait = 4 Then
            Try
                If operate = 1 Then
                    number_1 = CType(number_1, Double) + CType(number_2, Double)
                ElseIf operate = 2 Then
                    number_1 = CType(number_1, Double) - CType(number_2, Double)
                ElseIf operate = 3 Then
                    number_1 = CType(number_1, Double) * CType(number_2, Double)
                ElseIf operate = 4 Then
                    number_1 = CType(number_1, Double) / CType(number_2, Double)
                    If number_1 = "бесконечность" Then Error 1
                    If number_1 = "бесконечность" Then number_1 = 0
                End If
                otvet = True
                Renovate_TextBox(1, False)
            Catch
                Renovate_TextBox(1, True)
                er = True
                MsgBox("Произошла ошибка: невозможно обработать данное выражение!", , "Ошибка")
            End Try
            operate = 2
        ElseIf mode_wait = 5 Then
            Try
                If operate = 1 Then
                    number_1 = CType(number_1, Double) + CType(number_2, Double)
                ElseIf operate = 2 Then
                    number_1 = CType(number_1, Double) - CType(number_2, Double)
                ElseIf operate = 3 Then
                    number_1 = CType(number_1, Double) * CType(number_2, Double)
                ElseIf operate = 4 Then
                    number_1 = CType(number_1, Double) / CType(number_2, Double)
                    If number_1 = "бесконечность" Then Error 1
                    If number_1 = "бесконечность" Then number_1 = 0
                End If
                otvet = True
                Renovate_TextBox(1, False)
            Catch
                Renovate_TextBox(1, True)
                er = True
                MsgBox("Произошла ошибка: невозможно обработать данное выражение!", , "Ошибка")
            End Try
            operate = 3
        ElseIf mode_wait = 6 Then
            Try
                If operate = 1 Then
                    number_1 = CType(number_1, Double) + CType(number_2, Double)
                ElseIf operate = 2 Then
                    number_1 = CType(number_1, Double) - CType(number_2, Double)
                ElseIf operate = 3 Then
                    number_1 = CType(number_1, Double) * CType(number_2, Double)
                ElseIf operate = 4 Then
                    number_1 = CType(number_1, Double) / CType(number_2, Double)
                    If number_1 = "бесконечность" Then Error 1
                    If number_1 = "бесконечность" Then number_1 = 0
                End If
                otvet = True
                Renovate_TextBox(1, False)
            Catch
                Renovate_TextBox(1, True)
                er = True
                MsgBox("Произошла ошибка: невозможно обработать данное выражение!", , "Ошибка")
            End Try
            operate = 4
        ElseIf mode_wait = 7 Then
            If er = True Or two_number = False Then
                Exit Sub
            End If
            If otvet = True Then
                Try
                    number_1 = result
                    result = CType(number_1, Double) / 100 * CType(number_2, Double)
                    If operate = 1 Then
                        result = CType(number_1, Double) + result
                    ElseIf operate = 2 Then
                        result = CType(number_1, Double) - result
                    ElseIf operate = 3 Then
                        result = CType(number_1, Double) * result
                    ElseIf operate = 4 Then
                        result = CType(number_1, Double) / result
                        If result = "бесконечность" Then Error 1
                        If result = "бесконечность" Then result = 0
                    End If
                    If result.Length > 18 Then
                        If Int(result.Length) > 18 Then
                            TextBox1.Text = "= " & Mid(result, 1, 18) & " E"
                            er = True
                            MsgBox("Произошла ошибка: переполнение области вычислений!", , "Ошибка")
                        Else
                            TextBox1.Text = Mid(result, 1, 18)
                        End If
                    Else
                        TextBox1.Text = number_1 & " + " & number_2 & "% = " & result
                    End If
                Catch
                    Renovate_TextBox(1, True)
                    er = True
                    MsgBox("Произошла ошибка: невозможно обработать данное выражение!", , "Ошибка")
                End Try
            Else
                Try
                    result = CType(number_1, Double) / 100 * CType(number_2, Double)
                    If operate = 1 Then
                        result = CType(number_1, Double) + result
                    ElseIf operate = 2 Then
                        result = CType(number_1, Double) - result
                    ElseIf operate = 3 Then
                        result = CType(number_1, Double) * result
                    ElseIf operate = 4 Then
                        result = CType(number_1, Double) / result
                        If result = "бесконечность" Then Error 1
                        If result = "бесконечность" Then result = 0
                    End If
                    otvet = True
                    If result.Length > 18 Then
                        If Int(result.Length) > 18 Then
                            TextBox1.Text = "= " & Mid(result, 1, 18) & " E"
                            er = True
                            MsgBox("Произошла ошибка: переполнение области вычислений!", , "Ошибка")
                        Else
                            TextBox1.Text = Mid(result, 1, 18)
                        End If
                    Else
                        TextBox1.Text = number_1 & " + " & number_2 & "% = " & result
                    End If
                Catch
                    Renovate_TextBox(1, True)
                    er = True
                    MsgBox("Произошла ошибка: невозможно обработать данное выражение!", , "Ошибка")
                End Try
            End If
        End If
        Wait.Stop()
    End Sub
End Class
