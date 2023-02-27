using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Data.SQLite;


namespace ModernCalculator
{
    public partial class EstimationForm : Form
    {
        double Customer, Amount, Main_materials, KZ_Temir, Casting, Additional_materials, Main_Transport_Expences, Sveller_Expences, Overheads_Expences_TotalWeight,
            Overheads_Expences_Total, Transaction_Salary, Transaction_Salary_Total, Preliminary_Design, Banner_Printing_Count, Banner_Printing,
            Total_Costs, Total;

        Bitmap bitmap;

        string connectionString = "Data Source=test_db.db;Version=3;";

        private void EstimationForm_Load(object sender, EventArgs e)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string selectQuery = "SELECT Casting_Summ_Total FROM Casting_Totals";
                using (var command = new SQLiteCommand(selectQuery, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Casting_TB.Text = reader.GetString(0);
                        }
                        else
                        {
                            Casting_TB.Text = "999";
                        }
                    }
                }
            }
            ToolTip t = new ToolTip();
            t.SetToolTip(Customer_TB, "Заказчик из Казтемир");
            var cst = new CastingForm();
            //cst.TotalSumText += Casting_TB.Text;
            Customer_TB.Text = GlobalData.CaptionFromKaztemirForm;
            //Casting_TB.Text = GlobalData.SummFromCastingForm;
            Additional_materials_TB.Text = GlobalData.SummFromAdditionalMaterialsForm;

        }

        public EstimationForm()
        {
            InitializeComponent();

            Customer_TB.TextChanged += Customer_TB_TextChanged;
            Transaction_Salary_TB.TextChanged += Transaction_Salary_TB_TextChanged;
            Banner_Printing_Count_TB.TextChanged += Banner_Printing_Count_TB_TextChanged;
            //Transaction_Salary_TB.TextChanged += Transaction_Salary_TB_TextChanged;
            
        }
        private void Customer_TB_TextChanged(object sender, EventArgs e)
        {
            if (Customer_TB.Text != " ")
            {
                double.TryParse(Customer_TB.Text, out Customer);
                Overheads_Expences_Total_TB.Text = Convert.ToString(Math.Round(Customer * Convert.ToDouble(Overheads_Expences_Const_Lbl.Text), 2));
                
            }
        }
        private void Transaction_Salary_TB_TextChanged(object sender, EventArgs e)
        {
            if (Customer_TB.Text != " ")
            {
                double.TryParse(Transaction_Salary_TB.Text, out Transaction_Salary);
                Transaction_Salary_Total_TB.Text = Convert.ToString(Math.Round((Transaction_Salary * 10/100), 2));

            }
        }
        private void Banner_Printing_Count_TB_TextChanged(object sender, EventArgs e)
        {
            if (Customer_TB.Text != " ")
            {
                double.TryParse(Banner_Printing_Count_TB.Text, out Banner_Printing_Count);
                Banner_Printing_TB.Text = Convert.ToString(Math.Round((Banner_Printing_Count * 2000), 2));

            }
        }
        public string TotalCastingText
        {
            get { return Casting_TB.Text; }
            set { Casting_TB.Text = value; }
        }
        private void казтемирКонтрактToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            KaztemirContractForm kaz = new KaztemirContractForm();
            kaz.ShowDialog();
        }

        private void сопутствующиеМатериалыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdditionalMaterialsForm ad = new AdditionalMaterialsForm();
            ad.ShowDialog();
        }

        private void литьеToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Hide();
            CastingForm cs = new CastingForm();
            cs.Show();
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Проставьте количество");
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
        }
        private void печатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Panel panel = new Panel();
            this.Controls.Add(panel);
            Graphics grp = panel.CreateGraphics();
            Size formSize = this.ClientSize;
            bitmap = new Bitmap(formSize.Width, formSize.Height, grp);
            grp = Graphics.FromImage(bitmap);
            Point panelLocation = PointToScreen(panel.Location);
            grp.CopyFromScreen(panelLocation.X, panelLocation.Y, 0, 0, formSize);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();
        }
        private void CaptureScreen()
        {
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            bitmap = new Bitmap(s.Width, s.Height+300, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(bitmap);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);
        }
        private void Price_Lbl_1_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }
        
    }
}
