using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CRUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            //READ


            cTextFile verifyFileData = new cTextFile();
            verifyFileData.start();

        }


        private void btnAdd_Click(object sender, EventArgs e)
        {

            //create
            addPlayer createPlayerProfile = new addPlayer();
            createPlayerProfile.Show();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            //update
            ModifyPlayer modifyPlayerProfile = new ModifyPlayer();
            modifyPlayerProfile.Show();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            //delete
            deletePlayer deletePlayerProfile = new deletePlayer();
            deletePlayerProfile.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do yo want to exit from the Application??", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.ExitThread();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            string file = @"Help.txt";
            Process.Start(file);


        }

      
    }
}
