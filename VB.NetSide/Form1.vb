Imports System
Imports System.Net
Imports System.Net.Sockets
Imports System.Threading
Imports System.Text


Public Class Form1

	Private client As AsynchronousClient = Nothing
	Private address As IPAddress = Nothing

	Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
	End Sub

	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles connect.Click


		If (ipAddress.Text IsNot "") Then
			If (System.Net.IPAddress.TryParse(ipAddress.Text, address)) Then
				If (IsNothing(client)) Then
					client = New AsynchronousClient(SocketType.Stream, ProtocolType.Tcp)
				End If
				client.Connect(address, port.Value)
				AddHandler client.ReceivedData, AddressOf onRecievedData
				AddHandler client.Loged, AddressOf onLogEvent
			End If
		End If
	End Sub

	Private Sub onLogEvent(message As String)
		Me.BeginInvoke(Sub() recievedDataList.Text += message)
	End Sub

	Private Sub onRecievedData(data As String)
		Me.BeginInvoke(Sub() recievedDataList.Text += data)
	End Sub

	Private Sub SendData_Click(sender As Object, e As EventArgs) Handles sendData.Click
		Dim dataInt As Int32 = data.Value
		client.Send(dataInt.ToString())
	End Sub
End Class

' State object for receiving data from remote device.  
Public Class StateObject

	' Client socket.  
	Public workSocket As Socket = Nothing

	' Size of receive buffer.  
	Public Const BufferSize As Integer = 256

	' Receive buffer.  
	Public buffer() As Byte = New Byte((BufferSize) - 1) {}

	' Received data string.  
	Public sb As StringBuilder = New StringBuilder
End Class

Public Class AsynchronousClient

	' ManualResetEvent instances signal completion.  
	Public connectDone As ManualResetEvent = New ManualResetEvent(False)

	Public sendDone As ManualResetEvent = New ManualResetEvent(False)

	Public receiveDone As ManualResetEvent = New ManualResetEvent(False)


	' The response from the remote device.  
	Public response As String = String.Empty

	Private client As Socket = Nothing

	Public Event ReceivedData(data As String)
	Public Event Loged(message As String)

	Public Sub New(socketType As SocketType, protocolType As ProtocolType)
		client = New Socket(socketType, protocolType)

	End Sub

	Private Sub ConnectCallback(ByVal ar As IAsyncResult)
		Try
			' Retrieve the socket from the state object.  
			Dim client As Socket = CType(ar.AsyncState, Socket)
			' Complete the connection.  
			client.EndConnect(ar)
			RaiseEvent Loged("Socket connected to " + client.RemoteEndPoint.ToString())
			' Signal that the connection has been made.  
			connectDone.Set()
			Receive(client)
		Catch e As Exception
			RaiseEvent Loged(e.ToString)
		End Try

	End Sub

	Private Sub Receive(ByVal client As Socket)
		Try
			' Create the state object.  
			Dim state As StateObject = New StateObject
			state.workSocket = client
			' Begin receiving the data from the remote device.  
			client.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0, New AsyncCallback(AddressOf ReceiveCallback), state)
		Catch e As Exception
			RaiseEvent Loged(e.ToString)
		End Try

	End Sub

	Private Sub ReceiveCallback(ByVal ar As IAsyncResult)
		Try
			' Retrieve the state object and the client socket   
			' from the asynchronous state object.  
			Dim state As StateObject = CType(ar.AsyncState, StateObject)
			Dim client As Socket = state.workSocket
			' Read data from the remote device.  
			Dim bytesRead As Integer = client.EndReceive(ar)
			If (bytesRead > 0) Then
				' There might be more data, so store the data received so far.
				Dim str As String = Encoding.ASCII.GetString(state.buffer, 0, bytesRead)
				state.sb.Append(str)
				' Get the rest of the data.  

				If (str.Length > 1) Then
					RaiseEvent ReceivedData(str)
				End If

				' Signal that all bytes have been received.  
				receiveDone.Set()
				client.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0, New AsyncCallback(AddressOf ReceiveCallback), state)
			Else
				' All the data has arrived; put it in response.  
				' Must change strategye to best detect packet 
			End If

		Catch e As Exception
			RaiseEvent Loged(e.ToString)
		End Try

	End Sub

	Private Sub Send(ByVal client As Socket, ByVal data As String)
		' Convert the string data to byte data using ASCII encoding.  
		Dim byteData() As Byte = Encoding.ASCII.GetBytes(data)
		' Begin sending the data to the remote device.  
		client.BeginSend(byteData, 0, byteData.Length, 0, New AsyncCallback(AddressOf SendCallback), client)
	End Sub

	Private Sub SendCallback(ByVal ar As IAsyncResult)
		Try
			' Retrieve the socket from the state object.  
			Dim client As Socket = CType(ar.AsyncState, Socket)
			' Complete sending the data to the remote device.  
			Dim bytesSent As Integer = client.EndSend(ar)
			RaiseEvent Loged("Sent " + bytesSent.ToString() + " bytes to server.")
			' Signal that all bytes have been sent.  
			sendDone.Set()
		Catch e As Exception
			Console.WriteLine(e.ToString)
		End Try

	End Sub

	Public Sub Connect(ipAddress As IPAddress, port As Int32)
		client.BeginConnect(ipAddress, port, New AsyncCallback(AddressOf ConnectCallback), client)
	End Sub

	Public Sub Send(ByVal data As String)
		' Convert the string data to byte data using ASCII encoding.  
		Dim byteData() As Byte = Encoding.ASCII.GetBytes(data & vbLf)
		' Begin sending the data to the remote device.  
		'client.BeginSend(byteData, 0, byteData.Length, 0, New AsyncCallback(AddressOf SendCallback), client)
		client.Send(byteData)
	End Sub
End Class

