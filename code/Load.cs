namespace Space_Game
{
    //TODO Develop trading system - X product goes to [planet] to be sold for how much?

    public class Load
    {
        public string description;
        
        public int weight;

        public decimal purchaseCost;
        public decimal sellingCost;

        public Load(string description, int weight, decimal purchaseCost, decimal sellingCost)
        {
            this.description = description;
            this.weight = weight;
            this.purchaseCost = purchaseCost;
            this.sellingCost = sellingCost;
        }
    }
}