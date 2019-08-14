namespace Ex1Cap5
{
    class Party
    {
        public const decimal costOfFoodPerPerson = 25;

        private int numberOfPeople;
        public decimal CostOfDecorations { get; set; }
        public bool FancyParty { get; set; }

        public Party(int numberOfPeople, bool fancyParty)
        {             
            FancyParty = fancyParty;
            NumberOfPeople = numberOfPeople;
            CalculateCostOfDecorations(FancyParty);
        }

        public virtual int NumberOfPeople
        {
            get { return numberOfPeople; }
            set { numberOfPeople = value; CalculateCostOfDecorations(FancyParty); }
        }

        public void CalculateCostOfDecorations(bool fancy)
        {
            FancyParty = fancy;
            if (fancy)
                CostOfDecorations = (NumberOfPeople * 15.00M) + 50;

            else
                CostOfDecorations = (NumberOfPeople * 7.50M) + 30;
        }

        public virtual decimal CalculateCost()
        {
            decimal partialCost = CostOfDecorations + (costOfFoodPerPerson * numberOfPeople);
            return partialCost;
        }
    }
}
