Public Class Said
    Public parametrs(5) As Short, r_data_mode As Short
    Dim way As String = Application.StartupPath, frases(), g_frases(), b_frases() As String, a, b, v, g As String, faze(4) As Short, frase_type(4) As Short
    Private Sub Said_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        My.Computer.FileSystem.WriteAllText(way & "frase.tmp", My.Resources.Frase, False)
        My.Computer.FileSystem.WriteAllText(way & "g_frase.tmp", My.Resources.Good, False)
        My.Computer.FileSystem.WriteAllText(way & "b_frase.tmp", My.Resources.Bad, False)
        frases = IO.File.ReadAllLines(way & "frase.tmp")
        g_frases = IO.File.ReadAllLines(way & "g_frase.tmp")
        b_frases = IO.File.ReadAllLines(way & "b_frase.tmp")
        My.Computer.FileSystem.DeleteFile(way & "frase.tmp")
        My.Computer.FileSystem.DeleteFile(way & "g_frase.tmp")
        My.Computer.FileSystem.DeleteFile(way & "b_frase.tmp")
        parametrs(5) = 25
        r_data_mode = 1
        R_data.Start()
    End Sub
    Private Sub Said_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Button1.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = False
        Button4.Enabled = False
        Button5.Enabled = False
        Renov_Paramet()
    End Sub
    Public Sub Renov_Paramet()
        Dim time As Boolean = R_data.Enabled
        R_data.Stop()
        Label8.Text = "Работоспособность: " & parametrs(0) & "%"
        Label4.Text = "Радость: " & parametrs(1) & "%"
        Label2.Text = "Гнев: " & parametrs(2) & "%"
        Label7.Text = "Обида: " & parametrs(3) & "%"
        Label3.Text = "Температура: " & parametrs(5) & "°"
        Calc.Text = "Калькулятор. Р - " & parametrs(0) & "% Т - " & parametrs(5) & "°"
        If parametrs(5) >= 100 Then
            UseWaitCursor = True
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = False
            Button5.Enabled = False
            TextBox1.Enabled = False
            MsgBox("Перегрев!", , "! Сообщение")
            Me.Close()
        End If
        R_data.Enabled = time
    End Sub
    Private Sub R_data_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles R_data.Tick
        Dim r As New Random
        If r_data_mode = 1 Then
            parametrs(2) = r.Next(8)
            parametrs(5) += Int(parametrs(2) / 2)
            Renov_Paramet()
            r_data_mode = 2
        ElseIf r_data_mode = 2 Then
            parametrs(3) = r.Next(10)
            Renov_Paramet()
            r_data_mode = 3
        ElseIf r_data_mode = 3 Then
            parametrs(0) = 8 - (parametrs(2) + parametrs(3))
            If parametrs(0) < 0 Then
                parametrs(0) = 0
            End If
            Renov_Paramet()
            r_data_mode = 4
        ElseIf r_data_mode = 4 Then
            parametrs(1) = 4 - parametrs(3)
            If parametrs(1) < 0 Then
                parametrs(1) = 0
            End If
            Renov_Paramet()
            r_data_mode = 5
        ElseIf r_data_mode = 5 Then
            TextBox1.Text = frases(r.Next(frases.Length))
            r_data_mode = 6
        ElseIf r_data_mode = 6 Then
            frase_type(0) = r.Next(2)
            r_data_mode = 7
        ElseIf r_data_mode = 7 Then
            frase_type(1) = r.Next(2)
            r_data_mode = 8
        ElseIf r_data_mode = 8 Then
            If frase_type(0) = 1 And frase_type(1) = 1 Then
                frase_type(2) = r.Next(3)
                If frase_type(2) = 2 Then
                    frase_type(2) = 1
                Else
                    frase_type(2) = 0
                End If
            Else
                frase_type(1) = r.Next(2)
            End If
            frase_type(2) = r.Next(2)
            r_data_mode = 9
        ElseIf r_data_mode = 9 Then
            frase_type(3) = r.Next(2)
            If frase_type(0) = 1 And frase_type(1) = 1 And frase_type(2) = 1 Then
                frase_type(3) = 0
            ElseIf frase_type(0) = 0 And frase_type(1) = 0 And frase_type(2) = 0 Then
                frase_type(3) = 1
            Else
                frase_type(3) = r.Next(2)
            End If
            r_data_mode = 10
        ElseIf r_data_mode = 10 Then
            Text_Scroll.Stop()
            If frase_type(0) = 1 Then
                a = g_frases(r.Next(g_frases.Length))
            Else
                a = b_frases(r.Next(b_frases.Length))
            End If
            faze(0) = 0
            r_data_mode = 11
        ElseIf r_data_mode = 11 Then
            If frase_type(1) = 1 Then
                b = g_frases(r.Next(g_frases.Length))
            Else
                b = b_frases(r.Next(b_frases.Length))
            End If
            faze(1) = 0
            r_data_mode = 12
        ElseIf r_data_mode = 12 Then
            If frase_type(2) = 1 Then
                v = g_frases(r.Next(g_frases.Length))
            Else
                v = b_frases(r.Next(b_frases.Length))
            End If
            faze(2) = 0
            r_data_mode = 13
        ElseIf r_data_mode = 13 Then
            If frase_type(3) = 1 Then
                g = g_frases(r.Next(g_frases.Length))
            Else
                g = b_frases(r.Next(b_frases.Length))
            End If
            faze(3) = 0
            r_data_mode = 0
            parametrs(5) += 1
            Renov_Paramet()
            Text_Scroll.Start()
            R_data.Stop()
            Button1.Enabled = True
            Button2.Enabled = True
            Button3.Enabled = True
            Button4.Enabled = True
        ElseIf r_data_mode = 14 Then
            parametrs(5) -= Int(parametrs(2) / 2)
            If parametrs(2) = 0 Then
                Dim time As Short = r.Next(4) - 2
                If time > 0 Then
                    parametrs(2) += time
                End If
            Else
                Dim time As Short = r.Next(1, 3)
                If parametrs(2) + time > 100 Then
                    parametrs(2) = 100
                Else
                    parametrs(2) += time
                End If
            End If
            parametrs(5) += Int(parametrs(2) / 2)
            r_data_mode = 15
        ElseIf r_data_mode = 15 Then
            Dim time As Short = r.Next(4)
            If parametrs(3) + time > 100 Then
                parametrs(3) = 100
            Else
                parametrs(3) += time
            End If
            r_data_mode = 16
        ElseIf r_data_mode = 16 Then
            If parametrs(0) > 0 Then
                Dim time As Short = r.Next(10) - 8
                If time = 1 Then
                    parametrs(0) += 1
                Else
                    If time < -6 Then
                        If parametrs(0) - 2 < 0 Then
                            parametrs(0) = 0
                        Else
                            parametrs(0) -= 2
                        End If
                    Else
                        parametrs(0) -= 1
                    End If
                End If
            End If
            If parametrs(0) > 50 Then
                Button5.Enabled = True
            Else
                Button5.Enabled = False
            End If
            r_data_mode = 17
        ElseIf r_data_mode = 17 Then
            Dim time As Short = r.Next(20)
            If parametrs(1) - time < 0 Then
                parametrs(1) = 0
            Else
                parametrs(1) -= time
            End If
            Renov_Paramet()
            r_data_mode = 5
        ElseIf r_data_mode = 18 Then
            parametrs(5) -= Int(parametrs(2) / 2)
            If parametrs(2) = 100 Then
                Dim time As Short = r.Next(4) - 2
                If time > 0 Then
                    parametrs(2) -= time
                End If
            Else
                If parametrs(2) - 1 < 0 Then
                    parametrs(2) = 0
                Else
                    parametrs(2) -= 1
                End If
            End If
            parametrs(5) += Int(parametrs(2) / 2)
            r_data_mode = 19
        ElseIf r_data_mode = 19 Then
            Dim time As Short = r.Next(1, 3)
            If parametrs(3) - time < 0 Then
                parametrs(3) = 0
            Else
                parametrs(3) -= time
            End If
            r_data_mode = 20
        ElseIf r_data_mode = 20 Then
            If parametrs(0) < 100 Then
                If parametrs(1) < 100 Then
                    Dim time As Short = r.Next(10)
                    If time = 9 Then
                        If parametrs(0) + 2 > 100 Then
                            parametrs(0) = 100
                        Else
                            parametrs(0) += 2
                        End If
                    Else
                        If time < 2 Then
                            parametrs(0) += 1
                        End If
                    End If
                Else
                    Dim time As Short = r.Next(10)
                    If time > 5 Then
                        If parametrs(0) + 2 > 100 Then
                            parametrs(0) = 100
                        Else
                            parametrs(0) += 2
                        End If
                    Else
                        parametrs(0) += 1
                    End If
                End If
            End If
            If parametrs(0) < 50 Then
                Button5.Enabled = False
            Else
                Button5.Enabled = True
            End If
            r_data_mode = 21
        ElseIf r_data_mode = 21 Then
            Dim time As Short = r.Next(10)
            If parametrs(1) + time > 100 Then
                parametrs(1) = 100
            Else
                parametrs(1) += time
            End If
            Renov_Paramet()
            r_data_mode = 5
        End If
    End Sub
    Dim ticks As Short = 0
    Private Sub Text_Scroll_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Text_Scroll.Tick
        a_t.Text = Mid(a, faze(0) + 1, 34)
        If faze(0) < a.Length Then
            faze(0) += 1
        Else
            faze(0) = 0
        End If
        b_t.Text = Mid(b, faze(1) + 1, 34)
        If faze(1) < b.Length Then
            faze(1) += 1
        Else
            faze(1) = 0
        End If
        v_t.Text = Mid(v, faze(2) + 1, 34)
        If faze(2) < v.Length Then
            faze(2) += 1
        Else
            faze(2) = 0
        End If
        g_t.Text = Mid(g, faze(3) + 1, 34)
        If faze(3) < g.Length Then
            faze(3) += 1
        Else
            faze(3) = 0
        End If
        If ticks = 150 Then
            ticks = 0
            parametrs(5) -= Int(parametrs(2) / 2)
            If parametrs(5) > 25 Then
                parametrs(5) -= 1
            End If
            parametrs(5) += Int(parametrs(2) / 2)
            Renov_Paramet()
        Else
            ticks += 1
        End If
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If frase_type(0) = 1 Then
            r_data_mode = 18
        Else
            r_data_mode = 14
        End If
        Button1.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = False
        Button4.Enabled = False
        R_data.Start()
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If frase_type(1) = 1 Then
            r_data_mode = 18
        Else
            r_data_mode = 14
        End If
        Button1.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = False
        Button4.Enabled = False
        R_data.Start()
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If frase_type(2) = 1 Then
            r_data_mode = 18
        Else
            r_data_mode = 14
        End If
        Button1.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = False
        Button4.Enabled = False
        R_data.Start()
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If frase_type(3) = 1 Then
            r_data_mode = 18
        Else
            r_data_mode = 14
        End If
        Button1.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = False
        Button4.Enabled = False
        R_data.Start()
    End Sub
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Calc.Show()
        Me.Hide()
    End Sub
End Class