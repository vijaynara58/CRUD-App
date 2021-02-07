using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CRUD
{
    public partial class addPlayer : Form
    {
        public addPlayer()
        {
            InitializeComponent();
        }

        /// <summary>
        /// it represents form1.
        /// use it if you want to use any control of Form 1
        /// </summary>
        static Form1 myFrm = Application.OpenForms.OfType<Form1>().FirstOrDefault();
        public bool val = true;
        public string err = "";
        private void btnCreate_Click(object sender, EventArgs e)
        {
            //checking file exist or not
            //if not then it will create it
            cTextFile verifyTxtFile = new cTextFile();
            verifyTxtFile.fileExist();


            validation();


            try
            {
                //logics of validation

                if (val == true)
                {
                    if (MessageBox.Show("Do you Want to Add this Player", "Add Profile", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {


                        //obj reference of cPlayer 
                        cPlayers player = new cPlayers();


                        //reading text and cmbbox value 
                        player.name = txtName.Text;
                        player.age = txtAge.Text;
                        player.number = txtNumber.Text;
                        player.role = cmbRole.SelectedItem.ToString();
                        player.battiing = cmbBatting.SelectedItem.ToString();
                        player.bowling = cmbBowling.SelectedItem.ToString();
                        player.signedYear = cmbSignedYear.SelectedItem.ToString();
                        player.salary = txtSalary.Text;
                        player.country = cmbCountry.SelectedItem.ToString();


                        //STORING INDEX NUMBER INTO ARRAY FOR TEXTFILE.
                        string[] entries = new string[9];

                        entries[0] = player.name;
                        entries[1] = player.age;
                        entries[2] = player.number;
                        entries[3] = cmbRole.SelectedIndex.ToString();  //selecting index of combo box to add in text file.
                        entries[4] = cmbBatting.SelectedIndex.ToString();//selecting index of combo box to add in text file.
                        entries[5] = cmbBowling.SelectedIndex.ToString();//selecting index of combo box to add in text file.
                        entries[6] = cmbSignedYear.SelectedIndex.ToString();//selecting index of combo box to add in text file.
                        entries[7] = player.salary;
                        entries[8] = cmbCountry.SelectedIndex.ToString();//selecting index of combo box to add in text file.

                        //Write into Text file
                        StreamWriter sw = new StreamWriter(cPath.pathPlayers, true);
                        sw.WriteLine(entries[0] + ";" + entries[1] + ";" + entries[2] + ";" + entries[3] + ";" + entries[4] + ";" + entries[5] + ";" + entries[6] + ";" + entries[7] + ";" + entries[8]);
                        sw.Close();
                        MessageBox.Show("New Player has been Added Successfully!!!.", "Player Added",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);

                        //Write into list view
                        myFrm.listView1.Items.Add(new ListViewItem(new string[] { player.name, player.age, player.number, player.role, player.battiing, player.bowling, player.signedYear, player.salary, player.country }));

                        txtAge.Clear();
                        txtName.Clear();
                        txtNumber.Clear();
                        txtSalary.Clear();
                        cmbBatting.Items.Clear();
                        cmbBowling.Items.Clear();
                        cmbCountry.Items.Clear();
                        cmbRole.Items.Clear();
                        cmbSignedYear.Items.Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                err = ex.ToString();
            }


        }


        //Validition for input
        //Regex is used for validation.
        public void validation()
        {

            //Validation for TXTNAME
            if(!Regex.IsMatch(txtName.Text,@"^[a-zA-Z\s]+$"))
            {
                errAdd.SetError(txtName, "Please Enter a valid name");
               
                MessageBox.Show("Please Enter a valid name", "Error",
                             MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, 0, @"Help.txt");
                txtName.Clear();
                txtName.Focus();
                val = false;
            }
            //txtAge
            else if (!Regex.IsMatch(txtAge.Text, @"^[0-9]+$"))
            {
                errAdd.SetError(txtAge, "Please Enter a valid Age");

                MessageBox.Show("Please Enter a valid Age", "Error",
                             MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, 0, @"Help.txt");
                txtAge.Clear();
                txtAge.Focus();
                val = false;
            }

            //txtNumber
            else if (!Regex.IsMatch(txtNumber.Text, @"^[0-9]+$"))
            
            {
                errAdd.SetError(txtNumber, "Please Enter a valid Number");

                MessageBox.Show("Please Enter a valid Number", "Error",
                             MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, 0, @"Help.txt");
                txtNumber.Clear();
                txtNumber.Focus();
                val = false;
            }

            //TXTSALARY
            else if (!Regex.IsMatch(txtSalary.Text, @"^[a-zA-Z0-9.,\s]+$"))
            {
                errAdd.SetError(txtSalary, "Please Enter a valid Salary.");
               MessageBox.Show("Please Enter a valid Salary.", "Error",
                     MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, 0, @"Help.txt");
                txtSalary.Clear();
;                txtSalary.Focus();
                val = false;
            }

            else if (cmbRole.SelectedIndex < 0)
            {
                errAdd.SetError(cmbRole, "Please Select a role.");
                MessageBox.Show("Please select a role.", "Error",
                             MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, 0, @"Help.txt");
                cmbRole.Focus();
                val = false;
            }
            else if (cmbBatting.SelectedIndex < 0)
            {
                errAdd.SetError(cmbBatting, "Please select any value.");
                MessageBox.Show("Please select Batting Style.", "Error",
                             MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, 0, @"Help.txt");
                cmbBatting.Focus();
                val = false;
            }
            else if (cmbBowling.SelectedIndex < 0)
            {
                errAdd.SetError(cmbBowling, "Please select any value.");
                MessageBox.Show("Please select Bowling Style.", "Error",
                             MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, 0, @"Help.txt");
                cmbBowling.Focus();
                val = false;
            }
            else if (cmbCountry.SelectedIndex < 0)
            {
                errAdd.SetError(cmbCountry, "Please select any value.");
                MessageBox.Show("Please select Country.", "Error",
                             MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, 0, @"Help.txt");
                cmbCountry.Focus();
                val = false;
            }
            else if (cmbSignedYear.SelectedIndex < 0)
            {
                errAdd.SetError(cmbSignedYear, "Please select any value.");
                MessageBox.Show("Please select Year.", "Error",
                             MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, 0, @"Help.txt");
                cmbSignedYear.Focus();
                val = false;
            }
            else
            {
                val = true;
            }


        }
    }
}
