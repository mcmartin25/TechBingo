﻿Imports System.IO
Public Class About
    Private Sub ButtonOK_Click(sender As Object, e As RoutedEventArgs) Handles buttonOK.Click
        Hide()
    End Sub

    Private Sub About_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
        Dim tcb As SolidColorBrush = New SolidColorBrush()
        Dim bgcb As SolidColorBrush = New SolidColorBrush()
        Dim maincb As SolidColorBrush = New SolidColorBrush()

        If MainWindow.dm = True Then
            tcb.Color = ColorConverter.ConvertFromString("#ffffff")
            bgcb.Color = ColorConverter.ConvertFromString("#4D4D4D")
            maincb.Color = ColorConverter.ConvertFromString("#262626")
        ElseIf MainWindow.dm = False Then
            tcb.Color = ColorConverter.ConvertFromString("#000000")
            bgcb.Color = ColorConverter.ConvertFromString("#ffffff")
            maincb.Color = ColorConverter.ConvertFromString("#ffffff")
        End If

        'Help file
        If File.Exists("HELP") Then
            txtHelp.Text = File.ReadAllText("HELP")
        Else
            txtHelp.Text = "Cannot read help resources"
        End If

        'License file
        If File.Exists("LICENSE") Then
            txtLicense.Text = File.ReadAllText("LICENSE")
        Else
            txtLicense.Text = "Cannot read help resources"
        End If

        '25 buttons content text
        txtAbout.Foreground = tcb
        txtHelp.Foreground = tcb
        txtLicense.Foreground = tcb

        '25 buttons content background color
        txtAbout.Background = bgcb
        txtHelp.Background = bgcb
        txtLicense.Background = bgcb

        'background color
        Background = maincb
    End Sub

End Class
