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
            Console.WriteLine($"@ AuctionHouse: May win up to {winningBidsCeiling} {(winningBidsCeiling == 1 ? "car" : "cars")} this visit");

            // Let the bidding begin
            for (var i = 0; i < winningBidsCeiling; i++)
            {
                // Purchased max cars already?
                if (carsOnHand + carsPurchased.Count >= _params.MaxInventory)
                {
                    Console.WriteLine($"@ AuctionHouse: At max inventory ({_params.MaxInventory}), done purchasing at auction");
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

                    Console.WriteLine($"@ AuctionHouse: Purchased a car for ${totalPurchaseAmount}, cash on hand is now ${cashOnHand}");
                }
                else
                {
                    // Not enough cash
                    Console.WriteLine($"@ AuctionHouse: Purchase amount is ${totalPurchaseAmount} but cash on hand is only ${cashOnHand}");
                }
            }

            Console.WriteLine();

            return carsPurchased;
        }
    }
}
