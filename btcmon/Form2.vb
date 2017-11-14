Public Class Form2
    Private Sub btn_alert_ok_Click(sender As System.Object, e As System.EventArgs) Handles btn_alert_ok.Click
        Dim k As Integer
        k = alert_ar1.SelectedIndex
        Panelscollection(ALERT_PANEL).p1_alert_onoff.BackColor = Color.Red
        pandetail(ALERT_PANEL).alert_2_val = nud_alert_higher.Value
        pandetail(ALERT_PANEL).alert_1_val = nud_alert_lower.Value
        pandetail(ALERT_PANEL).alert_1_ar = alert_ar1.SelectedIndex
        pandetail(ALERT_PANEL).alert_2_ar = alert_ar2.SelectedIndex
        pandetail(ALERT_PANEL).alert_or = cb_alert_or.Checked
        pandetail(ALERT_PANEL).alert_set = True
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\btcmon", "p" & ALERT_PANEL & "_alert_val1", pandetail(ALERT_PANEL).alert_1_val)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\btcmon", "p" & ALERT_PANEL & "_val2", pandetail(ALERT_PANEL).alert_2_val)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\btcmon", "p" & ALERT_PANEL & "_ar1", pandetail(ALERT_PANEL).alert_1_ar)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\btcmon", "p" & ALERT_PANEL & "_ar2", pandetail(ALERT_PANEL).alert_2_ar)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\btcmon", "p" & ALERT_PANEL & "_or", pandetail(ALERT_PANEL).alert_or)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\btcmon", "p" & ALERT_PANEL & "_set", pandetail(ALERT_PANEL).alert_set)
        Me.Close()
    End Sub

    Private Sub Form2_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
        Me.TopMost = True
        alert_ar1.SelectedIndex = 0
        alert_ar2.SelectedIndex = 0
        If pandetail(ALERT_PANEL).alert_set Then
            nud_alert_higher.Value = pandetail(ALERT_PANEL).alert_2_val
            nud_alert_lower.Value = pandetail(ALERT_PANEL).alert_1_val
            alert_ar1.SelectedIndex = pandetail(ALERT_PANEL).alert_1_ar
            alert_ar2.SelectedIndex = pandetail(ALERT_PANEL).alert_2_ar
            cb_alert_or.Checked = pandetail(ALERT_PANEL).alert_or
            If pandetail(ALERT_PANEL).alert_or Then
                cb_alert_or.Visible = True
                nud_alert_higher.Visible = True
            End If
        Else
            nud_alert_lower.Value = pandetail(ALERT_PANEL).last_value
        End If
    End Sub

    Private Sub btn_alert_cancel_Click(sender As System.Object, e As System.EventArgs) Handles btn_alert_cancel.Click
        Me.Close()
    End Sub

    Private Sub btn_alert_clear_Click(sender As System.Object, e As System.EventArgs) Handles btn_alert_clear.Click

        pandetail(ALERT_PANEL).alert_set = False
        Panelscollection(ALERT_PANEL).p1_alert_onoff.BackColor = Color.Black
        pandetail(ALERT_PANEL).alert = False
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\btcmon", "p" & ALERT_PANEL & "_set", pandetail(ALERT_PANEL).alert_set)
    End Sub


    Private Sub cb_alert_or_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_alert_or.CheckedChanged
        If cb_alert_or.Checked Then
            alert_ar2.Visible = True
            nud_alert_higher.Visible = True
        Else
            alert_ar2.Visible = False
            nud_alert_higher.Visible = False
        End If
    End Sub

End Class