using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsInput;

namespace LeagueOfLegends_ClipBoard
{
    public partial class FRM_Main : Form
    {
        string CustomKey1 = null;
        string CustomKey2 = null;
        string CustomKey3 = null;
        string CustomKey4 = null;
        string CustomKey5 = null;
        string CustomKey6 = null;
        string CustomKey7 = null;
        string WINDOWSNAME = "League of Legends (TM) Client";
        bool allChat = false;
        bool isActive = true;
        bool clientDetection = true;
        string ClipKey = "";
        Dictionary<string, string> keysHooked = new Dictionary<string, string>();
        string clipboardText;
        GlobalKeyboardHook gHook;
        public FRM_Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists(@"data.ecd"))
            {
                StreamReader SR = new StreamReader(@"data.ecd");
                string[] DATA = SR.ReadLine().Split('|');
                CustomKey7 = DATA[0];
                SR.Close();
                LBL_ExeKey7.Text = DATA[1];
                TBX_Custom1.Text = DATA[2];
                CustomKey1 = DATA[3];
                LBL_ExeKey1.Text = DATA[4];
                CustomKey2 = DATA[5];
                LBL_ExeKey2.Text = DATA[6];
                CustomKey3 = DATA[7];
                LBL_ExeKey3.Text = DATA[8];
                CustomKey4 = DATA[9];
                LBL_ExeKey4.Text = DATA[10];
                CustomKey5 = DATA[11];
                LBL_ExeKey5.Text = DATA[12];
                CustomKey6 = DATA[13];
                LBL_ExeKey6.Text = DATA[14];
                WINDOWSNAME = DATA[15];
            }
            else
            {
                StreamWriter SW = new StreamWriter(@"data.ecd");
                SW.WriteLine("53|(|Enter a custom sentence.|222|²|226|<|49|&|50|é|51|\"|52|'|League of Legends (TM) Client");
                SW.Flush();
                SW.Close();
                TBX_Custom1.Text = "Enter a custom sentence.";
                LBL_ExeKey7.Text = "(";
                LBL_ExeKey6.Text = "'";
                LBL_ExeKey5.Text = "\"";
                LBL_ExeKey4.Text = "é";
                LBL_ExeKey3.Text = "&&";
                LBL_ExeKey5.Text = "<";
                LBL_ExeKey1.Text = "²";

                StreamReader SR = new StreamReader(@"data.ecd");
                string[] DATA = SR.ReadLine().Split('|');

                CustomKey7 = DATA[0];
                CustomKey1 = DATA[3];
                CustomKey2 = DATA[5];
                CustomKey3 = DATA[7];
                CustomKey4 = DATA[9];
                CustomKey5 = DATA[11];
                CustomKey6 = DATA[13];
                SR.Close();
                //keysHooked.Add()
            }
            gHook = new GlobalKeyboardHook();
            gHook.KeyDown += new KeyEventHandler(gHook_KeyDown);
            foreach (Keys key in Enum.GetValues(typeof(Keys)))
            {
                gHook.HookedKeys.Add(key);
            }
            gHook.hook();
        }
        public void gHook_KeyDown(object sender, KeyEventArgs e)
        {
            bool canContinue = false;
            if(ClipKey.Contains("WaitingForKey"))
            {
                canContinue = true;
            }
            else
            {
                if (clientDetection == true)
                {
                    if (GetActiveWindowTitle() == WINDOWSNAME)
                    {
                        canContinue = true;
                    }
                }
                else
                {
                    canContinue = true;
                }
            }

            if(canContinue == true)
            {
                if (String.IsNullOrEmpty(ClipKey))
                {
                    if (e.KeyValue.ToString() == "162" || e.KeyValue.ToString() == "163")
                    {
                        ClipKey = "WaitingForOrder";
                    }
                }
                else
                {
                    if (ClipKey == "WaitingForOrder")
                    {
                        //C Key pressed (Copy)
                        //if (e.KeyValue.ToString() == "67")
                        //{
                        //ClipKey = "";
                        //}
                        //² Key pressed (Paste)
                        if (e.KeyValue.ToString() == CustomKey1)
                        {
                            clipboardText = Clipboard.GetText(TextDataFormat.Text);
                            if (string.IsNullOrEmpty(clipboardText) == false)
                            {
                                float PartsSize = 30;

                                IEnumerable<String> iText = StringSpliter.SplitString(clipboardText, (int)Math.Round(PartsSize));
                                var aText = iText.ToArray();
                                int i = 0;
                                InputSimulator Simulator = new InputSimulator();
                                if (allChat == true)
                                {
                                    Simulator.Keyboard.TextEntry("/all ");
                                }
                                Thread.Sleep(75);
                                while (i < aText.Length)
                                {
                                    Simulator.Keyboard.TextEntry(aText[i]);
                                    Thread.Sleep(75);
                                    i++;
                                }
                                if (CBX_ToggleAll.Checked == true)
                                {
                                    allChat = false;
                                }
                            }
                            ClipKey = "";
                        }
                        //'<' Key (toggle /all)
                        else if (e.KeyValue.ToString() == CustomKey2)
                        {
                            if (allChat == true)
                            {
                                allChat = false;
                            }
                            else
                            {
                                allChat = true;
                            }

                            ClipKey = "";
                        }
                        //'&' Key
                        else if (e.KeyValue.ToString() == CustomKey3)
                        {
                            InputSimulator Simulator = new InputSimulator();
                            if (allChat == true)
                            {
                                Simulator.Keyboard.TextEntry("/all ");
                            }
                            Simulator.Keyboard.TextEntry("GL & HF !");
                            if (CBX_ToggleAll.Checked == true)
                            {
                                allChat = false;
                            }
                            ClipKey = "";
                        }
                        //'é' key
                        else if (e.KeyValue.ToString() == CustomKey4)
                        {
                            InputSimulator Simulator = new InputSimulator();
                            if (allChat == true)
                            {
                                Simulator.Keyboard.TextEntry("/all ");
                            }
                            Simulator.Keyboard.TextEntry("I need help please.");
                            if (CBX_ToggleAll.Checked == true)
                            {
                                allChat = false;
                            }
                            ClipKey = "";
                        }
                        //'"' Key
                        else if (e.KeyValue.ToString() == CustomKey5)
                        {
                            InputSimulator Simulator = new InputSimulator();
                            if (allChat == true)
                            {
                                Simulator.Keyboard.TextEntry("/all ");
                            }
                            Simulator.Keyboard.TextEntry("Thank you very much!");
                            if (CBX_ToggleAll.Checked == true)
                            {
                                allChat = false;
                            }
                            ClipKey = "";
                        }
                        //''' Key
                        else if (e.KeyValue.ToString() == CustomKey6)
                        {
                            InputSimulator Simulator = new InputSimulator();
                            if (allChat == true)
                            {
                                Simulator.Keyboard.TextEntry("/all ");
                            }
                            Simulator.Keyboard.TextEntry("The pleasure is all mine!");
                            if (CBX_ToggleAll.Checked == true)
                            {
                                allChat = false;
                            }
                            ClipKey = "";
                        }
                        else if (e.KeyValue.ToString() == CustomKey7)
                        {
                            clipboardText = TBX_Custom1.Text;
                            if (string.IsNullOrEmpty(clipboardText) == false)
                            {
                                float PartsSize = 30;

                                IEnumerable<String> iText = StringSpliter.SplitString(clipboardText, (int)Math.Round(PartsSize));
                                var aText = iText.ToArray();
                                int i = 0;
                                InputSimulator Simulator = new InputSimulator();
                                if (allChat == true)
                                {
                                    Simulator.Keyboard.TextEntry("/all ");
                                }
                                Thread.Sleep(75);
                                while (i < aText.Length)
                                {
                                    Simulator.Keyboard.TextEntry(aText[i]);
                                    Thread.Sleep(75);
                                    i++;
                                }
                                if (CBX_ToggleAll.Checked == true)
                                {
                                    allChat = false;
                                }
                            }
                            ClipKey = "";
                        }
                        else
                        {
                            ClipKey = "";
                        }
                    }
                    else if (ClipKey.Contains("WaitingForKey"))
                    {
                        if (ClipKey == "WaitingForKey1")
                        {
                            CustomKey1 = e.KeyValue.ToString();
                            LBL_ExeKey1.Text = e.KeyData.ToString();
                            LBL_ExeKey1.BackColor = Color.FromArgb(11, 21, 40);
                        }
                        else if (ClipKey == "WaitingForKey2")
                        {
                            CustomKey2 = e.KeyValue.ToString();
                            LBL_ExeKey2.Text = e.KeyData.ToString();
                            LBL_ExeKey2.BackColor = Color.FromArgb(11, 21, 40);
                        }
                        else if (ClipKey == "WaitingForKey3")
                        {
                            CustomKey3 = e.KeyValue.ToString();
                            LBL_ExeKey3.Text = e.KeyData.ToString();
                            LBL_ExeKey3.BackColor = Color.FromArgb(11, 21, 40);
                        }
                        else if (ClipKey == "WaitingForKey4")
                        {
                            CustomKey4 = e.KeyValue.ToString();
                            LBL_ExeKey4.Text = e.KeyData.ToString();
                            LBL_ExeKey4.BackColor = Color.FromArgb(11, 21, 40);
                        }
                        else if (ClipKey == "WaitingForKey5")
                        {
                            CustomKey5 = e.KeyValue.ToString();
                            LBL_ExeKey5.Text = e.KeyData.ToString();
                            LBL_ExeKey5.BackColor = Color.FromArgb(11, 21, 40);
                        }
                        else if (ClipKey == "WaitingForKey6")
                        {
                            CustomKey6 = e.KeyValue.ToString();
                            LBL_ExeKey6.Text = e.KeyData.ToString();
                            LBL_ExeKey6.BackColor = Color.FromArgb(11, 21, 40);
                        }
                        else if (ClipKey == "WaitingForKey7")
                        {
                            CustomKey7 = e.KeyValue.ToString();
                            LBL_ExeKey7.Text = e.KeyData.ToString();
                            LBL_ExeKey7.BackColor = Color.FromArgb(11, 21, 40);
                        }

                        StreamWriter SW = new StreamWriter(@"data.ecd");
                        SW.WriteLine(CustomKey7 + "|" + LBL_ExeKey7.Text + "|" + TBX_Custom1.Text + "|" + CustomKey1 + "|" + LBL_ExeKey1.Text + "|" + CustomKey2 + "|" + LBL_ExeKey2.Text + "|" + CustomKey3 + "|" + LBL_ExeKey3.Text + "|" + CustomKey4 + "|" + LBL_ExeKey4.Text + "|" + CustomKey5 + "|" + LBL_ExeKey5.Text + "|" + CustomKey6 + "|" + LBL_ExeKey6.Text + "|" + WINDOWSNAME);
                        SW.Flush();
                        SW.Close();
                        ClipKey = "";

                    }
                }
            }          
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            gHook.unhook();
        }

        private void QuestionMarkButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This program was developped by Maxmistral and published under MIT license.\n\nLeague of Legends and Riot Games are registered trademarks of Riot Games, Inc. League of Legends © Riot Games, Inc. All rights reserved.\n\n For any questions, propositions, or if you just want to make sure this program is safe, you can ask for source code access by asking me on my discord : https://discord.gg/pQkvy6P. \n\nFor information purposes, the functionalities of this tool have been designed to be used for League of Legends but can also be used elsewhere. Indeed, under no circumstances are the game files modified.");
        }

        private void ReduceButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure to want to quit this application? Otherwise, this application will be reduced.", "Do you want to quit?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                GC.Collect();
                Application.Exit();
            }
            else if (dialogResult == DialogResult.No)
            {
                Hide();
                notifIcon.Visible = true;
                notifIcon.ShowBalloonTip(1000);
                GC.Collect();
            }
        }

        //======================== Border =======================
        private void FRM_Main_Windows_Paint(object sender, PaintEventArgs e)
        {
            int width = this.Width - 1;
            int height = this.Height - 1;
            Pen DrawBorder = new Pen(Color.FromArgb(147, 115, 65), 4);
            e.Graphics.DrawRectangle(DrawBorder, 0, 0, width, height);
        }

        //=============================== Move Windows ===================================

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        //private void Form1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        private void OnStayClick_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void LBL_isActive_MouseEnter(object sender, EventArgs e)
        {
            if (isActive == true)
            {
                LBL_isActive.ForeColor = Color.DarkGreen;
            }
            else
            {
                LBL_isActive.ForeColor = Color.Maroon;
            }
        }

        private void LBL_isActive_MouseLeave(object sender, EventArgs e)
        {
            if (isActive == true)
            {
                LBL_isActive.ForeColor = Color.Green;
            }
            else
            {
                LBL_isActive.ForeColor = Color.DarkRed;
            }
        }

        private void LBL_isActive_Click(object sender, EventArgs e)
        {
            if (isActive == true)
            {
                LBL_isActive.Text = "✖";
                LBL_isActive.ForeColor = Color.Maroon;
                isActive = false;
                gHook.unhook();
                notifIcon.Text = "LoL ClipBoard Inactive";
            }
            else
            {
                LBL_isActive.Text = "✔";
                LBL_isActive.ForeColor = Color.DarkGreen;
                isActive = true;
                gHook.hook();
                notifIcon.Text = "LoL ClipBoard Active";
            }
        }

        private void notifIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
            notifIcon.Visible = false;
        }

        private void LBL_Version_MouseHover(object sender, EventArgs e)
        {
            TTIP_Ver.Show("Version number.Number of release.Number of code update", this.LBL_Version);
        }

        private void LBL_Modify1_Click(object sender, EventArgs e)
        {
            if (TBX_Custom1.Enabled == true)
            {
                if (String.IsNullOrWhiteSpace(TBX_Custom1.Text) == true)
                {
                    TBX_Custom1.Text = "Enter custom sentence.";
                }
                TBX_Custom1.Enabled = false;
                StreamReader SR = new StreamReader(@"data.ecd");
                string[] OLDDATA = SR.ReadLine().Split('|');
                SR.Close();
                StreamWriter SW = new StreamWriter(@"data.ecd");
                SW.WriteLine(OLDDATA[0] + "|" + OLDDATA[1] + "|" + TBX_Custom1.Text + "|" + CustomKey1 + "|" + LBL_ExeKey1.Text + "|" + CustomKey2 + "|" + LBL_ExeKey2.Text + "|" + CustomKey3 + "|" + LBL_ExeKey3.Text + "|" + CustomKey4 + "|" + LBL_ExeKey4.Text + "|" + CustomKey5 + "|" + LBL_ExeKey5.Text + "|" + CustomKey6 + "|" + LBL_ExeKey6.Text + "|" + WINDOWSNAME);
                SW.Flush();
                SW.Close();
            }
            else if (TBX_Custom1.Enabled == false)
            {
                if (!ClipKey.Contains("WaitingForKey"))
                {
                    ClipKey = "";
                    LBL_ExeKey7.BackColor = Color.FromArgb(11, 21, 40);
                }
                TBX_Custom1.Enabled = true;
                TBX_Custom1.Focus();
            }
        }

        private void LBL_ExeKey7_Click(object sender, EventArgs e)
        {
            if (!ClipKey.Contains("WaitingForKey"))
            {
                if (TBX_Custom1.Enabled == true)
                {
                    TBX_Custom1.Enabled = false;
                }
                ClipKey = "WaitingForKey7";
                LBL_ExeKey7.BackColor = Color.FromArgb(21, 41, 79);
            }
            else
            {
                ClipKey = "";
                LBL_ExeKey7.BackColor = Color.FromArgb(11, 21, 40);
            }
        }
        private void LBL_ExeKey6_Click(object sender, EventArgs e)
        {
            if (!ClipKey.Contains("WaitingForKey"))
            {
                if (TBX_Custom1.Enabled == true)
                {
                    TBX_Custom1.Enabled = false;
                }
                ClipKey = "WaitingForKey6";
                LBL_ExeKey6.BackColor = Color.FromArgb(21, 41, 79);
            }
            else
            {
                ClipKey = "";
                LBL_ExeKey6.BackColor = Color.FromArgb(11, 21, 40);
            }
        }

        private void LBL_ExeKey5_Click(object sender, EventArgs e)
        {
            if (!ClipKey.Contains("WaitingForKey"))
            {
                if (TBX_Custom1.Enabled == true)
                {
                    TBX_Custom1.Enabled = false;
                }
                ClipKey = "WaitingForKey5";
                LBL_ExeKey5.BackColor = Color.FromArgb(21, 41, 79);
            }
            else
            {
                ClipKey = "";
                LBL_ExeKey5.BackColor = Color.FromArgb(11, 21, 40);
            }
        }

        private void LBL_ExeKey4_Click(object sender, EventArgs e)
        {
            if (!ClipKey.Contains("WaitingForKey"))
            {
                if (TBX_Custom1.Enabled == true)
                {
                    TBX_Custom1.Enabled = false;
                }
                ClipKey = "WaitingForKey4";
                LBL_ExeKey4.BackColor = Color.FromArgb(21, 41, 79);
            }
            else
            {
                ClipKey = "";
                LBL_ExeKey4.BackColor = Color.FromArgb(11, 21, 40);
            }
        }

        private void LBL_ExeKey3_Click(object sender, EventArgs e)
        {
            if (!ClipKey.Contains("WaitingForKey"))
            {
                if (TBX_Custom1.Enabled == true)
                {
                    TBX_Custom1.Enabled = false;
                }
                ClipKey = "WaitingForKey3";
                LBL_ExeKey3.BackColor = Color.FromArgb(21, 41, 79);
            }
            else
            {
                ClipKey = "";
                LBL_ExeKey3.BackColor = Color.FromArgb(11, 21, 40);
            }
        }

        private void LBL_ExeKey2_Click(object sender, EventArgs e)
        {
            if (!ClipKey.Contains("WaitingForKey"))
            {
                if (TBX_Custom1.Enabled == true)
                {
                    TBX_Custom1.Enabled = false;
                }
                ClipKey = "WaitingForKey2";
                LBL_ExeKey2.BackColor = Color.FromArgb(21, 41, 79);
            }
            else
            {
                ClipKey = "";
                LBL_ExeKey2.BackColor = Color.FromArgb(11, 21, 40);
            }
        }

        private void LBL_ExeKey1_Click(object sender, EventArgs e)
        {
            if (!ClipKey.Contains("WaitingForKey"))
            {
                if (TBX_Custom1.Enabled == true)
                {
                    TBX_Custom1.Enabled = false;
                }
                ClipKey = "WaitingForKey1";
                LBL_ExeKey1.BackColor = Color.FromArgb(21, 41, 79);
            }
            else
            {
                ClipKey = "";
                LBL_ExeKey1.BackColor = Color.FromArgb(11, 21, 40);
            }
        }

        private void LBL_Modify1_MouseEnter(object sender, EventArgs e)
        {
            LBL_Modify1.ForeColor = Color.FromArgb(122, 95, 54);
        }

        private void LBL_Modify1_MouseLeave(object sender, EventArgs e)
        {
            LBL_Modify1.ForeColor = Color.FromArgb(147, 115, 65);            
        }


        [DllImport("user32.dll")]
        static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll")]
        static extern int GetWindowText(IntPtr hWnd, StringBuilder text, int count);

        [DllImport("user32.dll")]
        static extern int GetWindowModuleFileName(IntPtr hWnd, StringBuilder text, uint count);

        private string GetActiveWindowTitle()
        {
            const int nChars = 256;
            StringBuilder Buff = new StringBuilder(nChars);
            IntPtr handle = GetForegroundWindow();

            if (GetWindowText(handle, Buff, nChars) > 0)
            {
                return Buff.ToString();
            }
            return null;
        }

        private string GetActiveWindowProcess()
        {
            const int nChars = 256;
            StringBuilder Buff = new StringBuilder(nChars);
            IntPtr handle = GetForegroundWindow();

            if (GetWindowModuleFileName(handle, Buff, nChars) > 0)
            {
                return Buff.ToString();
            }
            return null;
        }

        private void CBX_ClientDetection_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CBX_ClientDetection_CheckedChanged_1(object sender, EventArgs e)
        {
            clientDetection = CBX_ClientDetection.Checked;
        }
    }
}
