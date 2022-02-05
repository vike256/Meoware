using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Memory;

namespace Meoware
{
    public partial class UserControl_Cheats2 : UserControl
    {
        public Mem m = new Mem();

        public UserControl_Cheats2()
        {
            InitializeComponent();
        }

        private bool procOpen()
        {
            m.OpenProcess("Growtopia.exe");
            if (m.OpenProcess("Growtopia.exe"))
            {
                return true;
            }
            return false;
        }

        private void cb_slowmo_CheckedChanged(object sender, EventArgs e)
        {
            if (procOpen())
            {
                if (cb_slowmo.Checked)
                {
                    m.WriteMemory(Form1.Address.SlowMo, "bytes", "90 90");
                }
                else
                {
                    m.WriteMemory(Form1.Address.SlowMo, "bytes", "72 A7");
                }
            }
        }

        private void cb_tractor_CheckedChanged(object sender, EventArgs e)
        {
            if (procOpen())
            {
                if (cb_tractor.Checked)
                {
                    m.WriteMemory(Form1.Address.Tractor, "bytes", "0F 84 F2 00 00 00");
                }
                else
                {
                    m.WriteMemory(Form1.Address.Tractor, "bytes", "0F 85 F2 00 00 00");
                }
            }
        }
    }
}
