Imports System.IO
Public Class Form1
    Dim Language1 As String
    Dim Language2 As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbLanguage1.SelectedIndex = 25
        cbLanguage2.SelectedIndex = 23
    End Sub

    Private Sub cbLanguage1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbLanguage1.SelectedIndexChanged
        ChangeLanguage()
    End Sub

    Private Sub cbLanguage2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbLanguage2.SelectedIndexChanged
        ChangeLanguage()
    End Sub

    Private Sub ChangeLanguage()
        If cbLanguage1.Text <> "" And cbLanguage2.Text <> "" Then
            Language1 = cbLanguage1.Text
            Language2 = cbLanguage2.Text
            lbLanguage1.Text = Language1 & ":"
            lbLanguage2.Text = Language2 & ":"
        End If
    End Sub

    Private Sub btEnter_Click(sender As Object, e As EventArgs) Handles btEnter.Click
        Save()
    End Sub

    Private Sub Save()
        If tbLanguage1.Text <> "" And tbLanguage2.Text <> "" Then
            With lvVocabulary.Items.Add(tbLanguage1.Text)
                .SubItems.Add(Language1)
                .SubItems.Add(tbLanguage2.Text)
                .SubItems.Add(Language2)
            End With
            tbLanguage1.Text = ""
            tbLanguage2.Text = ""
            Me.tbLanguage1.Focus()
        Else
            MsgBox("Keine Eingabe!", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub tbLanguage2_KeyDown(sender As Object, e As KeyEventArgs) Handles tbLanguage2.KeyDown
        If cboEnableKeySubmit.Checked Then
            If e.KeyData = Keys.Enter Then
                Save()
            End If
        End If
    End Sub

    Private Sub tbLanguage1_KeyDown(sender As Object, e As KeyEventArgs) Handles tbLanguage1.KeyDown
        If cboEnableKeySubmit.Checked Then
            If e.KeyData = Keys.Enter Then
                Save()
            End If
        End If
    End Sub

    Private Sub AusgewählteVokabelnLöschenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AusgewählteVokabelnLöschenToolStripMenuItem.Click
        For i = 0 To lvVocabulary.SelectedItems.Count - 1
            lvVocabulary.Items.Remove(lvVocabulary.SelectedItems.Item(0))
        Next
    End Sub

    Private Sub btSaveToCSV_Click(sender As Object, e As EventArgs) Handles btSaveToCSV.Click
        SaveToCSV()
    End Sub

    Private Sub SaveToCSV()
        If SaveFileDialog.ShowDialog() = DialogResult.OK Then
            Dim FilePath As String = SaveFileDialog.FileName
            Dim Lines(lvVocabulary.Items.Count - 1) As String
            For i = 0 To lvVocabulary.Items.Count - 1
                Lines(i) = String.Format("{0}{1}{2};{3}{4}{5};{6}{7}{8};{9}{10}{11}", Chr(34), lvVocabulary.Items.Item(i).SubItems.Item(1).Text, Chr(34), Chr(34), lvVocabulary.Items.Item(i).Text, Chr(34), Chr(34), lvVocabulary.Items.Item(i).SubItems.Item(3).Text, Chr(34), Chr(34), lvVocabulary.Items.Item(i).SubItems.Item(2).Text, Chr(34))
            Next
            File.WriteAllLines(FilePath, Lines)
        End If
    End Sub

    Private Sub btLoadFromCSV_Click(sender As Object, e As EventArgs) Handles btLoadFromCSV.Click
        If OpenFileDialog.ShowDialog() = DialogResult.OK Then
            If MsgBox("Es werden alle aktuellen Eingaben gelöscht. Datei laden?", MsgBoxStyle.YesNo, "Sicher?") = MsgBoxResult.Yes Then
                Dim FilePath As String = OpenFileDialog.FileName
                Dim Lines As IEnumerable(Of String) = File.ReadLines(FilePath)

                For i = 0 To Lines.Count - 1
                    Dim Items As String() = Lines(i).Split(";")
                    With lvVocabulary.Items.Add(Items(1).Substring(1, Items(1).Length - 2))
                        .SubItems.Add(Items(0).Substring(1, Items(0).Length - 2))
                        .SubItems.Add(Items(3).Substring(1, Items(3).Length - 2))
                        .SubItems.Add(Items(2).Substring(1, Items(2).Length - 2))
                    End With
                Next

                tbLanguage1.Text = ""
                tbLanguage2.Text = ""
                Me.tbLanguage1.Focus()
            End If
        End If
    End Sub

    Private Sub btHint1_Click(sender As Object, e As EventArgs) Handles btHint1.Click
        AddHints.ShowDialog()


    End Sub
End Class
