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
        public string taken_names = null;
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

                    if (NameBox.Text == null)
                    {
                        MessageBox.Show("Your name must contain at least one character");
                    }
                    else
                    {
                        MessageBox.Show("This name is taken, try again");
                    }
                    NameBox.Clear();
                }
            }
        }
        private bool ValidateName(string name)
        {

            if (name != null && name != "invalid name")
            {
                if (!taken_names.Contains(name))
                {
                    return true;
                }
            }
            return false;
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
            if (string.IsNullOrEmpty(_port)) { return false; }
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
                string message = Encoding.ASCII.GetString(_buffer, 0, bytesRead);

                if (message[..6] == "Server" && message[6..20] == "ClientAccepted")
                {
                    taken_names = message[20..];
                    MessageBox.Show("connection successful");
                    IPBox.Clear();
                    PortBox.Clear();
                    IPlabel.Hide();
                    PortNumberLabel.Hide();
                    IPBox.Hide();
                    PortBox.Hide();
                    enterIPlabel.Hide();
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
                MessageBox.Show("oops, something went wrong");
            }

        }
        private void NameBox_TextChanged(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void CredentialsForm_Load(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void IPBox_TextChanged(object sender, EventArgs e) { }
        private void NameBox_Enter(object sender, EventArgs e)
        {
            NameBox.Text = string.Empty;
        }

        private void CredentialsForm_Resize(object sender, EventArgs e)
        {
            float font_size_1 = Height / 30;
            float font_size_2 = Height / 50;
            float font_size_3 = Height / 60;

            //font_size = Math.Max(font_size, 10);
            WelcomeLabel.Font = new Font(WelcomeLabel.Font.FontFamily, font_size_1);
            enterIPlabel.Font = new Font(Font.FontFamily, font_size_2);
            PortNumberLabel.Font = new Font(Font.FontFamily, font_size_3);
            IPlabel.Font = new Font(Font.FontFamily, font_size_3);

        }
        private void label1_Click_1(object sender, EventArgs e) { }

        private void PortBox_TextChanged(object sender, EventArgs e) { }
    }
}
