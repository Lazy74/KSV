﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KSV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.BackColor == System.Drawing.Color.BlueViolet)
            {
                this.BackColor = System.Drawing.Color.Green;
            }
            else
            {
                this.BackColor = System.Drawing.Color.BlueViolet;
            }
        }

        private void Form1_Deactivate(object sender, EventArgs e)
        {
            this.TopMost = true;
        }
    }
}
