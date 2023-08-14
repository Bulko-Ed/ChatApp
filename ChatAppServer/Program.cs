namespace ChatAppServer
{
    using System;
    using System.Net.Sockets;
    using System.Net; // for ip address.any
    using System.Text; // for encoding
    

    class Program
    {   
        static List<TcpClient> clients = new List<TcpClient>();
        static void Main(string[] args)
        {
            TcpListener listener = new TcpListener(IPAddress.Any, 5000);
            listener.Start();
            Task task = AcceptNewClients(listener);
            

        }
        private static async Task AcceptNewClients(TcpListener listener)
        {
            while (true)
            {
                TcpClient client = listener.AcceptTcpClient(); //will wait until there is an incoming connection request (why async task then?)
                if (client.Connected == true)
                {
                    SendMesssage(client, Senders.Server, null, ServerMessages.ClientAccepted.ToString());
                    clients.Add(client);
                    ListenToClients(clients.First());
                }
            }
        }
        
        static void ListenToClients(TcpClient client)
        {                                   
            NetworkStream stream = client.GetStream();

            var buffer = new byte[1024];
            string clientname = null;

            while (true)
            {
                var bytesRead = stream.Read(buffer, 0, buffer.Length);
                var message = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                if (clientname == null)
                {
                    clientname = message;
                    continue;
                }
                if (message.Length != 0) // terrible if condition
                {
                    Console.WriteLine($"{clientname} says {message}");
                    SendMesssage(client, Senders.Client, clientname, message);
                    clientname = null;
                }
            }
        }
        static void SendMesssage(TcpClient client, Senders sender, string? sender_name, string message)
        {   
                NetworkStream _stream = client.GetStream();

                var buffer = Encoding.ASCII.GetBytes(sender.ToString());
                _stream.Write(buffer, 0, buffer.Length);
                if (sender is Senders.Client)
                {
                    buffer = Encoding.ASCII.GetBytes(sender_name);
                    _stream.Write(buffer, 0, buffer.Length); // WRONG ORDER FOR ACCEPTING CLIENTD AND WRITING NORMAL MESSAGES
                }
                buffer = Encoding.ASCII.GetBytes(message);
                _stream.Write(buffer, 0, buffer.Length);

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
