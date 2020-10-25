//------------------------------------------------------------------
//-----------------------------Usings-------------------------------
//------------------------------------------------------------------
#region Usings
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Net;
using System.IO;
using System.Runtime.InteropServices;
using Microsoft.Win32;
using System.Collections.Specialized;
using System.Security.Cryptography;
#endregion

namespace WindowsFormsApplication1
{

    public partial class Form1 : Form
    {
        //------------------------------------------------------------------
        //---------------------Click Anywhere to Move-----------------------
        //------------------------------------------------------------------
        #region Click Anywhere to Move
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
        int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        #endregion

        //------------------------------------------------------------------
        //------------------Click Anywhere to Move Event--------------------
        //------------------------------------------------------------------
        #region Click Anywhere to Move Event
        private void titelLeiste_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }
        #endregion

        //------------------------------------------------------------------
        //-----------------------------Form1--------------------------------
        //------------------------------------------------------------------
        #region Form1
        public Form1()
        {
            InitializeComponent();

            if (!check_dir())
            {
                MessageBox.Show("Launcher liegt im falschen Verzeichnis", "Fehler!");
                MessageBox.Show("Launcher muss ins OA Verzeichnis!", "Fehler hoch 2!");
                MessageBox.Show("PACK MICH DA REIN!!!!", "Fehler hoch 3!");
                Application.Exit();
            }

            version_txt.Text = "Version: " + get_online_version();
            StartGameButton.Image = ExtremLauncher.Properties.Resources.extrem_rdy;
            //set_text("Spiel ist auf dem neusten Stand");
            StartGameButton.Enabled = true;
        }
        #endregion

        public Boolean check_dir()
        {
            if (File.Exists(Directory.GetCurrentDirectory() + "\\Expansion\\beta\\arma2oa.exe"))
                return true;
            else
                return false;
        }

        public String get_online_version()
        {
            string myTextUrl = "http://dengpeng.eu/mod/e/version.php";
            WebClient urlGrabber = new WebClient();
            return urlGrabber.DownloadString(myTextUrl);
        }

        public String get_arma2ordner()
        {
            if (File.Exists(Directory.GetCurrentDirectory() + "\\arma2_pfad.ini"))
            {
                using (StreamReader reader = new StreamReader(Directory.GetCurrentDirectory() + "\\arma2_pfad.ini", System.Text.Encoding.Default))
                {
                    return reader.ReadLine();
                }
            }
            else
            {
                return Directory.GetCurrentDirectory();
            }
        }

        public String get_extra_cmd()
        {
            if (File.Exists(Directory.GetCurrentDirectory() + "\\e_extra_cmd.ini"))
            {
                using (StreamReader reader = new StreamReader(Directory.GetCurrentDirectory() + "\\e_extra_cmd.ini", System.Text.Encoding.Default))
                {
                    return reader.ReadLine();
                }
            }
            else
            {
                return "-nosplash";
            }
        }

        public String get_guid()
        {
            if (File.Exists(Directory.GetCurrentDirectory() + "\\guid.ini"))
            {
                using (StreamReader reader = new StreamReader(Directory.GetCurrentDirectory() + "\\guid.ini", System.Text.Encoding.Default))
                {
                    return reader.ReadLine();
                }
            }
            else
            {
                return "NO-GUID";
            }
        }

        public Boolean erstelle_config()
        {
            if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\ArmA 2\\ArmA2OA.cfg"))
            {
                using (StreamReader reader = new StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\ArmA 2\\ArmA2OA.cfg", System.Text.Encoding.Default))
                {
                    string line;
                    string new_config = "";

                    while ((line = reader.ReadLine()) != null)
                    {
                        if (line.Contains("MinErrorToSend") || line.Contains("MaxMsgSend") || line.Contains("MaxSizeGuaranteed") || line.Contains("MaxSizeNonguaranteed") || line.Contains("MinBandwidth") || line.Contains("MaxBandwidth"))
                        {
                            using (var wb = new WebClient())
                            {
                                char trenn = '=';
                                string[] split = line.Split(trenn);
                                var data = new NameValueCollection();
                                data.Add("guid", get_guid());
                                data.Add("feld", split[0]);
                                data.Add("wert", split[1]);
                                data.Add("key", "dp");
                                var response = wb.UploadValues("http://www.dengpeng.eu/report_config.php", "POST", data);
                            }
                        }
                        else
                        {
                            new_config += line + "\r\n";
                        }
                    }
                    reader.Close();
                    if (File.Exists(Directory.GetCurrentDirectory() + "\\extrem.cfg"))
                        File.Delete(Directory.GetCurrentDirectory() + "\\extrem.cfg");
                    StreamWriter myFile = new StreamWriter("extrem.cfg");
                    myFile.Write(new_config);
                    myFile.Write("MinErrorToSend=0.001;\r\nMaxMsgSend=128;\r\nMaxSizeGuaranteed=1300;\r\nMaxSizeNonguaranteed=1300;\r\nMinBandwidth=256000;\r\nMaxBandwidth=480000;");
                    myFile.Close();
                    MessageBox.Show("Config geschrieben ...");
                }
            }
            else
                return false;
            return false;
        }

        delegate void SetTextCallback(string text);

        public void set_text(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.status.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(set_text);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.status.Text = text;
            }
        }

