Public Class About
    Private Sub ButtonOK_Click(sender As Object, e As RoutedEventArgs) Handles buttonOK.Click
        Hide()
    End Sub

    Private Sub About_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
        Dim tcb As SolidColorBrush = New SolidColorBrush()
        Dim bgcb As SolidColorBrush = New SolidColorBrush()
        Dim maincb As SolidColorBrush = New SolidColorBrush()

        If MainWindow.dm = False Then
            MainWindow.dm = True
            tcb.Color = ColorConverter.ConvertFromString("#ffffff")
            bgcb.Color = ColorConverter.ConvertFromString("#4D4D4D")
            maincb.Color = ColorConverter.ConvertFromString("#262626")
        ElseIf MainWindow.dm = True Then
            MainWindow.dm = False
            tcb.Color = ColorConverter.ConvertFromString("#000000")
            bgcb.Color = ColorConverter.ConvertFromString("#ffffff")
            maincb.Color = ColorConverter.ConvertFromString("#ffffff")
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
