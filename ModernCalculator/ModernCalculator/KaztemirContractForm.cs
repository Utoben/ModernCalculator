using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModernCalculator
{
    public partial class KaztemirContractForm : Form
    {
        public double Arm10Text, Arm12Text, Arm14Text, Arm16Text, Arm18Text;
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

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Проставьте значения");
        }

        private void RezultButton_Click(object sender, EventArgs e)
        {


            double.TryParse(Arm10TB.Text, out Arm10Text);
            double.TryParse(Arm12TB.Text, out Arm12Text);
            double.TryParse(Arm14TB.Text, out Arm14Text);
            double.TryParse(Arm16TB.Text, out Arm16Text);
            double.TryParse(Arm18TB.Text, out Arm18Text);

            Count_And_Sum_Rezult();
            Percent_and_Whils_Rezult();


        }

        void Count_And_Sum_Rezult()
        {
            //подсчет Количества(Общий вес)
            TotalCount_Arm10Label.Text = Convert.ToString(Math.Round((Arm10Text * Convert.ToDouble(label13.Text)),2));
            TotalCount_Arm12Label.Text = Convert.ToString(Math.Round(Arm12Text * Convert.ToDouble(label12.Text),2));
            TotalCount_Arm14Label.Text = Convert.ToString(Math.Round(Arm14Text * Convert.ToDouble(label11.Text),2));
            TotalCount_Arm16Label.Text = Convert.ToString(Math.Round(Arm16Text * Convert.ToDouble(label10.Text),2));
            TotalCount_Arm18Label.Text = Convert.ToString(Math.Round(Arm18Text * Convert.ToDouble(label9.Text),2));







            //подсчет Суммы
            TotalSum_Arm10Label.Text = Convert.ToString(Math.Round(Arm10Text * Convert.ToDouble((label43.Text))));
            TotalSum_Arm12Label.Text = Convert.ToString(Math.Round(Arm12Text * Convert.ToDouble((label42.Text))));
            TotalSum_Arm14Label.Text = Convert.ToString(Math.Round(Arm14Text * Convert.ToDouble((label41.Text))));
            TotalSum_Arm16Label.Text = Convert.ToString(Math.Round(Arm16Text * Convert.ToDouble((label40.Text))));
            TotalSum_Arm18Label.Text = Convert.ToString(Math.Round(Arm18Text * Convert.ToDouble((label39.Text))));


        }

        void Percent_and_Whils_Rezult()
        {
            //подсчет процентов(20%)
            Perc20_Arm10Label.Text = Convert.ToString(Math.Round(Arm10Text * 20 / 100,1));
            Perc20_Arm12Label.Text = Convert.ToString(Math.Round(Arm12Text * 20 / 100,1));
            Perc20_Arm14Label.Text = Convert.ToString(Math.Round(Arm14Text * 20 / 100,1));
            Perc20_Arm16Label.Text = Convert.ToString(Math.Round(Arm16Text * 20 / 100,1));
            Perc20_Arm18Label.Text = Convert.ToString(Math.Round(Arm18Text * 20 / 100,1));

            //подсчет Хлыстов
            Whip_Arm10Label.Text = Convert.ToString(Math.Round(Arm10Text / 6,2));
            Whip_Arm12Label.Text = Convert.ToString(Math.Round(Arm12Text / 6,2));
            Whip_Arm14Label.Text = Convert.ToString(Math.Round(Arm14Text / 6,2));
            Whip_Arm16Label.Text = Convert.ToString(Math.Round(Arm16Text / 6,2));
            Whip_Arm18Label.Text = Convert.ToString(Math.Round(Arm18Text / 6,2));
        }

    }
}
