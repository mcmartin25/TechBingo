Imports System.Windows.Threading

Public Class Window1
    Dim p As Integer = 0
    Dim bingocheck As Boolean = False 'Decide to display bingo text or not
    Dim dt As DispatcherTimer = New DispatcherTimer
    Dim t As Integer = 0 'Timer recorder, the default set to 3
    Dim cr As New SolidColorBrush()
    Dim cbk As New SolidColorBrush()

    Private Sub Window1_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
        ''label.Content = MainWindow.txtTitle.Text
        cr.Color = Colors.Red
        cbk.Color = Colors.Black
        AddHandler dt.Tick, AddressOf DispatcherTimer_Tick
        dt.Interval = New TimeSpan(0, 0, 1)
        dt.Stop()
    End Sub

    Public Sub DispatcherTimer_Tick(ByVal sender As Object, ByVal e As EventArgs)
        If bingocheck = True Then
            If t >= 3 Then
                bingocheck = False
                t = 0
                labelmark.Foreground = cbk
                labelmark.Content = p.ToString + " / 25"
                dt.Stop()
            Else
                labelmark.Foreground = cr
                labelmark.Content = "Bingo!"
                t += 1

            End If
        End If
        Debug.Write("bingocheck: ")
        Debug.WriteLine(bingocheck.ToString)
        Debug.Write("t: ")
        Debug.WriteLine(t)
    End Sub

    Private Sub BtnObj01_Click(sender As Object, e As RoutedEventArgs) Handles btnObj01.Click
        p += 1
        labelmark.Content = p.ToString + " / 25"
        btnObj01.IsEnabled = False
    End Sub

    Private Sub BtnObj02_Click(sender As Object, e As RoutedEventArgs) Handles btnObj02.Click
        p += 1
        labelmark.Content = p.ToString + " / 25"
        btnObj02.IsEnabled = False
    End Sub

    Private Sub BtnObj03_Click(sender As Object, e As RoutedEventArgs) Handles btnObj03.Click
        p += 1
        labelmark.Content = p.ToString + " / 25"
        btnObj03.IsEnabled = False
    End Sub

    Private Sub BtnObj04_Click(sender As Object, e As RoutedEventArgs) Handles btnObj04.Click
        p += 1
        labelmark.Content = p.ToString + " / 25"
        btnObj04.IsEnabled = False
    End Sub

    Private Sub BtnObj05_Click(sender As Object, e As RoutedEventArgs) Handles btnObj05.Click
        p += 1
        labelmark.Content = p.ToString + " / 25"
        btnObj05.IsEnabled = False
    End Sub

    Private Sub BtnObj06_Click(sender As Object, e As RoutedEventArgs) Handles btnObj06.Click
        p += 1
        labelmark.Content = p.ToString + " / 25"
        btnObj06.IsEnabled = False
    End Sub

    Private Sub BtnObj07_Click(sender As Object, e As RoutedEventArgs) Handles btnObj07.Click
        p += 1
        labelmark.Content = p.ToString + " / 25"
        btnObj07.IsEnabled = False
    End Sub

    Private Sub BtnObj08_Click(sender As Object, e As RoutedEventArgs) Handles btnObj08.Click
        p += 1
        labelmark.Content = p.ToString + " / 25"
        btnObj08.IsEnabled = False
    End Sub

    Private Sub BtnObj09_Click(sender As Object, e As RoutedEventArgs) Handles btnObj09.Click
        p += 1
        labelmark.Content = p.ToString + " / 25"
        btnObj09.IsEnabled = False
    End Sub

    Private Sub BtnObj10_Click(sender As Object, e As RoutedEventArgs) Handles btnObj10.Click
        p += 1
        labelmark.Content = p.ToString + " / 25"
        btnObj10.IsEnabled = False
    End Sub

    Private Sub BtnObj11_Click(sender As Object, e As RoutedEventArgs) Handles btnObj11.Click
        p += 1
        labelmark.Content = p.ToString + " / 25"
        btnObj11.IsEnabled = False
    End Sub

    Private Sub BtnObj12_Click(sender As Object, e As RoutedEventArgs) Handles btnObj12.Click
        p += 1
        labelmark.Content = p.ToString + " / 25"
        btnObj12.IsEnabled = False
    End Sub

    Private Sub BtnObj13_Click(sender As Object, e As RoutedEventArgs) Handles btnObj13.Click
        p += 1
        labelmark.Content = p.ToString + " / 25"
        btnObj13.IsEnabled = False
    End Sub

    Private Sub BtnObj14_Click(sender As Object, e As RoutedEventArgs) Handles btnObj14.Click
        p += 1
        labelmark.Content = p.ToString + " / 25"
        btnObj14.IsEnabled = False
    End Sub

    Private Sub BtnObj15_Click(sender As Object, e As RoutedEventArgs) Handles btnObj15.Click
        p += 1
        labelmark.Content = p.ToString + " / 25"
        btnObj15.IsEnabled = False
    End Sub

    Private Sub BtnObj16_Click(sender As Object, e As RoutedEventArgs) Handles btnObj16.Click
        p += 1
        labelmark.Content = p.ToString + " / 25"
        btnObj16.IsEnabled = False
    End Sub

    Private Sub BtnObj17_Click(sender As Object, e As RoutedEventArgs) Handles btnObj17.Click
        p += 1
        labelmark.Content = p.ToString + " / 25"
        btnObj17.IsEnabled = False
    End Sub

    Private Sub BtnObj18_Click(sender As Object, e As RoutedEventArgs) Handles btnObj18.Click
        p += 1
        labelmark.Content = p.ToString + " / 25"
        btnObj18.IsEnabled = False
    End Sub

    Private Sub BtnObj19_Click(sender As Object, e As RoutedEventArgs) Handles btnObj19.Click
        p += 1
        labelmark.Content = p.ToString + " / 25"
        btnObj19.IsEnabled = False
    End Sub

    Private Sub BtnObj20_Click(sender As Object, e As RoutedEventArgs) Handles btnObj20.Click
        p += 1
        labelmark.Content = p.ToString + " / 25"
        btnObj20.IsEnabled = False
    End Sub

    Private Sub BtnObj21_Click(sender As Object, e As RoutedEventArgs) Handles btnObj21.Click
        p += 1
        labelmark.Content = p.ToString + " / 25"
        btnObj21.IsEnabled = False
    End Sub

    Private Sub BtnObj22_Click(sender As Object, e As RoutedEventArgs) Handles btnObj22.Click
        p += 1
        labelmark.Content = p.ToString + " / 25"
        btnObj22.IsEnabled = False
    End Sub

    Private Sub BtnObj23_Click(sender As Object, e As RoutedEventArgs) Handles btnObj23.Click
        p += 1
        labelmark.Content = p.ToString + " / 25"
        btnObj23.IsEnabled = False
    End Sub

    Private Sub BtnObj24_Click(sender As Object, e As RoutedEventArgs) Handles btnObj24.Click
        p += 1
        labelmark.Content = p.ToString + " / 25"
        btnObj24.IsEnabled = False
    End Sub

    Private Sub BtnObj25_Click(sender As Object, e As RoutedEventArgs) Handles btnObj25.Click
        p += 1
        labelmark.Content = p.ToString + " / 25"
        btnObj25.IsEnabled = False
    End Sub

    Sub Objects(ByVal sender As Object, ByVal e As EventArgs) Handles btnObj01.Click, btnObj02.Click, btnObj03.Click, btnObj04.Click, btnObj05.Click,
        btnObj06.Click, btnObj07.Click, btnObj08.Click, btnObj09.Click, btnObj10.Click,
        btnObj11.Click, btnObj12.Click, btnObj13.Click, btnObj14.Click, btnObj15.Click,
        btnObj16.Click, btnObj17.Click, btnObj18.Click, btnObj19.Click, btnObj20.Click,
        btnObj21.Click, btnObj22.Click, btnObj23.Click, btnObj24.Click, btnObj25.Click

        'Disable button when clicks
        'If btnObj01.IsEnabled = True Then
        'p += 1
        'labelmark.Content = p.ToString + " / 25"
        'btnObj01.IsEnabled = False
        'End If
        '...
        If bingocheck = False Then
            'Check Bingo or not

            'Row
            If btnObj01.IsEnabled = False And btnObj02.IsEnabled = False And btnObj03.IsEnabled = False And btnObj04.IsEnabled = False And btnObj05.IsEnabled = False Then
                bingocheck = True
                dt.Start()
            End If

            If btnObj06.IsEnabled = False And btnObj07.IsEnabled = False And btnObj08.IsEnabled = False And btnObj09.IsEnabled = False And btnObj10.IsEnabled = False Then
                bingocheck = True
                dt.Start()
            End If

            If btnObj11.IsEnabled = False And btnObj12.IsEnabled = False And btnObj13.IsEnabled = False And btnObj14.IsEnabled = False And btnObj15.IsEnabled = False Then
                bingocheck = True
                dt.Start()
            End If

            If btnObj16.IsEnabled = False And btnObj17.IsEnabled = False And btnObj18.IsEnabled = False And btnObj19.IsEnabled = False And btnObj20.IsEnabled = False Then
                bingocheck = True
                dt.Start()
            End If

            If btnObj21.IsEnabled = False And btnObj22.IsEnabled = False And btnObj23.IsEnabled = False And btnObj24.IsEnabled = False And btnObj25.IsEnabled = False Then
                bingocheck = True
                dt.Start()
            End If

            'Column
            If btnObj01.IsEnabled = False And btnObj06.IsEnabled = False And btnObj11.IsEnabled = False And btnObj16.IsEnabled = False And btnObj21.IsEnabled = False Then
                bingocheck = True
                dt.Start()
            End If

            If btnObj02.IsEnabled = False And btnObj07.IsEnabled = False And btnObj12.IsEnabled = False And btnObj17.IsEnabled = False And btnObj22.IsEnabled = False Then
                bingocheck = True
                dt.Start()
            End If

            If btnObj03.IsEnabled = False And btnObj08.IsEnabled = False And btnObj13.IsEnabled = False And btnObj18.IsEnabled = False And btnObj23.IsEnabled = False Then
                bingocheck = True
                dt.Start()
            End If

            If btnObj04.IsEnabled = False And btnObj09.IsEnabled = False And btnObj14.IsEnabled = False And btnObj19.IsEnabled = False And btnObj24.IsEnabled = False Then
                bingocheck = True
                dt.Start()
            End If

            If btnObj05.IsEnabled = False And btnObj10.IsEnabled = False And btnObj15.IsEnabled = False And btnObj20.IsEnabled = False And btnObj25.IsEnabled = False Then
                bingocheck = True
                dt.Start()
            End If

            'incline

            If btnObj01.IsEnabled = False And btnObj07.IsEnabled = False And btnObj13.IsEnabled = False And btnObj19.IsEnabled = False And btnObj25.IsEnabled = False Then
                bingocheck = True
                dt.Start()
            End If

            If btnObj05.IsEnabled = False And btnObj09.IsEnabled = False And btnObj13.IsEnabled = False And btnObj17.IsEnabled = False And btnObj21.IsEnabled = False Then
                bingocheck = True
                dt.Start()
            End If
        End If
    End Sub

    Private Sub BtnReset_Click(sender As Object, e As RoutedEventArgs) Handles btnReset.Click
        p = 0
        labelmark.Content = p.ToString + " / 25"
        btnObj01.IsEnabled = True
        btnObj02.IsEnabled = True
        btnObj03.IsEnabled = True
        btnObj04.IsEnabled = True
        btnObj05.IsEnabled = True
        btnObj06.IsEnabled = True
        btnObj07.IsEnabled = True
        btnObj08.IsEnabled = True
        btnObj09.IsEnabled = True
        btnObj10.IsEnabled = True
        btnObj11.IsEnabled = True
        btnObj12.IsEnabled = True
        btnObj13.IsEnabled = True
        btnObj14.IsEnabled = True
        btnObj15.IsEnabled = True
        btnObj16.IsEnabled = True
        btnObj17.IsEnabled = True
        btnObj18.IsEnabled = True
        btnObj19.IsEnabled = True
        btnObj20.IsEnabled = True
        btnObj21.IsEnabled = True
        btnObj22.IsEnabled = True
        btnObj23.IsEnabled = True
        btnObj24.IsEnabled = True
        btnObj25.IsEnabled = True
        dt.Stop()
    End Sub

    Private Sub BtnAbout_Click(sender As Object, e As RoutedEventArgs) Handles btnAbout.Click
        Dim about As About = New About()
        about.Show()
    End Sub

    Private Sub Window1_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Dim mainwin As MainWindow = New MainWindow()
        mainwin.Show()
        ''title content
        mainwin.txtTitle.Text = labeltext.Content
        ''25 buttons content
        mainwin.txtObj01.Text = btnObj01.Content
        mainwin.txtObj02.Text = btnObj02.Content
        mainwin.txtObj03.Text = btnObj03.Content
        mainwin.txtObj04.Text = btnObj04.Content
        mainwin.txtObj05.Text = btnObj05.Content
        mainwin.txtObj06.Text = btnObj06.Content
        mainwin.txtObj07.Text = btnObj07.Content
        mainwin.txtObj08.Text = btnObj08.Content
        mainwin.txtObj09.Text = btnObj09.Content
        mainwin.txtObj10.Text = btnObj10.Content
        mainwin.txtObj11.Text = btnObj11.Content
        mainwin.txtObj12.Text = btnObj12.Content
        mainwin.txtObj13.Text = btnObj13.Content
        mainwin.txtObj14.Text = btnObj14.Content
        mainwin.txtObj15.Text = btnObj15.Content
        mainwin.txtObj16.Text = btnObj16.Content
        mainwin.txtObj17.Text = btnObj17.Content
        mainwin.txtObj18.Text = btnObj18.Content
        mainwin.txtObj19.Text = btnObj19.Content
        mainwin.txtObj20.Text = btnObj20.Content
        mainwin.txtObj21.Text = btnObj21.Content
        mainwin.txtObj22.Text = btnObj22.Content
        mainwin.txtObj23.Text = btnObj23.Content
        mainwin.txtObj24.Text = btnObj24.Content
        mainwin.txtObj25.Text = btnObj25.Content
        dt.Stop()
        Hide()
    End Sub


End Class
