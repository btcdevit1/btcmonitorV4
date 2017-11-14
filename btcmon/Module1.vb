Module Module1
    Public Structure panel
        Public currency As String
        Public market As String
        Public buy As String
        Public sell As String
        Public time As String
        Public value As Double
        Public last_value As Double
        Public trend As String
        Public enable As Boolean
        Public status As String
        Public url As String
        Public col As Integer
        Public row As Integer
        Public alert_1_val As Double
        Public alert_2_val As Double
        Public alert_1_ar As Integer
        Public alert_2_ar As Integer
        Public alert_or As Boolean
        Public alert_set As Boolean
        Public alert As Integer
        Public coin As String
        Public dec As Integer
        Public format As System.IFormatProvider
        Public reg_url As String
        Public reg_market As String
        Public reg_currency As String
        Public reg_enable As String
        Public reg_coin As String
        Public panelscollection_id As Integer
        Public tooltip As String
    End Structure
    Public Structure st_coinmarket
        Public id As String
        Public name As String
        Public symbol As String
        Public price_usd As String
        Public price_btc As String
        Public price_eur As String
        Public price_gbp As String
        Public price_cny As String
        Public price_jpy As String
        Public change_7d As String
    End Structure
    Public Structure st_bitcoinde
        Public result As String
        Public now As String
        Public last_local As String
        Public buy As String
        Public sell As String
    End Structure
    Public Structure st_bitstamp
        Public now As String
        Public last As String
        Public buy As String
        Public sell As String
    End Structure
    Public Structure st_btcchina
        Public last As String
        Public buy As String
        Public sell As String
    End Structure
    Public Structure st_btce
        Public last As String
        Public buy As String
        Public sell As String
        Public now As String
    End Structure
    Public Structure st_kraken
        Public last As String
        Public buy As String
        Public sell As String
    End Structure
    Public Structure st_bitfinex
        Public last As String
        Public sell As String
        Public buy As String
        Public now As String

    End Structure
    Public ALERT_PANEL As Integer
    Public pandetail(50) As panel
    Public coinmarket_load As Boolean = False
    Public coinmarket_count As Integer
    Public bitcoinde As New st_bitcoinde
    Public bitstamp As New st_bitstamp
    Public btcchina As New st_btcchina
    Public btce As New st_btce
    Public kraken As New st_kraken
    Public bitfinex As New st_bitfinex
    Public coinmarket(500) As st_coinmarket
    Public Panelscollection(50) As Panel_tmpl ' Panelcontrol
    Public panels As Integer = 1 ' panelscount
    Private Sub ToolTip_Popup(sender As System.Object, e As System.Windows.Forms.PopupEventArgs)
        Dim tt As ToolTip = sender
        Dim panel = tt.Tag
        Panelscollection(panel).ToolTip4.SetToolTip(Panelscollection(panel).p1_value, pandetail(panel).tooltip)
    End Sub
   
    Public Sub set_market(ByRef p As panel, ByVal currency As String, ByVal market As String, ByVal coin As String, ByVal url As String)
        p.currency = currency
        p.market = market
        p.coin = coin
        p.url = url
        Panelscollection(p.panelscollection_id).p1_value.Text = "wait"
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\btcmon", p.reg_market, market)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\btcmon", p.reg_currency, currency)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\btcmon", p.reg_url, url)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\btcmon", p.reg_enable, "1")
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\btcmon", p.reg_coin, coin)
    End Sub
    Public Sub load_registry()

        For a = 0 To panels - 1
            pandetail(a).reg_market = "p" & a & "_market"
            pandetail(a).reg_url = "p" & a & "_url"
            pandetail(a).reg_enable = "p" & a & "_enable"
            pandetail(a).reg_coin = "p" & a & "_coin"
            pandetail(a).reg_currency = "p" & a & "_cur"
            pandetail(a).dec = 2
            pandetail(a).market = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\btcmon", pandetail(a).reg_market, "bitcoinde")
            pandetail(a).currency = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\btcmon", pandetail(a).reg_currency, "EUR")
            pandetail(a).url = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\btcmon", pandetail(a).reg_url, "https://bitcoinapi.de/widget/current-btc-price/rate.json")
            pandetail(a).enable = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\btcmon", pandetail(a).reg_enable, "1")
            pandetail(a).dec = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\btcmon", "p" & a & "_dec", "2")
            pandetail(a).coin = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\btcmon", pandetail(a).reg_coin, "BTC")

            'init alerts
            ' Panelscollection(ALERT_PANEL).p1_alert_onoff.BackColor = Color.Red
            pandetail(a).alert_2_val = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\btcmon", "p" & a & "_val2", 0)
            pandetail(a).alert_1_val = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\btcmon", "p" & a & "_alert_val1", 0)
            pandetail(a).alert_1_ar = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\btcmon", "p" & a & "_ar1", 0)
            pandetail(a).alert_2_ar = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\btcmon", "p" & a & "_ar2", 0)
            pandetail(a).alert_or = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\btcmon", "p" & a & "_or", 0)
            pandetail(a).alert_set = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\btcmon", "p" & a & "_set", False)
         
        Next



    End Sub
    Public Sub panel_add(ByVal panel As Integer)
        'Add new paneldata into pandetails

        Dim a = panel
        Dim width = Screen.PrimaryScreen.Bounds.Width
        Dim height = Screen.PrimaryScreen.Bounds.Height
        Dim hpanels As Integer = Int((width - 60) / 180)   ' max horizontal cols for panels
        Dim vpanels As Integer = Int((height - 60) / 100) ' mac vertical rows for  panels
        Dim col, row As Integer
        If panel >= hpanels Then
            row = Math.Floor(panel / hpanels)
            col = panel - (row * hpanels)
        Else
            row = 0
            col = panel
        End If


        ' Names for registry keys
        pandetail(a).reg_market = "p" & a & "_market"
        pandetail(a).reg_url = "p" & a & "_url"
        pandetail(a).reg_enable = "p" & a & "_enable"
        pandetail(a).reg_coin = "p" & a & "_coin"
        pandetail(a).reg_currency = "p" & a & "_cur"
        'pandetail(a).dec = 2
        pandetail(a).col = col
        pandetail(a).row = row
        pandetail(a).enable = True
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\btcmon", "p" & a & "_enable", "1")
        new_layout(Form1.align)
    End Sub

    Public Sub main_redraw1(Optional ByVal v As Integer = 0)
        ' Redraws all Panels on the screen
        ' Is called on start and after adding or removing panels


        Dim width = Screen.PrimaryScreen.Bounds.Width
        Dim height = Screen.PrimaryScreen.Bounds.Height
        Dim hpanels As Integer = Int((width - 60) / 180)
        Dim vpanels As Integer = Int((height - 60) / 82)
        Form1.Width = 30
        'first we remove all panelcontrolls
        For Each a As Control In Form1.Controls.Find("panel", True)
            Form1.Controls.Remove(a)
            a.Dispose()
        Next


        For a = 0 To 49
            ' 
            ' Panelscollection(a).Dispose()
            'iterate through pandetails
            If pandetail(a).enable = True Then
                pandetail(a).panelscollection_id = a
                Panelscollection(a) = New Panel_tmpl
                Panelscollection(a).Visible = True
                Panelscollection(a).Location = New Drawing.Point(pandetail(a).col * 180 + 5, pandetail(a).row * 80 + 3)
                If Form1.align = 0 Then
                    If pandetail(a).col * 180 + 30 + 180 > Form1.Width Then
                        Form1.Width = pandetail(a).col * 180 + 30 + 180
                    End If
                    Form1.Height = pandetail(a).row * 80 + 80
                Else
                    Form1.Width = pandetail(a).col * 180 + 192
                    If pandetail(a).row * 80 + 80 > Form1.Height Then
                        Form1.Height = pandetail(a).row * 80 + 80
                    End If
                End If

                Form1.Controls.Add(Panelscollection(a))
                Panelscollection(a).p1_cur.Text = "---"
                Panelscollection(a).Panel_menue.Name = a
                Panelscollection(a).cmp_kraken.Name = a
                Panelscollection(a).cmp_bitfinex.Name = a
                Panelscollection(a).cmp2_bitstamp.Name = a
                Panelscollection(a).cmp2_coinmarket.Name = a
                Panelscollection(a).cmp2_market.Name = a
                Panelscollection(a).cmp2_mtgox.Name = a
                Panelscollection(a).Name = "panel"
                Panelscollection(a).ToolTip4.Tag = a
                If pandetail(a).alert_set Then
                    Panelscollection(a).p1_alert_onoff.BackColor = Color.Red
                End If
            End If
        Next
    End Sub
    Public Sub addmenusToPanel(a As Integer)
        AddHandler Panelscollection(a).cmp_bitcoinde.Click, AddressOf Form1.bitcoinde_Click
        kraken_menu_ini(a)
        bitstamp_menu_ini(a)
        coinmarket_init(a)
        bitfinex_menu_ini(a)
        AddHandler Panelscollection(a).ToolTip4.Popup, AddressOf ToolTip_Popup
    End Sub
    Public Sub Panel_remove(removepanel As Integer)
        Dim width = Screen.PrimaryScreen.Bounds.Width
        Dim height = Screen.PrimaryScreen.Bounds.Height
        Dim hpanels As Integer = Int((width - 60) / 180)
        Dim vpanels As Integer = Int((height - 60) / 100)
        Dim col, row As Integer
        Dim p1, p2 As panel
        col = 0
        row = 0
        If removepanel = 0 And panels = 1 Then
            MsgBox("last panel cannot be removed !")
            GoTo ende
        End If
        If removepanel = panels - 1 Then ' remove the last panel
            Form1.Controls.Remove(Panelscollection(removepanel))
            Panelscollection(removepanel).Dispose()
            pandetail(removepanel).enable = False
            If pandetail(removepanel).row = 0 Then ' we are in the first row
                Form1.Width = Form1.Width - 180
            Else
                If pandetail(removepanel).row > 0 And pandetail(removepanel).col = 0 Then
                    Form1.Height = Form1.Height - 80
                End If
            End If
            panels = panels - 1
            GoTo ende
        End If
        'iterate through panetails and rearrange
        If panels > 1 Then
            For a = 0 To 49
                If a >= removepanel Then
                    ' Array.Clear(pandetail, a, 1)
                    pandetail(a) = pandetail(a + 1)
                End If
            Next
            For a = 0 To 49
                row = Math.Floor(a / hpanels)
                col = a - (row * hpanels)
                pandetail(a).col = col
                pandetail(a).row = row
                pandetail(a).reg_market = "p" & a & "_market"
                pandetail(a).reg_url = "p" & a & "_url"
                pandetail(a).reg_enable = "p" & a & "_enable"
                pandetail(a).reg_coin = "p" & a & "_coin"
                pandetail(a).reg_currency = "p" & a & "_cur"
                col = col + 1
            Next
            main_redraw1(1)
        End If
        panels = panels - 1
        For a = 0 To panels - 1

            p_draw(a)

        Next

