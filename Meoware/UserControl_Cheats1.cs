using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.Windows.Input;
using System.Diagnostics;
using System.Net;
using Memory;


namespace Meoware
{
    public partial class UserControl_Cheats1 : UserControl
    {
        public Mem m = new Mem();
        public int BaseAddress;


        public UserControl_Cheats1()
        {
            InitializeComponent();
        }

        private bool procOpen()
        {
            m.OpenProcess("Growtopia.exe");
            if (m.OpenProcess("Growtopia.exe")) return true;
            return false;
        }

        private void cb_antibounce_CheckedChanged(object sender, EventArgs e)
        {
            if (procOpen())
            {
                if (cb_antibounce.Checked)
                {
                    m.WriteMemory(Form1.Address.AntiBounce, "bytes", "90 90 90");
                }
                else
                {
                    m.WriteMemory(Form1.Address.AntiBounce, "bytes", "0F 28 FA");
                }
            }
        }

        private void cb_anticheckpoint_CheckedChanged(object sender, EventArgs e)
        {
            if (procOpen())
            {
                if (cb_anticheckpoint.Checked)
                {
                    m.WriteMemory(Form1.Address.AntiCheckPoint, "bytes", "90 90 90 90 90");
                }
                else
                {
                    m.WriteMemory(Form1.Address.AntiCheckPoint, "bytes", "83 7C 02 04 1B");
                }
            }
        }

        private void cb_antilava_CheckedChanged(object sender, EventArgs e)
        {
            if (procOpen())
            {
                if (cb_antilava.Checked)
                {
                    m.WriteMemory(Form1.Address.AntiLava, "bytes", "90 90");
                }
                else
                {
                    m.WriteMemory(Form1.Address.AntiLava, "bytes", "75 07");
                }
            }
        }

        private void cb_antipunch_CheckedChanged(object sender, EventArgs e)
        {
            if (procOpen())
            {
                if (cb_antipunch.Checked)
                {
                    m.WriteMemory(Form1.Address.AntiPunch, "bytes", "0F 84 C0 00 00 00");
                }
                else
                {
                    m.WriteMemory(Form1.Address.AntiPunch, "bytes", "0F 85 C0 00 00 00");
                }
            }
        }

        private void cb_antirespawn_CheckedChanged(object sender, EventArgs e)
        {
            if (procOpen())
            {
                if (cb_antirespawn.Checked)
                {
                    m.WriteMemory(Form1.Address.AntiRespawn, "bytes", "90 90");
                }
                else
                {
                    m.WriteMemory(Form1.Address.AntiRespawn, "bytes", "4F 6E");
                }
            }
        }

        private void cb_antislide_CheckedChanged(object sender, EventArgs e)
        {
            if (procOpen())
            {
                if (cb_antislide.Checked)
                {
                    m.WriteMemory(Form1.Address.AntiSlide, "bytes", "90 90");
                }
                else
                {
                    m.WriteMemory(Form1.Address.AntiSlide, "bytes", "75 03");
                }
            }
        }

        private void cb_antispike_CheckedChanged(object sender, EventArgs e)
        {
            if (procOpen())
            {
                if (cb_antispike.Checked)
                {
                    m.WriteMemory(Form1.Address.AntiSpike, "bytes", "0F 84 67 05 00 00");
                }
                else
                {
                    m.WriteMemory(Form1.Address.AntiSpike, "bytes", "0F 85 67 05 00 00");
                }
            }
        }

        private void cb_devmode_CheckedChanged(object sender, EventArgs e)
        {
            if (procOpen())
            {
                if (cb_devmode.Checked)
                {
                    m.WriteMemory(Form1.Address.DevMode, "bytes", "75 5F");
                }
                else
                {
                    m.WriteMemory(Form1.Address.DevMode, "bytes", "74 5F");
                }
            }
        }

        private void cb_fastinwater_CheckedChanged(object sender, EventArgs e)
        {
            if (procOpen())
            {
                if (cb_fastinwater.Checked)
                {
                    m.WriteMemory(Form1.Address.FastInWater, "bytes", "80 BF 88 01 00 00 01");
                }
                else
                {
                    m.WriteMemory(Form1.Address.FastInWater, "bytes", "F6 87 88 01 00 00 01");
                }
            }
        }

