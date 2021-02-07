using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using System.Windows.Forms;

namespace CRUD
{

    class cTextFile
    {
        //Creating instances of all the lists
        public List<cPlayers> listPlayers = new List<cPlayers>();
        public List<string> lines = new List<string>();
        public List<string> listRole = new List<string>();
        public List<string> listBatting = new List<string>();
        public List<string> listBowling = new List<string>();
        public List<string> listCountry = new List<string>();
        public List<string> listSignedYear = new List<string>();
        public string err = "";


        //For reference to objects in form 1
        static Form1 myFrm = Application.OpenForms.OfType<Form1>().FirstOrDefault();
        static ModifyPlayer myFrmModify = Application.OpenForms.OfType<ModifyPlayer>().FirstOrDefault();


        //Instanciating filler text
        cFillTextFile fillData = new cFillTextFile();


        //Program Start
        public void start()
        {


            fileExist();                                        //Verifies If File Exists and creates a file
            removeGap();                                        //Removes Gaps
            readFile();                                         //Write into 

            
        }




        //Verifies If File Exists and creates a file
        public void fileExist()
        {
            try
            {



                //Verifying if folder exists
                if (!Directory.Exists(cPath.pathFolder))
                {
                    //create a folder
                    Directory.CreateDirectory(cPath.pathFolder);
                }


                //Verifying if file exists
                if (!File.Exists(cPath.pathPlayers))
                {
                    //Create a file
                    var txtFile = File.Create(cPath.pathPlayers);

                    //Making sure to close a file after opening it.
                    txtFile.Close();

                    //Adding data
                    defaultData(cPath.pathPlayers, fillData.dataPlayers);
                }

                //Verifying if file exists
                if (!File.Exists(cPath.pathRole))
                {
                    //Create a file
                    var txtFile = File.Create(cPath.pathRole);

                    //Closing the file
                    txtFile.Close();

                    //Adding data
                    defaultData(cPath.pathRole, fillData.dataRole);
                }

                //Verifying if file exists
                if (!File.Exists(cPath.pathBatting))
                {
                    //Create a file
                    var txtFile = File.Create(cPath.pathBatting);

                    //Closing the file
                    txtFile.Close();

                    //Adding data
                    defaultData(cPath.pathBatting, fillData.dataBatting);
                }

                //Verifying if file exists
                if (!File.Exists(cPath.pathBowling))
                {
                    //Create a file
                    var txtFile = File.Create(cPath.pathBowling);

                    //Closing the file
                    txtFile.Close();

                    //Adding data
                    defaultData(cPath.pathBowling, fillData.dataBowling);
                }

                //Verifying if file exists
                if (!File.Exists(cPath.pathSignYear))
                {
                    //Create a file
                    var txtFile = File.Create(cPath.pathSignYear);

                    //Closing the file
                    txtFile.Close();

                    //Adding data
                    defaultData(cPath.pathSignYear, fillData.dataSignedYear);
                }

                //Verifying if file exists
                if (!File.Exists(cPath.pathCountry))
                {
                    //Create a file
                    var txtFile = File.Create(cPath.pathCountry);

                    //Closing the file
                    txtFile.Close();

                    //Adding data
                    defaultData(cPath.pathCountry, fillData.dataCountry);
                }

                
                if (new FileInfo(cPath.pathPlayers).Length ==0)
                {
                    defaultData(cPath.pathPlayers, fillData.dataPlayers);

                }

            }
            catch (Exception ex)
            {
                //ERROR
                err = ex.ToString();
            }
        }

        
        /// add default data into text files.
        
        private void defaultData(string path, string[] text)
        {
            try
            {
                File.WriteAllLines(path, text, Encoding.Default);
            }
            catch (Exception ex)
            {
                err = ex.ToString();
            }
        }
        
