namespace FrontEnd
{
    partial class SearchWindow
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
            this.uxFirstName = new System.Windows.Forms.TextBox();
            this.uxLastName = new System.Windows.Forms.TextBox();
            this.uxSearchExecute = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.uxGrid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uxShowAllBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.uxGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // uxFirstName
            // 
            this.uxFirstName.Location = new System.Drawing.Point(71, 41);
            this.uxFirstName.Name = "uxFirstName";
            this.uxFirstName.Size = new System.Drawing.Size(100, 20);
            this.uxFirstName.TabIndex = 1;
            // 
            // uxLastName
            // 
            this.uxLastName.Location = new System.Drawing.Point(71, 67);
            this.uxLastName.Name = "uxLastName";
            this.uxLastName.Size = new System.Drawing.Size(100, 20);
            this.uxLastName.TabIndex = 2;
            // 
            // uxSearchExecute
            // 
            this.uxSearchExecute.Location = new System.Drawing.Point(192, 41);
            this.uxSearchExecute.Name = "uxSearchExecute";
            this.uxSearchExecute.Size = new System.Drawing.Size(75, 44);
            this.uxSearchExecute.TabIndex = 6;
            this.uxSearchExecute.Text = "Search";
            this.uxSearchExecute.UseVisualStyleBackColor = true;
            this.uxSearchExecute.Click += new System.EventHandler(this.uxSearchExecute_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Last Name";
            // 
            // uxGrid
            // 
            this.uxGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uxGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column3,
            this.Column4,
            this.Column5});
            this.uxGrid.Location = new System.Drawing.Point(51, 242);
            this.uxGrid.Name = "uxGrid";
            this.uxGrid.Size = new System.Drawing.Size(546, 150);
            this.uxGrid.TabIndex = 9;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Name";
            this.Column1.Name = "Column1";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Jersey Number";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Position";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Team";
            this.Column5.Name = "Column5";
            // 
            // uxShowAllBtn
            // 
            this.uxShowAllBtn.Location = new System.Drawing.Point(295, 41);
            this.uxShowAllBtn.Name = "uxShowAllBtn";
            this.uxShowAllBtn.Size = new System.Drawing.Size(75, 46);
            this.uxShowAllBtn.TabIndex = 10;
            this.uxShowAllBtn.Text = "Show All";
            this.uxShowAllBtn.UseVisualStyleBackColor = true;
            this.uxShowAllBtn.Click += new System.EventHandler(this.uxShowAllBtn_Click);
            // 
            // SearchWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 413);
            this.Controls.Add(this.uxShowAllBtn);
            this.Controls.Add(this.uxGrid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uxSearchExecute);
            this.Controls.Add(this.uxLastName);
            this.Controls.Add(this.uxFirstName);
            this.Name = "SearchWindow";
            this.Text = "Player Search";
            ((System.ComponentModel.ISupportInitialize)(this.uxGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox uxFirstName;
        private System.Windows.Forms.TextBox uxLastName;
        private System.Windows.Forms.Button uxSearchExecute;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView uxGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button uxShowAllBtn;
    }
}