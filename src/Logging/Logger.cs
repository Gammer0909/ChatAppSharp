using System;

namespace Gammer0909.ChatAppSharp.Logging;

// Just a simple solution for color in the console before I port it to Spectre.Console
public static class Logger {

    public static void Warn(string message) {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("[WARNING]: " + message);
        Console.ResetColor();
    }

    public static void Error(string message) {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("[ERROR]: " + message);
        Console.ResetColor();
    }

    public static void Info(string message) {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("[INFO]: " + message);
        Console.ResetColor();
    }

    public static void Success(string message) {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("[SUCCESS]: " + message);
        Console.ResetColor();
    }

    public static void Debug(string message) {
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("[DEBUG]: " + message);
        Console.ResetColor();
    }

    public static void Log(string message) {
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("[LOG]: " + message);
        Console.ResetColor();
    }

    public static void Server(string message) {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("[SERVER]: " + message);
        Console.ResetColor();
    }

    public static void Client(string message) {
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("[CLIENT]: " + message);
        Console.ResetColor();
    }

}