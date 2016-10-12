﻿Public Class EmoApp
    Private Sub EmoApp_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub ThemeCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles ThemeCheckBox.CheckedChanged
        If DarkTheme Then
            CurrentTheme = MetroFramework.MetroThemeStyle.Light
            DarkTheme = False
        Else
            CurrentTheme = MetroFramework.MetroThemeStyle.Dark
            DarkTheme = True
        End If

        Me.Theme = CurrentTheme
        ThemeCheckBox.Theme = CurrentTheme
        PraatButton.Theme = CurrentTheme
        ElanButton.Theme = CurrentTheme
        WebcamButton.Theme = CurrentTheme
        EmotivButton.Theme = CurrentTheme
        WebcamForm.Theme = CurrentTheme
        WebcamForm.recordButton.Theme = CurrentTheme
        WebcamForm.cameraButton.Theme = CurrentTheme
        Me.Refresh()
        WebcamForm.Refresh()

    End Sub

    Private Sub PraatButton_Click(sender As Object, e As EventArgs) Handles PraatButton.Click
        Try
            System.Diagnostics.Process.Start(PraatPath)
        Catch startError As Exception
            'Console.WriteLine(startError.Message)
            Msg = "No Program Path Specified"
            MsgForm.Show()
            OpenFileDialog.ShowDialog()
            MsgForm.Close()
            If OpenFileDialog.FileName <> NullPath Then
                PraatPath = OpenFileDialog.FileName
                Msg = "SUCCESSFULLY CHANGED!"
                MsgForm.Show()
            End If
            OpenFileDialog.FileName = NullPath
        End Try
    End Sub

    Private Sub ElanButton_Click(sender As Object, e As EventArgs) Handles ElanButton.Click
        Try
            System.Diagnostics.Process.Start(ElanPath)
        Catch startError As Exception
            'Console.WriteLine(startError.Message)
            Msg = "No Program Path Specified"
            MsgForm.Show()
            OpenFileDialog.ShowDialog()
            MsgForm.Close()
            If OpenFileDialog.FileName <> NullPath Then
                ElanPath = OpenFileDialog.FileName
                Msg = "SUCCESSFULLY CHANGED!"
                MsgForm.Show()
            End If
            OpenFileDialog.FileName = NullPath
        End Try
    End Sub

    Private Sub WebcamButton_Click(sender As Object, e As EventArgs) Handles WebcamButton.Click
        WebcamForm.Show()
    End Sub

    Private Sub EmotivButton_Click(sender As Object, e As EventArgs) Handles EmotivButton.Click
        Try
            System.Diagnostics.Process.Start(EEGWriterPath)
        Catch ex As Exception

        End Try
    End Sub
End Class
