using System.Diagnostics;

namespace ProxyEnabler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   
            Process process = new Process();

            // Stop the process from opening a new window
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.CreateNoWindow = true;

            // Setup executable and parameters
            process.StartInfo.FileName = @"cmd.exe";
            process.StartInfo.Arguments = "/c reg add \"HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings\" /v ProxyEnable /t REG_DWORD /d 1 /f";

            // Go
            process.Start();
            button1.Enabled = false;
            button1.BackColor = Color.LightSteelBlue;

            button2.Enabled = true;
            button2.BackColor = Color.FromArgb(35,40,45);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process process = new Process();

            // Stop the process from opening a new window
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.CreateNoWindow = true;

            // Setup executable and parameters
            process.StartInfo.FileName = @"cmd.exe";
            process.StartInfo.Arguments = "/c reg add \"HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings\" /v ProxyEnable /t REG_DWORD /d 0 /f";

            // Go
            process.Start();
            button2.Enabled = false;
            button2.BackColor = Color.LightSteelBlue;

            button1.Enabled = true;
            button1.BackColor = Color.FromArgb(35, 40, 45);
        }
    }
}