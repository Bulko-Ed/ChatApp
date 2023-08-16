namespace ChatAppClient
{
    partial class CredentialsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            NameBox = new TextBox();
            WelcomeLabel = new Label();
            enterIPlabel = new Label();
            IPlabel = new Label();
            PortNumberLabel = new Label();
            IPBox = new TextBox();
            PortBox = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // NameBox
            // 
            tableLayoutPanel1.SetColumnSpan(NameBox, 3);
            NameBox.Location = new Point(351, 227);
            NameBox.Name = "NameBox";
            NameBox.Size = new Size(173, 27);
            NameBox.TabIndex = 0;
            NameBox.Text = "Enter your name";
            NameBox.TextChanged += NameBox_TextChanged;
            NameBox.Enter += NameBox_Enter;
            NameBox.KeyDown += NameBox_KeyDown;
            // 
            // WelcomeLabel
            // 
            WelcomeLabel.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(WelcomeLabel, 7);
            WelcomeLabel.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            WelcomeLabel.Location = new Point(264, 112);
            WelcomeLabel.Name = "WelcomeLabel";
            tableLayoutPanel1.SetRowSpan(WelcomeLabel, 2);
            WelcomeLabel.Size = new Size(419, 50);
            WelcomeLabel.TabIndex = 1;
            WelcomeLabel.Text = " Welcome to chat room!";
            WelcomeLabel.Click += label1_Click;
            // 
            // enterIPlabel
            // 
            enterIPlabel.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(enterIPlabel, 5);
            enterIPlabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            enterIPlabel.Location = new Point(264, 280);
            enterIPlabel.Name = "enterIPlabel";
            enterIPlabel.Size = new Size(371, 28);
            enterIPlabel.TabIndex = 2;
            enterIPlabel.Text = "Please, enter IP address and port number.";
            enterIPlabel.Click += label1_Click_1;
            // 
            // IPlabel
            // 
            IPlabel.AutoSize = true;
            IPlabel.Location = new Point(264, 336);
            IPlabel.Name = "IPlabel";
            IPlabel.Size = new Size(76, 20);
            IPlabel.TabIndex = 3;
            IPlabel.Text = "IP address";
            IPlabel.Click += label2_Click;
            // 
            // PortNumberLabel
            // 
            PortNumberLabel.AutoSize = true;
            PortNumberLabel.Location = new Point(264, 392);
            PortNumberLabel.Name = "PortNumberLabel";
            PortNumberLabel.Size = new Size(60, 40);
            PortNumberLabel.TabIndex = 4;
            PortNumberLabel.Text = "Port number";
            // 
            // IPBox
            // 
            tableLayoutPanel1.SetColumnSpan(IPBox, 2);
            IPBox.Location = new Point(351, 339);
            IPBox.Name = "IPBox";
            IPBox.Size = new Size(158, 27);
            IPBox.TabIndex = 5;
            IPBox.TextChanged += IPBox_TextChanged;
            IPBox.KeyDown += IPBox_KeyDown;
            // 
            // PortBox
            // 
            tableLayoutPanel1.SetColumnSpan(PortBox, 2);
            PortBox.Location = new Point(351, 395);
            PortBox.Name = "PortBox";
            PortBox.Size = new Size(161, 27);
            PortBox.TabIndex = 6;
            PortBox.TextChanged += PortBox_TextChanged;
            PortBox.KeyDown += PortBox_KeyDown;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 10;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.Controls.Add(WelcomeLabel, 3, 2);
            tableLayoutPanel1.Controls.Add(PortNumberLabel, 3, 7);
            tableLayoutPanel1.Controls.Add(PortBox, 4, 7);
            tableLayoutPanel1.Controls.Add(IPlabel, 3, 6);
            tableLayoutPanel1.Controls.Add(IPBox, 4, 6);
            tableLayoutPanel1.Controls.Add(enterIPlabel, 3, 5);
            tableLayoutPanel1.Controls.Add(NameBox, 4, 4);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 10;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(876, 565);
            tableLayoutPanel1.TabIndex = 7;
            // 
            // CredentialsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(876, 565);
            Controls.Add(tableLayoutPanel1);
            Name = "CredentialsForm";
            Text = "Chat room";
            Load += CredentialsForm_Load;
            Resize += CredentialsForm_Resize;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox NameBox;
        private Label WelcomeLabel;
        private Label enterIPlabel;
        private Label IPlabel;
        private Label PortNumberLabel;
        private TextBox IPBox;
        private TextBox PortBox;
        private TableLayoutPanel tableLayoutPanel1;
    }
}