using System;
using System.Windows.Forms;

namespace Ex1Cap5
{
    public partial class Form1 : Form
    {
        DinnerParty dinnerParty;
        BirthdayParty birthdayParty;

        public Form1()
        {
            InitializeComponent();

            //DINNER PLANNER =============================================================================================================================================            
            dinnerParty = new DinnerParty((int)numberPeopleUpDown.Value, fancyOption.Checked, healthyOption.Checked);
            DisplayDinnerPartyCost();
            //=============================================================================================================================================================

            //BIRTHDAY PLANNER ==============================================================================================================================================
            fancyBirthdayCheck.Checked = true;
            birthdayParty = new BirthdayParty((int)numberOfPeopleBirthday.Value, fancyBirthdayCheck.Checked, birthdayCakeTextBox.Text);
            DisplayBirthdayPartyCost();
        }

        //DINNER PLANNER ==============================================================================================================================================        
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            dinnerParty.NumberOfPeople = (int)numberPeopleUpDown.Value;
            DisplayDinnerPartyCost();
        }

        private void DisplayDinnerPartyCost()
        {
            costLabel.Text = dinnerParty.CalculateCost(healthyOption.Checked).ToString("C");            
        }

        private void fancyOption_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.CalculateCostOfDecorations(fancyOption.Checked);
            DisplayDinnerPartyCost();
        }

        private void healthyOption_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.SetHealthOption(healthyOption.Checked);
            DisplayDinnerPartyCost();
        }
        //===============================================================================================================================================================

        //BIRTHDAY PLANNER ==============================================================================================================================================
        private void numberOfPeopleBirthday_ValueChanged(object sender, EventArgs e)
        {
            birthdayParty.NumberOfPeople = (int)numberOfPeopleBirthday.Value;
            DisplayBirthdayPartyCost();
        }

        private void fancyBirthdayCheck_CheckedChanged(object sender, EventArgs e)
        {
            birthdayParty.CalculateCostOfDecorations(fancyBirthdayCheck.Checked);
            DisplayBirthdayPartyCost();
        }

        private void birthdayCakeTextBox_TextChanged(object sender, EventArgs e)
        {
            birthdayParty.CakeWriting = birthdayCakeTextBox.Text;
            DisplayBirthdayPartyCost();
        }
    
        private void DisplayBirthdayPartyCost()
        {
            costBirthdayLabel.Text = birthdayParty.CalculateCost().ToString("C");
        }
    }
}
