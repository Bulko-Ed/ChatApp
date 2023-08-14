using System.Net.Sockets;
using System.Text;
using System.Net;

namespace ChatAppClient
{
    public partial class MessagesForm : Form
    {
        public TcpClient client;
        public NetworkStream stream;
        string client_name;

        public MessagesForm(string client_name, TcpClient client)
        {
            InitializeComponent();
            this.client_name = client_name;
            this.client = client;
            stream = client.GetStream();
            Task task = ListenToServer();
            //Task.Run(() => { ListenToServer(); });
        }
        

        private void SendMessageButton_Click(object sender, EventArgs e)
        {
            string message = EnterMessageBox.Text;
            EnterMessageBox.Clear();
            var buffer = Encoding.ASCII.GetBytes(client_name);
            stream.Write(buffer, 0, buffer.Length);
            buffer = Encoding.ASCII.GetBytes(message);
            stream.Write(buffer, 0, buffer.Length);
        }

        private void Form1_Closing(object sender, FormClosingEventArgs e)
        {
            client.Close(); // TODO notify server
        }

        private void EnterMessageBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendMessageButton_Click(sender, e);
            }
        }


        private async Task ListenToServer()
        {
            string who = null;
            string clientname = null;
            while (true)
            {
                try
                {
                    var _buffer = new byte[1024];
                    var bytesRead = await stream.ReadAsync(_buffer, 0, _buffer.Length);
                    var message = Encoding.ASCII.GetString(_buffer, 0, bytesRead);
                    if (who == null)
                    {
                        who = message;
                        continue;
                    }
                    else if (who == "Client" && clientname == null)
                    {
                        clientname = message;
                        continue;
                    }
                    else if (who == "Client")
                    {
                        //to show clientname in bold font and time the message was sent
                        int start = rtb.TextLength;
                        rtb.Invoke(() =>
                        {
                            rtb.AppendText($"{clientname}");
                            rtb.Select(start, clientname.Length);
                            rtb.SelectionFont = new Font(rtb.Font, FontStyle.Bold);
                            rtb.Select(rtb.TextLength, 0); // to move insertion point to the end, because selectionfont starts with it
                            rtb.SelectionFont = new Font(rtb.Font, FontStyle.Regular);

                        });

                        string t = DateTime.Now.ToString("HH:mm:ss");
                        rtb.Invoke(() =>
                        {
                            rtb.AppendText($" at {t} \n");
                            rtb.AppendText($"{message} \n"); // TODO if string is bigger that window size, allow breaks in a message? 
                            rtb.AppendText($"{new string('-', 50)} \n"); // TODO set string to match window size
                        });

                        // to display the most recent messages
                        rtb.SelectionStart = rtb.TextLength;
                        rtb.Invoke(() => rtb.ScrollToCaret());
                        clientname = null;
                    }
                    else if (who == "Server" && message != null)
                    {
                        who = null; 
                        message = null;
                    }
                }
                catch
                {
                    client.Close();
                }
            }
        }

        private void EnterMessageBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void NameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}