﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeKiosk
{
    public partial class UCCoffee : UserControl
    {
        public UCCoffee()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //UCCoffeeOption uCCoOption = new UCCoffeeOption();
            //addUC(uCCoOption);
            MessageBox.Show("hi");
        }
    }
}