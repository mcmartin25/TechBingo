Imports System.IO
Class MainWindow
    'DEMO: https://www.google.com/imgres?imgurl=http%3A%2F%2Fwww.rongregory.org%2Fportfolio%2Fpics%2F01019.PNG&imgrefurl=http%3A%2F%2Fwww.rongregory.org%2Fportfolio%2Findex.php&docid=qJEAXNbRQ8E83M&tbnid=EIlxaSgwJoZuVM%3A&vet=10ahUKEwj1q6T7qZzcAhWCFYgKHRZqCEsQMwhFKA4wDg..i&w=641&h=634&client=firefox-b-ab&bih=824&biw=1440&q=vb%20bingo&ved=0ahUKEwj1q6T7qZzcAhWCFYgKHRZqCEsQMwhFKA4wDg&iact=mrc&uact=8#h=634&imgdii=EIlxaSgwJoZuVM:&vet=10ahUKEwj1q6T7qZzcAhWCFYgKHRZqCEsQMwhFKA4wDg..i&w=641
    'Search: https://www.google.com/search?client=firefox-b-ab&biw=1440&bih=824&ei=T71IW_H6G8KsoASiwbm4Dg&q=h%26s+bingo&oq=h%26s+bingo&gs_l=psy-ab.3..0i8i30k1l2.10092.12933.0.13193.8.8.0.0.0.0.98.571.8.8.0....0...1c.1.64.psy-ab..0.6.446...0i13i5i30k1j0i13i5i10i30k1j0i8i13i30k1j0i13i30k1j0i8i13i10i30k1j0i19k1j0i13i30i19k1j0i7i10i30k1j0i8i7i30k1j0i5i30k1.0.78K3gGlTfH0

    'Dim controls As Reflection.Assembly = Reflection.Assembly.GetAssembly(GetType(Control))
    Public Shared dm As Boolean = False

    Private Sub MainWindow_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
        'Help file
        If Not File.Exists("HELP") Then
            File.WriteAllBytes("HELP", My.Resources.HELP)
        End If

        'License file
        If Not File.Exists("LICENSE") Then
            File.WriteAllBytes("LICENSE", My.Resources.LICENSE)
        End If
    End Sub

    Private Sub Button_Click(sender As Object, e As RoutedEventArgs) Handles button.Click
        If txtObj01.Text = Nothing Or txtObj02.Text = Nothing Or txtObj03.Text = Nothing Or txtObj04.Text = Nothing Or txtObj05.Text = Nothing Or txtObj06.Text = Nothing Or txtObj07.Text = Nothing Or txtObj08.Text = Nothing Or txtObj09.Text = Nothing Or txtObj10.Text = Nothing Or txtObj11.Text = Nothing Or txtObj12.Text = Nothing Or txtObj13.Text = Nothing Or txtObj14.Text = Nothing Or txtObj15.Text = Nothing Or txtObj16.Text = Nothing Or txtObj17.Text = Nothing Or txtObj18.Text = Nothing Or txtObj19.Text = Nothing Or txtObj20.Text = Nothing Or txtObj21.Text = Nothing Or txtObj22.Text = Nothing Or txtObj23.Text = Nothing Or txtObj24.Text = Nothing Or txtObj25.Text = Nothing Or txtTitle.Text = Nothing Then
            lblTitle.Foreground = System.Windows.Media.Brushes.Red
            lblTitle.Content = "You still have something missing"
        Else
            ''lblTitle.Foreground = System.Windows.Media.Brushes.Green
            ''lblTitle.Content = "Pass!"
            Dim win1 As Window1 = New Window1()
            win1.Show()
            ''title content
            win1.labeltext.Content = txtTitle.Text
            ''25 buttons content
            win1.btnObj01.Content = txtObj01.Text
            win1.btnObj02.Content = txtObj02.Text
            win1.btnObj03.Content = txtObj03.Text
            win1.btnObj04.Content = txtObj04.Text
            win1.btnObj05.Content = txtObj05.Text
            win1.btnObj06.Content = txtObj06.Text
            win1.btnObj07.Content = txtObj07.Text
            win1.btnObj08.Content = txtObj08.Text
            win1.btnObj09.Content = txtObj09.Text
            win1.btnObj10.Content = txtObj10.Text
            win1.btnObj11.Content = txtObj11.Text
            win1.btnObj12.Content = txtObj12.Text
            win1.btnObj13.Content = txtObj13.Text
            win1.btnObj14.Content = txtObj14.Text
            win1.btnObj15.Content = txtObj15.Text
            win1.btnObj16.Content = txtObj16.Text
            win1.btnObj17.Content = txtObj17.Text
            win1.btnObj18.Content = txtObj18.Text
            win1.btnObj19.Content = txtObj19.Text
            win1.btnObj20.Content = txtObj20.Text
            win1.btnObj21.Content = txtObj21.Text
            win1.btnObj22.Content = txtObj22.Text
            win1.btnObj23.Content = txtObj23.Text
            win1.btnObj24.Content = txtObj24.Text
            win1.btnObj25.Content = txtObj25.Text
            Hide()
        End If
    End Sub

    Private Sub BtnAbout_Click(sender As Object, e As RoutedEventArgs) Handles btnAbout.Click
        Dim about As About = New About()
        about.Show()
    End Sub

    Private Sub BtnHelp_Click(sender As Object, e As RoutedEventArgs) Handles btnHelp.Click
        Dim about As About = New About()
        about.Show()
        about.tabControl1.SelectedIndex = 1
    End Sub

    Private Sub BtnLoad_Click(sender As Object, e As RoutedEventArgs) Handles btnLoad.Click
        ' Create OpenFileDialog 
        Dim dlg As New Microsoft.Win32.OpenFileDialog()

        ' Set filter for file extension and default file extension 
        dlg.DefaultExt = ".txt"
        dlg.Filter = "Text documents (.txt)|*.txt"

        ' Display OpenFileDialog by calling ShowDialog method 
        Dim result As Nullable(Of Boolean) = dlg.ShowDialog()

        ' Get the selected file name and display in a TextBox 
        If result = True Then
            ' Open document 
            Dim filename As String = dlg.FileName
            'open txt then list by boxes
            'FileNameTextBox.Text = filename
            'Dim number As Integer = 0
            'Dim Counter As String = System.IO.File.ReadAllLines(filename)(number)
            If File.ReadAllLines(filename).Count > 1 And File.ReadAllLines(filename).Count >= 26 Then
                txtTitle.Text = System.IO.File.ReadAllLines(filename)(0)
                txtObj01.Text = System.IO.File.ReadAllLines(filename)(1)
                txtObj02.Text = System.IO.File.ReadAllLines(filename)(2)
                txtObj03.Text = System.IO.File.ReadAllLines(filename)(3)
                txtObj04.Text = System.IO.File.ReadAllLines(filename)(4)
                txtObj05.Text = System.IO.File.ReadAllLines(filename)(5)
                txtObj06.Text = System.IO.File.ReadAllLines(filename)(6)
                txtObj07.Text = System.IO.File.ReadAllLines(filename)(7)
                txtObj08.Text = System.IO.File.ReadAllLines(filename)(8)
                txtObj09.Text = System.IO.File.ReadAllLines(filename)(9)
                txtObj10.Text = System.IO.File.ReadAllLines(filename)(10)
                txtObj11.Text = System.IO.File.ReadAllLines(filename)(11)
                txtObj12.Text = System.IO.File.ReadAllLines(filename)(12)
                txtObj13.Text = System.IO.File.ReadAllLines(filename)(13)
                txtObj14.Text = System.IO.File.ReadAllLines(filename)(14)
                txtObj15.Text = System.IO.File.ReadAllLines(filename)(15)
                txtObj16.Text = System.IO.File.ReadAllLines(filename)(16)
                txtObj17.Text = System.IO.File.ReadAllLines(filename)(17)
                txtObj18.Text = System.IO.File.ReadAllLines(filename)(18)
                txtObj19.Text = System.IO.File.ReadAllLines(filename)(19)
                txtObj20.Text = System.IO.File.ReadAllLines(filename)(20)
                txtObj21.Text = System.IO.File.ReadAllLines(filename)(21)
                txtObj22.Text = System.IO.File.ReadAllLines(filename)(22)
                txtObj23.Text = System.IO.File.ReadAllLines(filename)(23)
                txtObj24.Text = System.IO.File.ReadAllLines(filename)(24)
                txtObj25.Text = System.IO.File.ReadAllLines(filename)(25)
            ElseIf File.ReadAllLines(filename).Count < 26 Then
                MessageBox.Show("Load error! Data line not enough")
            Else
                MessageBox.Show("Load error! Data missing")
            End If
        End If
    End Sub

    Private Sub BtnExport_Click(sender As Object, e As RoutedEventArgs) Handles btnExport.Click
        ' Create OpenFileDialog 
        Dim dlg As New Microsoft.Win32.SaveFileDialog()

        ' Set filter for file extension and default file extension 
        dlg.DefaultExt = ".txt"
        dlg.Filter = "Text documents (.txt)|*.txt"

        ' Display OpenFileDialog by calling ShowDialog method 
        Dim result As Nullable(Of Boolean) = dlg.ShowDialog()

        ' Get the selected file name and display in a TextBox 
        If result = True Then
            ' Open document 
            Dim filename As String = dlg.FileName
            ''Write all text to txt file, title first
            Dim c As String
            c = txtTitle.Text + vbCrLf +
                txtObj01.Text + vbCrLf +
                txtObj02.Text + vbCrLf +
                txtObj03.Text + vbCrLf +
                txtObj04.Text + vbCrLf +
                txtObj05.Text + vbCrLf +
                txtObj06.Text + vbCrLf +
                txtObj07.Text + vbCrLf +
                txtObj08.Text + vbCrLf +
                txtObj09.Text + vbCrLf +
                txtObj10.Text + vbCrLf +
                txtObj11.Text + vbCrLf +
                txtObj12.Text + vbCrLf +
                txtObj13.Text + vbCrLf +
                txtObj14.Text + vbCrLf +
                txtObj15.Text + vbCrLf +
                txtObj16.Text + vbCrLf +
                txtObj17.Text + vbCrLf +
                txtObj18.Text + vbCrLf +
                txtObj19.Text + vbCrLf +
                txtObj20.Text + vbCrLf +
                txtObj20.Text + vbCrLf +
                txtObj21.Text + vbCrLf +
                txtObj22.Text + vbCrLf +
                txtObj23.Text + vbCrLf +
                txtObj24.Text + vbCrLf +
                txtObj25.Text + vbCrLf
            File.WriteAllText(dlg.FileName, c)
        End If
    End Sub

    Private Sub MainWindow_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Environment.Exit(0)
    End Sub

    Private Sub BtnDarkMode_Click(sender As Object, e As RoutedEventArgs) Handles btnDarkMode.Click
        Dim tcb As SolidColorBrush = New SolidColorBrush()
        Dim bgcb As SolidColorBrush = New SolidColorBrush()
        Dim maincb As SolidColorBrush = New SolidColorBrush()

        If dm = False Then
            dm = True
            tcb.Color = ColorConverter.ConvertFromString("#ffffff")
            bgcb.Color = ColorConverter.ConvertFromString("#4D4D4D")
            maincb.Color = ColorConverter.ConvertFromString("#262626")
            btnDarkMode.Content = "Normal Mode"
        ElseIf dm = True Then
            dm = False
            tcb.Color = ColorConverter.ConvertFromString("#000000")
            bgcb.Color = ColorConverter.ConvertFromString("#ffffff")
            maincb.Color = ColorConverter.ConvertFromString("#ffffff")
            btnDarkMode.Content = "Dark Mode"
        End If

        '25 buttons content text
        txtTitle.Foreground = tcb
        txtObj01.Foreground = tcb
        txtObj02.Foreground = tcb
        txtObj03.Foreground = tcb
        txtObj04.Foreground = tcb
        txtObj05.Foreground = tcb
        txtObj06.Foreground = tcb
        txtObj07.Foreground = tcb
        txtObj08.Foreground = tcb
        txtObj09.Foreground = tcb
        txtObj10.Foreground = tcb
        txtObj11.Foreground = tcb
        txtObj12.Foreground = tcb
        txtObj13.Foreground = tcb
        txtObj14.Foreground = tcb
        txtObj15.Foreground = tcb
        txtObj16.Foreground = tcb
        txtObj17.Foreground = tcb
        txtObj18.Foreground = tcb
        txtObj19.Foreground = tcb
        txtObj20.Foreground = tcb
        txtObj20.Foreground = tcb
        txtObj21.Foreground = tcb
        txtObj22.Foreground = tcb
        txtObj23.Foreground = tcb
        txtObj24.Foreground = tcb
        txtObj25.Foreground = tcb

        '25 buttons content background color
        txtTitle.Background = bgcb
        txtObj01.Background = bgcb
        txtObj02.Background = bgcb
        txtObj03.Background = bgcb
        txtObj04.Background = bgcb
        txtObj05.Background = bgcb
        txtObj06.Background = bgcb
        txtObj07.Background = bgcb
        txtObj08.Background = bgcb
        txtObj09.Background = bgcb
        txtObj10.Background = bgcb
        txtObj11.Background = bgcb
        txtObj12.Background = bgcb
        txtObj13.Background = bgcb
        txtObj14.Background = bgcb
        txtObj15.Background = bgcb
        txtObj16.Background = bgcb
        txtObj17.Background = bgcb
        txtObj18.Background = bgcb
        txtObj19.Background = bgcb
        txtObj20.Background = bgcb
        txtObj20.Background = bgcb
        txtObj21.Background = bgcb
        txtObj22.Background = bgcb
        txtObj23.Background = bgcb
        txtObj24.Background = bgcb
        txtObj25.Background = bgcb

        'label content text, background set to transparent
        lblTitle.Foreground = tcb
        lblTitle2.Foreground = tcb

        'main app background color
        Background = maincb

    End Sub

End Class
