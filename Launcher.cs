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
using Ionic.Zip;
using Ionic.Zlib;
using Microsoft.Win32;
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
            
            Boolean check_b = check();
            if (check_b)
            {
                version_txt.Text = "Version: " + get_version();
                StartGameButton.Image = ExtremLauncher.Properties.Resources.extrem_rdy;
                set_text("Spiel ist auf dem neusten Stand");
                StartGameButton.Enabled = true;
                updateb.Enabled = false;
                updateb.Image = ExtremLauncher.Properties.Resources.update;
            }
            else
            {
                version_txt.Text = "Version: " + get_version();
                StartGameButton.Enabled = false;
                updateb.Enabled = true;
                StartGameButton.Image = ExtremLauncher.Properties.Resources.extrem_nonstart;
                updateb.Image = ExtremLauncher.Properties.Resources.update;
            }
            
        }
        #endregion

        public Boolean check_dir()
        {
            if (File.Exists(Directory.GetCurrentDirectory() + "\\Expansion\\beta\\arma2oa.exe"))
                return true;
            else
                return false;
        }

        public Boolean check()
        {
            string version = get_version();
            string next_version = get_next_version();
            // == 
            if (version == next_version)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public String get_version()
        {
            if (File.Exists(Directory.GetCurrentDirectory() + "\\e_version.ini"))
            {
                return System.IO.File.ReadAllText(Directory.GetCurrentDirectory() + "\\e_version.ini");
            }
            else
            {
                return "0.00";
            }
        }

        public String get_next_version()
        {
            string version = get_version();
            string myTextUrl = "http://dengpeng.eu/mod/e/version.php?version=" + version;
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
                string a2path = get_arma2ordner();
                string extra_cmd = get_extra_cmd();

                Process P = new Process();
                P.StartInfo.FileName = Directory.GetCurrentDirectory() + "\\Expansion\\beta\\arma2oa.exe";
                if (sm.Checked == true)
                {
                    P.StartInfo.Arguments = "\"-mod=" + a2path + ";EXPANSION;ca\" -mod=Expansion\\beta;Expansion\\beta\\Expansion;@DayZ_EX;@CBA;@CBA_A2;@CBA_OA;@DayZ_EX_SFX -connect=95.156.251.20 -port=2401 " + extra_cmd; //  -nosplash -cpuCount=4 -exThreads=7
                }
                else
                {
                    P.StartInfo.Arguments = "\"-mod=" + a2path + ";EXPANSION;ca\" -mod=Expansion\\beta;Expansion\\beta\\Expansion;@DayZ_EX;@CBA;@CBA_A2;@CBA_OA -connect=95.156.251.20 -port=2401 " + extra_cmd; //  -nosplash -cpuCount=4 -exThreads=7
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
        //----------------------Updateb Events--------------------------
        //------------------------------------------------------------------
        #region updateb Events
        private void updateb_MouseEnter(object sender, EventArgs e)
        {
            updateb.Image = ExtremLauncher.Properties.Resources.update_hover;
        }
        private void updateb_MouseLeave(object sender, EventArgs e)
        {
            updateb.Image = ExtremLauncher.Properties.Resources.update;
        }
        private void updateb_MouseDown(object sender, MouseEventArgs e)
        {
            updateb.Image = ExtremLauncher.Properties.Resources.update_on_druck;
        }
        private void updateb_Click(object sender, EventArgs e)
        {
            string version = get_version();
            string new_version = get_next_version();
            updateb.Enabled = false;
            updateb.Image = ExtremLauncher.Properties.Resources.update;
            set_text("Starte Update auf Version: " + new_version + "\n\rDu hast momentan Version: " + version);
            downloadUpdates = new BackgroundWorker();
            downloadUpdates.DoWork += new DoWorkEventHandler(downloadUpdates_DoWork);
            downloadUpdates.RunWorkerAsync();
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

        //------------------------------------------------------------------
        //--------------------AutomaticUpdater Events-----------------------
        //------------------------------------------------------------------
        #region AutomaticUpdater Events
        private void downloadUpdates_DoWork(object sender, DoWorkEventArgs e)
        {
            string version = get_version();
            string next_version = get_next_version();

            // the URL to download the file from
            string sUrlToReadFileFrom = "http://dengpeng.eu/mod/e/" + next_version + "/update.zip";
            // the path to write the file to
            string sFilePathToWriteFileTo = next_version + ".zip";

            // first, we need to get the exact size (in bytes) of the file we are downloading
            Uri url = new Uri(sUrlToReadFileFrom);
            System.Net.HttpWebRequest request = (System.Net.HttpWebRequest)System.Net.WebRequest.Create(url);
            System.Net.HttpWebResponse response = (System.Net.HttpWebResponse)request.GetResponse();
            response.Close();
            // gets the size of the file in bytes
            Int64 iSize = response.ContentLength;
            Int64 size = 0;

            if (File.Exists(next_version + ".zip"))
            {
                FileInfo finfo = new FileInfo(next_version + ".zip");
                size = finfo.Length;
            }
            if (size == iSize)
                entpacken(next_version);
            else
            {
                // keeps track of the total bytes downloaded so we can update the progress bar
                Int64 iRunningByteTotal = 0;
                // use the webclient object to download the file
                using (System.Net.WebClient client = new System.Net.WebClient())
                {
                    // open the file at the remote URL for reading
                    using (System.IO.Stream streamRemote = client.OpenRead(new Uri(sUrlToReadFileFrom)))
                    {
                        // using the FileStream object, we can write the downloaded bytes to the file system
                        using (Stream streamLocal = new FileStream(sFilePathToWriteFileTo, FileMode.Create, FileAccess.Write, FileShare.None))
                        {
                            // loop the stream and get the file into the byte buffer
                            int iByteSize = 0;
                            byte[] byteBuffer = new byte[iSize];
                            while ((iByteSize = streamRemote.Read(byteBuffer, 0, byteBuffer.Length)) > 0)
                            {
                                // write the bytes to the file system at the file path specified
                                streamLocal.Write(byteBuffer, 0, iByteSize);
                                iRunningByteTotal += iByteSize;

                                // calculate the progress out of a base "100"
                                double dIndex = (double)(iRunningByteTotal);
                                double dTotal = (double)byteBuffer.Length;
                                double dProgressPercentage = (dIndex / dTotal);
                                int iProgressPercentage = (int)(dProgressPercentage * 100);
                                mbs.Text = Math.Round(dIndex / 1024 / 1024, 0) + "MB von " + Math.Round(dTotal / 1024 / 1024, 0) + "MB";
                                prozent.Text = iProgressPercentage + " %";

                                // update the progress bar
                                downloadUpdates.ReportProgress(iProgressPercentage);
                            }
                            // clean up the file stream
                            streamLocal.Close();
                        }
                        // close the connection to the remote server
                        streamRemote.Close();
                    }
                }
            }
        }

        private void downloadUpdates_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            downloadProgress.Value = e.ProgressPercentage;
            if (e.ProgressPercentage == 10)
                dlp.Image = ExtremLauncher.Properties.Resources.pBar_01;
            if (e.ProgressPercentage == 20)
                dlp.Image = ExtremLauncher.Properties.Resources.pBar_02;
            if (e.ProgressPercentage == 30)
                dlp.Image = ExtremLauncher.Properties.Resources.pBar_03;
            if (e.ProgressPercentage == 40)
                dlp.Image = ExtremLauncher.Properties.Resources.pBar_04;
            if (e.ProgressPercentage == 50)
                dlp.Image = ExtremLauncher.Properties.Resources.pBar_05;
            if (e.ProgressPercentage == 60)
                dlp.Image = ExtremLauncher.Properties.Resources.pBar_06;
            if (e.ProgressPercentage == 70)
                dlp.Image = ExtremLauncher.Properties.Resources.pBar_07;
            if (e.ProgressPercentage == 80)
                dlp.Image = ExtremLauncher.Properties.Resources.pBar_08;
            if (e.ProgressPercentage == 90)
                dlp.Image = ExtremLauncher.Properties.Resources.pBar_09;
            if (e.ProgressPercentage > 98)
                dlp.Image = ExtremLauncher.Properties.Resources.pBar_10;
        }

        private void downloadUpdates_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            string version = get_version();
            string next_version = get_next_version();

            set_text("Download komplett. \n\r Starte den Update Vorgang....");

            if (entpacken(next_version))
                Application.Restart();
            else
                Application.Restart();
        }
        #endregion

        public Boolean entpacken(String filename)
        {
            if (File.Exists(filename + ".zip"))
            {
                try
                {
                    try
                    {
                        using (ZipFile zip = ZipFile.Read(filename + ".zip"))
                        {
                            zip.ExtractAll(Directory.GetCurrentDirectory(), ExtractExistingFileAction.OverwriteSilently);
                        }
                        if (File.Exists(Directory.GetCurrentDirectory() + "\\delete.ini"))
                        {
                            string line;
                            System.IO.StreamReader file = new System.IO.StreamReader(Directory.GetCurrentDirectory() + "\\delete.ini");
                            set_text("Lösche alte Dateien....");
                            while ((line = file.ReadLine()) != null)
                            {
                                if (line.Length > 0)
                                {
                                    string[] lines = line.Split(new Char[] { ':' });
                                    if(lines[0] == "f")
                                        if (File.Exists(Directory.GetCurrentDirectory() + "\\" + lines[1]))
                                            System.IO.File.Delete(Directory.GetCurrentDirectory() + "\\" + lines[1]);
                                    if (lines[0] == "d")
                                        if (Directory.Exists(Directory.GetCurrentDirectory() + "\\" + lines[1]))
                                            System.IO.Directory.Delete(Directory.GetCurrentDirectory() + "\\" + lines[1], true);
                                }
                            }
                            file.Close();
                            System.IO.File.Delete(Directory.GetCurrentDirectory() + "\\delete.ini");
                        }
                        File.Delete(filename + ".zip");
                        set_text("Starte Launcher neu....");
                        return true;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Konnte Update Zip nicht öffnen :(");
                        MessageBox.Show("Noch mal Versuchen oder Dateien manuell downloaden");
                        MessageBox.Show("und ins OA Verzeichnis tun. Und dann wieder auf Update klicken");
                        MessageBox.Show("UND DIE ZIP DATEIEN NICHT SELBST ENTPACKEN!!!!");
                        //File.Delete(filename + ".zip");
                        return false;
                    }
                }
                catch
                {
                    MessageBox.Show("Fehler beim Entpacken :(");
                    //File.Delete(filename + ".zip");
                    return false;
                }
            }
            else
                return false;
        }       
    }
}