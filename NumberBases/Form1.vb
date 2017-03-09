﻿Public Class BaseConvert
    Private Sub Base10Chk_Click(sender As Object, e As EventArgs) Handles Base10Chk.Click
        If (Base2Chk.Checked Or Base16Chk.Checked Or ASCIIchk.Checked) Then
            Base2Chk.Checked = False
            Base16Chk.Checked = False
            ASCIIchk.Checked = False
        End If
    End Sub

    Private Sub Base2Chk_Click(sender As Object, e As EventArgs) Handles Base2Chk.Click
        If (Base10Chk.Checked Or Base16Chk.Checked Or ASCIIchk.Checked) Then
            Base10Chk.Checked = False
            Base16Chk.Checked = False
            ASCIIchk.Checked = False
        End If
    End Sub

    Private Sub Base16Chk_Click(sender As Object, e As EventArgs) Handles Base16Chk.Click
        If (Base2Chk.Checked Or Base10Chk.Checked Or ASCIIchk.Checked) Then
            Base2Chk.Checked = False
            Base10Chk.Checked = False
            ASCIIchk.Checked = False
        End If
    End Sub
    Private Sub ASCIIChk_Click(sender As Object, e As EventArgs) Handles ASCIIchk.Click
        If (Base2Chk.Checked Or Base10Chk.Checked Or Base16Chk.Checked) Then
            Base2Chk.Checked = False
            Base10Chk.Checked = False
            Base16Chk.Checked = False
        End If
    End Sub


    Private Sub RunBtn_Click(sender As Object, e As EventArgs) Handles RunBtn.Click
        Try
            If Base2Chk.Checked Then
                Base10.Text = Convert.ToInt32(Base2.Text, 2)
                Base16.Text = Hex(Convert.ToInt32(Base2.Text, 2))
                ASCII.Text = Chr(Convert.ToInt32(Base2.Text, 2) Mod 256)
            ElseIf Base10Chk.Checked Then
                Base2.Text = Convert.ToString(Convert.ToInt32(Base10.Text, 10), 2)
                Base16.Text = Hex(Convert.ToInt32(Base10.Text, 10))
                ASCII.Text = Chr(Convert.ToInt32(Base10.Text, 10) Mod 256)
            ElseIf Base16Chk.Checked Then
                Base2.Text = Convert.ToString(Convert.ToInt32(Base16.Text, 16), 2)
                Base10.Text = Convert.ToInt32(Base16.Text, 16)
                ASCII.Text = Chr(Convert.ToInt32(Base16.Text, 16) Mod 256)
            ElseIf ASCIIchk.Checked Then
                Base2.Text = Convert.ToString(Asc(ASCII.Text), 2)
                Base10.Text = Asc(ASCII.Text)
                Base16.Text = Hex(Asc(ASCII.Text))
            Else
                MsgBox("Please Check a Base")
            End If
        Catch ValueError As Exception
            MsgBox("Please enter Valid values")
        Finally
        End Try
    End Sub


    'Private Sub Base10_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Base10.KeyPress
    'If Asc(e.KeyChar) <> 8 Then
    'If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
    '           e.Handled = True
    'End If
    'End If

    'End Sub

    'Private Sub Base2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Base2.KeyPress
    'If Asc(e.KeyChar) <> 8 Then
    'If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
    '           e.Handled = True
    'End If
    'End If
    'End Sub

    'Private Sub Base16_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Base16.KeyPress
    'If Asc(e.KeyChar) <> 8 Then
    'If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
    '           e.Handled = True
    'End If
    'End If
    'End Sub
End Class
