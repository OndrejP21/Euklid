using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Euklid
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Euklid euklid = new Euklid();
            if (_num1.Value > _num2.Value)
            {
                int divisor = euklid.Divisor((int)_num1.Value, (int)_num2.Value);
                MessageBox.Show(divisor.ToString());
            } else
            {
                MessageBox.Show("První číslo musí být větší než druhé!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
