Module Module1

    Sub Main()
        Dim _myDas As New dasData.das
        'CHANGE FROM YOUR ACCOUNT
        Dim _Akey As String = "a09075165g-2f343fe-485a-8276-02574c41c94"
        Dim _dKey As String = "47d0b76dd8d449f2852ca3e25d2dbc"

        'SEND DATA DELIMITED BY |  DEPENDING ON THE CONFIGURED ELEMENTS 
        '  Console.Write(_myDas.sendDas("34|453|4322", _dKey, _Akey))

        'RECEIVE DATA - JSON / XML
        ' latest 100 values :: "json", 0, 100    
        ' based on interval dfrom / dto :: "json", 23.12.2013, 14.01.2014   
        '  Console.Write(_myDas.getDas(_dKey, "json", 0, 100))
        Console.Write(_myDas.getDas(_dKey, "jsond", "23.12.2013", "14.12.2016"))
        '  Console.Write(_myDas.getDas(_dKey, "xml", 0, 100))
        ' Console.Write(_myDas.getDas(_dKey, "xmld", "23.12.2013", "14.01.2014"))
        Console.ReadLine()
    End Sub

End Module
