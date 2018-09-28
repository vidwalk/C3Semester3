using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Exercise4 {
    class Program {

        public class Server{
            public Server()
            {
            //Setting up the listener
            byte[] adr = { 127, 0, 0, 1 };
            IPAddress ipAdr = new IPAddress (adr);
            TcpListener newsock = new TcpListener (ipAdr, 12345);
            newsock.Start ();
            Console.WriteLine (Environment.MachineName);
            Console.WriteLine ("Waiting for a client...");
            // Stream open so it can receive a client
            while(0 == 0){
            TcpClient client = newsock.AcceptTcpClient ();
            NetworkStream ns = client.GetStream ();
            // Welcome the Client
            string welcome = "Welcome to the DNP test server";
            byte[] data = Encoding.ASCII.GetBytes (welcome);
            ns.Write (data, 0, data.Length);
            Console.WriteLine ("Sent: {0}", welcome);
            // Get the response from the Client
            data = new Byte[256];
            String responseData = String.Empty;
            Int32 bytes = ns.Read (data, 0, data.Length);
            responseData = System.Text.Encoding.ASCII.GetString (data, 0, bytes);
            Console.WriteLine ("Received: {0}", responseData);
            // Respond to the Client
            if(responseData != ""){
            string response = "\nResponse received";
            data = Encoding.ASCII.GetBytes (response);
            ns.Write (data, 0, data.Length);
            }
            }
            }
        }
        static void Main (string[] args) {
            
            Server server = new Server();
        }
    }
}