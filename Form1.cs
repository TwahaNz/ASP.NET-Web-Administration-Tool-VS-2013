using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;

namespace WebSiteAdministration
{
    public partial class Form1 : Form
    {
        private char mainDriveLetter;
        private string os_type;
        private string serverDetails;
        private string startBrowser;
        private string port;

        private bool isFirst;

        public Form1()
        {
            InitializeComponent();
            mainDriveLetter = 'C';
            os_type = @"C:\Program Files\IIS Express";
            isFirst = true;
        }

        private void btnFolder_Click(object sender, EventArgs e)
        {
            if (isFirst)
            {
                MessageBox.Show("Please make sure to select the folder where your \nASP.NET documents and files are located and not the \n folder with the .sln file", "TnZ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                isFirst = false;
            }

            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();


            if (folderBrowser.ShowDialog().Equals(DialogResult.OK))
            {
                txt_location.Text = folderBrowser.SelectedPath;
                btn_startServer.Enabled = true;
                btn_stop_server.Enabled = true;
            }
        }

        private void rb_86_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_86.Checked)
                os_type = @"C:\Program Files\IIS Express";
            else
                os_type = @"C:\Program Files (x86)\IIS Express";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            port = txt_port.Text;

            string[] statements = new string[3];

            if (String.IsNullOrWhiteSpace(txt_port.Text))
                port = "8082";

            serverDetails = "iisexpress.exe /path:\"C:\\Windows\\Microsoft.NET\\Framework\\v4.0.30319\\ASP.NETWebAdminFiles\" /vpath:\"/ASP.NETWebAdminFiles\" /port:" + port + " /clr:4.0 /ntlm";

            statements[0] = mainDriveLetter + ":";
            statements[1] = "CD \"" + os_type + "\"";
            statements[2] = serverDetails;

            Process shut = new Process();

            File.WriteAllLines("start-server.bat", statements);

            shut.StartInfo.RedirectStandardOutput = true;
            shut.StartInfo.RedirectStandardError = true;
            shut.StartInfo.UseShellExecute = false;
            shut.StartInfo.CreateNoWindow = true;

            shut.StartInfo.FileName = "start-server.bat";

            shut.Start();

            txt_link.Text = "localhost:" + port + "/asp.netwebadminfiles/default.aspx?applicationPhysicalPath=" + txt_location.Text + "&applicationUrl=/";

            btn_startServer.Enabled = false;

            pc_on.Visible = true;
            pc_off.Visible = false;           

            lbl_link.Visible = true;
            lbl_note.Visible = true;
            lbl_note1.Visible = true;

            lbl_status.ForeColor = Color.Green;
            lbl_status.Text = "Web Tool Is Running!";
        }

        public void btn_start_browser_Click()
        {
            port = txt_port.Text;

            if (String.IsNullOrWhiteSpace(txt_port.Text))
                port = "8082";

            startBrowser = "start http:\\\\localhost:" + port + "/asp.netwebadminfiles/default.aspx?applicationPhysicalPath=" + txt_location.Text + "&applicationUrl=/";

            Process shut = new Process();

            File.WriteAllText("start-browser.bat", startBrowser);

            shut.StartInfo.RedirectStandardOutput = true;
            shut.StartInfo.RedirectStandardError = true;
            shut.StartInfo.UseShellExecute = false;
            shut.StartInfo.CreateNoWindow = true;

            shut.StartInfo.FileName = "start-browser.bat";

            shut.Start();
        }

        private void btn_stop_server_Click(object sender, EventArgs e)
        {
            string[] kills = { "TASKKILL -F -IM iisexpress.exe", "TASKKILL -F -IM iisexpresstray.exe" };

            Process shut = new Process();

            File.WriteAllLines("kill-server.bat", kills);

            shut.StartInfo.RedirectStandardOutput = true;
            shut.StartInfo.RedirectStandardError = true;
            shut.StartInfo.UseShellExecute = false;
            shut.StartInfo.CreateNoWindow = true;

            shut.StartInfo.FileName = "kill-server.bat";

            shut.Start();

            shut.WaitForExit();

            if (File.Exists("start-server.bat"))
                File.Delete("start-server.bat");

            if (File.Exists("start-browser.bat"))
                File.Delete("start-browser.bat");

            if (File.Exists("kill-server.bat"))
                File.Delete("kill-server.bat");

            txt_link.Text = "";

            btn_startServer.Enabled = true;

            pc_on.Visible = false;
            pc_off.Visible = true;     

            lbl_link.Visible = false;
            lbl_note.Visible = false;
            lbl_note1.Visible = false;

            lbl_status.ForeColor = Color.Red;
            lbl_status.Text = "Web Tool Is Off!";
        }
    }
}
