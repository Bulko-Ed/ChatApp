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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            IPBox = new TextBox();
            PortBox = new TextBox();
            SuspendLayout();
            // 
            // NameBox
            // 
            NameBox.Location = new Point(145, 388);
            NameBox.Name = "NameBox";
            NameBox.Size = new Size(233, 27);
            NameBox.TabIndex = 0;
            NameBox.Text = "Enter your name";
            NameBox.TextChanged += NameBox_TextChanged;
            NameBox.KeyDown += NameBox_KeyDown;
            // 
            // WelcomeLabel
            // 
            WelcomeLabel.AutoSize = true;
            WelcomeLabel.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            WelcomeLabel.Location = new Point(145, 90);
            WelcomeLabel.Name = "WelcomeLabel";
            WelcomeLabel.Size = new Size(419, 50);
            WelcomeLabel.TabIndex = 1;
            WelcomeLabel.Text = " Welcome to chat room!";
            WelcomeLabel.Click += label1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(145, 226);
            label1.Name = "label1";
            label1.Size = new Size(371, 28);
            label1.TabIndex = 2;
            label1.Text = "Please, enter IP address and port number.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(145, 287);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 3;
            label2.Text = "IP address";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(145, 331);
            label3.Name = "label3";
            label3.Size = new Size(90, 20);
            label3.TabIndex = 4;
            label3.Text = "Port number";
            // 
            // IPBox
            // 
            IPBox.Location = new Point(249, 287);
            IPBox.Name = "IPBox";
            IPBox.Size = new Size(125, 27);
            IPBox.TabIndex = 5;
            IPBox.KeyDown += IPBox_KeyDown;
            // 
            // PortBox
            // 
            PortBox.Location = new Point(249, 324);
            PortBox.Name = "PortBox";
            PortBox.Size = new Size(125, 27);
            PortBox.TabIndex = 6;
            PortBox.KeyDown += PortBox_KeyDown;
            // 
            // CredentialsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(800, 450);
            Controls.Add(PortBox);
            Controls.Add(IPBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(WelcomeLabel);
            Controls.Add(NameBox);
            Name = "CredentialsForm";
            Text = "Chat room";
            Load += CredentialsForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox NameBox;
        private Label WelcomeLabel;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox IPBox;
        private TextBox PortBox;
    }
}