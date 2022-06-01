using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLib;
using TrackerLib.Classes;
using TrackerLib.DataAccess;
using TrackerLib.Models;
using TrackerUI.Interface;

namespace TrackerUI.Forms
{
    public partial class CreatePrize : Form
    {
        IPrizeRequester callingForm;
        public CreatePrize(IPrizeRequester caller)
        {
            InitializeComponent();
            callingForm = caller;
        }

        private void BtnCreatePrize_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PrizeModel prizeModel = new PrizeModel(
                    txtPlaceNumber.Text,
                    txtPlaceName.Text,
                    txtPrizeAmount.Text,
                    txtPrizePercentage.Text
                    );
                GlobalConfig.Connection.CreatePrize(prizeModel);

                callingForm.PrizeComplete(prizeModel);

                this.Close();
            }
            else
            {
                MessageBox.Show("This form has invalid information(s). Please check and retry.");
            }
        }

        private bool ValidateForm()
        {
            bool result = true;
            bool placeNumberValid = int.TryParse(txtPlaceNumber.Text, out int placeNumber);
            if (!placeNumberValid)
            {
                result = false;
            }
            if (placeNumber < 1)
            {
                result = false;
            }
            if (String.IsNullOrEmpty(txtPlaceName.Text))
            {
                result = false;
            }

            bool prizeAmountValid = decimal.TryParse(txtPrizeAmount.Text, out decimal prizeAmount);
            bool prizePercentageValid = double.TryParse(txtPrizePercentage.Text, out double prizePercentage);

            if (!prizeAmountValid && !prizePercentageValid)
            {
                result = false;
            }

            if (prizeAmount <= 0 && (prizePercentage <= 0 || prizePercentage > 100))
            {
                result = false;
            }

            return result;
        }

        private void TxtPrizeAmount_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtPrizeAmount.Text) && txtPrizeAmount.Text != "0")
            {
                txtPrizePercentage.Enabled = false;
            }
            else
            {
                txtPrizePercentage.Enabled = true;
            }
        }

        private void TxtPrizePercentage_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtPrizePercentage.Text) && txtPrizePercentage.Text != "0")
            {
                txtPrizeAmount.Enabled = false;
            }
            else
            {
                txtPrizeAmount.Enabled = true;
            }
        }

        private void CreatePrize_Load(object sender, EventArgs e)
        {
            txtPrizeAmount.Text = "0";
            txtPrizePercentage.Text = "0";
        }
    }
}
