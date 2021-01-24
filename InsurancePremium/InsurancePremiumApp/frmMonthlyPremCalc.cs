using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InsurancePremiumApp
{
    public partial class frmMonthlyPremCalc : Form
    {

        //string OccupationName = string.Empty;
        string Rating = string.Empty;
        double Factor = 0;

        public frmMonthlyPremCalc()
        {
            InitializeComponent();
            cmbOccupation.SelectedIndexChanged += cmbOccupation_SelectedIndexChanged;
            FillOccupation();


        }

        private void FillOccupation()
        {
            DataTable dtOccupation = new DataTable();
            DataRow dr;
            dtOccupation.Columns.Add("Text", typeof(string));
            dtOccupation.Columns.Add("Value", typeof(string));

            dr = dtOccupation.NewRow();
            dr["Text"] = "---Select Occupation--";
            dr["Value"] = "0";
            dtOccupation.Rows.Add(dr);

            dr = dtOccupation.NewRow();
            dr["Text"] = "Cleaner";
            dr["Value"] = "1";
            dtOccupation.Rows.Add(dr);

            dr = dtOccupation.NewRow();
            dr["Text"] = "Doctor";
            dr["Value"] = "2";
            dtOccupation.Rows.Add(dr);

            dr = dtOccupation.NewRow();
            dr["Text"] = "Author";
            dr["Value"] = "3";
            dtOccupation.Rows.Add(dr);

            dr = dtOccupation.NewRow();
            dr["Text"] = "Farmer";
            dr["Value"] = "4";
            dtOccupation.Rows.Add(dr);

            dr = dtOccupation.NewRow();
            dr["Text"] = "Mechanic";
            dr["Value"] = "5";
            dtOccupation.Rows.Add(dr);

            dr = dtOccupation.NewRow();
            dr["Text"] = "Florist";
            dr["Value"] = "6";
            dtOccupation.Rows.Add(dr);

            cmbOccupation.DataSource = dtOccupation;
            cmbOccupation.DisplayMember = "Text";
            cmbOccupation.ValueMember = "Value";
            cmbOccupation.SelectedIndex = 0;

        }
        private void SetOccupationRating(string _OccupationName)
        {

            switch (_OccupationName)
            {
                case "Cleaner":
                    {
                        Rating = "Light Manual";
                        break;
                    }
                case "Doctor":
                    {
                        Rating = "Professional";
                        break;
                    }
                case "Author":
                    {
                        Rating = "White Collar";
                        break;
                    }
                case "Farmer":
                    {
                        Rating = "Heavy Manual";
                        break;
                    }
                case "Mechanic":
                    {
                        Rating = "Heavy Manual";
                        break;
                    }
                case "Florist":
                    {
                        Rating = "Light Manual";
                        break;
                    }
            }

        }

        private void SetRatingFactor()
        {

            switch (Rating)
            {
                case "Professional":
                    {
                        Factor = 1.0;
                        break;
                    }
                case "White Collar":
                    {
                        Factor = 1.25;
                        break;
                    }
                case "Light Manual":
                    {
                        Factor = 1.50;
                        break;
                    }
                case "Heavy Manual":
                    {
                        Factor = 1.75;
                        break;
                    }
            }

        }

        private void CalcMonthlyPremium()
        {
            
            double monthlyDeathPremium = 0;
            double deathCoverAmt = Convert.ToDouble(txtDeathSumIns.Text);
            int Age = Convert.ToInt32(txtAge.Text);

            monthlyDeathPremium = (deathCoverAmt * Factor * Age) / (1000 * 12);

            txtMonthlyPremCalc.Text = Convert.ToString(Math.Round(monthlyDeathPremium, 2));


        }

        private void cmbOccupation_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            try
            {
                if (cmbOccupation.SelectedIndex > 0)
                {
                    SetOccupationRating(cmbOccupation.Text);
                    SetRatingFactor();
                    CalcMonthlyPremium();

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("frmMonthlyPremCalc.cmbOccupation_SelectedIndexChanged()" + ex.Message);
            }


        }


    }
}
