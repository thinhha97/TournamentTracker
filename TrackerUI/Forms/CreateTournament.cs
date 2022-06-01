using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLib.Models;

namespace TrackerUI.Forms
{
    public partial class CreateTournament : Form
    {
        List<TeamModel> availableTeams = new List<TeamModel>();
        public CreateTournament()
        {
            InitializeComponent();
        }
    }
}
