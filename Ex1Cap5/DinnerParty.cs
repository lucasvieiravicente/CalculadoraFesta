namespace Ex1Cap5
{
    class DinnerParty
    {
        private const decimal costOfFoodPerPerson = 25;

        private int numberOfPeople;
        private decimal costOfBeveragesPerPerson;
        private decimal costOfDecorations;
        private bool fancyParty;

        public int NumberOfPeople
        {
            get { return numberOfPeople; }
            set { numberOfPeople = value; CalculateCostOfDecorations(fancyParty); }
        }

        public DinnerParty(int numberOfPeople, bool fancyParty, bool healthyParty)
        {
            this.numberOfPeople = numberOfPeople;
            this.fancyParty = fancyParty;
            SetHealthOption(healthyParty);
            CalculateCostOfDecorations(fancyParty);
        }

        public void SetHealthOption(bool fancy)
        {
            fancyParty = fancy;
            if (fancy)
                costOfBeveragesPerPerson = 5;
            else
                costOfBeveragesPerPerson = 20;
        }

        public void CalculateCostOfDecorations(bool fancy)
        {
            if (fancy)
                costOfDecorations = (NumberOfPeople * 15.00M) + 50;

            else
                costOfDecorations = (NumberOfPeople * 7.50M) + 50;
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
