Imports System.IO
Imports Microsoft.Office.Interop
Imports System.Threading
Imports System.Globalization


'Imports Microsoft.Office.Interop.Word
'Imports Microsoft.Office.Interop.Excel




Public Class frmXML
    Inherits System.Windows.Forms.Form

    Dim stringsToCompare As Array

    Protected Function killProcessByName(ByVal prName As String) As Boolean
        Try
            For Each prcess As Process In Process.GetProcessesByName(prName)
                'prcess.Close()
                'prcess.WaitForExit(1000)
                prcess.Kill()

            Next
            Return True
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
            Return False
        End Try

    End Function

    Protected Function convertWordDocToTxtInTempFolder(ByVal docFilePath As String) As String
        Try

            Dim tmpFolderPath As String = System.IO.Path.GetTempPath

            Dim wApp = New Word.Application
            Dim wDoc = wApp.Documents.Open([FileName]:=docFilePath, [ReadOnly]:=True)

            'Dim txtFilePath As String = tmpFolderPath & wDoc.Name.ToString & ".txt"
            Dim txtFilePath As String = tmpFolderPath & Path.GetFileNameWithoutExtension(docFilePath) & "__" & getateTimeToString() & ".txt"
            Path.GetFileNameWithoutExtension(docFilePath)

            wDoc.SaveAs(txtFilePath, Word.WdSaveFormat.wdFormatUnicodeText)

            wDoc.Close()
            wApp.Quit()


            Return txtFilePath

        Catch ex As Exception
            MsgBox(ex.Message.ToString & vbCrLf & "File: " & docFilePath)
            Return Nothing
        End Try

    End Function 'convertWordDocToTxtInTempFolder


    ''' '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ''' ''' '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Public Sub GetFilesToTheList(ByVal path As String)
        If File.Exists(path) Then
            ' This path is a file
            ProcessFile(path)
        ElseIf Directory.Exists(path) Then
            ' This path is a directory
            ProcessDirectory(path)
        End If
    End Sub  ' logic to get files in folder here.

    Public Sub ProcessFile(ByVal path As String) ' Processing logic is here
        If path.EndsWith(".doc") Or path.EndsWith(".docx") Or path.EndsWith(".rtf") Or path.EndsWith(".txt") Then
            clbFilesToCheck.Items.Add(path)
        End If
        'MsgBox(convertWordDocToTxtInTempFolder(path))
    End Sub ' Insert logic for processing found files here.

    Public Sub ProcessDirectory(ByVal targetDirectory As String)
        ' Process the list of files found in the directory.
        Dim fileEntries As String() = Directory.GetFiles(targetDirectory)
        For Each fileName As String In fileEntries
            ProcessFile(fileName)
        Next

        ' Recurse into subdirectories of this directory.
        Dim subdirectoryEntries As String() = Directory.GetDirectories(targetDirectory)
        For Each subdirectory As String In subdirectoryEntries
            ProcessDirectory(subdirectory)
        Next
    End Sub ' Process all files in the directory passed in, recurse on any directories that are found, and process the files they contain.
    ''' '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ''' ''' '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub
    Friend WithEvents tabctrl As System.Windows.Forms.TabControl
    Friend WithEvents tabReport As System.Windows.Forms.TabPage
    Friend WithEvents btnUncheckAll As System.Windows.Forms.Button
    Friend WithEvents btnCheckAll As System.Windows.Forms.Button
    Friend WithEvents lblFilesCountMsg As System.Windows.Forms.Label
    Friend WithEvents lblCountFilesInFolder As System.Windows.Forms.Label
    Friend WithEvents btnViewFile As System.Windows.Forms.Button
    Friend WithEvents btnRun As System.Windows.Forms.Button
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents lblFilePath As System.Windows.Forms.Label
    Friend WithEvents txtFilePath As System.Windows.Forms.TextBox
    Friend WithEvents btnSelectFile As System.Windows.Forms.Button
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents txtFolderPath As System.Windows.Forms.TextBox
    Friend WithEvents lblDirPath As System.Windows.Forms.Label
    Friend WithEvents tabMain As System.Windows.Forms.TabPage
    Friend WithEvents lvFilesCompareResult As System.Windows.Forms.ListView
    Friend WithEvents clnFilePath As System.Windows.Forms.ColumnHeader
    Friend WithEvents clnContentMatch As System.Windows.Forms.ColumnHeader
    Friend WithEvents clnSimilarity As System.Windows.Forms.ColumnHeader
    Friend WithEvents clbFilesToCheck As System.Windows.Forms.CheckedListBox
    Friend WithEvents btnExportToExcel As System.Windows.Forms.Button
    Friend WithEvents btnSaveAsText As System.Windows.Forms.Button
    Friend WithEvents btnViewMainFile As System.Windows.Forms.Button
    Friend WithEvents lblScanStatus As System.Windows.Forms.Label
    Friend WithEvents pb As System.Windows.Forms.ProgressBar
    Friend WithEvents lblCurrentScanFile As System.Windows.Forms.Label
    Friend WithEvents txtSeparator As System.Windows.Forms.TextBox
    Friend WithEvents lblOptSeparator As System.Windows.Forms.Label
    Friend WithEvents lblPtSimilarity As System.Windows.Forms.Label
    Friend WithEvents txtSmilarityPt As System.Windows.Forms.TextBox

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    'Friend WithEvents btnSinc As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmXML))
        Me.tabctrl = New System.Windows.Forms.TabControl()
        Me.tabMain = New System.Windows.Forms.TabPage()
        Me.txtSmilarityPt = New System.Windows.Forms.TextBox()
        Me.lblPtSimilarity = New System.Windows.Forms.Label()
        Me.lblOptSeparator = New System.Windows.Forms.Label()
        Me.txtSeparator = New System.Windows.Forms.TextBox()
        Me.btnViewMainFile = New System.Windows.Forms.Button()
        Me.btnSaveAsText = New System.Windows.Forms.Button()
        Me.lblFilePath = New System.Windows.Forms.Label()
        Me.btnUncheckAll = New System.Windows.Forms.Button()
        Me.btnCheckAll = New System.Windows.Forms.Button()
        Me.lblFilesCountMsg = New System.Windows.Forms.Label()
        Me.lblCountFilesInFolder = New System.Windows.Forms.Label()
        Me.btnViewFile = New System.Windows.Forms.Button()
        Me.btnRun = New System.Windows.Forms.Button()
        Me.txtFilePath = New System.Windows.Forms.TextBox()
        Me.btnSelectFile = New System.Windows.Forms.Button()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.txtFolderPath = New System.Windows.Forms.TextBox()
        Me.lblDirPath = New System.Windows.Forms.Label()
        Me.clbFilesToCheck = New System.Windows.Forms.CheckedListBox()
        Me.tabReport = New System.Windows.Forms.TabPage()
        Me.lblCurrentScanFile = New System.Windows.Forms.Label()
        Me.lblScanStatus = New System.Windows.Forms.Label()
        Me.pb = New System.Windows.Forms.ProgressBar()
        Me.btnExportToExcel = New System.Windows.Forms.Button()
        Me.lvFilesCompareResult = New System.Windows.Forms.ListView()
        Me.clnFilePath = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clnContentMatch = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clnSimilarity = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.tabctrl.SuspendLayout()
        Me.tabMain.SuspendLayout()
        Me.tabReport.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabctrl
        '
        Me.tabctrl.Controls.Add(Me.tabMain)
        Me.tabctrl.Controls.Add(Me.tabReport)
        resources.ApplyResources(Me.tabctrl, "tabctrl")
        Me.tabctrl.Name = "tabctrl"
        Me.tabctrl.SelectedIndex = 0
        Me.tabctrl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        '
        'tabMain
        '
        Me.tabMain.BackColor = System.Drawing.Color.SlateGray
        Me.tabMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.tabMain.Controls.Add(Me.txtSmilarityPt)
        Me.tabMain.Controls.Add(Me.lblPtSimilarity)
        Me.tabMain.Controls.Add(Me.lblOptSeparator)
        Me.tabMain.Controls.Add(Me.txtSeparator)
        Me.tabMain.Controls.Add(Me.btnViewMainFile)
        Me.tabMain.Controls.Add(Me.btnSaveAsText)
        Me.tabMain.Controls.Add(Me.lblFilePath)
        Me.tabMain.Controls.Add(Me.btnUncheckAll)
        Me.tabMain.Controls.Add(Me.btnCheckAll)
        Me.tabMain.Controls.Add(Me.lblFilesCountMsg)
        Me.tabMain.Controls.Add(Me.lblCountFilesInFolder)
        Me.tabMain.Controls.Add(Me.btnViewFile)
        Me.tabMain.Controls.Add(Me.btnRun)
        Me.tabMain.Controls.Add(Me.txtFilePath)
        Me.tabMain.Controls.Add(Me.btnSelectFile)
        Me.tabMain.Controls.Add(Me.btnBrowse)
        Me.tabMain.Controls.Add(Me.txtFolderPath)
        Me.tabMain.Controls.Add(Me.lblDirPath)
        Me.tabMain.Controls.Add(Me.clbFilesToCheck)
        resources.ApplyResources(Me.tabMain, "tabMain")
        Me.tabMain.Name = "tabMain"
        '
        'txtSmilarityPt
        '
        resources.ApplyResources(Me.txtSmilarityPt, "txtSmilarityPt")
        Me.txtSmilarityPt.Name = "txtSmilarityPt"
        '
        'lblPtSimilarity
        '
        resources.ApplyResources(Me.lblPtSimilarity, "lblPtSimilarity")
        Me.lblPtSimilarity.ForeColor = System.Drawing.Color.White
        Me.lblPtSimilarity.Name = "lblPtSimilarity"
        '
        'lblOptSeparator
        '
        resources.ApplyResources(Me.lblOptSeparator, "lblOptSeparator")
        Me.lblOptSeparator.ForeColor = System.Drawing.Color.White
        Me.lblOptSeparator.Name = "lblOptSeparator"
        '
        'txtSeparator
        '
        Me.txtSeparator.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        resources.ApplyResources(Me.txtSeparator, "txtSeparator")
        Me.txtSeparator.Name = "txtSeparator"
        '
        'btnViewMainFile
        '
        resources.ApplyResources(Me.btnViewMainFile, "btnViewMainFile")
        Me.btnViewMainFile.ForeColor = System.Drawing.Color.Black
        Me.btnViewMainFile.Name = "btnViewMainFile"
        '
        'btnSaveAsText
        '
        resources.ApplyResources(Me.btnSaveAsText, "btnSaveAsText")
        Me.btnSaveAsText.ForeColor = System.Drawing.Color.Black
        Me.btnSaveAsText.Name = "btnSaveAsText"
        '
        'lblFilePath
        '
        resources.ApplyResources(Me.lblFilePath, "lblFilePath")
        Me.lblFilePath.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblFilePath.Name = "lblFilePath"
        '
        'btnUncheckAll
        '
        resources.ApplyResources(Me.btnUncheckAll, "btnUncheckAll")
        Me.btnUncheckAll.ForeColor = System.Drawing.Color.Black
        Me.btnUncheckAll.Name = "btnUncheckAll"
        '
        'btnCheckAll
        '
        resources.ApplyResources(Me.btnCheckAll, "btnCheckAll")
        Me.btnCheckAll.ForeColor = System.Drawing.Color.Black
        Me.btnCheckAll.Name = "btnCheckAll"
        '
        'lblFilesCountMsg
        '
        resources.ApplyResources(Me.lblFilesCountMsg, "lblFilesCountMsg")
        Me.lblFilesCountMsg.ForeColor = System.Drawing.Color.White
        Me.lblFilesCountMsg.Name = "lblFilesCountMsg"
        '
        'lblCountFilesInFolder
        '
        resources.ApplyResources(Me.lblCountFilesInFolder, "lblCountFilesInFolder")
        Me.lblCountFilesInFolder.ForeColor = System.Drawing.Color.White
        Me.lblCountFilesInFolder.Name = "lblCountFilesInFolder"
        '
        'btnViewFile
        '
        resources.ApplyResources(Me.btnViewFile, "btnViewFile")
        Me.btnViewFile.ForeColor = System.Drawing.Color.Black
        Me.btnViewFile.Name = "btnViewFile"
        '
        'btnRun
        '
        Me.btnRun.BackColor = System.Drawing.Color.Yellow
        Me.btnRun.ForeColor = System.Drawing.Color.Black
        resources.ApplyResources(Me.btnRun, "btnRun")
        Me.btnRun.Name = "btnRun"
        Me.btnRun.UseVisualStyleBackColor = False
        '
        'txtFilePath
        '
        Me.txtFilePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        resources.ApplyResources(Me.txtFilePath, "txtFilePath")
        Me.txtFilePath.Name = "txtFilePath"
        Me.txtFilePath.ReadOnly = True
        '
        'btnSelectFile
        '
        resources.ApplyResources(Me.btnSelectFile, "btnSelectFile")
        Me.btnSelectFile.BackColor = System.Drawing.SystemColors.Control
        Me.btnSelectFile.ForeColor = System.Drawing.Color.Black
        Me.btnSelectFile.Name = "btnSelectFile"
        Me.btnSelectFile.UseVisualStyleBackColor = False
        '
        'btnBrowse
        '
        resources.ApplyResources(Me.btnBrowse, "btnBrowse")
        Me.btnBrowse.BackColor = System.Drawing.SystemColors.Control
        Me.btnBrowse.ForeColor = System.Drawing.Color.Black
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.UseVisualStyleBackColor = False
        '
        'txtFolderPath
        '
        Me.txtFolderPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        resources.ApplyResources(Me.txtFolderPath, "txtFolderPath")
        Me.txtFolderPath.Name = "txtFolderPath"
        Me.txtFolderPath.ReadOnly = True
        '
        'lblDirPath
        '
        resources.ApplyResources(Me.lblDirPath, "lblDirPath")
        Me.lblDirPath.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblDirPath.Name = "lblDirPath"
        '
        'clbFilesToCheck
        '
        Me.clbFilesToCheck.FormattingEnabled = True
        resources.ApplyResources(Me.clbFilesToCheck, "clbFilesToCheck")
        Me.clbFilesToCheck.Name = "clbFilesToCheck"
        '
        'tabReport
        '
        Me.tabReport.BackColor = System.Drawing.Color.SlateGray
        Me.tabReport.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.tabReport.Controls.Add(Me.lblCurrentScanFile)
        Me.tabReport.Controls.Add(Me.lblScanStatus)
        Me.tabReport.Controls.Add(Me.pb)
        Me.tabReport.Controls.Add(Me.btnExportToExcel)
        Me.tabReport.Controls.Add(Me.lvFilesCompareResult)
        resources.ApplyResources(Me.tabReport, "tabReport")
        Me.tabReport.Name = "tabReport"
        '
        'lblCurrentScanFile
        '
        resources.ApplyResources(Me.lblCurrentScanFile, "lblCurrentScanFile")
        Me.lblCurrentScanFile.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblCurrentScanFile.Name = "lblCurrentScanFile"
        '
        'lblScanStatus
        '
        resources.ApplyResources(Me.lblScanStatus, "lblScanStatus")
        Me.lblScanStatus.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblScanStatus.Name = "lblScanStatus"
        '
        'pb
        '
        Me.pb.ForeColor = System.Drawing.Color.Yellow
        resources.ApplyResources(Me.pb, "pb")
        Me.pb.Minimum = 1
        Me.pb.Name = "pb"
        Me.pb.Step = 1
        Me.pb.Value = 1
        '
        'btnExportToExcel
        '
        resources.ApplyResources(Me.btnExportToExcel, "btnExportToExcel")
        Me.btnExportToExcel.ForeColor = System.Drawing.Color.Black
        Me.btnExportToExcel.Name = "btnExportToExcel"
        '
        'lvFilesCompareResult
        '
        Me.lvFilesCompareResult.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.clnFilePath, Me.clnContentMatch, Me.clnSimilarity})
        resources.ApplyResources(Me.lvFilesCompareResult, "lvFilesCompareResult")
        Me.lvFilesCompareResult.MultiSelect = False
        Me.lvFilesCompareResult.Name = "lvFilesCompareResult"
        Me.lvFilesCompareResult.UseCompatibleStateImageBehavior = False
        Me.lvFilesCompareResult.View = System.Windows.Forms.View.Details
        '
        'clnFilePath
        '
        resources.ApplyResources(Me.clnFilePath, "clnFilePath")
        '
        'clnContentMatch
        '
        resources.ApplyResources(Me.clnContentMatch, "clnContentMatch")
        '
        'clnSimilarity
        '
        resources.ApplyResources(Me.clnSimilarity, "clnSimilarity")
        '
        'FolderBrowserDialog1
        '
        resources.ApplyResources(Me.FolderBrowserDialog1, "FolderBrowserDialog1")
        Me.FolderBrowserDialog1.ShowNewFolderButton = False
        '
        'frmXML
        '
        resources.ApplyResources(Me, "$this")
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.Controls.Add(Me.tabctrl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmXML"
        Me.tabctrl.ResumeLayout(False)
        Me.tabMain.ResumeLayout(False)
        Me.tabMain.PerformLayout()
        Me.tabReport.ResumeLayout(False)
        Me.tabReport.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region
    ':::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
    'Feb 15, 2012
    'Description: Recursive Function for getting duplicate content files 
    'Author:Oleksandr Maksiuta

    'This code is distributed in the hope that it will be useful.
    'Feel free to use it, just leave these comment lines.

    'Thanks to all those people that share their knowledge on internet !
    ':::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::

    Protected Function getMatchCountViaSearchOfArrayItemsInText(ByVal searchIteams As Array, _
                                                           ByVal Text As String) As Integer
        Dim matchCount As Integer = 0
        Try
            Dim searchString As String
            Text = Text.ToUpper.Replace(Space(1), "").Replace(vbCrLf, "")

            For i As Integer = 0 To searchIteams.Length - 1
                searchString = searchIteams(i).Replace(Space(1), "").Replace(vbCrLf, "")

                If Text.Contains(searchString.ToUpper) = True Then
                    matchCount = matchCount + 1
                End If
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return matchCount
    End Function 'getMatchCountViaSearchOfArrayItemsInText

    Protected Function exportListViewToExcelFile(ByVal filename As String, ByVal lv As ListView) As Boolean
        Try
            Thread.CurrentThread.CurrentCulture = New CultureInfo("en-US") 'For Localization

            Dim xlsApp As Excel.Application
            Dim xlsWbook As Excel.Workbook
            Dim xlsWSheet As Excel.Worksheet
            Dim misValue As Object = System.Reflection.Missing.Value

            xlsApp = New Excel.ApplicationClass
            xlsWbook = xlsApp.Workbooks.Add(misValue)
            'xlsWSheet = xlsWbook.Sheets("sheet111")
            xlsWSheet = DirectCast(xlsApp.ActiveSheet, Excel.Worksheet)

            Dim i As Integer = 1

            Dim j As Integer = 1
            Dim jj As Integer = lv.Columns.Count

            For rr As Integer = 0 To lv.Columns.Count - 1
                xlsWSheet.Cells(i, j) = lv.Columns(rr).Text
                j = j + 1
            Next
            i = 2
            j = 1
            For Each comp As ListViewItem In lv.Items
                xlsWSheet.Cells(i, j) = comp.Text.ToString()
                For Each drv As ListViewItem.ListViewSubItem In comp.SubItems
                    xlsWSheet.Cells(i, j) = drv.Text.ToString()
                    j += 1
                Next
                j = 1
                i += 1
            Next

            xlsApp.Visible = True
            xlsWSheet.SaveAs(filename)
            'wb.Close() 
            'xla.Quit() 

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        End Try
        Return True
    End Function

    Protected Function exportCheckedListBoxToTextFile(ByVal filename As String, ByVal clb As CheckedListBox) As Boolean
        Try
            ' Open output file 
            Dim sWriter As New StreamWriter(filename)

            sWriter.WriteLine("Files to validate: " & lblCountFilesInFolder.Text)
            sWriter.WriteLine()

            ' Write records 
            For i As Integer = 0 To clb.Items.Count - 1

                sWriter.Write(clb.Items(i).ToString)
                sWriter.WriteLine()

            Next
            sWriter.Close()

            Dim pr As New Process
            pr.StartInfo.FileName = filename
            pr.StartInfo.WindowStyle = ProcessWindowStyle.Maximized
            pr.Start()



        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
        Return True
    End Function 'exportListViewToTextFile

    Protected Function getateTimeToString() As String
        Return Date.Now.ToString.Replace(Space(1), "").Replace(":", "").Replace(",", "").Replace(".", "").Replace("\", "").Replace("/", "").Replace("|", "").Replace("~", "").Replace("?", "").Replace("+", "").Replace("=", "")
    End Function 'getateTimeToString

    Protected Function excludeFiles(ByVal sMainFileText As String) As Boolean
        Dim aWords(2) As String
        aWords(0) = "finalzla61himash"
        aWords(1) = "automoftechprocc"
        aWords(2) = "diplnontaucheverall"
        sMainFileText = sMainFileText.ToUpper.Replace(Space(1), "").Replace(vbCrLf, "")

        For Each s As String In aWords
            If sMainFileText.Contains(s.ToUpper) Then
                Return True

            End If
        Next
        Return False
    End Function



    Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click
        If FolderBrowserDialog1.ShowDialog = DialogResult.OK Then
            txtFolderPath.Text = FolderBrowserDialog1.SelectedPath

            'Show all available files files by extention
            Dim serachFolderPath As String = txtFolderPath.Text
            If serachFolderPath.Trim.Length > 0 Then
                clbFilesToCheck.Items.Clear()
                GetFilesToTheList(txtFolderPath.Text)
                lblCountFilesInFolder.Text = clbFilesToCheck.Items.Count
            Else
                MsgBox("Select Folder with files to compare")
            End If
        End If

    End Sub


    Dim arrayOfRowsFromMainFile As Array

    Private Sub btnRun_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRun.Click
        Thread.CurrentThread.CurrentCulture = New CultureInfo("ru-RU")

        If txtFilePath.Text.ToString.Length > 0 And txtFolderPath.Text.ToString.Length > 0 Then '// check if OK was pressed. 
            If clbFilesToCheck.CheckedItems.Count > 0 Then
                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''' 
                'Get file text of main file 
                killProcessByName("WINWORD")
                Dim mainFileToRead As String = convertWordDocToTxtInTempFolder(txtFilePath.Text.ToString)

                If mainFileToRead Is Nothing Then
                    MsgBox("Please check Main file. Scan is aborted!")
                Else
                    'Prepare Result view
                    lvFilesCompareResult.Items.Clear()
                    lblCurrentScanFile.Text = ""
                    lblCurrentScanFile.Refresh()
                    tabctrl.SelectedTab = tabReport
                    tabctrl.SelectedTab.Refresh()
                    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                    Dim sReaderMain As StreamReader = File.OpenText(mainFileToRead)
                    Dim contentOfMainFile As String = sReaderMain.ReadToEnd()
                    sReaderMain.DiscardBufferedData()
                    sReaderMain.Dispose()
                    sReaderMain.Close()
                    'Delete converted file from temp folder
                    Dim mainFileToDelete As String = mainFileToRead
                    If System.IO.File.Exists(mainFileToDelete) = True Then
                        System.IO.File.Delete(mainFileToRead)
                    End If
                    killProcessByName("WINWORD")
                    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''' 
                    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''' 
                    Dim compareFile As String
                    Dim compareFileFormated As String
                    Dim contentFromCompareFile As String

                    Dim lengthOfMainFile As Integer
                    Dim lengthOfCompareFile As Integer

                    Dim textdelimiter As String = txtSeparator.Text.ToString '"."

                    Dim matching As Decimal
                    Dim similarity As Decimal

                    Dim sReaderCompare As StreamReader


                    'Progress bar parameters

                    Dim pbMin As Integer = 0
                    Dim pbMax As Integer = clbFilesToCheck.Items.Count
                    pb.Maximum = pbMax
                    For i As Integer = pbMin To pbMax - 1
                        ' System.Threading.Thread.Sleep(200)
                        If clbFilesToCheck.GetItemCheckState(i) = CheckState.Checked Then

                            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''' 
                            'Get file text from file to compare 
                            compareFile = clbFilesToCheck.Items(i).ToString
                            lblCurrentScanFile.Text = compareFile
                            lblCurrentScanFile.Refresh()

                            compareFileFormated = convertWordDocToTxtInTempFolder(compareFile)

                            sReaderCompare = File.OpenText(compareFileFormated)
                            contentFromCompareFile = sReaderCompare.ReadToEnd
                            sReaderCompare.DiscardBufferedData()
                            sReaderCompare.Dispose()
                            sReaderCompare.Close()
                            'Delete converted file from temp folder
                            Dim compareFileToDelete As String = compareFileFormated
                            If System.IO.File.Exists(compareFileFormated) = True Then
                                System.IO.File.Delete(compareFileFormated)
                            End If
                            killProcessByName("WINWORD")
                            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''' 

                            'Get length of main file and file to compare 
                            lengthOfMainFile = contentOfMainFile.Length
                            lengthOfCompareFile = contentFromCompareFile.Length
                            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''' 
                            'Get % of matches where Main file is a base 
                            matching = 0
                            If lengthOfMainFile = 0 Or lengthOfCompareFile = 0 Then
                                matching = 0
                            Else
                                'Split content main file to array of rows using delimiter 
                                arrayOfRowsFromMainFile = Split(contentOfMainFile, textdelimiter)

                                Dim expectedCountOfMatches As Integer = arrayOfRowsFromMainFile.Length

                                Dim actualMatchCount As Integer = getMatchCountViaSearchOfArrayItemsInText(
                                                                arrayOfRowsFromMainFile,
                                                                contentFromCompareFile)
                                If expectedCountOfMatches > 0 Then
                                    matching = actualMatchCount / expectedCountOfMatches
                                    If matching > 1 Then
                                        matching = expectedCountOfMatches / actualMatchCount
                                    End If
                                End If

                                ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''' 
                                'CheckBox main parameters
                                If excludeFiles(contentOfMainFile) = True And excludeFiles(contentFromCompareFile) = True Then
                                ElseIf excludeFiles(contentOfMainFile) = True And matching > 0.02 Then
                                    matching = 0.01
                                ElseIf excludeFiles(contentFromCompareFile) = True And matching > 0.02 Then
                                    matching = 0.01
                                End If


                                ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''' 
                                'Calculate Similarity % where Main file is a base 
                                similarity = 0
                                If lengthOfMainFile > 0 Then
                                    similarity = lengthOfCompareFile / lengthOfMainFile
                                    If similarity > 1 Then
                                        similarity = lengthOfMainFile / lengthOfCompareFile
                                    End If
                                End If
                                similarity = matching * similarity
                                ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''' 
                                'Add result of comparison into ListView 
                                Dim lvi As New ListViewItem()
                                lvi.Text = compareFile
                                lvFilesCompareResult.Items.Add(lvi)
                                lvi.SubItems.Add(Math.Ceiling(100 * matching).ToString & " %")
                                lvi.SubItems.Add(Math.Ceiling(100 * similarity).ToString & " %")
                                'Change color of similar file as set in options 
                                Dim index As Integer = lvFilesCompareResult.Items.Count - 1

                                Dim similarityPt As Decimal = txtSmilarityPt.Text.ToString.Trim
                                If similarity > (similarityPt - 1) / 100 Then  ' 0.5 Then
                                    lvFilesCompareResult.Items(index).ForeColor = Color.Red
                                End If
                                ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''' 
                                lvFilesCompareResult.Refresh()
                            End If
                        End If
                        pb.Value = i + 1
                        pb.Refresh()
                    Next
                    lblCurrentScanFile.Text = "Scan is Finished"
                    MsgBox(lblCurrentScanFile.Text)
                End If

                'Show Export To excel
                If lvFilesCompareResult.Items.Count > 0 Then
                    btnExportToExcel.Visible = True
                    btnExportToExcel.Refresh()
                End If
            Else
                MsgBox("Check Items in the list to compare")
            End If
        Else
            MsgBox("Select Main File and Folder with files to compare")
        End If



    End Sub

    Private Sub btnSelectFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelectFile.Click
        'http://www.theukwebdesigncompany.com/articles/article.php?article=151


        Dim OpenAnswerFile As New OpenFileDialog
        OpenAnswerFile.Title = "Select Main File"
        OpenAnswerFile.Multiselect.Equals(False)
        OpenAnswerFile.DefaultExt = Nothing

        If OpenAnswerFile.ShowDialog = DialogResult.OK Then '// check if OK was pressed.



            Dim filetoread As String = OpenAnswerFile.FileName
            Dim filestream As StreamReader = File.OpenText(filetoread)
            Dim readcontents As String = filestream.ReadToEnd()
            filestream.Dispose()
            filestream.Close()

            txtFilePath.Text = filetoread

            Dim textdelimiter As String = "."

            Dim splitout As Array = Split(readcontents, textdelimiter)
            stringsToCompare = splitout



            Dim t As String = ""
            Dim mainTextLength As Integer = 0
            For i As Integer = 0 To splitout.Length - 1

                t = splitout(i)

            Next

            btnRun.Enabled = True


        End If

    End Sub


    Private Sub btnViewFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewFile.Click
        If clbFilesToCheck.SelectedIndex > 0 Then
            'Process.Start(clbFilesToCheck.SelectedItem)

            Dim pr As New Process
            pr.StartInfo.FileName = clbFilesToCheck.SelectedItem
            pr.StartInfo.WindowStyle = ProcessWindowStyle.Maximized
            pr.Start()

        Else
            MsgBox("Select file Item in above list")
        End If
    End Sub


    Private Sub btnCheckAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCheckAll.Click
        For i As Integer = 0 To clbFilesToCheck.Items.Count - 1
            clbFilesToCheck.SetItemChecked(i, True)
        Next
    End Sub

    Private Sub btnUncheckAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUncheckAll.Click
        For i As Integer = 0 To clbFilesToCheck.Items.Count - 1
            clbFilesToCheck.SetItemChecked(i, False)
        Next
    End Sub


    Private Sub btnSaveAsText_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveAsText.Click
        If clbFilesToCheck.Items.Count > 0 Then
            exportCheckedListBoxToTextFile("pfd__" & getateTimeToString() & ".txt", clbFilesToCheck)
        Else
            MsgBox("There are No files to validate in above list")
        End If
    End Sub

    Private Sub btnViewMainFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewMainFile.Click
        If txtFilePath.Text.ToString.Length > 0 Then
            Dim pr As New Process
            pr.StartInfo.FileName = txtFilePath.Text.ToString
            pr.StartInfo.WindowStyle = ProcessWindowStyle.Maximized
            pr.Start()

        Else
            MsgBox("Select Main file to validate")
        End If
    End Sub




    Private Sub btnExportToExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportToExcel.Click
        If lvFilesCompareResult.Items.Count > 0 Then
            exportListViewToExcelFile("pfd__" & getateTimeToString() & ".xls", lvFilesCompareResult)
        Else
            MsgBox("There are No files in above list")
        End If

    End Sub


End Class
