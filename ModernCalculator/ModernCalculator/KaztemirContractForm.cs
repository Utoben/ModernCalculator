using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModernCalculator
{
    public partial class KaztemirContractForm : Form
    {
        public KaztemirContractForm()
        {
            InitializeComponent();
        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void ToChooseButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainCalculationChooseForm s = new MainCalculationChooseForm();
            s.ShowDialog();
        }

        private void label167_Click(object sender, EventArgs e)
        {

        }

        private void label145_Click(object sender, EventArgs e)
        {

        }
    }
}
