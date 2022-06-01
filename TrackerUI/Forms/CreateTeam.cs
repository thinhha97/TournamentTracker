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
using TrackerUI.Interface;

namespace TrackerUI.Forms
{
    public partial class CreateTeam : Form
    {
        private readonly List<PersonModel> availableTeamMembers = GlobalConfig.Connection.ReadPerson_All();
        private readonly List<PersonModel> selectedTeamMembers = new List<PersonModel>();
        ITeamRequester callingForm;
        public CreateTeam(ITeamRequester caller)
        {
            InitializeComponent();
            ReloadLists();
            callingForm = caller;
        }
        private void ReloadLists()
        {
            cbxSelectTeam.DataSource = null;
            cbxSelectTeam.DataSource = availableTeamMembers;
            cbxSelectTeam.DisplayMember = "FullName";

            lbxTeamMembers.DataSource = null;
            lbxTeamMembers.DataSource = selectedTeamMembers;
            lbxTeamMembers.DisplayMember = "FullName";
        }

        private void BtnCreateMember_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PersonModel personModel = new PersonModel
                {
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    EmailAddress = txtEmail.Text,
                    CellPhoneNumber = txtCellphone.Text
                };

                GlobalConfig.Connection.CreatePerson(personModel);

                selectedTeamMembers.Add(personModel);

                ReloadLists();

                txtFirstName.Text = "";
                txtLastName.Text = "";
                txtEmail.Text = "";
                txtCellphone.Text = "";

            }
            else
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

        private void BtnAddTeamMember_Click(object sender, EventArgs e)
        {
            PersonModel personModel = (PersonModel)cbxSelectTeam.SelectedItem;

            if (personModel != null)
            {
                availableTeamMembers.Remove(personModel);

                selectedTeamMembers.Add(personModel);

                ReloadLists();
            }
        }

        private void BtnDeleteSelectedTeamMember_Click(object sender, EventArgs e)
        {
            PersonModel personModel = (PersonModel)lbxTeamMembers.SelectedItem;

            if (personModel != null)
            {
                selectedTeamMembers.Remove(personModel);

                availableTeamMembers.Add(personModel);

                ReloadLists();
            }
        }

        private void BtnCreateTeam_Click(object sender, EventArgs e)
        {
            TeamModel teamModel = new TeamModel
            {
                TeamName = txtTeamName.Text,
                TeamMembers = selectedTeamMembers
            };
            GlobalConfig.Connection.CreateTeam(teamModel);
            callingForm.TeamComplete(teamModel);
            this.Close();
        }
    }
}
