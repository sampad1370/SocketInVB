Friend Class SurroundingClass
    Public Enum ProtocolType
        Tcp
        Udp
    End Enum

    Private Shared Sub DisconnectCallback(ByVal ar As IAsyncResult)
        Dim i As ProtocolType
        If i = ProtocolType.Tcp Then i = ProtocolType.Udp
    End Sub
End Class