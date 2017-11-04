using SimEngine.AuctionHouse;
using SimEngine.Dealership;
using System;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace SimGui
{
    public partial class MainWindow : Form
    {
        private IDealership _dealership;

        private bool _started = false;

        private const int STARTING_BALANCE = 17500;
        private const int SALE_PROFIT_LOW = 950;
        private const int SALE_PROFIT_HIGH = 1400;
        private const int NUM_WINNING_BIDS_LOW = 2;
        private const int NUM_WINNING_BIDS_HIGH = 6;
        private const int TOTAL_PURCHASE_PRICE_LOW = 2500;
        private const int TOTAL_PURCHASE_PRICE_HIGH = 4000;
        private const int MAX_INVENTORY = 6;
        private const int WEEKS_FOR_CAR_TO_SELL_LOW = 3;
        private const int WEEKS_FOR_CAR_TO_SELL_HIGH = 4;
        private const int WEEKLY_PERSONAL_EXPENSES = 750;

        private const int SIMULATION_RANDOMNESS_DELAY = 20;

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
            _dealership = GetDealership();
            SetControlsToStoppedState();
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
            _dealership = GetDealership();

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
            var weeklyResult = _dealership.Crank(weekNumber);

            // Update display
            UpdateDealershipDisplayValues(weeklyResult);
            UpdateLedgerDisplay();

            lotDisplayPanel.Invalidate();
        }

        private void lotDisplayPanel_Paint(object sender, PaintEventArgs e)
        {
            using (var g = lotDisplayPanel.CreateGraphics())
            {
                // Clear the lot first
                g.Clear(Color.Black);

                // Redraw the lot
                for (var i = 0; i < _dealership.GetCurrentInventory().Count; i++)
                {
                    var car = _dealership.GetCurrentInventory()[i];

                    var x = 10 + 50 * i;
                    var y = 10;

                    g.DrawRectangle(Pens.White, x, y, 25, 25);
                    g.DrawString($"{car.WeeksInInventory}", SystemFonts.DefaultFont, Brushes.White, x + 8, y + 5);
                }
            }
        }

        private void UpdateLedgerDisplay()
        {
            ledgerTextBox.AppendText($"Week {weekNumberTextBox.Text}\n");

            foreach (var entry in _dealership.GetLedger().GetEntries().Where(x => x.WeekNumber == Int32.Parse(weekNumberTextBox.Text)))
            {
                var color = entry.Direction == SimEngine.Ledger.EntryDirection.CREDIT ? Color.Green : Color.OrangeRed;
                ledgerTextBox.SelectionColor = color;
                ledgerTextBox.AppendText($"{entry}\n");
            }

            ledgerTextBox.AppendText("\n");
            ledgerTextBox.ScrollToCaret();
        }

        private void UpdateDealershipDisplayValues(WeeklyResult weeklyResult)
        {
            currentCashTextBox.Text = $"{weeklyResult.CashOnHand}";
            currentInventoryTextBox.Text = $"{_dealership.GetCurrentInventory().Count}";
            currentCashLockedTextbox.Text = $"{weeklyResult.CashLockedUp}";
            currentTotalAssetsTextbox.Text = $"{weeklyResult.TotalAssets}";
            totalPersonalBurnTextbox.Text = $"{Int32.Parse(weekNumberTextBox.Text) * _dealership.GetParameters().WeeklyPersonalExpenses}";
            cashPlusAssetsTextBox.Text = $"{weeklyResult.CashOnHand + weeklyResult.TotalAssets}";
        }

        private void plotButton_Click(object sender, EventArgs e)
        {
            // TODO: Validate input
            var numberOfWeeks = Int32.Parse(numberOfWeeksTextbox.Text);
            var numberOfSimulations = Int32.Parse(numberOfSimulationsTextBox.Text);

            // Update "Plot" button
            plotButton.Enabled = false;
            var originalPlotButtonText = plotButton.Text;
            var originalPlotButtonColor = plotButton.BackColor;
            plotButton.Text = "Simulating...";
            plotButton.BackColor = Color.Yellow;
            plotButton.Update();

            // Initialize chart
            dealershipChart.Series.Clear();

            // Simulate and plot
            for (var simulationNumber = 1; simulationNumber <= numberOfSimulations; simulationNumber++)
            {
                // Initialize chart control series
                var cashOnHandSeries = dealershipChart.Series.Add($"Cash {simulationNumber}");
                var totalAssetsSeries = dealershipChart.Series.Add($"Assets {simulationNumber}");
                cashOnHandSeries.Color = Color.Blue;
                totalAssetsSeries.Color = Color.Green;
                cashOnHandSeries.ChartType = SeriesChartType.Line;
                totalAssetsSeries.ChartType = SeriesChartType.Line;

                // Initialize dealership
                var dealership = GetDealership();

                // Simulate each week
                for (var weekNumber = 1; weekNumber <= numberOfWeeks; weekNumber++)
                {
                    // Simulate
                    var result = dealership.Crank(weekNumber);

                    // Plot
                    cashOnHandSeries.Points.AddXY(weekNumber, result.CashOnHand);
                    totalAssetsSeries.Points.AddXY(weekNumber, result.TotalAssets);
                }

                // Slow down a bit to help with randomness
                Thread.Sleep(SIMULATION_RANDOMNESS_DELAY);
            }

            // Update "Plot" button
            plotButton.Text = originalPlotButtonText;
            plotButton.BackColor = originalPlotButtonColor;
            plotButton.Enabled = true;
            plotButton.Update();
        }

        private IDealership GetDealership()
        {
            var dealershipParams = new DealershipParameters
            {
                StartingCash = Int32.Parse(startingCashTextBox.Text),
                SaleProfitLow = Int32.Parse(profitLowTextBox.Text),
                SaleProfitHigh = Int32.Parse(profitHighTextBox.Text),
                WeeklyPersonalExpenses = Int32.Parse(personalExpensesTextBox.Text),
                WeeksForCarToSellLow = Int32.Parse(weeksToSellLowTextBox.Text),
                WeeksForCarToSellHigh = Int32.Parse(weeksToSellHighTextBox.Text)
            };

            var auctionParams = new AuctionParameters
            {
                NumberOfWinningBidsLow = Int32.Parse(winningBidsLowTextBox.Text),
                NumberOfWinningBidsHigh = Int32.Parse(winningBidsHighTextBox.Text),
                TotalPurchasePriceLow = Int32.Parse(lowWinningBidAmountTextBox.Text),
                TotalPurchasePriceHigh = Int32.Parse(highWinningBidAmountTextBox.Text),
                MaxInventory = Int32.Parse(maxInventoryTextBox.Text)
            };

            var auctionHouse = new TypicalAuctionHouse(auctionParams);
            return new TypicalDealership(dealershipParams, auctionHouse);
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
            weeksToSellLowTextBox.Enabled = false;
            weeksToSellHighTextBox.Enabled = false;
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
            currentCashLockedTextbox.Text = "";
            currentTotalAssetsTextbox.Text = "";
            totalPersonalBurnTextbox.Text = "";
            cashPlusAssetsTextBox.Text = "";
            ledgerTextBox.Text = "";

            // Enable text boxes
            startingCashTextBox.Enabled = true;
            maxInventoryTextBox.Enabled = true;
            profitLowTextBox.Enabled = true;
            profitHighTextBox.Enabled = true;
            winningBidsLowTextBox.Enabled = true;
            winningBidsHighTextBox.Enabled = true;
            lowWinningBidAmountTextBox.Enabled = true;
            highWinningBidAmountTextBox.Enabled = true;
            weeksToSellLowTextBox.Enabled = true;
            weeksToSellHighTextBox.Enabled = true;
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
            weeksToSellLowTextBox.Text = $"{WEEKS_FOR_CAR_TO_SELL_LOW}";
            weeksToSellHighTextBox.Text = $"{WEEKS_FOR_CAR_TO_SELL_HIGH}";
            personalExpensesTextBox.Text = $"{WEEKLY_PERSONAL_EXPENSES}";
        }
    }
}