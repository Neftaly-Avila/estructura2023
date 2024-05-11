Imports System
// ejercicio 1
Module Program
    Sub Main()
        PrintEvenNumbers(1)
    End Sub

    Sub PrintEvenNumbers(ByVal n As Integer)
        If n <= 100 Then
            If n Mod 2 = 0 Then
                Console.WriteLine(n)
            End If
            PrintEvenNumbers(n + 1)
        End If
    End Sub
End Module

