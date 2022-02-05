using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using System.Diagnostics;

namespace Meoware
{
    public partial class UserControl_Info : UserControl
    {
        public UserControl_Info()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/v1ke/Meoware");
        }
    }
}
