<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.BtnOpenDataDir = New System.Windows.Forms.Button()
        Me.TBDataDir = New System.Windows.Forms.TextBox()
        Me.LblRadbendDataDir = New System.Windows.Forms.Label()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.BtnChangeDataDir = New System.Windows.Forms.Button()
        Me.TBInstallDIr = New System.Windows.Forms.TextBox()
        Me.BtnOpenInstallDir = New System.Windows.Forms.Button()
        Me.TBCLSPath = New System.Windows.Forms.TextBox()
        Me.BtnOpenCLSPath = New System.Windows.Forms.Button()
        Me.LblRadbendInstallDir = New System.Windows.Forms.Label()
        Me.LblCLSPath = New System.Windows.Forms.Label()
        Me.LblRunRadbend = New System.Windows.Forms.Label()
        Me.LblRunSelectedAnalysers = New System.Windows.Forms.Label()
        Me.LblGeometryUt = New System.Windows.Forms.Label()
        Me.LblToolLibrary = New System.Windows.Forms.Label()
        Me.LblCadConnection = New System.Windows.Forms.Label()
        Me.LblSmbViewer = New System.Windows.Forms.Label()
        Me.LblLicenseManager = New System.Windows.Forms.Label()
        Me.CBLAnalysers = New System.Windows.Forms.CheckedListBox()
        Me.LblAvailableAnalysers = New System.Windows.Forms.Label()
        Me.LblByWho = New System.Windows.Forms.Label()
        Me.BtnAddRestAnalysers = New System.Windows.Forms.Button()
        Me.PanelDirs = New System.Windows.Forms.Panel()
        Me.PanelShortcuts = New System.Windows.Forms.Panel()
        Me.BtnCadConnection = New System.Windows.Forms.Button()
        Me.BtnToolLibrary = New System.Windows.Forms.Button()
        Me.BtnRunRadbend = New System.Windows.Forms.Button()
        Me.BtnLicenceManager = New System.Windows.Forms.Button()
        Me.BtnSmbViewer = New System.Windows.Forms.Button()
        Me.btnGeometryUtility = New System.Windows.Forms.Button()
        Me.BtnAnalyser = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnRunTool = New System.Windows.Forms.Button()
        Me.LblProgs = New System.Windows.Forms.Label()
        Me.CBLTools = New System.Windows.Forms.CheckedListBox()
        Me.PanelDirs.SuspendLayout()
        Me.PanelShortcuts.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnOpenDataDir
        '
        Me.BtnOpenDataDir.Location = New System.Drawing.Point(422, 19)
        Me.BtnOpenDataDir.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnOpenDataDir.Name = "BtnOpenDataDir"
        Me.BtnOpenDataDir.Size = New System.Drawing.Size(56, 19)
        Me.BtnOpenDataDir.TabIndex = 0
        Me.BtnOpenDataDir.Text = "Open"
        Me.BtnOpenDataDir.UseVisualStyleBackColor = True
        '
        'TBDataDir
        '
        Me.TBDataDir.Location = New System.Drawing.Point(4, 30)
        Me.TBDataDir.Margin = New System.Windows.Forms.Padding(2)
        Me.TBDataDir.Name = "TBDataDir"
        Me.TBDataDir.Size = New System.Drawing.Size(400, 20)
        Me.TBDataDir.TabIndex = 1
        '
        'LblRadbendDataDir
        '
        Me.LblRadbendDataDir.AutoSize = True
        Me.LblRadbendDataDir.BackColor = System.Drawing.SystemColors.Window
        Me.LblRadbendDataDir.Location = New System.Drawing.Point(2, 8)
        Me.LblRadbendDataDir.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblRadbendDataDir.Name = "LblRadbendDataDir"
        Me.LblRadbendDataDir.Size = New System.Drawing.Size(93, 13)
        Me.LblRadbendDataDir.TabIndex = 2
        Me.LblRadbendDataDir.Text = "Radbend Data Dir"
        '
        'BtnChangeDataDir
        '
        Me.BtnChangeDataDir.Location = New System.Drawing.Point(422, 42)
        Me.BtnChangeDataDir.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnChangeDataDir.Name = "BtnChangeDataDir"
        Me.BtnChangeDataDir.Size = New System.Drawing.Size(56, 19)
        Me.BtnChangeDataDir.TabIndex = 3
        Me.BtnChangeDataDir.Text = "Change"
        Me.BtnChangeDataDir.UseVisualStyleBackColor = True
        '
        'TBInstallDIr
        '
        Me.TBInstallDIr.Location = New System.Drawing.Point(4, 85)
        Me.TBInstallDIr.Margin = New System.Windows.Forms.Padding(2)
        Me.TBInstallDIr.Name = "TBInstallDIr"
        Me.TBInstallDIr.Size = New System.Drawing.Size(400, 20)
        Me.TBInstallDIr.TabIndex = 6
        '
        'BtnOpenInstallDir
        '
        Me.BtnOpenInstallDir.Location = New System.Drawing.Point(421, 85)
        Me.BtnOpenInstallDir.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnOpenInstallDir.Name = "BtnOpenInstallDir"
        Me.BtnOpenInstallDir.Size = New System.Drawing.Size(56, 19)
        Me.BtnOpenInstallDir.TabIndex = 5
        Me.BtnOpenInstallDir.Text = "Open"
        Me.BtnOpenInstallDir.UseVisualStyleBackColor = True
        '
        'TBCLSPath
        '
        Me.TBCLSPath.Location = New System.Drawing.Point(4, 138)
        Me.TBCLSPath.Margin = New System.Windows.Forms.Padding(2)
        Me.TBCLSPath.Name = "TBCLSPath"
        Me.TBCLSPath.Size = New System.Drawing.Size(400, 20)
        Me.TBCLSPath.TabIndex = 8
        '
        'BtnOpenCLSPath
        '
        Me.BtnOpenCLSPath.Location = New System.Drawing.Point(421, 137)
        Me.BtnOpenCLSPath.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnOpenCLSPath.Name = "BtnOpenCLSPath"
        Me.BtnOpenCLSPath.Size = New System.Drawing.Size(56, 19)
        Me.BtnOpenCLSPath.TabIndex = 7
        Me.BtnOpenCLSPath.Text = "Open"
        Me.BtnOpenCLSPath.UseVisualStyleBackColor = True
        '
        'LblRadbendInstallDir
        '
        Me.LblRadbendInstallDir.AutoSize = True
        Me.LblRadbendInstallDir.BackColor = System.Drawing.SystemColors.Window
        Me.LblRadbendInstallDir.Location = New System.Drawing.Point(2, 60)
        Me.LblRadbendInstallDir.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblRadbendInstallDir.Name = "LblRadbendInstallDir"
        Me.LblRadbendInstallDir.Size = New System.Drawing.Size(97, 13)
        Me.LblRadbendInstallDir.TabIndex = 9
        Me.LblRadbendInstallDir.Text = "Radbend Install Dir"
        '
        'LblCLSPath
        '
        Me.LblCLSPath.AutoSize = True
        Me.LblCLSPath.BackColor = System.Drawing.SystemColors.Window
        Me.LblCLSPath.Location = New System.Drawing.Point(2, 115)
        Me.LblCLSPath.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblCLSPath.Name = "LblCLSPath"
        Me.LblCLSPath.Size = New System.Drawing.Size(52, 13)
        Me.LblCLSPath.TabIndex = 10
        Me.LblCLSPath.Text = "CLS Path"
        '
        'LblRunRadbend
        '
        Me.LblRunRadbend.AutoSize = True
        Me.LblRunRadbend.BackColor = System.Drawing.SystemColors.Window
        Me.LblRunRadbend.Location = New System.Drawing.Point(3, 28)
        Me.LblRunRadbend.Name = "LblRunRadbend"
        Me.LblRunRadbend.Size = New System.Drawing.Size(74, 13)
        Me.LblRunRadbend.TabIndex = 12
        Me.LblRunRadbend.Text = "Run Radbend"
        '
        'LblRunSelectedAnalysers
        '
        Me.LblRunSelectedAnalysers.AutoSize = True
        Me.LblRunSelectedAnalysers.BackColor = System.Drawing.SystemColors.Window
        Me.LblRunSelectedAnalysers.Location = New System.Drawing.Point(3, 292)
        Me.LblRunSelectedAnalysers.Name = "LblRunSelectedAnalysers"
        Me.LblRunSelectedAnalysers.Size = New System.Drawing.Size(115, 13)
        Me.LblRunSelectedAnalysers.TabIndex = 19
        Me.LblRunSelectedAnalysers.Text = "Run Selected Analyser"
        '
        'LblGeometryUt
        '
        Me.LblGeometryUt.AutoSize = True
        Me.LblGeometryUt.BackColor = System.Drawing.SystemColors.Window
        Me.LblGeometryUt.Location = New System.Drawing.Point(1, 206)
        Me.LblGeometryUt.Name = "LblGeometryUt"
        Me.LblGeometryUt.Size = New System.Drawing.Size(80, 13)
        Me.LblGeometryUt.TabIndex = 20
        Me.LblGeometryUt.Text = "Geometry Utility"
        '
        'LblToolLibrary
        '
        Me.LblToolLibrary.AutoSize = True
        Me.LblToolLibrary.BackColor = System.Drawing.SystemColors.Window
        Me.LblToolLibrary.Location = New System.Drawing.Point(8, 118)
        Me.LblToolLibrary.Name = "LblToolLibrary"
        Me.LblToolLibrary.Size = New System.Drawing.Size(62, 13)
        Me.LblToolLibrary.TabIndex = 21
        Me.LblToolLibrary.Text = "Tool Library"
        '
        'LblCadConnection
        '
        Me.LblCadConnection.AutoSize = True
        Me.LblCadConnection.BackColor = System.Drawing.SystemColors.Window
        Me.LblCadConnection.Location = New System.Drawing.Point(80, 118)
        Me.LblCadConnection.Name = "LblCadConnection"
        Me.LblCadConnection.Size = New System.Drawing.Size(83, 13)
        Me.LblCadConnection.TabIndex = 22
        Me.LblCadConnection.Text = "Cad Connection"
        '
        'LblSmbViewer
        '
        Me.LblSmbViewer.AutoSize = True
        Me.LblSmbViewer.BackColor = System.Drawing.SystemColors.Window
        Me.LblSmbViewer.Location = New System.Drawing.Point(89, 28)
        Me.LblSmbViewer.Name = "LblSmbViewer"
        Me.LblSmbViewer.Size = New System.Drawing.Size(61, 13)
        Me.LblSmbViewer.TabIndex = 23
        Me.LblSmbViewer.Text = "SmBViewer"
        '
        'LblLicenseManager
        '
        Me.LblLicenseManager.AutoSize = True
        Me.LblLicenseManager.BackColor = System.Drawing.SystemColors.Window
        Me.LblLicenseManager.Location = New System.Drawing.Point(80, 206)
        Me.LblLicenseManager.Name = "LblLicenseManager"
        Me.LblLicenseManager.Size = New System.Drawing.Size(90, 13)
        Me.LblLicenseManager.TabIndex = 24
        Me.LblLicenseManager.Text = "Licence Manager"
        '
        'CBLAnalysers
        '
        Me.CBLAnalysers.FormattingEnabled = True
        Me.CBLAnalysers.Location = New System.Drawing.Point(1, 44)
        Me.CBLAnalysers.Name = "CBLAnalysers"
        Me.CBLAnalysers.Size = New System.Drawing.Size(151, 244)
        Me.CBLAnalysers.TabIndex = 30
        '
        'LblAvailableAnalysers
        '
        Me.LblAvailableAnalysers.AutoSize = True
        Me.LblAvailableAnalysers.BackColor = System.Drawing.SystemColors.Window
        Me.LblAvailableAnalysers.Location = New System.Drawing.Point(3, 28)
        Me.LblAvailableAnalysers.Name = "LblAvailableAnalysers"
        Me.LblAvailableAnalysers.Size = New System.Drawing.Size(98, 13)
        Me.LblAvailableAnalysers.TabIndex = 31
        Me.LblAvailableAnalysers.Text = "Available Analysers"
        '
        'LblByWho
        '
        Me.LblByWho.AutoSize = True
        Me.LblByWho.BackColor = System.Drawing.SystemColors.Window
        Me.LblByWho.Location = New System.Drawing.Point(1081, 9)
        Me.LblByWho.Name = "LblByWho"
        Me.LblByWho.Size = New System.Drawing.Size(131, 13)
        Me.LblByWho.TabIndex = 33
        Me.LblByWho.Text = "By K.Paprocki Verashape "
        '
        'BtnAddRestAnalysers
        '
        Me.BtnAddRestAnalysers.Location = New System.Drawing.Point(87, 308)
        Me.BtnAddRestAnalysers.Name = "BtnAddRestAnalysers"
        Me.BtnAddRestAnalysers.Size = New System.Drawing.Size(65, 55)
        Me.BtnAddRestAnalysers.TabIndex = 35
        Me.BtnAddRestAnalysers.Text = "Add rest Analysers (admin)"
        Me.BtnAddRestAnalysers.UseVisualStyleBackColor = True
        '
        'PanelDirs
        '
        Me.PanelDirs.BackColor = System.Drawing.SystemColors.HighlightText
        Me.PanelDirs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelDirs.Controls.Add(Me.TBDataDir)
        Me.PanelDirs.Controls.Add(Me.BtnOpenDataDir)
        Me.PanelDirs.Controls.Add(Me.LblRadbendDataDir)
        Me.PanelDirs.Controls.Add(Me.BtnChangeDataDir)
        Me.PanelDirs.Controls.Add(Me.BtnOpenInstallDir)
        Me.PanelDirs.Controls.Add(Me.TBInstallDIr)
        Me.PanelDirs.Controls.Add(Me.BtnOpenCLSPath)
        Me.PanelDirs.Controls.Add(Me.TBCLSPath)
        Me.PanelDirs.Controls.Add(Me.LblRadbendInstallDir)
        Me.PanelDirs.Controls.Add(Me.LblCLSPath)
        Me.PanelDirs.Location = New System.Drawing.Point(20, 386)
        Me.PanelDirs.Name = "PanelDirs"
        Me.PanelDirs.Size = New System.Drawing.Size(535, 174)
        Me.PanelDirs.TabIndex = 36
        '
        'PanelShortcuts
        '
        Me.PanelShortcuts.BackColor = System.Drawing.SystemColors.HighlightText
        Me.PanelShortcuts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelShortcuts.Controls.Add(Me.LblLicenseManager)
        Me.PanelShortcuts.Controls.Add(Me.BtnCadConnection)
        Me.PanelShortcuts.Controls.Add(Me.BtnToolLibrary)
        Me.PanelShortcuts.Controls.Add(Me.BtnRunRadbend)
        Me.PanelShortcuts.Controls.Add(Me.BtnLicenceManager)
        Me.PanelShortcuts.Controls.Add(Me.BtnSmbViewer)
        Me.PanelShortcuts.Controls.Add(Me.btnGeometryUtility)
        Me.PanelShortcuts.Controls.Add(Me.LblGeometryUt)
        Me.PanelShortcuts.Controls.Add(Me.LblRunRadbend)
        Me.PanelShortcuts.Controls.Add(Me.LblToolLibrary)
        Me.PanelShortcuts.Controls.Add(Me.LblCadConnection)
        Me.PanelShortcuts.Controls.Add(Me.LblSmbViewer)
        Me.PanelShortcuts.Location = New System.Drawing.Point(20, 12)
        Me.PanelShortcuts.Name = "PanelShortcuts"
        Me.PanelShortcuts.Size = New System.Drawing.Size(183, 368)
        Me.PanelShortcuts.TabIndex = 37
        '
        'BtnCadConnection
        '
        Me.BtnCadConnection.Image = Global.RadbendLauncher.My.Resources.Resources.Press51
        Me.BtnCadConnection.Location = New System.Drawing.Point(92, 134)
        Me.BtnCadConnection.Name = "BtnCadConnection"
        Me.BtnCadConnection.Size = New System.Drawing.Size(55, 55)
        Me.BtnCadConnection.TabIndex = 42
        Me.BtnCadConnection.UseVisualStyleBackColor = True
        '
        'BtnToolLibrary
        '
        Me.BtnToolLibrary.Image = Global.RadbendLauncher.My.Resources.Resources.Press3
        Me.BtnToolLibrary.Location = New System.Drawing.Point(15, 134)
        Me.BtnToolLibrary.Name = "BtnToolLibrary"
        Me.BtnToolLibrary.Size = New System.Drawing.Size(55, 55)
        Me.BtnToolLibrary.TabIndex = 41
        Me.BtnToolLibrary.UseVisualStyleBackColor = True
        '
        'BtnRunRadbend
        '
        Me.BtnRunRadbend.Image = Global.RadbendLauncher.My.Resources.Resources.Press8
        Me.BtnRunRadbend.Location = New System.Drawing.Point(15, 44)
        Me.BtnRunRadbend.Name = "BtnRunRadbend"
        Me.BtnRunRadbend.Size = New System.Drawing.Size(55, 55)
        Me.BtnRunRadbend.TabIndex = 40
        Me.BtnRunRadbend.UseVisualStyleBackColor = True
        '
        'BtnLicenceManager
        '
        Me.BtnLicenceManager.Image = Global.RadbendLauncher.My.Resources.Resources.Licenses
        Me.BtnLicenceManager.Location = New System.Drawing.Point(90, 222)
        Me.BtnLicenceManager.Name = "BtnLicenceManager"
        Me.BtnLicenceManager.Size = New System.Drawing.Size(55, 55)
        Me.BtnLicenceManager.TabIndex = 39
        Me.BtnLicenceManager.UseVisualStyleBackColor = True
        '
        'BtnSmbViewer
        '
        Me.BtnSmbViewer.Image = Global.RadbendLauncher.My.Resources.Resources.SMB
        Me.BtnSmbViewer.Location = New System.Drawing.Point(92, 44)
        Me.BtnSmbViewer.Name = "BtnSmbViewer"
        Me.BtnSmbViewer.Size = New System.Drawing.Size(55, 55)
        Me.BtnSmbViewer.TabIndex = 38
        Me.BtnSmbViewer.UseVisualStyleBackColor = True
        '
        'btnGeometryUtility
        '
        Me.btnGeometryUtility.Image = Global.RadbendLauncher.My.Resources.Resources.Press
        Me.btnGeometryUtility.Location = New System.Drawing.Point(13, 222)
        Me.btnGeometryUtility.Name = "btnGeometryUtility"
        Me.btnGeometryUtility.Size = New System.Drawing.Size(55, 55)
        Me.btnGeometryUtility.TabIndex = 37
        Me.btnGeometryUtility.UseVisualStyleBackColor = True
        '
        'BtnAnalyser
        '
        Me.BtnAnalyser.Image = Global.RadbendLauncher.My.Resources.Resources.Analyse
        Me.BtnAnalyser.Location = New System.Drawing.Point(3, 308)
        Me.BtnAnalyser.Name = "BtnAnalyser"
        Me.BtnAnalyser.Size = New System.Drawing.Size(55, 55)
        Me.BtnAnalyser.TabIndex = 36
        Me.BtnAnalyser.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.HighlightText
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.BtnRunTool)
        Me.Panel1.Controls.Add(Me.LblProgs)
        Me.Panel1.Controls.Add(Me.CBLTools)
        Me.Panel1.Controls.Add(Me.CBLAnalysers)
        Me.Panel1.Controls.Add(Me.LblRunSelectedAnalysers)
        Me.Panel1.Controls.Add(Me.LblAvailableAnalysers)
        Me.Panel1.Controls.Add(Me.BtnAddRestAnalysers)
        Me.Panel1.Controls.Add(Me.BtnAnalyser)
        Me.Panel1.Location = New System.Drawing.Point(209, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(346, 368)
        Me.Panel1.TabIndex = 38
        '
        'BtnRunTool
        '
        Me.BtnRunTool.Location = New System.Drawing.Point(276, 308)
        Me.BtnRunTool.Name = "BtnRunTool"
        Me.BtnRunTool.Size = New System.Drawing.Size(65, 55)
        Me.BtnRunTool.TabIndex = 39
        Me.BtnRunTool.Text = "Run Tool"
        Me.BtnRunTool.UseVisualStyleBackColor = True
        '
        'LblProgs
        '
        Me.LblProgs.AutoSize = True
        Me.LblProgs.BackColor = System.Drawing.SystemColors.Window
        Me.LblProgs.Location = New System.Drawing.Point(308, 28)
        Me.LblProgs.Name = "LblProgs"
        Me.LblProgs.Size = New System.Drawing.Size(33, 13)
        Me.LblProgs.TabIndex = 38
        Me.LblProgs.Text = "Tools"
        '
        'CBLTools
        '
        Me.CBLTools.FormattingEnabled = True
        Me.CBLTools.Items.AddRange(New Object() {"pressbrakesExtractorUtil.exe", "HeelTool.exe", "TeamViewerQS.exe", "CustDataUtil.exe", "MaterialUpdate.exe", "msgFileConvert.exe", "ProfileEditor.exe", "SignXMLFile.exe", "smbSearchAndReplaceFiles.exe"})
        Me.CBLTools.Location = New System.Drawing.Point(165, 44)
        Me.CBLTools.Name = "CBLTools"
        Me.CBLTools.Size = New System.Drawing.Size(176, 244)
        Me.CBLTools.TabIndex = 37
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.RadbendLauncher.My.Resources.Resources.Prasa
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1224, 573)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.LblByWho)
        Me.Controls.Add(Me.PanelDirs)
        Me.Controls.Add(Me.PanelShortcuts)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Radbend Launcher"
        Me.PanelDirs.ResumeLayout(False)
        Me.PanelDirs.PerformLayout()
        Me.PanelShortcuts.ResumeLayout(False)
        Me.PanelShortcuts.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnOpenDataDir As System.Windows.Forms.Button
    Friend WithEvents TBDataDir As System.Windows.Forms.TextBox
    Friend WithEvents LblRadbendDataDir As System.Windows.Forms.Label
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents BtnChangeDataDir As System.Windows.Forms.Button
    Friend WithEvents TBInstallDIr As TextBox
    Friend WithEvents BtnOpenInstallDir As Button
    Friend WithEvents TBCLSPath As TextBox
    Friend WithEvents BtnOpenCLSPath As Button
    Friend WithEvents LblRadbendInstallDir As Label
    Friend WithEvents LblCLSPath As Label
    Friend WithEvents LblRunRadbend As Label
    Friend WithEvents LblRunSelectedAnalysers As Label
    Friend WithEvents LblGeometryUt As Label
    Friend WithEvents LblToolLibrary As Label
    Friend WithEvents LblCadConnection As Label
    Friend WithEvents LblSmbViewer As Label
    Friend WithEvents LblLicenseManager As Label
    Friend WithEvents CBLAnalysers As CheckedListBox
    Friend WithEvents LblAvailableAnalysers As Label
    Friend WithEvents LblByWho As Label
    Friend WithEvents BtnAddRestAnalysers As Button
    Friend WithEvents PanelDirs As Panel
    Friend WithEvents PanelShortcuts As Panel
    Friend WithEvents BtnAnalyser As Button
    Friend WithEvents BtnRunRadbend As Button
    Friend WithEvents BtnLicenceManager As Button
    Friend WithEvents BtnSmbViewer As Button
    Friend WithEvents btnGeometryUtility As Button
    Friend WithEvents BtnCadConnection As Button
    Friend WithEvents BtnToolLibrary As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents CBLTools As CheckedListBox
    Friend WithEvents BtnRunTool As Button
    Friend WithEvents LblProgs As Label
End Class
