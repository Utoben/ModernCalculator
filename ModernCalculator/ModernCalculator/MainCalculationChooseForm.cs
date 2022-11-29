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
    public partial class MainCalculationChooseForm : Form
    {
        public MainCalculationChooseForm()
        {
            InitializeComponent();
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Выберите компанию щелчком по кнопке");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KaztemirContractForm k = new KaztemirContractForm();
            k.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            StartForm s = new StartForm();
            s.ShowDialog();
        }
    }
}
