using SimEngine.AuctionHouse;
using SimEngine.Dealership;
using SimEngine.Ledger;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SimGui
{
    public partial class MainWindow : Form
    {
        private IDealership _dealership;
        private IAuctionHouse _auctionHouse;
        private ILedger _ledger;

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

            // Go ahead and simulate the first week
            _dealership.Crank();
            UpdateLotDisplay();

            // Update display
            UpdateDealershipDisplayValues();
        }

        private void UpdateDealershipDisplayValues()
        {
            currentCashTextBox.Text = $"{_dealership.GetCurrentCashOnHand()}";
            currentInventoryTextBox.Text = $"{_dealership.GetCurrentInventory().Count}";
        }

        private void nextWeekButton_Click(object sender, EventArgs e)
        {
            // Increment the week number
            weekNumberTextBox.Text = $"{Int32.Parse(weekNumberTextBox.Text) + 1}";

            // Simulate another week
            _dealership.Crank();

            // Update display
            UpdateDealershipDisplayValues();
            UpdateLotDisplay();
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
                    var x = 10 + 50 * i;
                    var y = 10;
                    g.DrawRectangle(Pens.White, x, y, 25, 25);
                    g.DrawString($"{_dealership.GetCurrentInventory()[i].WeeksInInventory}", SystemFonts.DefaultFont, Brushes.White, x + 8, y + 5);
                }
            }
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
            weekNumberTextBox.Text = "1";
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