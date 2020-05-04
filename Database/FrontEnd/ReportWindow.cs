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
        public List<TeamPlayer> playerList = new List<TeamPlayer>();


        public ReportWindow()
        {
            InitializeComponent();
        }
    }
}
