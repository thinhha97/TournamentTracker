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
    public partial class CreateTournament : Form
    {
        readonly List<TeamModel> availableTeams = GlobalConfig.Connection.ReadTeam_All();
        readonly List<TeamModel> selectedTeams = new List<TeamModel>();
        readonly List<PrizeModel> selectedPrizes = new List<PrizeModel>();
        public CreateTournament()
        {
            InitializeComponent();
            InitializeLists();
        }
        private void InitializeLists()
        {
            cbxSelectTeam.DataSource = null;
            cbxSelectTeam.DataSource = availableTeams;
            cbxSelectTeam.DisplayMember = "TeamName";

            lbxTournamentTeams.DataSource = null;
            lbxTournamentTeams.DataSource = selectedTeams;
            lbxTournamentTeams.DisplayMember = "TeamName";

            lbxPrizesList.DataSource = null;
            lbxPrizesList.DataSource = selectedPrizes;
            lbxPrizesList.DisplayMember = "PlaceName ";

        }

        private void BtnAddTeam_Click(object sender, EventArgs e)
        {
            TeamModel teamModel = (TeamModel)cbxSelectTeam.SelectedItem;

            if (teamModel != null)
            {
                availableTeams.Remove(teamModel);

                selectedTeams.Add(teamModel);

                InitializeLists();
            }
        }

        private void BtnDeleteSelectedTeam_Click(object sender, EventArgs e)
        {
            TeamModel teamModel = (TeamModel)lbxTournamentTeams.SelectedItem;

            if (teamModel != null)
            {
                selectedTeams.Remove(teamModel);

                availableTeams.Add(teamModel);

                InitializeLists();
            }
        }

        private void BtnCreatePrize_Click(object sender, EventArgs e)
        {
            CreatePrize frm = new CreatePrize();
            frm.Show();
        }
    }
}
