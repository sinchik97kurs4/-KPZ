﻿using System;
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
      
      

        public Form2()
        {
            InitializeComponent();
           

        }

        private void Form2_Load(object sender, EventArgs e)
        {
         
               
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 History = new Form3();
            History.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 bookmarks = new Form4();
            bookmarks.ShowDialog();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dispose();
        }
    }
}
