using System;
using System.Net;
using System.Net.Sockets;
using Gammer0909.ChatAppSharp.Logging;

namespace Gammer0909.ChatAppSharp;

public class Server {

    private Socket serverSocket;

    public Server() {
        this.serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
    }

    public void Start(int port, int maxConnections) {

        this.serverSocket.Bind(new IPEndPoint(IPAddress.Any, port));
        this.serverSocket.Listen(maxConnections);

        Logger.Success($"Server started on port {port}, and any IP address.");
        Logger.Info($"Maximum connections: {maxConnections}");
        Logger.Server("Waiting for connections...");

        Socket clientSocket = this.serverSocket.Accept();

        Logger.Server($"Client connected: {clientSocket.RemoteEndPoint}");

        byte[] buffer = new byte[1024];
        int received = clientSocket.Receive(buffer);
        byte[] data = new byte[received];
        Array.Copy(buffer, data, received);
        string message = System.Text.Encoding.UTF8.GetString(data);

        Logger.Client($"Received message: {message}");

    }

    public void Recieve() {

        

    }

    public void Stop() {
        this.serverSocket.Close();
        Logger.Warn("Server stopped.");
    }

}