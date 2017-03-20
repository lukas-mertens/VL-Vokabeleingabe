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
        Me.btSaveToCSV = New System.Windows.Forms.Button()
        Me.tbLanguage1 = New System.Windows.Forms.TextBox()
        Me.lbLanguage1 = New System.Windows.Forms.Label()
        Me.tbLanguage2 = New System.Windows.Forms.TextBox()
        Me.lbLanguage2 = New System.Windows.Forms.Label()
        Me.cbLanguage1 = New System.Windows.Forms.ComboBox()
        Me.cbLanguage2 = New System.Windows.Forms.ComboBox()
        Me.cboEnableKeySubmit = New System.Windows.Forms.CheckBox()
        Me.btEnter = New System.Windows.Forms.Button()
        Me.lvVocabulary = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cmsLvVocabulary = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AusgewählteVokabelnLöschenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.btLoadFromCSV = New System.Windows.Forms.Button()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.btHint1 = New System.Windows.Forms.Button()
        Me.btHint2 = New System.Windows.Forms.Button()
        Me.cmsLvVocabulary.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btSaveToCSV
        '
        Me.btSaveToCSV.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btSaveToCSV.Location = New System.Drawing.Point(12, 437)
        Me.btSaveToCSV.Name = "btSaveToCSV"
        Me.btSaveToCSV.Size = New System.Drawing.Size(471, 23)
        Me.btSaveToCSV.TabIndex = 0
        Me.btSaveToCSV.Text = "Vokabeln als JSON speichern"
        Me.btSaveToCSV.UseVisualStyleBackColor = True
        '
        'tbLanguage1
        '
        Me.tbLanguage1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbLanguage1.Location = New System.Drawing.Point(12, 41)
        Me.tbLanguage1.Multiline = True
        Me.tbLanguage1.Name = "tbLanguage1"
        Me.tbLanguage1.Size = New System.Drawing.Size(447, 20)
        Me.tbLanguage1.TabIndex = 1
        Me.tbLanguage1.Tag = ""
        '
        'lbLanguage1
        '
        Me.lbLanguage1.AutoSize = True
        Me.lbLanguage1.Location = New System.Drawing.Point(12, 22)
        Me.lbLanguage1.Name = "lbLanguage1"
        Me.lbLanguage1.Size = New System.Drawing.Size(50, 13)
        Me.lbLanguage1.TabIndex = 2
        Me.lbLanguage1.Text = "Englisch:"
        '
        'tbLanguage2
        '
        Me.tbLanguage2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbLanguage2.Location = New System.Drawing.Point(12, 88)
        Me.tbLanguage2.Multiline = True
        Me.tbLanguage2.Name = "tbLanguage2"
        Me.tbLanguage2.Size = New System.Drawing.Size(447, 20)
        Me.tbLanguage2.TabIndex = 3
        Me.tbLanguage2.Tag = ""
        '
        'lbLanguage2
        '
        Me.lbLanguage2.AutoSize = True
        Me.lbLanguage2.Location = New System.Drawing.Point(12, 72)
        Me.lbLanguage2.Name = "lbLanguage2"
        Me.lbLanguage2.Size = New System.Drawing.Size(50, 13)
        Me.lbLanguage2.TabIndex = 4
        Me.lbLanguage2.Text = "Deutsch:"
        '
        'cbLanguage1
        '
        Me.cbLanguage1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbLanguage1.FormattingEnabled = True
        Me.cbLanguage1.Items.AddRange(New Object() {"keine", "Abchasisch", "Afar", "Afrikaans", "Albanisch", "Amharisch", "Arabisch", "Armenisch", "Aserbaidschanisch", "Assamesisch", "Aymara", "Baschkirisch", "Baskisch", "Belorussisch", "Bengalisch", "Biharisch", "Bislamisch", "Bosnisch", "Bretonisch", "Bulgarisch", "Burmesisch", "Chinesisch", "Dänisch", "Deutsch", "Dzongkha", "Englisch", "Esperanto", "Estnisch", "Färöisch", "Fiji", "Finnisch", "Französisch", "Friesisch", "Galizisch", "Georgisch", "Griechisch", "Guarani", "Gujaratisch", "Haussa", "Hebräisch", "Hindi", "Indonesisch", "Interlingua", "Interlingue", "Inuktitut", "Inupiak", "Irisch", "Isländisch", "Italienisch", "Japanisch", "Javanisch", "Jiddish", "Joruba", "Kalaallisut", "Kambodschanisch", "Kannada", "Kasachisch", "Kaschmirisch", "Katalanisch", "Kijarwanda", "Kirgisisch", "Kirundisch", "Koreanisch", "Korsisch", "Kroatisch", "Kurdisch", "Laotisch", "Lateinisch", "Lettisch", "Lingala", "Litauisch", "Malagasisch", "Malajalam", "Malaysisch", "Maltesisch", "Maorisch", "Marathi", "Mazedonisch", "Moldavisch", "Mongolisch", "Nauruisch", "Nepalesisch", "Niederländisch", "Norwegisch", "Okzitanisch", "Oriya", "Oromo", "Paschtu", "Persisch", "Polnisch", "Portugiesisch", "Pundjabisch", "Quechua", "Rätoromanisch", "Rumänisch", "Russisch", "Samoanisch", "Sango", "Sanskrit", "Schonisch", "Schwedisch", "Serbisch", "Serbokroatisch", "Sesothisch", "Sindhi", "Singhalesisch", "Slowakisch", "Slowenisch", "Somalisch", "Spanisch", "Suaheli", "Sudanesisch", "Swasiländisch", "Tadschikisch", "Tagalog", "Tamilisch", "Tatarisch", "Telugu", "Thai", "Tibetanisch", "Tigrinja", "Tongaisch", "Tschechisch", "Tsongaisch", "Türkisch", "Turkmenisch", "Twi", "Uigurisch", "Ukrainisch", "Ungarisch", "Urdu", "Usbekisch", "Vietnamesisch", "Volapük", "Walisisch", "Wolof", "Xhosa", "Zhuang", "Zulu"})
        Me.cbLanguage1.Location = New System.Drawing.Point(15, 8)
        Me.cbLanguage1.Name = "cbLanguage1"
        Me.cbLanguage1.Size = New System.Drawing.Size(223, 21)
        Me.cbLanguage1.TabIndex = 5
        '
        'cbLanguage2
        '
        Me.cbLanguage2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbLanguage2.FormattingEnabled = True
        Me.cbLanguage2.Items.AddRange(New Object() {"keine", "Abchasisch", "Afar", "Afrikaans", "Albanisch", "Amharisch", "Arabisch", "Armenisch", "Aserbaidschanisch", "Assamesisch", "Aymara", "Baschkirisch", "Baskisch", "Belorussisch", "Bengalisch", "Biharisch", "Bislamisch", "Bosnisch", "Bretonisch", "Bulgarisch", "Burmesisch", "Chinesisch", "Dänisch", "Deutsch", "Dzongkha", "Englisch", "Esperanto", "Estnisch", "Färöisch", "Fiji", "Finnisch", "Französisch", "Friesisch", "Galizisch", "Georgisch", "Griechisch", "Guarani", "Gujaratisch", "Haussa", "Hebräisch", "Hindi", "Indonesisch", "Interlingua", "Interlingue", "Inuktitut", "Inupiak", "Irisch", "Isländisch", "Italienisch", "Japanisch", "Javanisch", "Jiddish", "Joruba", "Kalaallisut", "Kambodschanisch", "Kannada", "Kasachisch", "Kaschmirisch", "Katalanisch", "Kijarwanda", "Kirgisisch", "Kirundisch", "Koreanisch", "Korsisch", "Kroatisch", "Kurdisch", "Laotisch", "Lateinisch", "Lettisch", "Lingala", "Litauisch", "Malagasisch", "Malajalam", "Malaysisch", "Maltesisch", "Maorisch", "Marathi", "Mazedonisch", "Moldavisch", "Mongolisch", "Nauruisch", "Nepalesisch", "Niederländisch", "Norwegisch", "Okzitanisch", "Oriya", "Oromo", "Paschtu", "Persisch", "Polnisch", "Portugiesisch", "Pundjabisch", "Quechua", "Rätoromanisch", "Rumänisch", "Russisch", "Samoanisch", "Sango", "Sanskrit", "Schonisch", "Schwedisch", "Serbisch", "Serbokroatisch", "Sesothisch", "Sindhi", "Singhalesisch", "Slowakisch", "Slowenisch", "Somalisch", "Spanisch", "Suaheli", "Sudanesisch", "Swasiländisch", "Tadschikisch", "Tagalog", "Tamilisch", "Tatarisch", "Telugu", "Thai", "Tibetanisch", "Tigrinja", "Tongaisch", "Tschechisch", "Tsongaisch", "Türkisch", "Turkmenisch", "Twi", "Uigurisch", "Ukrainisch", "Ungarisch", "Urdu", "Usbekisch", "Vietnamesisch", "Volapük", "Walisisch", "Wolof", "Xhosa", "Zhuang", "Zulu"})
        Me.cbLanguage2.Location = New System.Drawing.Point(4, 8)
        Me.cbLanguage2.Name = "cbLanguage2"
        Me.cbLanguage2.Size = New System.Drawing.Size(228, 21)
        Me.cbLanguage2.TabIndex = 6
        '
        'cboEnableKeySubmit
        '
        Me.cboEnableKeySubmit.AutoSize = True
        Me.cboEnableKeySubmit.Checked = True
        Me.cboEnableKeySubmit.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cboEnableKeySubmit.Location = New System.Drawing.Point(15, 182)
        Me.cboEnableKeySubmit.Name = "cboEnableKeySubmit"
        Me.cboEnableKeySubmit.Size = New System.Drawing.Size(179, 17)
        Me.cboEnableKeySubmit.TabIndex = 7
        Me.cboEnableKeySubmit.Text = "Vokabel durch Return speichern"
        Me.cboEnableKeySubmit.UseVisualStyleBackColor = True
        '
        'btEnter
        '
        Me.btEnter.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btEnter.Location = New System.Drawing.Point(12, 115)
        Me.btEnter.Name = "btEnter"
        Me.btEnter.Size = New System.Drawing.Size(471, 23)
        Me.btEnter.TabIndex = 8
        Me.btEnter.Text = "Speichern"
        Me.btEnter.UseVisualStyleBackColor = True
        '
        'lvVocabulary
        '
        Me.lvVocabulary.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvVocabulary.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.lvVocabulary.ContextMenuStrip = Me.cmsLvVocabulary
        Me.lvVocabulary.FullRowSelect = True
        Me.lvVocabulary.Location = New System.Drawing.Point(12, 206)
        Me.lvVocabulary.Name = "lvVocabulary"
        Me.lvVocabulary.Size = New System.Drawing.Size(471, 196)
        Me.lvVocabulary.TabIndex = 9
        Me.lvVocabulary.UseCompatibleStateImageBehavior = False
        Me.lvVocabulary.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Vokabel"
        Me.ColumnHeader1.Width = 160
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Sprache"
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Vokabel"
        Me.ColumnHeader3.Width = 183
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Sprache"
        '
        'cmsLvVocabulary
        '
        Me.cmsLvVocabulary.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AusgewählteVokabelnLöschenToolStripMenuItem})
        Me.cmsLvVocabulary.Name = "cmsLvVocabulary"
        Me.cmsLvVocabulary.Size = New System.Drawing.Size(238, 26)
        '
        'AusgewählteVokabelnLöschenToolStripMenuItem
        '
        Me.AusgewählteVokabelnLöschenToolStripMenuItem.Name = "AusgewählteVokabelnLöschenToolStripMenuItem"
        Me.AusgewählteVokabelnLöschenToolStripMenuItem.Size = New System.Drawing.Size(237, 22)
        Me.AusgewählteVokabelnLöschenToolStripMenuItem.Text = "Ausgewählte Vokabeln löschen"
        '
        'SaveFileDialog
        '
        Me.SaveFileDialog.Filter = "CSV-Datei (.csv) |*.csv"
        Me.SaveFileDialog.Title = "Vokabeln exportieren"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 144)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.cbLanguage1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.cbLanguage2)
        Me.SplitContainer1.Size = New System.Drawing.Size(493, 32)
        Me.SplitContainer1.SplitterDistance = 247
        Me.SplitContainer1.TabIndex = 10
        '
        'btLoadFromCSV
        '
        Me.btLoadFromCSV.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btLoadFromCSV.Location = New System.Drawing.Point(12, 408)
        Me.btLoadFromCSV.Name = "btLoadFromCSV"
        Me.btLoadFromCSV.Size = New System.Drawing.Size(471, 23)
        Me.btLoadFromCSV.TabIndex = 11
        Me.btLoadFromCSV.Text = "Vokabeln aus JSON laden"
        Me.btLoadFromCSV.UseVisualStyleBackColor = True
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.FileName = "OpenFileDialog1"
        '
        'btHint1
        '
        Me.btHint1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btHint1.Location = New System.Drawing.Point(465, 39)
        Me.btHint1.Name = "btHint1"
        Me.btHint1.Size = New System.Drawing.Size(18, 23)
        Me.btHint1.TabIndex = 12
        Me.btHint1.Text = "💡"
        Me.btHint1.UseVisualStyleBackColor = True
        '
        'btHint2
        '
        Me.btHint2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btHint2.Location = New System.Drawing.Point(465, 86)
        Me.btHint2.Name = "btHint2"
        Me.btHint2.Size = New System.Drawing.Size(18, 23)
        Me.btHint2.TabIndex = 13
        Me.btHint2.Text = "💡"
        Me.btHint2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(495, 472)
        Me.Controls.Add(Me.btHint2)
        Me.Controls.Add(Me.btHint1)
        Me.Controls.Add(Me.btLoadFromCSV)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.lvVocabulary)
        Me.Controls.Add(Me.btEnter)
        Me.Controls.Add(Me.cboEnableKeySubmit)
        Me.Controls.Add(Me.lbLanguage2)
        Me.Controls.Add(Me.tbLanguage2)
        Me.Controls.Add(Me.lbLanguage1)
        Me.Controls.Add(Me.tbLanguage1)
        Me.Controls.Add(Me.btSaveToCSV)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = " VL Vokabeleingabe"
        Me.cmsLvVocabulary.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btSaveToCSV As Button
    Friend WithEvents tbLanguage1 As TextBox
    Friend WithEvents lbLanguage1 As Label
    Friend WithEvents tbLanguage2 As TextBox
    Friend WithEvents lbLanguage2 As Label
    Friend WithEvents cbLanguage1 As ComboBox
    Friend WithEvents cbLanguage2 As ComboBox
    Friend WithEvents cboEnableKeySubmit As CheckBox
    Friend WithEvents btEnter As Button
    Friend WithEvents lvVocabulary As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents cmsLvVocabulary As ContextMenuStrip
    Friend WithEvents AusgewählteVokabelnLöschenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveFileDialog As SaveFileDialog
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents btLoadFromCSV As Button
    Friend WithEvents OpenFileDialog As OpenFileDialog
    Friend WithEvents btHint1 As Button
    Friend WithEvents btHint2 As Button
End Class