        // read textfiles data into table.       
        private void readFile()
        {
            try
            {
                // read txt files into list
                lines = File.ReadAllLines(cPath.pathPlayers, Encoding.Default).ToList();
                listRole = File.ReadAllLines(cPath.pathRole, Encoding.Default).ToList();
                listBatting = File.ReadAllLines(cPath.pathBatting, Encoding.Default).ToList();
                listBowling = File.ReadAllLines(cPath.pathBowling, Encoding.Default).ToList();
                listCountry = File.ReadAllLines(cPath.pathCountry, Encoding.Default).ToList();
                listSignedYear = File.ReadAllLines(cPath.pathSignYear, Encoding.Default).ToList();

                //split data from txt files
                //
                foreach (string line in lines)
                {
                    int countSemiColumn = line.Split(';').Length - 1;

                    if (countSemiColumn > 8)
                    {
                        //skip error
                        continue;
                    }
                    else
                    {
                        //store data into string from line after spliting
                        string[] entries = line.Split(';');

                        //instance of cPlayer class
                        cPlayers player = new cPlayers();

                        switch (entries[3].Trim())
                        {
                            case "0":
                                player.role = listRole[0];
                                break;

                            case "1":
                                player.role = listRole[1];
                                break;

                            case "2":
                                player.role = listRole[2];
                                break;

                            case "3":
                                player.role = listRole[3];
                                break;
                        }

                        switch (entries[4].Trim())
                        {
                            case "0":
                                player.battiing = listBatting[0];
                                break;

                            case "1":
                                player.battiing = listBatting[1];
                                break;
                        }

                        switch (entries[5].Trim())
                        {
                            case "0":
                                player.bowling = listBowling[0];
                                break;

                            case "1":
                                player.bowling = listBowling[1];
                                break;

                            case "2":
                                player.bowling = listBowling[2];
                                break;

                            case "3":
                                player.bowling = listBowling[3];
                                break;

                            case "4":
                                player.bowling = listBowling[4];
                                break;

                            case "5":
                                player.bowling = listBowling[5];
                                break;

                            case "6":
                                player.bowling = listBowling[6];
                                break;

                            case "7":
                                player.bowling = listBowling[7];
                                break;

                            case "8":
                                player.bowling = listBowling[8];
                                break;


                        }

                        switch (entries[6].Trim())
                        {
                            case "0":
                                player.signedYear = listSignedYear[0];
                                break;

                            case "1":
                                player.signedYear = listSignedYear[1];
                                break;

                            case "2":
                                player.signedYear = listSignedYear[2];
                                break;

                            case "3":
                                player.signedYear = listSignedYear[3];
                                break;

                            case "4":
                                player.signedYear = listSignedYear[4];
                                break;

                            case "5":
                                player.signedYear = listSignedYear[5];
                                break;

                            case "6":
                                player.signedYear = listSignedYear[6];
                                break;

                            case "7":
                                player.signedYear = listSignedYear[7];
                                break;

                            case "8":
                                player.signedYear = listSignedYear[8];
                                break;

                            case "9":
                                player.signedYear = listSignedYear[9];
                                break;

                            case "10":
                                player.signedYear = listSignedYear[10];
                                break;

                            case "11":
                                player.signedYear = listSignedYear[11];
                                break;

                            case "12":
                                player.signedYear = listSignedYear[12];
                                break;
                        }

                        switch (entries[8].Trim())
                        {
                            case "0":
                                player.country = listCountry[0];
                                break;

                            case "1":
                                player.country = listCountry[1];
                                break;

                            case "2":
                                player.country = listCountry[2];
                                break;

                            case "3":
                                player.country = listCountry[3];
                                break;

                            case "4":
                                player.country = listCountry[4];
                                break;

                            case "5":
                                player.country = listCountry[5];
                                break;

                            case "6":
                                player.country = listCountry[6];
                                break;

                            case "7":
                                player.country = listCountry[7];
                                break;

                            case "8":
                                player.country = listCountry[8];
                                break;

                            case "9":
                                player.country = listCountry[9];
                                break;

                            case "10":
                                player.country = listCountry[10];
                                break;
                        }

                        player.name = entries[0].Trim();
                        player.age = entries[1].Trim();
                        player.number = entries[2].Trim();
                        player.salary = entries[7].Trim();


                        listPlayers.Add(player);


                    }

                    //read data into list view from listPlayer
                    foreach (cPlayers play in listPlayers)
                    {
                        myFrm.listView1.Items.Add(new ListViewItem(new string[] { play.name, play.age, play.number, play.role, play.battiing, play.bowling, play.signedYear, play.salary, play.country }));
                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }



        }
       private void removeGap()
        {

            try
            {
                lines = File.ReadAllLines(cPath.pathPlayers, Encoding.Default).ToList();

                File.WriteAllText(cPath.pathPlayers, string.Empty, Encoding.Default);

                foreach (string line in lines)
                {

                    int countSemiColumn = line.Split(';').Length - 1;

                    if (countSemiColumn > 8)
                    {
                        //skip error
                        continue;

                    }
                    else
                    {
                        if (line != "")
                        {
                            StreamWriter txtFile = new StreamWriter(cPath.pathPlayers, true, Encoding.Default);
                            txtFile.Write(line + Environment.NewLine);
                            txtFile.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                err = ex.ToString();
            }
        }


        



    }
}



