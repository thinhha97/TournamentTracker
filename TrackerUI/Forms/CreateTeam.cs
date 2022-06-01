using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLib.Classes;
using TrackerLib.Models;

namespace TrackerUI.Forms
{
    public partial class CreateTeam : Form
    {
        public CreateTeam()
        {
            InitializeComponent();
        }

        private void btnCreateMember_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PersonModel personModel = new PersonModel();
                personModel.FirstName = txtFirstName.Text;
                personModel.LastName = txtLastName.Text;
                personModel.EmailAddress = txtEmail.Text;
                personModel.CellPhoneNumber = txtCellphone.Text;

                GlobalConfig.Connection.CreatePerson(personModel);

            } else
            {
                MessageBox.Show("You need to fill all fields.");
            }
        }

        private bool ValidateForm()
        {
            if (String.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                return false;
            }
            if (String.IsNullOrWhiteSpace(txtLastName.Text))
            {
                return false;
            }
            if (String.IsNullOrWhiteSpace(txtEmail.Text))
            {
                return false;
            }
            if (String.IsNullOrWhiteSpace(txtCellphone.Text))
            {
                return false;
            }

            return true;
        }
    }
}
