﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_Lab10
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            EndForm endForm = new EndForm();
            endForm.Show();
            Hide(); // StartForm.Hide();
        }

        private void MainForm_Close(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
