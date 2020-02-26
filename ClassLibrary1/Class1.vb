Public Class Class1



	Public Delegate Sub DGetResult(szRes As String)
	Public Shared GetResult As DGetResult = Nothing ' 此处相当于定义函数指针了
	' 设置回调函数地址
	Public Shared Sub GetResultCallBack(ByVal GetResultFunc As DGetResult)
		GetResult = GetResultFunc
	End Sub

	' 调用回调函数
	Public Shared Sub CallGetResult(szRes As String)
		CallGetResults(szRes)
	End Sub

End Class
