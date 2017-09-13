using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace FormsDotNet2
{
    public partial class Form1 : Form
    {
        [DllImport("IAPWrapper")]
        extern static IntPtr Purchase(string storeID);
        public Form1()
        {
            InitializeComponent();
        }

        private void Demo_Click(object sender, EventArgs e)
        {
            Purchase(storeID.Text);
        }
    }
}
