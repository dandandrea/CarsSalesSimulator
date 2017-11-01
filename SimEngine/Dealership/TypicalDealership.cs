using System;
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
        public void Crank()
        {
            // Sell 'em if ya can
            var carsSold = SellCars(_currentInventory, _params, _random);

            // Remove cars sold at dealership from inventory and add entries to ledger
            carsSold.ForEach(result => _ledger.AddEntry(EntryDirection.CREDIT, EntryType.CAR_SALE, result.Car.TotalPurchaseAmount + result.Profit));
            carsSold.ForEach(result => _currentInventory.Remove(result.Car));

            // Visit the auction
            var carsPurchased = _auctionHouse.Buy(_ledger.GetCurrentCashOnHand(), _currentInventory.Count);

            // Add cars purchased at auction to ledger and inventory
            carsPurchased.ForEach(car => _ledger.AddEntry(EntryDirection.DEBIT, EntryType.CAR_PURCHASE, car.TotalPurchaseAmount));
            carsPurchased.ForEach(car => _currentInventory.Add(car));

            // Deduct personal expenses
            Console.WriteLine($"Deducting ${_params.WeeklyPersonalExpenses} for personal expenses");
            _ledger.AddEntry(EntryDirection.DEBIT, EntryType.PERSONAL_EXPENSES, _params.WeeklyPersonalExpenses);

            // Age the inventory
            _currentInventory.ForEach(car => car.WeeksInInventory += 1);
        }

        public List<Car> GetCurrentInventory()
        {
            return _currentInventory;
        }

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
        private static List<SalesResult> SellCars(List<Car> currentInventory, DealershipParameters dealershipParams, Random random) {
            var results = new List<SalesResult>();

            // Sell cars or increment their time in inventory
            foreach (var car in currentInventory)
            {
                // Sell car or increment its time in inventory
                if (car.WeeksInInventory >= dealershipParams.MaxWeeksForCarToSell)
                {
                    // Generate random quantity for sale profit
                    int saleProfit = random.Next(dealershipParams.SaleProfitLow, dealershipParams.SaleProfitHigh + 1);

                    // Add sale to results
                    results.Add(new SalesResult { Car = car, Profit = saleProfit });

                    Console.WriteLine($"$ Sold a car for ${car.TotalPurchaseAmount + saleProfit} (${saleProfit} profit)");
                }
            }

            // Done
            return results;
        }
    }
}
