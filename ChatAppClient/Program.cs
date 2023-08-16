namespace ChatAppClient
{
    using System;
    using System.IO;
    using System.Net.Sockets;
    using System.Text;

    internal static class Program
    {
        [STAThread]
        
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            CredentialsForm credentialsForm = new CredentialsForm();
            string login;
            TcpClient client;

            if (credentialsForm.ShowDialog() == DialogResult.OK)
            {
                login = credentialsForm.name;
                client = credentialsForm.client;
                MessagesForm messagesForm = new MessagesForm(login, client);
                //credentialsForm.Close();
                Application.Run(messagesForm);
            } 
            else
            {
                return;
            }
        }
        public static void Send(TcpClient client, string towhom, string clientname, string message)
        {
            string m = towhom + clientname + "\n" + message;
            var buffer = Encoding.ASCII.GetBytes(m);
            client.GetStream().Write(buffer, 0, buffer.Length);

        }
    }
}