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
            SuspendLayout();
            // 
            // NameBox
            // 
            NameBox.Location = new Point(277, 250);
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
            WelcomeLabel.Location = new Point(277, 104);
            WelcomeLabel.Name = "WelcomeLabel";
            WelcomeLabel.Size = new Size(165, 20);
            WelcomeLabel.TabIndex = 1;
            WelcomeLabel.Text = "Welcome to chat room!";
            WelcomeLabel.Click += label1_Click;
            // 
            // CredentialsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(800, 450);
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
    }
}