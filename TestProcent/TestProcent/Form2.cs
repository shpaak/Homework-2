using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using stavka1;

namespace TestProcent
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal S = stavka1._0.Rates.Easy(Convert.ToDecimal(txti.Text), Convert.ToDecimal(txtn.Text),
                Convert.ToDecimal(txtP.Text));
                lblS.Text = S.ToString("F2"); 
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
