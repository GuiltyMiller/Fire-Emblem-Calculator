using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        private Form1 MainForm = null;

        public Form2(Form1 that)
        {
            InitializeComponent();
            MainForm = that;
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm.Form2Open = false;
        }
    }
}
