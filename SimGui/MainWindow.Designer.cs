namespace SimGui
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.currentCashLabel = new System.Windows.Forms.Label();
            this.currentCashTextBox = new System.Windows.Forms.TextBox();
            this.nextWeekButton = new System.Windows.Forms.Button();
            this.weekNumberTextBox = new System.Windows.Forms.TextBox();
            this.weekNumberLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.weeksToSellHighTextBox = new System.Windows.Forms.TextBox();
            this.weeksToSellHighLabel = new System.Windows.Forms.Label();
            this.personalExpensesTextBox = new System.Windows.Forms.TextBox();
            this.personalExpensesLabel = new System.Windows.Forms.Label();
            this.weeksToSellLowTextBox = new System.Windows.Forms.TextBox();
            this.weeksToSellLowLabel = new System.Windows.Forms.Label();
            this.highWinningBidAmountTextBox = new System.Windows.Forms.TextBox();
            this.highWinningBidAmountLabel = new System.Windows.Forms.Label();
            this.lowWinningBidAmountTextBox = new System.Windows.Forms.TextBox();
            this.lowWinningBidAmountLabel = new System.Windows.Forms.Label();
            this.profitHighTextBox = new System.Windows.Forms.TextBox();
            this.profitHighLabel = new System.Windows.Forms.Label();
            this.profitLowTextBox = new System.Windows.Forms.TextBox();
            this.profitLowLabel = new System.Windows.Forms.Label();
            this.winningBidsHighTextBox = new System.Windows.Forms.TextBox();
            this.winningBidsHighLabel = new System.Windows.Forms.Label();
            this.winningBidsLowTextBox = new System.Windows.Forms.TextBox();
            this.winningBidsLowLabel = new System.Windows.Forms.Label();
            this.maxInventoryTextBox = new System.Windows.Forms.TextBox();
            this.maxInventoryLabel = new System.Windows.Forms.Label();
            this.startingCashTextBox = new System.Windows.Forms.TextBox();
            this.startingCashLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cashPlusAssetsLabel = new System.Windows.Forms.Label();
            this.cashPlusAssetsTextBox = new System.Windows.Forms.TextBox();
            this.totalPersonalBurnLabel = new System.Windows.Forms.Label();
            this.totalPersonalBurnTextbox = new System.Windows.Forms.TextBox();
            this.currentCashLockedTextbox = new System.Windows.Forms.TextBox();
            this.currentTotalAssetsLabel = new System.Windows.Forms.Label();
            this.currentTotalAssetsTextbox = new System.Windows.Forms.TextBox();
            this.currentCashLockedLabel = new System.Windows.Forms.Label();
            this.currentInventoryTextBox = new System.Windows.Forms.TextBox();
            this.currentInventoryLabel = new System.Windows.Forms.Label();
            this.lotDisplayPanel = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ledgerTextBox = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.numberOfSimulationsTextBox = new System.Windows.Forms.TextBox();
            this.numberOfSimulationsLabel = new System.Windows.Forms.Label();
            this.numberOfWeeksTextbox = new System.Windows.Forms.TextBox();
            this.dealershipChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.numberOfWeeksLabel = new System.Windows.Forms.Label();
            this.plotButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dealershipChart)).BeginInit();
            this.SuspendLayout();
            // 
            // currentCashLabel
            // 
            this.currentCashLabel.AutoSize = true;
            this.currentCashLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentCashLabel.Location = new System.Drawing.Point(248, 22);
            this.currentCashLabel.Name = "currentCashLabel";
            this.currentCashLabel.Size = new System.Drawing.Size(165, 17);
            this.currentCashLabel.TabIndex = 3;
            this.currentCashLabel.Text = "Current cash on hand";
            // 
            // currentCashTextBox
            // 
            this.currentCashTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentCashTextBox.Location = new System.Drawing.Point(423, 19);
            this.currentCashTextBox.Name = "currentCashTextBox";
            this.currentCashTextBox.ReadOnly = true;
            this.currentCashTextBox.Size = new System.Drawing.Size(88, 22);
            this.currentCashTextBox.TabIndex = 4;
            // 
            // nextWeekButton
            // 
            this.nextWeekButton.BackColor = System.Drawing.Color.Green;
            this.nextWeekButton.Enabled = false;
            this.nextWeekButton.Location = new System.Drawing.Point(117, 80);
            this.nextWeekButton.Name = "nextWeekButton";
            this.nextWeekButton.Size = new System.Drawing.Size(88, 38);
            this.nextWeekButton.TabIndex = 5;
            this.nextWeekButton.Text = "Next";
            this.nextWeekButton.UseVisualStyleBackColor = false;
            this.nextWeekButton.Click += new System.EventHandler(this.nextWeekButton_Click);
            // 
            // weekNumberTextBox
            // 
            this.weekNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weekNumberTextBox.Location = new System.Drawing.Point(86, 19);
            this.weekNumberTextBox.Name = "weekNumberTextBox";
            this.weekNumberTextBox.ReadOnly = true;
            this.weekNumberTextBox.Size = new System.Drawing.Size(46, 22);
            this.weekNumberTextBox.TabIndex = 7;
            // 
            // weekNumberLabel
            // 
            this.weekNumberLabel.AutoSize = true;
            this.weekNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weekNumberLabel.Location = new System.Drawing.Point(15, 22);
            this.weekNumberLabel.Name = "weekNumberLabel";
            this.weekNumberLabel.Size = new System.Drawing.Size(62, 17);
            this.weekNumberLabel.TabIndex = 6;
            this.weekNumberLabel.Text = "Week #";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.weeksToSellHighTextBox);
            this.panel1.Controls.Add(this.weeksToSellHighLabel);
            this.panel1.Controls.Add(this.personalExpensesTextBox);
            this.panel1.Controls.Add(this.personalExpensesLabel);
            this.panel1.Controls.Add(this.weeksToSellLowTextBox);
            this.panel1.Controls.Add(this.weeksToSellLowLabel);
            this.panel1.Controls.Add(this.highWinningBidAmountTextBox);
            this.panel1.Controls.Add(this.highWinningBidAmountLabel);
            this.panel1.Controls.Add(this.lowWinningBidAmountTextBox);
            this.panel1.Controls.Add(this.lowWinningBidAmountLabel);
            this.panel1.Controls.Add(this.profitHighTextBox);
            this.panel1.Controls.Add(this.profitHighLabel);
            this.panel1.Controls.Add(this.profitLowTextBox);
            this.panel1.Controls.Add(this.profitLowLabel);
            this.panel1.Controls.Add(this.winningBidsHighTextBox);
            this.panel1.Controls.Add(this.winningBidsHighLabel);
            this.panel1.Controls.Add(this.winningBidsLowTextBox);
            this.panel1.Controls.Add(this.winningBidsLowLabel);
            this.panel1.Controls.Add(this.maxInventoryTextBox);
            this.panel1.Controls.Add(this.maxInventoryLabel);
            this.panel1.Controls.Add(this.startingCashTextBox);
            this.panel1.Controls.Add(this.startingCashLabel);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(967, 148);
            this.panel1.TabIndex = 26;
            // 
            // weeksToSellHighTextBox
            // 
            this.weeksToSellHighTextBox.Location = new System.Drawing.Point(395, 105);
            this.weeksToSellHighTextBox.Name = "weeksToSellHighTextBox";
            this.weeksToSellHighTextBox.Size = new System.Drawing.Size(46, 22);
            this.weeksToSellHighTextBox.TabIndex = 48;
            // 
            // weeksToSellHighLabel
            // 
            this.weeksToSellHighLabel.AutoSize = true;
            this.weeksToSellHighLabel.Location = new System.Drawing.Point(267, 108);
            this.weeksToSellHighLabel.Name = "weeksToSellHighLabel";
            this.weeksToSellHighLabel.Size = new System.Drawing.Size(112, 17);
            this.weeksToSellHighLabel.TabIndex = 47;
            this.weeksToSellHighLabel.Text = "Weeks/sale high";
            // 
            // personalExpensesTextBox
            // 
            this.personalExpensesTextBox.Location = new System.Drawing.Point(614, 105);
            this.personalExpensesTextBox.Name = "personalExpensesTextBox";
            this.personalExpensesTextBox.Size = new System.Drawing.Size(100, 22);
            this.personalExpensesTextBox.TabIndex = 46;
            // 
            // personalExpensesLabel
            // 
            this.personalExpensesLabel.AutoSize = true;
            this.personalExpensesLabel.Location = new System.Drawing.Point(498, 108);
            this.personalExpensesLabel.Name = "personalExpensesLabel";
            this.personalExpensesLabel.Size = new System.Drawing.Size(109, 17);
            this.personalExpensesLabel.TabIndex = 45;
            this.personalExpensesLabel.Text = "Personal burn $";
            // 
            // weeksToSellLowTextBox
            // 
            this.weeksToSellLowTextBox.Location = new System.Drawing.Point(133, 105);
            this.weeksToSellLowTextBox.Name = "weeksToSellLowTextBox";
            this.weeksToSellLowTextBox.Size = new System.Drawing.Size(46, 22);
            this.weeksToSellLowTextBox.TabIndex = 44;
            // 
            // weeksToSellLowLabel
            // 
            this.weeksToSellLowLabel.AutoSize = true;
            this.weeksToSellLowLabel.Location = new System.Drawing.Point(15, 108);
            this.weeksToSellLowLabel.Name = "weeksToSellLowLabel";
            this.weeksToSellLowLabel.Size = new System.Drawing.Size(105, 17);
            this.weeksToSellLowLabel.TabIndex = 43;
            this.weeksToSellLowLabel.Text = "Weeks/sale low";
            // 
            // highWinningBidAmountTextBox
            // 
            this.highWinningBidAmountTextBox.Location = new System.Drawing.Point(837, 61);
            this.highWinningBidAmountTextBox.Name = "highWinningBidAmountTextBox";
            this.highWinningBidAmountTextBox.Size = new System.Drawing.Size(100, 22);
            this.highWinningBidAmountTextBox.TabIndex = 42;
            // 
            // highWinningBidAmountLabel
            // 
            this.highWinningBidAmountLabel.AutoSize = true;
            this.highWinningBidAmountLabel.Location = new System.Drawing.Point(740, 64);
            this.highWinningBidAmountLabel.Name = "highWinningBidAmountLabel";
            this.highWinningBidAmountLabel.Size = new System.Drawing.Size(96, 17);
            this.highWinningBidAmountLabel.TabIndex = 41;
            this.highWinningBidAmountLabel.Text = "High win bid $";
            // 
            // lowWinningBidAmountTextBox
            // 
            this.lowWinningBidAmountTextBox.Location = new System.Drawing.Point(614, 61);
            this.lowWinningBidAmountTextBox.Name = "lowWinningBidAmountTextBox";
            this.lowWinningBidAmountTextBox.Size = new System.Drawing.Size(100, 22);
            this.lowWinningBidAmountTextBox.TabIndex = 40;
            // 
            // lowWinningBidAmountLabel
            // 
            this.lowWinningBidAmountLabel.AutoSize = true;
            this.lowWinningBidAmountLabel.Location = new System.Drawing.Point(498, 64);
            this.lowWinningBidAmountLabel.Name = "lowWinningBidAmountLabel";
            this.lowWinningBidAmountLabel.Size = new System.Drawing.Size(92, 17);
            this.lowWinningBidAmountLabel.TabIndex = 39;
            this.lowWinningBidAmountLabel.Text = "Low win bid $";
            // 
            // profitHighTextBox
            // 
            this.profitHighTextBox.Location = new System.Drawing.Point(837, 20);
            this.profitHighTextBox.Name = "profitHighTextBox";
            this.profitHighTextBox.Size = new System.Drawing.Size(100, 22);
            this.profitHighTextBox.TabIndex = 38;
            // 
            // profitHighLabel
            // 
            this.profitHighLabel.AutoSize = true;
            this.profitHighLabel.Location = new System.Drawing.Point(740, 23);
            this.profitHighLabel.Name = "profitHighLabel";
            this.profitHighLabel.Size = new System.Drawing.Size(72, 17);
            this.profitHighLabel.TabIndex = 37;
            this.profitHighLabel.Text = "Profit high";
            // 
            // profitLowTextBox
            // 
            this.profitLowTextBox.Location = new System.Drawing.Point(614, 20);
            this.profitLowTextBox.Name = "profitLowTextBox";
            this.profitLowTextBox.Size = new System.Drawing.Size(100, 22);
            this.profitLowTextBox.TabIndex = 36;
            // 
            // profitLowLabel
            // 
            this.profitLowLabel.AutoSize = true;
            this.profitLowLabel.Location = new System.Drawing.Point(498, 23);
            this.profitLowLabel.Name = "profitLowLabel";
            this.profitLowLabel.Size = new System.Drawing.Size(65, 17);
            this.profitLowLabel.TabIndex = 35;
            this.profitLowLabel.Text = "Profit low";
            // 
            // winningBidsHighTextBox
            // 
            this.winningBidsHighTextBox.Location = new System.Drawing.Point(394, 61);
            this.winningBidsHighTextBox.Name = "winningBidsHighTextBox";
            this.winningBidsHighTextBox.Size = new System.Drawing.Size(47, 22);
            this.winningBidsHighTextBox.TabIndex = 34;
            // 
            // winningBidsHighLabel
            // 
            this.winningBidsHighLabel.AutoSize = true;
            this.winningBidsHighLabel.Location = new System.Drawing.Point(267, 64);
            this.winningBidsHighLabel.Name = "winningBidsHighLabel";
            this.winningBidsHighLabel.Size = new System.Drawing.Size(94, 17);
            this.winningBidsHighLabel.TabIndex = 33;
            this.winningBidsHighLabel.Text = "# win bid high";
            // 
            // winningBidsLowTextBox
            // 
            this.winningBidsLowTextBox.Location = new System.Drawing.Point(133, 61);
            this.winningBidsLowTextBox.Name = "winningBidsLowTextBox";
            this.winningBidsLowTextBox.Size = new System.Drawing.Size(46, 22);
            this.winningBidsLowTextBox.TabIndex = 32;
            // 
            // winningBidsLowLabel
            // 
            this.winningBidsLowLabel.AutoSize = true;
            this.winningBidsLowLabel.Location = new System.Drawing.Point(15, 64);
            this.winningBidsLowLabel.Name = "winningBidsLowLabel";
            this.winningBidsLowLabel.Size = new System.Drawing.Size(87, 17);
            this.winningBidsLowLabel.TabIndex = 31;
            this.winningBidsLowLabel.Text = "# win bid low";
            // 
            // maxInventoryTextBox
            // 
            this.maxInventoryTextBox.Location = new System.Drawing.Point(394, 20);
            this.maxInventoryTextBox.Name = "maxInventoryTextBox";
            this.maxInventoryTextBox.Size = new System.Drawing.Size(47, 22);
            this.maxInventoryTextBox.TabIndex = 30;
            // 
            // maxInventoryLabel
            // 
            this.maxInventoryLabel.AutoSize = true;
            this.maxInventoryLabel.Location = new System.Drawing.Point(267, 23);
            this.maxInventoryLabel.Name = "maxInventoryLabel";
            this.maxInventoryLabel.Size = new System.Drawing.Size(95, 17);
            this.maxInventoryLabel.TabIndex = 29;
            this.maxInventoryLabel.Text = "Max inventory";
            // 
            // startingCashTextBox
            // 
            this.startingCashTextBox.Location = new System.Drawing.Point(133, 20);
            this.startingCashTextBox.Name = "startingCashTextBox";
            this.startingCashTextBox.Size = new System.Drawing.Size(100, 22);
            this.startingCashTextBox.TabIndex = 27;
            // 
            // startingCashLabel
            // 
            this.startingCashLabel.AutoSize = true;
            this.startingCashLabel.Location = new System.Drawing.Point(15, 23);
            this.startingCashLabel.Name = "startingCashLabel";
            this.startingCashLabel.Size = new System.Drawing.Size(91, 17);
            this.startingCashLabel.TabIndex = 26;
            this.startingCashLabel.Text = "Starting cash";
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.Green;
            this.startButton.Location = new System.Drawing.Point(11, 80);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(88, 38);
            this.startButton.TabIndex = 28;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cashPlusAssetsLabel);
            this.panel2.Controls.Add(this.cashPlusAssetsTextBox);
            this.panel2.Controls.Add(this.totalPersonalBurnLabel);
            this.panel2.Controls.Add(this.totalPersonalBurnTextbox);
            this.panel2.Controls.Add(this.currentCashLockedTextbox);
            this.panel2.Controls.Add(this.currentTotalAssetsLabel);
            this.panel2.Controls.Add(this.currentTotalAssetsTextbox);
            this.panel2.Controls.Add(this.currentCashLockedLabel);
            this.panel2.Controls.Add(this.currentInventoryTextBox);
            this.panel2.Controls.Add(this.currentInventoryLabel);
            this.panel2.Controls.Add(this.nextWeekButton);
            this.panel2.Controls.Add(this.weekNumberTextBox);
            this.panel2.Controls.Add(this.currentCashLabel);
            this.panel2.Controls.Add(this.weekNumberLabel);
            this.panel2.Controls.Add(this.currentCashTextBox);
            this.panel2.Controls.Add(this.startButton);
            this.panel2.Location = new System.Drawing.Point(6, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(947, 166);
            this.panel2.TabIndex = 47;
            // 
            // cashPlusAssetsLabel
            // 
            this.cashPlusAssetsLabel.AutoSize = true;
            this.cashPlusAssetsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashPlusAssetsLabel.Location = new System.Drawing.Point(550, 128);
            this.cashPlusAssetsLabel.Name = "cashPlusAssetsLabel";
            this.cashPlusAssetsLabel.Size = new System.Drawing.Size(110, 17);
            this.cashPlusAssetsLabel.TabIndex = 19;
            this.cashPlusAssetsLabel.Text = "Cash + assets";
            // 
            // cashPlusAssetsTextBox
            // 
            this.cashPlusAssetsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashPlusAssetsTextBox.Location = new System.Drawing.Point(701, 125);
            this.cashPlusAssetsTextBox.Name = "cashPlusAssetsTextBox";
            this.cashPlusAssetsTextBox.ReadOnly = true;
            this.cashPlusAssetsTextBox.Size = new System.Drawing.Size(88, 22);
            this.cashPlusAssetsTextBox.TabIndex = 18;
            // 
            // totalPersonalBurnLabel
            // 
            this.totalPersonalBurnLabel.AutoSize = true;
            this.totalPersonalBurnLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPersonalBurnLabel.Location = new System.Drawing.Point(550, 22);
            this.totalPersonalBurnLabel.Name = "totalPersonalBurnLabel";
            this.totalPersonalBurnLabel.Size = new System.Drawing.Size(144, 17);
            this.totalPersonalBurnLabel.TabIndex = 16;
            this.totalPersonalBurnLabel.Text = "Total personal burn $";
            // 
            // totalPersonalBurnTextbox
            // 
            this.totalPersonalBurnTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPersonalBurnTextbox.Location = new System.Drawing.Point(701, 19);
            this.totalPersonalBurnTextbox.Name = "totalPersonalBurnTextbox";
            this.totalPersonalBurnTextbox.ReadOnly = true;
            this.totalPersonalBurnTextbox.Size = new System.Drawing.Size(88, 22);
            this.totalPersonalBurnTextbox.TabIndex = 17;
            // 
            // currentCashLockedTextbox
            // 
            this.currentCashLockedTextbox.Location = new System.Drawing.Point(423, 88);
            this.currentCashLockedTextbox.Name = "currentCashLockedTextbox";
            this.currentCashLockedTextbox.ReadOnly = true;
            this.currentCashLockedTextbox.Size = new System.Drawing.Size(88, 22);
            this.currentCashLockedTextbox.TabIndex = 15;
            // 
            // currentTotalAssetsLabel
            // 
            this.currentTotalAssetsLabel.AutoSize = true;
            this.currentTotalAssetsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentTotalAssetsLabel.Location = new System.Drawing.Point(248, 128);
            this.currentTotalAssetsLabel.Name = "currentTotalAssetsLabel";
            this.currentTotalAssetsLabel.Size = new System.Drawing.Size(151, 17);
            this.currentTotalAssetsLabel.TabIndex = 14;
            this.currentTotalAssetsLabel.Text = "Current total assets";
            // 
            // currentTotalAssetsTextbox
            // 
            this.currentTotalAssetsTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentTotalAssetsTextbox.Location = new System.Drawing.Point(423, 125);
            this.currentTotalAssetsTextbox.Name = "currentTotalAssetsTextbox";
            this.currentTotalAssetsTextbox.ReadOnly = true;
            this.currentTotalAssetsTextbox.Size = new System.Drawing.Size(88, 22);
            this.currentTotalAssetsTextbox.TabIndex = 13;
            // 
            // currentCashLockedLabel
            // 
            this.currentCashLockedLabel.AutoSize = true;
            this.currentCashLockedLabel.Location = new System.Drawing.Point(248, 91);
            this.currentCashLockedLabel.Name = "currentCashLockedLabel";
            this.currentCashLockedLabel.Size = new System.Drawing.Size(154, 17);
            this.currentCashLockedLabel.TabIndex = 12;
            this.currentCashLockedLabel.Text = "Current cash locked up";
            // 
            // currentInventoryTextBox
            // 
            this.currentInventoryTextBox.Location = new System.Drawing.Point(423, 52);
            this.currentInventoryTextBox.Name = "currentInventoryTextBox";
            this.currentInventoryTextBox.ReadOnly = true;
            this.currentInventoryTextBox.Size = new System.Drawing.Size(46, 22);
            this.currentInventoryTextBox.TabIndex = 9;
            // 
            // currentInventoryLabel
            // 
            this.currentInventoryLabel.AutoSize = true;
            this.currentInventoryLabel.Location = new System.Drawing.Point(248, 55);
            this.currentInventoryLabel.Name = "currentInventoryLabel";
            this.currentInventoryLabel.Size = new System.Drawing.Size(86, 17);
            this.currentInventoryLabel.TabIndex = 8;
            this.currentInventoryLabel.Text = "# cars on lot";
            // 
            // lotDisplayPanel
            // 
            this.lotDisplayPanel.BackColor = System.Drawing.Color.Black;
            this.lotDisplayPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lotDisplayPanel.Location = new System.Drawing.Point(6, 178);
            this.lotDisplayPanel.Name = "lotDisplayPanel";
            this.lotDisplayPanel.Size = new System.Drawing.Size(477, 271);
            this.lotDisplayPanel.TabIndex = 48;
            this.lotDisplayPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.lotDisplayPanel_Paint);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(9, 216);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(0, 0);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1363, 608);
            this.tabControl1.TabIndex = 47;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.ledgerTextBox);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.lotDisplayPanel);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1355, 579);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Interactive";
            // 
            // ledgerTextBox
            // 
            this.ledgerTextBox.BackColor = System.Drawing.Color.Black;
            this.ledgerTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ledgerTextBox.ForeColor = System.Drawing.Color.White;
            this.ledgerTextBox.Location = new System.Drawing.Point(489, 178);
            this.ledgerTextBox.Name = "ledgerTextBox";
            this.ledgerTextBox.ReadOnly = true;
            this.ledgerTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.ledgerTextBox.Size = new System.Drawing.Size(464, 271);
            this.ledgerTextBox.TabIndex = 16;
            this.ledgerTextBox.Text = "";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage2.Controls.Add(this.numberOfSimulationsTextBox);
            this.tabPage2.Controls.Add(this.numberOfSimulationsLabel);
            this.tabPage2.Controls.Add(this.numberOfWeeksTextbox);
            this.tabPage2.Controls.Add(this.dealershipChart);
            this.tabPage2.Controls.Add(this.numberOfWeeksLabel);
            this.tabPage2.Controls.Add(this.plotButton);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1355, 579);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Plot";
            // 
            // numberOfSimulationsTextBox
            // 
            this.numberOfSimulationsTextBox.Location = new System.Drawing.Point(240, 20);
            this.numberOfSimulationsTextBox.Name = "numberOfSimulationsTextBox";
            this.numberOfSimulationsTextBox.Size = new System.Drawing.Size(46, 22);
            this.numberOfSimulationsTextBox.TabIndex = 53;
            this.numberOfSimulationsTextBox.Text = "1";
            // 
            // numberOfSimulationsLabel
            // 
            this.numberOfSimulationsLabel.AutoSize = true;
            this.numberOfSimulationsLabel.Location = new System.Drawing.Point(144, 25);
            this.numberOfSimulationsLabel.Name = "numberOfSimulationsLabel";
            this.numberOfSimulationsLabel.Size = new System.Drawing.Size(90, 17);
            this.numberOfSimulationsLabel.TabIndex = 52;
            this.numberOfSimulationsLabel.Text = "# simulations";
            // 
            // numberOfWeeksTextbox
            // 
            this.numberOfWeeksTextbox.Location = new System.Drawing.Point(79, 20);
            this.numberOfWeeksTextbox.Name = "numberOfWeeksTextbox";
            this.numberOfWeeksTextbox.Size = new System.Drawing.Size(46, 22);
            this.numberOfWeeksTextbox.TabIndex = 50;
            this.numberOfWeeksTextbox.Text = "52";
            // 
            // dealershipChart
            // 
            chartArea2.Name = "ChartArea1";
            this.dealershipChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.dealershipChart.Legends.Add(legend2);
            this.dealershipChart.Location = new System.Drawing.Point(17, 78);
            this.dealershipChart.Name = "dealershipChart";
            this.dealershipChart.Size = new System.Drawing.Size(1314, 478);
            this.dealershipChart.TabIndex = 51;
            // 
            // numberOfWeeksLabel
            // 
            this.numberOfWeeksLabel.AutoSize = true;
            this.numberOfWeeksLabel.Location = new System.Drawing.Point(14, 23);
            this.numberOfWeeksLabel.Name = "numberOfWeeksLabel";
            this.numberOfWeeksLabel.Size = new System.Drawing.Size(59, 17);
            this.numberOfWeeksLabel.TabIndex = 49;
            this.numberOfWeeksLabel.Text = "# weeks";
            // 
            // plotButton
            // 
            this.plotButton.BackColor = System.Drawing.Color.Lime;
            this.plotButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plotButton.Location = new System.Drawing.Point(315, 15);
            this.plotButton.Name = "plotButton";
            this.plotButton.Size = new System.Drawing.Size(125, 36);
            this.plotButton.TabIndex = 50;
            this.plotButton.Text = "Plot";
            this.plotButton.UseVisualStyleBackColor = false;
            this.plotButton.Click += new System.EventHandler(this.plotButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1381, 876);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Car Sales Simulator";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dealershipChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label currentCashLabel;
        private System.Windows.Forms.TextBox currentCashTextBox;
        private System.Windows.Forms.Button nextWeekButton;
        private System.Windows.Forms.TextBox weekNumberTextBox;
        private System.Windows.Forms.Label weekNumberLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox personalExpensesTextBox;
        private System.Windows.Forms.Label personalExpensesLabel;
        private System.Windows.Forms.TextBox weeksToSellLowTextBox;
        private System.Windows.Forms.Label weeksToSellLowLabel;
        private System.Windows.Forms.TextBox highWinningBidAmountTextBox;
        private System.Windows.Forms.Label highWinningBidAmountLabel;
        private System.Windows.Forms.TextBox lowWinningBidAmountTextBox;
        private System.Windows.Forms.Label lowWinningBidAmountLabel;
        private System.Windows.Forms.TextBox profitHighTextBox;
        private System.Windows.Forms.Label profitHighLabel;
        private System.Windows.Forms.TextBox profitLowTextBox;
        private System.Windows.Forms.Label profitLowLabel;
        private System.Windows.Forms.TextBox winningBidsHighTextBox;
        private System.Windows.Forms.Label winningBidsHighLabel;
        private System.Windows.Forms.TextBox winningBidsLowTextBox;
        private System.Windows.Forms.Label winningBidsLowLabel;
        private System.Windows.Forms.TextBox maxInventoryTextBox;
        private System.Windows.Forms.Label maxInventoryLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.TextBox startingCashTextBox;
        private System.Windows.Forms.Label startingCashLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox currentInventoryTextBox;
        private System.Windows.Forms.Label currentInventoryLabel;
        private System.Windows.Forms.Panel lotDisplayPanel;
        private System.Windows.Forms.Label currentCashLockedLabel;
        private System.Windows.Forms.TextBox currentCashLockedTextbox;
        private System.Windows.Forms.Label currentTotalAssetsLabel;
        private System.Windows.Forms.TextBox currentTotalAssetsTextbox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox ledgerTextBox;
        private System.Windows.Forms.Label totalPersonalBurnLabel;
        private System.Windows.Forms.TextBox totalPersonalBurnTextbox;
        private System.Windows.Forms.TextBox weeksToSellHighTextBox;
        private System.Windows.Forms.Label weeksToSellHighLabel;
        private System.Windows.Forms.Label cashPlusAssetsLabel;
        private System.Windows.Forms.TextBox cashPlusAssetsTextBox;
        private System.Windows.Forms.Button plotButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart dealershipChart;
        private System.Windows.Forms.TextBox numberOfWeeksTextbox;
        private System.Windows.Forms.Label numberOfWeeksLabel;
        private System.Windows.Forms.TextBox numberOfSimulationsTextBox;
        private System.Windows.Forms.Label numberOfSimulationsLabel;
    }
}