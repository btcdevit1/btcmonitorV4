Public Class Panel_tmpl

    Private Sub CloseToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CloseToolStripMenuItem.Click
        Panel_remove(Int(Panel_menue.Name))
    End Sub


    Private Sub ToolStripMenuItem23_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem23.Click
        pandetail(Int(Panel_menue.Name)).dec = 2
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\btcmon", "p" & Int(Panel_menue.Name) & "_dec", "2")
        p1_value.Text = Convert.ToDouble(p1_value.Text.Replace(".", ",")).ToString("###0.00#######", System.Globalization.CultureInfo.CreateSpecificCulture("en-US"))
    End Sub


    Private Sub ToolStripMenuItem27_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem27.Click
        pandetail(Int(Panel_menue.Name)).dec = 3
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\btcmon", "p" & Int(Panel_menue.Name) & "_dec", "3")
        p1_value.Text = Convert.ToDouble(p1_value.Text.Replace(".", ",")).ToString("###0.000#######", System.Globalization.CultureInfo.CreateSpecificCulture("en-US"))
    End Sub

    Private Sub ToolStripMenuItem22_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem22.Click
        pandetail(Int(Panel_menue.Name)).dec = 1
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\btcmon", "p" & Int(Panel_menue.Name) & "_dec", "1")
        p1_value.Text = Convert.ToDouble(p1_value.Text.Replace(".", ",")).ToString("###0.00000#######", System.Globalization.CultureInfo.CreateSpecificCulture("en-US"))
    End Sub

    Private Sub ToolStripMenuItem26_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem26.Click
        pandetail(Int(Panel_menue.Name)).dec = 4
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\btcmon", "p" & Int(Panel_menue.Name) & "_dec", "4")
        p1_value.Text = Convert.ToDouble(p1_value.Text.Replace(".", ",")).ToString("###0.00000#######", System.Globalization.CultureInfo.CreateSpecificCulture("en-US"))
    End Sub

    Private Sub ToolStripMenuItem28_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem28.Click
        pandetail(Int(Panel_menue.Name)).dec = 5
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\btcmon", "p" & Int(Panel_menue.Name) & "_dec", "5")
        p1_value.Text = Convert.ToDouble(p1_value.Text.Replace(".", ",")).ToString("###0.000000#######", System.Globalization.CultureInfo.CreateSpecificCulture("en-US"))
    End Sub

    Private Sub ToolStripMenuItem7_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem7.Click
        pandetail(Int(Panel_menue.Name)).dec = 6
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\btcmon", "p" & Int(Panel_menue.Name) & "_dec", "6")
        p1_value.Text = Convert.ToDouble(p1_value.Text.Replace(".", ",")).ToString("###0.000000##", System.Globalization.CultureInfo.CreateSpecificCulture("en-US"))
    End Sub


    Private Sub AlertToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AlertToolStripMenuItem.Click
        alert_show(Int(Panel_menue.Name))
    End Sub

End Class