ende:

    End Sub

    Public Sub alert_show(ByVal a As Integer)
        ALERT_PANEL = a
        Form2.ShowDialog()

    End Sub

    Public Sub alert_off(ByVal panel As Integer)
        If panel = 1 Then
            ' p1.alert_set = False
            ' p1.alert = 0
            'Form1.p1_alert_onoff.BackColor = Color.Black
            '   My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\btcmon", "p1_alert_set", p1.alert_set)
        End If

    End Sub
    Public Sub bitcoinde_get(ByVal url As String)
        Try
            Dim client As System.Net.WebClient = New System.Net.WebClient()
            Dim reply As String = client.DownloadString(url)
            Dim st(), cent As String
            Dim a As Integer
            Dim stringSeparators() As String = {Chr(34)}
            st = reply.Split(stringSeparators, StringSplitOptions.None)
            For Each s As String In st
                ' s = Mid(s, 2, Len(s) - 1)
                If a = 3 Then

                    bitcoinde.buy = "na"
                    bitcoinde.sell = "na"
                    bitcoinde.last_local = s.Split("\")(0)
                End If
                If a = 7 Then

                    bitcoinde.now = s
                    
                End If
                bitcoinde.result = "success"
                a = a + 1
            Next
        Catch ex As Exception
        End Try
    End Sub
    Public Sub kraken_get(ByVal url As String)
        Try
            Dim client As System.Net.WebClient = New System.Net.WebClient()
            Dim reply As String = client.DownloadString(url)
            Dim st() As String
            Dim u() As String
            Dim a As Integer
            Dim stringSeparators() As String = {":", ","}
            Dim stringSeparators1() As String = {Chr(34)}
            st = reply.Split(stringSeparators, StringSplitOptions.None)
            For Each s As String In st
                If a = 13 Then
                    u = s.Split(stringSeparators1, StringSplitOptions.None)
                    kraken.last = u(1)
                End If
                If a = 5 Then
                    u = s.Split(stringSeparators1, StringSplitOptions.None)
                    kraken.buy = u(1)
                End If
                If a = 9 Then
                    u = s.Split(stringSeparators1, StringSplitOptions.None)
                    kraken.sell = u(1)
                End If
                a = a + 1
            Next
        Catch ex As Exception
        End Try
    End Sub
    Public Sub bitstamp_get(ByVal url As String)
        Try
            Dim client As System.Net.WebClient = New System.Net.WebClient()
            Dim reply As String = client.DownloadString(url)
            Dim st() As String
            Dim a As Integer
            Dim stringSeparators() As String = {":", ","}
            st = reply.Split(stringSeparators, StringSplitOptions.None)
            For Each s As String In st
                s = Mid(s, 3, Len(s) - 2)
                If a = 3 Then bitstamp.last = Mid(s, 1, Len(s) - 1).Replace(".", ",")
                If a = 5 Then bitstamp.now = Mid(s, 1, Len(s) - 1)
                If a = 7 Then bitstamp.buy = Mid(s, 1, Len(s) - 1)
                If a = 13 Then bitstamp.sell = Mid(s, 1, Len(s) - 2)
                a = a + 1
            Next
        Catch ex As Exception
        End Try
    End Sub
    Public Sub bitfinex_get(ByVal url As String)
        Try
            Dim client As System.Net.WebClient = New System.Net.WebClient()
            Dim reply As String = client.DownloadString(url)
            Dim st() As String
            Dim a As Integer
            Dim stringSeparators() As String = {":", ","}
            st = reply.Split(stringSeparators, StringSplitOptions.None)
            For Each s As String In st
                s = Mid(s, 2, Len(s) - 2)
                If a = 3 Then bitfinex.sell = Mid(s, 1, Len(s)).Replace(".", ",")
                If a = 5 Then bitfinex.buy = Mid(s, 1, Len(s))
                If a = 7 Then bitfinex.last = Mid(s, 1, Len(s))
                If a = 15 Then bitfinex.now = Mid(s, 1, Len(s))
                a = a + 1
            Next
        Catch ex As Exception
        End Try
    End Sub
    Public Sub coinmarket_get(ByVal curr As String, ByVal coin As String)
        Try
            Dim client As System.Net.WebClient = New System.Net.WebClient()
            Dim a, c As Integer
            Dim stringSeparators() As String = {":", ","}
            For a = 0 To coinmarket_count
                If coinmarket(a).symbol = coin Then
                    If curr = "USD" Then
                        btcchina.last = coinmarket(a).price_usd.Replace(".", ",")
                    End If
                    If curr = "EUR" Then
                        btcchina.last = coinmarket(a).price_eur.Replace(".", ",")
                    End If
                    If curr = "CNY" Then
                        btcchina.last = coinmarket(a).price_cny.Replace(".", ",")
                    End If

                    btcchina.buy = "na"
                    btcchina.sell = "na"
                End If
            Next
        Catch ex As Exception
        End Try
    End Sub
    Public Sub coinmarket_get_prices()
        Dim client As System.Net.WebClient = New System.Net.WebClient()
        '   Dim reply As String = client.DownloadString(url)
        Dim st(), st1(), st2(), st3(), id As String
        Dim c As Integer
        Dim reply1 As String = client.DownloadString("https://api.coinmarketcap.com/v1/ticker/")
        st1 = reply1.Split("}")
        For Each f As String In st1
            st2 = f.Split(",")
            For Each g As String In st2
                st3 = g.Split(":")
                If st3(0).Contains("id") Then coinmarket(c).id = Mid(st3(1), 3, Len(st3(1)) - 3)
                If st3(0).Contains("name") Then coinmarket(c).name = Mid(st3(1), 3, Len(st3(1)) - 3)
                If st3(0).Contains("symbol") Then coinmarket(c).symbol = Mid(st3(1), 3, Len(st3(1)) - 3)
                If st3(0).Contains("price_usd") Then coinmarket(c).price_usd = Mid(st3(1), 3, Len(st3(1)) - 3)
                If st3(0).Contains("price_btc") Then coinmarket(c).price_btc = Mid(st3(1), 3, Len(st3(1)) - 3)
                If st3(0).Contains("change_7d") Then coinmarket(c).change_7d = Mid(st3(1), 3, Len(st3(1)) - 3)
            Next
            c = c + 1
        Next

        coinmarket_count = c - 1
        reply1 = client.DownloadString("https://api.coinmarketcap.com/v1/ticker/?convert=EUR")
        st1 = reply1.Split("}")
        For Each f As String In st1
            st2 = f.Split(",")
            For Each g As String In st2
                st3 = g.Split(":")
                If st3(0).Contains("id") Then
                    id = Mid(st3(1), 3, Len(st3(1)) - 3)
                End If
                If st3(0).Contains("price_eur") Then
                    For k = 0 To 499
                        If coinmarket(k).id = id Then
                            coinmarket(k).price_eur = Mid(st3(1), 3, Len(st3(1)) - 3)
                        End If
                    Next
                End If
            Next
        Next
        reply1 = client.DownloadString("https://api.coinmarketcap.com/v1/ticker/?convert=CNY")
        st1 = reply1.Split("}")
        For Each f As String In st1
            st2 = f.Split(",")
            For Each g As String In st2
                st3 = g.Split(":")
                If st3(0).Contains("id") Then
                    id = Mid(st3(1), 3, Len(st3(1)) - 3)
                End If
                If st3(0).Contains("price_cny") Then
                    For k = 0 To 499
                        If coinmarket(k).id = id Then
                            coinmarket(k).price_cny = Mid(st3(1), 3, Len(st3(1)) - 3)
                        End If
                    Next
                End If
            Next
        Next
    End Sub
    Public Sub coinmarket_init(ByVal panel As Integer)

        For r = 0 To coinmarket_count
            Dim menu4 As New ToolStripMenuItem() With {.Text = coinmarket(r).symbol, .Name = coinmarket(r).symbol}
            Dim menu4a As New ToolStripMenuItem() With {.Text = "EUR", .Name = "EUR"}
            Dim menu4b As New ToolStripMenuItem() With {.Text = "USD", .Name = "USD"}
            Dim menu4c As New ToolStripMenuItem() With {.Text = "CNY", .Name = "CNY"}
            menu4.DropDownItems.Add(menu4a)
            AddHandler menu4a.Click, AddressOf Form1.coinmarket_Clicked
            menu4.DropDownItems.Add(menu4b)
            AddHandler menu4b.Click, AddressOf Form1.coinmarket_Clicked
            menu4.DropDownItems.Add(menu4c)
            AddHandler menu4c.Click, AddressOf Form1.coinmarket_Clicked


            Dim t As ToolStripMenuItem
            t = Panelscollection(panel).cmp2_coinmarket

            menu4.DropDownItems.Add(menu4a)
            menu4.DropDownItems.Add(menu4b)
            menu4.DropDownItems.Add(menu4c)
            t.DropDownItems.Add(menu4)
        Next
        coinmarket_load = True

    End Sub
    Public Sub bitstamp_menu_ini(ByVal panel As Integer)

        Dim menu(10) As ToolStripMenuItem

        menu(0) = New ToolStripMenuItem() With {.Text = "BTC/USD", .Name = "BTC/USD"}
        menu(1) = New ToolStripMenuItem() With {.Text = "BTC/EUR", .Name = "BTC/EUR"}
        menu(2) = New ToolStripMenuItem() With {.Text = "ETH/USD", .Name = "ETH/USD"}
        menu(3) = New ToolStripMenuItem() With {.Text = "ETH/EUR", .Name = "ETH/EUR"}
        menu(4) = New ToolStripMenuItem() With {.Text = "ETH/BTC", .Name = "ETH/BTC"}
        menu(5) = New ToolStripMenuItem() With {.Text = "LTC/USD", .Name = "LTC/USD"}
        menu(6) = New ToolStripMenuItem() With {.Text = "LTC/EUR", .Name = "LTC/EUR"}
        menu(7) = New ToolStripMenuItem() With {.Text = "LTC/BTC", .Name = "LTC/BTC"}

        Dim t As ToolStripMenuItem
        t = Panelscollection(panel).cmp2_bitstamp

        For b = 0 To 7
            AddHandler menu(b).Click, AddressOf Form1.bitstamp_Clicked
            t.DropDownItems.Add(menu(b))
        Next

    End Sub
    Public Sub kraken_menu_ini(panel As Integer)

        Dim menu(10) As ToolStripMenuItem
        menu(0) = New ToolStripMenuItem() With {.Text = "XBT/USD", .Name = "XBT/USD"}
        menu(1) = New ToolStripMenuItem() With {.Text = "XBT/EUR", .Name = "XBT/EUR"}
        menu(2) = New ToolStripMenuItem() With {.Text = "ETH/USD", .Name = "ETH/USD"}
        menu(3) = New ToolStripMenuItem() With {.Text = "ETH/EUR", .Name = "ETH/EUR"}
        menu(4) = New ToolStripMenuItem() With {.Text = "ETH/XBT", .Name = "ETH/XBT"}
        menu(5) = New ToolStripMenuItem() With {.Text = "LTC/USD", .Name = "LTC/USD"}
        menu(6) = New ToolStripMenuItem() With {.Text = "LTC/EUR", .Name = "LTC/EUR"}
        menu(7) = New ToolStripMenuItem() With {.Text = "LTC/XBT", .Name = "LTC/XBT"}
        Dim t As ToolStripMenuItem
        t = Panelscollection(panel).cmp_kraken
        For b = 0 To 7
            AddHandler menu(b).Click, AddressOf Form1.kraken_Clicked
            t.DropDownItems.Add(menu(b))
        Next

    End Sub
    Public Sub bitfinex_menu_ini(panel As Integer)
        Dim menu(10) As ToolStripMenuItem
        Dim a As Integer
        a = 0
        menu(0) = New ToolStripMenuItem() With {.Text = "BTC/USD", .Name = "BTCUSD"}
        menu(1) = New ToolStripMenuItem() With {.Text = "BCH/USD", .Name = "BCHUSD"}
        menu(2) = New ToolStripMenuItem() With {.Text = "DASH/USD", .Name = "DASHUSD"}
        menu(3) = New ToolStripMenuItem() With {.Text = "ETH/USD", .Name = "ETHUSD"}
        menu(4) = New ToolStripMenuItem() With {.Text = "LTC/USD", .Name = "LTCUSD"}
        menu(5) = New ToolStripMenuItem() With {.Text = "NEO/USD", .Name = "NEOUSD"}
        menu(6) = New ToolStripMenuItem() With {.Text = "OMG/USD", .Name = "OMGUSD"}
        menu(7) = New ToolStripMenuItem() With {.Text = "XMR/USD", .Name = "XMRUSD"}
        menu(8) = New ToolStripMenuItem() With {.Text = "ZEC/USD", .Name = "ZECUSD"}
        Dim t As ToolStripMenuItem
        t = Panelscollection(panel).cmp_bitfinex
        For b = 0 To 8
            AddHandler menu(b).Click, AddressOf Form1.bitfinex_Clicked
            t.DropDownItems.Add(menu(b))
        Next
    End Sub
    Public Sub new_layout(ByRef a As Integer)

        ' Change Layout vertical / horizontal
        Dim width = Screen.PrimaryScreen.Bounds.Width
        Dim height = Screen.PrimaryScreen.Bounds.Height
        Dim hpanels As Integer = Int((width - 60) / 180)   ' max horizontal cols for panels
        Dim vpanels As Integer = Int((height - 60) / 80) ' mac vertical rows for  panels
        Dim col, row As Integer
        col = 0
        row = 0
        If a = 0 Then ' horizontal
            For b = 0 To panels - 1
                If pandetail(b).enable = True Then
                    If b >= hpanels Then
                        row = Math.Floor(b / hpanels)
                        col = b - (row * hpanels)
                    Else
                        row = 0
                        col = b
                    End If
                    pandetail(b).col = col
                    pandetail(b).row = row
                End If
            Next
        End If
        If a = 1 Then ' vertical
            For b = 0 To panels - 1
                If pandetail(b).enable = True Then
                    If b >= vpanels Then
                        col = Math.Floor(b / vpanels)
                        row = b - (col * vpanels)
                    Else
                        row = b
                        col = 0
                    End If
                    pandetail(b).col = col
                    pandetail(b).row = row
                End If
            Next
        End If


    End Sub
    Public Sub reorder_panelscollection()
        Form1.Width = 30
        For b = 0 To panels - 1
            Panelscollection(b).Location = New Drawing.Point(pandetail(b).col * 180 + 5, pandetail(b).row * 80 + 3)
            If Form1.align = 0 Then
                If pandetail(b).col * 180 + 30 + 180 > Form1.Width Then
                    Form1.Width = pandetail(b).col * 180 + 30 + 180
                End If
                Form1.Height = pandetail(b).row * 80 + 80
            Else
                Form1.Width = pandetail(b).col * 180 + 192
                If pandetail(b).row * 80 + 80 + 12 > Form1.Height Then
                    Form1.Height = pandetail(b).row * 80 + 80 + 12
                End If
            End If
        Next
    End Sub
    Public Sub p_draw(ByVal a As Integer)
        Dim i As Integer
        i = pandetail(a).panelscollection_id
        Panelscollection(i).p1_value.ForeColor = Color.White
        If pandetail(i).trend = "up" Then Panelscollection(i).p1_value.ForeColor = Color.Lime
        If pandetail(i).trend = "down" Then Panelscollection(i).p1_value.ForeColor = Color.Red
        If pandetail(i).dec = 1 Then
            Panelscollection(i).p1_value.Text = pandetail(a).value.ToString("###0.0", System.Globalization.CultureInfo.CreateSpecificCulture("en-US"))
        End If
        If pandetail(i).dec = 2 Or pandetail(i).dec = 0 Then
            Panelscollection(i).p1_value.Text = pandetail(a).value.ToString("###0.00#######", System.Globalization.CultureInfo.CreateSpecificCulture("en-US"))
        End If
        If pandetail(i).dec = 3 Then
            Panelscollection(i).p1_value.Text = pandetail(a).value.ToString("###0.000#####", System.Globalization.CultureInfo.CreateSpecificCulture("en-US"))
        End If
        If pandetail(i).dec = 4 Then
            Panelscollection(i).p1_value.Text = pandetail(a).value.ToString("###0.0000####", System.Globalization.CultureInfo.CreateSpecificCulture("en-US"))
        End If
        If pandetail(i).dec = 5 Then
            Panelscollection(i).p1_value.Text = pandetail(a).value.ToString("###0.00000###", System.Globalization.CultureInfo.CreateSpecificCulture("en-US"))
        End If
        If pandetail(i).dec = 6 Then
            Panelscollection(i).p1_value.Text = pandetail(a).value.ToString("###0.000000##", System.Globalization.CultureInfo.CreateSpecificCulture("en-US"))
        End If
        Panelscollection(i).p1_cur.Text = pandetail(a).currency
        Panelscollection(i).p1_market.Text = pandetail(a).market
        Panelscollection(i).p1_sell.Text = "sell:" + pandetail(a).sell
        Panelscollection(i).p1_buy.Text = "buy:" + pandetail(a).buy
        Panelscollection(i).p1_coin.Text = pandetail(a).coin
    End Sub

    Public Sub panel_update(ByRef p As panel, ByVal i As Integer)
        Dim a As Double
        Dim nDateTime As System.DateTime = New System.DateTime(1970, 1, 1, 0, 0, 0, 0)

        Try


            If p.market = "bitcoinde" Then
                bitcoinde_get(p.url)
                If bitcoinde.result = "success" Then
                    p.sell = bitcoinde.sell
                    p.buy = bitcoinde.buy
                    p.time = bitcoinde.now
                    p.status = bitcoinde.result
                    a = bitcoinde.last_local
                    p.value = a
                    If p.value > p.last_value Then p.trend = "up"
                    If p.value < p.last_value Then p.trend = "down"
                    p.last_value = p.value
                    p.tooltip = "last update: " & p.time
                End If
            End If
            If p.market = "bitstamp" Then
                bitstamp_get(p.url)
                p.sell = bitstamp.sell
                p.buy = bitstamp.buy
                p.time = bitstamp.now
                p.value = Convert.ToDouble(bitstamp.last)
                If p.value > p.last_value Then p.trend = "up"
                If p.value < p.last_value Then p.trend = "down"
                p.last_value = p.value
            End If
            If p.market = "bitfinex" Then
                bitfinex_get(p.url)
                p.sell = bitfinex.sell
                p.buy = bitfinex.buy
                p.time = bitfinex.now
                p.value = Convert.ToDecimal(bitfinex.last.Replace(".", ","))
                If p.value > p.last_value Then p.trend = "up"
                If p.value < p.last_value Then p.trend = "down"
                p.last_value = p.value
            End If
            If p.market = "coinmarket" Then
                coinmarket_get(p.currency, p.coin)
                p.sell = btcchina.sell
                p.buy = btcchina.buy
                p.time = "0"
                p.value = Convert.ToDecimal(btcchina.last.Replace(".", ","))
                If p.value > p.last_value Then p.trend = "up"
                If p.value < p.last_value Then p.trend = "down"
                p.last_value = p.value
            End If
            If p.market = "kraken" Then
                kraken_get(p.url)
                If Len(kraken.sell) > 10 Then p.sell = Mid(kraken.sell, 1, 10) Else p.sell = kraken.sell
                If Len(kraken.buy) > 10 Then p.buy = Mid(kraken.buy, 1, 10) Else p.buy = kraken.buy
                p.value = Convert.ToDecimal(kraken.last.Replace(".", ","))
                If p.value > p.last_value Then p.trend = "up"
                If p.value < p.last_value Then p.trend = "down"
                p.last_value = p.value
            End If
        Catch ex As Exception

        End Try

        alert_chk(i)
    End Sub
    Public Sub alert_chk(ByVal panel As Integer)
        If pandetail(panel).alert_set = True Then
            If pandetail(panel).alert_1_ar = 0 Then '>=
                If pandetail(panel).value >= pandetail(panel).alert_1_val Then pandetail(panel).alert = 1 Else pandetail(panel).alert = 0
            Else
                If pandetail(panel).alert_1_ar = 1 Then '<=
                    If pandetail(panel).value <= pandetail(panel).alert_1_val Then pandetail(panel).alert = 1 Else pandetail(panel).alert = 0
                End If
            End If
            If pandetail(panel).alert_or Then
                If pandetail(panel).alert_2_ar = 0 Then '>=
                    If pandetail(panel).value >= pandetail(panel).alert_2_val Then pandetail(panel).alert = 1
                Else
                    If pandetail(panel).alert_2_ar = 1 Then '<=
                        If pandetail(panel).value <= pandetail(panel).alert_2_val Then pandetail(panel).alert = 1
                    End If
                End If
            End If
        End If

    End Sub
End Module
