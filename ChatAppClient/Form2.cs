using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;


namespace ChatAppClient
{
    public partial class CredentialsForm : Form
    {
        public string name;
        public TcpClient client;
        public IPAddress IP;
        public int port = -1;
        public CredentialsForm()
        {
            InitializeComponent();
            NameBox.Hide();
        }

        private void NameBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bool valid_name = ValidateName(NameBox.Text);
                if (valid_name)
                {
                    this.name = NameBox.Text;
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    NameBox.Clear();
                    MessageBox.Show("Invalid name, try again");
                }
            }
        }
        private bool ValidateName(string name)
        {
            return (name != null && name != "invalid name");
        }
        private void IPBox_KeyDown(Object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!ValidIP()) { return; }
                if (ValidPort()) { TryConnect(IP, port); }
            }
        }
        private void PortBox_KeyDown(Object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!ValidPort()) { return; }
                if (ValidIP()) { TryConnect(IP, port); }
            }
        }
        private bool ValidIP()
        {   
            string _IP = IPBox.Text;    
            if (string.IsNullOrEmpty(_IP)) { return false; }
            try
            {
                IP = IPAddress.Parse(_IP); 
                return true;
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid IP, try again.");
                return false;
            }
        }

        private bool ValidPort()
        {
            string _port = PortBox.Text;
            if (string.IsNullOrEmpty(_port)) {  return false; }
            try
            {
                port = int.Parse(_port);
                return true; // дойдет ли досюда если порт инвэлид 

            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid port, try again.");
                return false;
            }
        }
        private void TryConnect(IPAddress IP, int port)
        {
            try
            {
                TcpClient client = new TcpClient();
                client.Connect(IP, port);
                Stream stream = client.GetStream();
                var _buffer = new byte[1024];
                var bytesRead = stream.Read(_buffer, 0, _buffer.Length);
                string sender = Encoding.ASCII.GetString(_buffer, 0, bytesRead);
                _buffer = new byte[1024];
                bytesRead = stream.Read(_buffer, 0, _buffer.Length);
                string message = Encoding.ASCII.GetString(_buffer, 0, bytesRead);
                if (sender == "Server" && message == "ClientAccepted")
                {
                    MessageBox.Show("connection successful");
                    IPBox.Clear();
                    PortBox.Clear();
                    NameBox.Show();
                    this.client = client;
                }
                else
                {
                    MessageBox.Show("Try again.");

                }

            }

            catch (SocketException)
            {
                MessageBox.Show("Failed to connect. The server may not be listening.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("oops");
            }

        }
        private void NameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CredentialsForm_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
