
using Microsoft.Win32;

namespace StripControlmadebyme
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();

            string ipAddress = Properties.Settings.Default.IpAddr;

            Port.Text = Properties.Settings.Default.Port.ToString();

            if (!string.IsNullOrEmpty(ipAddress))
            {
                string[] ipParts = ipAddress.Split('.');
                if (ipParts.Length == 4)
                {
                    IP1.Text = ipParts[0];
                    IP2.Text = ipParts[1];
                    IP3.Text = ipParts[2];
                    IP4.Text = ipParts[3];
                }
            }
        }

        private void SwitchOnStartup_Click(object sender, EventArgs e)
        {
            RegisterApp();
        }

        readonly string? AppDir = Environment.ProcessPath;
        readonly string RegistryKeyPath = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run";
        readonly string AppName = "LedStripControl";

        private void RegisterApp()
        {
            if (Properties.Settings.Default.Startup == false)
            {
                RegistryKey? registryKey = Registry.CurrentUser.OpenSubKey(RegistryKeyPath, true);

                if (registryKey == null || AppDir == null)
                {
                    throw new ArgumentException("Registry key or application directory is null.");
                }

                registryKey.SetValue(AppName, AppDir);
                SwitchOnStartup.Text = "Disable Startup";
            }
            else
            {
                RegistryKey? registryKey = Registry.CurrentUser.OpenSubKey(RegistryKeyPath, true);

                if (registryKey == null)
                {
                    throw new ArgumentException("Registry key is null.");
                }

                registryKey.DeleteValue(AppName, false);
                SwitchOnStartup.Text = "Enable Startup";
            }

            Properties.Settings.Default.Startup = !Properties.Settings.Default.Startup;
            Properties.Settings.Default.Save();

        }

        private void SaveSettings_Click(object sender, EventArgs e)
        {
            TextBox[] textBoxes = { IP1, IP2, IP3, IP4 };


            foreach (TextBox textBox in textBoxes)
            {
                int value = -1;
                if (textBox.Text == "" || !int.TryParse(textBox.Text, out value))
                {
                    MessageBox.Show("Incorrect value in IP address field.");
                    return;
                }

                if (value < 0 || value > 255)
                {
                    MessageBox.Show("Incorrect value in IP address field.");
                    return;
                }
            }

            string ipAddress = $"{IP1.Text}.{IP2.Text}.{IP3.Text}.{IP4.Text}";

            int portValue = -1;

            if (Port.Text == "" || !int.TryParse(Port.Text, out portValue))
            {
                MessageBox.Show("Incorrect value in port field.");
                return;
            }
            if (portValue < 0 || portValue > 65535)
            {
                MessageBox.Show("Incorrect value in port field.");
                return;
            }

            Properties.Settings.Default.IpAddr = ipAddress;
            Properties.Settings.Default.Port = portValue;
            Properties.Settings.Default.Save();
        }
    }
}
