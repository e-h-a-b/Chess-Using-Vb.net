Public Class chess

    '=========================================
    'A8 B8 C8 D8 E8 F8 G8 H8 
    'A7 B7 C7 D7 E7 F7 G7 H7

    'a6 b6 c6 d6 e6 f6 g6 h6
    'a5 b5 c5 d5 e5 f5 g5 h5
    'a4 b4 c4 d4 e4 f4 g4 h4
    'a3 b3 c3 d3 e3 f3 g3 h3

    'A2 B2 C2 D2 E2 F2 G2 H2
    'A1 B1 C1 D1 E1 F1 G1 H1
    Dim sapi = CreateObject("sapi.spvoice")
    Function def1(ByVal chk As PictureBox)
        Dim re
        sapi = CreateObject("sapi.spvoice")
        'black
        chk.BackColor = Color.Lime
        If chk.BackgroundImage Is D01.BackgroundImage Then chk.BackColor = Color.Red : re = "black,Asskary" 'عسكري
        If chk.BackgroundImage Is D02.BackgroundImage Then chk.BackColor = Color.Red : re = "black,tabya" 'طبية
        If chk.BackgroundImage Is D03.BackgroundImage Then chk.BackColor = Color.Red : re = "black,hosan" 'حصان
        If chk.BackgroundImage Is D04.BackgroundImage Then chk.BackColor = Color.Red : re = "black,feal" 'فيل
        If chk.BackgroundImage Is D06.BackgroundImage Then chk.BackColor = Color.Red : re = "black,malk" 'ملك
        If chk.BackgroundImage Is D05.BackgroundImage Then chk.BackColor = Color.Red : re = "black,wazer" 'وزير

        'white
        If chk.BackgroundImage Is D09.BackgroundImage Then chk.BackColor = Color.Red : re = "white,Asskary" 'عسكري
        If chk.BackgroundImage Is D10.BackgroundImage Then chk.BackColor = Color.Red : re = "white,tabya" 'طبية
        If chk.BackgroundImage Is D11.BackgroundImage Then chk.BackColor = Color.Red : re = "white,hosan" 'حصان
        If chk.BackgroundImage Is D12.BackgroundImage Then chk.BackColor = Color.Red : re = "white,feal" 'فيل
        If chk.BackgroundImage Is D14.BackgroundImage Then chk.BackColor = Color.Red : sapi.speak("The queen underattack") : re = "white,malk" 'ملك
        If chk.BackgroundImage Is D13.BackgroundImage Then chk.BackColor = Color.Red : re = "white,wazer" 'وزير
        If chk.BackgroundImage Is Nothing Then re = "Empty"

        Return re
    End Function
    Dim group() As String = {"a", "b", "c", "d", "e", "f", "g", "h"}
    Dim lock As String 'lock Game
    Dim randoms(1) As String
    Dim gg As PictureBox
    Sub st()
        Dim chars = "12345678"
        Dim random = New Random(Guid.NewGuid().GetHashCode())
        Dim randomString = New String(Enumerable.Repeat(chars, 1).[Select](Function(s) s(random.[Next](s.Length))).ToArray())

        Dim chars1 = "abcdefgh"
        Dim random1 = New Random(Guid.NewGuid().GetHashCode())
        Dim randomString1 = New String(Enumerable.Repeat(chars1, 1).[Select](Function(s) s(random1.[Next](s.Length))).ToArray())

        randoms(1) = randomString1 & randomString

    End Sub
    Sub stratgy()
        st()
        TextBox1.Text = randoms(1)

    End Sub
    Function def2(ByVal chk As String)
        Dim re

        If chk = "a1" Then re = def1(a1)
        If chk = "a2" Then re = def1(a2)
        If chk = "a3" Then re = def1(a3)
        If chk = "a4" Then re = def1(a4)
        If chk = "a5" Then re = def1(a5)
        If chk = "a6" Then re = def1(a6)
        If chk = "a7" Then re = def1(a7)
        If chk = "a8" Then re = def1(a8)

        If chk = "b1" Then re = def1(b1)
        If chk = "b2" Then re = def1(b2)
        If chk = "b3" Then re = def1(b3)
        If chk = "b4" Then re = def1(b4)
        If chk = "b5" Then re = def1(b5)
        If chk = "b6" Then re = def1(b6)
        If chk = "b7" Then re = def1(b7)
        If chk = "b8" Then re = def1(b8)

        If chk = "c1" Then re = def1(c1)
        If chk = "c2" Then re = def1(c2)
        If chk = "c3" Then re = def1(c3)
        If chk = "c4" Then re = def1(c4)
        If chk = "c5" Then re = def1(c5)
        If chk = "c6" Then re = def1(c6)
        If chk = "c7" Then re = def1(c7)
        If chk = "c8" Then re = def1(c8)

        If chk = "d1" Then re = def1(d1)
        If chk = "d2" Then re = def1(d2)
        If chk = "d3" Then re = def1(d3)
        If chk = "d4" Then re = def1(d4)
        If chk = "d5" Then re = def1(d5)
        If chk = "d6" Then re = def1(d6)
        If chk = "d7" Then re = def1(d7)
        If chk = "d8" Then re = def1(d8)

        If chk = "e1" Then re = def1(e1)
        If chk = "e2" Then re = def1(e2)
        If chk = "e3" Then re = def1(e3)
        If chk = "e4" Then re = def1(e4)
        If chk = "e5" Then re = def1(e5)
        If chk = "e6" Then re = def1(e6)
        If chk = "e7" Then re = def1(e7)
        If chk = "e8" Then re = def1(e8)

        If chk = "f1" Then re = def1(f1)
        If chk = "f2" Then re = def1(f2)
        If chk = "f3" Then re = def1(f3)
        If chk = "f4" Then re = def1(f4)
        If chk = "f5" Then re = def1(f5)
        If chk = "f6" Then re = def1(f6)
        If chk = "f7" Then re = def1(f7)
        If chk = "f8" Then re = def1(f8)

        If chk = "g1" Then re = def1(g1)
        If chk = "g2" Then re = def1(g2)
        If chk = "g3" Then re = def1(g3)
        If chk = "g4" Then re = def1(g4)
        If chk = "g5" Then re = def1(g5)
        If chk = "g6" Then re = def1(g6)
        If chk = "g7" Then re = def1(g7)
        If chk = "g8" Then re = def1(g8)

        If chk = "h1" Then re = def1(h1)
        If chk = "h2" Then re = def1(h2)
        If chk = "h3" Then re = def1(h3)
        If chk = "h4" Then re = def1(h4)
        If chk = "h5" Then re = def1(h5)
        If chk = "h6" Then re = def1(h6)
        If chk = "h7" Then re = def1(h7)
        If chk = "h8" Then re = def1(h8)

        Return re
    End Function
    Sub asskry(ByVal def As String, ByVal location As String)
        On Error Resume Next
        Dim cellvalue(2) As String
        cellvalue(0) = location.Chars(0)
        cellvalue(1) = location.Chars(1)
        If def = "white" Then
            If location = "a7" Or location = "b7" Or _
               location = "c7" Or location = "d7" Or _
               location = "e7" Or location = "f7" Or _
               location = "g7" Or location = "h7" Then
                TextBox3.Text = cellvalue(0) & cellvalue(1) - 1 & vbCrLf & cellvalue(0) & cellvalue(1) - 2
                def2(cellvalue(0) & cellvalue(1) - 1)
                def2(cellvalue(0) & cellvalue(1) - 2)
                lock = cellvalue(0) & cellvalue(1) - 1 & vbCrLf & cellvalue(0) & cellvalue(1) - 2
            Else
                TextBox3.Text = cellvalue(0) & cellvalue(1) - 1
                def2(cellvalue(0) & cellvalue(1) - 1)
                lock = cellvalue(0) & cellvalue(1) - 1
            End If
            Dim m, getvalue, lst, bn
            For g = 0 To group.Length - 1
                If group(g) = cellvalue(0) Then
                    getvalue = g
                End If
            Next
            ' -Up + down
            bn = 0
            For k = getvalue + 1 To getvalue + 1
                bn += 1
                def2(group(k) & cellvalue(1) - bn) 'Error
                lst = lst & vbCrLf & group(k) & cellvalue(1) - bn
            Next
            bn = 0
            For k = getvalue - 1 To getvalue - 1
                bn += 1
                def2(group(k) & cellvalue(1) - bn)
                lst = lst & vbCrLf & group(k) & cellvalue(1) - bn
            Next
            lock = lock & vbCrLf & lst
        ElseIf def = "black" Then
            'move
            If location = "a2" Or location = "b2" Or _
                location = "c2" Or location = "d2" Or _
                location = "e2" Or location = "f2" Or _
                location = "g2" Or location = "h2" Then
                TextBox3.Text = cellvalue(0) & cellvalue(1) + 1 & vbCrLf & cellvalue(0) & cellvalue(1) + 2
                def2(cellvalue(0) & cellvalue(1) + 1)
                def2(cellvalue(0) & cellvalue(1) + 2)
                lock = cellvalue(0) & cellvalue(1) + 1 & vbCrLf & cellvalue(0) & cellvalue(1) + 2
            Else
                TextBox3.Text = cellvalue(0) & cellvalue(1) + 1
                def2(cellvalue(0) & cellvalue(1) + 1)
                lock = cellvalue(0) & cellvalue(1) + 1
            End If
            'eat
            Dim m, getvalue, lst, bn
            For g = 0 To group.Length - 1
                If group(g) = cellvalue(0) Then
                    getvalue = g
                End If
            Next
            ' -Up + down
            bn = 0
            For k = getvalue + 1 To getvalue + 1
                bn += 1
                def2(group(k) & cellvalue(1) + bn)
                lst = lst & vbCrLf & group(k) & cellvalue(1) + bn
            Next
            bn = 0
            For k = getvalue - 1 To getvalue - 1
                bn += 1
                def2(group(k) & cellvalue(1) + bn)
                lst = lst & vbCrLf & group(k) & cellvalue(1) + bn
            Next
            lock = lock & vbCrLf & lst
        End If
    End Sub
    Sub tabya(ByVal def As String, ByVal location As String)
        '1 to 2
        'white & black
        Dim re As String
        'move
        Dim cellvalue(2) As String
        cellvalue(0) = location.Chars(0)
        cellvalue(1) = location.Chars(1)
        'right  left  up  down
        Textbox3.Text = ""
        Dim m, getvalue, lst
        For g = 0 To group.Length - 1
            If group(g) = cellvalue(0) Then
                getvalue = g
            End If
        Next


        For k = 0 To getvalue - 1
            lst = lst & vbCrLf & group(k) & cellvalue(1)
            def2(group(k) & cellvalue(1))
        Next
        For k = getvalue + 1 To group.Length - 1
            lst = lst & vbCrLf & group(k) & cellvalue(1)
            def2(group(k) & cellvalue(1))
        Next
        For i = 1 To 8 - cellvalue(1)
            m = cellvalue(0) & cellvalue(1) + i

            TextBox3.Text = TextBox3.Text & vbCrLf & cellvalue(0) & cellvalue(1) + i & def2(m)
        Next
        For i = 1 To cellvalue(1) - 1
            m = cellvalue(0) & cellvalue(1) - i
            Textbox3.Text = Textbox3.Text & vbCrLf & cellvalue(0) & cellvalue(1) - i & def2(m)
        Next
        TextBox3.Text = TextBox3.Text & vbCrLf & lst
        lock = TextBox3.Text
        'eat
    End Sub
    Sub hosan(ByVal def As String, ByVal location As String)
        On Error Resume Next
        Dim cellvalue(2) As String
        cellvalue(0) = location.Chars(0)
        cellvalue(1) = location.Chars(1)
        'right  left  up  down
        Textbox3.Text = ""
        Dim m, getvalue, lst, bn
        For g = 0 To group.Length - 1
            If group(g) = cellvalue(0) Then
                getvalue = g
            End If
        Next
        bn = 0
        For k = getvalue - 2 To getvalue - 1
            bn += 1
            'If cellvalue(1) - bn > 8 Or cellvalue(1) + bn > 8 Or _
            '    cellvalue(1) - bn < 1 Or cellvalue(1) + bn < 1 Then
            'Else
            ' A7
            ' A 0   7
            ' B 1
            ' C 2
            ' D 3
            ' A >> B C D E F G H
            ' 7 >> 6 5 4 3 2 1 
            lst = lst & vbCrLf & group(k) & cellvalue(1) - bn & def2(group(k) & cellvalue(1) - bn)
            lst = lst & vbCrLf & group(k) & cellvalue(1) + bn & def2(group(k) & cellvalue(1) + bn)
            'End If
        Next
        bn = 0
        For k As Integer = getvalue + 2 To getvalue + 1 Step -1
            bn += 1
            'If cellvalue(1) - bn > 8 Or cellvalue(1) + bn > 8 Or _
            '   cellvalue(1) - bn < 1 Or cellvalue(1) + bn < 1 Then
            'Else
            lst = lst & vbCrLf & group(k) & cellvalue(1) - bn & def2(group(k) & cellvalue(1) - bn)
            lst = lst & vbCrLf & group(k) & cellvalue(1) + bn & def2(group(k) & cellvalue(1) + bn)
            'End If
        Next k
        TextBox3.Text = "HZ=" & lst
        lock = lst
    End Sub
    Sub feal(ByVal def As String, ByVal location As String)
        Dim cellvalue(2) As String
        cellvalue(0) = location.Chars(0)
        cellvalue(1) = location.Chars(1)
        'right  left  up  down

        Dim m, getvalue, lst, bn
        For g = 0 To group.Length - 1
            If group(g) = cellvalue(0) Then
                getvalue = g
            End If
        Next
        ' -Up + down
        bn = 0
        For k As Integer = getvalue - 1 To 0 Step -1
            bn += 1
            def2(group(k) & cellvalue(1) + bn)
            lst = lst & vbCrLf & group(k) & cellvalue(1) + bn
        Next
        bn = 0
        For k = getvalue + 1 To group.Length - 1
            bn += 1
            def2(group(k) & cellvalue(1) - bn)
            lst = lst & vbCrLf & group(k) & cellvalue(1) - bn
        Next
        '#####################################################
        ' +Up - down
        bn = 0
        For k As Integer = getvalue - 1 To 0 Step -1
            bn += 1
            def2(group(k) & cellvalue(1) - bn)
            lst = lst & vbCrLf & group(k) & cellvalue(1) - bn
        Next
        bn = 0
        For k = getvalue + 1 To group.Length - 1
            bn += 1
            def2(group(k) & cellvalue(1) + bn)
            lst = lst & vbCrLf & group(k) & cellvalue(1) + bn
        Next
        TextBox3.Text = TextBox3.Text & vbCrLf & lst
        lock = TextBox3.Text
    End Sub
    Sub wazer(ByVal def As String, ByVal location As String)
        tabya(def, location)
        feal(def, location)
    End Sub
    Sub malk(ByVal def As String, ByVal location As String)
        Dim cellvalue(2) As String
        cellvalue(0) = location.Chars(0)
        cellvalue(1) = location.Chars(1)
        TextBox3.Text = cellvalue(0) & cellvalue(1) - 1 & vbCrLf & cellvalue(0) & cellvalue(1) + 1
        def2(cellvalue(0) & cellvalue(1) - 1)
        def2(cellvalue(0) & cellvalue(1) + 1)
        Dim m, getvalue, lst, bn
        For g = 0 To group.Length - 1
            If group(g) = cellvalue(0) Then
                getvalue = g
            End If
        Next
        ' -Up + down
        bn = 0
        For k = getvalue + 1 To getvalue + 1
            bn += 1
            def2(group(k) & cellvalue(1) - bn)
            def2(group(k) & cellvalue(1))
            lst = lst & vbCrLf & group(k) & cellvalue(1) - bn
            lst = lst & vbCrLf & group(k) & cellvalue(1)
        Next
        bn = 0
        For k = getvalue - 1 To getvalue - 1
            bn += 1
            def2(group(k) & cellvalue(1) - bn)
            def2(group(k) & cellvalue(1))
            lst = lst & vbCrLf & group(k) & cellvalue(1) - bn
            lst = lst & vbCrLf & group(k) & cellvalue(1)
        Next
        bn = 0
        For k = getvalue + 1 To getvalue + 1
            bn += 1
            def2(group(k) & cellvalue(1) + bn)
            lst = lst & vbCrLf & group(k) & cellvalue(1) + bn
        Next
        bn = 0
        For k = getvalue - 1 To getvalue - 1
            bn += 1
            def2(group(k) & cellvalue(1) + bn)
            lst = lst & vbCrLf & group(k) & cellvalue(1) + bn
        Next
        TextBox3.Text = TextBox3.Text & vbCrLf & lst
        lock = TextBox3.Text
    End Sub
    Sub Reset()
        Label17.Text = "Game on : White"
        a2.BackgroundImage = D01.BackgroundImage
        b2.BackgroundImage = D01.BackgroundImage
        c2.BackgroundImage = D01.BackgroundImage
        d2.BackgroundImage = D01.BackgroundImage
        e2.BackgroundImage = D01.BackgroundImage
        f2.BackgroundImage = D01.BackgroundImage
        g2.BackgroundImage = D01.BackgroundImage
        h2.BackgroundImage = D01.BackgroundImage

        a1.BackgroundImage = D02.BackgroundImage 'طبية
        b1.BackgroundImage = D03.BackgroundImage 'حصان
        c1.BackgroundImage = D04.BackgroundImage 'فيل
        d1.BackgroundImage = D06.BackgroundImage 'ملك
        e1.BackgroundImage = D05.BackgroundImage 'وزير
        f1.BackgroundImage = D04.BackgroundImage 'فيل
        g1.BackgroundImage = D03.BackgroundImage 'حصان
        h1.BackgroundImage = D02.BackgroundImage 'طبية


        a7.BackgroundImage = D09.BackgroundImage
        b7.BackgroundImage = D09.BackgroundImage
        c7.BackgroundImage = D09.BackgroundImage
        d7.BackgroundImage = D09.BackgroundImage
        e7.BackgroundImage = D09.BackgroundImage
        f7.BackgroundImage = D09.BackgroundImage
        g7.BackgroundImage = D09.BackgroundImage
        h7.BackgroundImage = D09.BackgroundImage

        a8.BackgroundImage = D10.BackgroundImage 'طبية
        b8.BackgroundImage = D11.BackgroundImage 'حصان
        c8.BackgroundImage = D12.BackgroundImage 'فيل
        d8.BackgroundImage = D14.BackgroundImage 'ملك
        e8.BackgroundImage = D13.BackgroundImage 'وزير
        f8.BackgroundImage = D12.BackgroundImage 'فيل
        g8.BackgroundImage = D11.BackgroundImage 'حصان
        h8.BackgroundImage = D10.BackgroundImage 'طبية

        a3.BackgroundImage = Nothing : a4.BackgroundImage = Nothing : a5.BackgroundImage = Nothing : a6.BackgroundImage = Nothing
        b3.BackgroundImage = Nothing : b4.BackgroundImage = Nothing : b5.BackgroundImage = Nothing : b6.BackgroundImage = Nothing
        c3.BackgroundImage = Nothing : c4.BackgroundImage = Nothing : c5.BackgroundImage = Nothing : c6.BackgroundImage = Nothing
        d3.BackgroundImage = Nothing : d4.BackgroundImage = Nothing : d5.BackgroundImage = Nothing : d6.BackgroundImage = Nothing
        e3.BackgroundImage = Nothing : e4.BackgroundImage = Nothing : e5.BackgroundImage = Nothing : e6.BackgroundImage = Nothing
        f3.BackgroundImage = Nothing : f4.BackgroundImage = Nothing : f5.BackgroundImage = Nothing : f6.BackgroundImage = Nothing
        g3.BackgroundImage = Nothing : g4.BackgroundImage = Nothing : g5.BackgroundImage = Nothing : g6.BackgroundImage = Nothing
        h3.BackgroundImage = Nothing : h4.BackgroundImage = Nothing : h5.BackgroundImage = Nothing : h6.BackgroundImage = Nothing
    End Sub
    Sub resetcolor()
        a2.BackColor = Color.AliceBlue
        b2.BackColor = SystemColors.AppWorkspace
        c2.BackColor = Color.AliceBlue
        d2.BackColor = SystemColors.AppWorkspace
        e2.BackColor = Color.AliceBlue
        f2.BackColor = SystemColors.AppWorkspace
        g2.BackColor = Color.AliceBlue
        h2.BackColor = SystemColors.AppWorkspace

        a1.BackColor = SystemColors.AppWorkspace 'طبية
        b1.BackColor = Color.AliceBlue 'حصان
        c1.BackColor = SystemColors.AppWorkspace 'فيل
        d1.BackColor = Color.AliceBlue 'ملك
        e1.BackColor = SystemColors.AppWorkspace 'وزير
        f1.BackColor = Color.AliceBlue 'فيل
        g1.BackColor = SystemColors.AppWorkspace 'حصان
        h1.BackColor = Color.AliceBlue 'طبية


        a7.BackColor = SystemColors.AppWorkspace
        b7.BackColor = Color.AliceBlue
        c7.BackColor = SystemColors.AppWorkspace
        d7.BackColor = Color.AliceBlue
        e7.BackColor = SystemColors.AppWorkspace
        f7.BackColor = Color.AliceBlue
        g7.BackColor = SystemColors.AppWorkspace
        h7.BackColor = Color.AliceBlue

        a8.BackColor = Color.AliceBlue 'طبية
        b8.BackColor = SystemColors.AppWorkspace 'حصان
        c8.BackColor = Color.AliceBlue 'فيل
        d8.BackColor = SystemColors.AppWorkspace 'ملك
        e8.BackColor = Color.AliceBlue 'وزير
        f8.BackColor = SystemColors.AppWorkspace 'فيل
        g8.BackColor = Color.AliceBlue 'حصان
        h8.BackColor = SystemColors.AppWorkspace 'طبية

        '00000000000000000000000000000
        a3.BackColor = SystemColors.AppWorkspace : a4.BackColor = Color.AliceBlue : a5.BackColor = SystemColors.AppWorkspace : a6.BackColor = Color.AliceBlue
        b3.BackColor = Color.AliceBlue : b4.BackColor = SystemColors.AppWorkspace : b5.BackColor = Color.AliceBlue : b6.BackColor = SystemColors.AppWorkspace
        c3.BackColor = SystemColors.AppWorkspace : c4.BackColor = Color.AliceBlue : c5.BackColor = SystemColors.AppWorkspace : c6.BackColor = Color.AliceBlue
        d3.BackColor = Color.AliceBlue : d4.BackColor = SystemColors.AppWorkspace : d5.BackColor = Color.AliceBlue : d6.BackColor = SystemColors.AppWorkspace
        e3.BackColor = SystemColors.AppWorkspace : e4.BackColor = Color.AliceBlue : e5.BackColor = SystemColors.AppWorkspace : e6.BackColor = Color.AliceBlue
        f3.BackColor = Color.AliceBlue : f4.BackColor = SystemColors.AppWorkspace : f5.BackColor = Color.AliceBlue : f6.BackColor = SystemColors.AppWorkspace
        g3.BackColor = SystemColors.AppWorkspace : g4.BackColor = Color.AliceBlue : g5.BackColor = SystemColors.AppWorkspace : g6.BackColor = Color.AliceBlue
        h3.BackColor = Color.AliceBlue : h4.BackColor = SystemColors.AppWorkspace : h5.BackColor = Color.AliceBlue : h6.BackColor = SystemColors.AppWorkspace
    End Sub
    Private Sub chess_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        D01.BackgroundImage = My.Resources._1
        D02.BackgroundImage = My.Resources._2 'طبية
        D03.BackgroundImage = My.Resources._3 'حصان
        D04.BackgroundImage = My.Resources._4 'فيل
        D05.BackgroundImage = My.Resources._5 'وزير
        D06.BackgroundImage = My.Resources._6 'ملك

        D09.BackgroundImage = My.Resources._01
        D10.BackgroundImage = My.Resources._02 'طبية
        D11.BackgroundImage = My.Resources._03 'حصان
        D12.BackgroundImage = My.Resources._04 'فيل
        D13.BackgroundImage = My.Resources._05 'وزير
        D14.BackgroundImage = My.Resources._06 'ملك

        Reset()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Reset()
        resetcolor()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _
        a1.Click, a2.Click, a3.Click, a4.Click, a5.Click, a6.Click, a7.Click, a8.Click, _
        b1.Click, b2.Click, b3.Click, b4.Click, b5.Click, b6.Click, b7.Click, b8.Click, _
        c1.Click, c2.Click, c3.Click, c4.Click, c5.Click, c6.Click, c7.Click, c8.Click, _
        d1.Click, d2.Click, d3.Click, d4.Click, d5.Click, d6.Click, d7.Click, d8.Click, _
        e1.Click, e2.Click, e3.Click, e4.Click, e5.Click, e6.Click, e7.Click, e8.Click, _
        f1.Click, f2.Click, f3.Click, f4.Click, f5.Click, f6.Click, f7.Click, f8.Click, _
        g1.Click, g2.Click, g3.Click, g4.Click, g5.Click, g6.Click, g7.Click, g8.Click, _
        h1.Click, h2.Click, h3.Click, h4.Click, h5.Click, h6.Click, h7.Click, h8.Click
        On Error Resume Next


        TextBox3.Text = ""
        resetcolor()
        If TextBox1.Text = "" Then

            Dim picBox As PictureBox = DirectCast(sender, PictureBox)
            Dim name As String = picBox.Name
            TextBox1.Text = name
            If picBox.BackgroundImage Is D01.BackgroundImage And Label18.Text.Contains("Black") Then Label17.Text = "عسكري اسود" : asskry("black", TextBox1.Text) : gg = picBox : Label18.Text = "Next Game on : White"
            If picBox.BackgroundImage Is D02.BackgroundImage And Label18.Text.Contains("Black") Then Label17.Text = "طبية سوداء" : tabya("black", TextBox1.Text) : gg = picBox : Label18.Text = "Next Game on : White"
            If picBox.BackgroundImage Is D03.BackgroundImage And Label18.Text.Contains("Black") Then Label17.Text = "حصان اسود" : hosan("black", TextBox1.Text) : gg = picBox : Label18.Text = "Next Game on : White"
            If picBox.BackgroundImage Is D04.BackgroundImage And Label18.Text.Contains("Black") Then Label17.Text = "فيل اسود" : feal("black", TextBox1.Text) : gg = picBox : Label18.Text = "Next Game on : White"
            If picBox.BackgroundImage Is D06.BackgroundImage And Label18.Text.Contains("Black") Then Label17.Text = "ملك اسود" : malk("black", TextBox1.Text) : gg = picBox : Label18.Text = "Next Game on : White"
            If picBox.BackgroundImage Is D05.BackgroundImage And Label18.Text.Contains("Black") Then Label17.Text = "وزير اسود" : wazer("black", TextBox1.Text) : gg = picBox : Label18.Text = "Next Game on : White"
            If picBox.BackgroundImage Is D04.BackgroundImage And Label18.Text.Contains("Black") Then Label17.Text = "فيل اسود" : feal("black", TextBox1.Text) : gg = picBox : Label18.Text = "Next Game on : White"
            If picBox.BackgroundImage Is D03.BackgroundImage And Label18.Text.Contains("Black") Then Label17.Text = "حصان اسود" : hosan("black", TextBox1.Text) : gg = picBox : Label18.Text = "Next Game on : White"
            If picBox.BackgroundImage Is D02.BackgroundImage And Label18.Text.Contains("Black") Then Label17.Text = "طبية سوداء" : tabya("black", TextBox1.Text) : gg = picBox : Label18.Text = "Next Game on : White"

            Label20.Text = def1(picBox)

            If picBox.BackgroundImage Is D09.BackgroundImage And Label18.Text.Contains("White") Then Label17.Text = "عسكري ابيض" : asskry("white", TextBox1.Text) : gg = picBox : Label18.Text = "Next Game on : Black"
            If picBox.BackgroundImage Is D10.BackgroundImage And Label18.Text.Contains("White") Then Label17.Text = "طبية بيضة" : tabya("white", TextBox1.Text) : gg = picBox : Label18.Text = "Next Game on : Black"
            If picBox.BackgroundImage Is D11.BackgroundImage And Label18.Text.Contains("White") Then Label17.Text = "حصان ابيض" : hosan("white", TextBox1.Text) : gg = picBox : Label18.Text = "Next Game on : Black"
            If picBox.BackgroundImage Is D12.BackgroundImage And Label18.Text.Contains("White") Then Label17.Text = "فيل ابيض" : feal("white", TextBox1.Text) : gg = picBox : Label18.Text = "Next Game on : Black"
            If picBox.BackgroundImage Is D14.BackgroundImage And Label18.Text.Contains("White") Then Label17.Text = "ملك ابيض" : malk("white", TextBox1.Text) : gg = picBox : Label18.Text = "Next Game on : Black"
            If picBox.BackgroundImage Is D13.BackgroundImage And Label18.Text.Contains("White") Then Label17.Text = "وزير ابيض" : wazer("white", TextBox1.Text) : gg = picBox : Label18.Text = "Next Game on : Black"
            If picBox.BackgroundImage Is D12.BackgroundImage And Label18.Text.Contains("White") Then Label17.Text = "فيل ابيض" : feal("white", TextBox1.Text) : gg = picBox : Label18.Text = "Next Game on : Black"
            If picBox.BackgroundImage Is D11.BackgroundImage And Label18.Text.Contains("White") Then Label17.Text = "حصان ابيض" : hosan("white", TextBox1.Text) : gg = picBox : Label18.Text = "Next Game on : Black"
            If picBox.BackgroundImage Is D10.BackgroundImage And Label18.Text.Contains("White") Then Label17.Text = "طبية بيضة" : tabya("white", TextBox1.Text) : gg = picBox : Label18.Text = "Next Game on : Black"
            If picBox.BackgroundImage Is Nothing Then TextBox1.Text = ""

        Else



            TextBox2.Text = TextBox1.Text
            Dim picBox1 As PictureBox = DirectCast(sender, PictureBox)
            TextBox1.Text = ""
            If lock.Contains(picBox1.Name) Then
                picBox1.BackgroundImage = gg.BackgroundImage
                gg.BackgroundImage = Nothing
                lock = ""
            End If


        End If

    End Sub
End Class