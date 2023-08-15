namespace ChatAppClient
{
    using System;
    using System.Net.Sockets;

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
    }
}