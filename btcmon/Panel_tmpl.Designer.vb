<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Panel_tmpl
    Inherits System.Windows.Forms.UserControl

    'UserControl überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel_menue = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmp2_market = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmp2_mtgox = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmp_bitcoinde = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmp2_bitstamp = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmp_kraken = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmp2_coinmarket = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmp_bitfinex = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmp2_format = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem22 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem23 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem27 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem26 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem28 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem7 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlertToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.p1_alert_onoff = New System.Windows.Forms.RadioButton()
        Me.p1_sell = New System.Windows.Forms.Label()
        Me.p1_buy = New System.Windows.Forms.Label()
        Me.p1_market = New System.Windows.Forms.Label()
        Me.p1_coin = New System.Windows.Forms.Label()
        Me.p1_cur = New System.Windows.Forms.Label()
        Me.p1_value = New System.Windows.Forms.Label()
        Me.ToolTip4 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1.SuspendLayout()
        Me.Panel_menue.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.ContextMenuStrip = Me.Panel_menue
        Me.Panel1.Controls.Add(Me.p1_alert_onoff)
        Me.Panel1.Controls.Add(Me.p1_sell)
        Me.Panel1.Controls.Add(Me.p1_buy)
        Me.Panel1.Controls.Add(Me.p1_market)
        Me.Panel1.Controls.Add(Me.p1_coin)
        Me.Panel1.Controls.Add(Me.p1_cur)
        Me.Panel1.Controls.Add(Me.p1_value)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(179, 72)
        Me.Panel1.TabIndex = 1
        '
        'Panel_menue
        '
        Me.Panel_menue.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmp2_market, Me.CloseToolStripMenuItem, Me.cmp2_format, Me.AlertToolStripMenuItem})
        Me.Panel_menue.Name = "Panel_menue"
        Me.Panel_menue.Size = New System.Drawing.Size(108, 92)
        '
        'cmp2_market
        '
        Me.cmp2_market.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmp2_mtgox, Me.cmp2_bitstamp, Me.cmp_kraken, Me.cmp2_coinmarket, Me.cmp_bitfinex})
        Me.cmp2_market.Name = "cmp2_market"
        Me.cmp2_market.Size = New System.Drawing.Size(107, 22)
        Me.cmp2_market.Text = "market"
        '
        'cmp2_mtgox
        '
        Me.cmp2_mtgox.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmp_bitcoinde})
        Me.cmp2_mtgox.Name = "cmp2_mtgox"
        Me.cmp2_mtgox.Size = New System.Drawing.Size(126, 22)
        Me.cmp2_mtgox.Text = "Bitcoin.de"
        '
        'cmp_bitcoinde
        '
        Me.cmp_bitcoinde.Name = "cmp_bitcoinde"
        Me.cmp_bitcoinde.Size = New System.Drawing.Size(117, 22)
        Me.cmp_bitcoinde.Text = "BTC/EUR"
        '
        'cmp2_bitstamp
        '
        Me.cmp2_bitstamp.Name = "cmp2_bitstamp"
        Me.cmp2_bitstamp.Size = New System.Drawing.Size(126, 22)
        Me.cmp2_bitstamp.Text = "bitstamp"
        '
        'cmp_kraken
        '
        Me.cmp_kraken.Name = "cmp_kraken"
        Me.cmp_kraken.Size = New System.Drawing.Size(126, 22)
        Me.cmp_kraken.Text = "kraken"
        Me.cmp_kraken.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmp2_coinmarket
        '
        Me.cmp2_coinmarket.Name = "cmp2_coinmarket"
        Me.cmp2_coinmarket.Size = New System.Drawing.Size(126, 22)
        Me.cmp2_coinmarket.Text = "coinmarket"
        '
        'cmp_bitfinex
        '
        Me.cmp_bitfinex.Name = "cmp_bitfinex"
        Me.cmp_bitfinex.Size = New System.Drawing.Size(126, 22)
        Me.cmp_bitfinex.Text = "bitfinex"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.CloseToolStripMenuItem.Text = "close"
        '
        'cmp2_format
        '
        Me.cmp2_format.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem22, Me.ToolStripMenuItem23, Me.ToolStripMenuItem27, Me.ToolStripMenuItem26, Me.ToolStripMenuItem28, Me.ToolStripMenuItem7})
        Me.cmp2_format.Name = "cmp2_format"
        Me.cmp2_format.Size = New System.Drawing.Size(107, 22)
        Me.cmp2_format.Text = "format"
        '
        'ToolStripMenuItem22
        '
        Me.ToolStripMenuItem22.Name = "ToolStripMenuItem22"
        Me.ToolStripMenuItem22.Size = New System.Drawing.Size(120, 22)
        Me.ToolStripMenuItem22.Text = "0000.0"
        '
        'ToolStripMenuItem23
        '
        Me.ToolStripMenuItem23.Name = "ToolStripMenuItem23"
        Me.ToolStripMenuItem23.Size = New System.Drawing.Size(120, 22)
        Me.ToolStripMenuItem23.Text = "0000.00"
        '
        'ToolStripMenuItem27
        '
        Me.ToolStripMenuItem27.Name = "ToolStripMenuItem27"
        Me.ToolStripMenuItem27.Size = New System.Drawing.Size(120, 22)
        Me.ToolStripMenuItem27.Text = "000.000"
        '
        'ToolStripMenuItem26
        '
        Me.ToolStripMenuItem26.Name = "ToolStripMenuItem26"
        Me.ToolStripMenuItem26.Size = New System.Drawing.Size(120, 22)
        Me.ToolStripMenuItem26.Text = "00.0000"
        '
        'ToolStripMenuItem28
        '
        Me.ToolStripMenuItem28.Name = "ToolStripMenuItem28"
        Me.ToolStripMenuItem28.Size = New System.Drawing.Size(120, 22)
        Me.ToolStripMenuItem28.Text = "0.00000"
        '
        'ToolStripMenuItem7
        '
        Me.ToolStripMenuItem7.Name = "ToolStripMenuItem7"
        Me.ToolStripMenuItem7.Size = New System.Drawing.Size(120, 22)
        Me.ToolStripMenuItem7.Text = "0.000000"
        '
        'AlertToolStripMenuItem
        '
        Me.AlertToolStripMenuItem.Name = "AlertToolStripMenuItem"
        Me.AlertToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AlertToolStripMenuItem.Text = "alert"
        '
        'p1_alert_onoff
        '
        Me.p1_alert_onoff.Appearance = System.Windows.Forms.Appearance.Button
        Me.p1_alert_onoff.AutoSize = True
        Me.p1_alert_onoff.FlatAppearance.BorderSize = 0
        Me.p1_alert_onoff.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.p1_alert_onoff.Location = New System.Drawing.Point(4, 7)
        Me.p1_alert_onoff.Name = "p1_alert_onoff"
        Me.p1_alert_onoff.Size = New System.Drawing.Size(6, 6)
        Me.p1_alert_onoff.TabIndex = 5
        Me.p1_alert_onoff.TabStop = True
        Me.p1_alert_onoff.UseVisualStyleBackColor = True
        '
        'p1_sell
        '
        Me.p1_sell.ForeColor = System.Drawing.Color.White
        Me.p1_sell.Location = New System.Drawing.Point(92, 55)
        Me.p1_sell.Name = "p1_sell"
        Me.p1_sell.Size = New System.Drawing.Size(84, 13)
        Me.p1_sell.TabIndex = 4
        '
        'p1_buy
        '
        Me.p1_buy.ForeColor = System.Drawing.Color.White
        Me.p1_buy.Location = New System.Drawing.Point(1, 55)
        Me.p1_buy.Name = "p1_buy"
        Me.p1_buy.Size = New System.Drawing.Size(95, 13)
        Me.p1_buy.TabIndex = 3
        '
        'p1_market
        '
        Me.p1_market.AutoSize = True
        Me.p1_market.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.p1_market.ForeColor = System.Drawing.Color.White
        Me.p1_market.Location = New System.Drawing.Point(32, 7)
        Me.p1_market.Name = "p1_market"
        Me.p1_market.Size = New System.Drawing.Size(0, 18)
        Me.p1_market.TabIndex = 2
        Me.p1_market.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'p1_coin
        '
        Me.p1_coin.AutoSize = True
        Me.p1_coin.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.p1_coin.ForeColor = System.Drawing.Color.White
        Me.p1_coin.Location = New System.Drawing.Point(128, 7)
        Me.p1_coin.Name = "p1_coin"
        Me.p1_coin.Size = New System.Drawing.Size(41, 18)
        Me.p1_coin.TabIndex = 6
        Me.p1_coin.Text = "BTC"
        '
        'p1_cur
        '
        Me.p1_cur.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.p1_cur.ForeColor = System.Drawing.Color.White
        Me.p1_cur.Location = New System.Drawing.Point(119, 26)
        Me.p1_cur.Name = "p1_cur"
        Me.p1_cur.Size = New System.Drawing.Size(59, 25)
        Me.p1_cur.TabIndex = 1
        '
        'p1_value
        '
        Me.p1_value.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.p1_value.ForeColor = System.Drawing.Color.Lime
        Me.p1_value.Location = New System.Drawing.Point(3, 26)
        Me.p1_value.Name = "p1_value"
        Me.p1_value.Size = New System.Drawing.Size(120, 24)
        Me.p1_value.TabIndex = 0
        Me.p1_value.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ToolTip4
        '
        Me.ToolTip4.AutomaticDelay = 50
        Me.ToolTip4.AutoPopDelay = 50000
        Me.ToolTip4.InitialDelay = 50
        Me.ToolTip4.ReshowDelay = 0
        Me.ToolTip4.ShowAlways = True
        Me.ToolTip4.Tag = "999"
        Me.ToolTip4.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        '
        'Panel_tmpl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Panel_tmpl"
        Me.Size = New System.Drawing.Size(180, 74)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel_menue.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents p1_alert_onoff As System.Windows.Forms.RadioButton
    Friend WithEvents p1_sell As System.Windows.Forms.Label
    Friend WithEvents p1_buy As System.Windows.Forms.Label
    Friend WithEvents p1_market As System.Windows.Forms.Label
    Friend WithEvents p1_coin As System.Windows.Forms.Label
    Friend WithEvents p1_cur As System.Windows.Forms.Label
    Friend WithEvents p1_value As System.Windows.Forms.Label
    Friend WithEvents Panel_menue As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AlertToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmp2_market As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmp2_mtgox As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmp_bitcoinde As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmp2_bitstamp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmp_kraken As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmp2_coinmarket As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmp2_format As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem22 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem23 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem27 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem26 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem28 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem7 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmp_bitfinex As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolTip4 As System.Windows.Forms.ToolTip

End Class
