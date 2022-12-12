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
    {// переменные для ввода пользователя
        double Arm10Text, Arm12Text, Arm14Text, Arm16Text, Arm18Text;
        double SteelCircle8Text, SteelCircle10Text, SteelCircle12Text, SteelCircle14Text, SteelCircle16Text, SteelCircle18Text, SteelCircle20Text;
        double Sq8_Text, Sq10_Text, Sq12_Text, Sq14_Text;
        double Corner1_Text, Corner2_Text, Corner3_Text, Corner4_Text, Corner5_Text, Corner6_Text, Corner7_Text, Corner8_Text, Corner9_Text, Corner10_Text;
        double Shv_Text_10, Shv_Text_12, Shv_Text_14, Shv_Text_16, Shv_Text_18;
        double Stripe_Text_1, Stripe_Text_2, Stripe_Text_3, Stripe_Text_4;
        double Pipe_Rect_Text_1, Pipe_Rect_Text_2, Pipe_Rect_Text_3, Pipe_Rect_Text_4, Pipe_Rect_Text_5, Pipe_Rect_Text_6, Pipe_Rect_Text_7, Pipe_Rect_Text_8, Pipe_Rect_Text_9, Pipe_Rect_Text_10, Pipe_Rect_Text_11, Pipe_Rect_Text_12, Pipe_Rect_Text_13, Pipe_Rect_Text_14, Pipe_Rect_Text_15;
        double Shet_Text_1, Shet_Text_2, Shet_Text_3, Shet_Text_4, Shet_Text_5, Shet_Text_6, Shet_Text_7, Shet_Text_8;
        double Seamless_Pipe_Text_1, Seamless_Pipe_Text_2;
        double VGP_Pipe_Text_1, VGP_Pipe_Text_2, VGP_Pipe_Text_3, VGP_Pipe_Text_4, VGP_Pipe_Text_5, VGP_Pipe_Text_6, VGP_Pipe_Text_7, VGP_Pipe_Text_8, VGP_Pipe_Text_9, VGP_Pipe_Text_10, VGP_Pipe_Text_11, VGP_Pipe_Text_12, VGP_Pipe_Text_13, VGP_Pipe_Text_14, VGP_Pipe_Text_15, VGP_Pipe_Text_16;
        double El_Weld_Pipe_Text_1, El_Weld_Pipe_Text_2, El_Weld_Pipe_Text_3;
        double Rect_Steel_Pipe_Text_1, Rect_Steel_Pipe_Text_2, Rect_Steel_Pipe_Text_3, Rect_Steel_Pipe_Text_4, Rect_Steel_Pipe_Text_5, Rect_Steel_Pipe_Text_6, Rect_Steel_Pipe_Text_7, Rect_Steel_Pipe_Text_8, Rect_Steel_Pipe_Text_9, Rect_Steel_Pipe_Text_10, Rect_Steel_Pipe_Text_11, Rect_Steel_Pipe_Text_12, Rect_Steel_Pipe_Text_13, Rect_Steel_Pipe_Text_14, Rect_Steel_Pipe_Text_15, Rect_Steel_Pipe_Text_16, Rect_Steel_Pipe_Text_17, Rect_Steel_Pipe_Text_18, Rect_Steel_Pipe_Text_19, Rect_Steel_Pipe_Text_20, Rect_Steel_Pipe_Text_21;
        double totalWeightSumResult;
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

        private void label229_Click(object sender, EventArgs e)
        {

        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Проставьте значения");
        }
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RezultButton_Click(object sender, EventArgs e)
        {


            double.TryParse(Arm10TB.Text, out Arm10Text);
            double.TryParse(Arm12TB.Text, out Arm12Text);
            double.TryParse(Arm14TB.Text, out Arm14Text);
            double.TryParse(Arm16TB.Text, out Arm16Text);
            double.TryParse(Arm18TB.Text, out Arm18Text);

            double.TryParse(SteelCircle8TB.Text, out SteelCircle8Text);
            double.TryParse(SteelCircle10TB.Text, out SteelCircle10Text);
            double.TryParse(SteelCircle12TB.Text, out SteelCircle12Text);
            double.TryParse(SteelCircle14TB.Text, out SteelCircle14Text);
            double.TryParse(SteelCircle16TB.Text, out SteelCircle16Text);
            double.TryParse(SteelCircle18TB.Text, out SteelCircle18Text);
            double.TryParse(SteelCircle20TB.Text, out SteelCircle20Text);

            double.TryParse(Sq8_TB.Text, out Sq8_Text);
            double.TryParse(Sq10_TB.Text, out Sq10_Text);
            double.TryParse(Sq12_TB.Text, out Sq12_Text);
            double.TryParse(Sq14_TB.Text, out Sq14_Text);

            double.TryParse(Corner1_TB.Text, out Corner1_Text);
            double.TryParse(Corner1_TB.Text, out Corner2_Text);
            double.TryParse(Corner1_TB.Text, out Corner3_Text);
            double.TryParse(Corner1_TB.Text, out Corner4_Text);
            double.TryParse(Corner1_TB.Text, out Corner5_Text);
            double.TryParse(Corner1_TB.Text, out Corner6_Text);
            double.TryParse(Corner1_TB.Text, out Corner7_Text);
            double.TryParse(Corner1_TB.Text, out Corner8_Text);
            double.TryParse(Corner1_TB.Text, out Corner9_Text);
            double.TryParse(Corner1_TB.Text, out Corner10_Text);

            double.TryParse(Shv_TB_10.Text, out Shv_Text_10);
            double.TryParse(Shv_TB_12.Text, out Shv_Text_12);
            double.TryParse(Shv_TB_14.Text, out Shv_Text_14);
            double.TryParse(Shv_TB_16.Text, out Shv_Text_16);
            double.TryParse(Shv_TB_18.Text, out Shv_Text_18);

            double.TryParse(Stripe_TB_1.Text, out Stripe_Text_1);
            double.TryParse(Stripe_TB_2.Text, out Stripe_Text_2);
            double.TryParse(Stripe_TB_3.Text, out Stripe_Text_3);
            double.TryParse(Stripe_TB_4.Text, out Stripe_Text_4);

            double.TryParse(Pipe_Rect_TB_1.Text, out Pipe_Rect_Text_1);
            double.TryParse(Pipe_Rect_TB_2.Text, out Pipe_Rect_Text_2);
            double.TryParse(Pipe_Rect_TB_3.Text, out Pipe_Rect_Text_3);
            double.TryParse(Pipe_Rect_TB_4.Text, out Pipe_Rect_Text_4);
            double.TryParse(Pipe_Rect_TB_5.Text, out Pipe_Rect_Text_5);
            double.TryParse(Pipe_Rect_TB_6.Text, out Pipe_Rect_Text_6);
            double.TryParse(Pipe_Rect_TB_7.Text, out Pipe_Rect_Text_7);
            double.TryParse(Pipe_Rect_TB_8.Text, out Pipe_Rect_Text_8);
            double.TryParse(Pipe_Rect_TB_9.Text, out Pipe_Rect_Text_9);
            double.TryParse(Pipe_Rect_TB_10.Text, out Pipe_Rect_Text_10);
            double.TryParse(Pipe_Rect_TB_11.Text, out Pipe_Rect_Text_11);
            double.TryParse(Pipe_Rect_TB_12.Text, out Pipe_Rect_Text_12);
            double.TryParse(Pipe_Rect_TB_13.Text, out Pipe_Rect_Text_13);
            double.TryParse(Pipe_Rect_TB_14.Text, out Pipe_Rect_Text_14);
            double.TryParse(Pipe_Rect_TB_15.Text, out Pipe_Rect_Text_15);

            double.TryParse(Shet_TB_1.Text, out Shet_Text_1);
            double.TryParse(Shet_TB_2.Text, out Shet_Text_2);
            double.TryParse(Shet_TB_3.Text, out Shet_Text_3);
            double.TryParse(Shet_TB_4.Text, out Shet_Text_4);
            double.TryParse(Shet_TB_5.Text, out Shet_Text_5);
            double.TryParse(Shet_TB_6.Text, out Shet_Text_6);
            double.TryParse(Shet_TB_7.Text, out Shet_Text_7);
            double.TryParse(Shet_TB_8.Text, out Shet_Text_8);

            double.TryParse(Seamless_Pipe_TB_1.Text, out Seamless_Pipe_Text_1);
            double.TryParse(Seamless_Pipe_TB_2.Text, out Seamless_Pipe_Text_2);

            double.TryParse(VGP_Pipe_TB_1.Text, out VGP_Pipe_Text_1);
            double.TryParse(VGP_Pipe_TB_2.Text, out VGP_Pipe_Text_2);
            double.TryParse(VGP_Pipe_TB_3.Text, out VGP_Pipe_Text_3);
            double.TryParse(VGP_Pipe_TB_4.Text, out VGP_Pipe_Text_4);
            double.TryParse(VGP_Pipe_TB_5.Text, out VGP_Pipe_Text_5);
            double.TryParse(VGP_Pipe_TB_6.Text, out VGP_Pipe_Text_6);
            double.TryParse(VGP_Pipe_TB_7.Text, out VGP_Pipe_Text_7);
            double.TryParse(VGP_Pipe_TB_8.Text, out VGP_Pipe_Text_8);
            double.TryParse(VGP_Pipe_TB_9.Text, out VGP_Pipe_Text_9);
            double.TryParse(VGP_Pipe_TB_10.Text, out VGP_Pipe_Text_10);
            double.TryParse(VGP_Pipe_TB_11.Text, out VGP_Pipe_Text_11);
            double.TryParse(VGP_Pipe_TB_12.Text, out VGP_Pipe_Text_12);
            double.TryParse(VGP_Pipe_TB_13.Text, out VGP_Pipe_Text_13);
            double.TryParse(VGP_Pipe_TB_14.Text, out VGP_Pipe_Text_14);
            double.TryParse(VGP_Pipe_TB_15.Text, out VGP_Pipe_Text_15);
            double.TryParse(VGP_Pipe_TB_16.Text, out VGP_Pipe_Text_16);

            double.TryParse(El_Weld_Pipe_TB_1.Text, out El_Weld_Pipe_Text_1);
            double.TryParse(El_Weld_Pipe_TB_2.Text, out El_Weld_Pipe_Text_2);
            double.TryParse(El_Weld_Pipe_TB_3.Text, out El_Weld_Pipe_Text_3);

            double.TryParse(Rect_Steel_Pipe_TB_1.Text, out Rect_Steel_Pipe_Text_1);
            double.TryParse(Rect_Steel_Pipe_TB_2.Text, out Rect_Steel_Pipe_Text_2);
            double.TryParse(Rect_Steel_Pipe_TB_3.Text, out Rect_Steel_Pipe_Text_3);
            double.TryParse(Rect_Steel_Pipe_TB_4.Text, out Rect_Steel_Pipe_Text_4);
            double.TryParse(Rect_Steel_Pipe_TB_5.Text, out Rect_Steel_Pipe_Text_5);
            double.TryParse(Rect_Steel_Pipe_TB_6.Text, out Rect_Steel_Pipe_Text_6);
            double.TryParse(Rect_Steel_Pipe_TB_7.Text, out Rect_Steel_Pipe_Text_7);
            double.TryParse(Rect_Steel_Pipe_TB_8.Text, out Rect_Steel_Pipe_Text_8);
            double.TryParse(Rect_Steel_Pipe_TB_9.Text, out Rect_Steel_Pipe_Text_9);
            double.TryParse(Rect_Steel_Pipe_TB_10.Text, out Rect_Steel_Pipe_Text_10);
            double.TryParse(Rect_Steel_Pipe_TB_11.Text, out Rect_Steel_Pipe_Text_11);
            double.TryParse(Rect_Steel_Pipe_TB_12.Text, out Rect_Steel_Pipe_Text_12);
            double.TryParse(Rect_Steel_Pipe_TB_13.Text, out Rect_Steel_Pipe_Text_13);
            double.TryParse(Rect_Steel_Pipe_TB_14.Text, out Rect_Steel_Pipe_Text_14);
            double.TryParse(Rect_Steel_Pipe_TB_15.Text, out Rect_Steel_Pipe_Text_15);
            double.TryParse(Rect_Steel_Pipe_TB_16.Text, out Rect_Steel_Pipe_Text_16);
            double.TryParse(Rect_Steel_Pipe_TB_17.Text, out Rect_Steel_Pipe_Text_17);
            double.TryParse(Rect_Steel_Pipe_TB_18.Text, out Rect_Steel_Pipe_Text_18);
            double.TryParse(Rect_Steel_Pipe_TB_19.Text, out Rect_Steel_Pipe_Text_19);
            double.TryParse(Rect_Steel_Pipe_TB_20.Text, out Rect_Steel_Pipe_Text_20);
            double.TryParse(Rect_Steel_Pipe_TB_21.Text, out Rect_Steel_Pipe_Text_21);


            Count_And_Sum_Rezult();
            Percent_and_Whils_Rezult();
            TotalWeightSum();


        }

        void Count_And_Sum_Rezult()
        {
            //подсчет Количества(Общий вес)
            TotalCount_Arm10Label.Text = Convert.ToString(Math.Round((Arm10Text * Convert.ToDouble(label13.Text)),2));
            TotalCount_Arm12Label.Text = Convert.ToString(Math.Round(Arm12Text * Convert.ToDouble(label12.Text),2));
            TotalCount_Arm14Label.Text = Convert.ToString(Math.Round(Arm14Text * Convert.ToDouble(label11.Text),2));
            TotalCount_Arm16Label.Text = Convert.ToString(Math.Round(Arm16Text * Convert.ToDouble(label10.Text),2));
            TotalCount_Arm18Label.Text = Convert.ToString(Math.Round(Arm18Text * Convert.ToDouble(label9.Text),2));

            Count_StCl8Lbl.Text = Convert.ToString(Math.Round(SteelCircle8Text * Convert.ToDouble(label81.Text), 2));
            Count_StCl10Lbl.Text = Convert.ToString(Math.Round(SteelCircle10Text * Convert.ToDouble(label80.Text), 2));
            Count_StCl12Lbl.Text = Convert.ToString(Math.Round(SteelCircle12Text * Convert.ToDouble(label79.Text), 2));
            Count_StCl14Lbl.Text = Convert.ToString(Math.Round(SteelCircle14Text * Convert.ToDouble(label81.Text), 2));
            Count_StCl16Lbl.Text = Convert.ToString(Math.Round(SteelCircle16Text * Convert.ToDouble(label81.Text), 2));
            Count_StCl18Lbl.Text = Convert.ToString(Math.Round(SteelCircle18Text * Convert.ToDouble(label81.Text), 2));
            Count_StC20Lbl.Text = Convert.ToString(Math.Round(SteelCircle20Text * Convert.ToDouble(label103.Text), 2));

            Count_Sq8Lbl.Text = Convert.ToString(Math.Round(Sq8_Text * Convert.ToDouble(label156.Text), 2));
            Count_Sq10Lbl.Text = Convert.ToString(Math.Round(Sq10_Text * Convert.ToDouble(label155.Text), 2));
            Count_Sq12Lbl.Text = Convert.ToString(Math.Round(Sq12_Text * Convert.ToDouble(label154.Text), 2));
            Count_Sq14Lbl.Text = Convert.ToString(Math.Round(Sq14_Text * Convert.ToDouble(label153.Text), 2));

            Count_Corner32x4Lbl.Text = Convert.ToString(Math.Round(Corner1_Text * Convert.ToDouble(label168.Text), 2));
            Count_Corner25x4Lbl.Text = Convert.ToString(Math.Round(Corner2_Text * Convert.ToDouble(label162.Text), 2));
            Count_Corner32x2Lbl.Text = Convert.ToString(Math.Round(Corner3_Text * Convert.ToDouble(label157.Text), 2));
            Count_Corner40x4Lbl.Text = Convert.ToString(Math.Round(Corner4_Text * Convert.ToDouble(label152.Text), 2));
            Count_Corner45x4Lbl.Text = Convert.ToString(Math.Round(Corner5_Text * Convert.ToDouble(label201.Text), 2));
            Count_Corner50x3Lbl.Text = Convert.ToString(Math.Round(Corner6_Text * Convert.ToDouble(label200.Text), 2));
            Count_Corner50x4Lbl.Text = Convert.ToString(Math.Round(Corner7_Text * Convert.ToDouble(label199.Text), 2));
            Count_Corner50x5Lbl.Text = Convert.ToString(Math.Round(Corner8_Text * Convert.ToDouble(label221.Text), 2));
            Count_Corner63x3Lbl.Text = Convert.ToString(Math.Round(Corner9_Text * Convert.ToDouble(label220.Text), 2));
            Count_Corner63x5Lbl.Text = Convert.ToString(Math.Round(Corner10_Text * Convert.ToDouble(label297.Text), 2));

            Count_Shv_10Lbl.Text = Convert.ToString(Math.Round(Shv_Text_10 * Convert.ToDouble(label296.Text), 2));
            Count_Shv_12Lbl.Text = Convert.ToString(Math.Round(Shv_Text_12 * Convert.ToDouble(label295.Text), 2));
            Count_Shv_14Lbl.Text = Convert.ToString(Math.Round(Shv_Text_14 * Convert.ToDouble(label294.Text), 2));
            Count_Shv_16Lbl.Text = Convert.ToString(Math.Round(Shv_Text_16 * Convert.ToDouble(label265.Text), 2));
            Count_Shv_18Lbl.Text = Convert.ToString(Math.Round(Shv_Text_18 * Convert.ToDouble(label264.Text), 2));

            Count_Stripe1Lbl.Text = Convert.ToString(Math.Round(Stripe_Text_1 * Convert.ToDouble(label266.Text), 2));
            Count_Stripe2Lbl.Text = Convert.ToString(Math.Round(Stripe_Text_2 * Convert.ToDouble(label263.Text), 2));
            Count_Stripe3Lbl.Text = Convert.ToString(Math.Round(Stripe_Text_3 * Convert.ToDouble(label262.Text), 2));
            Count_Stripe4Lbl.Text = Convert.ToString(Math.Round(Stripe_Text_4 * Convert.ToDouble(label234.Text), 2));

            Count_Pipe_Rect1Lbl.Text = Convert.ToString(Math.Round(Pipe_Rect_Text_1 * Convert.ToDouble(label390.Text), 2));
            Count_Pipe_Rect2Lbl.Text = Convert.ToString(Math.Round(Pipe_Rect_Text_2 * Convert.ToDouble(label389.Text), 2));
            Count_Pipe_Rect3Lbl.Text = Convert.ToString(Math.Round(Pipe_Rect_Text_3 * Convert.ToDouble(label388.Text), 2));
            Count_Pipe_Rect4Lbl.Text = Convert.ToString(Math.Round(Pipe_Rect_Text_4 * Convert.ToDouble(label387.Text), 2));
            Count_Pipe_Rect5Lbl.Text = Convert.ToString(Math.Round(Pipe_Rect_Text_5 * Convert.ToDouble(label358.Text), 2));
            Count_Pipe_Rect6Lbl.Text = Convert.ToString(Math.Round(Pipe_Rect_Text_6 * Convert.ToDouble(label357.Text), 2));
            Count_Pipe_Rect7Lbl.Text = Convert.ToString(Math.Round(Pipe_Rect_Text_7 * Convert.ToDouble(label356.Text), 2));
            Count_Pipe_Rect8Lbl.Text = Convert.ToString(Math.Round(Pipe_Rect_Text_8 * Convert.ToDouble(label330.Text), 2));
            Count_Pipe_Rect9Lbl.Text = Convert.ToString(Math.Round(Pipe_Rect_Text_9 * Convert.ToDouble(label329.Text), 2));
            Count_Pipe_Rect10Lbl.Text = Convert.ToString(Math.Round(Pipe_Rect_Text_10 * Convert.ToDouble(label316.Text), 2));
            Count_Pipe_Rect11Lbl.Text = Convert.ToString(Math.Round(Pipe_Rect_Text_11 * Convert.ToDouble(label442.Text), 2));
            Count_Pipe_Rect12Lbl.Text = Convert.ToString(Math.Round(Pipe_Rect_Text_12 * Convert.ToDouble(label441.Text), 2));
            Count_Pipe_Rect13Lbl.Text = Convert.ToString(Math.Round(Pipe_Rect_Text_13 * Convert.ToDouble(label420.Text), 2));
            Count_Pipe_Rect14Lbl.Text = Convert.ToString(Math.Round(Pipe_Rect_Text_14 * Convert.ToDouble(label419.Text), 2));
            Count_Pipe_Rect15Lbl.Text = Convert.ToString(Math.Round(Pipe_Rect_Text_15 * Convert.ToDouble(label406.Text), 2));

            Count_Shet_1Lbl.Text = Convert.ToString(Math.Round(Shet_Text_1 * Convert.ToDouble(label495.Text), 2));
            Count_Shet_2Lbl.Text = Convert.ToString(Math.Round(Shet_Text_2 * Convert.ToDouble(label494.Text), 2));
            Count_Shet_3Lbl.Text = Convert.ToString(Math.Round(Shet_Text_3 * Convert.ToDouble(label493.Text), 2));
            Count_Shet_4Lbl.Text = Convert.ToString(Math.Round(Shet_Text_4 * Convert.ToDouble(label492.Text), 2));
            Count_Shet_5Lbl.Text = Convert.ToString(Math.Round(Shet_Text_5 * Convert.ToDouble(label491.Text), 2));
            Count_Shet_6Lbl.Text = Convert.ToString(Math.Round(Shet_Text_6 * Convert.ToDouble(label461.Text), 2));
            Count_Shet_7Lbl.Text = Convert.ToString(Math.Round(Shet_Text_7 * Convert.ToDouble(label460.Text), 2));
            Count_Shet_8Lbl.Text = Convert.ToString(Math.Round(Shet_Text_8 * Convert.ToDouble(label512.Text), 2));

            Count_Seamless_Pipe_1Lbl.Text = Convert.ToString(Math.Round(Seamless_Pipe_Text_1 * Convert.ToDouble(label529.Text), 2));
            Count_Seamless_Pipe_2Lbl.Text = Convert.ToString(Math.Round(Seamless_Pipe_Text_2 * Convert.ToDouble(label521.Text), 2));

            Count_VGP_Pipe_1Lbl.Text = Convert.ToString(Math.Round(VGP_Pipe_Text_1 * Convert.ToDouble(label661.Text), 2));
            Count_VGP_Pipe_2Lbl.Text = Convert.ToString(Math.Round(VGP_Pipe_Text_2 * Convert.ToDouble(label660.Text), 2));
            Count_VGP_Pipe_3Lbl.Text = Convert.ToString(Math.Round(VGP_Pipe_Text_3 * Convert.ToDouble(label659.Text), 2));
            Count_VGP_Pipe_4Lbl.Text = Convert.ToString(Math.Round(VGP_Pipe_Text_4 * Convert.ToDouble(label658.Text), 2));
            Count_VGP_Pipe_5Lbl.Text = Convert.ToString(Math.Round(VGP_Pipe_Text_5 * Convert.ToDouble(label629.Text), 2));
            Count_VGP_Pipe_6Lbl.Text = Convert.ToString(Math.Round(VGP_Pipe_Text_6 * Convert.ToDouble(label628.Text), 2));
            Count_VGP_Pipe_7Lbl.Text = Convert.ToString(Math.Round(VGP_Pipe_Text_7 * Convert.ToDouble(label627.Text), 2));
            Count_VGP_Pipe_8Lbl.Text = Convert.ToString(Math.Round(VGP_Pipe_Text_8 * Convert.ToDouble(label601.Text), 2));
            Count_VGP_Pipe_9Lbl.Text = Convert.ToString(Math.Round(VGP_Pipe_Text_9 * Convert.ToDouble(label600.Text), 2));
            Count_VGP_Pipe_10Lbl.Text = Convert.ToString(Math.Round(VGP_Pipe_Text_10 * Convert.ToDouble(label587.Text), 2));
            Count_VGP_Pipe_11Lbl.Text = Convert.ToString(Math.Round(VGP_Pipe_Text_11 * Convert.ToDouble(label575.Text), 2));
            Count_VGP_Pipe_12Lbl.Text = Convert.ToString(Math.Round(VGP_Pipe_Text_12 * Convert.ToDouble(label574.Text), 2));
            Count_VGP_Pipe_13Lbl.Text = Convert.ToString(Math.Round(VGP_Pipe_Text_13 * Convert.ToDouble(label553.Text), 2));
            Count_VGP_Pipe_14Lbl.Text = Convert.ToString(Math.Round(VGP_Pipe_Text_14 * Convert.ToDouble(label552.Text), 2));
            Count_VGP_Pipe_15Lbl.Text = Convert.ToString(Math.Round(VGP_Pipe_Text_15 * Convert.ToDouble(label539.Text), 2));
            Count_VGP_Pipe_16Lbl.Text = Convert.ToString(Math.Round(VGP_Pipe_Text_16 * Convert.ToDouble(label676.Text), 2));

            Count_El_Weld_Pipe_1Lbl.Text = Convert.ToString(Math.Round(El_Weld_Pipe_Text_1 * Convert.ToDouble(label693.Text), 2));
            Count_El_Weld_Pipe_2Lbl.Text = Convert.ToString(Math.Round(El_Weld_Pipe_Text_2 * Convert.ToDouble(label685.Text), 2));
            Count_El_Weld_Pipe_3Lbl.Text = Convert.ToString(Math.Round(El_Weld_Pipe_Text_3 * Convert.ToDouble(label702.Text), 2));

            Count_Rect_Pipe_1Lbl.Text = Convert.ToString(Math.Round(VGP_Pipe_Text_16 * Convert.ToDouble(label676.Text), 2));
            Count_Rect_Pipe_1Lbl.Text = Convert.ToString(Math.Round(VGP_Pipe_Text_16 * Convert.ToDouble(label676.Text), 2));
            Count_Rect_Pipe_1Lbl.Text = Convert.ToString(Math.Round(VGP_Pipe_Text_16 * Convert.ToDouble(label676.Text), 2));
            Count_Rect_Pipe_1Lbl.Text = Convert.ToString(Math.Round(VGP_Pipe_Text_16 * Convert.ToDouble(label676.Text), 2));
            Count_Rect_Pipe_1Lbl.Text = Convert.ToString(Math.Round(VGP_Pipe_Text_16 * Convert.ToDouble(label676.Text), 2));

            Count_Rect_Pipe_1Lbl.Text = Convert.ToString(Math.Round(Rect_Steel_Pipe_Text_1 * Convert.ToDouble(label841.Text), 2));
            Count_Rect_Pipe_2Lbl.Text = Convert.ToString(Math.Round(Rect_Steel_Pipe_Text_2 * Convert.ToDouble(label840.Text), 2));
            Count_Rect_Pipe_3Lbl.Text = Convert.ToString(Math.Round(Rect_Steel_Pipe_Text_3 * Convert.ToDouble(label839.Text), 2));
            Count_Rect_Pipe_4Lbl.Text = Convert.ToString(Math.Round(Rect_Steel_Pipe_Text_4 * Convert.ToDouble(label838.Text), 2));
            Count_Rect_Pipe_5Lbl.Text = Convert.ToString(Math.Round(Rect_Steel_Pipe_Text_5 * Convert.ToDouble(label809.Text), 2));
            Count_Rect_Pipe_6Lbl.Text = Convert.ToString(Math.Round(Rect_Steel_Pipe_Text_6 * Convert.ToDouble(label808.Text), 2));
            Count_Rect_Pipe_7Lbl.Text = Convert.ToString(Math.Round(Rect_Steel_Pipe_Text_7 * Convert.ToDouble(label807.Text), 2));
            Count_Rect_Pipe_8Lbl.Text = Convert.ToString(Math.Round(Rect_Steel_Pipe_Text_8 * Convert.ToDouble(label781.Text), 2));
            Count_Rect_Pipe_9Lbl.Text = Convert.ToString(Math.Round(Rect_Steel_Pipe_Text_9 * Convert.ToDouble(label780.Text), 2));
            Count_Rect_Pipe_10Lbl.Text = Convert.ToString(Math.Round(Rect_Steel_Pipe_Text_10 * Convert.ToDouble(label767.Text), 2));
            Count_Rect_Pipe_11Lbl.Text = Convert.ToString(Math.Round(Rect_Steel_Pipe_Text_11 * Convert.ToDouble(label755.Text), 2));
            Count_Rect_Pipe_12Lbl.Text = Convert.ToString(Math.Round(Rect_Steel_Pipe_Text_12 * Convert.ToDouble(label754.Text), 2));
            Count_Rect_Pipe_13Lbl.Text = Convert.ToString(Math.Round(Rect_Steel_Pipe_Text_13 * Convert.ToDouble(label733.Text), 2));
            Count_Rect_Pipe_14Lbl.Text = Convert.ToString(Math.Round(Rect_Steel_Pipe_Text_14 * Convert.ToDouble(label732.Text), 2));
            Count_Rect_Pipe_15Lbl.Text = Convert.ToString(Math.Round(Rect_Steel_Pipe_Text_15 * Convert.ToDouble(label719.Text), 2));
            Count_Rect_Pipe_16Lbl.Text = Convert.ToString(Math.Round(Rect_Steel_Pipe_Text_16 * Convert.ToDouble(label711.Text), 2));
            Count_Rect_Pipe_17Lbl.Text = Convert.ToString(Math.Round(Rect_Steel_Pipe_Text_17 * Convert.ToDouble(label894.Text), 2));
            Count_Rect_Pipe_18Lbl.Text = Convert.ToString(Math.Round(Rect_Steel_Pipe_Text_18 * Convert.ToDouble(label878.Text), 2));
            Count_Rect_Pipe_19Lbl.Text = Convert.ToString(Math.Round(Rect_Steel_Pipe_Text_19 * Convert.ToDouble(label877.Text), 2));
            Count_Rect_Pipe_20Lbl.Text = Convert.ToString(Math.Round(Rect_Steel_Pipe_Text_20 * Convert.ToDouble(label864.Text), 2));
            Count_Rect_Pipe_21Lbl.Text = Convert.ToString(Math.Round(Rect_Steel_Pipe_Text_21 * Convert.ToDouble(label864.Text), 2));


            //подсчет Суммы////////////////////////////////////////////////////////////////////////////////////////
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

            Perc_SteelCircle_Lbl_8.Text = Convert.ToString(Math.Round(SteelCircle8Text * 20 / 100, 1));
            Perc_SteelCircle_Lbl_10.Text = Convert.ToString(Math.Round(SteelCircle10Text * 20 / 100, 1));
            Perc_SteelCircle_Lbl_12.Text = Convert.ToString(Math.Round(SteelCircle12Text * 20 / 100, 1));
            Perc_SteelCircle_Lbl_14.Text = Convert.ToString(Math.Round(SteelCircle14Text * 20 / 100, 1));
            Perc_SteelCircle_Lbl_16.Text = Convert.ToString(Math.Round(SteelCircle16Text * 20 / 100, 1));
            Perc_SteelCircle_Lbl_18.Text = Convert.ToString(Math.Round(SteelCircle18Text * 20 / 100, 1));
            Perc_SteelCircle_Lbl_20.Text = Convert.ToString(Math.Round(SteelCircle20Text * 20 / 100, 1));

            Perc_Sq_Lbl_8.Text = Convert.ToString(Math.Round(Sq8_Text * 20 / 100, 1));
            Perc_Sq_Lbl_10.Text = Convert.ToString(Math.Round(Sq10_Text * 20 / 100, 1));
            Perc_Sq_Lbl_12.Text = Convert.ToString(Math.Round(Sq12_Text * 20 / 100, 1));
            Perc_Sq_Lbl_14.Text = Convert.ToString(Math.Round(Sq14_Text * 20 / 100, 1));

            Perc_Corner_Lbl_1.Text = Convert.ToString(Math.Round(Corner1_Text * 20 / 100, 1));
            Perc_Corner_Lbl_2.Text = Convert.ToString(Math.Round(Corner2_Text * 20 / 100, 1));
            Perc_Corner_Lbl_3.Text = Convert.ToString(Math.Round(Corner3_Text * 20 / 100, 1));
            Perc_Corner_Lbl_4.Text = Convert.ToString(Math.Round(Corner4_Text * 20 / 100, 1));
            Perc_Corner_Lbl_5.Text = Convert.ToString(Math.Round(Corner5_Text * 20 / 100, 1));
            Perc_Corner_Lbl_6.Text = Convert.ToString(Math.Round(Corner6_Text * 20 / 100, 1));
            Perc_Corner_Lbl_7.Text = Convert.ToString(Math.Round(Corner7_Text * 20 / 100, 1));
            Perc_Corner_Lbl_8.Text = Convert.ToString(Math.Round(Corner8_Text * 20 / 100, 1));
            Perc_Corner_Lbl_9.Text = Convert.ToString(Math.Round(Corner9_Text * 20 / 100, 1));
            Perc_Corner_Lbl_10.Text = Convert.ToString(Math.Round(Corner10_Text * 20 / 100, 1));

            Perc_Shv_Lbl_1.Text = Convert.ToString(Math.Round(Shv_Text_10 / 6, 2));
            Perc_Shv_Lbl_2.Text = Convert.ToString(Math.Round(Shv_Text_12 / 6, 2));
            Perc_Shv_Lbl_3.Text = Convert.ToString(Math.Round(Shv_Text_14 / 6, 2));
            Perc_Shv_Lbl_4.Text = Convert.ToString(Math.Round(Shv_Text_16 / 6, 2));
            Perc_Shv_Lbl_5.Text = Convert.ToString(Math.Round(Shv_Text_18 / 6, 2));

            Perc_Shv_Lbl_1.Text = Convert.ToString(Math.Round(Stripe_Text_1 / 6, 2));
            Perc_Shv_Lbl_2.Text = Convert.ToString(Math.Round(Stripe_Text_2 / 6, 2));
            Perc_Shv_Lbl_3.Text = Convert.ToString(Math.Round(Stripe_Text_3 / 6, 2));
            Perc_Shv_Lbl_4.Text = Convert.ToString(Math.Round(Stripe_Text_4 / 6, 2));

            Perc_Pipe_Rect_Lbl_1.Text = Convert.ToString(Math.Round(Pipe_Rect_Text_1 / 6, 2));
            Perc_Pipe_Rect_Lbl_2.Text = Convert.ToString(Math.Round(Pipe_Rect_Text_2 / 6, 2));
            Perc_Pipe_Rect_Lbl_3.Text = Convert.ToString(Math.Round(Pipe_Rect_Text_3 / 6, 2));
            Perc_Pipe_Rect_Lbl_4.Text = Convert.ToString(Math.Round(Pipe_Rect_Text_4 / 6, 2));
            Perc_Pipe_Rect_Lbl_5.Text = Convert.ToString(Math.Round(Pipe_Rect_Text_5 / 6, 2));
            Perc_Pipe_Rect_Lbl_6.Text = Convert.ToString(Math.Round(Pipe_Rect_Text_6 / 6, 2));
            Perc_Pipe_Rect_Lbl_7.Text = Convert.ToString(Math.Round(Pipe_Rect_Text_7 / 6, 2));
            Perc_Pipe_Rect_Lbl_8.Text = Convert.ToString(Math.Round(Pipe_Rect_Text_8 / 6, 2));
            Perc_Pipe_Rect_Lbl_9.Text = Convert.ToString(Math.Round(Pipe_Rect_Text_9 / 6, 2));
            Perc_Pipe_Rect_Lbl_10.Text = Convert.ToString(Math.Round(Pipe_Rect_Text_10 / 6, 2));
            Perc_Pipe_Rect_Lbl_11.Text = Convert.ToString(Math.Round(Pipe_Rect_Text_11 / 6, 2));
            Perc_Pipe_Rect_Lbl_12.Text = Convert.ToString(Math.Round(Pipe_Rect_Text_12 / 6, 2));
            Perc_Pipe_Rect_Lbl_13.Text = Convert.ToString(Math.Round(Pipe_Rect_Text_13 / 6, 2));
            Perc_Pipe_Rect_Lbl_14.Text = Convert.ToString(Math.Round(Pipe_Rect_Text_14 / 6, 2));
            Perc_Pipe_Rect_Lbl_15.Text = Convert.ToString(Math.Round(Pipe_Rect_Text_15 / 6, 2));

            Perc_Shet_Lbl_1.Text = Convert.ToString(Math.Round(Shet_Text_1 / 6, 2));
            Perc_Shet_Lbl_2.Text = Convert.ToString(Math.Round(Shet_Text_2 / 6, 2));
            Perc_Shet_Lbl_3.Text = Convert.ToString(Math.Round(Shet_Text_3 / 6, 2));
            Perc_Shet_Lbl_4.Text = Convert.ToString(Math.Round(Shet_Text_4 / 6, 2));
            Perc_Shet_Lbl_5.Text = Convert.ToString(Math.Round(Shet_Text_5 / 6, 2));
            Perc_Shet_Lbl_6.Text = Convert.ToString(Math.Round(Shet_Text_6 / 6, 2));
            Perc_Shet_Lbl_7.Text = Convert.ToString(Math.Round(Shet_Text_7 / 6, 2));
            Perc_Shet_Lbl_8.Text = Convert.ToString(Math.Round(Shet_Text_8 / 6, 2));

            Perc_Seamless_Pipe_Lbl_1.Text = Convert.ToString(Math.Round(Seamless_Pipe_Text_1 / 6, 2));
            Perc_Seamless_Pipe_Lbl_2.Text = Convert.ToString(Math.Round(Seamless_Pipe_Text_2 / 6, 2));

            Perc_VGP_Pipe_Lbl_1.Text = Convert.ToString(Math.Round(VGP_Pipe_Text_1 / 6, 2));
            Perc_VGP_Pipe_Lbl_2.Text = Convert.ToString(Math.Round(VGP_Pipe_Text_2 / 6, 2));
            Perc_VGP_Pipe_Lbl_3.Text = Convert.ToString(Math.Round(VGP_Pipe_Text_3 / 6, 2));
            Perc_VGP_Pipe_Lbl_4.Text = Convert.ToString(Math.Round(VGP_Pipe_Text_4 / 6, 2));
            Perc_VGP_Pipe_Lbl_5.Text = Convert.ToString(Math.Round(VGP_Pipe_Text_5 / 6, 2));
            Perc_VGP_Pipe_Lbl_6.Text = Convert.ToString(Math.Round(VGP_Pipe_Text_6 / 6, 2));
            Perc_VGP_Pipe_Lbl_7.Text = Convert.ToString(Math.Round(VGP_Pipe_Text_7 / 6, 2));
            Perc_VGP_Pipe_Lbl_8.Text = Convert.ToString(Math.Round(VGP_Pipe_Text_8 / 6, 2));
            Perc_VGP_Pipe_Lbl_9.Text = Convert.ToString(Math.Round(VGP_Pipe_Text_9 / 6, 2));
            Perc_VGP_Pipe_Lbl_10.Text = Convert.ToString(Math.Round(VGP_Pipe_Text_10 / 6, 2));
            Perc_VGP_Pipe_Lbl_11.Text = Convert.ToString(Math.Round(VGP_Pipe_Text_11 / 6, 2));
            Perc_VGP_Pipe_Lbl_12.Text = Convert.ToString(Math.Round(VGP_Pipe_Text_12 / 6, 2));
            Perc_VGP_Pipe_Lbl_13.Text = Convert.ToString(Math.Round(VGP_Pipe_Text_13 / 6, 2));
            Perc_VGP_Pipe_Lbl_14.Text = Convert.ToString(Math.Round(VGP_Pipe_Text_14 / 6, 2));
            Perc_VGP_Pipe_Lbl_15.Text = Convert.ToString(Math.Round(VGP_Pipe_Text_15 / 6, 2));
            Perc_VGP_Pipe_Lbl_16.Text = Convert.ToString(Math.Round(VGP_Pipe_Text_16 / 6, 2));

            Perc_El_Weld_Pipe_Lbl_1.Text = Convert.ToString(Math.Round(El_Weld_Pipe_Text_1 / 6, 2));
            Perc_El_Weld_Pipe_Lbl_2.Text = Convert.ToString(Math.Round(El_Weld_Pipe_Text_2 / 6, 2));
            Perc_El_Weld_Pipe_Lbl_3.Text = Convert.ToString(Math.Round(El_Weld_Pipe_Text_3 / 6, 2));

            Perc_Rect_Steel_Pipe_1.Text = Convert.ToString(Math.Round(Rect_Steel_Pipe_Text_1 / 6, 2));
            Perc_Rect_Steel_Pipe_2.Text = Convert.ToString(Math.Round(Rect_Steel_Pipe_Text_2 / 6, 2));
            Perc_Rect_Steel_Pipe_3.Text = Convert.ToString(Math.Round(Rect_Steel_Pipe_Text_3 / 6, 2));
            Perc_Rect_Steel_Pipe_4.Text = Convert.ToString(Math.Round(Rect_Steel_Pipe_Text_4 / 6, 2));
            Perc_Rect_Steel_Pipe_5.Text = Convert.ToString(Math.Round(Rect_Steel_Pipe_Text_5 / 6, 2));
            Perc_Rect_Steel_Pipe_6.Text = Convert.ToString(Math.Round(Rect_Steel_Pipe_Text_6 / 6, 2));
            Perc_Rect_Steel_Pipe_7.Text = Convert.ToString(Math.Round(Rect_Steel_Pipe_Text_7 / 6, 2));
            Perc_Rect_Steel_Pipe_8.Text = Convert.ToString(Math.Round(Rect_Steel_Pipe_Text_8 / 6, 2));
            Perc_Rect_Steel_Pipe_9.Text = Convert.ToString(Math.Round(Rect_Steel_Pipe_Text_9 / 6, 2));
            Perc_Rect_Steel_Pipe_10.Text = Convert.ToString(Math.Round(Rect_Steel_Pipe_Text_10 / 6, 2));
            Perc_Rect_Steel_Pipe_11.Text = Convert.ToString(Math.Round(Rect_Steel_Pipe_Text_11 / 6, 2));
            Perc_Rect_Steel_Pipe_12.Text = Convert.ToString(Math.Round(Rect_Steel_Pipe_Text_12 / 6, 2));
            Perc_Rect_Steel_Pipe_13.Text = Convert.ToString(Math.Round(Rect_Steel_Pipe_Text_13 / 6, 2));
            Perc_Rect_Steel_Pipe_14.Text = Convert.ToString(Math.Round(Rect_Steel_Pipe_Text_14 / 6, 2));
            Perc_Rect_Steel_Pipe_15.Text = Convert.ToString(Math.Round(Rect_Steel_Pipe_Text_15 / 6, 2));
            Perc_Rect_Steel_Pipe_16.Text = Convert.ToString(Math.Round(Rect_Steel_Pipe_Text_16 / 6, 2));
            Perc_Rect_Steel_Pipe_17.Text = Convert.ToString(Math.Round(Rect_Steel_Pipe_Text_17 / 6, 2));
            Perc_Rect_Steel_Pipe_18.Text = Convert.ToString(Math.Round(Rect_Steel_Pipe_Text_18 / 6, 2));
            Perc_Rect_Steel_Pipe_19.Text = Convert.ToString(Math.Round(Rect_Steel_Pipe_Text_19 / 6, 2));
            Perc_Rect_Steel_Pipe_20.Text = Convert.ToString(Math.Round(Rect_Steel_Pipe_Text_20 / 6, 2));
            Perc_Rect_Steel_Pipe_21.Text = Convert.ToString(Math.Round(Rect_Steel_Pipe_Text_21 / 6, 2));

            //подсчет Хлыстов
            Whip_Arm10Label.Text = Convert.ToString(Math.Round(Arm10Text / 6,2));
            Whip_Arm12Label.Text = Convert.ToString(Math.Round(Arm12Text / 6,2));
            Whip_Arm14Label.Text = Convert.ToString(Math.Round(Arm14Text / 6,2));
            Whip_Arm16Label.Text = Convert.ToString(Math.Round(Arm16Text / 6,2));
            Whip_Arm18Label.Text = Convert.ToString(Math.Round(Arm18Text / 6,2));

            Whil_SteelCircle_Lbl_8.Text = Convert.ToString(Math.Round(SteelCircle8Text / 6, 2));
            Whil_SteelCircle_Lbl_10.Text = Convert.ToString(Math.Round(SteelCircle10Text / 6, 2));
            Whil_SteelCircle_Lbl_12.Text = Convert.ToString(Math.Round(SteelCircle12Text / 6, 2));
            Whil_SteelCircle_Lbl_14.Text = Convert.ToString(Math.Round(SteelCircle14Text / 6, 2));
            Whil_SteelCircle_Lbl_16.Text = Convert.ToString(Math.Round(SteelCircle16Text / 6, 2));
            Whil_SteelCircle_Lbl_18.Text = Convert.ToString(Math.Round(SteelCircle18Text / 6, 2));
            Whil_SteelCircle_Lbl_20.Text = Convert.ToString(Math.Round(SteelCircle20Text / 6, 2));

            Whil_Sq_Lbl_8.Text = Convert.ToString(Math.Round(Sq8_Text / 6, 2));
            Whil_Sq_Lbl_10.Text = Convert.ToString(Math.Round(Sq10_Text / 6, 2));
            Whil_Sq_Lbl_12.Text = Convert.ToString(Math.Round(Sq12_Text / 6, 2));
            Whil_Sq_Lbl_14.Text = Convert.ToString(Math.Round(Sq14_Text / 6, 2));

            Whil_Corner_Lbl_1.Text = Convert.ToString(Math.Round(Corner1_Text / 6, 2));
            Whil_Corner_Lbl_2.Text = Convert.ToString(Math.Round(Corner2_Text / 6, 2));
            Whil_Corner_Lbl_3.Text = Convert.ToString(Math.Round(Corner3_Text / 6, 2));
            Whil_Corner_Lbl_4.Text = Convert.ToString(Math.Round(Corner4_Text / 6, 2));
            Whil_Corner_Lbl_5.Text = Convert.ToString(Math.Round(Corner5_Text / 6, 2));
            Whil_Corner_Lbl_6.Text = Convert.ToString(Math.Round(Corner6_Text / 6, 2));
            Whil_Corner_Lbl_7.Text = Convert.ToString(Math.Round(Corner7_Text / 6, 2));
            Whil_Corner_Lbl_8.Text = Convert.ToString(Math.Round(Corner8_Text / 6, 2));
            Whil_Corner_Lbl_9.Text = Convert.ToString(Math.Round(Corner9_Text / 6, 2));
            Whil_Corner_Lbl_10.Text = Convert.ToString(Math.Round(Corner10_Text / 6, 2));

            Whil_Shv_Lbl_1.Text = Convert.ToString(Math.Round(Shv_Text_10 / 6, 2));
            Whil_Shv_Lbl_2.Text = Convert.ToString(Math.Round(Shv_Text_12 / 6, 2));
            Whil_Shv_Lbl_3.Text = Convert.ToString(Math.Round(Shv_Text_14/ 6, 2));
            Whil_Shv_Lbl_4.Text = Convert.ToString(Math.Round(Shv_Text_16 / 6, 2));
            Whil_Shv_Lbl_5.Text = Convert.ToString(Math.Round(Shv_Text_18/ 6, 2));

            Whil_Shv_Lbl_1.Text = Convert.ToString(Math.Round(Stripe_Text_1 / 6, 2));
            Whil_Shv_Lbl_2.Text = Convert.ToString(Math.Round(Stripe_Text_2 / 6, 2));
            Whil_Shv_Lbl_3.Text = Convert.ToString(Math.Round(Stripe_Text_3 / 6, 2));
            Whil_Shv_Lbl_4.Text = Convert.ToString(Math.Round(Stripe_Text_4 / 6, 2));

            Whil_Pipe_Rect_Lbl_1.Text = Convert.ToString(Math.Round(Pipe_Rect_Text_1 / 6, 2));
            Whil_Pipe_Rect_Lbl_2.Text = Convert.ToString(Math.Round(Pipe_Rect_Text_2 / 6, 2));
            Whil_Pipe_Rect_Lbl_3.Text = Convert.ToString(Math.Round(Pipe_Rect_Text_3 / 6, 2));
            Whil_Pipe_Rect_Lbl_4.Text = Convert.ToString(Math.Round(Pipe_Rect_Text_4 / 6, 2));
            Whil_Pipe_Rect_Lbl_5.Text = Convert.ToString(Math.Round(Pipe_Rect_Text_5 / 6, 2));
            Whil_Pipe_Rect_Lbl_6.Text = Convert.ToString(Math.Round(Pipe_Rect_Text_6 / 6, 2));
            Whil_Pipe_Rect_Lbl_7.Text = Convert.ToString(Math.Round(Pipe_Rect_Text_7 / 6, 2));
            Whil_Pipe_Rect_Lbl_8.Text = Convert.ToString(Math.Round(Pipe_Rect_Text_8 / 6, 2));
            Whil_Pipe_Rect_Lbl_9.Text = Convert.ToString(Math.Round(Pipe_Rect_Text_9 / 6, 2));
            Whil_Pipe_Rect_Lbl_10.Text = Convert.ToString(Math.Round(Pipe_Rect_Text_10 / 6, 2));
            Whil_Pipe_Rect_Lbl_11.Text = Convert.ToString(Math.Round(Pipe_Rect_Text_11 / 6, 2));
            Whil_Pipe_Rect_Lbl_12.Text = Convert.ToString(Math.Round(Pipe_Rect_Text_12/ 6, 2));
            Whil_Pipe_Rect_Lbl_13.Text = Convert.ToString(Math.Round(Pipe_Rect_Text_13/ 6, 2));
            Whil_Pipe_Rect_Lbl_14.Text = Convert.ToString(Math.Round(Pipe_Rect_Text_14/ 6, 2));
            Whil_Pipe_Rect_Lbl_15.Text = Convert.ToString(Math.Round(Pipe_Rect_Text_15/ 6, 2));

            Whil_Shet_Lbl_1.Text = Convert.ToString(Math.Round(Shet_Text_1 / 6, 2));
            Whil_Shet_Lbl_2.Text = Convert.ToString(Math.Round(Shet_Text_2 / 6, 2));
            Whil_Shet_Lbl_3.Text = Convert.ToString(Math.Round(Shet_Text_3 / 6, 2));
            Whil_Shet_Lbl_4.Text = Convert.ToString(Math.Round(Shet_Text_4 / 6, 2));
            Whil_Shet_Lbl_5.Text = Convert.ToString(Math.Round(Shet_Text_5 / 6, 2));
            Whil_Shet_Lbl_6.Text = Convert.ToString(Math.Round(Shet_Text_6 / 6, 2));
            Whil_Shet_Lbl_7.Text = Convert.ToString(Math.Round(Shet_Text_7 / 6, 2));
            Whil_Shet_Lbl_8.Text = Convert.ToString(Math.Round(Shet_Text_8 / 6, 2));

            Whil_Seamless_Pipe_Lbl_1.Text = Convert.ToString(Math.Round(Seamless_Pipe_Text_1 / 6, 2));
            Whil_Seamless_Pipe_Lbl_2.Text = Convert.ToString(Math.Round(Seamless_Pipe_Text_2 / 6, 2));

            Whil_VGP_Pipe_Lbl_1.Text = Convert.ToString(Math.Round(VGP_Pipe_Text_1 / 6, 2));
            Whil_VGP_Pipe_Lbl_2.Text = Convert.ToString(Math.Round(VGP_Pipe_Text_2 / 6, 2));
            Whil_VGP_Pipe_Lbl_3.Text = Convert.ToString(Math.Round(VGP_Pipe_Text_3 / 6, 2));
            Whil_VGP_Pipe_Lbl_4.Text = Convert.ToString(Math.Round(VGP_Pipe_Text_4 / 6, 2));
            Whil_VGP_Pipe_Lbl_5.Text = Convert.ToString(Math.Round(VGP_Pipe_Text_5 / 6, 2));
            Whil_VGP_Pipe_Lbl_6.Text = Convert.ToString(Math.Round(VGP_Pipe_Text_6 / 6, 2));
            Whil_VGP_Pipe_Lbl_7.Text = Convert.ToString(Math.Round(VGP_Pipe_Text_7 / 6, 2));
            Whil_VGP_Pipe_Lbl_8.Text = Convert.ToString(Math.Round(VGP_Pipe_Text_8 / 6, 2));
            Whil_VGP_Pipe_Lbl_9.Text = Convert.ToString(Math.Round(VGP_Pipe_Text_9 / 6, 2));
            Whil_VGP_Pipe_Lbl_10.Text = Convert.ToString(Math.Round(VGP_Pipe_Text_10 / 6, 2));
            Whil_VGP_Pipe_Lbl_11.Text = Convert.ToString(Math.Round(VGP_Pipe_Text_11 / 6, 2));
            Whil_VGP_Pipe_Lbl_12.Text = Convert.ToString(Math.Round(VGP_Pipe_Text_12 / 6, 2));
            Whil_VGP_Pipe_Lbl_13.Text = Convert.ToString(Math.Round(VGP_Pipe_Text_13 / 6, 2));
            Whil_VGP_Pipe_Lbl_14.Text = Convert.ToString(Math.Round(VGP_Pipe_Text_14 / 6, 2));
            Whil_VGP_Pipe_Lbl_15.Text = Convert.ToString(Math.Round(VGP_Pipe_Text_15 / 6, 2));
            Whil_VGP_Pipe_Lbl_16.Text = Convert.ToString(Math.Round(VGP_Pipe_Text_16 / 6, 2));

            Whil_El_Weld_Pipe_Lbl_1.Text = Convert.ToString(Math.Round(El_Weld_Pipe_Text_1 / 6, 2));
            Whil_El_Weld_Pipe_Lbl_2.Text = Convert.ToString(Math.Round(El_Weld_Pipe_Text_2 / 6, 2));
            Whil_El_Weld_Pipe_Lbl_3.Text = Convert.ToString(Math.Round(El_Weld_Pipe_Text_3 / 6, 2));

            Whil_Rect_Steel_Pipe_1.Text = Convert.ToString(Math.Round(Rect_Steel_Pipe_Text_1 / 6, 2));
            Whil_Rect_Steel_Pipe_2.Text = Convert.ToString(Math.Round(Rect_Steel_Pipe_Text_2 / 6, 2));
            Whil_Rect_Steel_Pipe_3.Text = Convert.ToString(Math.Round(Rect_Steel_Pipe_Text_3 / 6, 2));
            Whil_Rect_Steel_Pipe_4.Text = Convert.ToString(Math.Round(Rect_Steel_Pipe_Text_4 / 6, 2));
            Whil_Rect_Steel_Pipe_5.Text = Convert.ToString(Math.Round(Rect_Steel_Pipe_Text_5 / 6, 2));
            Whil_Rect_Steel_Pipe_6.Text = Convert.ToString(Math.Round(Rect_Steel_Pipe_Text_6 / 6, 2));
            Whil_Rect_Steel_Pipe_7.Text = Convert.ToString(Math.Round(Rect_Steel_Pipe_Text_7 / 6, 2));
            Whil_Rect_Steel_Pipe_8.Text = Convert.ToString(Math.Round(Rect_Steel_Pipe_Text_8 / 6, 2));
            Whil_Rect_Steel_Pipe_9.Text = Convert.ToString(Math.Round(Rect_Steel_Pipe_Text_9 / 6, 2));
            Whil_Rect_Steel_Pipe_10.Text = Convert.ToString(Math.Round(Rect_Steel_Pipe_Text_10 / 6, 2));
            Whil_Rect_Steel_Pipe_11.Text = Convert.ToString(Math.Round(Rect_Steel_Pipe_Text_11 / 6, 2));
            Whil_Rect_Steel_Pipe_12.Text = Convert.ToString(Math.Round(Rect_Steel_Pipe_Text_12 / 6, 2));
            Whil_Rect_Steel_Pipe_13.Text = Convert.ToString(Math.Round(Rect_Steel_Pipe_Text_13 / 6, 2));
            Whil_Rect_Steel_Pipe_14.Text = Convert.ToString(Math.Round(Rect_Steel_Pipe_Text_14 / 6, 2));
            Whil_Rect_Steel_Pipe_15.Text = Convert.ToString(Math.Round(Rect_Steel_Pipe_Text_15 / 6, 2));
            Whil_Rect_Steel_Pipe_16.Text = Convert.ToString(Math.Round(Rect_Steel_Pipe_Text_16 / 6, 2));
            Whil_Rect_Steel_Pipe_17.Text = Convert.ToString(Math.Round(Rect_Steel_Pipe_Text_17 / 6, 2));
            Whil_Rect_Steel_Pipe_18.Text = Convert.ToString(Math.Round(Rect_Steel_Pipe_Text_18 / 6, 2));
            Whil_Rect_Steel_Pipe_19.Text = Convert.ToString(Math.Round(Rect_Steel_Pipe_Text_19 / 6, 2));
            Whil_Rect_Steel_Pipe_20.Text = Convert.ToString(Math.Round(Rect_Steel_Pipe_Text_20 / 6, 2));
            Whil_Rect_Steel_Pipe_21.Text = Convert.ToString(Math.Round(Rect_Steel_Pipe_Text_21 / 6, 2));
           

        }

        void TotalWeightSum()
        {
            totalWeightSumResult = double.Parse(TotalCount_Arm10Label.Text) + double.Parse(TotalCount_Arm12Label.Text) + double.Parse(TotalCount_Arm14Label.Text) + double.Parse(TotalCount_Arm16Label.Text) + double.Parse(TotalCount_Arm18Label.Text);
            totalWeightLlabel.Text = totalWeightSumResult.ToString();
        }

        
    }
}
