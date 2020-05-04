using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Database.Model;
using Database;
using System.Transactions;

namespace FrontEnd
{
    public partial class MainWindow : Form
    {
        const string connectionString = @"Server=LAPTOP-TN62H4D5\SQLEXPRESS;Database=560 project;Integrated Security=SSPI;";

        private SqlBasketballTeamsrepository teamsrepo;
        private SqlTeamPlayerRepository PlayerTeamrepo;
        private SqlPlayerStatsRepository PlayerstatsRepo;
        private TransactionScope transaction;

        public MainWindow()
        {
            teamsrepo = new SqlBasketballTeamsrepository(connectionString);
            PlayerTeamrepo = new SqlTeamPlayerRepository(connectionString);
            PlayerstatsRepo = new SqlPlayerStatsRepository(connectionString);
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 1;
            //TeamPlayer team = PlayerTeamrepo.FetchTeamPlayer(1);
            IReadOnlyList<PlayerStats> plas = PlayerstatsRepo.RetrievePlayersStats();
            TeamPlayer z = PlayerTeamrepo.FetchTeamPlayer(1);
            BasketballTeam a = teamsrepo.GetBasketballTeam("Celtics");

            TeamPlayer T = PlayerTeamrepo.GetTeamPlayer("Alfonso", "Kelly");
            IReadOnlyList<PlayerStats> players = PlayerstatsRepo.RetrievePlayersStats();
            IReadOnlyList<TeamPlayer> tests = PlayerTeamrepo.RetrieveTeamPlayers();
            IReadOnlyList<BasketballTeam> teams = teamsrepo.RetrieveBasketballTeams();
            foreach (PlayerStats p in players)
            {
                i++;
            }



        }
    }
}
