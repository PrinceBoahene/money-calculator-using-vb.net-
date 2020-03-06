Public Class Form1

  

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox2_TextChanged(sender, e)
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox9.TextChanged, TextBox8.TextChanged, TextBox7.TextChanged, TextBox6.TextChanged, TextBox5.TextChanged, TextBox4.TextChanged, TextBox3.TextChanged, TextBox2.TextChanged, TextBox12.TextChanged, TextBox11.TextChanged, TextBox10.TextChanged


        Dim twohundredcedis As Double = Val(TextBox2.Text)
        Dim onehundredcedis As Double = Val(TextBox3.Text)
        Dim fiftycedis As Double = Val(TextBox4.Text)
        Dim twentycedis As Double = Val(TextBox5.Text)
        Dim tencedis As Double = Val(TextBox6.Text)
        Dim fivecedis As Double = Val(TextBox7.Text)
        Dim twocedis As Double = Val(TextBox8.Text)
        Dim onecedi As Double = Val(TextBox9.Text)
        Dim fiftypes As Double = Val(TextBox10.Text)
        Dim twentypes As Double = Val(TextBox11.Text)
        Dim tenpes As Double = Val(TextBox12.Text)

        If IsNumeric(twohundredcedis) And IsNumeric(onehundredcedis) And IsNumeric(fiftycedis) And IsNumeric(twentycedis) And IsNumeric(tencedis) And IsNumeric(fivecedis) And IsNumeric(twocedis) And IsNumeric(onecedi) And IsNumeric(fiftypes) And IsNumeric(twentypes) And IsNumeric(tenpes) Then

            Label6.Text = twohundredcedis * 200
            Label9.Text = onehundredcedis * 100
            Label12.Text = fiftycedis * 50
            Label15.Text = twentycedis * 20
            Label18.Text = tencedis * 10
            Label21.Text = fivecedis * 5
            Label24.Text = twocedis * 2
            Label27.Text = onecedi * 1
            Label30.Text = fiftypes * 0.5
            Label33.Text = twentypes * 0.2
            Label36.Text = tenpes * 0.1
            'If Label30.Text = "" Or Label33.Text = "" Or Label36.Text = "" Then
            '    Label5.Text = Val(Label6.Text) + Val(Label9.Text) + Val(Label12.Text) + Val(Label15.Text) + Val(Label18.Text) + Val(Label21.Text) + Val(Label24.Text) + Val(Label27.Text) + Val(Label30.Text) + Val(Label33.Text) + Val(Label36.Text) & ".00"
            'Else
            Label5.Text = Val(Label6.Text) + Val(Label9.Text) + Val(Label12.Text) + Val(Label15.Text) + Val(Label18.Text) + Val(Label21.Text) + Val(Label24.Text) + Val(Label27.Text) + Val(Label30.Text) + Val(Label33.Text) + Val(Label36.Text)


            'End If
        Else
        MsgBox("Error Please input numbers")
        End If
    End Sub

  

    Private Sub TextBox2_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox9.MouseHover, TextBox8.MouseHover, TextBox7.MouseHover, TextBox6.MouseHover, TextBox5.MouseHover, TextBox4.MouseHover, TextBox3.MouseHover, TextBox2.MouseHover, TextBox12.MouseHover, TextBox11.MouseHover, TextBox10.MouseHover
        TextBox2_TextChanged(sender, e)
    End Sub

    Private Sub TextBox2_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox9.MouseLeave, TextBox8.MouseLeave, TextBox7.MouseLeave, TextBox6.MouseLeave, TextBox5.MouseLeave, TextBox4.MouseLeave, TextBox3.MouseLeave, TextBox2.MouseLeave, TextBox12.MouseLeave, TextBox11.MouseLeave, TextBox10.MouseLeave
        TextBox2_TextChanged(sender, e)
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click

        Me.Close()

    End Sub
End Class
