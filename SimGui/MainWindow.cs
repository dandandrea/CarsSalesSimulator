using SimEngine.AuctionHouse;
using SimEngine.Dealership;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SimGui
{
    public partial class MainWindow : Form
    {
        private IDealership _dealership;
        private IAuctionHouse _auctionHouse;

        private bool _started = false;

        private const int STARTING_BALANCE = 12000;
        private const int SALE_PROFIT_LOW = 950;
        private const int SALE_PROFIT_HIGH = 1400;
        private const int NUM_WINNING_BIDS_LOW = 1;
        private const int NUM_WINNING_BIDS_HIGH = 6;
        private const int TOTAL_PURCHASE_PRICE_LOW = 2000;
        private const int TOTAL_PURCHASE_PRICE_HIGH = 4000;
        private const int MAX_INVENTORY = 5;
        private const int MAX_WEEKS_FOR_CAR_TO_SELL = 3;
        private const int WEEKLY_PERSONAL_EXPENSES = 500;

        public MainWindow()
        {
            // Auto-generated
            InitializeComponent();

            // Me
            SetInitialTextBoxValues();
            InitializeForm();
        }

        private void InitializeForm()
        {
            InitializeDealership();
            SetControlsToStoppedState();
            UpdateLotDisplay();
            _started = false;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            // Have we already started?  If so, this is a request to stop
            if (_started == true)
            {
                // Stop
                InitializeForm();
                return;
            }

            // TODO: Validate inputs

            // Started
            SetControlsToRunningState();
            _started = true;

            // Initialize the dealership and lot display
            InitializeDealership();
            UpdateLotDisplay();

            // Simulate the first week
            Crank();
        }

        private void nextWeekButton_Click(object sender, EventArgs e)
        {
            Crank();
        }

        private void Crank()
        {
            // Increment the week number
            var weekNumber = Int32.Parse(weekNumberTextBox.Text) + 1;
            weekNumberTextBox.Text = $"{weekNumber}";

            // Simulate another week
            _dealership.Crank(weekNumber);

            // Update display
            UpdateDealershipDisplayValues();
            UpdateLotDisplay();
            UpdateLedgerDisplay();
        }

        private void UpdateLedgerDisplay()
        {
            foreach (var entry in _dealership.GetLedger().GetEntries())
            {
                if (entry.WeekNumber == Int32.Parse(weekNumberTextBox.Text))
                {
                    ledgerTextBox.AppendText($"{entry}\n");
                }
            }
        }

        private void UpdateLotDisplay()
        {
            using (var g = panel3.CreateGraphics())
            {
                // Clear the lot first
                g.Clear(Color.Black);

                // Redraw the lot
                for (var i = 0; i < _dealership.GetCurrentInventory().Count; i++)
                {
                    var car = _dealership.GetCurrentInventory()[i];

                    var pen = Pens.White;
                    var brush = Brushes.White;
                    if (car.WeeksInInventory == _dealership.GetParameters().MaxWeeksForCarToSell - 1)
                    {
                        pen = Pens.Yellow;
                        brush = Brushes.Yellow;
                    }
                    else if (car.WeeksInInventory == _dealership.GetParameters().MaxWeeksForCarToSell)
                    {
                        pen = Pens.Green;
                        brush = Brushes.Green;
                    }

                    var x = 10 + 50 * i;
                    var y = 10;

                    g.DrawRectangle(pen, x, y, 25, 25);
                    g.DrawString($"{car.WeeksInInventory}", SystemFonts.DefaultFont, brush, x + 8, y + 5);
                }
            }
        }

        private void UpdateDealershipDisplayValues()
        {
            currentCashTextBox.Text = $"{_dealership.GetCurrentCashOnHand()}";
            currentInventoryTextBox.Text = $"{_dealership.GetCurrentInventory().Count}";
        }

        private void InitializeDealership()
        {
            // Auction house
            var auctionParams = new AuctionParameters
            {
                NumberOfWinningBidsLow = Int32.Parse(winningBidsLowTextBox.Text),
                NumberOfWinningBidsHigh = Int32.Parse(winningBidsHighTextBox.Text),
                TotalPurchasePriceLow = Int32.Parse(lowWinningBidAmountTextBox.Text),
                TotalPurchasePriceHigh = Int32.Parse(highWinningBidAmountTextBox.Text),
                MaxInventory = Int32.Parse(maxInventoryTextBox.Text)
            };
            _auctionHouse = new TypicalAuctionHouse(auctionParams);

            // Dealership
            var dealershipParams = new DealershipParameters
            {
                StartingCash = Int32.Parse(startingCashTextBox.Text),
                SaleProfitLow = Int32.Parse(profitLowTextBox.Text),
                SaleProfitHigh = Int32.Parse(profitHighTextBox.Text),
                WeeklyPersonalExpenses = Int32.Parse(personalExpensesTextBox.Text),
                MaxWeeksForCarToSell = Int32.Parse(weeksToSellTextBox.Text)
            };
            _dealership = new TypicalDealership(dealershipParams, _auctionHouse);
        }

        private void SetControlsToRunningState()
        {
            // Disable text boxes
            startingCashTextBox.Enabled = false;
            maxInventoryTextBox.Enabled = false;
            profitLowTextBox.Enabled = false;
            profitHighTextBox.Enabled = false;
            winningBidsLowTextBox.Enabled = false;
            winningBidsHighTextBox.Enabled = false;
            lowWinningBidAmountTextBox.Enabled = false;
            highWinningBidAmountTextBox.Enabled = false;
            weeksToSellTextBox.Enabled = false;
            personalExpensesTextBox.Enabled = false;

            // Buttons
            startButton.BackColor = Color.Red;
            startButton.Text = "Stop";
            nextWeekButton.Enabled = true;

            // Initialize week number
            weekNumberTextBox.Text = "0";
        }

        private void SetControlsToStoppedState()
        {
            // Text boxes values
            weekNumberTextBox.Text = "";
            currentInventoryTextBox.Text = "";
            currentCashTextBox.Text = "";

            // Enable text boxes
            startingCashTextBox.Enabled = true;
            maxInventoryTextBox.Enabled = true;
            profitLowTextBox.Enabled = true;
            profitHighTextBox.Enabled = true;
            winningBidsLowTextBox.Enabled = true;
            winningBidsHighTextBox.Enabled = true;
            lowWinningBidAmountTextBox.Enabled = true;
            highWinningBidAmountTextBox.Enabled = true;
            weeksToSellTextBox.Enabled = true;
            personalExpensesTextBox.Enabled = true;

            // Buttons
            startButton.BackColor = Color.Green;
            startButton.Text = "Start";
            nextWeekButton.Enabled = false;
        }

        private void SetInitialTextBoxValues()
        {
            startingCashTextBox.Text = $"{STARTING_BALANCE}";
            maxInventoryTextBox.Text = $"{MAX_INVENTORY}";
            profitLowTextBox.Text = $"{SALE_PROFIT_LOW}";
            profitHighTextBox.Text = $"{SALE_PROFIT_HIGH}";
            winningBidsLowTextBox.Text = $"{NUM_WINNING_BIDS_LOW}";
            winningBidsHighTextBox.Text = $"{NUM_WINNING_BIDS_HIGH}";
            lowWinningBidAmountTextBox.Text = $"{TOTAL_PURCHASE_PRICE_LOW}";
            highWinningBidAmountTextBox.Text = $"{TOTAL_PURCHASE_PRICE_HIGH}";
            weeksToSellTextBox.Text = $"{MAX_WEEKS_FOR_CAR_TO_SELL}";
            personalExpensesTextBox.Text = $"{WEEKLY_PERSONAL_EXPENSES}";
        }
    }
}