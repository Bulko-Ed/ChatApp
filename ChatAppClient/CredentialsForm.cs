using System.IO;
using System.Net; // for IP address
using System.Net.Sockets; // for TcpClient
using System.Text; // for Encoding


namespace ChatAppClient
{
    public partial class CredentialsForm : Form
    {
        public string name = null;
        public TcpClient client;
        private IPAddress IP;
        private int port = -1;
        private string taken_names = null;
        public CredentialsForm()
        {
            InitializeComponent();
            NameBox.Hide();
        }

        private void NameBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (NameBox.Text == "")
                {
                    MessageBox.Show("Your name must contain at least one character.");
                    return;
                }
                else
                {
                    if (!taken_names.Contains(NameBox.Text))
                    {
                        name = NameBox.Text;
                        DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("This name is already taken, try again.");
                        NameBox.Clear();
                    }
                }
            }
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
                return true;

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
                client = new TcpClient();
                client.Connect(IP, port);

                if (ConnectionConfirmed())
                { 
                    IPlabel.Hide();
                    PortNumberLabel.Hide();
                    IPBox.Hide();
                    PortBox.Hide();
                    enterIPlabel.Hide();
                    NameBox.Show();
                }
                else
                {
                    MessageBox.Show("Try again.");
                    IP = null;
                    port = -1;
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
        private bool ConnectionConfirmed()
        {
            var buffer = new byte[1024];
            var bytesRead = client.GetStream().Read(buffer, 0, buffer.Length);
            string message = Encoding.ASCII.GetString(buffer, 0, bytesRead);

            if (message[..6] == "Server" && message[6..20] == "ClientAccepted")
            {
                taken_names = message[20..];
                MessageBox.Show("connection successful");
                return true;
            }
            return false;
        }

        private void CredentialsForm_Resize(object sender, EventArgs e)
        {
            float font_size_1 = Height / 30;
            float font_size_2 = Height / 50;
            float font_size_3 = Height / 60;

            WelcomeLabel.Font = new Font(WelcomeLabel.Font.FontFamily, font_size_1);
            enterIPlabel.Font = new Font(Font.FontFamily, font_size_2);
            PortNumberLabel.Font = new Font(Font.FontFamily, font_size_3);
            IPlabel.Font = new Font(Font.FontFamily, font_size_3);

        }
        private void NameBox_Enter(object sender, EventArgs e)
        {
            NameBox.Text = string.Empty;
        }

        private void label1_Click_1(object sender, EventArgs e) { }
        private void PortBox_TextChanged(object sender, EventArgs e) { }
        private void NameBox_TextChanged(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void CredentialsForm_Load(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void IPBox_TextChanged(object sender, EventArgs e) { }
    }
}
