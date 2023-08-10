namespace ChatAppClient
{
    using System;

    internal static class Program
    {
        [STAThread]
        
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            CredentialsForm credentialsForm = new CredentialsForm();
            //Application.Run(credentialsForm);

            string login;
            if (credentialsForm.ShowDialog() == DialogResult.OK)
            {
                login = credentialsForm.name;
                credentialsForm.Close();
                MessagesForm messagesForm = new MessagesForm(login);
                Application.Run(messagesForm);
            } 
            else
            {
                return;
            }
        }
    }
}