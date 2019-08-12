using System.Windows.Forms;

namespace Ex1Cap5
{
    class BirthdayParty
    {
        private const decimal costOfFoodPerPerson = 25;

        private int numberOfPeople;
        private decimal costOfDecorations;
        private bool fancyParty;
        private string cakeWriting = "";

        public int CakeSize;

        public string CakeWriting
        {
            get { return cakeWriting; }
            set
            {
                int maxLenght;

                if (CakeSize == 8)
                    maxLenght = 16;
                else
                    maxLenght = 40;

                if (value.Length > maxLenght)
                {
                    MessageBox.Show("Too many letters for a " + CakeSize + " inch cake!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (maxLenght > cakeWriting.Length)
                        maxLenght = cakeWriting.Length;

                    cakeWriting = cakeWriting.Substring(0, maxLenght);
                }
                else
                    cakeWriting = value;
                    
            }
        }

        public int NumberOfPeople
        {
            get { return numberOfPeople; }
            set { numberOfPeople = value; CalculateCostOfDecorations(fancyParty); CalculateCakeSize(); CakeWriting = cakeWriting; }
        }

        public BirthdayParty(int numberOfPeople, bool fancyParty, string cakeWriting)
        {
            this.numberOfPeople = numberOfPeople;
            this.fancyParty = fancyParty;
            CalculateCakeSize();
            CakeWriting = cakeWriting;
            CalculateCostOfDecorations(fancyParty);
        }

        public void CalculateCostOfDecorations(bool fancy)
        {
            if (fancy)
                costOfDecorations = (NumberOfPeople * 15.00M) + 50;

            else
                costOfDecorations = (NumberOfPeople * 7.50M) + 30;
        }

        public void CalculateCakeSize()
        {
            if (NumberOfPeople <= 4)
                CakeSize = 8;
            else
                CakeSize = 16;
        }

        public decimal CalculateCost()
        {
            decimal TotalCost = costOfDecorations + (costOfFoodPerPerson * NumberOfPeople);
            decimal CakeCost;

            if (CakeSize == 8)
                CakeCost = 40M + CakeWriting.Length * .25M;
            else
                CakeCost = 75M + CakeWriting.Length * .25M;

            return TotalCost + CakeCost;
        }
    }
}