        //------------------------------------------------------------------
        //---------------------StartGameButton Events-----------------------
        //------------------------------------------------------------------
        #region StartGameButton Events
        private void StartGamebtn_Click(object sender, EventArgs e)
        {
            if (check_dir())
            {
                Process Pu = new Process();
                Pu.StartInfo.FileName = Directory.GetCurrentDirectory() + "\\rsync\\rsync.exe";
                //Pu.StartInfo.UseShellExecute = true;
                //Pu.StartInfo.RedirectStandardOutput = true;
                string cygdrive = "\"/cygdrive/" + Directory.GetCurrentDirectory().Remove(1, 1).Replace("\\", "/") + "\"";
                Pu.StartInfo.Arguments = " -htrv --del --progress moddownload.dengpeng.eu::extrem_test " + cygdrive + "/@DayZ_EX_TEST";
                Pu.Start();
                Pu.WaitForExit();
                Pu.StartInfo.Arguments = " -htrv --del --progress moddownload.dengpeng.eu::cba_dp " + cygdrive + "/@CBA_DP";
                Pu.Start();
                Pu.WaitForExit();
                Pu.StartInfo.Arguments = " -htrv --progress moddownload.dengpeng.eu::userconfig " + cygdrive + "/userconfig";
                Pu.Start();
                Pu.WaitForExit();
                if (sm.Checked == true)
                {
                    Pu.StartInfo.Arguments = " -htrv --del --progress moddownload.dengpeng.eu::soundmod_dp " + cygdrive + "/@SoundMOD_DP";
                    Pu.Start();
                    Pu.WaitForExit();
                }

                string a2path = get_arma2ordner();
                string extra_cmd = get_extra_cmd();

                Process P = new Process();
                P.StartInfo.FileName = Directory.GetCurrentDirectory() + "\\Expansion\\beta\\arma2oa.exe";
                if (sm.Checked == true)
                {
                    if (erstelle_config())
                        P.StartInfo.Arguments = "\"-mod=" + a2path + ";EXPANSION;ca\" -mod=Expansion\\beta;Expansion\\beta\\Expansion;@DayZ_EX_TEST;@CBA_DP;@SoundMOD_DP -cfg=extrem.cfg -connect=extremtest.dengpeng.eu -port=2401 " + extra_cmd; //  -nosplash -cpuCount=4 -exThreads=7
                    else
                        P.StartInfo.Arguments = "\"-mod=" + a2path + ";EXPANSION;ca\" -mod=Expansion\\beta;Expansion\\beta\\Expansion;@DayZ_EX_TEST;@CBA_DP;@SoundMOD_DP -connect=extremtest.dengpeng.eu -port=2401 " + extra_cmd; //  -nosplash -cpuCount=4 -exThreads=7
                }
                else
                {
                    if (erstelle_config())
                        P.StartInfo.Arguments = "\"-mod=" + a2path + ";EXPANSION;ca\" -mod=Expansion\\beta;Expansion\\beta\\Expansion;@DayZ_EX_TEST;@CBA_DP -cfg=extrem.cfg -connect=extremtest.dengpeng.eu -port=2401 " + extra_cmd; //  -nosplash -cpuCount=4 -exThreads=7
                    else
                        P.StartInfo.Arguments = "\"-mod=" + a2path + ";EXPANSION;ca\" -mod=Expansion\\beta;Expansion\\beta\\Expansion;@DayZ_EX_TEST;@CBA_DP -connect=extremtest.dengpeng.eu -port=2401 " + extra_cmd; //  -nosplash -cpuCount=4 -exThreads=7
                }
                P.Start();
            }
            else
            {
                MessageBox.Show("Launcher liegt im falschen Verzeichnis", "Fehler!");
                MessageBox.Show("Launcher muss ins OA Verzeichnis!", "Fehler hoch 2!");
                MessageBox.Show("PACK MICH DA REIN!!!!", "Fehler hoch 3!");
            }
        }
        private void StartGamebtn_MouseEnter(object sender, EventArgs e)
        {
            StartGameButton.Image = ExtremLauncher.Properties.Resources.extrem_rdy;
        }
        private void StartGamebtn_MouseHover(object sender, EventArgs e)
        {
            StartGameButton.Image = ExtremLauncher.Properties.Resources.extrem_start;
        }
        #endregion

        //------------------------------------------------------------------
        //----------------------CloseButton Events--------------------------
        //------------------------------------------------------------------
        #region CloseButton Events
        private void Closebtn_MouseEnter(object sender, EventArgs e)
        {
            CloseButton.Image = ExtremLauncher.Properties.Resources.exit_over;
        }
        private void Closebtn_MouseLeave(object sender, EventArgs e)
        {
            CloseButton.Image = ExtremLauncher.Properties.Resources.exit_off;
        }
        private void Closebtn_MouseDown(object sender, MouseEventArgs e)
        {
            CloseButton.Image = ExtremLauncher.Properties.Resources.exit_over;
        }
        private void Closebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

    }    
}