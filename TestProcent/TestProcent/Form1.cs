using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestProcent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 dlg = new Form2();
            dlg.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 dlg = new Form3();
            dlg.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 dlg = new Form4();
            dlg.ShowDialog();
        }
    }
}
