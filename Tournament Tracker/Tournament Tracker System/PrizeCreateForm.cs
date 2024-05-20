using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tournament_Tracker_Library;
using Tournament_Tracker_Library.DataAccess;
using Tournament_Tracker_Library.Models;

namespace Tournament_Tracker
{
    public partial class PrizeCreateForm : Form
    {
        IPrizeRequester callingForm;
        public PrizeCreateForm(IPrizeRequester caller)
        {
            InitializeComponent();
            callingForm = caller;
        }

        private void CreatePrizeBTN_Click(object sender, EventArgs e)
        {
            if(ValidateForm())
            {
                PrizeModel model = new PrizeModel(
                    PlaceNameTB.Text, 
                    PlaceNumberTB.Text, 
                    PrizeAmountTB.Text,
                    PrizePercentageTB.Text);

                GlobalConfig.Connection.CreatePrize(model);

                callingForm.PrizeComplete(model);

                this.Close();

                //PlaceNameTB.Text = "";
                //PlaceNumberTB.Text = "";
                //PrizeAmountTB.Text = "0";
                //PrizePercentageTB.Text = "0";
            }
            else
            {
                MessageBox.Show("This For, has invalid informations");
            }
        }

        private bool ValidateForm()
        {
            bool output = true;
            int placeNumber = 0;
            bool placeNumbeValidNumber = int.TryParse(PlaceNumberTB.Text, out placeNumber);

            if (!placeNumbeValidNumber)
            {
                output = false;
            }

            if (placeNumber < 1)
            {
                output = false;
            }

            if ( PlaceNameTB.Text .Length == 0 ) 
            {
                output = false;
            }

            decimal prizeAmount = 0;
            double prizePercentage = 0;

            bool prizeAmountValue = decimal.TryParse(PrizeAmountTB.Text, out prizeAmount);
            bool prizePercentageValid = double.TryParse(PrizePercentageTB.Text, out prizePercentage);

            if (prizeAmountValue == false || prizePercentageValid == false)
            {
                output = false;
            }

            if ( prizeAmount <= 0 && prizePercentage <=0)
            {
                output = false;
            }

            if (prizePercentage < 0 || prizePercentage > 100)
            {
                output = false;
            }

            return output;
        }
    }
}
