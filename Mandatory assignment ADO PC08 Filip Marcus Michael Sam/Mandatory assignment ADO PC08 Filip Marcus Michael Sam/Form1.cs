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

        //list of the default names
        string[] defaultNames = new string[]
        {
        "Eden",
        "Filip",
        "Marcus",
        "Michael",
        "Sam"
        };

        //list of the balances
        List<double> balance = new List<double>()
        {
            0.00, //this one is on index 0 so would correspond to the default name at index 0, which in this case is Eden
            0.00,
            0.00,
            0.00,
            0.00
        };

        List<string> allNames = new List<string>();

        int indexBalance;

        public Form1()
        {
            InitializeComponent();
            lbNameList.Items.Clear();
        }
        private void btnAddDefaultsArray_Click(object sender, EventArgs e)
        { 
            //adds the devault names to the listboxes once 
            for (int i = 0; i < defaultNames.Length; i++)
            {
                lbNameList.Items.Add(defaultNames[i]);

                lbCurrentStandingOfDebt.Items.Add(defaultNames[i] + "          € " + balance[i]);

                allNames.Add(defaultNames[i]);
            }

            btnAddDefaults.Enabled = false;

        }

        private void btnRemovePersonArray_Click(object sender, EventArgs e) //Button for removing selected players, can't change the name to the proper name because vs suck
        {
            //removes the selected name in lbNameList
            if (this.lbNameList.SelectedItem != null && balance[indexBalance] == 0.00) 
            { 
                this.lbNameList.Items.Remove(this.lbNameList.SelectedItem); 
            }
            else
            {
                if (this.lbNameList.SelectedItem != null && balance[indexBalance] != 0.00)
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
            lbNameList.Items.Add(tbTeamMemberName.Text);

            //new name and balance are added to each list 
            allNames.Add(tbTeamMemberName.Text);
            balance.Add(0.00);


            lbCurrentStandingOfDebt.Items.Add(allNames[allNames.Count - 1] + "          € "+  balance[balance.Count - 1]);

        }

        private void btnRemoveNameArray_Click(object sender, EventArgs e)
        {
            //removes the name which is in the textbox from the name list
            string name = tbTeamMemberName.Text.Trim();

            if (lbNameList.Items.Contains(name) && balance[indexBalance] == 0.00) //checks if the listbox contains the name in the textbox and if the balance is 0
            {
                lbNameList.Items.Remove(tbTeamMemberName.Text);
            }
            else
            {
                if(lbNameList.Items.Contains(name) && balance[indexBalance] != 0.00) //if the balance is not 0 show message
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
            if (this.lbNameList.SelectedItem != null)
            {
                lbRoundInfo.Items.Add(this.lbNameList.SelectedItem);

                this.lbNameList.Items.Remove(this.lbNameList.SelectedItem);
            }
        }

        private void btnMoveToListboxArray_Click(object sender, EventArgs e)
        {

            //code to move names back from the round info listbox to the name listbox 
            if (this.lbRoundInfo.SelectedItem != null && balance[indexBalance] == 0)
            {
                lbNameList.Items.Add(this.lbRoundInfo.SelectedItem);

                this.lbRoundInfo.Items.Remove(this.lbRoundInfo.SelectedItem);
            }
        }

        private void btnBuyARoundArray_Click(object sender, EventArgs e)
        {
                int indexDrinkers;
                int indexBuyer;

            //check if there is a name in the listbox
            if (lbRoundInfo.Items.Count == 0)
            {
                MessageBox.Show("You can't buy a round for nobody!");
            }
            else
            {
                if (lbRoundInfo.Items.Count == 1 && lbRoundInfo.Items.Contains(tbRoundBuyer.Text.Trim())) //if there is check if it is not the same name as in the textbox.
                {
                    MessageBox.Show("You can't buy a drink for yourself!");
                }
                else
                {
                    if (!lbNameList.Items.Contains(tbRoundBuyer.Text.Trim())) //if it is not the same name as the buyer check is the name is valid
                    {
                        MessageBox.Show("No valid name was given");
                    }
                    else //if everything has passed update the balances of the drinkers and buyers
                    {
                    indexDrinkers = allNames.IndexOf(lbRoundInfo.Items.Count.ToString()); //this returns -1 instead of the actual index of the names, needs fixing
                    indexBuyer = allNames.IndexOf(tbRoundBuyer.Text); //so dies this


                    //these lines are to update the balance values, don't work yet bc of the above two lines 
                    //balance[indexDrinkers] = balance[indexDrinkers] - (Convert.ToInt32(tbRoundPrice.Text)/lbRoundInfo.Items.Count);
                    //balance[indexBuyer] = balance[indexBuyer] + (Convert.ToInt32(tbRoundPrice.Text));
                    }
                }
            }
        }
    }
}
