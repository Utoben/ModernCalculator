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
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        public int value;

        private void ReturnToMainButton_Click(object sender, EventArgs e)
        {
            this.Hide();// скрыть StartForm
            StartForm f = new StartForm();
            f.ShowDialog();
        }

        private void TraceryCounting_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Заполните поля 'Количество' в 'Подсчет узора' для рассчета. \nЗатем нажмите кнопку Рассчитать.");
        }

        private void MetallCountLabel_Click(object sender, EventArgs e)
        {
            
        }

        private void TestCalculationButton1_Click(object sender, EventArgs e)
        {
            if (MetrageTextBox.Text == "")// проверка на отсутствие ввода
            {
                MessageBox.Show("Заполните поле 'Метраж'");
            }
            Int32.TryParse(MetrageTextBox.Text, out value);

            MetallCountLabel.Text = Convert.ToString(value);// заполнение поле Количество металла
            MetallPriceLabel.Text = MetallCountLabel.Text; //заполнение поле Цена металла
            //заполнение полей сумма (количество*цена)
            MetallSumLabel.Text = Convert.ToString(Convert.ToInt32(MetallCountLabel.Text) * Convert.ToInt32(MetallPriceLabel.Text));


            // заполнение итогового поля
            TotalSumLabel.Text = Convert.ToString(Convert.ToInt32(MetallSumLabel.Text) + Convert.ToInt32(PropanSumLabel.Text) + Convert.ToInt32(ElEnergySumLabel.Text) + Convert.ToInt32(ZPSumLabel.Text) + Convert.ToInt32(WireSumLabel.Text) + Convert.ToInt32(CarbonDioxideSumLabel.Text) + Convert.ToInt32(OverheadsSumLabel.Text));
            //рассчет процентов справа
            SevenPercentOutLabel.Text = Convert.ToString(Convert.ToInt32(TotalSumLabel.Text)+ (Convert.ToInt32(TotalSumLabel.Text)*7/100));
            TenPercentOutLabell63.Text = Convert.ToString(Convert.ToInt32(TotalSumLabel.Text) + (Convert.ToInt32(TotalSumLabel.Text) * 10 / 100));
            FifteenPercentOutLabel.Text = Convert.ToString(Convert.ToInt32(TotalSumLabel.Text) + (Convert.ToInt32(TotalSumLabel.Text) * 15 / 100));
            TwentyPercentOutLabel.Text = Convert.ToString(Convert.ToInt32(TotalSumLabel.Text) + (Convert.ToInt32(TotalSumLabel.Text) * 20 / 100));
            TwentyfivePercentOutLabel.Text = Convert.ToString(Convert.ToInt32(TotalSumLabel.Text) + (Convert.ToInt32(TotalSumLabel.Text) * 25 / 100));
            
        }
    }
}
