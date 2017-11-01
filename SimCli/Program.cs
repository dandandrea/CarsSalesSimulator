using SimEngine;
using SimEngine.AuctionHouse;
using SimEngine.Dealership;
using System;

namespace CarSalesModeler
{
    public class Program
    {
        public static void Main(string[] args)
        {
            const int STARTING_BALANCE = 12000;
            const int SALE_PROFIT_LOW = 950;
            const int SALE_PROFIT_HIGH = 1400;
            const int NUM_WINNING_BIDS_LOW = 1;
            const int NUM_WINNING_BIDS_HIGH = 6;
            const int TOTAL_PURCHASE_PRICE_LOW = 2000;
            const int TOTAL_PURCHASE_PRICE_HIGH = 4000;
            const int MAX_INVENTORY = 5;
            const int MAX_WEEKS_FOR_CAR_TO_SELL = 3;
            const int WEEKLY_PERSONAL_EXPENSES = 500;

            // Auction house
            var auctionParams = new AuctionParameters
            {
                NumberOfWinningBidsLow = NUM_WINNING_BIDS_LOW,
                NumberOfWinningBidsHigh = NUM_WINNING_BIDS_HIGH,
                TotalPurchasePriceLow = TOTAL_PURCHASE_PRICE_LOW,
                TotalPurchasePriceHigh = TOTAL_PURCHASE_PRICE_HIGH,
                MaxInventory = MAX_INVENTORY
            };
            var auctionHouse = new TypicalAuctionHouse(auctionParams);

            // Dealership
            var dealershipParams = new DealershipParameters
            {
                StartingCash = STARTING_BALANCE,
                SaleProfitLow = SALE_PROFIT_LOW,
                SaleProfitHigh = SALE_PROFIT_HIGH,
                WeeklyPersonalExpenses = WEEKLY_PERSONAL_EXPENSES,
                MaxWeeksForCarToSell = MAX_WEEKS_FOR_CAR_TO_SELL
            };
            var dealership = new TypicalDealership(dealershipParams, auctionHouse);

            // Grind away
            int weekNumber = 1;
            while (true)
            {
                // Start of week report
                Console.Write($">>> Start of week {weekNumber} [Cash: ${dealership.GetCurrentCashOnHand()}");
                Console.WriteLine($", cars: {dealership.CurrentInventory.Count}]");

                // Starting inventory
                Console.WriteLine();
                Console.WriteLine($"Beginning inventory");
                Console.WriteLine($"-------------------");
                foreach (var car in dealership.CurrentInventory)
                {
                    Console.WriteLine($"* Purchased for ${car.TotalPurchaseAmount} {car.WeeksInInventory} {(car.WeeksInInventory == 1 ? "week" : "weeks")} ago");
                }
                Console.WriteLine();

                // Do the week's business
                dealership.Crank();

                // End of week report
                Console.Write($">>> End of week {weekNumber} [");
                Console.Write($"Cash ${dealership.GetCurrentCashOnHand()}");
                Console.Write($", cars: {dealership.CurrentInventory.Count}");
                Console.WriteLine($", rough profit per month: ${dealership.GetNetProfit() / weekNumber * 4.2}]");
                Console.WriteLine();
                Console.WriteLine($"ENTER Q TO QUIT");

                // Another week, another dollar
                weekNumber++;

                // Quit?
                var quit = Console.ReadLine();
                if (quit?.Trim().ToUpper() == "Q") break;
            }
        }
    }
}
