using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class CreateTournament : Form
    {
        List<TeamModel> availableTeams = GlobalConfig.Connection.GetTeam_All();
        public CreateTournament()
        {
            InitializeComponent();

            InitializeLists();
        }

        private void InitializeLists()
        {
            selectTeamDropDown.DataSource = availableTeams;
            selectTeamDropDown.DisplayMember = "TeamName";
        }

        private void headerLabel_Click(object sender, EventArgs e)
        {
        }

        private void entryFeeLabel_Click(object sender, EventArgs e)
        {
        }

        private void selectTeamLabel_Click(object sender, EventArgs e)
        {
        }

        private void createNewTeamLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        }

        private void tournamentPlayersLabel_Click(object sender, EventArgs e)
        {
        }
    }
}