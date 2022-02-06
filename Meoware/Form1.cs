using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Memory;
using System.Threading;

namespace Meoware
{
    public partial class Form1 : Form
    {
        public Mem mem = new Mem();

        bool ProcOpen = false;
        public static bool IsAttached = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void BGWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            ProcOpen = mem.OpenProcess("Growtopia");

            if (!ProcOpen) IsAttached = false;

            Thread.Sleep(100);
            BGWorker.ReportProgress(0);
        }

        private void BGWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (ProcOpen)
            {
                ProcOpenLabel.Text = "Growtopia Found";
                ProcOpenLabel.ForeColor = Color.FromArgb(0, 255, 0);

                if (!IsAttached)
                {
                    Thread.Sleep(2000);
                    LoadAddresses();
                }
            }
            else
            {
                ProcOpenLabel.Text = "No Growtopia";
                ProcOpenLabel.ForeColor = Color.FromArgb(255, 0, 0);
                IsAttached = false;
                AttachLabel.Text = "Not Attached";
                AttachLabel.ForeColor = Color.FromArgb(255, 0, 0);
            }
            Thread.Sleep(100);
        }

        private void BGWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            BGWorker.RunWorkerAsync();
        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        // Remove default window borders
        protected override void WndProc(ref Message m)
        {
            const int WM_NCCALSIZE = 0x0083;
            if (m.Msg == WM_NCCALSIZE && m.WParam.ToInt32() == 1)
            {
                return;
            }
            base.WndProc(ref m);
        }

        // Exit button. Turns off all cheats so if you open Meoware again the aob scan can find them.
        private void button_exit_Click(object sender, EventArgs e)
        {
            if (ProcOpen && IsAttached)
            {
                mem.WriteMemory(Address.AntiBounce, "bytes", "0F 28 FA");
                mem.WriteMemory(Address.AntiCheckPoint, "bytes", "83 7C 02 04 1B");
                mem.WriteMemory(Address.AntiLava, "bytes", "75 07");
                mem.WriteMemory(Address.AntiPunch, "bytes", "0F 85 C0 00 00 00");
                mem.WriteMemory(Address.AntiRespawn, "bytes", "4F 6E");
                mem.WriteMemory(Address.AntiSlide, "bytes", "75 03");
                mem.WriteMemory(Address.AntiSpike, "bytes", "0F 85 67 05 00 00");
                mem.WriteMemory(Address.DevMode, "bytes", "74 5F");
                mem.WriteMemory(Address.FastInWater, "bytes", "F6 87 88 01 00 00 01");
                mem.WriteMemory(Address.FrogMode, "bytes", "0F 84 EF 00 00 00");
                mem.WriteMemory(Address.Ghost, "bytes", "74 05");
                mem.WriteMemory(Address.Gravity, "bytes", "0F 84 17 01 00 00");
                mem.WriteMemory(Address.Growz, "bytes", "F3 0F 5C D1");
                mem.WriteMemory(Address.ModFly, "bytes", "74 5D");
                mem.WriteMemory(Address.NightVision, "bytes", "75 06");
                mem.WriteMemory(Address.NoClip, "bytes", "75 0B");
                mem.WriteMemory(Address.Slide, "bytes", "75 0E");
                mem.WriteMemory(Address.SlowMo, "bytes", "72 A7");
                mem.WriteMemory(Address.Tractor, "bytes", "0F 85 F2 00 00 00");
            }
            Application.Exit();
        }

        // Minimize button
        private void button_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // Show Cheats 1 tab and hide others
        private void button_cheats1_Click(object sender, EventArgs e)
        {
            button_info.BackColor = Color.FromArgb(40, 60, 95);
            button_cheats2.BackColor = Color.FromArgb(40, 60, 95);
            button_cheats1.BackColor = Color.FromArgb(65, 80, 130);

            userControl_Info1.Hide();
            userControl_Cheats21.Hide();
            userControl_Cheats11.Show();
            userControl_Cheats11.BringToFront();
        }

        // Show Cheats 2 tab and hide others
        private void button_cheats2_Click(object sender, EventArgs e)
        {
            button_info.BackColor = Color.FromArgb(40, 60, 95);
            button_cheats2.BackColor = Color.FromArgb(65, 80, 130);
            button_cheats1.BackColor = Color.FromArgb(40, 60, 95);

            userControl_Cheats11.Hide();
            userControl_Info1.Hide();
            userControl_Cheats21.Show();
            userControl_Cheats21.BringToFront();
        }

        // Show Info tab and hide others
        private void button_info_Click(object sender, EventArgs e)
        {
            button_info.BackColor = Color.FromArgb(65, 80, 130);
            button_cheats2.BackColor = Color.FromArgb(40, 60, 95);
            button_cheats1.BackColor = Color.FromArgb(40, 60, 95);

            userControl_Cheats11.Hide();
            userControl_Cheats21.Hide();
            userControl_Info1.Show();
            userControl_Info1.BringToFront();
        }


        private void Form1_Shown(object sender, EventArgs e)
        {
            BGWorker.RunWorkerAsync();
        }

        // Assigns addresses
        public struct Addresses
        {
            public string BanBypass;
            public string AntiSlide;
            public string AntiBounce;
            public string ModFly;
            public string AntiLava;
            public string AntiCheckPoint;
            public string AntiPunch;
            public string AntiRespawn;
            public string AntiSpike;
            //public string FastFall;
            public string ForceFps;
            public string NightVision;
            public string Slide;
            public string Tractor;
            public string NoClip;
            public string Gravity;
            //public string HighJump;
            public string Ghost;
            public string Growz;
            public string FastInWater;
            //public string FastDrop;
            //public string FastPickup;
            //public string AntiState;
            public string SlowMo;
            //public string AutoJump;
            public string FrogMode;
            //public string Ceme;
            //public string AutoPunch;
            //public string WaterVisual;
            //public string SmallJump;
            public string DevMode;
            //public string AntiKnockBack;
            //public string Chat;
        }
        public static Addresses Address = new Addresses();

        // Scans game code for opcodes
        public async void LoadAddresses()
        {
            IsAttached = true;
            AttachLabel.Text = "Attaching...";
            AttachLabel.ForeColor = Color.FromArgb(0, 255, 255);
            var PBP = await AoBScan("0F 85 18 01 00 00 C7 86 ?? ?? 00 00 01 00 00 00 48 8B CE E8 ?? ?? FF FF 84 C0 0F 84 FE 00 00 00 F3 0F 10 46 18 F3 0F 11 44 24 50 F3 0F 10 4E 1C F3 0F 11 4C 24 54 F3 0F 10 46 08 F3 0F 11 44 24 30 F3 0F 10 4E 0C F3 0F 11 4C 24 34 E8 ?? ?? ?? FF 41 B9 01 00 00 00 E9 AB 00 00 00 44 38 BE ?? ?? 00 00");
            var AIC = await AoBScan("76 08 32 C0 48 83 C4 30 5B C3 F3 0F 10 05 ?? ?? ?? 00 F3 0F 59 05 ?? ?? ?? 00 0F 29 74 24 20 F3 0F 10 35 ?? ?? ?? 00 F3 0F 5C F0");
            var BBP = await AoBScan("75 08 85 C9 0F 85 8B 00 00 00 C7 05 ?? ?? ?? 00 01 00 00 00 48 8B 8B ?? 01 00 00 48 85 C9 74 75 E8 ?? ?? ?? 00 84 C0 74 6C 48 C7 44 24 40 00 00 00 00 48 C7 44 24 30 00 00 00 00");

            mem.WriteMemory(PBP, "bytes", "90 90 90 90 90");
            mem.WriteMemory(AIC, "bytes", "90 90");
            mem.WriteMemory(BBP, "bytes", "90 90");

            Address.BanBypass = await AoBScan("?? ?? 85 C9 0F 85 8B 00 00 00 C7 05 ?? ?? ?? 00 01 00 00 00 48 8B 8B 98 01 00 00 48 85 C9 74"); // 2 bytes, 75 08
            Address.AntiSlide = await AoBScan("?? ?? 45 8B FC 48 8B 45 07 44 88 BF ?? ?? 00 00 0F B7 58 04 E8 ?? ?? ?? FF 8B 8F ?? ?? 00 00 4C 8B BC 24 A0 00 00 00 4C 8B B4 24 E0 00 00 00 48 8B 40 08 48 8B B4 24 D8 00 00 00 48 69 D3 ?? ?? 00 00"); // 2 bytes, 75 03
            Address.AntiBounce = await AoBScan("?? ?? ?? F3 0F 58 BC 24 ?0 00 00 00 0F 28 C7 F3 0F 58 C6 F3 0F 11 44 24 ?C 0F 57 C9 F3 0F 7F 48 80 48 C7 40 90 00 00 00 00 4C 8D 40 80 48 8D 54 24 ?0"); // 3 bytes, 0F 28 FA
            Address.ModFly = await AoBScan("?? ?? 8B 4F 14 83 F9 07 75 05 40 84 ED 75 50 0F B6 47 0A 66 0F 6E D0 0F 5B D2"); // 2 bytes, 74 5D
            Address.AntiLava = await AoBScan("?? ?? 83 8B ?? ?? 00 00 40 48 8D 8B ?? ?? 00 00 33 D2 48 83 C4 40 5B"); // 2 bytes, 75 07
            Address.AntiCheckPoint = await AoBScan("83 7C 02 04 1B 0F 94 C0 48 83 C4 20 5B C3"); // 5 bytes, 83 7C 02 04 1B
            Address.AntiPunch = await AoBScan("?? ?? ?? ?? ?? ?? E8 ?? ?? ?? FF 48 8B C8 E8 ?? ?? ?? FF 48 8B C8 48 8D 55 C7 E8 ?? ?? 00 00 48 8B D0 49 8B CE E8 ?? ?? ?? 00 84 C0"); // 6 bytes, 0F 85 C0 00 00 00
            Address.AntiRespawn = await AoBScan("?? ?? 53 65 74 50 6F 73 00 00 00 00 00 00 00 00 4F 6E 53 65 74 46 72 65 65 7A 65 53 74 61 74 65"); // 2 bytes, 4F 6E
            //Address.AntiRespawnMaybeOld = await AoBScan("80 7B 24 00 75 10 8B 43 28 01 43 14 83 C0 03 01 43 58 83 43 18 03 66 0F 6E 43 28 0F 5B C0");
            Address.AntiSpike = await AoBScan("0F 85 67 05 00 00 48 85 ?? ?? 32 48 8B CA E8 ?? ?? 04 00 B9 FE 18 00 00 66 3B C1"); // 6 bytes , 0F 85 67 05 00 00
            //Address.FastFall = await AoBScan("0F 84 ?? 00 00 00 F3 0F 10 81 ?? 01 00 00 F3 0F 10 89 ?? ?? 00 00 F3 41 0F 59 C0 F3 0F 5C C8 41 0F 2F CA 76 2A F3 0F 10 89 ?? 01 00 00 0F 28 C1 F3 41 0F 58 CA F3 41 0F 59 C0 F3 41 0F 58 C2 F3 0F 11 89 ?? ?? 00 00 F3 0F 11 81 ?? ?? 00 00 ?? ?? ?? ?? ?? ?? 00");
            Address.ForceFps = await AoBScan("0F 84 ?? 01 00 00 E8 ?? ?? ?? 00 48 8B D8 8B BE ?? 02 00 00 E8 ?? ?? ?? 00 C1 E8 0A 8B C8 0F 57 C0 F3 48 0F 2A C1 F3 0F 10 35 ?? ?? ?? 00 F3 0F 59 C6 0F 5A F8");
            Address.NightVision = await AoBScan("75 06 48 83 C4 20 5B C3 B8 F8 0D 00 00 66 39 43 12 75 67 48 8B 4B 20 48 8B 01 48 3B C1"); // 2 bytes, 75 06
            Address.Slide = await AoBScan("75 0E B8 2A 15 00 00 66 39 87 ?? ?? 00 00 75 03 45 8B FC"); // 2 bytes, 75 0E
            Address.Tractor = await AoBScan("0F 85 ?? 00 00 00 49 8D 8E ?? ?? 00 00 E8 ?? ?? ?? FF 84 C0 0F 84 ?? 00 00 00 48 83 7E 28 00 0F 84 ?? 00 00 00 48 8B CE E8 ?? ?? 04 00 0F B7 D8"); // 6 bytes, 0F 85 F2 00 00 00
            Address.NoClip = await AoBScan("?? ?? 32 C0 48 83 C4 20 41 5F ?? ?? C3 45 84 C9 74 0D 8B 41 14 83 F8 02 74 ?? 83 F8 07 74 ?? 8B 41 14 83 F8 05"); // 2 bytes, 75 0B
            Address.Gravity = await AoBScan("0F 84 ?? 01 00 00 80 BB ?? ?? 00 00 00 F3 0F 10 05 ?? ?? ?? 00 F3"); // 6 bytes, 0F 84 17 01 00 00
            //Address.HighJump = await AoBScan("75 1D F3 0F 10 0D ?? ?? ?? 00 F3 0F 10 05 ?? ?? ?? 00 F3 41 0F 59 C8 F3 0F 5C C1 F3 0F 59 F8 80 BB A1 01 00 00 00 0F 84 ?? 01 00 00 80 BB ?? ?? 00 00 00");
            Address.Ghost = await AoBScan("?? ?? E8 ?? ?? FF FF 48 8B CE E8 ?? ?? ?? ?? 48 83 BE 20 01 00 00 00 75 08 48 8B CE E8 ?? ?? 00 00 4C 8D 9C 24 28 01 00 00 41 0F 28 73 E8"); // 2 bytes, 74 05
            Address.Growz = await AoBScan("?? ?? ?? ?? 0F 28 F2 F3 44 0F 58 C2 F3 41 0F 58 F3 74 22 F6 87 88 01 00 00 01 75 19 F3 0F 10 87 F4 01 00 00 45 0F 28 C4 0F 28 F0 F3 44 0F 58 C0 F3 41 0F 58 F3 80 BF DE 00 00 00 00"); // 4 bytes, F3 0F 5C D1
            Address.FastInWater = await AoBScan("?? ?? ?? ?? ?? ?? ?? 75 19 F3 0F 10 87 F4 01 00 00 45 0F 28 C4 0F 28 F0 F3 44 0F 58 C0 F3 41 0F 58 F3 80 BF DE 00 00 00 00 74 27"); // 7 bytes, F6 87 88 01 00 00 01
            //Address.FastDrop = await AoBScan("E8 ?? ?? ?? FF 89 43 28 48 8D 43 10 48 8B 5C 24 70 48 8B 6C 24 78 48 8B B4 24 80 00 00 00 48 83 C4 50 41 5F 41 5E 5F C3");
            //Address.FastPickup = await AoBScan("73 19 80 63 13 FE C7 43 1C 00 00 00 00 F3 0F 10 05 ?? ?? ?? 00 48 83 C4 30 5B C3 F6 43 13 01");
            //Address.AntiState = await AoBScan("0F 84 ?? 16 00 00 48 8B D6 48 8B C8 E8 ?? ?? 0F 00 E9 ?? 16 00 00 E8 ?? ?? ?? FF 48 8D 88 60 01 00 00 8B 56 04 E8 ?? ?? 10 00 48 8B D8 48 85 C0");
            Address.SlowMo = await AoBScan("?? ?? 48 8B AC 24 88 00 00 00 4C 8B 74 24 60 0F 57 C0 48 8B 7C 24 68 48 85 F6 F3 48 0F 2A C6 48 8B B4 24 90 00 00 00"); // 2 bytes, 72 A7
            //Address.AutoJump = await AoBScan("74 09 80 BB A9 01 00 00 00 74 2B 80 BB 30 01 00 00 00 0F 85 ?? 02 00 00 F3 0F 10 83 C8 00 00 00 0F 2F C6 0F 86 ?? 02 00 00 80 BB A9 01 00 00 00");
            Address.FrogMode = await AoBScan("?? ?? ?? ?? ?? ?? 80 BE 30 01 00 00 00 75 3C 80 BE A0 01 00 00 00 75 3C F3 0F 10 86 00 01 00 00 F3 41 0F 59 C0 F3 0F 10 96 F4 00 00 00 F3 0F 5C D0 F3 41 0F 59 D4 44 8B 8E 3C 01 00 00"); // 6 bytes, 0F 84 EF 00 00 00
            //Address.Ceme = await AoBScan("0F B7 47 04 44 0F B6 77 30 89 5F 40 66 85 C0 75 04 0F B7 47 06 0F B7 D8");
            //Address.AutoPunch = await AoBScan("74 5F F3 0F 10 88 ?? ?? 00 00 0F 28 C1 F3 41 0F 58 C8 F3 0F 59 C7 F3 0F 11 88 ?? ?? 00 00 F3 41 0F 58 C0 F3 0F 11 80 ?? ?? 00 00 48 8B 43 08");
            //Address.WaterVisual = await AoBScan("74 1E 45 0F B6 46 0B 48 8D 8E 58 03 00 00 41 0F B6 56 0A 41 B1 01 C6 44 24 20 00 E8 ?? ?? ?? FF C6 86 A1 01 00 00 00");
            //Address.SmallJump = await AoBScan("75 12 B8 2C 15 00 00 66 39 83 CC 02 00 00 0F 85 C1 00 00 00 80 BB DE 00 00 00 00 0F 85 B4 00 00 00 48 85 F6");
            Address.DevMode = await AoBScan("7? 5F E8 ?? ?? ?? FF 48 69 D6 ?? 06 00 00 48 8B 40 08 83 7C 02 04 00 75 25 41 83 C9 FF"); // 2 bytes, 74 5F
            //Address.AntiKnockBack = await AoBScan("48 8B D9 F3 0F 10 49 0C 49 8B F8 F3 0F 5C 02 F3 0F 5C 4A 04 48 8D 4C 24 40 0F 29 74 24 20 F3 0F 11 44 24 40 F3 0F 11 4C 24 44");
            //Address.Chat = await AoBScan("?? 00 00 00 90 B2 BA D1 E4 01 00 00 00 00 00 00 00 00 00 00 73 6F 6C 69 64 00 00 00 00 00 00 00");
            mem.WriteMemory(Address.BanBypass, "bytes", "90 90");
            AttachLabel.Text = "Attached";
            AttachLabel.ForeColor = Color.FromArgb(0, 255, 0);
            mem.WriteMemory(Address.ForceFps, "bytes", "90 90 90 90 90 90");
            return;
        }

        public async Task<string> AoBScan(string Aob)
        {
            IEnumerable<long> AoBScanResults = await mem.AoBScan(Aob);
            long SingleAoBScanResult = AoBScanResults.FirstOrDefault();
            return SingleAoBScanResult.ToString("X");
        }

        // Opens Growtopia when "Open Growtopia" button is pressed
        private void button_open_growtopia_Click(object sender, EventArgs e)
        {
            string LocalAppDataPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            System.Diagnostics.Process.Start(System.IO.Path.Combine(LocalAppDataPath, @"Growtopia\Growtopia.exe"));
        }

        // Make window always on top
        private void cb_lock_window_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_lock_window.Checked)
            {
                ActiveForm.TopMost = true;
            }
            else
            {
                ActiveForm.TopMost = false;
            }
        }
    }
}
