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
//using System.Transactions;

namespace FrontEnd
{
    public partial class SearchWindow : Form
    {
        const string connectionString = @"Server=MIKE-PC2015;Database=560Project;Integrated Security = SSPI;";

        public static BindingList<TeamPlayer> playerList = new BindingList<TeamPlayer>();


        private SqlBasketballTeamsrepository teamsrepo;
        private SqlPlayerStatsRepository statsrepo;
        private SqlTeamPlayerRepository playerrepo;
        //private TransactionScope transaction;

        public SearchWindow()
        {
            InitializeComponent();
            //teamsrepo = new SqlBasketballTeamsrepository(connectionString);
            playerrepo = new SqlTeamPlayerRepository(connectionString);
            teamsrepo = new SqlBasketballTeamsrepository(connectionString);



        }

        private void uxSearchExecute_Click(object sender, EventArgs e)
        {




            int Row = 0;
            string firstName = uxFirstName.Text;
            string lastName = uxLastName.Text;
            TeamPlayer player;
            BasketballTeam team;

            player = playerrepo.GetTeamPlayer(firstName, lastName);
            uxGrid.Rows.Add();
            Row = uxGrid.Rows.Count - 2;
            if (player != null)
            {
                team = teamsrepo.FetchBasketballTeam(player.TeamId);
                uxGrid[0, Row].Value = player.FirstName + " " + player.LastName;
                uxGrid[1, Row].Value = player.JerseyNumber;
                uxGrid[2, Row].Value = player.Position;
                uxGrid[3, Row].Value = team.Name;
            }
            else
                MessageBox.Show("Player doesn't exist.");



        }

        private void uxShowAllBtn_Click(object sender, EventArgs e)
        {
            int Row = 0;
            BasketballTeam team;
            IReadOnlyList<TeamPlayer> playerList = playerrepo.RetrieveTeamPlayers();

            foreach (TeamPlayer p in playerList)
            {
                team = teamsrepo.FetchBasketballTeam(p.TeamId);
                uxGrid.Rows.Add();
                Row = uxGrid.Rows.Count - 2;
                uxGrid[0, Row].Value = p.FirstName + " " + p.LastName;
                uxGrid[1, Row].Value = p.JerseyNumber;
                uxGrid[2, Row].Value = p.Position;
                uxGrid[3, Row].Value = team.Name;
            }
        }
    }


}
