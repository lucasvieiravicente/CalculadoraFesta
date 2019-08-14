using System.Windows.Forms;

namespace Ex1Cap5
{
    class BirthdayParty : Party
    {
        private string cakeWriting = "";
        public int CakeSize;

        public BirthdayParty(int numberOfPeople, bool fancyParty, string cakeWriting) : base(numberOfPeople, fancyParty)
        {
            CalculateCakeSize();
            CakeWriting = cakeWriting;            
        }

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

        public override int NumberOfPeople
        {
            get { return base.NumberOfPeople; }
            set { base.NumberOfPeople = value; CalculateCakeSize(); CakeWriting = cakeWriting; }
        }       

        public void CalculateCakeSize()
        {
            if (NumberOfPeople <= 4)
                CakeSize = 8;
            else
                CakeSize = 16;
        }

        public override decimal CalculateCost()
        {
            decimal totalCost = base.CalculateCost();            
            decimal CakeCost;

            if (CakeSize == 8)
                CakeCost = 40M + CakeWriting.Length * .25M;
            else
                CakeCost = 75M + CakeWriting.Length * .25M;
            
            return totalCost + CakeCost;
        }
    }
}
