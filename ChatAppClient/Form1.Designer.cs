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
            EnterMessageBox = new TextBox();
            rtb = new RichTextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            SendMessageButton = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // EnterMessageBox
            // 
            tableLayoutPanel1.SetColumnSpan(EnterMessageBox, 9);
            EnterMessageBox.Dock = DockStyle.Fill;
            EnterMessageBox.Location = new Point(2, 560);
            EnterMessageBox.Margin = new Padding(2);
            EnterMessageBox.Multiline = true;
            EnterMessageBox.Name = "EnterMessageBox";
            tableLayoutPanel1.SetRowSpan(EnterMessageBox, 2);
            EnterMessageBox.Size = new Size(761, 73);
            EnterMessageBox.TabIndex = 1;
            EnterMessageBox.TextChanged += EnterMessageBox_TextChanged;
            // 
            // rtb
            // 
            tableLayoutPanel1.SetColumnSpan(rtb, 10);
            rtb.Dock = DockStyle.Fill;
            rtb.Location = new Point(3, 3);
            rtb.Name = "rtb";
            rtb.ReadOnly = true;
            tableLayoutPanel1.SetRowSpan(rtb, 18);
            rtb.Size = new Size(852, 552);
            rtb.TabIndex = 3;
            rtb.Text = "";
            rtb.TextChanged += richTextBox1_TextChanged;
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
            tableLayoutPanel1.Controls.Add(rtb, 0, 0);
            tableLayoutPanel1.Controls.Add(EnterMessageBox, 5, 17);
            tableLayoutPanel1.Controls.Add(SendMessageButton, 9, 18);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 20;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(858, 635);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // SendMessageButton
            // 
            SendMessageButton.Dock = DockStyle.Fill;
            SendMessageButton.Location = new Point(766, 559);
            SendMessageButton.Margin = new Padding(1);
            SendMessageButton.Name = "SendMessageButton";
            SendMessageButton.Padding = new Padding(1);
            tableLayoutPanel1.SetRowSpan(SendMessageButton, 2);
            SendMessageButton.Size = new Size(91, 75);
            SendMessageButton.TabIndex = 0;
            SendMessageButton.Text = "send";
            SendMessageButton.UseVisualStyleBackColor = true;
            SendMessageButton.Click += SendMessageButton_Click;
            // 
            // MessagesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(858, 635);
            Controls.Add(tableLayoutPanel1);
            Name = "MessagesForm";
            Text = "Chat application";
            FormClosing += Form1_Closing;
            Resize += MessagesForm_Resize;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox EnterMessageBox;
        private RichTextBox rtb;
        private TableLayoutPanel tableLayoutPanel1;
        private Button SendMessageButton;
    }
}