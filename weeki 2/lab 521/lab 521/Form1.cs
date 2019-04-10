using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_521
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] nishnebi = { 109, 67, 34, 96, 34, 12, 34, 56, 35, 24 };
            student studentobject -new student();
            label1.Text = studentobject.sashualoAritmetikuli(nishnebi).ToString();
        }
    }
}
