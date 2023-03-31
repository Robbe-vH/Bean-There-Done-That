namespace ClassLibBTDT.Business.Entities
{
    public class Coffee
    {
        private int coffeeID;

        public int CoffeeID
        {
            get { return coffeeID; }
            set { coffeeID = value; }
        }

        private string origin;

        public string Origin
        {
            get { return origin; }
            set { origin = value; }
        }

        private string roast;

        public string Roast
        {
            get { return roast; }
            set { roast = value; }
        }

        private string flavor;

        public string Flavor
        {
            get { return flavor; }
            set { flavor = value; }
        }

        private int arabicaPerc;

        public int ArabicaPerc
        {
            get { return arabicaPerc; }
            set { arabicaPerc = value; }
        }

        private bool deCaf;

        public bool DeCaf
        {
            get { return deCaf; }
            set { deCaf = value; }
        }

        private double price;

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        private int stock;

        public int Stock
        {
            get { return stock; }
            set { stock = value; }
        }


        public Coffee(int coffeeID, string origin, string roast, string flavor, int arabicaPerc, bool deCaf, double price, int stock)
        {
            CoffeeID = coffeeID;
            Origin = origin;
            Roast = roast;
            Flavor = flavor;
            ArabicaPerc = arabicaPerc;
            DeCaf = deCaf;
            Price = price;
            Stock = stock;
        }
    }
}