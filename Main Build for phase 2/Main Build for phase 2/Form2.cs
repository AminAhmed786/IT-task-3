﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main_Build_for_phase_2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();

            f3.Owner = this;

            f3.StartPosition = FormStartPosition.Manual;

            f3.Location = this.Location;

            this.Hide();
            f3.Show();
        }
    }
}
