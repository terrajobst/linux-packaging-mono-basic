'Author:
'   V. Sudharsan (vsudharsan@novell.com)
'
' (C) 2005 Novell, Inc.

Module ExpConversionStringtoByteA
    Function Main() As Integer
        Dim a As Byte
        Dim b As String = "123"
        a = CByte(b)
        If a <> 123 Then
            System.Console.WriteLine("Conversion of String to Byte not working. Expected 123 but got " & a) : Return 1
        End If
    End Function
End Module
