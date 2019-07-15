using System;
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
    public partial class EndForm : Form
    {
        public EndForm()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Program.mainForm.Show();
            Hide();
        }

        private void EndForm_Load(object sender, EventArgs e)
        {

        }

        private void EndForm_Close(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
