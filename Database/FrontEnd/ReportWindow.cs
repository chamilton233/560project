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
    public partial class ReportWindow : Form
    {
        const string connectionString = @"Server=MIKE-PC2015;Database=560Project;Integrated Security = SSPI;";
        public List<TeamPlayer> playerList = new List<TeamPlayer>();
        private SqlPlayerStatsRepository statsrepo;



        public ReportWindow()
        {
            InitializeComponent();
            statsrepo = new SqlPlayerStatsRepository(connectionString);
        }

        private void uxRunReport_Click(object sender, EventArgs e)
        {
            PlayerStats stats = statsrepo.RetrievePlayersStats();
        }
    }
}
