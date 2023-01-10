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
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TraseryPriceBaseButton_Click(object sender, EventArgs e)
        {
            /*Form1 frm = new Form1();
            frm.Show();
            Close();*/
            this.Hide();// скрыть StartForm
            Form1 f = new Form1();
            f.ShowDialog();
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Приложение предназначено для калькуляции внутри компании 'Modern'.\nРаздел будет дополняться. \n\n Команда разработки");
        }

        private void MainCalculationButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            //MainCalculationChooseForm m = new MainCalculationChooseForm();
            KaztemirContractForm k = new KaztemirContractForm();
            k.ShowDialog();
        }
    }
}
