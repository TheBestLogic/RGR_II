using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RGR_II
{
    public partial class StartForm : Form
    {
        byte iteration_step;
        public StartForm()
        {
            InitializeComponent();
        }

        private void button_StartNextEnd_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            StartForm_Load(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            checkBox2.Enabled = !checkBox1.Checked;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Enabled = !checkBox2.Checked;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            checkBox4.Enabled = !checkBox3.Checked;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            checkBox3.Enabled = !checkBox4.Checked;
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            checkBox6.Enabled = !checkBox5.Checked;
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            checkBox5.Enabled = !checkBox6.Checked;
        }

        private void StartForm_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            iteration_step = (byte)0;
        }
    }
}
