using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class CreateTeamForm : Form
    {

        private List<PersonModel> availableTeamMembers = GlobalConfig.Connection.GetPerson_All();
        private List<PersonModel> selectedTeamMembers = new List<PersonModel>();

        public CreateTeamForm()
        {
            InitializeComponent();
            
            //CreateSampleData();
            
            wireUpLists();
        }

        private void wireUpLists()
        {


            selectTeamMemberDropDown.DataSource = null;

            selectTeamMemberDropDown.DataSource = availableTeamMembers;
            selectTeamMemberDropDown.DisplayMember = "FullName";

            teamMembersListBox.DataSource = null;

            teamMembersListBox.DataSource = selectedTeamMembers;
            teamMembersListBox.DisplayMember = "FullName";
        }

        private void CreateSampleData()
        {
            availableTeamMembers.Add(new PersonModel {FirstName = "Jon", LastName = "Rhoads" });
            availableTeamMembers.Add(new PersonModel { FirstName = "Jane", LastName = "Smith" });

            selectedTeamMembers.Add(new PersonModel { FirstName = "Denzel", LastName = "Washington" });
            selectedTeamMembers.Add(new PersonModel { FirstName = "Dwayne", LastName = "Johnson" });
        }

        private void createTeamLabel_Click(object sender, EventArgs e)
        {
        }

        private void teamNameLabel_Click(object sender, EventArgs e)
        {
        }

        private void selectTeamMemberLabel_Click(object sender, EventArgs e)
        {
        }

        private void firstNameLabel_Click(object sender, EventArgs e)
        {
        }

        private void addTeamMemberButton_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)selectTeamMemberDropDown.SelectedItem;

            if (p != null)
            {
                availableTeamMembers.Remove(p);
                selectedTeamMembers.Add(p);

                wireUpLists(); 
            }
            
        }
        private void removeSelectedPlayerButton_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)teamMembersListBox.SelectedItem;

            if (p != null)
            {
                selectedTeamMembers.Remove(p);
                availableTeamMembers.Add(p);

                wireUpLists(); 
            }
        }
        private void CreateTeamForm_Load(object sender, EventArgs e)
        {
        }

        private void createTeamButton_Click(object sender, EventArgs e)
        {
        }

        private void createMemberButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PersonModel p = new PersonModel();

                p.FirstName = firstNameValue.Text;
                p.LastName = lastNameValue.Text;
                p.EmailAddress = emailValue.Text;
                p.CellphoneNumber = cellphoneValue.Text;

                p = GlobalConfig.Connection.CreatePerson(p);

                selectedTeamMembers.Add(p);

                wireUpLists();

                firstNameValue.Text = "";
                lastNameValue.Text = "";
                emailValue.Text = "";
                cellphoneValue.Text = "";
            }
            else
            {
                MessageBox.Show("This form has invalid information. Please check it and try again.");
            }


        }

        private bool ValidateForm()
        {
            
            if(firstNameValue.Text.Length == 0)
            {
                return false;
            }
            if (lastNameValue.Text.Length == 0)
            {
                return false;
            }
            if (emailValue.Text.Length == 0)
            {
                return false;
            }
            if (cellphoneValue.Text.Length == 0)
            {
                return false;
            }
            return true;
        }

        private void cellphoneValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void teamMembersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
    }
}