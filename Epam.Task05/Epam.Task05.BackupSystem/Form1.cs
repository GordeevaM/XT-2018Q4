using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Epam.Task05.BackupSystem
{
    public partial class Form1 : Form
    {
        Monitoring mon = new Monitoring(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "MyFolder"));

        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            dateTimePicker1.Enabled = false;
            mon.Start();
        }

        private void RollbackRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            mon.Stop();
            dateTimePicker1.Enabled = true;
            Rollback rb = new Rollback(dateTimePicker1.Value);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            Rollback rb = new Rollback(dateTimePicker1.Value);
            rb.MakeCopy();
        }
    }
}
