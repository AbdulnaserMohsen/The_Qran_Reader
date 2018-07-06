﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Form4 : Form
    {
        Main main;
        public Form4(Main m)
        {
            main = m;
            InitializeComponent();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Width < 302)
            {
                this.Size = new Size(this.Size.Width + 1, this.Size.Height + 1);
                this.Location = new Point(this.Location.X - 1, this.Location.Y - 1);
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            this.Size = new Size(1, 1);
            this.Location = new Point(700, 700);
        }
    }
}
