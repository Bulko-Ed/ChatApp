namespace ChatAppServer
{
    using System;
    using System.Net.Sockets;
    using System.Net; // for ip address.any
    using System.Text;

    class Program
    {
        static void Main(string[] args)
        {
            TcpListener listener = new TcpListener(IPAddress.Any, 5000);
            listener.Start();

            ListenToClients(listener);
        }
        
        static void ListenToClients(TcpListener listener)
        {                                   
            TcpClient client = listener.AcceptTcpClient(); //will wait until there is an incoming connection request
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
                    SendMesssage(client, clientname, message);
                    clientname = null;
                }
            }
        }
        static void SendMesssage(TcpClient client, string sender_name, string message)
        {
            NetworkStream _stream = client.GetStream();
            var buffer = Encoding.ASCII.GetBytes(sender_name);
            _stream.Write(buffer, 0, buffer.Length);
            Console.WriteLine(sender_name);
            buffer = Encoding.ASCII.GetBytes(message);
            _stream.Write(buffer, 0, buffer.Length);
            Console.WriteLine(message);


        }
    }
}
