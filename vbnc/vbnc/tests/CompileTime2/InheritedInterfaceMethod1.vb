Class InheritedInterfaceMethod1
    Class Consumer
        Implements IDerived

        Function Method() As Integer Implements IBase.Method
            Return 1
        End Function
    End Class

    Interface IBase
        Function Method() As Integer
    End Interface

    Interface IDerived
        Inherits IBase
    End Interface

    Shared Function Main() As Integer
        Dim c As New Consumer
        Dim i As IDerived
        i = c
        Return i.method - 1
    End Function
End Class