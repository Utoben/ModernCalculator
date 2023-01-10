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
    public partial class MetallServiseForm : Form
    {
        public MetallServiseForm()
        {
            InitializeComponent();
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Проставьте значения");
        }

        private void ToChooseButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            //MainCalculationChooseForm s = new MainCalculationChooseForm();
            StartForm s = new StartForm();
            s.ShowDialog();
        }
    }
}
