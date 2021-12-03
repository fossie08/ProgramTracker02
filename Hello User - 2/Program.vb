'
' Created by SharpDevelop.
' User: 19ofoster
' Date: 08/10/2021
' Time: 10:58
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Module Program
	Sub Main()
		'Dimesions a variabe as name
		Dim name As String=""
		
		'Gets the user to input their name
		Console.WriteLine("Please enter your name . . . ")
		name = Console.ReadLine()
		
		'Outputs the answer to the user
		Console.WriteLine("Hello, " & name)
		
		
		Console.Write("Press any key to continue . . . ")
		Console.ReadKey(True)
	End Sub
End Module
