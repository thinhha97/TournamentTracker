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
    public partial class TournamentDashboard : Form
    {
        List<TournamentModel> tournaments = GlobalConfig.Connection.ReadTournament_All();
        public TournamentDashboard()
        {
            InitializeComponent();
        }
    }
}
