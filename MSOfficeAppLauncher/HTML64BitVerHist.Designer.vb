<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HTML64BitVerHist
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.HTML64BitViewer = New System.Windows.Forms.WebBrowser()
        Me.SuspendLayout()
        '
        'HTML64BitViewer
        '
        Me.HTML64BitViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HTML64BitViewer.Location = New System.Drawing.Point(0, 0)
        Me.HTML64BitViewer.MinimumSize = New System.Drawing.Size(20, 20)
        Me.HTML64BitViewer.Name = "HTML64BitViewer"
        Me.HTML64BitViewer.ScrollBarsEnabled = False
        Me.HTML64BitViewer.Size = New System.Drawing.Size(376, 453)
        Me.HTML64BitViewer.TabIndex = 0
        Me.HTML64BitViewer.Url = New System.Uri("C:\resources.drew_general\rss_feeds\drews-apps_office64launch-rss.html", System.UriKind.Absolute)
        '
        'HTML64BitVerHist
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(376, 453)
        Me.Controls.Add(Me.HTML64BitViewer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "HTML64BitVerHist"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "64-Bit Version History"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents HTML64BitViewer As System.Windows.Forms.WebBrowser

End Class
