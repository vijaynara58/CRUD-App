using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD
{
    public partial class deletePlayer : Form
    {
        public deletePlayer()
        {
            InitializeComponent();
        }

        //GLOBAL VARIABLES
        public string err = "";
        cTextFile verifyFile = new cTextFile();

        /// <summary>
        /// it represents form1.
        /// use it if you want to use any control of Form 1
        /// </summary>
        static Form1 myFrm = Application.OpenForms.OfType<Form1>().FirstOrDefault();

        private void deletePlayer_Load(object sender, EventArgs e)
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if(cmbName.SelectedIndex<0)
                {
                    MessageBox.Show("Please Select Player to delete it.", "Error",
                             MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, 0, @"Help.txt");
                }
                else if (MessageBox.Show("Are You Sure? Do you Want to Delete Player Profile permanently??", "Delete Profile", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //selecting an item in cmbbox and get its index number
                    //index of cmbName and listview are same
                    var item = myFrm.listView1.FindItemWithText((string)cmbName.SelectedItem);
                    //itemIndex will very useful
                    //because the index of combo box and listview are same as well as index of textfile will alse be same.
                    var itemIndex = int.Parse(myFrm.listView1.Items.IndexOf(item).ToString());
                    //list of file data
                    List<string> lines = File.ReadAllLines(cPath.pathPlayers, Encoding.Default).ToList();

                    cmbName.Items.Remove(cmbName.SelectedItem);
                    myFrm.listView1.Items[itemIndex].Remove();



                    //removing data from the text file
                    lines.RemoveAt(itemIndex);
                    File.WriteAllLines(cPath.pathPlayers, lines.ToArray());

                    MessageBox.Show("player's profile has been deleted successfully", "Profile Deleted",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);

                }
            }
            catch (Exception ex)
            {
                err = ex.ToString();
            }
        }

       
    }
}
