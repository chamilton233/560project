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
        private SqlPlayerStatsRepository statsrepo;
        private SqlTeamPlayerRepository playerrepo;

        public ReportWindow()
        {
            InitializeComponent();
            statsrepo = new SqlPlayerStatsRepository(connectionString);
            playerrepo = new SqlTeamPlayerRepository(connectionString);
        }

        private void uxRunReport_Click(object sender, EventArgs e)
        {
            uxGrid.Rows.Clear();
            uxGrid.Refresh();
            int Row = 0;
            TeamPlayer player;
            IReadOnlyList<PlayerStats> playerList = statsrepo.RetrievePlayersStats();
            List<PlayerStats> stats = playerList.ToList<PlayerStats>();
            PlayerStats[] statsArr = playerList.ToArray();
            PlayerStats temp;
            
            List<PlayerStats> sorted = stats.OrderBy(o => o.Points).ToList();

            if (uxPickStat.Text == "Points")
            
                sorted = stats.OrderBy(o => o.Points).ToList();
            
            else if (uxPickStat.Text == "Assists")
                sorted = stats.OrderBy(o => o.Assists).ToList();
            else if (uxPickStat.Text == "Free Throw Attempts")
                sorted = stats.OrderBy(o => o.FreeThrowsAttempts).ToList();
            else if (uxPickStat.Text == "Free Throws Made")
                sorted = stats.OrderBy(o => o.FreeThrowsMade).ToList();
            else if (uxPickStat.Text == "Rebounds")
                sorted = stats.OrderBy(o => o.Rebounds).ToList();
            else if (uxPickStat.Text == "Blocks")
                sorted = stats.OrderBy(o => o.Blocks).ToList();
            else if (uxPickStat.Text == "Steals")
                sorted = stats.OrderBy(o => o.Steals).ToList();


            //statsArr.Sort((x, y) => x.Assists.CompareTo(y.Assists));
            if (uxTopBot.SelectedIndex == 1)
                sorted.Reverse();
            else
                sorted.Take(Decimal.ToInt32(uxPlayerCount.Value));
            for (int i = 0; i < Decimal.ToInt32(uxPlayerCount.Value); i++)// PlayerStats s in sorted)//statsArr.Take(Decimal.ToInt32(playerCount.Value)))
            {
                player = playerrepo.FetchTeamPlayer(sorted[i].PlayerId);
                uxGrid.Rows.Add();
                Row = uxGrid.Rows.Count - 2;
                uxGrid[0, Row].Value = player.FirstName + " " + player.LastName;
                uxGrid[1, Row].Value = player.Position;
                uxGrid[2, Row].Value = sorted[i].Points;
                uxGrid[3, Row].Value = sorted[i].Assists;
                uxGrid[4, Row].Value = sorted[i].FreeThrowsAttempts;
                uxGrid[5, Row].Value = sorted[i].FreeThrowsMade;
                uxGrid[6, Row].Value = sorted[i].Rebounds;
                uxGrid[7, Row].Value = sorted[i].Blocks;
                uxGrid[8, Row].Value = sorted[i].Steals;
            }

            //else
            //{
            //    foreach (PlayerStats s in statsArr)
            //    {
            //        player = playerrepo.FetchTeamPlayer(s.PlayerId);
            //        uxGrid.Rows.Add();
            //        Row = uxGrid.Rows.Count - 2;
            //        uxGrid[0, Row].Value = player.FirstName + " " + player.LastName;
            //        uxGrid[1, Row].Value = player.Position;
            //        uxGrid[2, Row].Value = s.Points;
            //        uxGrid[3, Row].Value = s.Assists;
            //        uxGrid[4, Row].Value = s.FreeThrowsAttempts;
            //        uxGrid[5, Row].Value = s.FreeThrowsMade;
            //        uxGrid[6, Row].Value = s.Rebounds;
            //        uxGrid[7, Row].Value = s.Blocks;
            //        uxGrid[8, Row].Value = s.Steals;
            //    }
            //}
        }

        private void uxGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void reportList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void uxClear_Click(object sender, EventArgs e)
        {
            uxGrid.Rows.Clear();
            uxGrid.Refresh();
        }
    }
}
