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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

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
            //Arm10TB.PreviewKeyDown += Arm10TB_PreviewKeyDown;
            
            Arm10TB.KeyDown += Arm10TB_KeyDown;
            Arm12TB.KeyDown += Arm12TB_KeyDown;
            Arm14TB.KeyDown += Arm14TB_KeyDown;
            Arm16TB.KeyDown += Arm16TB_KeyDown;
            Arm18TB.KeyDown += Arm18TB_KeyDown;

            SteelCircle8TB.KeyDown += SteelCircle8TB_KeyDown;
            SteelCircle10TB.KeyDown +=SteelCircle10TB_KeyDown;
            SteelCircle12TB.KeyDown +=SteelCircle12TB_KeyDown;
            SteelCircle14TB.KeyDown +=SteelCircle14TB_KeyDown;
            SteelCircle16TB.KeyDown +=SteelCircle16TB_KeyDown;
            SteelCircle18TB.KeyDown +=SteelCircle18TB_KeyDown;
            SteelCircle20TB.KeyDown +=SteelCircle20TB_KeyDown;

            Sq8_TB.KeyDown +=Sq8_TB_KeyDown;
            Sq10_TB.KeyDown +=Sq10_TB_KeyDown;
            Sq12_TB.KeyDown +=Sq12_TB_KeyDown;
            Sq14_TB.KeyDown +=Sq14_TB_KeyDown;
            
            Corner1_TB.KeyDown +=Corner1_TB_KeyDown;
            Corner2_TB.KeyDown +=Corner2_TB_KeyDown;
            Corner3_TB.KeyDown +=Corner3_TB_KeyDown;
            Corner4_TB.KeyDown +=Corner4_TB_KeyDown;
            Corner5_TB.KeyDown +=Corner5_TB_KeyDown;
            Corner6_TB.KeyDown +=Corner6_TB_KeyDown;
            Corner7_TB.KeyDown +=Corner7_TB_KeyDown;
            Corner8_TB.KeyDown +=Corner8_TB_KeyDown;
            Corner9_TB.KeyDown +=Corner9_TB_KeyDown;
            Corner10_TB.KeyDown +=Corner10_TB_KeyDown;

            Shv_TB_10.KeyDown +=Shv_TB_10_KeyDown;
            Shv_TB_12.KeyDown +=Shv_TB_12_KeyDown;
            Shv_TB_14.KeyDown +=Shv_TB_14_KeyDown;
            Shv_TB_16.KeyDown +=Shv_TB_16_KeyDown;
            Shv_TB_18.KeyDown +=Shv_TB_18_KeyDown;

            Stripe_TB_1.KeyDown +=Stripe_TB_1_KeyDown;
            Stripe_TB_2.KeyDown +=Stripe_TB_2_KeyDown;
            Stripe_TB_3.KeyDown +=Stripe_TB_3_KeyDown;
            Stripe_TB_4.KeyDown +=Stripe_TB_4_KeyDown;

            Pipe_Rect_TB_1.KeyDown +=Pipe_Rect_TB_1_KeyDown;
            Pipe_Rect_TB_2.KeyDown +=Pipe_Rect_TB_2_KeyDown;
            Pipe_Rect_TB_3.KeyDown +=Pipe_Rect_TB_3_KeyDown;
            Pipe_Rect_TB_4.KeyDown +=Pipe_Rect_TB_4_KeyDown;
            Pipe_Rect_TB_5.KeyDown +=Pipe_Rect_TB_5_KeyDown;
            Pipe_Rect_TB_6.KeyDown +=Pipe_Rect_TB_6_KeyDown;
            Pipe_Rect_TB_7.KeyDown +=Pipe_Rect_TB_7_KeyDown;
            Pipe_Rect_TB_8.KeyDown +=Pipe_Rect_TB_8_KeyDown;
            Pipe_Rect_TB_9.KeyDown +=Pipe_Rect_TB_9_KeyDown;
            Pipe_Rect_TB_10.KeyDown +=Pipe_Rect_TB_10_KeyDown;
            Pipe_Rect_TB_11.KeyDown +=Pipe_Rect_TB_11_KeyDown;
            Pipe_Rect_TB_12.KeyDown +=Pipe_Rect_TB_12_KeyDown;
            Pipe_Rect_TB_13.KeyDown +=Pipe_Rect_TB_13_KeyDown;
            Pipe_Rect_TB_14.KeyDown +=Pipe_Rect_TB_14_KeyDown;
            Pipe_Rect_TB_15.KeyDown +=Pipe_Rect_TB_15_KeyDown;

            Shet_TB_1.KeyDown +=Shet_TB_1_KeyDown;
            Shet_TB_2.KeyDown +=Shet_TB_2_KeyDown;
            Shet_TB_3.KeyDown +=Shet_TB_3_KeyDown;
            Shet_TB_4.KeyDown +=Shet_TB_4_KeyDown;
            Shet_TB_5.KeyDown +=Shet_TB_5_KeyDown;
            Shet_TB_6.KeyDown +=Shet_TB_6_KeyDown;
            Shet_TB_7.KeyDown +=Shet_TB_7_KeyDown;
            Shet_TB_8.KeyDown +=Shet_TB_8_KeyDown;

            Seamless_Pipe_TB_1.KeyDown +=Seamless_Pipe_TB_1_KeyDown;
            Seamless_Pipe_TB_2.KeyDown +=Seamless_Pipe_TB_2_KeyDown;

            VGP_Pipe_TB_1.KeyDown +=VGP_Pipe_TB_1_KeyDown;
            VGP_Pipe_TB_2.KeyDown +=VGP_Pipe_TB_2_KeyDown;
            VGP_Pipe_TB_3.KeyDown +=VGP_Pipe_TB_3_KeyDown;
            VGP_Pipe_TB_4.KeyDown +=VGP_Pipe_TB_4_KeyDown;
            VGP_Pipe_TB_5.KeyDown +=VGP_Pipe_TB_5_KeyDown;
            VGP_Pipe_TB_6.KeyDown +=VGP_Pipe_TB_6_KeyDown;
            VGP_Pipe_TB_7.KeyDown +=VGP_Pipe_TB_7_KeyDown;
            VGP_Pipe_TB_8.KeyDown +=VGP_Pipe_TB_8_KeyDown;
            VGP_Pipe_TB_9.KeyDown +=VGP_Pipe_TB_9_KeyDown;
            VGP_Pipe_TB_10.KeyDown +=VGP_Pipe_TB_10_KeyDown;
            VGP_Pipe_TB_11.KeyDown +=VGP_Pipe_TB_11_KeyDown;
            VGP_Pipe_TB_12.KeyDown +=VGP_Pipe_TB_12_KeyDown;
            VGP_Pipe_TB_13.KeyDown +=VGP_Pipe_TB_13_KeyDown;
            VGP_Pipe_TB_14.KeyDown +=VGP_Pipe_TB_14_KeyDown;
            VGP_Pipe_TB_15.KeyDown +=VGP_Pipe_TB_15_KeyDown;
            VGP_Pipe_TB_16.KeyDown +=VGP_Pipe_TB_16_KeyDown;

            El_Weld_Pipe_TB_1.KeyDown +=El_Weld_Pipe_TB_1_KeyDown;
            El_Weld_Pipe_TB_2.KeyDown +=El_Weld_Pipe_TB_2_KeyDown;
            El_Weld_Pipe_TB_3.KeyDown +=El_Weld_Pipe_TB_3_KeyDown;

            Rect_Steel_Pipe_TB_1.KeyDown +=Rect_Steel_Pipe_TB_1_KeyDown;
            Rect_Steel_Pipe_TB_2.KeyDown +=Rect_Steel_Pipe_TB_2_KeyDown;
            Rect_Steel_Pipe_TB_3.KeyDown +=Rect_Steel_Pipe_TB_3_KeyDown;
            Rect_Steel_Pipe_TB_4.KeyDown +=Rect_Steel_Pipe_TB_4_KeyDown;
            Rect_Steel_Pipe_TB_5.KeyDown +=Rect_Steel_Pipe_TB_5_KeyDown;
            Rect_Steel_Pipe_TB_6.KeyDown +=Rect_Steel_Pipe_TB_6_KeyDown;
            Rect_Steel_Pipe_TB_7.KeyDown +=Rect_Steel_Pipe_TB_7_KeyDown;
            Rect_Steel_Pipe_TB_8.KeyDown +=Rect_Steel_Pipe_TB_8_KeyDown;
            Rect_Steel_Pipe_TB_9.KeyDown +=Rect_Steel_Pipe_TB_9_KeyDown;
            Rect_Steel_Pipe_TB_10.KeyDown +=Rect_Steel_Pipe_TB_10_KeyDown;
            Rect_Steel_Pipe_TB_11.KeyDown +=Rect_Steel_Pipe_TB_11_KeyDown;
            Rect_Steel_Pipe_TB_12.KeyDown +=Rect_Steel_Pipe_TB_12_KeyDown;
            Rect_Steel_Pipe_TB_13.KeyDown +=Rect_Steel_Pipe_TB_13_KeyDown;
            Rect_Steel_Pipe_TB_14.KeyDown +=Rect_Steel_Pipe_TB_14_KeyDown;
            Rect_Steel_Pipe_TB_15.KeyDown +=Rect_Steel_Pipe_TB_15_KeyDown;
            Rect_Steel_Pipe_TB_16.KeyDown +=Rect_Steel_Pipe_TB_16_KeyDown;
            Rect_Steel_Pipe_TB_17.KeyDown +=Rect_Steel_Pipe_TB_17_KeyDown;
            Rect_Steel_Pipe_TB_18.KeyDown +=Rect_Steel_Pipe_TB_18_KeyDown;
            Rect_Steel_Pipe_TB_19.KeyDown +=Rect_Steel_Pipe_TB_19_KeyDown;
            Rect_Steel_Pipe_TB_20.KeyDown +=Rect_Steel_Pipe_TB_20_KeyDown;
            Rect_Steel_Pipe_TB_21.KeyDown +=Rect_Steel_Pipe_TB_21_KeyDown;

            ///////////////////////////////////////////////////////////////

            Arm10TB.TextChanged += Arm10TB_TextChanged; // К текстовому полю добавляется в разделе События событие = метод textBox_TextChanged, оно меняет поля связанные рассчетом калькуляции
            Arm12TB.TextChanged += Arm12TB_TextChanged;
            Arm14TB.TextChanged += Arm14TB_TextChanged;
            Arm16TB.TextChanged += Arm16TB_TextChanged;
            Arm18TB.TextChanged += Arm18TB_TextChanged;

            SteelCircle8TB.TextChanged += SteelCircle8TB_TextChanged;
            SteelCircle10TB.TextChanged +=SteelCircle10TB_TextChanged;
            SteelCircle12TB.TextChanged +=SteelCircle12TB_TextChanged;
            SteelCircle14TB.TextChanged +=SteelCircle14TB_TextChanged;
            SteelCircle16TB.TextChanged +=SteelCircle16TB_TextChanged;
            SteelCircle18TB.TextChanged +=SteelCircle18TB_TextChanged;
            SteelCircle20TB.TextChanged +=SteelCircle20TB_TextChanged;

            Sq8_TB.TextChanged +=Sq8_TB_TextChanged;
            Sq10_TB.TextChanged +=Sq10_TB_TextChanged;
            Sq12_TB.TextChanged +=Sq12_TB_TextChanged;
            Sq14_TB.TextChanged +=Sq14_TB_TextChanged;
            
            Corner1_TB.TextChanged +=Corner1_TB_TextChanged;
            Corner2_TB.TextChanged +=Corner2_TB_TextChanged;
            Corner3_TB.TextChanged +=Corner3_TB_TextChanged;
            Corner4_TB.TextChanged +=Corner4_TB_TextChanged;
            Corner5_TB.TextChanged +=Corner5_TB_TextChanged;
            Corner6_TB.TextChanged +=Corner6_TB_TextChanged;
            Corner7_TB.TextChanged +=Corner7_TB_TextChanged;
            Corner8_TB.TextChanged +=Corner8_TB_TextChanged;
            Corner9_TB.TextChanged +=Corner9_TB_TextChanged;
            Corner10_TB.TextChanged +=Corner10_TB_TextChanged;

            Shv_TB_10.TextChanged +=Shv_TB_10_TextChanged;
            Shv_TB_12.TextChanged +=Shv_TB_12_TextChanged;
            Shv_TB_14.TextChanged +=Shv_TB_14_TextChanged;
            Shv_TB_16.TextChanged +=Shv_TB_16_TextChanged;
            Shv_TB_18.TextChanged +=Shv_TB_18_TextChanged;

            Stripe_TB_1.TextChanged +=Stripe_TB_1_TextChanged;
            Stripe_TB_2.TextChanged +=Stripe_TB_2_TextChanged;
            Stripe_TB_3.TextChanged +=Stripe_TB_3_TextChanged;
            Stripe_TB_4.TextChanged +=Stripe_TB_4_TextChanged;
            
            Pipe_Rect_TB_1.TextChanged +=Pipe_Rect_TB_1_TextChanged;
            Pipe_Rect_TB_2.TextChanged +=Pipe_Rect_TB_2_TextChanged;
            Pipe_Rect_TB_3.TextChanged +=Pipe_Rect_TB_3_TextChanged;
            Pipe_Rect_TB_4.TextChanged +=Pipe_Rect_TB_4_TextChanged;
            Pipe_Rect_TB_5.TextChanged +=Pipe_Rect_TB_5_TextChanged;
            Pipe_Rect_TB_6.TextChanged +=Pipe_Rect_TB_6_TextChanged;
            Pipe_Rect_TB_7.TextChanged +=Pipe_Rect_TB_7_TextChanged;
            Pipe_Rect_TB_8.TextChanged +=Pipe_Rect_TB_8_TextChanged;
            Pipe_Rect_TB_9.TextChanged +=Pipe_Rect_TB_9_TextChanged;
            Pipe_Rect_TB_10.TextChanged +=Pipe_Rect_TB_10_TextChanged;
            Pipe_Rect_TB_11.TextChanged +=Pipe_Rect_TB_11_TextChanged;
            Pipe_Rect_TB_12.TextChanged +=Pipe_Rect_TB_12_TextChanged;
            Pipe_Rect_TB_13.TextChanged +=Pipe_Rect_TB_13_TextChanged;
            Pipe_Rect_TB_14.TextChanged +=Pipe_Rect_TB_14_TextChanged;
            Pipe_Rect_TB_15.TextChanged +=Pipe_Rect_TB_15_TextChanged;

            Shet_TB_1.TextChanged +=Shet_TB_1_TextChanged;
            Shet_TB_2.TextChanged +=Shet_TB_2_TextChanged;
            Shet_TB_3.TextChanged +=Shet_TB_3_TextChanged;
            Shet_TB_4.TextChanged +=Shet_TB_4_TextChanged;
            Shet_TB_5.TextChanged +=Shet_TB_5_TextChanged;
            Shet_TB_6.TextChanged +=Shet_TB_6_TextChanged;
            Shet_TB_7.TextChanged +=Shet_TB_7_TextChanged;
            Shet_TB_8.TextChanged +=Shet_TB_8_TextChanged;

            Seamless_Pipe_TB_1.TextChanged +=Seamless_Pipe_TB_1_TextChanged;
            Seamless_Pipe_TB_2.TextChanged +=Seamless_Pipe_TB_2_TextChanged;

            VGP_Pipe_TB_1.TextChanged +=VGP_Pipe_TB_1_TextChanged;
            VGP_Pipe_TB_2.TextChanged +=VGP_Pipe_TB_2_TextChanged;
            VGP_Pipe_TB_3.TextChanged +=VGP_Pipe_TB_3_TextChanged;
            VGP_Pipe_TB_4.TextChanged +=VGP_Pipe_TB_4_TextChanged;
            VGP_Pipe_TB_5.TextChanged +=VGP_Pipe_TB_5_TextChanged;
            VGP_Pipe_TB_6.TextChanged +=VGP_Pipe_TB_6_TextChanged;
            VGP_Pipe_TB_7.TextChanged +=VGP_Pipe_TB_7_TextChanged;
            VGP_Pipe_TB_8.TextChanged +=VGP_Pipe_TB_8_TextChanged;
            VGP_Pipe_TB_9.TextChanged +=VGP_Pipe_TB_9_TextChanged;
            VGP_Pipe_TB_10.TextChanged +=VGP_Pipe_TB_10_TextChanged;
            VGP_Pipe_TB_11.TextChanged +=VGP_Pipe_TB_11_TextChanged;
            VGP_Pipe_TB_12.TextChanged +=VGP_Pipe_TB_12_TextChanged;
            VGP_Pipe_TB_13.TextChanged +=VGP_Pipe_TB_13_TextChanged;
            VGP_Pipe_TB_14.TextChanged +=VGP_Pipe_TB_14_TextChanged;
            VGP_Pipe_TB_15.TextChanged +=VGP_Pipe_TB_15_TextChanged;
            VGP_Pipe_TB_16.TextChanged +=VGP_Pipe_TB_16_TextChanged;

            El_Weld_Pipe_TB_1.TextChanged +=El_Weld_Pipe_TB_1_TextChanged;
            El_Weld_Pipe_TB_2.TextChanged +=El_Weld_Pipe_TB_2_TextChanged;
            El_Weld_Pipe_TB_3.TextChanged +=El_Weld_Pipe_TB_3_TextChanged;

            Rect_Steel_Pipe_TB_1.TextChanged +=Rect_Steel_Pipe_TB_1_TextChanged;
            Rect_Steel_Pipe_TB_2.TextChanged +=Rect_Steel_Pipe_TB_2_TextChanged;
            Rect_Steel_Pipe_TB_3.TextChanged +=Rect_Steel_Pipe_TB_3_TextChanged;
            Rect_Steel_Pipe_TB_4.TextChanged +=Rect_Steel_Pipe_TB_4_TextChanged;
            Rect_Steel_Pipe_TB_5.TextChanged +=Rect_Steel_Pipe_TB_5_TextChanged;
            Rect_Steel_Pipe_TB_6.TextChanged +=Rect_Steel_Pipe_TB_6_TextChanged;
            Rect_Steel_Pipe_TB_7.TextChanged +=Rect_Steel_Pipe_TB_7_TextChanged;
            Rect_Steel_Pipe_TB_8.TextChanged +=Rect_Steel_Pipe_TB_8_TextChanged;
            Rect_Steel_Pipe_TB_9.TextChanged +=Rect_Steel_Pipe_TB_9_TextChanged;
            Rect_Steel_Pipe_TB_10.TextChanged +=Rect_Steel_Pipe_TB_10_TextChanged;
            Rect_Steel_Pipe_TB_11.TextChanged +=Rect_Steel_Pipe_TB_11_TextChanged;
            Rect_Steel_Pipe_TB_12.TextChanged +=Rect_Steel_Pipe_TB_12_TextChanged;
            Rect_Steel_Pipe_TB_13.TextChanged +=Rect_Steel_Pipe_TB_13_TextChanged;
            Rect_Steel_Pipe_TB_14.TextChanged +=Rect_Steel_Pipe_TB_14_TextChanged;
            Rect_Steel_Pipe_TB_15.TextChanged +=Rect_Steel_Pipe_TB_15_TextChanged;
            Rect_Steel_Pipe_TB_16.TextChanged +=Rect_Steel_Pipe_TB_16_TextChanged;
            Rect_Steel_Pipe_TB_17.TextChanged +=Rect_Steel_Pipe_TB_17_TextChanged;
            Rect_Steel_Pipe_TB_18.TextChanged +=Rect_Steel_Pipe_TB_18_TextChanged;
            Rect_Steel_Pipe_TB_19.TextChanged +=Rect_Steel_Pipe_TB_19_TextChanged;
            Rect_Steel_Pipe_TB_20.TextChanged +=Rect_Steel_Pipe_TB_20_TextChanged;
            Rect_Steel_Pipe_TB_21.TextChanged +=Rect_Steel_Pipe_TB_21_TextChanged;

        }
        private void Arm10TB_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down) 
                e.IsInputKey = true; // теперь стрелка будет вызывать KeyDown
        }
        /// ///////////////////////////////////////////////

        private void Arm10TB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                Arm12TB.Focus();
        }
        private void Arm12TB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                Arm14TB.Focus();
            else if (e.KeyCode == Keys.F1)
                Arm10TB.Focus();
        }

        private void Arm14TB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                Arm16TB.Focus();
            else if (e.KeyCode == Keys.F1)
                Arm12TB.Focus();
        }
        private void Arm16TB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                Arm18TB.Focus();
            else if (e.KeyCode == Keys.F1)
                Arm14TB.Focus();
        }
        private void Arm18TB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                SteelCircle8TB.Focus();
            else if (e.KeyCode == Keys.F1)
                Arm16TB.Focus();
        }
        //-------------------------------------------------------------------------
        private void SteelCircle8TB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                SteelCircle10TB.Focus();
            else if (e.KeyCode == Keys.F1)
                Arm18TB.Focus();
        }
        private void SteelCircle10TB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                SteelCircle12TB.Focus();
            else if (e.KeyCode == Keys.F1)
                SteelCircle8TB.Focus();
        }
        private void SteelCircle12TB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                SteelCircle14TB.Focus();
            else if (e.KeyCode == Keys.F1)
                SteelCircle10TB.Focus();
        }
        private void SteelCircle14TB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                SteelCircle16TB.Focus();
            else if (e.KeyCode == Keys.F1)
                SteelCircle12TB.Focus();
        }
        private void SteelCircle16TB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                SteelCircle18TB.Focus();
            else if (e.KeyCode == Keys.F1)
                SteelCircle14TB.Focus();
        }
        private void SteelCircle18TB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                SteelCircle20TB.Focus();
            else if (e.KeyCode == Keys.F1)
                SteelCircle16TB.Focus();
        }
        private void SteelCircle20TB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                Sq8_TB.Focus();
            else if (e.KeyCode == Keys.F1)
                SteelCircle18TB.Focus();
        }
        //-----------------------------------------------------------------------------------------------------------
        private void Sq8_TB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                Sq10_TB.Focus();
            else if (e.KeyCode == Keys.F1)
                SteelCircle20TB.Focus();
        }
        private void Sq10_TB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                Sq12_TB.Focus();
            else if (e.KeyCode == Keys.F1)
                Sq8_TB.Focus();
        }
        private void Sq12_TB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                Sq14_TB.Focus();
            else if (e.KeyCode == Keys.F1)
                Sq10_TB.Focus();
        }
        private void Sq14_TB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                Corner1_TB.Focus();
            else if (e.KeyCode == Keys.F1)
                Sq12_TB.Focus();
        }
        //-----------------------------------------------------------------------------------------------------------
        private void Corner1_TB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                Corner2_TB.Focus();
            else if (e.KeyCode == Keys.F1)
                Sq14_TB.Focus();
        }
        private void Corner2_TB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                Corner3_TB.Focus();
            else if (e.KeyCode == Keys.F1)
                Corner1_TB.Focus();
        }
        private void Corner3_TB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                Corner4_TB.Focus();
            else if (e.KeyCode == Keys.F1)
                Corner2_TB.Focus();
        }
        private void Corner4_TB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                Corner5_TB.Focus();
            else if (e.KeyCode == Keys.F1)
                Corner3_TB.Focus();
        }
        private void Corner5_TB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                Corner6_TB.Focus();
            else if (e.KeyCode == Keys.F1)
                Corner4_TB.Focus();
        }
        private void Corner6_TB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                Corner7_TB.Focus();
            else if (e.KeyCode == Keys.F1)
                Corner5_TB.Focus();
        }
        private void Corner7_TB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                Corner8_TB.Focus();
            else if (e.KeyCode == Keys.F1)
                Corner6_TB.Focus();
        }
        private void Corner8_TB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                Corner9_TB.Focus();
            else if (e.KeyCode == Keys.F1)
                Corner7_TB.Focus();
        }
        private void Corner9_TB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                Corner10_TB.Focus();
            else if (e.KeyCode == Keys.F1)
                Corner8_TB.Focus();
        }
        private void Corner10_TB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                Shv_TB_10.Focus();
            else if (e.KeyCode == Keys.F1)
                Corner9_TB.Focus();
        }
        //-----------------------------------------------------------------------------------------------------------
        private void Shv_TB_10_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                Shv_TB_12.Focus();
            else if (e.KeyCode == Keys.F1)
                Corner10_TB.Focus();
        }
        private void Shv_TB_12_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                Shv_TB_14.Focus();
            else if (e.KeyCode == Keys.F1)
                Shv_TB_10.Focus();
        }
        private void Shv_TB_14_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                Shv_TB_16.Focus();
            else if (e.KeyCode == Keys.F1)
                Shv_TB_12.Focus();
        }
        private void Shv_TB_16_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                Shv_TB_18.Focus();
            else if (e.KeyCode == Keys.F1)
                Shv_TB_14.Focus();
        }
        private void Shv_TB_18_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                Stripe_TB_1.Focus();
            else if (e.KeyCode == Keys.F1)
                Shv_TB_16.Focus();
        }
        //-----------------------------------------------------------------------------------------------------------
        private void Stripe_TB_1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                Stripe_TB_2.Focus();
            else if (e.KeyCode == Keys.F1)
                Shv_TB_18.Focus();
        }
        private void Stripe_TB_2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                Stripe_TB_3.Focus();
            else if (e.KeyCode == Keys.F1)
                Stripe_TB_1.Focus();
        }
        private void Stripe_TB_3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                Stripe_TB_4.Focus();
            else if (e.KeyCode == Keys.F1)
                Stripe_TB_2.Focus();
        }
        private void Stripe_TB_4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                Pipe_Rect_TB_1.Focus();
            else if (e.KeyCode == Keys.F1)
                Stripe_TB_3.Focus();
        }
        //-----------------------------------------------------------------------------------------------------------
        private void Pipe_Rect_TB_1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                Pipe_Rect_TB_2.Focus();
            else if (e.KeyCode == Keys.F1)
                Stripe_TB_4.Focus();
        }
        private void Pipe_Rect_TB_2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                Pipe_Rect_TB_3.Focus();
            else if (e.KeyCode == Keys.F1)
                Pipe_Rect_TB_1.Focus();
        }
        private void Pipe_Rect_TB_3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                Pipe_Rect_TB_4.Focus();
            else if (e.KeyCode == Keys.F1)
                Pipe_Rect_TB_2.Focus();
        }
        private void Pipe_Rect_TB_4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                Pipe_Rect_TB_5.Focus();
            else if (e.KeyCode == Keys.F1)
                Pipe_Rect_TB_3.Focus();
        }
        private void Pipe_Rect_TB_5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                Pipe_Rect_TB_6.Focus();
            else if (e.KeyCode == Keys.F1)
                Pipe_Rect_TB_4.Focus();
        }
        private void Pipe_Rect_TB_6_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                Pipe_Rect_TB_7.Focus();
            else if (e.KeyCode == Keys.F1)
                Pipe_Rect_TB_5.Focus();
        }
        private void Pipe_Rect_TB_7_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                Pipe_Rect_TB_8.Focus();
            else if (e.KeyCode == Keys.F1)
                Pipe_Rect_TB_6.Focus();
        }
        private void Pipe_Rect_TB_8_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                Pipe_Rect_TB_9.Focus();
            else if (e.KeyCode == Keys.F1)
                Pipe_Rect_TB_7.Focus();
        }
        private void Pipe_Rect_TB_9_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                Pipe_Rect_TB_10.Focus();
            else if (e.KeyCode == Keys.F1)
                Pipe_Rect_TB_8.Focus();
        }
        private void Pipe_Rect_TB_10_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                Pipe_Rect_TB_11.Focus();
            else if (e.KeyCode == Keys.F1)
                Pipe_Rect_TB_9.Focus();
        }
        private void Pipe_Rect_TB_11_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                Pipe_Rect_TB_12.Focus();
            else if (e.KeyCode == Keys.F1)
                Pipe_Rect_TB_10.Focus();
        }
        private void Pipe_Rect_TB_12_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                Pipe_Rect_TB_13.Focus();
            else if (e.KeyCode == Keys.F1)
                Pipe_Rect_TB_11.Focus();
        }
        private void Pipe_Rect_TB_13_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                Pipe_Rect_TB_14.Focus();
            else if (e.KeyCode == Keys.F1)
                Pipe_Rect_TB_12.Focus();
        }
        private void Pipe_Rect_TB_14_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                Pipe_Rect_TB_15.Focus();
            else if (e.KeyCode == Keys.F1)
                Pipe_Rect_TB_13.Focus();
        }
        private void Pipe_Rect_TB_15_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                Shet_TB_1.Focus();
            else if (e.KeyCode == Keys.F1)
                Pipe_Rect_TB_14.Focus();
        }
        //-----------------------------------------------------------------------------------------------------------
        private void Shet_TB_1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                Shet_TB_2.Focus();
            else if (e.KeyCode == Keys.F1)
                Pipe_Rect_TB_14.Focus();
        }
        private void Shet_TB_2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                Shet_TB_3.Focus();
            else if (e.KeyCode == Keys.F1)
                Shet_TB_1.Focus();
        }
        private void Shet_TB_3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                Shet_TB_4.Focus();
            else if (e.KeyCode == Keys.F1)
                Shet_TB_2.Focus();
        }
        private void Shet_TB_4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                Shet_TB_5.Focus();
            else if (e.KeyCode == Keys.F1)
                Shet_TB_3.Focus();
        }
        private void Shet_TB_5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                Shet_TB_6.Focus();
            else if (e.KeyCode == Keys.F1)
                Shet_TB_4.Focus();
        }
        private void Shet_TB_6_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                Shet_TB_7.Focus();
            else if (e.KeyCode == Keys.F1)
                Shet_TB_5.Focus();
        }
        private void Shet_TB_7_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                Shet_TB_8.Focus();
            else if (e.KeyCode == Keys.F1)
                Shet_TB_6.Focus();
        }
        private void Shet_TB_8_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                Seamless_Pipe_TB_1.Focus();
            else if (e.KeyCode == Keys.F1)
                Shet_TB_7.Focus();
        }
        //-----------------------------------------------------------------------------------------------------------
        private void Seamless_Pipe_TB_1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                Seamless_Pipe_TB_2.Focus();
            else if (e.KeyCode == Keys.F1)
                Shet_TB_8.Focus();
        }
        private void Seamless_Pipe_TB_2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                VGP_Pipe_TB_1.Focus();
            else if (e.KeyCode == Keys.F1)
                Seamless_Pipe_TB_1.Focus();
        }

        //-----------------------------------------------------------------------------------------------------------
        private void VGP_Pipe_TB_1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                VGP_Pipe_TB_2.Focus();
            else if (e.KeyCode == Keys.F1)
                Seamless_Pipe_TB_2.Focus();
        }
        private void VGP_Pipe_TB_2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                VGP_Pipe_TB_3.Focus();
            else if (e.KeyCode == Keys.F1)
                VGP_Pipe_TB_1.Focus();
        }
        private void VGP_Pipe_TB_3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                VGP_Pipe_TB_4.Focus();
            else if (e.KeyCode == Keys.F1)
                VGP_Pipe_TB_2.Focus();
        }
        private void VGP_Pipe_TB_4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                VGP_Pipe_TB_5.Focus();
            else if (e.KeyCode == Keys.F1)
                VGP_Pipe_TB_3.Focus();
        }
        private void VGP_Pipe_TB_5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                VGP_Pipe_TB_6.Focus();
            else if (e.KeyCode == Keys.F1)
                VGP_Pipe_TB_4.Focus();
        }
        private void VGP_Pipe_TB_6_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                VGP_Pipe_TB_7.Focus();
            else if (e.KeyCode == Keys.F1)
                VGP_Pipe_TB_5.Focus();
        }
        private void VGP_Pipe_TB_7_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                VGP_Pipe_TB_8.Focus();
            else if (e.KeyCode == Keys.F1)
                VGP_Pipe_TB_6.Focus();
        }
        private void VGP_Pipe_TB_8_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                VGP_Pipe_TB_9.Focus();
            else if (e.KeyCode == Keys.F1)
                VGP_Pipe_TB_7.Focus();
        }
        private void VGP_Pipe_TB_9_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                VGP_Pipe_TB_10.Focus();
            else if (e.KeyCode == Keys.F1)
                VGP_Pipe_TB_8.Focus();
        }
        private void VGP_Pipe_TB_10_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                VGP_Pipe_TB_11.Focus();
            else if (e.KeyCode == Keys.F1)
                VGP_Pipe_TB_9.Focus();
        }
        private void VGP_Pipe_TB_11_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                VGP_Pipe_TB_12.Focus();
            else if (e.KeyCode == Keys.F1)
                VGP_Pipe_TB_10.Focus();
        }
        private void VGP_Pipe_TB_12_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                VGP_Pipe_TB_13.Focus();
            else if (e.KeyCode == Keys.F1)
                VGP_Pipe_TB_11.Focus();
        }
        private void VGP_Pipe_TB_13_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                VGP_Pipe_TB_14.Focus();
            else if (e.KeyCode == Keys.F1)
                VGP_Pipe_TB_12.Focus();
        }
        private void VGP_Pipe_TB_14_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                VGP_Pipe_TB_15.Focus();
            else if (e.KeyCode == Keys.F1)
                VGP_Pipe_TB_13.Focus();
        }
        private void VGP_Pipe_TB_15_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                El_Weld_Pipe_TB_1.Focus();
            else if (e.KeyCode == Keys.F1)
                VGP_Pipe_TB_14.Focus();
        }
        private void VGP_Pipe_TB_16_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                El_Weld_Pipe_TB_1.Focus();
            else if (e.KeyCode == Keys.F1)
                VGP_Pipe_TB_15.Focus();
        }

        //-----------------------------------------------------------------------------------------------------------
        private void El_Weld_Pipe_TB_1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                El_Weld_Pipe_TB_2.Focus();
            else if (e.KeyCode == Keys.F1)
                VGP_Pipe_TB_16.Focus();
        }
        private void El_Weld_Pipe_TB_2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                El_Weld_Pipe_TB_3.Focus();
            else if (e.KeyCode == Keys.F1)
                El_Weld_Pipe_TB_1.Focus();
        }
        private void El_Weld_Pipe_TB_3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                Rect_Steel_Pipe_TB_1.Focus();
            else if (e.KeyCode == Keys.F1)
                El_Weld_Pipe_TB_2.Focus();
        }
        //-----------------------------------------------------------------------------------------------------------
        private void Rect_Steel_Pipe_TB_1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                Rect_Steel_Pipe_TB_2.Focus();
            else if (e.KeyCode == Keys.F1)
                El_Weld_Pipe_TB_3.Focus();
        }
        private void Rect_Steel_Pipe_TB_2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                Rect_Steel_Pipe_TB_3.Focus();
            else if (e.KeyCode == Keys.F1)
                Rect_Steel_Pipe_TB_1.Focus();
        }
        private void Rect_Steel_Pipe_TB_3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                Rect_Steel_Pipe_TB_4.Focus();
            else if (e.KeyCode == Keys.F1)
                Rect_Steel_Pipe_TB_2.Focus();
        }
        private void Rect_Steel_Pipe_TB_4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                Rect_Steel_Pipe_TB_5.Focus();
            else if (e.KeyCode == Keys.F1)
                Rect_Steel_Pipe_TB_3.Focus();
        }
        private void Rect_Steel_Pipe_TB_5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                Rect_Steel_Pipe_TB_6.Focus();
            else if (e.KeyCode == Keys.F1)
                Rect_Steel_Pipe_TB_4.Focus();
        }
        private void Rect_Steel_Pipe_TB_6_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                Rect_Steel_Pipe_TB_7.Focus();
            else if (e.KeyCode == Keys.F1)
                Rect_Steel_Pipe_TB_5.Focus();
        }
        private void Rect_Steel_Pipe_TB_7_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                Rect_Steel_Pipe_TB_8.Focus();
            else if (e.KeyCode == Keys.F1)
                Rect_Steel_Pipe_TB_6.Focus();
        }
        private void Rect_Steel_Pipe_TB_8_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                Rect_Steel_Pipe_TB_9.Focus();
            else if (e.KeyCode == Keys.F1)
                Rect_Steel_Pipe_TB_7.Focus();
        }
        private void Rect_Steel_Pipe_TB_9_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                Rect_Steel_Pipe_TB_10.Focus();
            else if (e.KeyCode == Keys.F1)
                Rect_Steel_Pipe_TB_8.Focus();
        }
        private void Rect_Steel_Pipe_TB_10_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                Rect_Steel_Pipe_TB_11.Focus();
            else if (e.KeyCode == Keys.F1)
                Rect_Steel_Pipe_TB_9.Focus();
        }
        private void Rect_Steel_Pipe_TB_11_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                Rect_Steel_Pipe_TB_12.Focus();
            else if (e.KeyCode == Keys.F1)
                Rect_Steel_Pipe_TB_10.Focus();
        }
        private void Rect_Steel_Pipe_TB_12_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                Rect_Steel_Pipe_TB_13.Focus();
            else if (e.KeyCode == Keys.F1)
                Rect_Steel_Pipe_TB_11.Focus();
        }
        private void Rect_Steel_Pipe_TB_13_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                Rect_Steel_Pipe_TB_14.Focus();
            else if (e.KeyCode == Keys.F1)
                Rect_Steel_Pipe_TB_12.Focus();
        }
        private void Rect_Steel_Pipe_TB_14_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                Rect_Steel_Pipe_TB_15.Focus();
            else if (e.KeyCode == Keys.F1)
                Rect_Steel_Pipe_TB_13.Focus();
        }
        private void Rect_Steel_Pipe_TB_15_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                Rect_Steel_Pipe_TB_16.Focus();
            else if (e.KeyCode == Keys.F1)
                Rect_Steel_Pipe_TB_14.Focus();
        }
        private void Rect_Steel_Pipe_TB_16_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                Rect_Steel_Pipe_TB_17.Focus();
            else if (e.KeyCode == Keys.F1)
                Rect_Steel_Pipe_TB_15.Focus();
        }
        private void Rect_Steel_Pipe_TB_17_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                Rect_Steel_Pipe_TB_18.Focus();
            else if (e.KeyCode == Keys.F1)
                Rect_Steel_Pipe_TB_16.Focus();
        }
        private void Rect_Steel_Pipe_TB_18_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                Rect_Steel_Pipe_TB_19.Focus();
            else if (e.KeyCode == Keys.F1)
                Rect_Steel_Pipe_TB_17.Focus();
        }
        private void Rect_Steel_Pipe_TB_19_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                Rect_Steel_Pipe_TB_20.Focus();
            else if (e.KeyCode == Keys.F1)
                Rect_Steel_Pipe_TB_18.Focus();
        }
        private void Rect_Steel_Pipe_TB_20_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                Rect_Steel_Pipe_TB_21.Focus();
            else if (e.KeyCode == Keys.F1)
                Rect_Steel_Pipe_TB_19.Focus();
        }
        private void Rect_Steel_Pipe_TB_21_KeyDown(object sender, KeyEventArgs e)
        {
            /*if (e.KeyCode == Keys.F2)
                Rect_Steel_Pipe_TB_1.Focus(); */
            if (e.KeyCode == Keys.F1)
                Rect_Steel_Pipe_TB_20.Focus();
        }
        //-----------------------------------------------------------------------------------------------------------


        private void Arm10TB_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(Arm10TB.Text, out Arm10Text);
            TotalCount_Arm10Label.Text = Convert.ToString(Math.Round((Arm10Text * Convert.ToDouble(label13.Text)), 2));
            TotalSum_Arm10Label.Text = Convert.ToString(Math.Round(Arm10Text * Convert.ToDouble((label43.Text))));
            Perc20_Arm10Label.Text = Convert.ToString(Math.Round(Arm10Text * 20 / 100, 1));
            Whip_Arm10Label.Text = Convert.ToString(Math.Round(Arm10Text / 6, 2));

        }
        private void Arm12TB_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(Arm12TB.Text, out Arm12Text);
            TotalCount_Arm12Label.Text = Convert.ToString(Math.Round(Arm12Text * Convert.ToDouble(label12.Text), 2));
            TotalSum_Arm12Label.Text = Convert.ToString(Math.Round(Arm12Text * Convert.ToDouble((label42.Text))));

            Perc20_Arm12Label.Text = Convert.ToString(Math.Round(Arm12Text * 20 / 100, 1));
            Whip_Arm12Label.Text = Convert.ToString(Math.Round(Arm12Text / 6, 2));

        }
        private void Arm14TB_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(Arm14TB.Text, out Arm14Text);
            TotalCount_Arm14Label.Text = Convert.ToString(Math.Round(Arm14Text * Convert.ToDouble(label11.Text), 2));
            TotalSum_Arm14Label.Text = Convert.ToString(Math.Round(Arm14Text * Convert.ToDouble((label41.Text))));
            Perc20_Arm14Label.Text = Convert.ToString(Math.Round(Arm14Text * 20 / 100, 1));
            Whip_Arm14Label.Text = Convert.ToString(Math.Round(Arm14Text / 6, 2));

        }

        private void Arm16TB_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(Arm16TB.Text, out Arm16Text);
            TotalCount_Arm16Label.Text = Convert.ToString(Math.Round(Arm16Text * Convert.ToDouble(label10.Text), 2));
            TotalSum_Arm16Label.Text = Convert.ToString(Math.Round(Arm16Text * Convert.ToDouble((label40.Text))));
            Perc20_Arm16Label.Text = Convert.ToString(Math.Round(Arm16Text * 20 / 100, 1));
            Whip_Arm16Label.Text = Convert.ToString(Math.Round(Arm16Text / 6, 2));
        }
        private void Arm18TB_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(Arm18TB.Text, out Arm18Text);
            TotalCount_Arm18Label.Text = Convert.ToString(Math.Round(Arm18Text * Convert.ToDouble(label9.Text), 2));
            TotalSum_Arm18Label.Text = Convert.ToString(Math.Round(Arm18Text * Convert.ToDouble((label39.Text))));
            Perc20_Arm18Label.Text = Convert.ToString(Math.Round(Arm18Text * 20 / 100, 1));
            Whip_Arm18Label.Text = Convert.ToString(Math.Round(Arm18Text / 6, 2));

        }
        
        /// ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        

        private void SteelCircle8TB_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(SteelCircle8TB.Text, out SteelCircle8Text);
            Count_StCl8Lbl.Text = Convert.ToString(Math.Round(SteelCircle8Text * Convert.ToDouble(label81.Text), 2));
            Sum_SteelCircle_Lbl_8.Text = Convert.ToString(Math.Round(SteelCircle8Text * Convert.ToDouble(label71.Text), 2));

            Perc_SteelCircle_Lbl_8.Text = Convert.ToString(Math.Round(SteelCircle8Text * 20 / 100, 1));

            Whil_SteelCircle_Lbl_8.Text = Convert.ToString(Math.Round(SteelCircle8Text / 6, 2));

        }
        private void SteelCircle10TB_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(SteelCircle10TB.Text, out SteelCircle10Text);
            Count_StCl10Lbl.Text = Convert.ToString(Math.Round(SteelCircle10Text * Convert.ToDouble(label80.Text), 2));
            Sum_SteelCircle_Lbl_10.Text = Convert.ToString(Math.Round(SteelCircle10Text * Convert.ToDouble(label70.Text), 2));
            Perc_SteelCircle_Lbl_10.Text = Convert.ToString(Math.Round(SteelCircle10Text * 20 / 100, 1));
            Whil_SteelCircle_Lbl_10.Text = Convert.ToString(Math.Round(SteelCircle10Text / 6, 2));
            

        }
        private void SteelCircle12TB_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(SteelCircle12TB.Text, out SteelCircle12Text);
            Count_StCl12Lbl.Text = Convert.ToString(Math.Round(SteelCircle12Text * Convert.ToDouble(label79.Text), 2));
            Sum_SteelCircle_Lbl_12.Text = Convert.ToString(Math.Round(SteelCircle12Text * Convert.ToDouble(label79.Text), 2));
            Perc_SteelCircle_Lbl_12.Text = Convert.ToString(Math.Round(SteelCircle12Text * 20 / 100, 1));
            Whil_SteelCircle_Lbl_12.Text = Convert.ToString(Math.Round(SteelCircle12Text / 6, 2));
            

        }
        private void SteelCircle14TB_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(SteelCircle14TB.Text, out SteelCircle14Text);
            Count_StCl14Lbl.Text = Convert.ToString(Math.Round(SteelCircle14Text * Convert.ToDouble(label81.Text), 2));
            Sum_SteelCircle_Lbl_14.Text = Convert.ToString(Math.Round(SteelCircle14Text * Convert.ToDouble(label69.Text), 2));
            Perc_SteelCircle_Lbl_14.Text = Convert.ToString(Math.Round(SteelCircle14Text * 20 / 100, 1));
            Whil_SteelCircle_Lbl_14.Text = Convert.ToString(Math.Round(SteelCircle14Text / 6, 2));
          

        }
        private void SteelCircle16TB_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(SteelCircle16TB.Text, out SteelCircle16Text);
            Count_StCl16Lbl.Text = Convert.ToString(Math.Round(SteelCircle16Text * Convert.ToDouble(label81.Text), 2));
            Sum_SteelCircle_Lbl_16.Text = Convert.ToString(Math.Round(SteelCircle16Text * Convert.ToDouble(label67.Text), 2));
            Perc_SteelCircle_Lbl_16.Text = Convert.ToString(Math.Round(SteelCircle16Text * 20 / 100, 1));
            Whil_SteelCircle_Lbl_16.Text = Convert.ToString(Math.Round(SteelCircle16Text / 6, 2));
            
        }
        private void SteelCircle18TB_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(SteelCircle18TB.Text, out SteelCircle18Text);
            Count_StCl18Lbl.Text = Convert.ToString(Math.Round(SteelCircle18Text * Convert.ToDouble(label81.Text), 2));
            Sum_SteelCircle_Lbl_18.Text = Convert.ToString(Math.Round(SteelCircle18Text * Convert.ToDouble(label100.Text), 2));
            Perc_SteelCircle_Lbl_18.Text = Convert.ToString(Math.Round(SteelCircle18Text * 20 / 100, 1));
            Whil_SteelCircle_Lbl_18.Text = Convert.ToString(Math.Round(SteelCircle18Text / 6, 2));
           

        }
        private void SteelCircle20TB_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(SteelCircle20TB.Text, out SteelCircle20Text);
            Count_StC20Lbl.Text = Convert.ToString(Math.Round(SteelCircle20Text * Convert.ToDouble(label103.Text), 2));
            Sum_SteelCircle_Lbl_20.Text = Convert.ToString(Math.Round(SteelCircle20Text * Convert.ToDouble(label99.Text), 2));
            Perc_SteelCircle_Lbl_20.Text = Convert.ToString(Math.Round(SteelCircle20Text * 20 / 100, 1));
            Whil_SteelCircle_Lbl_20.Text = Convert.ToString(Math.Round(SteelCircle20Text / 6, 2));
        }

        /// ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void Sq8_TB_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(Sq8_TB.Text, out Sq8_Text);
            Count_Sq8Lbl.Text = Convert.ToString(Math.Round(Sq8_Text * Convert.ToDouble(label156.Text), 2));
            Sum_Rect_Lbl_8.Text = Convert.ToString(Math.Round(Sq8_Text * Convert.ToDouble(label146.Text), 2));
            Perc_Sq_Lbl_8.Text = Convert.ToString(Math.Round(Sq8_Text * 20 / 100, 1));
            Whil_Sq_Lbl_8.Text = Convert.ToString(Math.Round(Sq8_Text / 6, 2));
            

        }
        private void Sq10_TB_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(Sq10_TB.Text, out Sq10_Text);
            Count_Sq10Lbl.Text = Convert.ToString(Math.Round(Sq10_Text * Convert.ToDouble(label155.Text), 2));
            Sum_Rect_Lbl_10.Text = Convert.ToString(Math.Round(Sq10_Text * Convert.ToDouble(label145.Text), 2));
            Perc_Sq_Lbl_10.Text = Convert.ToString(Math.Round(Sq10_Text * 20 / 100, 1));
            Whil_Sq_Lbl_10.Text = Convert.ToString(Math.Round(Sq10_Text / 6, 2));
            

        }
        private void Sq12_TB_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(Sq12_TB.Text, out Sq12_Text);
            Count_Sq12Lbl.Text = Convert.ToString(Math.Round(Sq12_Text * Convert.ToDouble(label154.Text), 2));
            Sum_Rect_Lbl_12.Text = Convert.ToString(Math.Round(Sq12_Text * Convert.ToDouble(label144.Text), 2));
            Perc_Sq_Lbl_12.Text = Convert.ToString(Math.Round(Sq12_Text * 20 / 100, 1));
            Whil_Sq_Lbl_12.Text = Convert.ToString(Math.Round(Sq12_Text / 6, 2));
            
        }
        private void Sq14_TB_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(Sq14_TB.Text, out Sq14_Text);
            Count_Sq14Lbl.Text = Convert.ToString(Math.Round(Sq14_Text * Convert.ToDouble(label153.Text), 2));
            Sum_Rect_Lbl_14.Text = Convert.ToString(Math.Round(Sq14_Text * Convert.ToDouble(label143.Text), 2));
            Perc_Sq_Lbl_14.Text = Convert.ToString(Math.Round(Sq14_Text * 20 / 100, 1));
            Whil_Sq_Lbl_14.Text = Convert.ToString(Math.Round(Sq14_Text / 6, 2));
        }
        /// //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////// <summary>

        private void Corner1_TB_TextChanged(object sender, EventArgs e)
        { 
            double.TryParse(Corner1_TB.Text, out Corner1_Text);

            Count_Corner32x4Lbl.Text = Convert.ToString(Math.Round(Corner1_Text * Convert.ToDouble(label168.Text), 2));
            Sum_Corner_Lbl_1.Text = Convert.ToString(Math.Round(Corner1_Text * Convert.ToDouble(label127.Text), 2));
            Perc_Corner_Lbl_1.Text = Convert.ToString(Math.Round(Corner1_Text * 20 / 100, 1));
            Whil_Corner_Lbl_1.Text = Convert.ToString(Math.Round(Corner1_Text / 6, 2));
           

        }

        private void Corner2_TB_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(Corner2_TB.Text, out Corner2_Text);
            Count_Corner25x4Lbl.Text = Convert.ToString(Math.Round(Corner2_Text * Convert.ToDouble(label162.Text), 2));
            Sum_Corner_Lbl_2.Text = Convert.ToString(Math.Round(Corner2_Text * Convert.ToDouble(label126.Text), 2));
            Perc_Corner_Lbl_2.Text = Convert.ToString(Math.Round(Corner2_Text * 20 / 100, 1));
            Whil_Corner_Lbl_2.Text = Convert.ToString(Math.Round(Corner2_Text / 6, 2));
            

        }
        private void Corner3_TB_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(Corner3_TB.Text, out Corner3_Text);
            Count_Corner32x2Lbl.Text = Convert.ToString(Math.Round(Corner3_Text * Convert.ToDouble(label157.Text), 2));
            Sum_Corner_Lbl_3.Text = Convert.ToString(Math.Round(Corner3_Text * Convert.ToDouble(label125.Text), 2));
            Perc_Corner_Lbl_3.Text = Convert.ToString(Math.Round(Corner3_Text * 20 / 100, 1));
            Whil_Corner_Lbl_3.Text = Convert.ToString(Math.Round(Corner3_Text / 6, 2));
            
        }
        private void Corner4_TB_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(Corner4_TB.Text, out Corner4_Text);
            Count_Corner40x4Lbl.Text = Convert.ToString(Math.Round(Corner4_Text * Convert.ToDouble(label152.Text), 2));
            Sum_Corner_Lbl_4.Text = Convert.ToString(Math.Round(Corner4_Text * Convert.ToDouble(label124.Text), 2));
            Perc_Corner_Lbl_4.Text = Convert.ToString(Math.Round(Corner4_Text * 20 / 100, 1));
            Whil_Corner_Lbl_4.Text = Convert.ToString(Math.Round(Corner4_Text / 6, 2));
            
        }
        private void Corner5_TB_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(Corner5_TB.Text, out Corner5_Text);
            Count_Corner45x4Lbl.Text = Convert.ToString(Math.Round(Corner5_Text * Convert.ToDouble(label201.Text), 2));
            Sum_Corner_Lbl_5.Text = Convert.ToString(Math.Round(Corner5_Text * Convert.ToDouble(label193.Text), 2));
            Perc_Corner_Lbl_5.Text = Convert.ToString(Math.Round(Corner5_Text * 20 / 100, 1));
            Whil_Corner_Lbl_5.Text = Convert.ToString(Math.Round(Corner5_Text / 6, 2));
            
        }
        private void Corner6_TB_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(Corner6_TB.Text, out Corner6_Text);
            Count_Corner50x3Lbl.Text = Convert.ToString(Math.Round(Corner6_Text * Convert.ToDouble(label200.Text), 2));
            Sum_Corner_Lbl_6.Text = Convert.ToString(Math.Round(Corner6_Text * Convert.ToDouble(label192.Text), 2));
            Perc_Corner_Lbl_6.Text = Convert.ToString(Math.Round(Corner6_Text * 20 / 100, 1));
            Whil_Corner_Lbl_6.Text = Convert.ToString(Math.Round(Corner6_Text / 6, 2));
            
        }
        private void Corner7_TB_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(Corner7_TB.Text, out Corner7_Text);

            Count_Corner50x4Lbl.Text = Convert.ToString(Math.Round(Corner7_Text * Convert.ToDouble(label199.Text), 2));
            Sum_Corner_Lbl_7.Text = Convert.ToString(Math.Round(Corner7_Text * Convert.ToDouble(label191.Text), 2));
            Perc_Corner_Lbl_7.Text = Convert.ToString(Math.Round(Corner7_Text * 20 / 100, 1));
            Whil_Corner_Lbl_7.Text = Convert.ToString(Math.Round(Corner7_Text / 6, 2));
            
        }
        private void Corner8_TB_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(Corner8_TB.Text, out Corner8_Text);
            Count_Corner50x5Lbl.Text = Convert.ToString(Math.Round(Corner8_Text * Convert.ToDouble(label221.Text), 2));
            Sum_Corner_Lbl_8.Text = Convert.ToString(Math.Round(Corner8_Text * Convert.ToDouble(label217.Text), 2));
            Perc_Corner_Lbl_8.Text = Convert.ToString(Math.Round(Corner8_Text * 20 / 100, 1));
            Whil_Corner_Lbl_8.Text = Convert.ToString(Math.Round(Corner8_Text / 6, 2));
            
        }
        private void Corner9_TB_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(Corner9_TB.Text, out Corner9_Text);
            Count_Corner63x3Lbl.Text = Convert.ToString(Math.Round(Corner9_Text * Convert.ToDouble(label220.Text), 2));
            Sum_Corner_Lbl_9.Text = Convert.ToString(Math.Round(Corner9_Text * Convert.ToDouble(label216.Text), 2));
            Perc_Corner_Lbl_9.Text = Convert.ToString(Math.Round(Corner9_Text * 20 / 100, 1));
            Whil_Corner_Lbl_9.Text = Convert.ToString(Math.Round(Corner9_Text / 6, 2));
            
        }
        private void Corner10_TB_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(Corner10_TB.Text, out Corner10_Text);
            
            Count_Corner63x5Lbl.Text = Convert.ToString(Math.Round(Corner10_Text * Convert.ToDouble(label297.Text), 2));
            Sum_Corner_Lbl_10.Text = Convert.ToString(Math.Round(Corner10_Text * Convert.ToDouble(label289.Text), 2));
            Perc_Corner_Lbl_10.Text = Convert.ToString(Math.Round(Corner10_Text * 20 / 100, 1));
            Whil_Corner_Lbl_10.Text = Convert.ToString(Math.Round(Corner10_Text / 6, 2));
        }

        





        /// ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void Shv_TB_10_TextChanged(object sender, EventArgs e)
        { 
            double.TryParse(Shv_TB_10.Text, out Shv_Text_10);
            Count_Shv_10Lbl.Text = Convert.ToString(Math.Round(Shv_Text_10 * Convert.ToDouble(label296.Text), 2));
            Sum_Shv_Lbl_1.Text = Convert.ToString(Math.Round(Shv_Text_10 * Convert.ToDouble(label288.Text), 2));
            Perc_Shv_Lbl_1.Text = Convert.ToString(Math.Round(Shv_Text_10 / 6, 2));
            Whil_Shv_Lbl_1.Text = Convert.ToString(Math.Round(Shv_Text_10 / 6, 2));

        }
        private void Shv_TB_12_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(Shv_TB_12.Text, out Shv_Text_12);
            Count_Shv_12Lbl.Text = Convert.ToString(Math.Round(Shv_Text_12 * Convert.ToDouble(label295.Text), 2));
            Sum_Shv_Lbl_2.Text = Convert.ToString(Math.Round(Shv_Text_12 * Convert.ToDouble(label287.Text), 2));
            Perc_Shv_Lbl_2.Text = Convert.ToString(Math.Round(Shv_Text_12 / 6, 2));
            Whil_Shv_Lbl_2.Text = Convert.ToString(Math.Round(Shv_Text_12 / 6, 2));

        }

        

        private void Shv_TB_14_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(Shv_TB_14.Text, out Shv_Text_14);
            Count_Shv_14Lbl.Text = Convert.ToString(Math.Round(Shv_Text_14 * Convert.ToDouble(label294.Text), 2));
            Sum_Shv_Lbl_3.Text = Convert.ToString(Math.Round(Shv_Text_14 * Convert.ToDouble(label286.Text), 2));
            Perc_Shv_Lbl_3.Text = Convert.ToString(Math.Round(Shv_Text_14 / 6, 2));
            Whil_Shv_Lbl_3.Text = Convert.ToString(Math.Round(Shv_Text_14 / 6, 2));

        }
        private void Shv_TB_16_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(Shv_TB_16.Text, out Shv_Text_16);
            Count_Shv_16Lbl.Text = Convert.ToString(Math.Round(Shv_Text_16 * Convert.ToDouble(label265.Text), 2));
            Sum_Shv_Lbl_4.Text = Convert.ToString(Math.Round(Shv_Text_16 * Convert.ToDouble(label257.Text), 2));
            Perc_Shv_Lbl_4.Text = Convert.ToString(Math.Round(Shv_Text_16 / 6, 2));
            Whil_Shv_Lbl_4.Text = Convert.ToString(Math.Round(Shv_Text_16 / 6, 2));

        }

        
        private void Shv_TB_18_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(Shv_TB_18.Text, out Shv_Text_18);
            Count_Shv_18Lbl.Text = Convert.ToString(Math.Round(Shv_Text_18 * Convert.ToDouble(label264.Text), 2));
            Sum_Shv_Lbl_5.Text = Convert.ToString(Math.Round(Shv_Text_18 * Convert.ToDouble(label256.Text), 2));
            Whil_Shv_Lbl_5.Text = Convert.ToString(Math.Round(Shv_Text_18 / 6, 2));
            Perc_Shv_Lbl_5.Text = Convert.ToString(Math.Round(Shv_Text_18 / 6, 2));
        }

        /// ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void Stripe_TB_1_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(Stripe_TB_1.Text, out Stripe_Text_1);
            Count_Stripe1Lbl.Text = Convert.ToString(Math.Round(Stripe_Text_1 * Convert.ToDouble(label266.Text), 2));
            Sum_Stripe_Lbl_1.Text = Convert.ToString(Math.Round(Stripe_Text_1 * Convert.ToDouble(label254.Text), 2));
            Perc_Shv_Lbl_1.Text = Convert.ToString(Math.Round(Stripe_Text_1 / 6, 2));

            Whil_Shv_Lbl_1.Text = Convert.ToString(Math.Round(Stripe_Text_1 / 6, 2));
            

        }

        private void Stripe_TB_2_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(Stripe_TB_2.Text, out Stripe_Text_2);
            Count_Stripe2Lbl.Text = Convert.ToString(Math.Round(Stripe_Text_2 * Convert.ToDouble(label263.Text), 2));
            Sum_Stripe_Lbl_2.Text = Convert.ToString(Math.Round(Stripe_Text_2 * Convert.ToDouble(label251.Text), 2));
            Perc_Shv_Lbl_2.Text = Convert.ToString(Math.Round(Stripe_Text_2 / 6, 2));
            Whil_Shv_Lbl_2.Text = Convert.ToString(Math.Round(Stripe_Text_2 / 6, 2));
            

        }

        private void Stripe_TB_3_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(Stripe_TB_3.Text, out Stripe_Text_3);
            Count_Stripe3Lbl.Text = Convert.ToString(Math.Round(Stripe_Text_3 * Convert.ToDouble(label262.Text), 2));
            Sum_Stripe_Lbl_3.Text = Convert.ToString(Math.Round(Stripe_Text_3 * Convert.ToDouble(label250.Text), 2));
            Perc_Shv_Lbl_3.Text = Convert.ToString(Math.Round(Stripe_Text_3 / 6, 2));
            Whil_Shv_Lbl_3.Text = Convert.ToString(Math.Round(Stripe_Text_3 / 6, 2));
            
        }

        private void Stripe_TB_4_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(Stripe_TB_4.Text, out Stripe_Text_4);
            Count_Stripe4Lbl.Text = Convert.ToString(Math.Round(Stripe_Text_4 * Convert.ToDouble(label234.Text), 2));
            Sum_Stripe_Lbl_4.Text = Convert.ToString(Math.Round(Stripe_Text_4 * Convert.ToDouble(label232.Text), 2));
            Perc_Shv_Lbl_4.Text = Convert.ToString(Math.Round(Stripe_Text_4 / 6, 2));
            Whil_Shv_Lbl_4.Text = Convert.ToString(Math.Round(Stripe_Text_4 / 6, 2));
        }

        /// ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void Pipe_Rect_TB_1_TextChanged(object sender, EventArgs e)
        {


            double.TryParse(Pipe_Rect_TB_1.Text, out Pipe_Rect_Text_1);


            Count_Pipe_Rect1Lbl.Text = Convert.ToString(Math.Round(Pipe_Rect_Text_1 * Convert.ToDouble(label390.Text), 2));
            Sum_Pipe_Rect_Lbl_1.Text = Convert.ToString(Math.Round(Pipe_Rect_Text_1 * Convert.ToDouble(label382.Text), 2));
            Perc_Pipe_Rect_Lbl_1.Text = Convert.ToString(Math.Round(Pipe_Rect_Text_1 / 6, 2));
            Whil_Pipe_Rect_Lbl_1.Text = Convert.ToString(Math.Round(Pipe_Rect_Text_1 / 6, 2));
           

        }

        private void Pipe_Rect_TB_2_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(Pipe_Rect_TB_2.Text, out Pipe_Rect_Text_2);
            Count_Pipe_Rect2Lbl.Text = Convert.ToString(Math.Round(Pipe_Rect_Text_2 * Convert.ToDouble(label389.Text), 2));
            Sum_Pipe_Rect_Lbl_2.Text = Convert.ToString(Math.Round(Pipe_Rect_Text_2 * Convert.ToDouble(label381.Text), 2));
            Perc_Pipe_Rect_Lbl_2.Text = Convert.ToString(Math.Round(Pipe_Rect_Text_2 / 6, 2));
            Whil_Pipe_Rect_Lbl_2.Text = Convert.ToString(Math.Round(Pipe_Rect_Text_2 / 6, 2));
            
        }

        private void Pipe_Rect_TB_3_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(Pipe_Rect_TB_3.Text, out Pipe_Rect_Text_3);
            Count_Pipe_Rect3Lbl.Text = Convert.ToString(Math.Round(Pipe_Rect_Text_3 * Convert.ToDouble(label388.Text), 2));
            Sum_Pipe_Rect_Lbl_3.Text = Convert.ToString(Math.Round(Pipe_Rect_Text_3 * Convert.ToDouble(label380.Text), 2));
            Perc_Pipe_Rect_Lbl_3.Text = Convert.ToString(Math.Round(Pipe_Rect_Text_3 / 6, 2));
            Whil_Pipe_Rect_Lbl_3.Text = Convert.ToString(Math.Round(Pipe_Rect_Text_3 / 6, 2));
            
        }

        private void Pipe_Rect_TB_4_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(Pipe_Rect_TB_4.Text, out Pipe_Rect_Text_4);
            Count_Pipe_Rect4Lbl.Text = Convert.ToString(Math.Round(Pipe_Rect_Text_4 * Convert.ToDouble(label387.Text), 2));
            Sum_Pipe_Rect_Lbl_4.Text = Convert.ToString(Math.Round(Pipe_Rect_Text_4 * Convert.ToDouble(label379.Text), 2));
            Perc_Pipe_Rect_Lbl_4.Text = Convert.ToString(Math.Round(Pipe_Rect_Text_4 / 6, 2));
            Whil_Pipe_Rect_Lbl_4.Text = Convert.ToString(Math.Round(Pipe_Rect_Text_4 / 6, 2));
            
        }

        private void Pipe_Rect_TB_5_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(Pipe_Rect_TB_5.Text, out Pipe_Rect_Text_5);
            Count_Pipe_Rect5Lbl.Text = Convert.ToString(Math.Round(Pipe_Rect_Text_5 * Convert.ToDouble(label358.Text), 2));
            Sum_Pipe_Rect_Lbl_5.Text = Convert.ToString(Math.Round(Pipe_Rect_Text_5 * Convert.ToDouble(label350.Text), 2));
            Perc_Pipe_Rect_Lbl_5.Text = Convert.ToString(Math.Round(Pipe_Rect_Text_5 / 6, 2));
            Whil_Pipe_Rect_Lbl_5.Text = Convert.ToString(Math.Round(Pipe_Rect_Text_5 / 6, 2));
           
        }

        private void Pipe_Rect_TB_6_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(Pipe_Rect_TB_6.Text, out Pipe_Rect_Text_6);
            Count_Pipe_Rect6Lbl.Text = Convert.ToString(Math.Round(Pipe_Rect_Text_6 * Convert.ToDouble(label357.Text), 2));
            Sum_Pipe_Rect_Lbl_6.Text = Convert.ToString(Math.Round(Pipe_Rect_Text_6 * Convert.ToDouble(label349.Text), 2));
            Perc_Pipe_Rect_Lbl_6.Text = Convert.ToString(Math.Round(Pipe_Rect_Text_6 / 6, 2));
            Whil_Pipe_Rect_Lbl_6.Text = Convert.ToString(Math.Round(Pipe_Rect_Text_6 / 6, 2));
           
        }

        private void Pipe_Rect_TB_7_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(Pipe_Rect_TB_7.Text, out Pipe_Rect_Text_7);
            Count_Pipe_Rect7Lbl.Text = Convert.ToString(Math.Round(Pipe_Rect_Text_7 * Convert.ToDouble(label356.Text), 2));
            Sum_Pipe_Rect_Lbl_7.Text = Convert.ToString(Math.Round(Pipe_Rect_Text_7 * Convert.ToDouble(label348.Text), 2));
            Perc_Pipe_Rect_Lbl_7.Text = Convert.ToString(Math.Round(Pipe_Rect_Text_7 / 6, 2));
            Whil_Pipe_Rect_Lbl_7.Text = Convert.ToString(Math.Round(Pipe_Rect_Text_7 / 6, 2));
           
        }

        private void Pipe_Rect_TB_8_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(Pipe_Rect_TB_8.Text, out Pipe_Rect_Text_8);
            Count_Pipe_Rect8Lbl.Text = Convert.ToString(Math.Round(Pipe_Rect_Text_8 * Convert.ToDouble(label330.Text), 2));
            Sum_Pipe_Rect_Lbl_8.Text = Convert.ToString(Math.Round(Pipe_Rect_Text_8 * Convert.ToDouble(label326.Text), 2));
            Perc_Pipe_Rect_Lbl_8.Text = Convert.ToString(Math.Round(Pipe_Rect_Text_8 / 6, 2));
            Whil_Pipe_Rect_Lbl_8.Text = Convert.ToString(Math.Round(Pipe_Rect_Text_8 / 6, 2));
           
        }

        private void Pipe_Rect_TB_9_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(Pipe_Rect_TB_9.Text, out Pipe_Rect_Text_9);
            Count_Pipe_Rect9Lbl.Text = Convert.ToString(Math.Round(Pipe_Rect_Text_9 * Convert.ToDouble(label329.Text), 2));
            Sum_Pipe_Rect_Lbl_9.Text = Convert.ToString(Math.Round(Pipe_Rect_Text_9 * Convert.ToDouble(label325.Text), 2));
            Perc_Pipe_Rect_Lbl_9.Text = Convert.ToString(Math.Round(Pipe_Rect_Text_9 / 6, 2));
            Whil_Pipe_Rect_Lbl_9.Text = Convert.ToString(Math.Round(Pipe_Rect_Text_9 / 6, 2));
            
        }

        private void Pipe_Rect_TB_10_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(Pipe_Rect_TB_10.Text, out Pipe_Rect_Text_10);
            Count_Pipe_Rect10Lbl.Text = Convert.ToString(Math.Round(Pipe_Rect_Text_10 * Convert.ToDouble(label316.Text), 2));
            Sum_Pipe_Rect_Lbl_10.Text = Convert.ToString(Math.Round(Pipe_Rect_Text_10 * Convert.ToDouble(label314.Text), 2));
            Perc_Pipe_Rect_Lbl_10.Text = Convert.ToString(Math.Round(Pipe_Rect_Text_10 / 6, 2));
            Whil_Pipe_Rect_Lbl_10.Text = Convert.ToString(Math.Round(Pipe_Rect_Text_10 / 6, 2));
            
        }

        private void Pipe_Rect_TB_11_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(Pipe_Rect_TB_11.Text, out Pipe_Rect_Text_11);
            Count_Pipe_Rect11Lbl.Text = Convert.ToString(Math.Round(Pipe_Rect_Text_11 * Convert.ToDouble(label442.Text), 2));
            Sum_Pipe_Rect_Lbl_11.Text = Convert.ToString(Math.Round(Pipe_Rect_Text_11 * Convert.ToDouble(label436.Text), 2));
            Perc_Pipe_Rect_Lbl_11.Text = Convert.ToString(Math.Round(Pipe_Rect_Text_11 / 6, 2));
            Whil_Pipe_Rect_Lbl_11.Text = Convert.ToString(Math.Round(Pipe_Rect_Text_11 / 6, 2));
           
        }

        private void Pipe_Rect_TB_12_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(Pipe_Rect_TB_12.Text, out Pipe_Rect_Text_12);
            Count_Pipe_Rect12Lbl.Text = Convert.ToString(Math.Round(Pipe_Rect_Text_12 * Convert.ToDouble(label441.Text), 2));
            Sum_Pipe_Rect_Lbl_12.Text = Convert.ToString(Math.Round(Pipe_Rect_Text_12 * Convert.ToDouble(label435.Text), 2));
            Perc_Pipe_Rect_Lbl_12.Text = Convert.ToString(Math.Round(Pipe_Rect_Text_12 / 6, 2));
            Whil_Pipe_Rect_Lbl_12.Text = Convert.ToString(Math.Round(Pipe_Rect_Text_12 / 6, 2));
            
        }

        private void Pipe_Rect_TB_13_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(Pipe_Rect_TB_13.Text, out Pipe_Rect_Text_13);
            Count_Pipe_Rect13Lbl.Text = Convert.ToString(Math.Round(Pipe_Rect_Text_13 * Convert.ToDouble(label420.Text), 2));
            Sum_Pipe_Rect_Lbl_13.Text = Convert.ToString(Math.Round(Pipe_Rect_Text_13 * Convert.ToDouble(label416.Text), 2));
            Perc_Pipe_Rect_Lbl_13.Text = Convert.ToString(Math.Round(Pipe_Rect_Text_13 / 6, 2));
            Whil_Pipe_Rect_Lbl_13.Text = Convert.ToString(Math.Round(Pipe_Rect_Text_13 / 6, 2));
            
        }

        private void Pipe_Rect_TB_14_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(Pipe_Rect_TB_14.Text, out Pipe_Rect_Text_14);
            Count_Pipe_Rect14Lbl.Text = Convert.ToString(Math.Round(Pipe_Rect_Text_14 * Convert.ToDouble(label419.Text), 2));
            Sum_Pipe_Rect_Lbl_14.Text = Convert.ToString(Math.Round(Pipe_Rect_Text_14 * Convert.ToDouble(label415.Text), 2));
            Perc_Pipe_Rect_Lbl_14.Text = Convert.ToString(Math.Round(Pipe_Rect_Text_14 / 6, 2));
            Whil_Pipe_Rect_Lbl_14.Text = Convert.ToString(Math.Round(Pipe_Rect_Text_14 / 6, 2));
            
        }

        private void Pipe_Rect_TB_15_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(Pipe_Rect_TB_15.Text, out Pipe_Rect_Text_15);
            Count_Pipe_Rect15Lbl.Text = Convert.ToString(Math.Round(Pipe_Rect_Text_15 * Convert.ToDouble(label406.Text), 2));
            Sum_Pipe_Rect_Lbl_15.Text = Convert.ToString(Math.Round(Pipe_Rect_Text_15 * Convert.ToDouble(label404.Text), 2));
            Perc_Pipe_Rect_Lbl_15.Text = Convert.ToString(Math.Round(Pipe_Rect_Text_15 / 6, 2));
            Whil_Pipe_Rect_Lbl_15.Text = Convert.ToString(Math.Round(Pipe_Rect_Text_15 / 6, 2));

        }

        /// ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void Shet_TB_1_TextChanged(object sender, EventArgs e)
        {

            double.TryParse(Shet_TB_1.Text, out Shet_Text_1);
            Count_Shet_1Lbl.Text = Convert.ToString(Math.Round(Shet_Text_1 * Convert.ToDouble(label495.Text), 2));
            Sum_Shet_Lbl_1.Text = Convert.ToString(Math.Round(Shet_Text_1 * Convert.ToDouble(label485.Text), 2));
            Perc_Shet_Lbl_1.Text = Convert.ToString(Math.Round(Shet_Text_1 / 6, 2));
            Whil_Shet_Lbl_1.Text = Convert.ToString(Math.Round(Shet_Text_1 / 6, 2));
            
        }

        private void Shet_TB_2_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(Shet_TB_2.Text, out Shet_Text_2);
            Count_Shet_2Lbl.Text = Convert.ToString(Math.Round(Shet_Text_2 * Convert.ToDouble(label494.Text), 2));
            Sum_Shet_Lbl_2.Text = Convert.ToString(Math.Round(Shet_Text_2 * Convert.ToDouble(label484.Text), 2));
            Perc_Shet_Lbl_2.Text = Convert.ToString(Math.Round(Shet_Text_2 / 6, 2));
            Whil_Shet_Lbl_2.Text = Convert.ToString(Math.Round(Shet_Text_2 / 6, 2));
            
        }

        private void Shet_TB_3_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(Shet_TB_3.Text, out Shet_Text_3);
            Count_Shet_3Lbl.Text = Convert.ToString(Math.Round(Shet_Text_3 * Convert.ToDouble(label493.Text), 2));
            Sum_Shet_Lbl_3.Text = Convert.ToString(Math.Round(Shet_Text_3 * Convert.ToDouble(label483.Text), 2));
            Perc_Shet_Lbl_3.Text = Convert.ToString(Math.Round(Shet_Text_3 / 6, 2));
            Whil_Shet_Lbl_3.Text = Convert.ToString(Math.Round(Shet_Text_3 / 6, 2));
            
        }

        private void Shet_TB_4_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(Shet_TB_4.Text, out Shet_Text_4);
            Count_Shet_4Lbl.Text = Convert.ToString(Math.Round(Shet_Text_4 * Convert.ToDouble(label492.Text), 2));
            Sum_Shet_Lbl_4.Text = Convert.ToString(Math.Round(Shet_Text_4 * Convert.ToDouble(label482.Text), 2));
            Perc_Shet_Lbl_4.Text = Convert.ToString(Math.Round(Shet_Text_4 / 6, 2));
            Whil_Shet_Lbl_4.Text = Convert.ToString(Math.Round(Shet_Text_4 / 6, 2));
            
        }

        private void Shet_TB_5_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(Shet_TB_5.Text, out Shet_Text_5);
            Count_Shet_5Lbl.Text = Convert.ToString(Math.Round(Shet_Text_5 * Convert.ToDouble(label491.Text), 2));
            Sum_Shet_Lbl_5.Text = Convert.ToString(Math.Round(Shet_Text_5 * Convert.ToDouble(label481.Text), 2));
            Perc_Shet_Lbl_5.Text = Convert.ToString(Math.Round(Shet_Text_5 / 6, 2));
            Whil_Shet_Lbl_5.Text = Convert.ToString(Math.Round(Shet_Text_5 / 6, 2));
           
        }

        private void Shet_TB_6_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(Shet_TB_6.Text, out Shet_Text_6);
            Count_Shet_6Lbl.Text = Convert.ToString(Math.Round(Shet_Text_6 * Convert.ToDouble(label461.Text), 2));
            Sum_Shet_Lbl_6.Text = Convert.ToString(Math.Round(Shet_Text_6 * Convert.ToDouble(label457.Text), 2));
            Perc_Shet_Lbl_6.Text = Convert.ToString(Math.Round(Shet_Text_6 / 6, 2));
            Whil_Shet_Lbl_6.Text = Convert.ToString(Math.Round(Shet_Text_6 / 6, 2));
            
        }

        private void Shet_TB_7_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(Shet_TB_7.Text, out Shet_Text_7);
            Count_Shet_7Lbl.Text = Convert.ToString(Math.Round(Shet_Text_7 * Convert.ToDouble(label460.Text), 2));
            Sum_Shet_Lbl_7.Text = Convert.ToString(Math.Round(Shet_Text_7 * Convert.ToDouble(label456.Text), 2));
            Perc_Shet_Lbl_7.Text = Convert.ToString(Math.Round(Shet_Text_7 / 6, 2));
            Whil_Shet_Lbl_7.Text = Convert.ToString(Math.Round(Shet_Text_7 / 6, 2));
            
        }

        private void Shet_TB_8_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(Shet_TB_8.Text, out Shet_Text_8);
            Count_Shet_8Lbl.Text = Convert.ToString(Math.Round(Shet_Text_8 * Convert.ToDouble(label512.Text), 2));
            Sum_Shet_Lbl_8.Text = Convert.ToString(Math.Round(Shet_Text_8 * Convert.ToDouble(label510.Text), 2));
            Perc_Shet_Lbl_8.Text = Convert.ToString(Math.Round(Shet_Text_8 / 6, 2));
            Whil_Shet_Lbl_8.Text = Convert.ToString(Math.Round(Shet_Text_8 / 6, 2));
        }

        /// ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void Seamless_Pipe_TB_1_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(Seamless_Pipe_TB_1.Text, out Seamless_Pipe_Text_1);
            Count_Seamless_Pipe_1Lbl.Text = Convert.ToString(Math.Round(Seamless_Pipe_Text_1 * Convert.ToDouble(label529.Text), 2));
            Sum_Seamless_Pipe_Lbl_1.Text = Convert.ToString(Math.Round(Seamless_Pipe_Text_1 * Convert.ToDouble(label527.Text), 2));
            Perc_Seamless_Pipe_Lbl_1.Text = Convert.ToString(Math.Round(Seamless_Pipe_Text_1 / 6, 2));
            Whil_Seamless_Pipe_Lbl_1.Text = Convert.ToString(Math.Round(Seamless_Pipe_Text_1 / 6, 2));
            
        }

        private void Seamless_Pipe_TB_2_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(Seamless_Pipe_TB_2.Text, out Seamless_Pipe_Text_2);
            Count_Seamless_Pipe_2Lbl.Text = Convert.ToString(Math.Round(Seamless_Pipe_Text_2 * Convert.ToDouble(label521.Text), 2));
            Sum_Seamless_Pipe_Lbl_2.Text = Convert.ToString(Math.Round(Seamless_Pipe_Text_2 * Convert.ToDouble(label519.Text), 2));
            Perc_Seamless_Pipe_Lbl_2.Text = Convert.ToString(Math.Round(Seamless_Pipe_Text_2 / 6, 2));
            Whil_Seamless_Pipe_Lbl_2.Text = Convert.ToString(Math.Round(Seamless_Pipe_Text_2 / 6, 2));
        }


        /// ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void VGP_Pipe_TB_1_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(VGP_Pipe_TB_1.Text, out VGP_Pipe_Text_1);
            Count_VGP_Pipe_1Lbl.Text = Convert.ToString(Math.Round(VGP_Pipe_Text_1 * Convert.ToDouble(label661.Text), 2));
            Sum_VGP_Pipe_Lbl_1.Text = Convert.ToString(Math.Round(VGP_Pipe_Text_1 * Convert.ToDouble(label661.Text), 2));
            Perc_VGP_Pipe_Lbl_1.Text = Convert.ToString(Math.Round(VGP_Pipe_Text_1 / 6, 2));
            Whil_VGP_Pipe_Lbl_1.Text = Convert.ToString(Math.Round(VGP_Pipe_Text_1 / 6, 2));
            
        }
        private void VGP_Pipe_TB_2_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(VGP_Pipe_TB_2.Text, out VGP_Pipe_Text_2);
            Count_VGP_Pipe_2Lbl.Text = Convert.ToString(Math.Round(VGP_Pipe_Text_2 * Convert.ToDouble(label660.Text), 2));
            Sum_VGP_Pipe_Lbl_2.Text = Convert.ToString(Math.Round(VGP_Pipe_Text_2 * Convert.ToDouble(label652.Text), 2));
            Perc_VGP_Pipe_Lbl_2.Text = Convert.ToString(Math.Round(VGP_Pipe_Text_2 / 6, 2));
            Whil_VGP_Pipe_Lbl_2.Text = Convert.ToString(Math.Round(VGP_Pipe_Text_2 / 6, 2));
            
        }
        private void VGP_Pipe_TB_3_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(VGP_Pipe_TB_3.Text, out VGP_Pipe_Text_3);
            Count_VGP_Pipe_3Lbl.Text = Convert.ToString(Math.Round(VGP_Pipe_Text_3 * Convert.ToDouble(label659.Text), 2));
            Sum_VGP_Pipe_Lbl_3.Text = Convert.ToString(Math.Round(VGP_Pipe_Text_3 * Convert.ToDouble(label651.Text), 2));
            Perc_VGP_Pipe_Lbl_3.Text = Convert.ToString(Math.Round(VGP_Pipe_Text_3 / 6, 2));
            Whil_VGP_Pipe_Lbl_3.Text = Convert.ToString(Math.Round(VGP_Pipe_Text_3 / 6, 2));
           
        }
        private void VGP_Pipe_TB_4_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(VGP_Pipe_TB_4.Text, out VGP_Pipe_Text_4);
            Count_VGP_Pipe_4Lbl.Text = Convert.ToString(Math.Round(VGP_Pipe_Text_4 * Convert.ToDouble(label658.Text), 2));
            Sum_VGP_Pipe_Lbl_4.Text = Convert.ToString(Math.Round(VGP_Pipe_Text_4 * Convert.ToDouble(label650.Text), 2));
            Perc_VGP_Pipe_Lbl_4.Text = Convert.ToString(Math.Round(VGP_Pipe_Text_4 / 6, 2));
            Whil_VGP_Pipe_Lbl_4.Text = Convert.ToString(Math.Round(VGP_Pipe_Text_4 / 6, 2));
            
        }
        private void VGP_Pipe_TB_5_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(VGP_Pipe_TB_5.Text, out VGP_Pipe_Text_5);
            Count_VGP_Pipe_5Lbl.Text = Convert.ToString(Math.Round(VGP_Pipe_Text_5 * Convert.ToDouble(label629.Text), 2));
            Sum_VGP_Pipe_Lbl_5.Text = Convert.ToString(Math.Round(VGP_Pipe_Text_5 * Convert.ToDouble(label621.Text), 2));
            Perc_VGP_Pipe_Lbl_5.Text = Convert.ToString(Math.Round(VGP_Pipe_Text_5 / 6, 2));
            Whil_VGP_Pipe_Lbl_5.Text = Convert.ToString(Math.Round(VGP_Pipe_Text_5 / 6, 2));
            
        }
        private void VGP_Pipe_TB_6_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(VGP_Pipe_TB_6.Text, out VGP_Pipe_Text_6);
            Count_VGP_Pipe_6Lbl.Text = Convert.ToString(Math.Round(VGP_Pipe_Text_6 * Convert.ToDouble(label628.Text), 2));
            Sum_VGP_Pipe_Lbl_6.Text = Convert.ToString(Math.Round(VGP_Pipe_Text_6 * Convert.ToDouble(label620.Text), 2));
            Perc_VGP_Pipe_Lbl_6.Text = Convert.ToString(Math.Round(VGP_Pipe_Text_6 / 6, 2));
            Whil_VGP_Pipe_Lbl_6.Text = Convert.ToString(Math.Round(VGP_Pipe_Text_6 / 6, 2));
            
        }
        private void VGP_Pipe_TB_7_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(VGP_Pipe_TB_7.Text, out VGP_Pipe_Text_7);
            Count_VGP_Pipe_7Lbl.Text = Convert.ToString(Math.Round(VGP_Pipe_Text_7 * Convert.ToDouble(label627.Text), 2));
            Sum_VGP_Pipe_Lbl_7.Text = Convert.ToString(Math.Round(VGP_Pipe_Text_7 * Convert.ToDouble(label619.Text), 2));
            Perc_VGP_Pipe_Lbl_7.Text = Convert.ToString(Math.Round(VGP_Pipe_Text_7 / 6, 2));
            Whil_VGP_Pipe_Lbl_7.Text = Convert.ToString(Math.Round(VGP_Pipe_Text_7 / 6, 2));
           
        }
        private void VGP_Pipe_TB_8_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(VGP_Pipe_TB_8.Text, out VGP_Pipe_Text_8);
            Count_VGP_Pipe_8Lbl.Text = Convert.ToString(Math.Round(VGP_Pipe_Text_8 * Convert.ToDouble(label601.Text), 2));
            Sum_VGP_Pipe_Lbl_8.Text = Convert.ToString(Math.Round(VGP_Pipe_Text_8 * Convert.ToDouble(label597.Text), 2));
            Perc_VGP_Pipe_Lbl_8.Text = Convert.ToString(Math.Round(VGP_Pipe_Text_8 / 6, 2));
            Whil_VGP_Pipe_Lbl_8.Text = Convert.ToString(Math.Round(VGP_Pipe_Text_8 / 6, 2));
           
        }
        private void VGP_Pipe_TB_9_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(VGP_Pipe_TB_9.Text, out VGP_Pipe_Text_9);
            Count_VGP_Pipe_9Lbl.Text = Convert.ToString(Math.Round(VGP_Pipe_Text_9 * Convert.ToDouble(label600.Text), 2));
            Sum_VGP_Pipe_Lbl_9.Text = Convert.ToString(Math.Round(VGP_Pipe_Text_9 * Convert.ToDouble(label596.Text), 2));
            Perc_VGP_Pipe_Lbl_9.Text = Convert.ToString(Math.Round(VGP_Pipe_Text_9 / 6, 2));
            Whil_VGP_Pipe_Lbl_9.Text = Convert.ToString(Math.Round(VGP_Pipe_Text_9 / 6, 2));
            
        }
        private void VGP_Pipe_TB_10_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(VGP_Pipe_TB_10.Text, out VGP_Pipe_Text_10);
            Count_VGP_Pipe_10Lbl.Text = Convert.ToString(Math.Round(VGP_Pipe_Text_10 * Convert.ToDouble(label587.Text), 2));
            Sum_VGP_Pipe_Lbl_10.Text = Convert.ToString(Math.Round(VGP_Pipe_Text_10 * Convert.ToDouble(label585.Text), 2));
            Perc_VGP_Pipe_Lbl_10.Text = Convert.ToString(Math.Round(VGP_Pipe_Text_10 / 6, 2));
            Whil_VGP_Pipe_Lbl_10.Text = Convert.ToString(Math.Round(VGP_Pipe_Text_10 / 6, 2));
            
        }
        private void VGP_Pipe_TB_11_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(VGP_Pipe_TB_11.Text, out VGP_Pipe_Text_11);
            Count_VGP_Pipe_11Lbl.Text = Convert.ToString(Math.Round(VGP_Pipe_Text_11 * Convert.ToDouble(label575.Text), 2));
            Sum_VGP_Pipe_Lbl_11.Text = Convert.ToString(Math.Round(VGP_Pipe_Text_11 * Convert.ToDouble(label569.Text), 2));
            Perc_VGP_Pipe_Lbl_11.Text = Convert.ToString(Math.Round(VGP_Pipe_Text_11 / 6, 2));
            Whil_VGP_Pipe_Lbl_11.Text = Convert.ToString(Math.Round(VGP_Pipe_Text_11 / 6, 2));
            
        }

        private void VGP_Pipe_TB_12_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(VGP_Pipe_TB_12.Text, out VGP_Pipe_Text_12);
            Count_VGP_Pipe_12Lbl.Text = Convert.ToString(Math.Round(VGP_Pipe_Text_12 * Convert.ToDouble(label574.Text), 2));
            Sum_VGP_Pipe_Lbl_12.Text = Convert.ToString(Math.Round(VGP_Pipe_Text_12 * Convert.ToDouble(label568.Text), 2));
            Perc_VGP_Pipe_Lbl_12.Text = Convert.ToString(Math.Round(VGP_Pipe_Text_12 / 6, 2));
            Whil_VGP_Pipe_Lbl_12.Text = Convert.ToString(Math.Round(VGP_Pipe_Text_12 / 6, 2));
            
        }
        private void VGP_Pipe_TB_13_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(VGP_Pipe_TB_13.Text, out VGP_Pipe_Text_13);
            Count_VGP_Pipe_13Lbl.Text = Convert.ToString(Math.Round(VGP_Pipe_Text_13 * Convert.ToDouble(label553.Text), 2));
            Sum_VGP_Pipe_Lbl_13.Text = Convert.ToString(Math.Round(VGP_Pipe_Text_13 * Convert.ToDouble(label549.Text), 2));
            Perc_VGP_Pipe_Lbl_13.Text = Convert.ToString(Math.Round(VGP_Pipe_Text_13 / 6, 2));
            Whil_VGP_Pipe_Lbl_13.Text = Convert.ToString(Math.Round(VGP_Pipe_Text_13 / 6, 2));
            
        }
        private void VGP_Pipe_TB_14_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(VGP_Pipe_TB_14.Text, out VGP_Pipe_Text_14);
            Count_VGP_Pipe_14Lbl.Text = Convert.ToString(Math.Round(VGP_Pipe_Text_14 * Convert.ToDouble(label552.Text), 2));
            Sum_VGP_Pipe_Lbl_14.Text = Convert.ToString(Math.Round(VGP_Pipe_Text_14 * Convert.ToDouble(label548.Text), 2));
            Perc_VGP_Pipe_Lbl_14.Text = Convert.ToString(Math.Round(VGP_Pipe_Text_14 / 6, 2));
            Whil_VGP_Pipe_Lbl_14.Text = Convert.ToString(Math.Round(VGP_Pipe_Text_14 / 6, 2));
            
        }
        private void VGP_Pipe_TB_15_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(VGP_Pipe_TB_15.Text, out VGP_Pipe_Text_15);
            Count_VGP_Pipe_15Lbl.Text = Convert.ToString(Math.Round(VGP_Pipe_Text_15 * Convert.ToDouble(label539.Text), 2));
            
            Sum_VGP_Pipe_Lbl_15.Text = Convert.ToString(Math.Round(VGP_Pipe_Text_15 * Convert.ToDouble(label537.Text), 2));
            Perc_VGP_Pipe_Lbl_15.Text = Convert.ToString(Math.Round(VGP_Pipe_Text_15 / 6, 2));
            Whil_VGP_Pipe_Lbl_15.Text = Convert.ToString(Math.Round(VGP_Pipe_Text_15 / 6, 2));
            
        }
        private void VGP_Pipe_TB_16_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(VGP_Pipe_TB_16.Text, out VGP_Pipe_Text_16);
            Count_VGP_Pipe_16Lbl.Text = Convert.ToString(Math.Round(VGP_Pipe_Text_16 * Convert.ToDouble(label676.Text), 2));
            Sum_VGP_Pipe_Lbl_16.Text = Convert.ToString(Math.Round(VGP_Pipe_Text_16 * Convert.ToDouble(label674.Text), 2));
            Perc_VGP_Pipe_Lbl_16.Text = Convert.ToString(Math.Round(VGP_Pipe_Text_16 / 6, 2));
            Whil_VGP_Pipe_Lbl_16.Text = Convert.ToString(Math.Round(VGP_Pipe_Text_16 / 6, 2));
        }


        /// ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void El_Weld_Pipe_TB_1_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(El_Weld_Pipe_TB_1.Text, out El_Weld_Pipe_Text_1);
            Count_El_Weld_Pipe_1Lbl.Text = Convert.ToString(Math.Round(El_Weld_Pipe_Text_1 * Convert.ToDouble(label693.Text), 2));
            Sum_El_Weld_Pipe_Lbl_1.Text = Convert.ToString(Math.Round(El_Weld_Pipe_Text_1 * Convert.ToDouble(label691.Text), 2));
            Perc_El_Weld_Pipe_Lbl_1.Text = Convert.ToString(Math.Round(El_Weld_Pipe_Text_1 / 6, 2));
            Whil_El_Weld_Pipe_Lbl_1.Text = Convert.ToString(Math.Round(El_Weld_Pipe_Text_1 / 6, 2));
            

        }
        private void El_Weld_Pipe_TB_2_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(El_Weld_Pipe_TB_2.Text, out El_Weld_Pipe_Text_2);
            Count_El_Weld_Pipe_2Lbl.Text = Convert.ToString(Math.Round(El_Weld_Pipe_Text_2 * Convert.ToDouble(label685.Text), 2));
            Sum_El_Weld_Pipe_Lbl_2.Text = Convert.ToString(Math.Round(El_Weld_Pipe_Text_2 * Convert.ToDouble(label683.Text), 2));
            Perc_El_Weld_Pipe_Lbl_2.Text = Convert.ToString(Math.Round(El_Weld_Pipe_Text_2 / 6, 2));
            Whil_El_Weld_Pipe_Lbl_2.Text = Convert.ToString(Math.Round(El_Weld_Pipe_Text_2 / 6, 2));
            
        }
        private void El_Weld_Pipe_TB_3_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(El_Weld_Pipe_TB_3.Text, out El_Weld_Pipe_Text_3);
            Count_El_Weld_Pipe_3Lbl.Text = Convert.ToString(Math.Round(El_Weld_Pipe_Text_3 * Convert.ToDouble(label702.Text), 2));
            Sum_El_Weld_Pipe_Lbl_3.Text = Convert.ToString(Math.Round(El_Weld_Pipe_Text_3 * Convert.ToDouble(label700.Text), 2));
            Perc_El_Weld_Pipe_Lbl_3.Text = Convert.ToString(Math.Round(El_Weld_Pipe_Text_3 / 6, 2));
            Whil_El_Weld_Pipe_Lbl_3.Text = Convert.ToString(Math.Round(El_Weld_Pipe_Text_3 / 6, 2));

        }
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void Rect_Steel_Pipe_TB_1_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(Rect_Steel_Pipe_TB_1.Text, out Rect_Steel_Pipe_Text_1);
            Count_Rect_Pipe_1Lbl.Text = Convert.ToString(Math.Round(Rect_Steel_Pipe_Text_1 * Convert.ToDouble(label841.Text), 2));
            Sum_Rect_Steel_Pipe_1.Text = Convert.ToString(Math.Round(Rect_Steel_Pipe_Text_1 * Convert.ToDouble(label833.Text), 2));

            Perc_Rect_Steel_Pipe_1.Text = Convert.ToString(Math.Round(Rect_Steel_Pipe_Text_1 / 6, 2));
            Whil_Rect_Steel_Pipe_1.Text = Convert.ToString(Math.Round(Rect_Steel_Pipe_Text_1 / 6, 2));
            

        }

        private void Rect_Steel_Pipe_TB_2_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(Rect_Steel_Pipe_TB_2.Text, out Rect_Steel_Pipe_Text_2);
            Count_Rect_Pipe_2Lbl.Text = Convert.ToString(Math.Round(Rect_Steel_Pipe_Text_2 * Convert.ToDouble(label840.Text), 2));
            Sum_Rect_Steel_Pipe_2.Text = Convert.ToString(Math.Round(Rect_Steel_Pipe_Text_2 * Convert.ToDouble(label832.Text), 2));
            Perc_Rect_Steel_Pipe_2.Text = Convert.ToString(Math.Round(Rect_Steel_Pipe_Text_2 / 6, 2));
            Whil_Rect_Steel_Pipe_2.Text = Convert.ToString(Math.Round(Rect_Steel_Pipe_Text_2 / 6, 2));
           

        }
        private void Rect_Steel_Pipe_TB_3_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(Rect_Steel_Pipe_TB_3.Text, out Rect_Steel_Pipe_Text_3);
            Count_Rect_Pipe_3Lbl.Text = Convert.ToString(Math.Round(Rect_Steel_Pipe_Text_3 * Convert.ToDouble(label839.Text), 2));
            Sum_Rect_Steel_Pipe_3.Text = Convert.ToString(Math.Round(Rect_Steel_Pipe_Text_3 * Convert.ToDouble(label831.Text), 2));
            Perc_Rect_Steel_Pipe_3.Text = Convert.ToString(Math.Round(Rect_Steel_Pipe_Text_3 / 6, 2));
            Whil_Rect_Steel_Pipe_3.Text = Convert.ToString(Math.Round(Rect_Steel_Pipe_Text_3 / 6, 2));
            

        }
        private void Rect_Steel_Pipe_TB_4_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(Rect_Steel_Pipe_TB_4.Text, out Rect_Steel_Pipe_Text_4);
            Count_Rect_Pipe_4Lbl.Text = Convert.ToString(Math.Round(Rect_Steel_Pipe_Text_4 * Convert.ToDouble(label838.Text), 2));
            Sum_Rect_Steel_Pipe_4.Text = Convert.ToString(Math.Round(Rect_Steel_Pipe_Text_4 * Convert.ToDouble(label830.Text), 2));
            Perc_Rect_Steel_Pipe_4.Text = Convert.ToString(Math.Round(Rect_Steel_Pipe_Text_4 / 6, 2));
            Whil_Rect_Steel_Pipe_4.Text = Convert.ToString(Math.Round(Rect_Steel_Pipe_Text_4 / 6, 2));
            

        }
        private void Rect_Steel_Pipe_TB_5_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(Rect_Steel_Pipe_TB_5.Text, out Rect_Steel_Pipe_Text_5);
            Count_Rect_Pipe_5Lbl.Text = Convert.ToString(Math.Round(Rect_Steel_Pipe_Text_5 * Convert.ToDouble(label809.Text), 2));
            Sum_Rect_Steel_Pipe_5.Text = Convert.ToString(Math.Round(Rect_Steel_Pipe_Text_5 * Convert.ToDouble(label801.Text), 2));
            Perc_Rect_Steel_Pipe_5.Text = Convert.ToString(Math.Round(Rect_Steel_Pipe_Text_5 / 6, 2));
            Whil_Rect_Steel_Pipe_5.Text = Convert.ToString(Math.Round(Rect_Steel_Pipe_Text_5 / 6, 2));
            
        }
        private void Rect_Steel_Pipe_TB_6_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(Rect_Steel_Pipe_TB_6.Text, out Rect_Steel_Pipe_Text_6);
            Count_Rect_Pipe_6Lbl.Text = Convert.ToString(Math.Round(Rect_Steel_Pipe_Text_6 * Convert.ToDouble(label808.Text), 2));
            Sum_Rect_Steel_Pipe_6.Text = Convert.ToString(Math.Round(Rect_Steel_Pipe_Text_6 * Convert.ToDouble(label800.Text), 2));
            Perc_Rect_Steel_Pipe_6.Text = Convert.ToString(Math.Round(Rect_Steel_Pipe_Text_6 / 6, 2));
            Whil_Rect_Steel_Pipe_6.Text = Convert.ToString(Math.Round(Rect_Steel_Pipe_Text_6 / 6, 2));
            


        }
        private void Rect_Steel_Pipe_TB_7_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(Rect_Steel_Pipe_TB_7.Text, out Rect_Steel_Pipe_Text_7);
            Count_Rect_Pipe_7Lbl.Text = Convert.ToString(Math.Round(Rect_Steel_Pipe_Text_7 * Convert.ToDouble(label807.Text), 2));
            Sum_Rect_Steel_Pipe_7.Text = Convert.ToString(Math.Round(Rect_Steel_Pipe_Text_7 * Convert.ToDouble(label799.Text), 2));
            Perc_Rect_Steel_Pipe_7.Text = Convert.ToString(Math.Round(Rect_Steel_Pipe_Text_7 / 6, 2));
            Whil_Rect_Steel_Pipe_7.Text = Convert.ToString(Math.Round(Rect_Steel_Pipe_Text_7 / 6, 2));
            

        }
        private void Rect_Steel_Pipe_TB_8_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(Rect_Steel_Pipe_TB_8.Text, out Rect_Steel_Pipe_Text_8);
            Count_Rect_Pipe_8Lbl.Text = Convert.ToString(Math.Round(Rect_Steel_Pipe_Text_8 * Convert.ToDouble(label781.Text), 2));
            Sum_Rect_Steel_Pipe_8.Text = Convert.ToString(Math.Round(Rect_Steel_Pipe_Text_8 * Convert.ToDouble(label777.Text), 2));
            Perc_Rect_Steel_Pipe_8.Text = Convert.ToString(Math.Round(Rect_Steel_Pipe_Text_8 / 6, 2));
            Whil_Rect_Steel_Pipe_8.Text = Convert.ToString(Math.Round(Rect_Steel_Pipe_Text_8 / 6, 2));
           

        }
        private void Rect_Steel_Pipe_TB_9_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(Rect_Steel_Pipe_TB_9.Text, out Rect_Steel_Pipe_Text_9);
            Count_Rect_Pipe_9Lbl.Text = Convert.ToString(Math.Round(Rect_Steel_Pipe_Text_9 * Convert.ToDouble(label780.Text), 2));
            Sum_Rect_Steel_Pipe_9.Text = Convert.ToString(Math.Round(Rect_Steel_Pipe_Text_9 * Convert.ToDouble(label776.Text), 2));
            Perc_Rect_Steel_Pipe_9.Text = Convert.ToString(Math.Round(Rect_Steel_Pipe_Text_9 / 6, 2));
            Whil_Rect_Steel_Pipe_9.Text = Convert.ToString(Math.Round(Rect_Steel_Pipe_Text_9 / 6, 2));
            

        }
        private void Rect_Steel_Pipe_TB_10_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(Rect_Steel_Pipe_TB_10.Text, out Rect_Steel_Pipe_Text_10);
            Count_Rect_Pipe_10Lbl.Text = Convert.ToString(Math.Round(Rect_Steel_Pipe_Text_10 * Convert.ToDouble(label767.Text), 2));
            Sum_Rect_Steel_Pipe_10.Text = Convert.ToString(Math.Round(Rect_Steel_Pipe_Text_10 * Convert.ToDouble(label765.Text), 2));
            Perc_Rect_Steel_Pipe_10.Text = Convert.ToString(Math.Round(Rect_Steel_Pipe_Text_10 / 6, 2));
            Whil_Rect_Steel_Pipe_10.Text = Convert.ToString(Math.Round(Rect_Steel_Pipe_Text_10 / 6, 2));
           

        }
        private void Rect_Steel_Pipe_TB_11_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(Rect_Steel_Pipe_TB_11.Text, out Rect_Steel_Pipe_Text_11);
            Count_Rect_Pipe_11Lbl.Text = Convert.ToString(Math.Round(Rect_Steel_Pipe_Text_11 * Convert.ToDouble(label755.Text), 2));
            Sum_Rect_Steel_Pipe_11.Text = Convert.ToString(Math.Round(Rect_Steel_Pipe_Text_11 * Convert.ToDouble(label749.Text), 2));
            Perc_Rect_Steel_Pipe_11.Text = Convert.ToString(Math.Round(Rect_Steel_Pipe_Text_11 / 6, 2));
            Whil_Rect_Steel_Pipe_11.Text = Convert.ToString(Math.Round(Rect_Steel_Pipe_Text_11 / 6, 2));
            

        }
        private void Rect_Steel_Pipe_TB_12_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(Rect_Steel_Pipe_TB_12.Text, out Rect_Steel_Pipe_Text_12);
            Count_Rect_Pipe_12Lbl.Text = Convert.ToString(Math.Round(Rect_Steel_Pipe_Text_12 * Convert.ToDouble(label754.Text), 2));
            Sum_Rect_Steel_Pipe_12.Text = Convert.ToString(Math.Round(Rect_Steel_Pipe_Text_12 * Convert.ToDouble(label748.Text), 2));
            Perc_Rect_Steel_Pipe_12.Text = Convert.ToString(Math.Round(Rect_Steel_Pipe_Text_12 / 6, 2));
            Whil_Rect_Steel_Pipe_12.Text = Convert.ToString(Math.Round(Rect_Steel_Pipe_Text_12 / 6, 2));
            
        }
        private void Rect_Steel_Pipe_TB_13_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(Rect_Steel_Pipe_TB_13.Text, out Rect_Steel_Pipe_Text_13);
            Count_Rect_Pipe_13Lbl.Text = Convert.ToString(Math.Round(Rect_Steel_Pipe_Text_13 * Convert.ToDouble(label733.Text), 2));
            Sum_Rect_Steel_Pipe_13.Text = Convert.ToString(Math.Round(Rect_Steel_Pipe_Text_13 * Convert.ToDouble(label729.Text), 2));
            Perc_Rect_Steel_Pipe_13.Text = Convert.ToString(Math.Round(Rect_Steel_Pipe_Text_13 / 6, 2));
            Whil_Rect_Steel_Pipe_13.Text = Convert.ToString(Math.Round(Rect_Steel_Pipe_Text_13 / 6, 2));
            


        }
        private void Rect_Steel_Pipe_TB_14_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(Rect_Steel_Pipe_TB_14.Text, out Rect_Steel_Pipe_Text_14);
            Count_Rect_Pipe_14Lbl.Text = Convert.ToString(Math.Round(Rect_Steel_Pipe_Text_14 * Convert.ToDouble(label732.Text), 2));
            Sum_Rect_Steel_Pipe_14.Text = Convert.ToString(Math.Round(Rect_Steel_Pipe_Text_14 * Convert.ToDouble(label728.Text), 2));
            Perc_Rect_Steel_Pipe_14.Text = Convert.ToString(Math.Round(Rect_Steel_Pipe_Text_14 / 6, 2));
            Whil_Rect_Steel_Pipe_14.Text = Convert.ToString(Math.Round(Rect_Steel_Pipe_Text_14 / 6, 2));
            

        }
        private void Rect_Steel_Pipe_TB_15_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(Rect_Steel_Pipe_TB_15.Text, out Rect_Steel_Pipe_Text_15);
            Count_Rect_Pipe_15Lbl.Text = Convert.ToString(Math.Round(Rect_Steel_Pipe_Text_15 * Convert.ToDouble(label719.Text), 2));
            Sum_Rect_Steel_Pipe_15.Text = Convert.ToString(Math.Round(Rect_Steel_Pipe_Text_15 * Convert.ToDouble(label717.Text), 2));
            Perc_Rect_Steel_Pipe_15.Text = Convert.ToString(Math.Round(Rect_Steel_Pipe_Text_15 / 6, 2));
            Whil_Rect_Steel_Pipe_15.Text = Convert.ToString(Math.Round(Rect_Steel_Pipe_Text_15 / 6, 2));
            

        }
        private void Rect_Steel_Pipe_TB_16_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(Rect_Steel_Pipe_TB_16.Text, out Rect_Steel_Pipe_Text_16);
            Count_Rect_Pipe_16Lbl.Text = Convert.ToString(Math.Round(Rect_Steel_Pipe_Text_16 * Convert.ToDouble(label711.Text), 2));
            Sum_Rect_Steel_Pipe_16.Text = Convert.ToString(Math.Round(Rect_Steel_Pipe_Text_16 * Convert.ToDouble(label709.Text), 2));
            Perc_Rect_Steel_Pipe_16.Text = Convert.ToString(Math.Round(Rect_Steel_Pipe_Text_16 / 6, 2));
            Whil_Rect_Steel_Pipe_16.Text = Convert.ToString(Math.Round(Rect_Steel_Pipe_Text_16 / 6, 2));
            

        }
        private void Rect_Steel_Pipe_TB_17_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(Rect_Steel_Pipe_TB_17.Text, out Rect_Steel_Pipe_Text_17);
            Count_Rect_Pipe_17Lbl.Text = Convert.ToString(Math.Round(Rect_Steel_Pipe_Text_17 * Convert.ToDouble(label894.Text), 2));
            Sum_Rect_Steel_Pipe_17.Text = Convert.ToString(Math.Round(Rect_Steel_Pipe_Text_17 * Convert.ToDouble(label890.Text), 2));
            Perc_Rect_Steel_Pipe_17.Text = Convert.ToString(Math.Round(Rect_Steel_Pipe_Text_17 / 6, 2));
            Whil_Rect_Steel_Pipe_17.Text = Convert.ToString(Math.Round(Rect_Steel_Pipe_Text_17 / 6, 2));
            

        }
        private void Rect_Steel_Pipe_TB_18_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(Rect_Steel_Pipe_TB_18.Text, out Rect_Steel_Pipe_Text_18);
            Count_Rect_Pipe_18Lbl.Text = Convert.ToString(Math.Round(Rect_Steel_Pipe_Text_18 * Convert.ToDouble(label878.Text), 2));
            Sum_Rect_Steel_Pipe_18.Text = Convert.ToString(Math.Round(Rect_Steel_Pipe_Text_18 * Convert.ToDouble(label874.Text), 2));
            Perc_Rect_Steel_Pipe_18.Text = Convert.ToString(Math.Round(Rect_Steel_Pipe_Text_18 / 6, 2));
            Whil_Rect_Steel_Pipe_18.Text = Convert.ToString(Math.Round(Rect_Steel_Pipe_Text_18 / 6, 2));
            
        }
        private void Rect_Steel_Pipe_TB_19_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(Rect_Steel_Pipe_TB_19.Text, out Rect_Steel_Pipe_Text_19);
            Count_Rect_Pipe_19Lbl.Text = Convert.ToString(Math.Round(Rect_Steel_Pipe_Text_19 * Convert.ToDouble(label877.Text), 2));
            Sum_Rect_Steel_Pipe_19.Text = Convert.ToString(Math.Round(Rect_Steel_Pipe_Text_19 * Convert.ToDouble(label873.Text), 2));
            Perc_Rect_Steel_Pipe_19.Text = Convert.ToString(Math.Round(Rect_Steel_Pipe_Text_19 / 6, 2));
            Whil_Rect_Steel_Pipe_19.Text = Convert.ToString(Math.Round(Rect_Steel_Pipe_Text_19 / 6, 2));
            


        }
        private void Rect_Steel_Pipe_TB_20_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(Rect_Steel_Pipe_TB_20.Text, out Rect_Steel_Pipe_Text_20);
            Count_Rect_Pipe_20Lbl.Text = Convert.ToString(Math.Round(Rect_Steel_Pipe_Text_20 * Convert.ToDouble(label864.Text), 2));
            Sum_Rect_Steel_Pipe_20.Text = Convert.ToString(Math.Round(Rect_Steel_Pipe_Text_20 * Convert.ToDouble(label862.Text), 2));
            Perc_Rect_Steel_Pipe_20.Text = Convert.ToString(Math.Round(Rect_Steel_Pipe_Text_20 / 6, 2));
            Whil_Rect_Steel_Pipe_20.Text = Convert.ToString(Math.Round(Rect_Steel_Pipe_Text_20 / 6, 2));
            

        }
        private void Rect_Steel_Pipe_TB_21_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(Rect_Steel_Pipe_TB_21.Text, out Rect_Steel_Pipe_Text_21);
            Count_Rect_Pipe_21Lbl.Text = Convert.ToString(Math.Round(Rect_Steel_Pipe_Text_21 * Convert.ToDouble(label864.Text), 2));
            Sum_Rect_Steel_Pipe_21.Text = Convert.ToString(Math.Round(Rect_Steel_Pipe_Text_21 * Convert.ToDouble(label854.Text), 2));
            Perc_Rect_Steel_Pipe_21.Text = Convert.ToString(Math.Round(Rect_Steel_Pipe_Text_21 / 6, 2));
            Whil_Rect_Steel_Pipe_21.Text = Convert.ToString(Math.Round(Rect_Steel_Pipe_Text_21 / 6, 2));
        }

        void TotalWeightSum()
        {
            totalWeightSumResult = double.Parse(TotalCount_Arm10Label.Text) + double.Parse(TotalCount_Arm12Label.Text) + double.Parse(TotalCount_Arm14Label.Text) + double.Parse(TotalCount_Arm16Label.Text) + double.Parse(TotalCount_Arm18Label.Text)+ double.Parse(Count_StCl8Lbl.Text) + double.Parse(Count_StCl10Lbl.Text) + double.Parse(Count_StCl12Lbl.Text)+ double.Parse(Count_StCl14Lbl.Text)+ double.Parse(Count_StCl16Lbl.Text)+ double.Parse(Count_StCl18Lbl.Text)+ double.Parse(Count_StC20Lbl.Text) + double.Parse(Count_Sq8Lbl.Text) + double.Parse(Count_Sq10Lbl.Text) + double.Parse(Count_Sq12Lbl.Text) + double.Parse(Count_Sq14Lbl.Text) +
              double.Parse(Count_Corner32x4Lbl.Text)+ double.Parse(Count_Corner25x4Lbl.Text)+ double.Parse(Count_Corner40x4Lbl.Text)+ double.Parse(Count_Corner45x4Lbl.Text)+ double.Parse(Count_Corner50x3Lbl.Text)+ double.Parse(Count_Corner50x4Lbl.Text)+ double.Parse(Count_Corner50x5Lbl.Text)+ double.Parse(Count_Corner63x3Lbl.Text) + double.Parse(Count_Corner63x5Lbl.Text)  ;




            totalWeightLlabel.Text = totalWeightSumResult.ToString();
        }


        public void ControlSetFocus(Control control)
        {
            control = Arm10TB;
            // Set focus to the control, if it can receive focus.
            if (control.CanFocus)
            {
                control.Focus();
            }
        }
        /*private void азияТемирЦентрToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }*/
        private void стальнойДворToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void металлСервисToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            MetallServiseForm ms = new MetallServiseForm();
            ms.ShowDialog();
        }
        /*private void металлСервисToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }*/
        private void выходToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void азияТемирЦентрToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            AsiaTemirForm t = new AsiaTemirForm();
            t.ShowDialog();
        }
        private void KaztemirContractForm_Load(object sender, EventArgs e)
        {

        }
        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void ToChooseButton_Click(object sender, EventArgs e)
        {
            /*this.Hide();
            // MainCalculationChooseForm s = new MainCalculationChooseForm();
            */
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
        private void назадToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            StartForm st = new StartForm();
            st.ShowDialog();
        }

        private void справкаToolStripMenuItem_Click_1(object sender, EventArgs e)
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
        private void дополнительныеМатериалыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdditionalMaterialsForm ad = new AdditionalMaterialsForm();
            ad.ShowDialog();
        }


        /* private void RezultButton_Click(object sender, EventArgs e)
         { 
             Count_And_Sum_Rezult();
             Percent_and_Whils_Rezult();
             TotalWeightSum();
         }

         void Count_And_Sum_Rezult()
         {
             //подсчет Количества(Общий вес)

             //подсчет Суммы////////////////////////////////////////////////////////////////////////////////////////

         }

        void Percent_and_Whils_Rezult()
        {
            //подсчет процентов(20%)

            //подсчет Хлыстов

        }

        protected override bool ProcessCmdKey(ref Text msg, Keys keyData)
        {
            if (keyData == (Keys.Down))//Меняй кнопки на что хочешь
                string x = Arm12TB.Focus();

            return base.ProcessCmdKey(ref msg, keyData);
        }
        protected override void OnClick(EventArgs e)
        {
            //this.SelectAll();
            base.OnClick(e);
        }
        /*protected void InvokeOnClick(System.Windows.Forms.Control toInvoke, EventArgs e)
        {
            //toInvoke = Arm12TB;
        }*/
    }
}
