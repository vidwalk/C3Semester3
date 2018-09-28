﻿using System;
using System.Net;
using System.Net.Sockets;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a TcpClient.
    // Note, for this client to work you need to have a TcpServer 
    // connected to the same address as specified by the server, port
    // combination.
    Int32 port = 12345;
    TcpClient client = new TcpClient("127.0.0.1", port);

    // Translate the passed message into ASCII and store it as a Byte array.
    String message = "I am connected to you";
    Byte[] data = System.Text.Encoding.ASCII.GetBytes(message);         

    // Get a client stream for reading and writing.
   //  Stream stream = client.GetStream();
    
    NetworkStream stream = client.GetStream();

    // Send the message to the connected TcpServer. 
    stream.Write(data, 0, data.Length);

    Console.WriteLine("Sent: {0}", message);         

    // Receive the TcpServer.response.
    
    // Buffer to store the response bytes.
    data = new Byte[256];

    // String to store the response ASCII representation.
    String responseData = String.Empty;

    // Read the first batch of the TcpServer response bytes.
    Int32 bytes = stream.Read(data, 0, data.Length);
    responseData = System.Text.Encoding.ASCII.GetString(data, 0, bytes);
    Console.WriteLine("Received: {0}", responseData);         

    // Close everything.       
    client.Close(); 
        }
    }
}
