namespace CRUD
{
    partial class ModifyPlayer
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
            this.components = new System.ComponentModel.Container();
            this.btnModify = new System.Windows.Forms.Button();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.cmbCountry = new System.Windows.Forms.ComboBox();
            this.cmbBowling = new System.Windows.Forms.ComboBox();
            this.cmbBatting = new System.Windows.Forms.ComboBox();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbSignedYear = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbName = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.errModify = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errModify)).BeginInit();
            this.SuspendLayout();
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(310, 267);
            this.btnModify.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(176, 39);
            this.btnModify.TabIndex = 11;
            this.btnModify.Text = "Modify Player";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(430, 180);
            this.txtSalary.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(92, 20);
            this.txtSalary.TabIndex = 9;
            // 
            // cmbCountry
            // 
            this.cmbCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCountry.FormattingEnabled = true;
            this.cmbCountry.Items.AddRange(new object[] {
            "Afghanistan",
            "Australia",
            "Bangladesh",
            "England",
            "Netherlands",
            "New ZeaLand",
            "South Africa",
            "Sri Lanka",
            "West Indies",
            "Zimbabwe",
            "India"});
            this.cmbCountry.Location = new System.Drawing.Point(430, 206);
            this.cmbCountry.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbCountry.Name = "cmbCountry";
            this.cmbCountry.Size = new System.Drawing.Size(92, 21);
            this.cmbCountry.TabIndex = 10;
            // 
            // cmbBowling
            // 
            this.cmbBowling.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBowling.FormattingEnabled = true;
            this.cmbBowling.Items.AddRange(new object[] {
            "Right-arm off break",
            "Right-arm medium",
            "Right-arm fast-medium",
            "Slow left-arm orthodox",
            "Right-arm leg break",
            "Not Bowler",
            "Left-arm fast-medium",
            "Right-arm fast",
            "Left-arm fast"});
            this.cmbBowling.Location = new System.Drawing.Point(430, 113);
            this.cmbBowling.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbBowling.Name = "cmbBowling";
            this.cmbBowling.Size = new System.Drawing.Size(121, 21);
            this.cmbBowling.TabIndex = 7;
            // 
            // cmbBatting
            // 
            this.cmbBatting.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBatting.FormattingEnabled = true;
            this.cmbBatting.Items.AddRange(new object[] {
            "Right-Handed",
            "Left-Handed"});
            this.cmbBatting.Location = new System.Drawing.Point(128, 232);
            this.cmbBatting.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbBatting.Name = "cmbBatting";
            this.cmbBatting.Size = new System.Drawing.Size(92, 21);
            this.cmbBatting.TabIndex = 6;
            // 
            // cmbRole
            // 
            this.cmbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.Items.AddRange(new object[] {
            "Batsman",
            "Bowler",
            "Wicket keeper",
            "All Rounder"});
            this.cmbRole.Location = new System.Drawing.Point(128, 184);
            this.cmbRole.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(92, 21);
            this.cmbRole.TabIndex = 5;
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(128, 142);
            this.txtNumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(76, 20);
            this.txtNumber.TabIndex = 4;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(128, 100);
            this.txtAge.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(76, 20);
            this.txtAge.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(370, 212);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "Country";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(370, 184);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "Salary";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(348, 150);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Signed Year";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(370, 115);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Bowling";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 234);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Batting";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 184);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Role";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 142);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Age";
            // 
            // cmbSignedYear
            // 
            this.cmbSignedYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSignedYear.FormattingEnabled = true;
            this.cmbSignedYear.Items.AddRange(new object[] {
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020"});
            this.cmbSignedYear.Location = new System.Drawing.Point(430, 150);
            this.cmbSignedYear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbSignedYear.Name = "cmbSignedYear";
            this.cmbSignedYear.Size = new System.Drawing.Size(92, 21);
            this.cmbSignedYear.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Name";
            // 
            // cmbName
            // 
            this.cmbName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbName.FormattingEnabled = true;
            this.cmbName.Location = new System.Drawing.Point(214, 31);
            this.cmbName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbName.Name = "cmbName";
            this.cmbName.Size = new System.Drawing.Size(166, 21);
            this.cmbName.TabIndex = 1;
            this.cmbName.SelectedIndexChanged += new System.EventHandler(this.cmbName_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(203, 7);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(204, 13);
            this.label10.TabIndex = 40;
            this.label10.Text = "Select Player Name to Update his Details.";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(128, 59);
            this.txtName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(76, 20);
            this.txtName.TabIndex = 2;
            // 
            // errModify
            // 
            this.errModify.ContainerControl = this;
            // 
            // ModifyPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 387);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cmbName);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.cmbCountry);
            this.Controls.Add(this.cmbBowling);
            this.Controls.Add(this.cmbBatting);
            this.Controls.Add(this.cmbRole);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbSignedYear);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ModifyPlayer";
            this.Text = "ModifyPlayer";
            this.Load += new System.EventHandler(this.ModifyPlayer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errModify)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnModify;
        public System.Windows.Forms.TextBox txtSalary;
        public System.Windows.Forms.ComboBox cmbCountry;
        public System.Windows.Forms.ComboBox cmbBowling;
        public System.Windows.Forms.ComboBox cmbBatting;
        public System.Windows.Forms.ComboBox cmbRole;
        public System.Windows.Forms.TextBox txtNumber;
        public System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox cmbSignedYear;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cmbName;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ErrorProvider errModify;
    }
}