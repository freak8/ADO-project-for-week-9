using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mandatory_assignment_ADO_PC08_Filip_Marcus_Michael_Sam
{


    public partial class Form1 : Form
    {

        //array with the default names
        string[] defaultArrayNames = new string[]
        {
        "Eden",
        "Filip",
        "Marcus",
        "Michael",
        "Sam"
        };

        double[] balanceArray = new double[]
        {
            0.00,
            0.00,
            0.00,
            0.00,
            0.00
        };

        string[] allArrayNames = new string[5];

        //list with the default names
        List<string> defaultListNames = new List<string>()
        {
        "Eden",
        "Filip",
        "Marcus",
        "Michael",
        "Sam"
        };

        //list of the balances
        List<double> balanceList = new List<double>()
        {
            0.00, //this one is on index 0 so would correspond to the default name at index 0, which in this case is Eden
            0.00,
            0.00,
            0.00,
            0.00
        };

        List<string> allListNames = new List<string>();

        int indexBalance;
        int counter = 0;

        public Form1()
        {
            InitializeComponent();
            lbNameListArray.Items.Clear();
            lbNameListList.Items.Clear();
            lbRoundInfoArray.Items.Clear();
            lbRoundInfoList.Items.Clear();
            lbCurrentStandingOfDebtArray.Items.Clear();
            lbCurrentStandingOfDebtList.Items.Clear();
        }



        //HERE STARTS THE CODE FOR THE ARRAY STUFF



        private void btnAddDefaultsArray_Click(object sender, EventArgs e)
        { 
            //adds the devault names to the listboxes once 
            for (int i = 0; i < defaultArrayNames.Length; i++)
            {
                lbNameListArray.Items.Add(defaultArrayNames[i]);

                lbCurrentStandingOfDebtArray.Items.Add(defaultArrayNames[i] + "          € " + balanceArray[i]);

                allArrayNames[i] = defaultArrayNames[i];
            }

            btnAddDefaultsArray.Enabled = false;

        }

        private void btnRemovePersonArray_Click(object sender, EventArgs e) //Button for removing selected players, can't change the name to the proper name because vs suck
        {
            //removes the selected name in lbNameList
            if (this.lbNameListArray.SelectedItem != null && balanceArray[indexBalance] == 0.00) 
            { 
                this.lbNameListArray.Items.Remove(this.lbNameListArray.SelectedItem); 
                //here we need to replace the name in the array with NULL
            }
            else
            {
                if (this.lbNameListArray.SelectedItem != null && balanceArray[indexBalance] != 0.00)
                {
                    MessageBox.Show("Balance is not €0.00");
                }
                else
                {
                    MessageBox.Show("No user selected");
                }
            }
        }

        private void btnAddNameArray_Click(object sender, EventArgs e)
        {
            //name from textbox is added
            lbNameListArray.Items.Add(tbTeamMemberNameArray.Text);

            //new name and balance are added to each list 
            //here we need to make a copy of the allArrayNames and add a spot


            lbCurrentStandingOfDebtArray.Items.Add(allArrayNames[allArrayNames.Length - 1] + "          € "+ balanceArray[balanceArray.Length - 1]);

        }

        private void btnRemoveNameArray_Click(object sender, EventArgs e)
        {
            //removes the name which is in the textbox from the name list
            string name = tbTeamMemberNameArray.Text.Trim();

            if (lbNameListArray.Items.Contains(name) && balanceArray[indexBalance] == 0.00) //checks if the listbox contains the name in the textbox and if the balance is 0
            {
                lbNameListArray.Items.Remove(tbTeamMemberNameArray.Text);
            }
            else
            {
                if(lbNameListArray.Items.Contains(name) && balanceArray[indexBalance] != 0.00) //if the balance is not 0 show message
                {
                    MessageBox.Show("Balance is not €0.00");
                }
                else // if the name is not in the listbox do this
                {
                    MessageBox.Show("Person does not exist in this list");
                }
            }
        }

        private void btnMoveToRoundArray_Click(object sender, EventArgs e)
        {
            //if there is an item selected it will be moved from the name listbox to the round info listbox
            if (this.lbNameListArray.SelectedItem != null)
            {
                lbRoundInfoArray.Items.Add(this.lbNameListArray.SelectedItem);

                this.lbNameListArray.Items.Remove(this.lbNameListArray.SelectedItem);
            }
        }

        private void btnMoveToListboxArray_Click(object sender, EventArgs e)
        {

            //code to move names back from the round info listbox to the name listbox 
            if (this.lbRoundInfoArray.SelectedItem != null)
            {
                lbNameListArray.Items.Add(this.lbRoundInfoArray.SelectedItem);

                this.lbRoundInfoArray.Items.Remove(this.lbRoundInfoArray.SelectedItem);
            }
        }

        private void btnBuyARoundArray_Click(object sender, EventArgs e)
        {
                int indexDrinkers;
                int indexBuyer;

            //check if there is a name in the listbox
            if (lbRoundInfoArray.Items.Count == 0)
            {
                MessageBox.Show("You can't buy a round for nobody!");
            }
            else
            {
                if (lbRoundInfoArray.Items.Count == 1 && lbRoundInfoArray.Items.Contains(tbRoundBuyerArray.Text.Trim())) //if there is check if it is not the same name as in the textbox.
                {
                    MessageBox.Show("You can't buy a drink for yourself!");
                }
                else
                {
                    if (!lbNameListArray.Items.Contains(tbRoundBuyerArray.Text.Trim())) //if it is not the same name as the buyer check is the name is valid
                    {
                        MessageBox.Show("No valid name was given");
                    }
                    else //if everything has passed update the balances of the drinkers and buyers
                    {
                    indexDrinkers = allArrayNames.IndexOf(lbRoundInfoArray.Items.Count.ToString()); //this should be used to get the index of the drinker's names
                    indexBuyer = allArrayNames.IndexOf(tbRoundBuyerArray.Text); //this should be used to get the index of the Buyer's name


                        //these lines are to update the balance values, don't work yet bc of the above two lines 
                        //balanceArray[indexDrinkers] = balanceArray[indexDrinkers] - (Convert.ToInt32(tbRoundPrice.Text)/lbRoundInfo.Items.Count);
                        //balanceArray[indexBuyer] = balanceArray[indexBuyer] + (Convert.ToInt32(tbRoundPrice.Text));
                    }
                }
            }
        }




        //HERE STARTS THE CODE FOR THE LIST STUFF





        private void btnAddDefaultsList_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < defaultListNames.Count; i++)
            {
                lbNameListList.Items.Add(defaultListNames[i]);

                lbCurrentStandingOfDebtList.Items.Add(defaultArrayNames[i] + "          € " + balanceList[i]);

                allListNames.Add(defaultListNames[i]);
            }
        }

        private void btnRemovePersonList_Click(object sender, EventArgs e)
        {
            //removes the selected name in lbNameList
            if (this.lbNameListList.SelectedItem != null && balanceList[indexBalance] == 0.00)
            {
                this.lbNameListList.Items.Remove(this.lbNameListList.SelectedItem);
            }
            else
            {
                if (this.lbNameListList.SelectedItem != null && balanceList[indexBalance] != 0.00)
                {
                    MessageBox.Show("Balance is not €0.00");
                }
                else
                {
                    MessageBox.Show("No user selected");
                }
            }
        }

        private void btnAddNameList_Click(object sender, EventArgs e)
        {
            //name from textbox is added
            lbNameListList.Items.Add(tbTeamMemberNameList.Text);

            //new name and balance are added to each list 
            //here we need to make a copy of the allArrayNames and add a spot


            lbCurrentStandingOfDebtList.Items.Add(allListNames[allListNames.Count - 1] + "          € " + balanceList[balanceList.Count - 1]);

        }

        private void btnRemoveNameList_Click(object sender, EventArgs e)
        {
            //removes the name which is in the textbox from the name list
            string name = tbTeamMemberNameList.Text.Trim();

            if (lbNameListList.Items.Contains(name) && balanceList[indexBalance] == 0.00) //checks if the listbox contains the name in the textbox and if the balance is 0
            {
                lbNameListList.Items.Remove(tbTeamMemberNameList.Text);
            }
            else
            {
                if (lbNameListList.Items.Contains(name) && balanceList[indexBalance] != 0.00) //if the balance is not 0 show message
                {
                    MessageBox.Show("Balance is not €0.00");
                }
                else // if the name is not in the listbox do this
                {
                    MessageBox.Show("Person does not exist in this list");
                }
            }
        }

        private void btnMoveToRoundList_Click(object sender, EventArgs e)
        {
            if (this.lbNameListList.SelectedItem != null)
            {
                lbRoundInfoList.Items.Add(this.lbNameListList.SelectedItem);

                this.lbNameListList.Items.Remove(this.lbNameListList.SelectedItem);
            }
        }

        private void btnMoveToListboxList_Click(object sender, EventArgs e)
        {
            if (this.lbRoundInfoList.SelectedItem != null)
            {
                lbNameListList.Items.Add(this.lbRoundInfoList.SelectedItem);

                this.lbRoundInfoList.Items.Remove(this.lbRoundInfoList.SelectedItem);
            }
        }

        private void btnBuyARoundList_Click(object sender, EventArgs e)
        {
            int indexDrinkers;
            int indexBuyer;

            //check if there is a name in the listbox
            if (lbRoundInfoList.Items.Count == 0)
            {
                MessageBox.Show("You can't buy a round for nobody!");
            }
            else
            {
                if (lbRoundInfoList.Items.Count == 1 && lbRoundInfoList.Items.Contains(tbRoundBuyerList.Text.Trim())) //if there is check if it is not the same name as in the textbox.
                {
                    MessageBox.Show("You can't buy a drink for yourself!");
                }
                else
                {
                    if (!lbNameListList.Items.Contains(tbRoundBuyerList.Text.Trim())) //if it is not the same name as the buyer check is the name is valid
                    {
                        MessageBox.Show("No valid name was given");
                    }
                    else //if everything has passed update the balances of the drinkers and buyers
                    {
                        indexDrinkers = allListNames.IndexOf(lbRoundInfoArray.Items.Count.ToString()); //this returns -1 instead of the actual index of the names, needs fixing
                        indexBuyer = allListNames.IndexOf(tbRoundBuyerArray.Text); //so dies this


                        //these lines are to update the balance values, don't work yet bc of the above two lines 
                        //balanceArray[indexDrinkers] = balanceArray[indexDrinkers] - (Convert.ToInt32(tbRoundPrice.Text)/lbRoundInfo.Items.Count);
                        //balanceArray[indexBuyer] = balanceArray[indexBuyer] + (Convert.ToInt32(tbRoundPrice.Text));
                    }
                }
            }
        }
    }
}
