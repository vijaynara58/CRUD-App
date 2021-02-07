namespace CRUD
{
    partial class Form1
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.playerName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.playerAge = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.playerNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.playerRole = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.playerBattingStyle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.playerBowlingStyle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.playerSignedYear = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PlayerSalary = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PlayerCountry = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnHelp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(340, 462);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add New Player";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(484, 462);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(75, 23);
            this.btnModify.TabIndex = 5;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(628, 462);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 6;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.playerName,
            this.playerAge,
            this.playerNumber,
            this.playerRole,
            this.playerBattingStyle,
            this.playerBowlingStyle,
            this.playerSignedYear,
            this.PlayerSalary,
            this.PlayerCountry});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(41, 106);
            this.listView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1034, 244);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            
            // 
            // playerName
            // 
            this.playerName.Text = "Name";
            this.playerName.Width = 294;
            // 
            // playerAge
            // 
            this.playerAge.Text = "Age";
            this.playerAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.playerAge.Width = 70;
            // 
            // playerNumber
            // 
            this.playerNumber.Text = "Number";
            this.playerNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.playerNumber.Width = 97;
            // 
            // playerRole
            // 
            this.playerRole.Text = "Role";
            this.playerRole.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.playerRole.Width = 177;
            // 
            // playerBattingStyle
            // 
            this.playerBattingStyle.Text = "Batting Style";
            this.playerBattingStyle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.playerBattingStyle.Width = 154;
            // 
            // playerBowlingStyle
            // 
            this.playerBowlingStyle.Text = "Bowling Style";
            this.playerBowlingStyle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.playerBowlingStyle.Width = 226;
            // 
            // playerSignedYear
            // 
            this.playerSignedYear.Text = "Signed Year";
            this.playerSignedYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.playerSignedYear.Width = 120;
            // 
            // PlayerSalary
            // 
            this.PlayerSalary.Text = "Salary";
            this.PlayerSalary.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PlayerSalary.Width = 132;
            // 
            // PlayerCountry
            // 
            this.PlayerCountry.Text = "Country";
            this.PlayerCountry.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PlayerCountry.Width = 120;
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(1063, 10);
            this.btnHelp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(57, 24);
            this.btnHelp.TabIndex = 9;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 490);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnAdd);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.ColumnHeader playerName;
        private System.Windows.Forms.ColumnHeader playerAge;
        private System.Windows.Forms.ColumnHeader playerNumber;
        private System.Windows.Forms.ColumnHeader playerRole;
        private System.Windows.Forms.ColumnHeader playerBattingStyle;
        private System.Windows.Forms.ColumnHeader playerBowlingStyle;
        private System.Windows.Forms.ColumnHeader playerSignedYear;
        private System.Windows.Forms.ColumnHeader PlayerSalary;
        private System.Windows.Forms.ColumnHeader PlayerCountry;
        public System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnHelp;
    }
}

