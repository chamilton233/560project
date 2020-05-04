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

            


        }

        private void uxSearchExecute_Click(object sender, EventArgs e)
        {
            //SqlConnection connection = new SqlConnection(connectionString);
            //connection.Open();

            //SqlCommand command;
            //SqlDataReader dataReader;
            //String sql, Output = "";
            string firstName = uxFirstName.Text;
            string lastName = uxLastName.Text;
            
            TeamPlayer player = playerrepo.GetTeamPlayer(firstName, lastName);
            //PlayerStats playerStats = statsrepo.FetchPlayerStats(1);
            MessageBox.Show("Player: " + player.FirstName + " " + player.LastName + " " + player.Position);

        }
    }


}
