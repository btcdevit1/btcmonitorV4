<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.p1timer = New System.Windows.Forms.Timer(Me.components)
        Me.cm_main = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AddPanelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MinimizeInTaskbarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PermamentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.YesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpacityToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LayoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cm_main_hor = New System.Windows.Forms.ToolStripMenuItem()
        Me.cm_main_ver = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.alert_timer = New System.Windows.Forms.Timer(Me.components)
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.cm_main.SuspendLayout()
        Me.SuspendLayout()
        '
        'p1timer
        '
        Me.p1timer.Interval = 8000
        '
        'cm_main
        '
        Me.cm_main.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddPanelToolStripMenuItem, Me.MinimizeInTaskbarToolStripMenuItem, Me.PermamentToolStripMenuItem, Me.OpacityToolStripMenuItem, Me.LayoutToolStripMenuItem, Me.CloseToolStripMenuItem, Me.InfoToolStripMenuItem})
        Me.cm_main.Name = "cm_main"
        Me.cm_main.Size = New System.Drawing.Size(164, 158)
        '
        'AddPanelToolStripMenuItem
        '
        Me.AddPanelToolStripMenuItem.Name = "AddPanelToolStripMenuItem"
        Me.AddPanelToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.AddPanelToolStripMenuItem.Text = "Add panel"
        '
        'MinimizeInTaskbarToolStripMenuItem
        '
        Me.MinimizeInTaskbarToolStripMenuItem.Name = "MinimizeInTaskbarToolStripMenuItem"
        Me.MinimizeInTaskbarToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.MinimizeInTaskbarToolStripMenuItem.Text = "minimize in systray"
        '
        'PermamentToolStripMenuItem
        '
        Me.PermamentToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.YesToolStripMenuItem, Me.NoToolStripMenuItem})
        Me.PermamentToolStripMenuItem.Name = "PermamentToolStripMenuItem"
        Me.PermamentToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.PermamentToolStripMenuItem.Text = "permament"
        '
        'YesToolStripMenuItem
        '
        Me.YesToolStripMenuItem.Name = "YesToolStripMenuItem"
        Me.YesToolStripMenuItem.Size = New System.Drawing.Size(91, 22)
        Me.YesToolStripMenuItem.Text = "yes"
        '
        'NoToolStripMenuItem
        '
        Me.NoToolStripMenuItem.Name = "NoToolStripMenuItem"
        Me.NoToolStripMenuItem.Size = New System.Drawing.Size(91, 22)
        Me.NoToolStripMenuItem.Text = "no"
        '
        'OpacityToolStripMenuItem
        '
        Me.OpacityToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2, Me.ToolStripMenuItem3, Me.ToolStripMenuItem4, Me.ToolStripMenuItem5, Me.ToolStripMenuItem6})
        Me.OpacityToolStripMenuItem.Name = "OpacityToolStripMenuItem"
        Me.OpacityToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.OpacityToolStripMenuItem.Text = "opacity"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(103, 22)
        Me.ToolStripMenuItem2.Text = "100%"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(103, 22)
        Me.ToolStripMenuItem3.Text = "75%"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(103, 22)
        Me.ToolStripMenuItem4.Text = "50%"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(103, 22)
        Me.ToolStripMenuItem5.Text = "25%"
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(103, 22)
        Me.ToolStripMenuItem6.Text = "10%"
        '
        'LayoutToolStripMenuItem
        '
        Me.LayoutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cm_main_hor, Me.cm_main_ver})
        Me.LayoutToolStripMenuItem.Name = "LayoutToolStripMenuItem"
        Me.LayoutToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.LayoutToolStripMenuItem.Text = "Layout"
        '
        'cm_main_hor
        '
        Me.cm_main_hor.Name = "cm_main_hor"
        Me.cm_main_hor.Size = New System.Drawing.Size(121, 22)
        Me.cm_main_hor.Text = "horizontal"
        '
        'cm_main_ver
        '
        Me.cm_main_ver.Name = "cm_main_ver"
        Me.cm_main_ver.Size = New System.Drawing.Size(121, 22)
        Me.cm_main_ver.Text = "vertical"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'InfoToolStripMenuItem
        '
        Me.InfoToolStripMenuItem.Name = "InfoToolStripMenuItem"
        Me.InfoToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.InfoToolStripMenuItem.Text = "Info"
        '
        'ToolTip1
        '
        Me.ToolTip1.ShowAlways = True
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        '
        'alert_timer
        '
        Me.alert_timer.Interval = 1000
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "btcmon"
        Me.NotifyIcon1.Visible = True
        '
        'Form1
        '
        Me.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(34, 86)
        Me.ContextMenuStrip = Me.cm_main
        Me.ControlBox = False
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.ToolTip1.SetToolTip(Me, "right click here for menue")
        Me.TopMost = True
        Me.cm_main.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents p1timer As System.Windows.Forms.Timer
    Friend WithEvents cm_main As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AddPanelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MinimizeInTaskbarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PermamentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents YesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpacityToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem6 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LayoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cm_main_hor As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cm_main_ver As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents alert_timer As System.Windows.Forms.Timer
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents InfoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
