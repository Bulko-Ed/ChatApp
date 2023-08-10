using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace ChatAppClient
{

    public partial class MessagesForm : Form
    {
        MyTcpClient client;
        NetworkStream stream;
        string client_name;

        public MessagesForm(string client_name)
        {
            InitializeComponent();
            this.client_name = client_name;
            client = new MyTcpClient();
            client.Connect("127.0.0.1", 5000);
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
            client.Close();
        }


        private async Task ListenToServer()
        {
            string clientname = null;
            while (true)
            {
                try
                {
                    var _buffer = new byte[1024];
                    var bytesRead = await stream.ReadAsync(_buffer, 0, _buffer.Length);
                    var message = Encoding.ASCII.GetString(_buffer, 0, bytesRead);
                    if (clientname == null)
                    {
                        clientname = message;
                        continue;
                    }
                    else
                    {
                        string m = $"{clientname} says {message}";
                        // label1.Text = m; // doesnt show the messge
                        label1.Invoke(() => label1.Text = "");
                        label1.Invoke(() => label1.Text = m);
                        clientname = null;
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
    }
    public class MyTcpClient : TcpClient
    {
        public string Name { get; set; }
    }
}