using System;
using System.Linq;
using System.Collections.Generic;
using SimEngine.AuctionHouse;
using SimEngine.Ledger;

namespace SimEngine.Dealership
{
    public class TypicalDealership : IDealership
    {
        private readonly DealershipParameters _params;
        private readonly IAuctionHouse _auctionHouse;
        private readonly ILedger _ledger;
        private readonly List<Car> _currentInventory;
        private readonly Random _random;

        public TypicalDealership(DealershipParameters dealershipParams, IAuctionHouse auctionHouse)
        {
            _currentInventory = new List<Car>();
            _ledger = new TypicalLedger(dealershipParams.StartingCash);
            _auctionHouse = auctionHouse;
            _params = dealershipParams;
            _random = new Random();
        }

        // Turn the machine
        public WeeklyResult Crank(int weekNumber)
        {
            // Sell 'em if ya can
            var carsSold = SellCars(_currentInventory, _params, _random);

            // Remove cars sold at dealership from inventory and add entries to ledger
            carsSold.ForEach(car => _ledger.AddEntry(EntryDirection.CREDIT, EntryType.CAR_SALE, weekNumber, car.TotalPurchaseAmount + car.ProjectedProfit));
            carsSold.ForEach(car => _currentInventory.Remove(car));

            // Visit the auction
            var carsPurchased = _auctionHouse.Buy(_ledger.GetCurrentCashOnHand(), _currentInventory.Count);

            // Assign profit projections and add cars purchased at auction to ledger & inventory
            carsPurchased.ForEach(car => car.ProjectedProfit = _random.Next(_params.SaleProfitLow, _params.SaleProfitHigh + 1));
            carsPurchased.ForEach(car => _ledger.AddEntry(EntryDirection.DEBIT, EntryType.CAR_PURCHASE, weekNumber, car.TotalPurchaseAmount));
            carsPurchased.ForEach(car => _currentInventory.Add(car));

            // Deduct personal expenses
            _ledger.AddEntry(EntryDirection.DEBIT, EntryType.PERSONAL_EXPENSES, weekNumber, _params.WeeklyPersonalExpenses);

            // Age the inventory
            _currentInventory.ForEach(car => car.WeeksInInventory += 1);

            // Return WeeklyResult
            return new WeeklyResult {
                CashOnHand = _ledger.GetCurrentCashOnHand(),
                CashLockedUp = _currentInventory.Sum(x => x.TotalPurchaseAmount),
                TotalAssets = _currentInventory.Sum(x => x.TotalPurchaseAmount + x.ProjectedProfit)
            };
        }

        // Simple getters
        public DealershipParameters GetParameters() => _params;
        public List<Car> GetCurrentInventory() => _currentInventory;
        public ILedger GetLedger() => _ledger;

        // Pass-through method: Get current cash on hand
        public int GetCurrentCashOnHand()
        {
            return _ledger.GetCurrentCashOnHand();
        }

        // Pass-through method: Get net profit
        public int GetNetProfit()
        {
            return _ledger.GetNetProfit();
        }

        // Sell cars
        private static List<Car> SellCars(List<Car> currentInventory, DealershipParameters dealershipParams, Random random) {
            var results = new List<Car>();

            // Sell cars or increment their time in inventory
            foreach (var car in currentInventory)
            {
                // Generate a random number of weeks
                var randomNumberOfWeeks = random.Next(dealershipParams.WeeksForCarToSellLow, dealershipParams.WeeksForCarToSellHigh + 1);

                // Sell car if ready
                if (car.WeeksInInventory >= randomNumberOfWeeks)
                {
                    // Add sale to results
                    results.Add(car);
                }
            }

            // Done
            return results;
        }
    }
}