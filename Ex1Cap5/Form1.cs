using System;
using System.Windows.Forms;

namespace Ex1Cap5
{
    public partial class Form1 : Form
    {
        DinnerParty dinnerParty;

        public Form1()
        {
            InitializeComponent();

            healthyOption.Checked = false;
            fancyOption.Checked = true;

            dinnerParty = new DinnerParty(5, fancyOption.Checked, healthyOption.Checked);
            DisplayDinnerPartyCost();

        }

        private void Form1_Load(object sender, EventArgs e){}

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            dinnerParty = new DinnerParty((int)numberPeopleUpDown.Value, fancyOption.Checked, healthyOption.Checked);
            DisplayDinnerPartyCost();
        }

        private void DisplayDinnerPartyCost()
        {
            costLabel.Text = dinnerParty.CalculateCost(healthyOption.Checked).ToString("c");
        }

        private void fancyOption_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty = new DinnerParty((int)numberPeopleUpDown.Value, fancyOption.Checked, healthyOption.Checked);
            DisplayDinnerPartyCost();
        }

        private void healthyOption_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty = new DinnerParty((int)numberPeopleUpDown.Value, fancyOption.Checked, healthyOption.Checked);
            DisplayDinnerPartyCost();
        }
    }
}
