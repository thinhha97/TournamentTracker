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
        private readonly List<PersonModel> availableTeamMembers = GlobalConfig.Connection.ReadPerson_All();
        private List<PersonModel> selectedTeamMembers = new List<PersonModel>();
        public CreateTeam()
        {
            InitializeComponent();
            SetDataSourceForLists();
        }
        private void SetDataSourceForLists()
        {
            cbxSelectTeam.DataSource = null;
            cbxSelectTeam.DataSource = availableTeamMembers;
            cbxSelectTeam.DisplayMember = "FullName";

            lbxTeamMembers.DataSource = null;
            lbxTeamMembers.DataSource = selectedTeamMembers;
            lbxTeamMembers.DisplayMember = "FullName";
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

                selectedTeamMembers.Add(personModel);

                SetDataSourceForLists();

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

        private void btnAddTeamMember_Click(object sender, EventArgs e)
        {
            PersonModel personModel = (PersonModel)cbxSelectTeam.SelectedItem;

            if (personModel != null)
            {
                availableTeamMembers.Remove(personModel);

                selectedTeamMembers.Add(personModel);

                SetDataSourceForLists();
            }
        }

        private void btnDeleteSelectedTeamMember_Click(object sender, EventArgs e)
        {
            PersonModel personModel = (PersonModel)lbxTeamMembers.SelectedItem;

            if (personModel != null)
            {
                selectedTeamMembers.Remove(personModel);

                availableTeamMembers.Add(personModel);

                SetDataSourceForLists();
            }
        }

        private void btnCreateTeam_Click(object sender, EventArgs e)
        {
            TeamModel teamModel = new TeamModel();
            teamModel.TeamName = txtTeamName.Text;
            teamModel.TeamMembers = selectedTeamMembers;
            GlobalConfig.Connection.CreateTeam(teamModel);
        }
    }
}
