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

        private void uxSearch_Click(object sender, EventArgs e)
        {
            SearchWindow search = new SearchWindow();
            search.ShowDialog();
        }

        private void uxReports_Click(object sender, EventArgs e)
        {
            ReportWindow report = new ReportWindow();
            report.ShowDialog();
        }

        private void uxUpdateBtn_Click(object sender, EventArgs e)
        {
            UpdateWindow update = new UpdateWindow();
            update.ShowDialog();
        }
    }
}
