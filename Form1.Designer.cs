namespace StripControlmadebyme
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            SwitchOnBar = new Button();
            colorDialog = new ColorDialog();
            SelectColor = new Button();
            SettingsButton = new Button();
            notifyIcon1 = new NotifyIcon(components);
            label1 = new Label();
            label2 = new Label();
            PortLabel = new Label();
            IPLabel = new Label();
            SuspendLayout();
            // 
            // SwitchOnBar
            // 
            SwitchOnBar.Font = new Font("Segoe UI", 14F);
            SwitchOnBar.Location = new Point(12, 57);
            SwitchOnBar.Name = "SwitchOnBar";
            SwitchOnBar.Size = new Size(150, 50);
            SwitchOnBar.TabIndex = 0;
            SwitchOnBar.Text = "Switch bar";
            SwitchOnBar.UseVisualStyleBackColor = true;
            SwitchOnBar.Click += SwitchOnBar_Click;
            // 
            // colorDialog
            // 
            colorDialog.AnyColor = true;
            // 
            // SelectColor
            // 
            SelectColor.Font = new Font("Segoe UI", 14F);
            SelectColor.Location = new Point(12, 113);
            SelectColor.Name = "SelectColor";
            SelectColor.Size = new Size(150, 50);
            SelectColor.TabIndex = 1;
            SelectColor.Text = "Select color";
            SelectColor.UseVisualStyleBackColor = true;
            SelectColor.Click += SelectColor_Click;
            // 
            // SettingsButton
            // 
            SettingsButton.Image = (Image)resources.GetObject("SettingsButton.Image");
            SettingsButton.Location = new Point(173, 12);
            SettingsButton.Name = "SettingsButton";
            SettingsButton.Size = new Size(35, 35);
            SettingsButton.TabIndex = 2;
            SettingsButton.UseVisualStyleBackColor = true;
            SettingsButton.Click += SettingsButton_Click;
            // 
            // notifyIcon1
            // 
            notifyIcon1.Icon = (Icon)resources.GetObject("notifyIcon1.Icon");
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            notifyIcon1.MouseClick += notifyIcon1_MouseDoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 3;
            label1.Text = "IP addr:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 32);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 4;
            label2.Text = "Port:";
            // 
            // PortLabel
            // 
            PortLabel.AutoSize = true;
            PortLabel.Location = new Point(65, 32);
            PortLabel.Name = "PortLabel";
            PortLabel.Size = new Size(31, 15);
            PortLabel.TabIndex = 6;
            PortLabel.Text = "1000";
            // 
            // IPLabel
            // 
            IPLabel.AutoSize = true;
            IPLabel.Location = new Point(65, 9);
            IPLabel.Name = "IPLabel";
            IPLabel.Size = new Size(40, 15);
            IPLabel.TabIndex = 7;
            IPLabel.Text = "1.1.1.1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(220, 172);
            Controls.Add(IPLabel);
            Controls.Add(PortLabel);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(SettingsButton);
            Controls.Add(SelectColor);
            Controls.Add(SwitchOnBar);
            Name = "Form1";
            Text = "Form1";
            Activated += Form_Activated;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SwitchOnBar;
        private ColorDialog colorDialog;
        private Button SelectColor;
        private Button SettingsButton;
        private NotifyIcon notifyIcon1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label PortLabel;
        private Label IPLabel;
    }
}
