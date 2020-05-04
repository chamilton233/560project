namespace FrontEnd
{
    partial class MainWindow
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
            this.uxSearch = new System.Windows.Forms.Button();
            this.uxReports = new System.Windows.Forms.Button();
            this.uxUpdateBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxSearch
            // 
            this.uxSearch.Location = new System.Drawing.Point(81, 12);
            this.uxSearch.Name = "uxSearch";
            this.uxSearch.Size = new System.Drawing.Size(279, 155);
            this.uxSearch.TabIndex = 0;
            this.uxSearch.Text = "Search";
            this.uxSearch.UseVisualStyleBackColor = true;
            this.uxSearch.Click += new System.EventHandler(this.uxSearch_Click);
            // 
            // uxReports
            // 
            this.uxReports.Location = new System.Drawing.Point(81, 173);
            this.uxReports.Name = "uxReports";
            this.uxReports.Size = new System.Drawing.Size(279, 155);
            this.uxReports.TabIndex = 1;
            this.uxReports.Text = "Reports";
            this.uxReports.UseVisualStyleBackColor = true;
            this.uxReports.Click += new System.EventHandler(this.uxReports_Click);
            // 
            // uxUpdateBtn
            // 
            this.uxUpdateBtn.Location = new System.Drawing.Point(81, 334);
            this.uxUpdateBtn.Name = "uxUpdateBtn";
            this.uxUpdateBtn.Size = new System.Drawing.Size(279, 155);
            this.uxUpdateBtn.TabIndex = 2;
            this.uxUpdateBtn.Text = "Update";
            this.uxUpdateBtn.UseVisualStyleBackColor = true;
            this.uxUpdateBtn.Click += new System.EventHandler(this.uxUpdateBtn_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 518);
            this.Controls.Add(this.uxUpdateBtn);
            this.Controls.Add(this.uxReports);
            this.Controls.Add(this.uxSearch);
            this.Name = "MainWindow";
            this.Text = "Basketball Database Manager";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button uxSearch;
        private System.Windows.Forms.Button uxReports;
        private System.Windows.Forms.Button uxUpdateBtn;
    }
}

