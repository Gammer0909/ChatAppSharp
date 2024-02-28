using System;
using Gammer0909.ChatAppSharp.Logging;

namespace Gammer0909.ChatAppSharp;

public class Program {

    public static void Main(string[] args) {

        if (args.Length == 0) {
            Logger.Error("Please specify if you want to run the server or the client.");
            return;
        }

        if (args[0].ToLower() == "client") {
            Client();
        } else if (args[0].ToLower() == "server") {
            Server();
        } else {
            Logger.Error("Please specify if you want to run the server or the client.");
        }

    }

    private static void Client() {
        Client client = new Client();

        string? ip = null;
        int port = 0;

        while (true) {
            Console.Write("IP: ");
            ip = Console.ReadLine();

            if (ip != null) {
                break;
            }
        }

        while (true) {
            Console.Write("Port: ");
            string? portString = Console.ReadLine();

            if (portString != null && int.TryParse(portString, out port)) {
                break;
            }
        }

        while (true) {
            string? message = Console.ReadLine();

            if (message == null || message.ToLower() == "/exit" || message.ToLower() == "/quit") {
                break;
            }

            client.Send(message);
        }

    }

    private static void Server() {

        Server server = new Server();
        server.Start(2020, 2);

        while (true) {
            server.Recieve();

            // Get input
            string? input = Console.ReadLine();

            if (input == null || input.ToLower() == "/exit" || input.ToLower() == "/quit") {
                break;
            }

            // Send the message to all the clients
            // TODO

        }

        server.Stop();
    }

}