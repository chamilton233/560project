namespace FrontEnd
{
    partial class ReportWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.uxTopBot = new System.Windows.Forms.ComboBox();
            this.uxPlayerCount = new System.Windows.Forms.NumericUpDown();
            this.uxPickStat = new System.Windows.Forms.ComboBox();
            this.uxRunReport = new System.Windows.Forms.Button();
            this.uxGrid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.uxPlayerCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // uxTopBot
            // 
            this.uxTopBot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.uxTopBot.FormattingEnabled = true;
            this.uxTopBot.Items.AddRange(new object[] {
            "Bottom",
            "Top"});
            this.uxTopBot.Location = new System.Drawing.Point(20, 12);
            this.uxTopBot.Name = "uxTopBot";
            this.uxTopBot.Size = new System.Drawing.Size(121, 59);
            this.uxTopBot.TabIndex = 0;
            // 
            // uxPlayerCount
            // 
            this.uxPlayerCount.Location = new System.Drawing.Point(147, 13);
            this.uxPlayerCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.uxPlayerCount.Name = "uxPlayerCount";
            this.uxPlayerCount.Size = new System.Drawing.Size(120, 20);
            this.uxPlayerCount.TabIndex = 1;
            this.uxPlayerCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // uxPickStat
            // 
            this.uxPickStat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.uxPickStat.FormattingEnabled = true;
            this.uxPickStat.Items.AddRange(new object[] {
            "Points",
            "Assists",
            "Free Throw Attempts",
            "Free Throws Made",
            "Rebounds",
            "Blocks",
            "Steals"});
            this.uxPickStat.Location = new System.Drawing.Point(273, 12);
            this.uxPickStat.Name = "uxPickStat";
            this.uxPickStat.Size = new System.Drawing.Size(121, 124);
            this.uxPickStat.TabIndex = 4;
            // 
            // uxRunReport
            // 
            this.uxRunReport.Location = new System.Drawing.Point(448, 60);
            this.uxRunReport.Name = "uxRunReport";
            this.uxRunReport.Size = new System.Drawing.Size(75, 23);
            this.uxRunReport.TabIndex = 6;
            this.uxRunReport.Text = "Run Report";
            this.uxRunReport.UseVisualStyleBackColor = true;
            this.uxRunReport.Click += new System.EventHandler(this.uxRunReport_Click);
            // 
            // uxGrid
            // 
            this.uxGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.uxGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uxGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column9,
            this.Column10,
            this.Column11});
            this.uxGrid.Location = new System.Drawing.Point(12, 142);
            this.uxGrid.Name = "uxGrid";
            this.uxGrid.Size = new System.Drawing.Size(570, 575);
            this.uxGrid.TabIndex = 7;
            this.uxGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.uxGrid_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Player";
            this.Column1.Name = "Column1";
            this.Column1.Width = 61;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Position";
            this.Column3.Name = "Column3";
            this.Column3.Width = 69;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "PTS";
            this.Column4.Name = "Column4";
            this.Column4.Width = 53;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "AST";
            this.Column5.Name = "Column5";
            this.Column5.Width = 53;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "FTA";
            this.Column6.Name = "Column6";
            this.Column6.Width = 52;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "FTM";
            this.Column7.Name = "Column7";
            this.Column7.Width = 54;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "REB";
            this.Column9.Name = "Column9";
            this.Column9.Width = 54;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "BLK";
            this.Column10.Name = "Column10";
            this.Column10.Width = 52;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "STL";
            this.Column11.Name = "Column11";
            this.Column11.Width = 52;
            // 
            // ReportWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 729);
            this.Controls.Add(this.uxGrid);
            this.Controls.Add(this.uxRunReport);
            this.Controls.Add(this.uxPickStat);
            this.Controls.Add(this.uxPlayerCount);
            this.Controls.Add(this.uxTopBot);
            this.Name = "ReportWindow";
            this.Text = "Reports";
            ((System.ComponentModel.ISupportInitialize)(this.uxPlayerCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox uxTopBot;
        private System.Windows.Forms.NumericUpDown uxPlayerCount;
        private System.Windows.Forms.ComboBox uxPickStat;
        private System.Windows.Forms.Button uxRunReport;
        private System.Windows.Forms.DataGridView uxGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
    }
}