namespace Client
{
    partial class ChatForm
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
            splitContainer1 = new SplitContainer();
            tabControl1 = new TabControl();
            Contacts = new TabPage();
            ContactsflowLayoutPanel = new FlowLayoutPanel();
            Groups = new TabPage();
            GroupsflowLayoutPanel = new FlowLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            NewGroupButton = new Button();
            Config = new TabPage();
            flowLayoutPanel4 = new FlowLayoutPanel();
            button3 = new Button();
            sendButton = new Button();
            messageTextBox = new TextBox();
            ChatRichTextBox = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            tabControl1.SuspendLayout();
            Contacts.SuspendLayout();
            Groups.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            Config.SuspendLayout();
            flowLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(tabControl1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(sendButton);
            splitContainer1.Panel2.Controls.Add(messageTextBox);
            splitContainer1.Panel2.Controls.Add(ChatRichTextBox);
            splitContainer1.Size = new Size(800, 450);
            splitContainer1.SplitterDistance = 266;
            splitContainer1.TabIndex = 0;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(Contacts);
            tabControl1.Controls.Add(Groups);
            tabControl1.Controls.Add(Config);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(266, 450);
            tabControl1.TabIndex = 0;
            // 
            // Contacts
            // 
            Contacts.Controls.Add(ContactsflowLayoutPanel);
            Contacts.Location = new Point(4, 24);
            Contacts.Name = "Contacts";
            Contacts.Padding = new Padding(3);
            Contacts.Size = new Size(258, 422);
            Contacts.TabIndex = 0;
            Contacts.Text = "Contacts";
            Contacts.UseVisualStyleBackColor = true;
            // 
            // ContactsflowLayoutPanel
            // 
            ContactsflowLayoutPanel.AutoScroll = true;
            ContactsflowLayoutPanel.Dock = DockStyle.Fill;
            ContactsflowLayoutPanel.Location = new Point(3, 3);
            ContactsflowLayoutPanel.Name = "ContactsflowLayoutPanel";
            ContactsflowLayoutPanel.Size = new Size(252, 416);
            ContactsflowLayoutPanel.TabIndex = 0;
            // 
            // Groups
            // 
            Groups.Controls.Add(GroupsflowLayoutPanel);
            Groups.Controls.Add(flowLayoutPanel2);
            Groups.Location = new Point(4, 24);
            Groups.Name = "Groups";
            Groups.Padding = new Padding(3);
            Groups.Size = new Size(258, 422);
            Groups.TabIndex = 1;
            Groups.Text = "Groups";
            Groups.UseVisualStyleBackColor = true;
            // 
            // GroupsflowLayoutPanel
            // 
            GroupsflowLayoutPanel.AutoScroll = true;
            GroupsflowLayoutPanel.Dock = DockStyle.Bottom;
            GroupsflowLayoutPanel.Location = new Point(3, 37);
            GroupsflowLayoutPanel.Name = "GroupsflowLayoutPanel";
            GroupsflowLayoutPanel.Size = new Size(252, 382);
            GroupsflowLayoutPanel.TabIndex = 1;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AutoSize = true;
            flowLayoutPanel2.Controls.Add(NewGroupButton);
            flowLayoutPanel2.Dock = DockStyle.Top;
            flowLayoutPanel2.Location = new Point(3, 3);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(252, 31);
            flowLayoutPanel2.TabIndex = 0;
            // 
            // NewGroupButton
            // 
            NewGroupButton.AutoSize = true;
            NewGroupButton.Location = new Point(3, 3);
            NewGroupButton.Name = "NewGroupButton";
            NewGroupButton.Size = new Size(81, 25);
            NewGroupButton.TabIndex = 0;
            NewGroupButton.Text = "Novo grupo";
            NewGroupButton.UseVisualStyleBackColor = true;
            NewGroupButton.Click += NewGroupButton_Click;
            // 
            // Config
            // 
            Config.Controls.Add(flowLayoutPanel4);
            Config.Location = new Point(4, 24);
            Config.Name = "Config";
            Config.Size = new Size(258, 422);
            Config.TabIndex = 2;
            Config.Text = "Config";
            Config.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.Controls.Add(button3);
            flowLayoutPanel4.Dock = DockStyle.Fill;
            flowLayoutPanel4.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel4.Location = new Point(0, 0);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(258, 422);
            flowLayoutPanel4.TabIndex = 0;
            // 
            // button3
            // 
            button3.AutoSize = true;
            button3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button3.Location = new Point(219, 3);
            button3.Name = "button3";
            button3.Size = new Size(36, 25);
            button3.TabIndex = 0;
            button3.Text = "Sair";
            button3.UseVisualStyleBackColor = true;
            // 
            // sendButton
            // 
            sendButton.AutoSize = true;
            sendButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            sendButton.Enabled = false;
            sendButton.Location = new Point(469, 413);
            sendButton.Name = "sendButton";
            sendButton.Size = new Size(43, 25);
            sendButton.TabIndex = 2;
            sendButton.Text = "Send";
            sendButton.UseVisualStyleBackColor = true;
            sendButton.Click += sendButton_Click;
            // 
            // messageTextBox
            // 
            messageTextBox.Enabled = false;
            messageTextBox.Location = new Point(3, 415);
            messageTextBox.Name = "messageTextBox";
            messageTextBox.Size = new Size(460, 23);
            messageTextBox.TabIndex = 1;
            messageTextBox.TextChanged += messageTextBox_TextChanged;
            messageTextBox.KeyDown += messageTextBox_KeyDown;
            // 
            // ChatRichTextBox
            // 
            ChatRichTextBox.Enabled = false;
            ChatRichTextBox.Location = new Point(3, 3);
            ChatRichTextBox.Name = "ChatRichTextBox";
            ChatRichTextBox.ReadOnly = true;
            ChatRichTextBox.Size = new Size(524, 406);
            ChatRichTextBox.TabIndex = 0;
            ChatRichTextBox.Text = "\n\n\n\n\n\n\n\t\t             \n                                                    Select An User Or Group To Send Messages";
            // 
            // ChatForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Name = "ChatForm";
            Load += ChatForm_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            Contacts.ResumeLayout(false);
            Groups.ResumeLayout(false);
            Groups.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            Config.ResumeLayout(false);
            flowLayoutPanel4.ResumeLayout(false);
            flowLayoutPanel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private TabControl tabControl1;
        private TabPage Contacts;
        private FlowLayoutPanel ContactsflowLayoutPanel;
        private TabPage Groups;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button NewGroupButton;
        private RichTextBox ChatRichTextBox;
        private FlowLayoutPanel GroupsflowLayoutPanel;
        private TabPage Config;
        private Button sendButton;
        private TextBox messageTextBox;
        private FlowLayoutPanel flowLayoutPanel4;
        private Button button3;
    }
}