        private void cb_frogmode_CheckedChanged(object sender, EventArgs e)
        {
            if (procOpen())
            {
                if (cb_frogmode.Checked)
                {
                    m.WriteMemory(Form1.Address.FrogMode, "bytes", "90 90 90 90 90 90");
                }
                else
                {
                    m.WriteMemory(Form1.Address.FrogMode, "bytes", "0F 84 EF 00 00 00");
                }
            }
        }

        private void cb_ghost_CheckedChanged(object sender, EventArgs e)
        {
            if (procOpen())
            {
                if (cb_ghost.Checked)
                {
                    m.WriteMemory(Form1.Address.Ghost, "bytes", "EB 05");
                }
                else
                {
                    m.WriteMemory(Form1.Address.Ghost, "bytes", "74 05");
                }
            }
        }

        // Giveaway mode is basically ModFly+Ghost+NoClip
        // OFF turns them off only if their checkboxes are not checked
        private void cb_giveaway_CheckedChanged(object sender, EventArgs e)
        {
            if (procOpen())
            {
                if (cb_giveaway.Checked)
                {
                    m.WriteMemory(Form1.Address.ModFly, "bytes", "90 90");
                    m.WriteMemory(Form1.Address.Ghost, "bytes", "EB 05");
                    m.WriteMemory(Form1.Address.NoClip, "bytes", "90 90");
                }
                else
                {
                    if (!cb_noclip.Checked) m.WriteMemory(Form1.Address.NoClip, "bytes", "75 0B");
                    if (!cb_ghost.Checked) m.WriteMemory(Form1.Address.Ghost, "bytes", "74 05");
                    if (!cb_modfly.Checked) m.WriteMemory(Form1.Address.ModFly, "bytes", "74 5D");
                }
            }
        }

        private void cb_gravity_CheckedChanged(object sender, EventArgs e)
        {
            if (procOpen())
            {
                if (cb_gravity.Checked)
                {
                    m.WriteMemory(Form1.Address.Gravity, "bytes", "90 90 90 90 90 90");
                }
                else
                {
                    m.WriteMemory(Form1.Address.Gravity, "bytes", "0F 84 17 01 00 00");
                }
            }
        }

        private void cb_growz_CheckedChanged(object sender, EventArgs e)
        {
            if (procOpen())
            {
                if (cb_growz.Checked)
                {
                    m.WriteMemory(Form1.Address.Growz, "bytes", "90 90 90 90");
                }
                else
                {
                    m.WriteMemory(Form1.Address.Growz, "bytes", "F3 0F 5C D1");
                }
            }
        }

        private void cb_modfly_CheckedChanged(object sender, EventArgs e)
        {
            if (procOpen())
            {
                if (cb_modfly.Checked)
                {
                    m.WriteMemory(Form1.Address.ModFly, "bytes", "90 90");
                }
                else
                {
                    m.WriteMemory(Form1.Address.ModFly, "bytes", "74 5D");
                }
            }
        }

        private void modfly_down_timer_Tick(object sender, EventArgs e)
        {
            if (cb_modfly.Checked || cb_giveaway.Checked)
            {
                if (Keyboard.IsKeyDown(Key.S))
                {
                    m.WriteMemory(Form1.Address.ModFly, "bytes", "74 5D");
                }
                else
                {
                    m.WriteMemory(Form1.Address.ModFly, "bytes", "90 90");
                }
            }
        }

        private void cb_nightvision_CheckedChanged(object sender, EventArgs e)
        {
            if (procOpen())
            {
                if (cb_nightvision.Checked)
                {
                    m.WriteMemory(Form1.Address.NightVision, "bytes", "90 90");
                }
                else
                {
                    m.WriteMemory(Form1.Address.NightVision, "bytes", "75 06");
                }
            }
        }

        private void cb_noclip_CheckedChanged(object sender, EventArgs e)
        {
            if (procOpen())
            {
                if (cb_noclip.Checked)
                {
                    m.WriteMemory(Form1.Address.NoClip, "bytes", "90 90");
                }
                else
                {
                    m.WriteMemory(Form1.Address.NoClip, "bytes", "75 0B");
                }
            }
        }

        private void cb_slide_CheckedChanged(object sender, EventArgs e)
        {
            if (procOpen())
            {
                if (cb_slide.Checked)
                {
                    m.WriteMemory(Form1.Address.Slide, "bytes", "90 90");
                }
                else
                {
                    m.WriteMemory(Form1.Address.Slide, "bytes", "75 0E");
                }
            }
        }
    }
}
