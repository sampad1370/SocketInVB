
public enum ProtocolType
{
    Tcp,Udp

};

private static void DisconnectCallback(IAsyncResult ar)
{
    ProtocolType i;
    if (i == ProtocolType.Tcp)
        i= ProtocolType.Udp;
}