Imports System.Net.WebClient
Imports System.Threading
Public Class Form1
    Dim dragme As Boolean
    Dim dragpos(1) As Integer
    Dim mainwidth As Integer
    Dim url_bitstampusd As String = "https://www.bitstamp.net/api/ticker/"
    Dim url_bitcoindeeur As String = "https://bitcoinapi.de/widget/current-btc-price/rate.json"
    Public align As Integer = 0 '0=4x1  1=1x4 2=2x2
    Public trd As Thread
    Private trd1 As Thread

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        My.Computer.Registry.CurrentUser.CreateSubKey("Software\btcmon")
        pandetail(0).reg_url = "p0_url"
        pandetail(0).reg_market = "p0_market"
        pandetail(0).reg_currency = "p0_cur"
        pandetail(0).reg_enable = "p0_enable"
        pandetail(0).reg_coin = "p0_coin"
        panels = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\btcmon", "active_panels", "1")
        align = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\btcmon", "align", "0")
        load_registry()
        pandetail(0).enable = True
        pandetail(0).col = 0
        pandetail(0).row = 0
        For a = 0 To panels - 1
            If pandetail(a).enable Then
                panel_add(a)
            End If
        Next
        main_redraw1()
        coinmarket_get_prices()
        For a = 0 To panels - 1
            If pandetail(a).enable Then
                ' panel_update(pandetail(a), a)
                addmenusToPanel(a)
            End If
        Next
       align = Int(My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\btcmon", "align", "0"))
        NotifyIcon1.Visible = False

        alert_timer.Enabled = True
        p1timer.Enabled = True
        trd = New Thread(AddressOf UpdateTask)
        trd.IsBackground = True
        trd.Start()

    End Sub
   
    Private Sub UpdateTask()
        Do
            coinmarket_get_prices()
            For a = 0 To panels - 1
                If pandetail(a).enable Then
                    panel_update(pandetail(a), a)
                End If
            Next
            Thread.Sleep(10000)
        Loop
    End Sub
    Public Sub bitstamp_Clicked(sender As Object, e As EventArgs)
        'Sometimes the menu items can remain open.  May not be necessary for you.
        Dim item As ToolStripMenuItem = TryCast(sender, ToolStripMenuItem)
        Dim curr, coin, owner As String
        If item IsNot Nothing Then
            coin = item.Text.Split("/")(0)
            curr = item.Text.Split("/")(1)
            owner = Int(item.OwnerItem.Name)
            set_market(pandetail(owner), curr, "bitstamp", coin, "https://www.bitstamp.net/api/v2/ticker/" & (coin + curr).ToLower & "/")
            ' alert_off(4)
            panel_update(pandetail(owner), owner)
        End If
    End Sub
    Public Sub bitfinex_Clicked(sender As Object, e As EventArgs)
        'Sometimes the menu items can remain open.  May not be necessary for you.
        Dim item As ToolStripMenuItem = TryCast(sender, ToolStripMenuItem)
        Dim curr, coin, owner As String
        If item IsNot Nothing Then
            coin = item.Text.Split("/")(0)
            curr = item.Text.Split("/")(1)
            owner = Int(item.OwnerItem.Name)
            set_market(pandetail(owner), curr, "bitfinex", coin, "https://api.bitfinex.com/v1/pubticker/" & (coin + curr))
            ' alert_off(4)
            panel_update(pandetail(owner), owner)
        End If
    End Sub
    Public Sub kraken_Clicked(sender As Object, e As EventArgs)
        'Sometimes the menu items can remain open.  May not be necessary for you.
        Dim item As ToolStripMenuItem = TryCast(sender, ToolStripMenuItem)

        Dim curr, coin, owner As String
        If item IsNot Nothing Then
            coin = item.Text.Split("/")(0)
            curr = item.Text.Split("/")(1)
            owner = Int(item.OwnerItem.Name)
            set_market(pandetail(owner), curr, "kraken", coin, "https://api.kraken.com/0/public/Ticker?pair=" & (coin + curr))
            ' alert_off(4)
            panel_update(pandetail(owner), owner)
        End If
    End Sub
    Public Sub coinmarket_Clicked(sender As Object, e As EventArgs)
        'Sometimes the menu items can remain open.  May not be necessary for you.
        Dim item As ToolStripMenuItem = TryCast(sender, ToolStripMenuItem)
        Dim curr, coin, owner As String
        If item IsNot Nothing Then
            coin = item.OwnerItem.Text
            curr = item.Text
            owner = item.OwnerItem.OwnerItem.OwnerItem.Name
            set_market(pandetail(owner), curr, "coinmarket", coin, "")
            ' alert_off(4)
            panel_update(pandetail(owner), owner)
        End If
    End Sub
  

    Private Sub p1timer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles p1timer.Tick
        p1timer.Enabled = False
        For a = 0 To panels - 1
            If pandetail(a).enable Then
                p_draw(a)
            End If
        Next
        p1timer.Enabled = True
    End Sub
   
   

    Public Sub bitcoinde_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim item As ToolStripMenuItem = TryCast(sender, ToolStripMenuItem)
        Dim Owner = Int(item.OwnerItem.Name)
        set_market(pandetail(Owner), "EUR", "bitcoinde", "BTC", url_bitcoindeeur)
        panel_update(pandetail(Owner), Owner)
        alert_off(1)
    End Sub


    Private Function GetUnixTimestamp(ByVal currDate As DateTime) As Double
        'create Timespan by subtracting the value provided from the Unix Epoch
        Dim span As TimeSpan = (currDate - New DateTime(2012, 1, 1, 0, 0, 0, 0).ToLocalTime())
        'return the total seconds (which is a UNIX timestamp)
        Return span.TotalSeconds
    End Function

    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        Me.Cursor = Cursors.Hand
        If e.Button = Windows.Forms.MouseButtons.Left Then
            dragme = True
            dragpos(0) = e.Location.X
            dragpos(1) = e.Location.Y
        End If
    End Sub

    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        Dim item As Control = CType(sender, Control)
        If dragme = True Then
            item.Left = item.Left - (dragpos(0) - e.Location.X)
            item.Top = item.Top - (dragpos(1) - e.Location.Y)
        End If
    End Sub

    Private Sub Form1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        Me.Cursor = Cursors.Arrow
        dragme = False
    End Sub

    Private Sub CloseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem.Click
        End
    End Sub

    Private Sub AddPanelToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddPanelToolStripMenuItem.Click
        panels = panels + 1
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\btcmon", "active_panels", panels)
        panel_add(panels - 1)
        Dim a As Integer = panels - 1
        Dim b As Integer
        ' Add to next position
        pandetail(a).panelscollection_id = a
        Panelscollection(a) = New Panel_tmpl
        Panelscollection(a).Visible = True
        Panelscollection(a).Location = New Drawing.Point(pandetail(a).col * 180 + 5, pandetail(a).row * 80 + 3)
        If align = 0 Then
            If pandetail(a).col * 180 + 30 + 180 > Me.Width Then
                Me.Width = pandetail(a).col * 180 + 30 + 180
            End If
            'Me.Width = Me.Width + Panelscollection(a).Width
            Me.Height = pandetail(a).row * 80 + 80
        Else
            Me.Width = pandetail(a).col * 180 + 192
            If pandetail(a).row * 80 + 80 > Me.Height Then
                Me.Height = pandetail(a).row * 80 + 80
            End If

        End If

            Me.Controls.Add(Panelscollection(a))
            '  Form1.main_redraw1()
            Panelscollection(a).p1_cur.Text = "---"
            Panelscollection(a).Panel_menue.Name = a
            Panelscollection(a).cmp_kraken.Name = a
            Panelscollection(a).cmp2_bitstamp.Name = a
            Panelscollection(a).cmp2_coinmarket.Name = a
            Panelscollection(a).cmp2_market.Name = a
        Panelscollection(a).cmp2_mtgox.Name = a
        Panelscollection(a).cmp_bitfinex.Name = a
            Panelscollection(a).Name = "panel"
        addmenusToPanel(a)
        b = a
            For a = 0 To panels - 1
                p_draw(a)
        Next

        Panelscollection(b).p1_value.Text = "Select market"

    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        Me.Opacity = 1
    End Sub

    Private Sub ToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem4.Click
        Me.Opacity = 0.5
    End Sub

    Private Sub ToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem3.Click
        Me.Opacity = 0.75
    End Sub

    Private Sub ToolStripMenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem5.Click
        Me.Opacity = 0.25
    End Sub

    Private Sub ToolStripMenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem6.Click
        Me.Opacity = 0.1
    End Sub

    Private Sub YesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles YesToolStripMenuItem.Click
        Me.TopMost = True
    End Sub

    Private Sub NoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NoToolStripMenuItem.Click
        Me.TopMost = False
    End Sub


    Private Sub cm_main_ver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cm_main_ver.Click
        align = 1
        align_save()
        new_layout(align)
        reorder_panelscollection()
    End Sub

    Private Sub cm_main_hor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cm_main_hor.Click
        align = 0
        align_save()
        new_layout(align)
        reorder_panelscollection()
    End Sub
    Private Sub align_save()
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\btcmon", "align", align)
    End Sub


    Private Sub alert_timer_Tick(sender As System.Object, e As System.EventArgs) Handles alert_timer.Tick
        For a = 0 To panels - 1
            If pandetail(a).alert = 1 Then
                Panelscollection(pandetail(a).panelscollection_id).Panel1.BackColor = Color.Red
                pandetail(a).alert = 2
                GoTo p2
            End If
            If pandetail(a).alert = 0 Then
                Panelscollection(pandetail(a).panelscollection_id).Panel1.BackColor = Color.Black
            End If
            If pandetail(a).alert = 2 Then
                Panelscollection(pandetail(a).panelscollection_id).Panel1.BackColor = Color.Black
                pandetail(a).alert = 1

            End If
p2:
        Next

    End Sub
    Private Sub MinimizeInTaskbarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MinimizeInTaskbarToolStripMenuItem.Click
        Me.NotifyIcon1.Visible = True
        'Me.WindowState = FormWindowState.Minimized
        Me.Visible = False

    End Sub
    Private Sub NotifyIcon1_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        If (FormWindowState.Minimized) Then
            Me.Visible = True
        End If
        Me.Activate()
    End Sub
    Private Sub InfoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InfoToolStripMenuItem.Click
        AboutBox1.ShowDialog()
    End Sub
   







  



   





End Class
