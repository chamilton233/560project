namespace FrontEnd
{
    partial class UpdateWindow
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.uxFirstName = new System.Windows.Forms.TextBox();
            this.uxLastName = new System.Windows.Forms.TextBox();
            this.uxInsertBtn = new System.Windows.Forms.Button();
            this.uxJerseyNum = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.uxPickTeam = new System.Windows.Forms.ComboBox();
            this.uxPickPos = new System.Windows.Forms.ComboBox();
            this.uxUpdateBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(16, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(576, 2);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Insert Player";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "First Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(389, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Jersey Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(208, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Last Name";
            // 
            // uxFirstName
            // 
            this.uxFirstName.Location = new System.Drawing.Point(76, 39);
            this.uxFirstName.Name = "uxFirstName";
            this.uxFirstName.Size = new System.Drawing.Size(120, 20);
            this.uxFirstName.TabIndex = 5;
            // 
            // uxLastName
            // 
            this.uxLastName.Location = new System.Drawing.Point(272, 39);
            this.uxLastName.Name = "uxLastName";
            this.uxLastName.Size = new System.Drawing.Size(100, 20);
            this.uxLastName.TabIndex = 6;
            // 
            // uxInsertBtn
            // 
            this.uxInsertBtn.Location = new System.Drawing.Point(168, 117);
            this.uxInsertBtn.Name = "uxInsertBtn";
            this.uxInsertBtn.Size = new System.Drawing.Size(75, 23);
            this.uxInsertBtn.TabIndex = 7;
            this.uxInsertBtn.Text = "Insert";
            this.uxInsertBtn.UseVisualStyleBackColor = true;
            this.uxInsertBtn.Click += new System.EventHandler(this.uxInsertBtn_Click);
            // 
            // uxJerseyNum
            // 
            this.uxJerseyNum.Location = new System.Drawing.Point(472, 39);
            this.uxJerseyNum.Name = "uxJerseyNum";
            this.uxJerseyNum.Size = new System.Drawing.Size(100, 20);
            this.uxJerseyNum.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(208, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Position";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Team";
            // 
            // uxPickTeam
            // 
            this.uxPickTeam.FormattingEnabled = true;
            this.uxPickTeam.Items.AddRange(new object[] {
            "Bucks",
            "Celtics",
            "Clippers",
            "Heat",
            "Jazz",
            "Lakers",
            "Nuggets",
            "Pacers",
            "Raptors",
            "Thunder"});
            this.uxPickTeam.Location = new System.Drawing.Point(75, 74);
            this.uxPickTeam.Name = "uxPickTeam";
            this.uxPickTeam.Size = new System.Drawing.Size(121, 21);
            this.uxPickTeam.TabIndex = 13;
            // 
            // uxPickPos
            // 
            this.uxPickPos.FormattingEnabled = true;
            this.uxPickPos.Items.AddRange(new object[] {
            "G",
            "F",
            "C"});
            this.uxPickPos.Location = new System.Drawing.Point(272, 74);
            this.uxPickPos.Name = "uxPickPos";
            this.uxPickPos.Size = new System.Drawing.Size(121, 21);
            this.uxPickPos.TabIndex = 14;
            // 
            // uxUpdateBtn
            // 
            this.uxUpdateBtn.Location = new System.Drawing.Point(306, 117);
            this.uxUpdateBtn.Name = "uxUpdateBtn";
            this.uxUpdateBtn.Size = new System.Drawing.Size(75, 23);
            this.uxUpdateBtn.TabIndex = 15;
            this.uxUpdateBtn.Text = "Update";
            this.uxUpdateBtn.UseVisualStyleBackColor = true;
            this.uxUpdateBtn.Click += new System.EventHandler(this.uxUpdateBtn_Click);
            // 
            // UpdateWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 179);
            this.Controls.Add(this.uxUpdateBtn);
            this.Controls.Add(this.uxPickPos);
            this.Controls.Add(this.uxPickTeam);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.uxJerseyNum);
            this.Controls.Add(this.uxInsertBtn);
            this.Controls.Add(this.uxLastName);
            this.Controls.Add(this.uxFirstName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UpdateWindow";
            this.Text = "Insert or Update Record";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox uxFirstName;
        private System.Windows.Forms.TextBox uxLastName;
        private System.Windows.Forms.Button uxInsertBtn;
        private System.Windows.Forms.TextBox uxJerseyNum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox uxPickTeam;
        private System.Windows.Forms.ComboBox uxPickPos;
        private System.Windows.Forms.Button uxUpdateBtn;
    }
}