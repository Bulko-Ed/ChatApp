namespace ChatAppClient
{
    public partial class CredentialsForm : Form
    {
        public string name;
        public CredentialsForm()
        {
            InitializeComponent();
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
            if (name == null || name == "invalid name")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void NameBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
