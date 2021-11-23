Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Me.Load
        TBDataDir.Text = odczytajRejestr("DataDir")
        TBInstallDIr.Text = odczytajRejestr("InstallDir")
        TBCLSPath.Text = odczytajRejestr("ClsPath")
        CheckAllAnalysers()
        CBLAnalysers.SetItemChecked(0, True)
        CBLTools.SetItemChecked(0, True)
        Dim RadbendExePath As String = TBInstallDIr.Text & "\TclTk\Bin\RadbendCNC.exe"

        If My.Computer.FileSystem.FileExists(RadbendExePath) Then
            ' MsgBox("File found.")
            ' MsgBox("Radbend is installed")
            '  

        Else
            MsgBox("Radbend is not installed. Closing")
            Me.Close()
        End If

    End Sub

    Function odczytajRejestr(ByVal rejestr As String) As String
        Dim wersja = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\WOW6432Node\Radan\RadbendCNC", "Current Version", Nothing)
        ' MsgBox("The value is " & readValue)
        Dim cls = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\WOW6432Node\Radan\RadbendCNC\" & wersja, rejestr, Nothing)
        Dim Folder_Path As String = cls
        Folder_Path.Replace("/", "\")
        Return Folder_Path
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnChangeDataDir.Click

        Try
            ChooseFolder()
            Dim wersja = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\WOW6432Node\Radan\RadbendCNC", "Current Version", Nothing)
            Dim autoshell = My.Computer.Registry.LocalMachine.OpenSubKey("SOFTWARE\WOW6432Node\Radan\RadbendCNC\" & wersja, True)
            autoshell.SetValue("DataDir", TBDataDir.Text)
            autoshell.Close()
        Catch ex As Exception
            MsgBox("Warning. This function works only in administrator mode")
        End Try


    End Sub

    Public Sub ChooseFolder()
        FolderBrowserDialog1.Description = "Wybierz katalog Dat.."
        FolderBrowserDialog1.SelectedPath = "C:\Radan Software\Radbend"
        If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then
            TBDataDir.Text = FolderBrowserDialog1.SelectedPath
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles BtnOpenDataDir.Click
        Process.Start(odczytajRejestr("DataDir"))
    End Sub

    Private Sub ButtonOtworzInstallDir_Click(sender As Object, e As EventArgs) Handles BtnOpenInstallDir.Click
        Process.Start(odczytajRejestr("InstallDir"))
    End Sub

    Private Sub ButtonOtworzCLSPath_Click(sender As Object, e As EventArgs) Handles BtnOpenCLSPath.Click
        Process.Start(odczytajRejestr("ClsPath"))
    End Sub


    Private Sub UruchomZInstallDir(ByVal sciezka As String)
        Dim sciezka2 As String = odczytajRejestr("InstallDir") & "\TclTk\Bin\" & sciezka
        ' MsgBox(sciezka2)
        Process.Start(sciezka2)
    End Sub

    Private Sub CheckAllAnalysers()
        CheckIfFileExist("DelemAnalyse.exe")
        CheckIfFileExist("AmadaAnalyse.exe")
        CheckIfFileExist("CybelecAnalyse.exe")
        CheckIfFileExist("kvaraAnalyse.exe")
        CheckIfFileExist("kebaAnalyse.exe")
        CheckIfFileExist("amncAnalyse.exe")
        CheckIfFileExist("bystronicAnalyse.exe")
        CheckIfFileExist("cincinnatiAnalyse.exe")
        CheckIfFileExist("infiniAnalyse.exe")
        CheckIfFileExist("lvdAnalyse.exe")
        CheckIfFileExist("lvdTouchAnalyse.exe")
        CheckIfFileExist("safanTSAnalyse.exe")
        CheckIfFileExist("safanECAnalyse.exe")
        CheckIfFileExist("hacoAnalyse.exe")
        CheckIfFileExist("byvisionAnalyse.exe")
        CheckIfFileExist("coastOneAnalyse.exe")
        CheckIfFileExist("task84Analyse.exe")
    End Sub

    Private Sub CheckAndCopyAllAnalysers()
        CheckIfFileExistAndCopy("DelemAnalyse.exe")
        CheckIfFileExistAndCopy("AmadaAnalyse.exe")
        CheckIfFileExistAndCopy("CybelecAnalyse.exe")
        CheckIfFileExistAndCopy("kvaraAnalyse.exe")
        CheckIfFileExistAndCopy("kebaAnalyse.exe")
        CheckIfFileExistAndCopy("amncAnalyse.exe")
        CheckIfFileExistAndCopy("bystronicAnalyse.exe")
        CheckIfFileExistAndCopy("cincinnatiAnalyse.exe")
        CheckIfFileExistAndCopy("infiniAnalyse.exe")
        CheckIfFileExistAndCopy("lvdAnalyse.exe")
        CheckIfFileExistAndCopy("lvdTouchAnalyse.exe")
        CheckIfFileExistAndCopy("safanTSAnalyse.exe")
        CheckIfFileExistAndCopy("safanECAnalyse.exe")
        CheckIfFileExistAndCopy("hacoAnalyse.exe")
        CheckIfFileExistAndCopy("byvisionAnalyse.exe")
        CheckIfFileExistAndCopy("coastOneAnalyse.exe")
        CheckIfFileExistAndCopy("task84Analyse.exe")
    End Sub


    Private Sub CheckIfFileExist(ByVal Analyser As String)
        Dim SemiPath As String = odczytajRejestr("InstallDir") & "\TclTk\Bin\"
        Dim Fullpath As String = SemiPath & Analyser
        If My.Computer.FileSystem.FileExists(Fullpath) Then
            ' MsgBox("File found.")
            CBLAnalysers.Items.Add(Analyser)
        Else
            'CheckedListBox2.Items.Add(Analyser)
            ' My.Computer.FileSystem.CopyFile(SemiPath & "geometryUtil.exe", Fullpath, CBool(1))
            '    MsgBox("File not found. " & FilePath & Analyser)
        End If
    End Sub

    Private Sub CheckIfFileExistAndCopy(ByVal Analyser As String)
        Dim SemiPath As String = odczytajRejestr("InstallDir") & "\TclTk\Bin\"
        Dim Fullpath As String = SemiPath & Analyser
        If My.Computer.FileSystem.FileExists(Fullpath) Then
            ' MsgBox("File found.")

        Else
            CBLAnalysers.Items.Add(Analyser)
            ' CheckedListBox2.Items.Add(Analyser)
            My.Computer.FileSystem.CopyFile(SemiPath & "geometryUtil.exe", Fullpath, CBool(1))
            '    MsgBox("File not found. " & FilePath & Analyser)
        End If
    End Sub

    Private Sub CHKListsolutions_MouseClick(sender As Object, e As MouseEventArgs) Handles CBLAnalysers.MouseClick
        Dim idx, sidx As Integer
        sidx = CBLAnalysers.SelectedIndex
        For idx = 0 To CBLAnalysers.Items.Count - 1
            If idx <> sidx Then
                CBLAnalysers.SetItemChecked(idx, False)
            Else
                CBLAnalysers.SetItemChecked(sidx, True)


            End If
        Next
    End Sub

    Private Sub CHKListsolutions2_MouseClick(sender As Object, e As MouseEventArgs) Handles CBLTools.MouseClick
        Dim idx, sidx As Integer
        sidx = CBLTools.SelectedIndex
        For idx = 0 To CBLTools.Items.Count - 1
            If idx <> sidx Then
                CBLTools.SetItemChecked(idx, False)
            Else
                CBLTools.SetItemChecked(sidx, True)
            End If
        Next
    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles BtnAddRestAnalysers.Click
        Try
            CheckAndCopyAllAnalysers()
        Catch ex As Exception
            MsgBox("Warning. This function works only in administrator mode")
        End Try

        '  Dim SemiPath As String = odczytajRejestr("InstallDir") & "\TclTk\Bin\"
        ' For idx = 0 To CheckedListBox1.Items.Count - 1
        'Dim Fullpath As String = SemiPath & CheckedListBox2.SelectedItem.ToString
        '  MsgBox(Fullpath)
        '     My.Computer.FileSystem.CopyFile(SemiPath & "geometryUtil.exe", Fullpath, CBool(1))
        '    Next
        ' CheckAllAnalysers()
    End Sub

    Private Sub BtnAnalyser_Click_1(sender As Object, e As EventArgs) Handles BtnAnalyser.Click
        If CBLAnalysers.CheckedItems.Count < 1 Then
            MsgBox("You must check the Analyser from the list.")
            Return
        End If

        UruchomZInstallDir(CBLAnalysers.CheckedItems(0))

    End Sub

    Private Sub BtnRunRadbend_Click(sender As Object, e As EventArgs) Handles BtnRunRadbend.Click
        UruchomZInstallDir("RadbendCNC.exe")
    End Sub

    Private Sub BtnGeometryUtility_Click(sender As Object, e As EventArgs) Handles btnGeometryUtility.Click
        UruchomZInstallDir("geometryUtil.exe")
    End Sub

    Private Sub BtnSmbViewer_Click(sender As Object, e As EventArgs) Handles BtnSmbViewer.Click
        UruchomZInstallDir("SmbViewer.exe")
    End Sub

    Private Sub BtnLicenceManager_Click(sender As Object, e As EventArgs) Handles BtnLicenceManager.Click
        Dim sciezka As String = odczytajRejestr("ClsPath") & "\licenses.exe"
        'MsgBox(sciezka)
        Process.Start(sciezka)
    End Sub

    Private Sub BtnToolLibrary_Click(sender As Object, e As EventArgs) Handles BtnToolLibrary.Click
        UruchomZInstallDir("databaseUtil.exe")
    End Sub

    Private Sub BtnCadConnection_Click(sender As Object, e As EventArgs) Handles BtnCadConnection.Click
        UruchomZInstallDir("CadConnection.exe")
    End Sub



    Private Sub BtnRunTool_Click_3(sender As Object, e As EventArgs) Handles BtnRunTool.Click
        If CBLTools.CheckedItems.Count < 1 Then
            MsgBox("You must check the Tool from the list.")
            Return
        End If

        UruchomZInstallDir(CBLTools.CheckedItems(0))
    End Sub


End Class
