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

            TcpClient client = listener.AcceptTcpClient(); //will wait until there is an incoming connection request
            NetworkStream stream = client.GetStream();
            var buffer = new byte[1024];

            while (true)
            {
                var bytesRead = stream.Read(buffer, 0, buffer.Length);
                var message = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                Console.WriteLine(message);
                
            }
        }
    }
}
