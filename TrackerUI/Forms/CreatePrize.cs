﻿using System;
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

namespace TrackerUI.Forms
{
    public partial class CreatePrize : Form
    {
        public CreatePrize()
        {
            InitializeComponent();
        }

        private void BtnCreatePrize_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PrizeModel prizeModel = new PrizeModel(
                    txtPlaceNumber.Text,
                    txtPlaceName.Text,
                    txtPrizeAmount.Text,
                    txtPricePercentage.Text
                    );
                foreach(IDataConnection dc in GlobalConfig.Connections)
                {
                    dc.CreatePrize(prizeModel);
                }
            } else
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
            bool prizePercentageValid = double.TryParse(txtPricePercentage.Text, out double prizePercentage);

            if (prizeAmountValid || prizePercentageValid)
            {
                result = false;
            }

            if (prizeAmount <= 0 && (prizePercentage <= 0 || prizePercentage > 100))
            {
                result = false;
            }

            return result;
        }
    }
}
