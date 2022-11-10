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

        public int metallValue;
        public int bracesValue;
        public int curlsValue;
        public int weldPointsValue;

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
            if (MetrageTextBox.Text != "")// проверка на отсутствие ввода
            {
                //парсим все введенные тексты в числа

                Int32.TryParse(MetrageTextBox.Text, out metallValue);
                Int32.TryParse(BracesTextBox.Text, out bracesValue);
                Int32.TryParse(CurlsTextBox.Text, out curlsValue);
                Int32.TryParse(WeldPointsTextBox.Text, out weldPointsValue);

                MetallCountLabel.Text = Convert.ToString(metallValue);// заполнение поле Количество металла
                                                                      //MetallCountLabel.Text = MetrageTextBox.Text;
                MetallPriceLabel.Text = MetallCountLabel.Text; //заполнение поле Цена металла TEST
                                                               //заполнение полей сумма (количество*цена)
                MetallSumLabel.Text = Convert.ToString(Convert.ToInt32(MetallCountLabel.Text) * Convert.ToInt32(MetallPriceLabel.Text));

                /*if (BracesTextBox.Text == "")// проверка на отсутствие ввода
                {
                    MessageBox.Show("Заполните поле 'Оттяжки'");
                }*/

                // пропан = оттяжки

                PropanLabel.Text = Convert.ToString(bracesValue);
                PropanLabel.Text = BracesTextBox.Text;

                PropanSumLabel.Text = Convert.ToString(Convert.ToInt32(PropanLabel.Text) * Convert.ToInt32(PropanPriceLabel.Text));

                // электроэнергия, зп, нак.расходы = завитки

                ElEnergyCountLabel.Text = Convert.ToString(curlsValue);
                ZPCountLabel.Text = Convert.ToString(curlsValue);
                OverheadsCountLabel.Text = Convert.ToString(curlsValue);

                ElEnergySumLabel.Text = Convert.ToString(Convert.ToInt32(ElEnergyCountLabel.Text) * Convert.ToInt32(ElEnergyPriceLabel.Text));
                ZPSumLabel.Text = Convert.ToString(Convert.ToInt32(ZPCountLabel.Text) * Convert.ToInt32(ZPPriceLabel.Text));
                OverheadsSumLabel.Text = Convert.ToString(Convert.ToInt32(OverheadsCountLabel.Text) * Convert.ToInt32(OverheadsPriceLabel.Text));
               
                // проволка, углексилота = сварные точки

                WireCountLabel.Text = Convert.ToString(weldPointsValue);
                CarbonDioxideCountLabel.Text = Convert.ToString(weldPointsValue);

                WireSumLabel.Text = Convert.ToString(Convert.ToInt32(WireCountLabel.Text) * Convert.ToInt32(WirePriceLabel.Text));
                CarbonDioxideSumLabel.Text = Convert.ToString(Convert.ToInt32(CarbonDioxideCountLabel.Text) * Convert.ToInt32(CarbonDioxidePriceLabel.Text));
                
                // заполнение итогового поля
                TotalSumLabel.Text = Convert.ToString(Convert.ToInt32(MetallSumLabel.Text) + Convert.ToInt32(PropanSumLabel.Text) + Convert.ToInt32(ElEnergySumLabel.Text) + Convert.ToInt32(ZPSumLabel.Text) + Convert.ToInt32(WireSumLabel.Text) + Convert.ToInt32(CarbonDioxideSumLabel.Text) + Convert.ToInt32(OverheadsSumLabel.Text));

                //CostPriceLabel - итог, себестоимость = сумма всего
                CostPriceLabel.Text = TotalSumLabel.Text;

                // рассчет процентов
                PercentOut();
            }
            else
            {
                MessageBox.Show("Заполните поле 'Метраж'");
            }
        }

        private void BracesTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PercentOut()
        {
            //рассчет процентов справа
            SevenPercentOutLabel.Text = Convert.ToString(Convert.ToInt32(TotalSumLabel.Text) + (Convert.ToInt32(TotalSumLabel.Text) * 7 / 100));
            TenPercentOutLabell63.Text = Convert.ToString(Convert.ToInt32(TotalSumLabel.Text) + (Convert.ToInt32(TotalSumLabel.Text) * 10 / 100));
            FifteenPercentOutLabel.Text = Convert.ToString(Convert.ToInt32(TotalSumLabel.Text) + (Convert.ToInt32(TotalSumLabel.Text) * 15 / 100));
            TwentyPercentOutLabel.Text = Convert.ToString(Convert.ToInt32(TotalSumLabel.Text) + (Convert.ToInt32(TotalSumLabel.Text) * 20 / 100));
            TwentyfivePercentOutLabel.Text = Convert.ToString(Convert.ToInt32(TotalSumLabel.Text) + (Convert.ToInt32(TotalSumLabel.Text) * 25 / 100));
        }
    }
}
