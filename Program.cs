namespace StripControlmadebyme
{
    internal static class Program
    {
        static Mutex mutex = new Mutex(true, "LizardLedController");

        [STAThread]
        static void Main()
        {
            if (mutex.WaitOne(TimeSpan.Zero, true))
            {
                try
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new Form1());
                }
                finally
                {
                    mutex.ReleaseMutex();
                }
            }
            else
            {
                MessageBox.Show("Another instance of the application is already running.", "Instance Running", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}