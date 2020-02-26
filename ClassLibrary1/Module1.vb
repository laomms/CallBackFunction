Module Module1
	Public Sub CallGetResults(szRes As String)
		If Class1.GetResult IsNot Nothing Then
			szRes = "123456"
			Class1.GetResult(szRes)
			Class1.GetResult("b")
			Class1.GetResult("c")
		End If
	End Sub

End Module
