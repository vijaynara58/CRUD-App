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
    public partial class ModifyPlayer : Form
    {
        public ModifyPlayer()
        {
            InitializeComponent();
        }

        //GLOBAL VARIABLES
        public string err = "";
        public bool val = true;
        cTextFile verifyFile = new cTextFile();

        /// <summary>
        /// it represents form1.
        /// use it if you want to use any control of Form 1
        /// </summary>
        static Form1 myFrm = Application.OpenForms.OfType<Form1>().FirstOrDefault();
        
        private void btnCreate_Click(object sender, EventArgs e)
        {
            
            

            //validation for cmbname
            if(cmbName.SelectedIndex<0)
            {
                MessageBox.Show("Please Select any value to chang player's Details.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, 0, @"Help.txt");
                val = false;
            }
            validation();
            

            try
            {
                if (val == true)
                {
                    if (MessageBox.Show("Are you sure? You want to change Player Details? ", "Edit Profile", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        //selecting an item in cmbbox and get its index number
                        //index of cmbName and listview are same
                        var item = myFrm.listView1.FindItemWithText((string)cmbName.SelectedItem);
                        //itemIndex will very useful
                        //because the index of combo box and listview are same as well as index of textfile will alse be same.
                        var itemIndex = int.Parse(myFrm.listView1.Items.IndexOf(item).ToString());


                        //updating listview data
                        myFrm.listView1.Items[itemIndex].SubItems[0].Text = txtName.Text;
                        myFrm.listView1.Items[itemIndex].SubItems[1].Text = txtAge.Text;
                        myFrm.listView1.Items[itemIndex].SubItems[2].Text = txtNumber.Text;
                        myFrm.listView1.Items[itemIndex].SubItems[3].Text = cmbRole.SelectedItem.ToString();
                        myFrm.listView1.Items[itemIndex].SubItems[4].Text = cmbBatting.SelectedItem.ToString();
                        myFrm.listView1.Items[itemIndex].SubItems[5].Text = cmbBowling.SelectedItem.ToString();
                        myFrm.listView1.Items[itemIndex].SubItems[6].Text = cmbSignedYear.SelectedItem.ToString();
                        myFrm.listView1.Items[itemIndex].SubItems[7].Text = txtSalary.Text;
                        myFrm.listView1.Items[itemIndex].SubItems[8].Text = cmbCountry.SelectedItem.ToString();


                        //Updating data into text file
                        string[] lines = File.ReadAllLines(cPath.pathPlayers, Encoding.Default);
                        string newText = txtName.Text + ";" + txtAge.Text + ";" + txtNumber.Text + ";" + cmbRole.SelectedIndex.ToString() + ";" + cmbBatting.SelectedIndex.ToString() + ";" + cmbBowling.SelectedIndex.ToString() + ";" + cmbSignedYear.SelectedIndex.ToString() + ";" + txtSalary.Text + ";" + cmbCountry.SelectedIndex.ToString();

                        lines[itemIndex] = newText;
                        File.WriteAllLines(cPath.pathPlayers, lines);
                        MessageBox.Show("Player Data has been modified successfully!!", "Profile Updated",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);

                        //CLEARING INPUTS
                        cmbName.Items.Clear();
                        txtSalary.Clear();
                        txtNumber.Clear();
                        txtName.Clear();
                        txtAge.Clear();
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
        


        private void ModifyPlayer_Load(object sender, EventArgs e)
        {
            
            verifyFile.fileExist();

            

            try
            {
                //load player name in cmbName
                foreach (ListViewItem itm in myFrm.listView1.Items)
                {
                    cmbName.Items.Add(itm.SubItems[0].Text);

                }

            }
            catch (Exception ex)
            {
                err = ex.ToString();
            }


           
        }

        private void cmbName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {


                //selecting an item in cmbbox and get its index number
                //index of cmbName and listview are same
                var item = myFrm.listView1.FindItemWithText((string)cmbName.SelectedItem);
                var itemIndex = int.Parse(myFrm.listView1.Items.IndexOf(item).ToString());

                

                //updating listview data
                txtName.Text = myFrm.listView1.Items[itemIndex].SubItems[0].Text;
                txtAge.Text = myFrm.listView1.Items[itemIndex].SubItems[1].Text;
                txtNumber.Text = myFrm.listView1.Items[itemIndex].SubItems[2].Text;
                cmbRole.SelectedItem = myFrm.listView1.Items[itemIndex].SubItems[3].Text;
                cmbBatting.SelectedItem=myFrm.listView1.Items[itemIndex].SubItems[4].Text;
                cmbBowling.SelectedItem=myFrm.listView1.Items[itemIndex].SubItems[5].Text;
                cmbSignedYear.SelectedItem=myFrm.listView1.Items[itemIndex].SubItems[6].Text;
                txtSalary.Text= myFrm.listView1.Items[itemIndex].SubItems[7].Text;
                cmbCountry.SelectedItem=myFrm.listView1.Items[itemIndex].SubItems[8].Text;




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
            if (!Regex.IsMatch(txtName.Text, @"^[a-zA-Z\s]+$"))
            {
                errModify.SetError(txtName, "Please Enter a valid name");

                MessageBox.Show("Please Enter a valid name", "Error",
                             MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, 0, @"Help.txt");
                txtName.Clear();
                txtName.Focus();
                val = false;
            }

            //txtAge
            else if (!Regex.IsMatch(txtAge.Text, @"^[0-9]+$"))
            
            {
                errModify.SetError(txtAge, "Please Enter a valid Age");

                MessageBox.Show("Please Enter a valid Age", "Error",
                             MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, 0, @"Help.txt");
                txtAge.Clear();
                txtAge.Focus();
                val = false;
            }

            //txtNumber
            else if (!Regex.IsMatch(txtNumber.Text, @"^[0-9]+$"))
            {
                errModify.SetError(txtNumber, "Please Enter a valid Number");

                MessageBox.Show("Please Enter a valid Number", "Error",
                             MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, 0, @"Help.txt");
                txtNumber.Clear();
                txtNumber.Focus();
                val = false;
            }

            //TXTSALARY
            else if (!Regex.IsMatch(txtSalary.Text, @"^[a-zA-Z0-9,.\s]+$"))
            {
                errModify.SetError(txtSalary, "Please Enter a valid Salary.");
                MessageBox.Show("Please Enter a valid Salary.", "Error",
                      MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, 0, @"Help.txt");
                txtSalary.Clear();
                ; txtSalary.Focus();
                val = false;
            }
            else if (cmbRole.SelectedIndex < 0)
            {
                errModify.SetError(cmbRole, "Please Select a role.");
                MessageBox.Show("Please select a role.", "Error",
                             MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, 0, @"Help.txt");
                cmbRole.Focus();
                val = false;
            }
            else if (cmbBatting.SelectedIndex < 0)
            {
                errModify.SetError(cmbBatting, "Please select any value.");
                MessageBox.Show("Please select Batting Style.", "Error",
                             MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, 0, @"Help.txt");
                cmbBatting.Focus();
                val = false;
            }
            else if (cmbBowling.SelectedIndex < 0)
            {
                errModify.SetError(cmbBowling, "Please select any value.");
                MessageBox.Show("Please select Bowling Style.", "Error",
                             MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, 0, @"Help.txt");
                cmbBowling.Focus();
                val = false;
            }
            else if (cmbCountry.SelectedIndex < 0)
            {
                errModify.SetError(cmbCountry, "Please select any value.");
                MessageBox.Show("Please select Country.", "Error",
                             MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, 0, @"Help.txt");
                cmbCountry.Focus();
                val = false;
            }
            else if (cmbSignedYear.SelectedIndex < 0)
            {
                errModify.SetError(cmbSignedYear, "Please select any value.");
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
