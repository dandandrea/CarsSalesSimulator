namespace SimEngine.AuctionHouse
{
    public class AuctionParameters
    {
        public int NumberOfWinningBidsLow { get; set; }
        public int NumberOfWinningBidsHigh { get; set; }
        public int TotalPurchasePriceLow { get; set; }
        public int TotalPurchasePriceHigh { get; set; }
        public int MaxInventory { get; set; }

        public AuctionParameters() { }

        public AuctionParameters(int numberOfWinningBidsLow, int numberOfWinningBidsHigh, int totalPurchasePriceLow, int totalPurchasePriceHigh,
            int maxInventory)
        {
            NumberOfWinningBidsLow = numberOfWinningBidsLow;
            NumberOfWinningBidsHigh = numberOfWinningBidsHigh;
            TotalPurchasePriceLow = totalPurchasePriceLow;
            TotalPurchasePriceHigh = totalPurchasePriceHigh;
            MaxInventory = maxInventory;
        }
    }
}
