namespace Multicast_Chat
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.PortPanel = new System.Windows.Forms.Panel();
            this.NameText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PortButton = new System.Windows.Forms.Button();
            this.PortText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ChatPanel = new System.Windows.Forms.Panel();
            this.MessagesList = new System.Windows.Forms.ListView();
            this.SendButton = new System.Windows.Forms.Button();
            this.MessageText = new System.Windows.Forms.TextBox();
            this.PortPanel.SuspendLayout();
            this.ChatPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // PortPanel
            // 
            this.PortPanel.Controls.Add(this.NameText);
            this.PortPanel.Controls.Add(this.label2);
            this.PortPanel.Controls.Add(this.PortButton);
            this.PortPanel.Controls.Add(this.PortText);
            this.PortPanel.Controls.Add(this.label1);
            this.PortPanel.Location = new System.Drawing.Point(42, 34);
            this.PortPanel.Name = "PortPanel";
            this.PortPanel.Size = new System.Drawing.Size(308, 157);
            this.PortPanel.TabIndex = 0;
            // 
            // NameText
            // 
            this.NameText.Location = new System.Drawing.Point(138, 77);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(147, 20);
            this.NameText.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Введите свое имя";
            // 
            // PortButton
            // 
            this.PortButton.Location = new System.Drawing.Point(98, 115);
            this.PortButton.Name = "PortButton";
            this.PortButton.Size = new System.Drawing.Size(100, 23);
            this.PortButton.TabIndex = 2;
            this.PortButton.Text = "Присоедениться";
            this.PortButton.UseVisualStyleBackColor = true;
            this.PortButton.Click += new System.EventHandler(this.PortButton_Click);
            // 
            // PortText
            // 
            this.PortText.Location = new System.Drawing.Point(98, 36);
            this.PortText.Name = "PortText";
            this.PortText.Size = new System.Drawing.Size(100, 20);
            this.PortText.TabIndex = 1;
            this.PortText.Text = "5555-5559";
            this.PortText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите порт для присоединения к общему чату";
            // 
            // ChatPanel
            // 
            this.ChatPanel.Controls.Add(this.MessagesList);
            this.ChatPanel.Controls.Add(this.SendButton);
            this.ChatPanel.Controls.Add(this.MessageText);
            this.ChatPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChatPanel.Location = new System.Drawing.Point(0, 0);
            this.ChatPanel.Name = "ChatPanel";
            this.ChatPanel.Size = new System.Drawing.Size(402, 261);
            this.ChatPanel.TabIndex = 1;
            this.ChatPanel.Visible = false;
            // 
            // MessagesList
            // 
            this.MessagesList.HideSelection = false;
            this.MessagesList.Location = new System.Drawing.Point(4, 4);
            this.MessagesList.Name = "MessagesList";
            this.MessagesList.Size = new System.Drawing.Size(395, 208);
            this.MessagesList.TabIndex = 2;
            this.MessagesList.UseCompatibleStateImageBehavior = false;
            this.MessagesList.View = System.Windows.Forms.View.List;
            // 
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(350, 218);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(49, 40);
            this.SendButton.TabIndex = 1;
            this.SendButton.Text = "Send";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // MessageText
            // 
            this.MessageText.Location = new System.Drawing.Point(4, 218);
            this.MessageText.MaximumSize = new System.Drawing.Size(340, 40);
            this.MessageText.MinimumSize = new System.Drawing.Size(340, 40);
            this.MessageText.Multiline = true;
            this.MessageText.Name = "MessageText";
            this.MessageText.Size = new System.Drawing.Size(340, 40);
            this.MessageText.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 261);
            this.Controls.Add(this.ChatPanel);
            this.Controls.Add(this.PortPanel);
            this.Name = "Form1";
            this.Text = "MulticastChat";
            this.PortPanel.ResumeLayout(false);
            this.PortPanel.PerformLayout();
            this.ChatPanel.ResumeLayout(false);
            this.ChatPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PortPanel;
        private System.Windows.Forms.Button PortButton;
        private System.Windows.Forms.TextBox PortText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel ChatPanel;
        private System.Windows.Forms.ListView MessagesList;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.TextBox MessageText;
    }
}

