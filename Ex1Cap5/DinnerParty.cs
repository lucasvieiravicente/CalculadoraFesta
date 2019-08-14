namespace Ex1Cap5
{
    class DinnerParty : Party
    {
        private decimal costOfBeveragesPerPerson;                
        private bool healthyParty;

        public override int NumberOfPeople
        {
            get { return base.NumberOfPeople; }
            set { base.NumberOfPeople = value; SetHealthOption(healthyParty); }
        }

        public DinnerParty(int numberOfPeople, bool fancyParty, bool healthyParty) : base (numberOfPeople, fancyParty)
        {                      
            SetHealthOption(healthyParty);            
        }

        public void SetHealthOption(bool healthy)
        {
            healthyParty = healthy;
            if (healthyParty)
                costOfBeveragesPerPerson = 5;
            else
                costOfBeveragesPerPerson = 20;
        }        
        
        public override decimal CalculateCost()
        {            
            decimal totalCost = base.CalculateCost() + (costOfBeveragesPerPerson * NumberOfPeople);

            if (healthyParty)
                return totalCost * 0.95M;
            else
                return totalCost;
        }
    }
}
