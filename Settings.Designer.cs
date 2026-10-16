namespace StripControlmadebyme
{
    partial class Settings
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
            SwitchOnStartup = new Button();
            label1 = new Label();
            label2 = new Label();
            IP1 = new TextBox();
            label3 = new Label();
            IP2 = new TextBox();
            label4 = new Label();
            IP3 = new TextBox();
            label5 = new Label();
            IP4 = new TextBox();
            Port = new TextBox();
            SaveSettings = new Button();
            SuspendLayout();
            // 
            // SwitchOnStartup
            // 
            SwitchOnStartup.Location = new Point(12, 12);
            SwitchOnStartup.Name = "SwitchOnStartup";
            SwitchOnStartup.Size = new Size(170, 36);
            SwitchOnStartup.TabIndex = 0;
            SwitchOnStartup.Text = "Turn on on startup";
            SwitchOnStartup.UseVisualStyleBackColor = true;
            SwitchOnStartup.Click += SwitchOnStartup_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 82);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 1;
            label1.Text = "IP addr:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 117);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 2;
            label2.Text = "Port:";
            // 
            // IP1
            // 
            IP1.Location = new Point(63, 74);
            IP1.Name = "IP1";
            IP1.Size = new Size(26, 23);
            IP1.TabIndex = 3;
            IP1.Text = "111";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(87, 78);
            label3.Name = "label3";
            label3.Size = new Size(10, 15);
            label3.TabIndex = 4;
            label3.Text = ".";
            // 
            // IP2
            // 
            IP2.Location = new Point(95, 74);
            IP2.Name = "IP2";
            IP2.Size = new Size(26, 23);
            IP2.TabIndex = 5;
            IP2.Text = "111";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(118, 78);
            label4.Name = "label4";
            label4.Size = new Size(10, 15);
            label4.TabIndex = 6;
            label4.Text = ".";
            // 
            // IP3
            // 
            IP3.Location = new Point(125, 74);
            IP3.Name = "IP3";
            IP3.Size = new Size(26, 23);
            IP3.TabIndex = 7;
            IP3.Text = "111";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(149, 79);
            label5.Name = "label5";
            label5.Size = new Size(10, 15);
            label5.TabIndex = 8;
            label5.Text = ".";
            // 
            // IP4
            // 
            IP4.Location = new Point(157, 74);
            IP4.Name = "IP4";
            IP4.Size = new Size(26, 23);
            IP4.TabIndex = 9;
            IP4.Text = "111";
            // 
            // Port
            // 
            Port.Location = new Point(63, 109);
            Port.Name = "Port";
            Port.Size = new Size(100, 23);
            Port.TabIndex = 10;
            // 
            // SaveSettings
            // 
            SaveSettings.Location = new Point(53, 149);
            SaveSettings.Name = "SaveSettings";
            SaveSettings.Size = new Size(75, 23);
            SaveSettings.TabIndex = 11;
            SaveSettings.Text = "Save";
            SaveSettings.UseVisualStyleBackColor = true;
            SaveSettings.Click += SaveSettings_Click;
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(194, 181);
            Controls.Add(SaveSettings);
            Controls.Add(Port);
            Controls.Add(IP4);
            Controls.Add(label5);
            Controls.Add(IP3);
            Controls.Add(label4);
            Controls.Add(IP2);
            Controls.Add(label3);
            Controls.Add(IP1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(SwitchOnStartup);
            Name = "Settings";
            Text = "Settings";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SwitchOnStartup;
        private Label label1;
        private Label label2;
        private TextBox IP1;
        private Label label3;
        private TextBox IP2;
        private Label label4;
        private TextBox IP3;
        private Label label5;
        private TextBox IP4;
        private TextBox Port;
        private Button SaveSettings;
    }
}