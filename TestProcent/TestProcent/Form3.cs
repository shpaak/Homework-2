﻿using System;
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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal S = stavka1._0.Rates.Hard(Convert.ToDecimal(txtj.Text), Convert.ToDecimal(txtm.Text),
                Convert.ToDecimal(txtn.Text), Convert.ToDecimal(txtP.Text));
            lblS.Text = S.ToString("F2");
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
