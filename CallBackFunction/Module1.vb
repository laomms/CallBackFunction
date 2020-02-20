Imports ClassLibrary1

Module Module1

    Sub Main()
        Dim dll As New Class1()
        dll.SetAddCallBack(AddressOf Add) ' 设置回调
        dll.CallAdd() ' 触发回调
        Console.Read() ' 暂停程序
    End Sub
    Private Function Add(ByVal a As Integer, ByVal b As Integer) As Integer
        Dim c As Integer = a + b
        Console.WriteLine("Add被调用了，a+b={0}", c)
        Return c
    End Function

End Module
