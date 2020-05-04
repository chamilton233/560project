using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using Database;
using Database.Model;
using System.Data.SqlClient;

namespace FrontEnd
{
    public partial class UpdateWindow : Form
    {
        const string connectionString = @"Server=MIKE-PC2015;Database=560Project;Integrated Security = SSPI;";
        private SqlPlayerStatsRepository statsrepo;
        private SqlTeamPlayerRepository playerrepo;
        private SqlBasketballTeamsrepository teamrepo;

        public UpdateWindow()
        {
            InitializeComponent();
            statsrepo = new SqlPlayerStatsRepository(connectionString);
            playerrepo = new SqlTeamPlayerRepository(connectionString);
            teamrepo = new SqlBasketballTeamsrepository(connectionString);
        }

        private void uxInsertBtn_Click(object sender, EventArgs e)
        {
            string team = uxPickTeam.SelectedItem.ToString();
            playerrepo.CreatePlayer(teamrepo.GetBasketballTeam(team).TeamId, uxFirstName.Text, uxLastName.Text, Int32.Parse(uxJerseyNum.Text), uxPickPos.SelectedItem.ToString());
        }

        private void uxUpdateBtn_Click(object sender, EventArgs e)
        {
            string team = uxPickTeam.SelectedItem.ToString();
            playerrepo.UpdateTeamPlayer(playerrepo.GetTeamPlayer(uxFirstName.Text, uxLastName.Text).PlayerId, teamrepo.GetBasketballTeam(team).TeamId, uxFirstName.Text, uxLastName.Text, Int32.Parse(uxJerseyNum.Text), uxPickPos.SelectedItem.ToString());
        }
    }
}
