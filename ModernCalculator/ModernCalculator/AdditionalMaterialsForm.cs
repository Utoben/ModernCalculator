﻿using System;
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
    public partial class AdditionalMaterialsForm : Form
    {       
            // переменные для ввода в поле Кол-во

            double Count_1, Count_2, Count_3, Count_4, Count_5, Count_6, Count_7, Count_8, Count_9, Count_10, Count_11, Count_12,
            Count_13, Count_14, Count_15, Count_16, Count_17, Count_18, Count_19, Count_20, 
            Count_21, Count_22, Count_23, Count_24, Count_25, Count_26, Count_27, Count_28, Count_29, Count_30,
            Count_31, Count_32, Count_33, Count_34, Count_35, Count_36, Count_37, Count_38, Count_39, Count_40, Count_41,
            Count_42, Count_43, Count_44, Count_45, Count_Total;

            

        public AdditionalMaterialsForm()
        {
            InitializeComponent();

            TB_1.KeyDown += TB_1_KeyDown;
            TB_2.KeyDown += TB_2_KeyDown;
            TB_3.KeyDown += TB_3_KeyDown;
            TB_4.KeyDown += TB_4_KeyDown;
            TB_5.KeyDown += TB_5_KeyDown;
            TB_6.KeyDown += TB_6_KeyDown;
            TB_7.KeyDown += TB_7_KeyDown;
            TB_8.KeyDown += TB_8_KeyDown;
            TB_9.KeyDown += TB_9_KeyDown;
            TB_10.KeyDown += TB_10_KeyDown;
            TB_11.KeyDown += TB_11_KeyDown;
            TB_12.KeyDown += TB_12_KeyDown;
            TB_13.KeyDown += TB_13_KeyDown;
            TB_14.KeyDown += TB_14_KeyDown;
            TB_15.KeyDown += TB_15_KeyDown;
            TB_16.KeyDown += TB_16_KeyDown;
            TB_17.KeyDown += TB_17_KeyDown;
            TB_18.KeyDown += TB_18_KeyDown;
            TB_19.KeyDown += TB_19_KeyDown;
            TB_20.KeyDown += TB_20_KeyDown;
            TB_21.KeyDown += TB_21_KeyDown;
            TB_22.KeyDown += TB_22_KeyDown;
            TB_23.KeyDown += TB_23_KeyDown;
            TB_24.KeyDown += TB_24_KeyDown;
            TB_25.KeyDown += TB_25_KeyDown;
            TB_26.KeyDown += TB_26_KeyDown;
            TB_27.KeyDown += TB_27_KeyDown;
            TB_28.KeyDown += TB_28_KeyDown;
            TB_29.KeyDown += TB_29_KeyDown;
            TB_30.KeyDown += TB_30_KeyDown;
            TB_31.KeyDown += TB_31_KeyDown;
            TB_32.KeyDown += TB_32_KeyDown;
            TB_33.KeyDown += TB_33_KeyDown;
            TB_34.KeyDown += TB_34_KeyDown;
            TB_35.KeyDown += TB_35_KeyDown;
            TB_36.KeyDown += TB_36_KeyDown;
            TB_37.KeyDown += TB_37_KeyDown;
            TB_38.KeyDown += TB_38_KeyDown;
            TB_39.KeyDown += TB_39_KeyDown;
            TB_40.KeyDown += TB_40_KeyDown;
            TB_41.KeyDown += TB_41_KeyDown;
            TB_42.KeyDown += TB_42_KeyDown;
            TB_43.KeyDown += TB_43_KeyDown;
            TB_44.KeyDown += TB_44_KeyDown;
            TB_45.KeyDown += TB_45_KeyDown;

            TB_1.TextChanged += TB_1_TextChanged;
            TB_2.TextChanged += TB_2_TextChanged;
            TB_3.TextChanged += TB_3_TextChanged;
            TB_4.TextChanged += TB_4_TextChanged;
            TB_5.TextChanged += TB_5_TextChanged;
            TB_6.TextChanged += TB_6_TextChanged;
            TB_7.TextChanged += TB_7_TextChanged;
            TB_8.TextChanged += TB_8_TextChanged;
            TB_9.TextChanged += TB_9_TextChanged;
            TB_10.TextChanged += TB_10_TextChanged;
            TB_11.TextChanged += TB_11_TextChanged;
            TB_12.TextChanged += TB_12_TextChanged;
            TB_13.TextChanged += TB_13_TextChanged;
            TB_14.TextChanged += TB_14_TextChanged; 
            TB_15.TextChanged += TB_15_TextChanged;
            TB_16.TextChanged += TB_16_TextChanged;
            TB_17.TextChanged += TB_17_TextChanged;
            TB_18.TextChanged += TB_18_TextChanged;
            TB_19.TextChanged += TB_19_TextChanged;
            TB_20.TextChanged += TB_20_TextChanged;
            TB_21.TextChanged += TB_21_TextChanged;
            TB_22.TextChanged += TB_22_TextChanged;
            TB_23.TextChanged += TB_23_TextChanged;
            TB_24.TextChanged += TB_24_TextChanged;
            TB_25.TextChanged += TB_25_TextChanged;
            TB_26.TextChanged += TB_26_TextChanged;
            TB_27.TextChanged += TB_27_TextChanged;
            TB_28.TextChanged += TB_28_TextChanged;
            TB_29.TextChanged += TB_29_TextChanged;
            TB_30.TextChanged += TB_30_TextChanged;
            TB_31.TextChanged += TB_31_TextChanged;
            TB_32.TextChanged += TB_32_TextChanged;
            TB_33.TextChanged += TB_33_TextChanged;
            TB_34.TextChanged += TB_34_TextChanged;
            TB_35.TextChanged += TB_35_TextChanged;
            TB_36.TextChanged += TB_36_TextChanged;
            TB_37.TextChanged += TB_37_TextChanged;
            TB_38.TextChanged += TB_38_TextChanged;
            TB_39.TextChanged += TB_39_TextChanged;
            TB_40.TextChanged += TB_40_TextChanged;
            TB_41.TextChanged += TB_41_TextChanged;
            TB_42.TextChanged += TB_42_TextChanged;
            TB_43.TextChanged += TB_43_TextChanged;
            TB_44.TextChanged += TB_44_TextChanged;
            TB_45.TextChanged += TB_45_TextChanged;

            //Sum_Lbl_Total.TextChanged += Sum_Lbl_Total_TextChanged;

            double[] counts = { Count_1, Count_2, Count_3, Count_4, Count_5, Count_6, Count_7, Count_8, Count_9, Count_10, Count_11, Count_12,
            Count_13, Count_14, Count_15, Count_16, Count_17, Count_18, Count_19, Count_20,
            Count_21, Count_22, Count_23, Count_24, Count_25, Count_26, Count_27, Count_28, Count_29, Count_30,
            Count_31, Count_32, Count_33, Count_34, Count_35, Count_36, Count_37, Count_38, Count_39, Count_40, Count_41,
            Count_42, Count_43, Count_44, Count_45 };


            for (int i = 0; i < counts.Length; i++)
            {
                if (i.ToString() != " ")
                {
                    Sum_Lbls_Total();
                }
            }
            //Sum_Lbls_Total();
        }
        private void TB_1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                TB_2.Focus();

        }
        private void TB_2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                TB_3.Focus();
            else if (e.KeyCode == Keys.F1)
                TB_1.Focus();
        }

        private void TB_3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                TB_4.Focus();
            else if (e.KeyCode == Keys.F1)
                TB_2.Focus();
        }
        private void TB_4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                TB_5.Focus();
            else if (e.KeyCode == Keys.F1)
                TB_3.Focus();
        }
        private void TB_5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                TB_6.Focus();
            else if (e.KeyCode == Keys.F1)
                TB_4.Focus();
        }
        private void TB_6_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                TB_7.Focus();
            else if (e.KeyCode == Keys.F1)
                TB_5.Focus();
        }
        private void TB_7_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                TB_8.Focus();
            else if (e.KeyCode == Keys.F1)
                TB_6.Focus();
        }
        private void TB_8_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                TB_9.Focus();
            else if (e.KeyCode == Keys.F1)
                TB_7.Focus();
        }
        private void TB_9_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                TB_10.Focus();
            else if (e.KeyCode == Keys.F1)
                TB_8.Focus();
        }
        private void TB_10_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                TB_11.Focus();
            else if (e.KeyCode == Keys.F1)
                TB_9.Focus();
        }
        private void TB_11_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                TB_12.Focus();
            else if (e.KeyCode == Keys.F1)
                TB_10.Focus();
        }
        private void TB_12_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                TB_13.Focus();
            else if (e.KeyCode == Keys.F1)
                TB_11.Focus();
        }
        private void TB_13_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                TB_14.Focus();
            else if (e.KeyCode == Keys.F1)
                TB_12.Focus();
        }
        private void TB_14_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                TB_15.Focus();
            else if (e.KeyCode == Keys.F1)
                TB_13.Focus();
        }
        private void TB_15_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                TB_16.Focus();
            else if (e.KeyCode == Keys.F1)
                TB_14.Focus();
        }
        private void TB_16_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                TB_17.Focus();
            else if (e.KeyCode == Keys.F1)
                TB_15.Focus();
        }
        private void TB_17_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                TB_18.Focus();
            else if (e.KeyCode == Keys.F1)
                TB_16.Focus();
        }
        private void TB_18_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                TB_19.Focus();
            else if (e.KeyCode == Keys.F1)
                TB_17.Focus();
        }
        private void TB_19_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                TB_20.Focus();
            else if (e.KeyCode == Keys.F1)
                TB_18.Focus();
        }
        private void TB_20_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                TB_21.Focus();
            else if (e.KeyCode == Keys.F1)
                TB_19.Focus();
        }
        private void TB_21_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                TB_22.Focus();
            else if (e.KeyCode == Keys.F1)
                TB_20.Focus();
        }
        private void TB_22_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                TB_23.Focus();
            else if (e.KeyCode == Keys.F1)
                TB_21.Focus();
        }
        private void TB_23_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                TB_24.Focus();
            else if (e.KeyCode == Keys.F1)
                TB_22.Focus();
        }
        private void TB_24_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                TB_25.Focus();
            else if (e.KeyCode == Keys.F1)
                TB_23.Focus();
        }
        private void TB_25_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                TB_26.Focus();
            else if (e.KeyCode == Keys.F1)
                TB_25.Focus();
        }
        private void TB_26_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                TB_27.Focus();
            else if (e.KeyCode == Keys.F1)
                TB_25.Focus();
        }
        private void TB_27_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                TB_28.Focus();
            else if (e.KeyCode == Keys.F1)
                TB_26.Focus();
        }
        private void TB_28_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                TB_29.Focus();
            else if (e.KeyCode == Keys.F1)
                TB_27.Focus();
        }
        private void TB_29_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                TB_30.Focus();
            else if (e.KeyCode == Keys.F1)
                TB_28.Focus();
        }
        private void TB_30_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                TB_31.Focus();
            else if (e.KeyCode == Keys.F1)
                TB_29.Focus();
        }
        private void TB_31_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                TB_32.Focus();
            else if (e.KeyCode == Keys.F1)
                TB_30.Focus();
        }
        private void TB_32_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                TB_33.Focus();
            else if (e.KeyCode == Keys.F1)
                TB_31.Focus();
        }
        private void TB_33_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                TB_34.Focus();
            else if (e.KeyCode == Keys.F1)
                TB_32.Focus();
        }
        private void TB_34_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                TB_35.Focus();
            else if (e.KeyCode == Keys.F1)
                TB_33.Focus();
        }
        private void TB_35_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                TB_36.Focus();
            else if (e.KeyCode == Keys.F1)
                TB_34.Focus();
        }
        private void TB_36_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                TB_37.Focus();
            else if (e.KeyCode == Keys.F1)
                TB_35.Focus();
        }
        private void TB_37_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                TB_38.Focus();
            else if (e.KeyCode == Keys.F1)
                TB_36.Focus();
        }
        private void TB_38_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                TB_39.Focus();
            else if (e.KeyCode == Keys.F1)
                TB_37.Focus();
        }
        private void TB_39_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                TB_40.Focus();
            else if (e.KeyCode == Keys.F1)
                TB_38.Focus();
        }
        private void TB_40_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                TB_41.Focus();
            else if (e.KeyCode == Keys.F1)
                TB_39.Focus();
        }
        private void TB_41_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                TB_42.Focus();
            else if (e.KeyCode == Keys.F1)
                TB_40.Focus();
        }
        private void TB_42_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                TB_43.Focus();
            else if (e.KeyCode == Keys.F1)
                TB_41.Focus();
        }
        private void TB_43_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                TB_44.Focus();
            else if (e.KeyCode == Keys.F1)
                TB_42.Focus();
        }
        private void TB_44_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                TB_45.Focus();
            else if (e.KeyCode == Keys.F1)
                TB_43.Focus();
        }
        private void TB_45_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
                TB_44.Focus();
            
        }

        /// ________________________________________________________________________


        private void TB_1_TextChanged(object sender, EventArgs e)
        {            
            if (TB_1.Text != " ")
            {
                double.TryParse(TB_1.Text, out Count_1);
                Sum_Lbl_1.Text = Convert.ToString(Math.Round(Count_1 * Convert.ToDouble(Price_Lbl_1.Text), 2));
            }
        }

        private void TB_2_TextChanged(object sender, EventArgs e)
        {
            if (TB_2.Text != " ")
            {
                double.TryParse(TB_2.Text, out Count_2);
                Sum_Lbl_2.Text = Convert.ToString(Math.Round(Count_1 * Convert.ToDouble(Price_Lbl_2.Text), 2));
            }
        }
        private void TB_3_TextChanged(object sender, EventArgs e)
        {
            if (TB_3.Text != " ")
            {
                double.TryParse(TB_3.Text, out Count_3);
                Sum_Lbl_3.Text = Convert.ToString(Math.Round(Count_1 * Convert.ToDouble(Price_Lbl_3.Text), 2));
            }
        }
        private void TB_4_TextChanged(object sender, EventArgs e)
        {
            if (TB_4.Text != " ")
            {
                double.TryParse(TB_4.Text, out Count_4);
                Sum_Lbl_4.Text = Convert.ToString(Math.Round(Count_1 * Convert.ToDouble(Price_Lbl_4.Text), 2));
            }
        }
        private void TB_5_TextChanged(object sender, EventArgs e)
        {
            if (TB_5.Text != " ")
            {
                double.TryParse(TB_5.Text, out Count_5);
                Sum_Lbl_5.Text = Convert.ToString(Math.Round(Count_1 * Convert.ToDouble(Price_Lbl_5.Text), 2));
            }
        }

        

        private void TB_6_TextChanged(object sender, EventArgs e)
        {
            if (TB_5.Text != " ")
            {
                double.TryParse(TB_6.Text, out Count_6);
                Sum_Lbl_6.Text = Convert.ToString(Math.Round(Count_1 * Convert.ToDouble(Price_Lbl_6.Text), 2));
            }
        }
        
        private void TB_7_TextChanged(object sender, EventArgs e)
        {
            if (TB_5.Text != " ")
            {
                double.TryParse(TB_7.Text, out Count_7);
                Sum_Lbl_7.Text = Convert.ToString(Math.Round(Count_1 * Convert.ToDouble(Price_Lbl_7.Text), 2));
            }
        }
        private void TB_8_TextChanged(object sender, EventArgs e)
        {
            if (TB_5.Text != " ")
            {
                double.TryParse(TB_8.Text, out Count_8);
                Sum_Lbl_8.Text = Convert.ToString(Math.Round(Count_1 * Convert.ToDouble(Price_Lbl_8.Text), 2));
            }
        }
        private void TB_9_TextChanged(object sender, EventArgs e)
        {
            if (TB_5.Text != " ")
            {
                double.TryParse(TB_9.Text, out Count_9);
                Sum_Lbl_9.Text = Convert.ToString(Math.Round(Count_1 * Convert.ToDouble(Price_Lbl_9.Text), 2));
            }
        }
        private void TB_10_TextChanged(object sender, EventArgs e)
        {
            if (TB_5.Text != " ")
            {
                double.TryParse(TB_10.Text, out Count_10);
                Sum_Lbl_10.Text = Convert.ToString(Math.Round(Count_1 * Convert.ToDouble(Price_Lbl_10.Text), 2));
            }
        }
        private void TB_11_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(TB_11.Text, out Count_11);
            Sum_Lbl_11.Text = Convert.ToString(Math.Round(Count_1 * Convert.ToDouble(Price_Lbl_11.Text), 2));
        }
        private void TB_12_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(TB_12.Text, out Count_12);
            Sum_Lbl_12.Text = Convert.ToString(Math.Round(Count_1 * Convert.ToDouble(Price_Lbl_12.Text), 2));
        }
        private void TB_13_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(TB_13.Text, out Count_13);
            Sum_Lbl_13.Text = Convert.ToString(Math.Round(Count_1 * Convert.ToDouble(Price_Lbl_13.Text), 2));
        }
        private void TB_14_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(TB_14.Text, out Count_14);
            Sum_Lbl_14.Text = Convert.ToString(Math.Round(Count_1 * Convert.ToDouble(Price_Lbl_14.Text), 2));
        }
        private void TB_15_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(TB_15.Text, out Count_15);
            Sum_Lbl_15.Text = Convert.ToString(Math.Round(Count_1 * Convert.ToDouble(Price_Lbl_15.Text), 2));
        }
        private void TB_16_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(TB_16.Text, out Count_16);
            Sum_Lbl_16.Text = Convert.ToString(Math.Round(Count_1 * Convert.ToDouble(Price_Lbl_16.Text), 2));
        }
        private void TB_17_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(TB_17.Text, out Count_17);
            Sum_Lbl_17.Text = Convert.ToString(Math.Round(Count_1 * Convert.ToDouble(Price_Lbl_17.Text), 2));
        }
        private void TB_18_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(TB_18.Text, out Count_18);
            Sum_Lbl_18.Text = Convert.ToString(Math.Round(Count_1 * Convert.ToDouble(Price_Lbl_18.Text), 2));
        }
        private void TB_19_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(TB_19.Text, out Count_19);
            Sum_Lbl_19.Text = Convert.ToString(Math.Round(Count_1 * Convert.ToDouble(Price_Lbl_19.Text), 2));
        }
        private void TB_20_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(TB_20.Text, out Count_20);
            Sum_Lbl_20.Text = Convert.ToString(Math.Round(Count_1 * Convert.ToDouble(Price_Lbl_20.Text), 2));
        }
        private void TB_21_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(TB_21.Text, out Count_21);
            Sum_Lbl_21.Text = Convert.ToString(Math.Round(Count_1 * Convert.ToDouble(Price_Lbl_21.Text), 2));
        }
        private void TB_22_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(TB_22.Text, out Count_22);
            Sum_Lbl_22.Text = Convert.ToString(Math.Round(Count_1 * Convert.ToDouble(Price_Lbl_22.Text), 2));
        }
        private void TB_23_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(TB_23.Text, out Count_23);
            Sum_Lbl_23.Text = Convert.ToString(Math.Round(Count_1 * Convert.ToDouble(Price_Lbl_23.Text), 2));
        }
        private void TB_24_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(TB_24.Text, out Count_24);
            Sum_Lbl_24.Text = Convert.ToString(Math.Round(Count_1 * Convert.ToDouble(Price_Lbl_24.Text), 2));
        }
        private void TB_25_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(TB_25.Text, out Count_25);
            Sum_Lbl_25.Text = Convert.ToString(Math.Round(Count_1 * Convert.ToDouble(Price_Lbl_25.Text), 2));
        }
        private void TB_26_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(TB_26.Text, out Count_26);
            Sum_Lbl_26.Text = Convert.ToString(Math.Round(Count_1 * Convert.ToDouble(Price_Lbl_26.Text), 2));
        }
        private void TB_27_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(TB_27.Text, out Count_27);
            Sum_Lbl_27.Text = Convert.ToString(Math.Round(Count_1 * Convert.ToDouble(Price_Lbl_27.Text), 2));
        }
        private void TB_28_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(TB_28.Text, out Count_28);
            Sum_Lbl_28.Text = Convert.ToString(Math.Round(Count_1 * Convert.ToDouble(Price_Lbl_28.Text), 2));
        }
        private void TB_29_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(TB_29.Text, out Count_29);
            Sum_Lbl_29.Text = Convert.ToString(Math.Round(Count_1 * Convert.ToDouble(Price_Lbl_29.Text), 2));
        }
        private void TB_30_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(TB_30.Text, out Count_30);
            Sum_Lbl_30.Text = Convert.ToString(Math.Round(Count_1 * Convert.ToDouble(Price_Lbl_30.Text), 2));
        }
        private void TB_31_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(TB_31.Text, out Count_31);
            Sum_Lbl_31.Text = Convert.ToString(Math.Round(Count_1 * Convert.ToDouble(Price_Lbl_31.Text), 2));
        }
        private void TB_32_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(TB_32.Text, out Count_32);
            Sum_Lbl_32.Text = Convert.ToString(Math.Round(Count_1 * Convert.ToDouble(Price_Lbl_32.Text), 2));
        }
        private void TB_33_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(TB_33.Text, out Count_33);
            Sum_Lbl_33.Text = Convert.ToString(Math.Round(Count_1 * Convert.ToDouble(Price_Lbl_33.Text), 2));
        }
        private void TB_34_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(TB_34.Text, out Count_34);
            Sum_Lbl_34.Text = Convert.ToString(Math.Round(Count_1 * Convert.ToDouble(Price_Lbl_34.Text), 2));
        }
        private void TB_35_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(TB_35.Text, out Count_35);
            Sum_Lbl_35.Text = Convert.ToString(Math.Round(Count_1 * Convert.ToDouble(Price_Lbl_35.Text), 2));
        }
        private void TB_36_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(TB_36.Text, out Count_36);
            Sum_Lbl_36.Text = Convert.ToString(Math.Round(Count_1 * Convert.ToDouble(Price_Lbl_36.Text), 2));
        }
        private void TB_37_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(TB_37.Text, out Count_37);
            Sum_Lbl_37.Text = Convert.ToString(Math.Round(Count_1 * Convert.ToDouble(Price_Lbl_37.Text), 2));
        }
        private void TB_38_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(TB_38.Text, out Count_38);
            Sum_Lbl_38.Text = Convert.ToString(Math.Round(Count_1 * Convert.ToDouble(Price_Lbl_38.Text), 2));
        }
        private void TB_39_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(TB_39.Text, out Count_39);
            Sum_Lbl_39.Text = Convert.ToString(Math.Round(Count_1 * Convert.ToDouble(Price_Lbl_39.Text), 2));
        }
        private void TB_40_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(TB_40.Text, out Count_40);
            Sum_Lbl_40.Text = Convert.ToString(Math.Round(Count_1 * Convert.ToDouble(Price_Lbl_40.Text), 2));
        }
        private void TB_41_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(TB_41.Text, out Count_41);
            Sum_Lbl_41.Text = Convert.ToString(Math.Round(Count_1 * Convert.ToDouble(Price_Lbl_41.Text), 2));
        }
        private void TB_42_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(TB_42.Text, out Count_42);
            Sum_Lbl_42.Text = Convert.ToString(Math.Round(Count_1 * Convert.ToDouble(Price_Lbl_42.Text), 2));
        }
        private void TB_43_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(TB_43.Text, out Count_43);
            Sum_Lbl_43.Text = Convert.ToString(Math.Round(Count_1 * Convert.ToDouble(Price_Lbl_43.Text), 2));
        }
        private void TB_44_TextChanged(object sender, EventArgs e)
        { 
            double.TryParse(TB_44.Text, out Count_44);
            Sum_Lbl_44.Text = Convert.ToString(Math.Round(Count_1 * Convert.ToDouble(Price_Lbl_44.Text), 2));
        }
        private void TB_45_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(TB_45.Text, out Count_45);
            Sum_Lbl_45.Text = Convert.ToString(Math.Round(Count_1 * Convert.ToDouble(Price_Lbl_45.Text), 2));
        }

        //---------------------------------------------------------------------------------------------------------
        private void Sum_Lbls_Total()
        {
            double.TryParse(Sum_Lbl_Total.Text, out Count_Total);

            Count_Total = (Math.Round(Convert.ToDouble(Sum_Lbl_1.Text) + Convert.ToDouble(Sum_Lbl_1.Text) 
                + Convert.ToDouble(Sum_Lbl_1.Text) + Convert.ToDouble(Sum_Lbl_2.Text) + Convert.ToDouble(Sum_Lbl_3.Text)
                + Convert.ToDouble(Sum_Lbl_4.Text) + Convert.ToDouble(Sum_Lbl_5.Text) + Convert.ToDouble(Sum_Lbl_6.Text) 
                + Convert.ToDouble(Sum_Lbl_7.Text) + Convert.ToDouble(Sum_Lbl_8.Text) + Convert.ToDouble(Sum_Lbl_9.Text) 
                + Convert.ToDouble(Sum_Lbl_10.Text) + Convert.ToDouble(Sum_Lbl_11.Text) + Convert.ToDouble(Sum_Lbl_12.Text) 
                + Convert.ToDouble(Sum_Lbl_13.Text) + Convert.ToDouble(Sum_Lbl_14.Text) + Convert.ToDouble(Sum_Lbl_15.Text) 
                + Convert.ToDouble(Sum_Lbl_16.Text) + Convert.ToDouble(Sum_Lbl_17.Text) + Convert.ToDouble(Sum_Lbl_18.Text) 
                + Convert.ToDouble(Sum_Lbl_19.Text) + Convert.ToDouble(Sum_Lbl_20.Text) + Convert.ToDouble(Sum_Lbl_21.Text) 
                + Convert.ToDouble(Sum_Lbl_22.Text) + Convert.ToDouble(Sum_Lbl_23.Text) + Convert.ToDouble(Sum_Lbl_24.Text) 
                + Convert.ToDouble(Sum_Lbl_25.Text) + Convert.ToDouble(Sum_Lbl_26.Text) + Convert.ToDouble(Sum_Lbl_27.Text) 
                + Convert.ToDouble(Sum_Lbl_28.Text) + Convert.ToDouble(Sum_Lbl_29.Text) + Convert.ToDouble(Sum_Lbl_30.Text) 
                + Convert.ToDouble(Sum_Lbl_31.Text) + Convert.ToDouble(Sum_Lbl_32.Text) + Convert.ToDouble(Sum_Lbl_33.Text) 
                + Convert.ToDouble(Sum_Lbl_34.Text) + Convert.ToDouble(Sum_Lbl_35.Text) + Convert.ToDouble(Sum_Lbl_36.Text)
                + Convert.ToDouble(Sum_Lbl_37.Text) + Convert.ToDouble(Sum_Lbl_38.Text) + Convert.ToDouble(Sum_Lbl_39.Text)
                + Convert.ToDouble(Sum_Lbl_40.Text) + Convert.ToDouble(Sum_Lbl_41.Text) + Convert.ToDouble(Sum_Lbl_42.Text)
                + Convert.ToDouble(Sum_Lbl_43.Text) + Convert.ToDouble(Sum_Lbl_44.Text) + Convert.ToDouble(Sum_Lbl_45.Text), 2));

            Sum_Lbl_Total.Text = Convert.ToString(Count_Total);

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Sum_Lbls_Total();
        }
        //------------------------------------------------------------------------------------------------------------
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void назадToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            KaztemirContractForm kz = new KaztemirContractForm();
            kz.ShowDialog();
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Проставьте значения");
        }

        private void label23_Click(object sender, EventArgs e)
        {

        }
    }
}