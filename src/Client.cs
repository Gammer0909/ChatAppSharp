using System;
using System.Net;
using System.Net.Sockets;
using Gammer0909.ChatAppSharp.Logging;

namespace Gammer0909.ChatAppSharp;

public class Client {

    private Socket clientSocket;

    public Client() {
        this.clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
    }

    public void Connect(string ip, int port) {
        try {
            this.clientSocket.Connect(new IPEndPoint(IPAddress.Parse(ip), port));
            Logger.Success("Connected to the server.");
        } catch (Exception e) {
            Logger.Error($"Failed to connect to the server: {e.Message}");
        }
    }

    public void Send(string message) {
        try {
            byte[] buffer = System.Text.Encoding.UTF8.GetBytes(message);
            this.clientSocket.Send(buffer);
        } catch (Exception e) {
            Logger.Error($"Failed to send message to the server: {e.Message}");
        }
    }

}