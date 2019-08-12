namespace Ex1Cap5
{
    class DinnerParty
    {
        private const decimal costOfFoodPerPerson = 25;

        private int numberOfPeople;
        private decimal costOfDecorations;
        private decimal costOfBeveragesPerPerson;        
        private bool fancyParty;
        private bool healthyParty;

        public int NumberOfPeople
        {
            get { return numberOfPeople; }
            set { numberOfPeople = value; CalculateCostOfDecorations(fancyParty); SetHealthOption(healthyParty); }
        }

        public DinnerParty(int numberOfPeople, bool fancyParty, bool healthyParty)
        {
            this.numberOfPeople = numberOfPeople;
            this.fancyParty = fancyParty;
            SetHealthOption(healthyParty);
            CalculateCostOfDecorations(fancyParty);
        }

        public void SetHealthOption(bool healthy)
        {
            healthyParty = healthy;
            if (healthyParty)
                costOfBeveragesPerPerson = 5;
            else
                costOfBeveragesPerPerson = 20;
        }

        public void CalculateCostOfDecorations(bool fancy)
        {
            if (fancy)
                costOfDecorations = (NumberOfPeople * 15.00M) + 50;

            else
                costOfDecorations = (NumberOfPeople * 7.50M) + 30;
        }
        
        public decimal CalculateCost(bool healthy)
        {
            decimal totalCost = ((costOfBeveragesPerPerson + costOfFoodPerPerson) * NumberOfPeople) + costOfDecorations;

            if (healthy)
                return totalCost * 0.95M;
            else
                return totalCost;
        }
    }
}
