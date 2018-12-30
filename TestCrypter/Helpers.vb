Public Class Helpers
     Public  Shared Function EncryptBase64(ByVal bytes() As Byte) As String
        Dim base64string as String = System.Convert.ToBase64String(bytes)
        Return base64string
     End Function
End Class
