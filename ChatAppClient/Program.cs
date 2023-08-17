using System;

namespace ChatAppClient
{
    internal static class Program
    {
        [STAThread]
        
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            CredentialsForm credentialsForm = new CredentialsForm();

            if (credentialsForm.ShowDialog() == DialogResult.OK)
            {
                ChatForm messagesForm = new ChatForm(credentialsForm.name, credentialsForm.client);
                Application.Run(messagesForm);
            } 
        }
    }
}