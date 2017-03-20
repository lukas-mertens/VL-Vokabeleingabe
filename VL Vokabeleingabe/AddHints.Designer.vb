<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddHints
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddHints))
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeaderLabel = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderText = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.InformationLöschenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlleInformationenLöschenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.btAdd = New System.Windows.Forms.Button()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.ListView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeaderLabel, Me.ColumnHeaderText})
        Me.ListView1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.ListView1.HoverSelection = True
        Me.ListView1.Location = New System.Drawing.Point(13, 82)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(294, 278)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeaderLabel
        '
        Me.ColumnHeaderLabel.Text = "Bezeichnung"
        Me.ColumnHeaderLabel.Width = 80
        '
        'ColumnHeaderText
        '
        Me.ColumnHeaderText.Text = "Text"
        Me.ColumnHeaderText.Width = 210
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InformationLöschenToolStripMenuItem, Me.AlleInformationenLöschenToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(266, 48)
        '
        'InformationLöschenToolStripMenuItem
        '
        Me.InformationLöschenToolStripMenuItem.Name = "InformationLöschenToolStripMenuItem"
        Me.InformationLöschenToolStripMenuItem.Size = New System.Drawing.Size(265, 22)
        Me.InformationLöschenToolStripMenuItem.Text = "Ausgewählte Informationen löschen"
        '
        'AlleInformationenLöschenToolStripMenuItem
        '
        Me.AlleInformationenLöschenToolStripMenuItem.Name = "AlleInformationenLöschenToolStripMenuItem"
        Me.AlleInformationenLöschenToolStripMenuItem.Size = New System.Drawing.Size(265, 22)
        Me.AlleInformationenLöschenToolStripMenuItem.Text = "Alle Informationen löschen"
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.Location = New System.Drawing.Point(3, 3)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(141, 20)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.Text = "Bezeichnung"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.Location = New System.Drawing.Point(13, 12)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.TextBox1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.TextBox2)
        Me.SplitContainer1.Size = New System.Drawing.Size(294, 28)
        Me.SplitContainer1.SplitterDistance = 147
        Me.SplitContainer1.TabIndex = 2
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox2.Location = New System.Drawing.Point(3, 3)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(137, 20)
        Me.TextBox2.TabIndex = 0
        Me.TextBox2.Text = "Text"
        '
        'btAdd
        '
        Me.btAdd.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btAdd.Location = New System.Drawing.Point(16, 42)
        Me.btAdd.Name = "btAdd"
        Me.btAdd.Size = New System.Drawing.Size(288, 23)
        Me.btAdd.TabIndex = 3
        Me.btAdd.Text = "Hinzufügen"
        Me.btAdd.UseVisualStyleBackColor = True
        '
        'AddHints
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(319, 372)
        Me.Controls.Add(Me.btAdd)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.ListView1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AddHints"
        Me.Text = "Informationen hinzufügen"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ListView1 As ListView
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents btAdd As Button
    Friend WithEvents ColumnHeaderLabel As ColumnHeader
    Friend WithEvents ColumnHeaderText As ColumnHeader
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents InformationLöschenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AlleInformationenLöschenToolStripMenuItem As ToolStripMenuItem
End Class
