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
    public partial class CreateTournament : Form, IPrizeRequester, ITeamRequester
    {
        readonly List<TeamModel> availableTeams = GlobalConfig.Connection.ReadTeam_All();
        readonly List<TeamModel> selectedTeams = new List<TeamModel>();
        readonly List<PrizeModel> selectedPrizes = new List<PrizeModel>();
        public CreateTournament()
        {
            InitializeComponent();
            ReloadLists();
        }
        private void ReloadLists()
        {
            cbxSelectTeam.DataSource = null;
            cbxSelectTeam.DataSource = availableTeams;
            cbxSelectTeam.DisplayMember = "TeamName";

            lbxTournamentTeams.DataSource = null;
            lbxTournamentTeams.DataSource = selectedTeams;
            lbxTournamentTeams.DisplayMember = "TeamName";

            lbxPrizesList.DataSource = null;
            lbxPrizesList.DataSource = selectedPrizes;
            lbxPrizesList.DisplayMember = "PlaceName";

        }

        private void BtnAddTeam_Click(object sender, EventArgs e)
        {
            TeamModel teamModel = (TeamModel)cbxSelectTeam.SelectedItem;

            if (teamModel != null)
            {
                availableTeams.Remove(teamModel);

                selectedTeams.Add(teamModel);

                ReloadLists();
            }
        }

        private void BtnRemoveSelectedTeam_Click(object sender, EventArgs e)
        {
            TeamModel teamModel = (TeamModel)lbxTournamentTeams.SelectedItem;

            if (teamModel != null)
            {
                selectedTeams.Remove(teamModel);

                availableTeams.Add(teamModel);

                ReloadLists();
            }
        }

        private void BtnCreatePrize_Click(object sender, EventArgs e)
        {
            CreatePrize frm = new CreatePrize(this);
            frm.Show();
        }


        private void BtnRemoveSelectedPrize_Click(object sender, EventArgs e)
        {
            PrizeModel prizeModel = (PrizeModel)lbxPrizesList.SelectedItem;
            if (prizeModel != null)
            {
                selectedPrizes.Remove(prizeModel);
                ReloadLists();
            }
        }
        public void PrizeComplete(PrizeModel prizeModel)
        {
            selectedPrizes.Add(prizeModel);
            ReloadLists();
        }

        public void TeamComplete(TeamModel teamModel)
        {
            selectedTeams.Add(teamModel);
            ReloadLists();
        }

        private void LnklbCreateNew_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateTeam frm = new CreateTeam(this);
            frm.Show();
        }

        private void BtnCreateTournament_Click(object sender, EventArgs e)
        {
            TournamentModel tournamentModel = new TournamentModel
            {
                TournamentName = txtTournamentName.Text
            };
            bool validFee = decimal.TryParse(txtEntryFee.Text, out decimal entryFee);
            if (validFee)
            {
                tournamentModel.EntryFee = entryFee;
            }
            else
            {
                MessageBox.Show(
                    "You need to enter a valid entry fee.",
                    "Invalid Fee",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            tournamentModel.EnteredTeams = selectedTeams;
            tournamentModel.Prizes = selectedPrizes;
            GlobalConfig.Connection.CreateTournament(tournamentModel);
        }
    }
}
