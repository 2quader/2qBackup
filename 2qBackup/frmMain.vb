' Bitte http://www.icsharpcode.net/opensource/sharpziplib/Download.aspx herunterladen
' und einen Verweis auf ICSharpCode.SharpZipLib.dll zum Projekt hinzufuegen
' (Doppelklick auf 'My Project' im Projektmappen-Explorer, links auf 'Verweise'
' klicken, und unten auf 'Hinzufuegen'. Dann auf die Registerkarte 'Durchsuchen'
' wechseln und die Datei ICSharpCode.SharpZipLib.dll auswaehlen)

Imports ICSharpCode.SharpZipLib
Imports System.IO
Imports System.Net

Public Class frmMain

    ' Globale Variablen
    Dim localpath As String
    Dim fno As String
    Dim confSrc As String
    Dim confTar As String
    Dim confUser As String
    Dim confPass As String
    WithEvents wC As New WebClient

    Private Sub logThis(ByVal log As String, Optional ByVal ZeigeZeit As Boolean = True)
        Select Case ZeigeZeit
            Case True
                Dim zeit_ As String = Now.TimeOfDay.ToString
                Dim zeit As String = zeit_.Substring(0, zeit_.LastIndexOf("."))
                lbLog.Items.Add("[" & zeit & "] " & log)
            Case False
                lbLog.Items.Add(log)
        End Select
    End Sub

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim fileName As String = My.Application.Info.DirectoryPath & "\conf.ini"
        Dim ini As New INIDatei
        If File.Exists(fileName) Then
            ini.Pfad = fileName
        Else
            If MessageBox.Show("Keine Konfigurationsdatei! Bitte " _
               & Chr(34) & fileName & Chr(34) & " anlegen!", "Wichtiger Hinweis", _
               MessageBoxButtons.OK, MessageBoxIcon.Error) = Windows.Forms.DialogResult.OK Then
                Me.Close()
            End If
        End If

        confSrc = ini.WertLesen("Path", "Src")
        confTar = ini.WertLesen("Path", "Tar")
        confUser = ini.WertLesen("Credentials", "User")
        confPass = ini.WertLesen("Credentials", "Pass")

        If confSrc = "" Or confTar = "" Or confUser = "" Or confPass = "" Then
            If MessageBox.Show("Fehler in der Konfigurationsdatei!" & vbCrLf & "Pfad: " _
               & Chr(34) & fileName & Chr(34), "Wichtiger Hinweis", MessageBoxButtons.OK, _
               MessageBoxIcon.Error) = Windows.Forms.DialogResult.OK Then
                Me.Close()
            End If
        End If

        txtSrc.Text = confSrc
        txtTarget.Text = confTar
        txtUser.Text = confUser
        txtmPass.Text = confPass
    End Sub

    Private Sub wC_UploadFileCompleted(ByVal sender As Object, ByVal e As System.Net.UploadFileCompletedEventArgs) Handles wC.UploadFileCompleted
        logThis("UPLOAD     : OK.")
        logThis("Lösche lokale Kopie...")
        File.Delete(localpath)
        logThis("Lokale Kopie gelöscht.")
        logThis(String.Empty, False)
        logThis("Fertig!")
        btnStart.Text = "Beenden"
    End Sub

    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        Select Case btnStart.Text
            Case "Beenden"
                Me.Close()
            Case Else
                bgwZIP.RunWorkerAsync()
                logThis("COMPRESSION: Gestartet.")
        End Select
    End Sub

    Private Sub bgwZIP_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bgwZIP.DoWork
        Try
            localpath = IO.Path.GetTempPath & Now.ToString.Replace(":", "-").Replace(".", "-").Replace(" ", "_") & ".zip"
            Dim compressor As New Zip.FastZip
            compressor.CreateEmptyDirectories = True
            'compressor.CreateZip(localpath, "C:\Users\Frank Schlüter\Documents\FC 1920 Remblinghausen e.V", True, "", "")
            compressor.CreateZip(localpath, confSrc, True, "", "")
        Catch ex As Exception
            e.Result = ex.Message
        End Try
    End Sub

    Private Sub bgwZIP_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgwZIP.RunWorkerCompleted
        If e.Result <> String.Empty Then
            logThis(e.Result)
            btnStart.Text = "Beenden"
        Else
            logThis("COMPRESSION: OK.")
            Dim fi As New FileInfo(localpath)
            fno = fi.Name
            logThis("UPLOAD     : Gestartet.")
            wC.Credentials = New Net.NetworkCredential(confUser, confPass)
            wC.UploadFileAsync(New System.Uri(confTar & fno), localpath)
        End If
    End Sub
End Class
