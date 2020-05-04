using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontEnd
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
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
    }
}
