namespace ChatAppClient
{
    partial class MessagesForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            SendMessageButton = new Button();
            EnterMessageBox = new TextBox();
            label1 = new Label();
            rtb = new RichTextBox();
            SuspendLayout();
            // 
            // SendMessageButton
            // 
            SendMessageButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            SendMessageButton.Location = new Point(706, 655);
            SendMessageButton.Margin = new Padding(1);
            SendMessageButton.Name = "SendMessageButton";
            SendMessageButton.Padding = new Padding(1);
            SendMessageButton.Size = new Size(98, 35);
            SendMessageButton.TabIndex = 0;
            SendMessageButton.Text = "send";
            SendMessageButton.UseVisualStyleBackColor = true;
            SendMessageButton.Click += SendMessageButton_Click;
            // 
            // EnterMessageBox
            // 
            EnterMessageBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            EnterMessageBox.Location = new Point(0, 663);
            EnterMessageBox.Margin = new Padding(2);
            EnterMessageBox.Name = "EnterMessageBox";
            EnterMessageBox.Size = new Size(703, 27);
            EnterMessageBox.TabIndex = 1;
            EnterMessageBox.TextChanged += EnterMessageBox_TextChanged;
            EnterMessageBox.KeyDown += EnterMessageBox_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(351, 260);
            label1.Name = "label1";
            label1.Size = new Size(40, 20);
            label1.TabIndex = 2;
            label1.Text = "HIIIII";
            label1.Click += label1_Click;
            // 
            // rtb
            // 
            rtb.Location = new Point(0, 2);
            rtb.Name = "rtb";
            rtb.ReadOnly = true;
            rtb.Size = new Size(804, 649);
            rtb.TabIndex = 3;
            rtb.Text = "";
            rtb.TextChanged += richTextBox1_TextChanged;
            // 
            // MessagesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(811, 690);
            Controls.Add(rtb);
            Controls.Add(label1);
            Controls.Add(EnterMessageBox);
            Controls.Add(SendMessageButton);
            Name = "MessagesForm";
            Text = "Form1";
            FormClosing += Form1_Closing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SendMessageButton;
        private TextBox EnterMessageBox;
        private Label label1;
        private RichTextBox rtb;
    }
}