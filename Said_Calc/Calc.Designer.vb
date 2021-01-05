<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Calc
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Calc))
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ContextMenuClean = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.КопироватьToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ВставитьToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ВКонецToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ВСерединуToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ВНачалоToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.Button15 = New System.Windows.Forms.Button()
        Me.Button16 = New System.Windows.Forms.Button()
        Me.Button17 = New System.Windows.Forms.Button()
        Me.Button18 = New System.Windows.Forms.Button()
        Me.Button19 = New System.Windows.Forms.Button()
        Me.Button20 = New System.Windows.Forms.Button()
        Me.Button21 = New System.Windows.Forms.Button()
        Me.Button22 = New System.Windows.Forms.Button()
        Me.Button23 = New System.Windows.Forms.Button()
        Me.Button24 = New System.Windows.Forms.Button()
        Me.Button25 = New System.Windows.Forms.Button()
        Me.Button26 = New System.Windows.Forms.Button()
        Me.Wait = New System.Windows.Forms.Timer(Me.components)
        Me.ContextMenuClean.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.BackColor = System.Drawing.SystemColors.Window
        Me.TextBox1.ContextMenuStrip = Me.ContextMenuClean
        Me.TextBox1.Cursor = System.Windows.Forms.Cursors.Default
        Me.TextBox1.Font = New System.Drawing.Font("Lubalin Graph", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(12, 12)
        Me.TextBox1.MaxLength = 25
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(363, 37)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ContextMenuClean
        '
        Me.ContextMenuClean.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ContextMenuClean.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.КопироватьToolStripMenuItem, Me.ВставитьToolStripMenuItem, Me.ToolStripSeparator1, Me.ВКонецToolStripMenuItem, Me.ВСерединуToolStripMenuItem, Me.ВНачалоToolStripMenuItem})
        Me.ContextMenuClean.Name = "ContextMenuClean"
        Me.ContextMenuClean.ShowImageMargin = False
        Me.ContextMenuClean.Size = New System.Drawing.Size(144, 120)
        '
        'КопироватьToolStripMenuItem
        '
        Me.КопироватьToolStripMenuItem.Name = "КопироватьToolStripMenuItem"
        Me.КопироватьToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.КопироватьToolStripMenuItem.Text = "Копировать"
        '
        'ВставитьToolStripMenuItem
        '
        Me.ВставитьToolStripMenuItem.Name = "ВставитьToolStripMenuItem"
        Me.ВставитьToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.ВставитьToolStripMenuItem.Text = "Вставить"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(140, 6)
        '
        'ВКонецToolStripMenuItem
        '
        Me.ВКонецToolStripMenuItem.Name = "ВКонецToolStripMenuItem"
        Me.ВКонецToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.ВКонецToolStripMenuItem.Text = "< В начало"
        '
        'ВСерединуToolStripMenuItem
        '
        Me.ВСерединуToolStripMenuItem.Name = "ВСерединуToolStripMenuItem"
        Me.ВСерединуToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.ВСерединуToolStripMenuItem.Text = "< В середину >"
        '
        'ВНачалоToolStripMenuItem
        '
        Me.ВНачалоToolStripMenuItem.Name = "ВНачалоToolStripMenuItem"
        Me.ВНачалоToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.ВНачалоToolStripMenuItem.Text = "В конец >"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button1.Location = New System.Drawing.Point(69, 55)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(44, 40)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button2.Location = New System.Drawing.Point(119, 55)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(44, 40)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button3.Location = New System.Drawing.Point(169, 55)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(44, 40)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button4.Location = New System.Drawing.Point(169, 101)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(44, 40)
        Me.Button4.TabIndex = 6
        Me.Button4.Text = "6"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button5.Location = New System.Drawing.Point(119, 101)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(44, 40)
        Me.Button5.TabIndex = 5
        Me.Button5.Text = "5"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button6.Location = New System.Drawing.Point(69, 101)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(44, 40)
        Me.Button6.TabIndex = 4
        Me.Button6.Text = "4"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button7.Location = New System.Drawing.Point(169, 147)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(44, 40)
        Me.Button7.TabIndex = 9
        Me.Button7.Text = "9"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button8.Location = New System.Drawing.Point(119, 147)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(44, 40)
        Me.Button8.TabIndex = 8
        Me.Button8.Text = "8"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button9.Location = New System.Drawing.Point(69, 147)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(44, 40)
        Me.Button9.TabIndex = 7
        Me.Button9.Text = "7"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button10.Location = New System.Drawing.Point(69, 193)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(94, 40)
        Me.Button10.TabIndex = 10
        Me.Button10.Text = "0"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button11
        '
        Me.Button11.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button11.Location = New System.Drawing.Point(169, 193)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(44, 40)
        Me.Button11.TabIndex = 11
        Me.Button11.Text = ","
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Button12
        '
        Me.Button12.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button12.Location = New System.Drawing.Point(219, 193)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(48, 40)
        Me.Button12.TabIndex = 14
        Me.Button12.Text = "+"
        Me.Button12.UseVisualStyleBackColor = True
        '
        'Button13
        '
        Me.Button13.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button13.Location = New System.Drawing.Point(12, 193)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(51, 40)
        Me.Button13.TabIndex = 22
        Me.Button13.Text = "AC/" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "/CE"
        Me.Button13.UseVisualStyleBackColor = True
        '
        'Button14
        '
        Me.Button14.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button14.Location = New System.Drawing.Point(273, 147)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(48, 84)
        Me.Button14.TabIndex = 17
        Me.Button14.Text = "="
        Me.Button14.UseVisualStyleBackColor = True
        '
        'Button15
        '
        Me.Button15.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button15.Location = New System.Drawing.Point(12, 55)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(44, 40)
        Me.Button15.TabIndex = 20
        Me.Button15.Text = ">"
        Me.Button15.UseVisualStyleBackColor = True
        '
        'Button16
        '
        Me.Button16.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button16.Location = New System.Drawing.Point(12, 147)
        Me.Button16.Name = "Button16"
        Me.Button16.Size = New System.Drawing.Size(44, 40)
        Me.Button16.TabIndex = 21
        Me.Button16.Text = "C"
        Me.Button16.UseVisualStyleBackColor = True
        '
        'Button17
        '
        Me.Button17.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button17.Location = New System.Drawing.Point(12, 101)
        Me.Button17.Name = "Button17"
        Me.Button17.Size = New System.Drawing.Size(44, 40)
        Me.Button17.TabIndex = 12
        Me.Button17.Text = "00"
        Me.Button17.UseVisualStyleBackColor = True
        '
        'Button18
        '
        Me.Button18.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button18.Location = New System.Drawing.Point(219, 147)
        Me.Button18.Name = "Button18"
        Me.Button18.Size = New System.Drawing.Size(48, 40)
        Me.Button18.TabIndex = 15
        Me.Button18.Text = "-"
        Me.Button18.UseVisualStyleBackColor = True
        '
        'Button19
        '
        Me.Button19.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button19.Location = New System.Drawing.Point(219, 101)
        Me.Button19.Name = "Button19"
        Me.Button19.Size = New System.Drawing.Size(48, 40)
        Me.Button19.TabIndex = 16
        Me.Button19.Text = "x"
        Me.Button19.UseVisualStyleBackColor = True
        '
        'Button20
        '
        Me.Button20.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button20.Location = New System.Drawing.Point(273, 101)
        Me.Button20.Name = "Button20"
        Me.Button20.Size = New System.Drawing.Size(48, 40)
        Me.Button20.TabIndex = 17
        Me.Button20.Text = ":"
        Me.Button20.UseVisualStyleBackColor = True
        '
        'Button21
        '
        Me.Button21.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button21.Location = New System.Drawing.Point(219, 55)
        Me.Button21.Name = "Button21"
        Me.Button21.Size = New System.Drawing.Size(48, 40)
        Me.Button21.TabIndex = 18
        Me.Button21.Text = "%"
        Me.Button21.UseVisualStyleBackColor = True
        '
        'Button22
        '
        Me.Button22.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button22.Location = New System.Drawing.Point(273, 55)
        Me.Button22.Name = "Button22"
        Me.Button22.Size = New System.Drawing.Size(48, 40)
        Me.Button22.TabIndex = 19
        Me.Button22.Text = "√"
        Me.Button22.UseVisualStyleBackColor = True
        '
        'Button23
        '
        Me.Button23.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button23.Location = New System.Drawing.Point(327, 55)
        Me.Button23.Name = "Button23"
        Me.Button23.Size = New System.Drawing.Size(48, 40)
        Me.Button23.TabIndex = 23
        Me.Button23.Text = "M" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "+/-"
        Me.Button23.UseVisualStyleBackColor = True
        '
        'Button24
        '
        Me.Button24.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button24.Location = New System.Drawing.Point(327, 101)
        Me.Button24.Name = "Button24"
        Me.Button24.Size = New System.Drawing.Size(48, 40)
        Me.Button24.TabIndex = 24
        Me.Button24.Text = "MC"
        Me.Button24.UseVisualStyleBackColor = True
        '
        'Button25
        '
        Me.Button25.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button25.Location = New System.Drawing.Point(327, 147)
        Me.Button25.Name = "Button25"
        Me.Button25.Size = New System.Drawing.Size(48, 40)
        Me.Button25.TabIndex = 25
        Me.Button25.Text = "MR"
        Me.Button25.UseVisualStyleBackColor = True
        '
        'Button26
        '
        Me.Button26.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button26.Location = New System.Drawing.Point(327, 191)
        Me.Button26.Name = "Button26"
        Me.Button26.Size = New System.Drawing.Size(48, 40)
        Me.Button26.TabIndex = 13
        Me.Button26.Text = "+/-"
        Me.Button26.UseVisualStyleBackColor = True
        '
        'Wait
        '
        '
        'Calc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(387, 243)
        Me.Controls.Add(Me.Button23)
        Me.Controls.Add(Me.Button26)
        Me.Controls.Add(Me.Button25)
        Me.Controls.Add(Me.Button24)
        Me.Controls.Add(Me.Button15)
        Me.Controls.Add(Me.Button22)
        Me.Controls.Add(Me.Button21)
        Me.Controls.Add(Me.Button20)
        Me.Controls.Add(Me.Button19)
        Me.Controls.Add(Me.Button18)
        Me.Controls.Add(Me.Button14)
        Me.Controls.Add(Me.Button16)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button12)
        Me.Controls.Add(Me.Button17)
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.Button13)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Calc"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Калькулятор. Р - 100% Т - 0°"
        Me.ContextMenuClean.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents Button12 As System.Windows.Forms.Button
    Friend WithEvents Button13 As System.Windows.Forms.Button
    Friend WithEvents Button14 As System.Windows.Forms.Button
    Friend WithEvents Button15 As System.Windows.Forms.Button
    Friend WithEvents Button16 As System.Windows.Forms.Button
    Friend WithEvents Button17 As System.Windows.Forms.Button
    Friend WithEvents Button18 As System.Windows.Forms.Button
    Friend WithEvents Button19 As System.Windows.Forms.Button
    Friend WithEvents Button20 As System.Windows.Forms.Button
    Friend WithEvents Button21 As System.Windows.Forms.Button
    Friend WithEvents Button22 As System.Windows.Forms.Button
    Friend WithEvents Button23 As System.Windows.Forms.Button
    Friend WithEvents Button24 As System.Windows.Forms.Button
    Friend WithEvents Button25 As System.Windows.Forms.Button
    Friend WithEvents Button26 As System.Windows.Forms.Button
    Friend WithEvents ContextMenuClean As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents КопироватьToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ВставитьToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ВКонецToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ВНачалоToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ВСерединуToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Wait As System.Windows.Forms.Timer

End Class
