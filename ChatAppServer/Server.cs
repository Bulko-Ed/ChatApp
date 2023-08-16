namespace ChatAppServer
{
    using System;
    using System.Net.Sockets;
    using System.Net; // for ip address.any
    using System.Text; // for encoding
    class Program
    {
        static List<TcpClient> clients = new List<TcpClient>();
        static List<string> client_names = new List<string>();
        static void Main(string[] args)
        {
            TcpListener listener = new TcpListener(IPAddress.Any, 5000);
            listener.Start();
            Task task = AcceptNewClients(listener);
            Console.WriteLine("Press q to close the server");
            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.Q)
                {
                    break;
                }
            }
            NotifyAndClose();
        }
        private static async Task AcceptNewClients(TcpListener listener)
        {
            while (true)
            {
                TcpClient client = await listener.AcceptTcpClientAsync(); //will wait until there is an incoming connection request (why async task then?)
                if (client.Connected == true)
                {
                    SendMessageAsServer(client, "ClientAccepted");
                    Thread thread = new Thread(new ParameterizedThreadStart(ListenToClient));
                    thread.Start(client);
                    clients.Add(client);
                }
            }
        }

        static void ListenToClient(object _client) // object because of listen to clients in thread declaration
        {
            TcpClient client = (TcpClient)_client;
            NetworkStream stream = client.GetStream();

            var buffer = new byte[1024];

            while (true)
            {
                var bytesRead = stream.Read(buffer, 0, buffer.Length);
                var message = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                if (message[..8] == "ToServer")
                {
                    ProcessMessageToServer(client, message[9..]);
                }
                else if (message[..9] == "ToClients") //"ToClients" + client_name + "\n" + EnterMessageBox.Text;
                {
                    SendMessageToClients(message[9..]);
                    Console.WriteLine($"{message[9..]}");
                    Console.WriteLine(new string('-', 50));
                }

            }
        }

        static void SendMessageToClients(string _message) // _message = client_name + "\n" + EnterMessageBox.Text
        {

            foreach (TcpClient client in clients)
            {
                string message = "Client" + "\n" + _message;
                NetworkStream ns = client.GetStream();
                var buffer = Encoding.ASCII.GetBytes(message);
                ns.Write(buffer, 0, buffer.Length);
            }
        }
        static void SendMessageAsServer(TcpClient client, string _message)
        {
            string message = "Server" + _message;
            Send(client, message);
        }

        static void ProcessMessageToServer(TcpClient client, string _message) //client_name + "\n" + "Closing"
        {
            bool isName = true;
            string name = null;
            string message = null;

            foreach (char c in _message)
            {
                if (c == '\n')
                {
                    isName = false;
                }
                else if (isName)
                {
                    name += c;
                }
                else
                {
                    message += c;
                }
            } /*
            if (_message == "Closing")
            {
                clients.Remove(client);
                client_names.Remove(name);
                client.Dispose();
            }
            */
        }


        static void Send(TcpClient client, string m) // what can be Sender, SenderName and Message
        {
            NetworkStream stream = client.GetStream();
            var buffer = Encoding.ASCII.GetBytes(m);
            stream.Write(buffer, 0, buffer.Length);
        }

        static void NotifyAndClose()
        {
            foreach (var client in clients)
            {
                SendMessageAsServer(client, "ShuttingDown");
                //todo : close the progra,
            }
            Environment.Exit(0);
        }
        enum ServerMessages
        {
            ShuttingDown,
            ClientAccepted
        }

        enum Senders
        {
            Client, 
            Server
        }
    }
}
