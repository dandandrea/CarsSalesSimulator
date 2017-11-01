using System;
using System.Collections.Generic;

namespace SimEngine.AuctionHouse
{
    public class TypicalAuctionHouse : IAuctionHouse
    {
        private AuctionParameters _params;
        private readonly Random _random;

        public TypicalAuctionHouse(AuctionParameters auctionParameters)
        {
            _params = auctionParameters;
            _random = new Random();
        }

        public List<Car> Buy(int cashOnHand, int carsOnHand)
        {
            // Hopefully this list ain't empty by the time we're done
            var carsPurchased = new List<Car>();

            // Generate a random winning bids ceiling
            int winningBidsCeiling = _random.Next(_params.NumberOfWinningBidsLow, _params.NumberOfWinningBidsHigh + 1);

            // Let the bidding begin
            for (var i = 0; i < winningBidsCeiling; i++)
            {
                // Purchased max cars already?
                if (carsOnHand + carsPurchased.Count >= _params.MaxInventory)
                {
                    break;
                }

                // Generate a random total purchase amount
                var totalPurchaseAmount = _random.Next(_params.TotalPurchasePriceLow, _params.TotalPurchasePriceHigh + 1);

                // Got enough cash for this one?
                if (cashOnHand >= totalPurchaseAmount)
                {
                    // Got it
                    carsPurchased.Add(new Car { TotalPurchaseAmount = totalPurchaseAmount });
                    cashOnHand = cashOnHand - totalPurchaseAmount;
                }
            }

            return carsPurchased;
        }
    }
}