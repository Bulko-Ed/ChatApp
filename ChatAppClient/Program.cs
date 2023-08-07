namespace ChatAppClient
{
    using System;
    //using System.Net.Sockets;
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}