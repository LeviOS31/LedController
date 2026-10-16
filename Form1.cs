using System.Net.Sockets;
using Microsoft.Win32;

namespace StripControlmadebyme
{
    public partial class Form1 : Form
    {
        private bool allowActualClose = false;
        string ip = Properties.Settings.Default.IpAddr;
        int port = Properties.Settings.Default.Port;
        byte[] SwitchOnOffPayload = [0x38, 0x86, 0x84, 0x99, 0xAA, 0x83];

        public Form1()
        {
            InitializeComponent();

            IPLabel.Text = ip;
            PortLabel.Text = port.ToString();
        }

        private void Form_Activated(object sender, EventArgs e)
        {
            // Update IP and Port labels when the form is activated
            ip = Properties.Settings.Default.IpAddr;
            port = Properties.Settings.Default.Port;
            IPLabel.Text = ip;
            PortLabel.Text = port.ToString();
        }

        private async void SwitchOnBar_Click(object sender, EventArgs e)
        {
            try
            {
                using (var socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp))
                {
                    // Begin the connection attempt asynchronously
                    var result = socket.BeginConnect(ip, port, null, null);

                    // Wait for 1 second max
                    bool success = result.AsyncWaitHandle.WaitOne(TimeSpan.FromMilliseconds(1000), true);

                    if (!success || !socket.Connected)
                    {
                        socket.Close();
                        throw new TimeoutException("Connection timed out or host is offline.");
                    }

                    socket.EndConnect(result);

                    // Once connected, convert to NetworkStream and send
                    using (var client = new TcpClient())
                    {
                        client.Client = socket;
                        using (NetworkStream stream = client.GetStream())
                        {
                            stream.WriteTimeout = 100;
                            stream.Write(SwitchOnOffPayload, 0, SwitchOnOffPayload.Length);
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void SelectColor_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (var client = new TcpClient(ip, port))
                    {
                        NetworkStream stream = client.GetStream();

                        byte r = colorDialog.Color.R;
                        byte g = colorDialog.Color.G;
                        byte b = colorDialog.Color.B;

                        byte[] ColorPayload = [0x38, r, g, b, 0x22, 0x83];

                        stream.Write(ColorPayload, 0, ColorPayload.Length);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            // If we are not intentionally shutting down, and the user clicked 'X'
            if (!allowActualClose && e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true; // Cancel the close event
                this.Hide();     // Hide the form to tray
                notifyIcon1.ShowBalloonTip(1000, "App Minimized", "Application is still running in the system tray.", ToolTipIcon.Info);
                notifyIcon1.Visible = true; // Ensure the tray icon is visible
            }
            else
            {
                // Perform your cleanup right before the app completely shuts down
                PerformAppCleanup();
            }
        }

        private void SystemEvents_SessionEnding(object sender, SessionEndingEventArgs e)
        {
            // Perform cleanup when the system is shutting down or the user is logging off
            allowActualClose = true; // Allow the form to close without canceling
            PerformAppCleanup();
        }

        private void PerformAppCleanup()
        {
            try
            {
                using (var client = new TcpClient(ip, port))
                {
                    NetworkStream stream = client.GetStream();
                    stream.Write(SwitchOnOffPayload, 0, SwitchOnOffPayload.Length);
                }

                notifyIcon1.Visible = false; // Clean up tray icon
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            allowActualClose = true;
            Application.Exit();
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            Settings settingsForm = new Settings();
            settingsForm.ShowDialog();
            IPLabel.Text = ip;
            PortLabel.Text = port.ToString();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ContextMenuStrip contextMenu = new ContextMenuStrip();

            ToolStripItem openItem = contextMenu.Items.Add("Open");
            ToolStripItem exitItem = contextMenu.Items.Add("Exit");

            openItem.Click += (s, args) =>
            {
                this.Show();
                this.WindowState = FormWindowState.Normal;
            };

            exitItem.Click += (s, args) =>
            {
                allowActualClose = true;
                Application.Exit();
            };

            contextMenu.Items.Add(openItem);
            contextMenu.Items.Add(exitItem);

            notifyIcon1.ContextMenuStrip = contextMenu;
        }
    }
}
