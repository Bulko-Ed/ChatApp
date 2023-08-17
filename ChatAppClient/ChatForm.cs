using System.Net.Sockets;
using System.Text;

namespace ChatAppClient
{
    public partial class ChatForm : Form
    {
        private TcpClient client;
        private NetworkStream stream;
        private string client_name;

        public ChatForm(string client_name, TcpClient client)
        {
            InitializeComponent();
            this.client_name = client_name;
            this.client = client;
            this.stream = client.GetStream();
            _ = ListenToServer();
            Send("ToServer", client_name, "Join");
        }
        private void SendMessageButton_Click(object sender, EventArgs e)
        { 
            if (!string.IsNullOrEmpty(EnterMessageBox.Text))
            {
                Send("ToClients", client_name, EnterMessageBox.Text);
                EnterMessageBox.Clear();
            }     
        }

        private void Form1_Closing(object sender, FormClosingEventArgs e)
        {
            if (client.Connected)
            {
                Send("ToServer", client_name, "Closing");
                client.Close();
                
            }
            Application.Exit();
            Environment.Exit(0);
        }
        public void Send(string where, string clientname, string message)
        {
            string m = where + clientname + "\n" + message; // m = ToServerClientname\nMessage
            var buffer = Encoding.ASCII.GetBytes(m);
            try
            {
            stream.Write(buffer, 0, buffer.Length);
            }
            catch (IOException)
            {
                client.Close();
                Form1_Closing(null, null);
            }
        }

        private async Task ListenToServer()
        {
            while (true)
            {
                try
                {
                    var _buffer = new byte[3024];
                    var bytesRead = await stream.ReadAsync(_buffer, 0, _buffer.Length);
                    if (bytesRead == 0) { client.Close(); Close(); }
                    var data = Encoding.ASCII.GetString(_buffer, 0, bytesRead);
                    // data = Server\nServerMessage or Client\nClientName\nClientMessage
                    if (data[..6] == "Server")
                    {
                        ProcessServerMessage(data[6..]);
                    }
                    else if (data[..6] == "Client")
                    {
                        ProcessClientMessage(data[7..]);
                    }
                }
                catch //  user close server without pressing q
                {
                    client.Close();
                    Close();
                }
            }
        }
        private void ProcessClientMessage(string data)
        {
            string sendername = null;
            string message = null;
            bool senderNamePart = true;
            foreach (char c in data)
            {
                if (c == '\n' && senderNamePart)
                {
                    senderNamePart = false;
                }
                else if (senderNamePart)
                {
                    sendername += c;
                }
                else
                {
                    message += c;
                }
            }
            ShowClientMessage(sendername, message);
        }
        private void ShowName(string name)
        {
            int start = rtb.TextLength;
            rtb.Invoke(() =>
            {
                rtb.AppendText($"{name}");
                rtb.Select(start, name.Length);
                rtb.SelectionFont = new Font(rtb.Font, FontStyle.Bold);
                rtb.Select(rtb.TextLength, 0); // to move insertion point to the end, because selectionfont starts with it
                rtb.SelectionFont = new Font(rtb.Font, FontStyle.Regular);

            });
        }
        private void ShowTime()
        {
            string t = DateTime.Now.ToString("HH:mm:ss");
            rtb.Invoke(() => { rtb.AppendText($" at {t} \n"); });
        }
        private void JoinLeftMessage(string joinleft, string name)
        {
            ShowName(name);
            rtb.Invoke(() => { rtb.AppendText($" has {joinleft} a chat\n"); });
            rtb.AppendText($"{new string('-', 70)} \n");
        }
        private void ShowClientMessage(string sendername, string message)
        {
            ShowName(sendername);
            ShowTime();
            
            rtb.Invoke(() =>
            {
                rtb.AppendText($"{message} \n"); 
                rtb.AppendText($"{new string('-', 70)} \n"); 
            });

            // to display the most recent messages
            rtb.SelectionStart = rtb.TextLength;
            rtb.Invoke(() => rtb.ScrollToCaret());
            message = null;
            sendername = null;

        }
        private void ProcessServerMessage(string message)
        {
            if (message == "ShuttingDown")
            {
                MessageBox.Show("server is closing, you will be disconnected");
                client.Close();
                Close();
            }
            else if (message[..4] == "Join")
            {
                JoinLeftMessage("joined", message[4..]);
            }
            else if (message[..4] == "Left")
            {
                JoinLeftMessage("left", message[4..]);
            }
        }
        private void EnterMessageBox_TextChanged(object sender, EventArgs e) { }
        private void NameBox_TextChanged(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void richTextBox1_TextChanged(object sender, EventArgs e) { }
        private void MessagesForm_Resize(object sender, EventArgs e) { }
    }
}