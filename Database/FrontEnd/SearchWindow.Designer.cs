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
            this.SearchBy = new System.Windows.Forms.Label();
            this.uxFirstName = new System.Windows.Forms.TextBox();
            this.uxLastName = new System.Windows.Forms.TextBox();
            this.uxJerseyNum = new System.Windows.Forms.TextBox();
            this.uxTeam = new System.Windows.Forms.TextBox();
            this.uxPosition = new System.Windows.Forms.TextBox();
            this.uxSearchExecute = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SearchBy
            // 
            this.SearchBy.AutoSize = true;
            this.SearchBy.Location = new System.Drawing.Point(15, 14);
            this.SearchBy.Name = "SearchBy";
            this.SearchBy.Size = new System.Drawing.Size(64, 13);
            this.SearchBy.TabIndex = 0;
            this.SearchBy.Text = "Search by...";
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
            // uxJerseyNum
            // 
            this.uxJerseyNum.Location = new System.Drawing.Point(71, 93);
            this.uxJerseyNum.Name = "uxJerseyNum";
            this.uxJerseyNum.Size = new System.Drawing.Size(100, 20);
            this.uxJerseyNum.TabIndex = 3;
            // 
            // uxTeam
            // 
            this.uxTeam.Location = new System.Drawing.Point(71, 119);
            this.uxTeam.Name = "uxTeam";
            this.uxTeam.Size = new System.Drawing.Size(100, 20);
            this.uxTeam.TabIndex = 4;
            // 
            // uxPosition
            // 
            this.uxPosition.Location = new System.Drawing.Point(71, 145);
            this.uxPosition.Name = "uxPosition";
            this.uxPosition.Size = new System.Drawing.Size(100, 20);
            this.uxPosition.TabIndex = 5;
            // 
            // uxSearchExecute
            // 
            this.uxSearchExecute.Location = new System.Drawing.Point(51, 192);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Team";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Position";
            // 
            // SearchWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 332);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uxSearchExecute);
            this.Controls.Add(this.uxPosition);
            this.Controls.Add(this.uxTeam);
            this.Controls.Add(this.uxJerseyNum);
            this.Controls.Add(this.uxLastName);
            this.Controls.Add(this.uxFirstName);
            this.Controls.Add(this.SearchBy);
            this.Name = "SearchWindow";
            this.Text = "Player Search";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SearchBy;
        private System.Windows.Forms.TextBox uxFirstName;
        private System.Windows.Forms.TextBox uxLastName;
        private System.Windows.Forms.TextBox uxJerseyNum;
        private System.Windows.Forms.TextBox uxTeam;
        private System.Windows.Forms.TextBox uxPosition;
        private System.Windows.Forms.Button uxSearchExecute;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}