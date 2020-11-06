using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gentry_linkedListSearch_X1
{
    public partial class Form1 : Form
    {
        LinkedList core = new LinkedList();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SearchResults.Text = "loading... please wait.";
            core.Start();
            UpadatUI();
            this.ActiveControl = SearchName;
        }

        private void SearchList_Click(object sender, EventArgs e)
        {
            SearchResults.Text = "";
            if (SearchName.Text == "")
            {
                MessageBox.Show("No name entered to search");
            }
            else
            {
                SearchResults.Text = core.SearchList(SearchName.Text);
            }
        }

        private void AddToList_Click(object sender, EventArgs e)
        {
            if(NameToAdd.Text == ""|| GenderSelection.Text == "" || PopularityAdd.Text == "" || int.TryParse(PopularityAdd.Text, out int popularNumber) == false)
            {
                MessageBox.Show("Not all values filled. Please try again");
            }
            else if (core.AddToList(NameToAdd.Text,GenderSelection.Text,int.Parse(PopularityAdd.Text)) == "error")
            {
                string message = "Name and gender already exist in the list. Do you want to try again but with _1X at the end of the name?";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult dialogResult = MessageBox.Show(message, "error", buttons);
                if(dialogResult == DialogResult.Yes)
                {
                    NameToAdd.Text = NameToAdd.Text + "_1X";
                    core.AddToList(NameToAdd.Text, GenderSelection.Text, int.Parse(PopularityAdd.Text));
                }
            }
            else 
            {
                MessageBox.Show("Done");
            }
            UpadatUI();
            NameToAdd.Text = "";
            GenderSelection.Text = "";
            PopularityAdd.Text = "";
        }
        private void UpadatUI()
        {
            numberOfMales.Text = core.getMale();
            TotalPeople.Text = core.getTotal();
            TotalFemales.Text = core.getFemale();
            PopularMale.Text = core.getPopulerMale();
            PopularFemale.Text = core.getPopulerFemale();
            SearchResults.Text = "";
        }
    }
}
