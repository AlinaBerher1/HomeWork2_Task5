using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void buttonByte_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("from 0 to 255");
        }
        private void buttonSbyte_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("from -128 to 127");
        }
        private void buttonShort_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("from -32 768 to 32 767");
        }
        private void buttonUshort_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("from 0 to 65 535");
        }
        private void buttonInt_Click(object sender, EventArgs e)
        {
            MessageBox.Show("from -2 147 483 648 to 2 147 483 647");
        }
        private void buttonUint_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("from 0 to 4 294 967 295");
        }
        private void buttonLong_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("from -9 223 372 036 854 775 808 to 9 223 372 036 854 775 807");
        }
        private void buttonUlong_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("from 0 to 18 446 744 073 709 551 615");
        }
    }
}
