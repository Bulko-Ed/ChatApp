using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace ChatAppClient
{
    public partial class Form1 : Form
    {
        TcpClient client;
        public Form1()
        {
            InitializeComponent();
            client = new TcpClient();
            client.Connect("127.0.0.1", 5000);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string message = textBox1.Text;
            textBox1.Clear();
            var buffer = Encoding.ASCII.GetBytes(message);
            client.GetStream().Write(buffer, 0, buffer.Length);
        }

        private void Form1_Closing(object sender, FormClosingEventArgs e)
        {
            client.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}