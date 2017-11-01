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
            this.currentCashLabel = new System.Windows.Forms.Label();
            this.currentCashTextBox = new System.Windows.Forms.TextBox();
            this.nextWeekButton = new System.Windows.Forms.Button();
            this.weekNumberTextBox = new System.Windows.Forms.TextBox();
            this.weekNumberLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.personalExpensesTextBox = new System.Windows.Forms.TextBox();
            this.personalExpensesLabel = new System.Windows.Forms.Label();
            this.weeksToSellTextBox = new System.Windows.Forms.TextBox();
            this.weeksToSellLabel = new System.Windows.Forms.Label();
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
            this.startButton = new System.Windows.Forms.Button();
            this.startingCashTextBox = new System.Windows.Forms.TextBox();
            this.startingCashLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.currentInventoryTextBox = new System.Windows.Forms.TextBox();
            this.currentInventoryLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ledgerTextBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // currentCashLabel
            // 
            this.currentCashLabel.AutoSize = true;
            this.currentCashLabel.Location = new System.Drawing.Point(145, 22);
            this.currentCashLabel.Name = "currentCashLabel";
            this.currentCashLabel.Size = new System.Drawing.Size(145, 17);
            this.currentCashLabel.TabIndex = 3;
            this.currentCashLabel.Text = "Current cash on hand";
            // 
            // currentCashTextBox
            // 
            this.currentCashTextBox.Location = new System.Drawing.Point(296, 19);
            this.currentCashTextBox.Name = "currentCashTextBox";
            this.currentCashTextBox.ReadOnly = true;
            this.currentCashTextBox.Size = new System.Drawing.Size(100, 22);
            this.currentCashTextBox.TabIndex = 4;
            // 
            // nextWeekButton
            // 
            this.nextWeekButton.BackColor = System.Drawing.Color.Green;
            this.nextWeekButton.Enabled = false;
            this.nextWeekButton.Location = new System.Drawing.Point(18, 59);
            this.nextWeekButton.Name = "nextWeekButton";
            this.nextWeekButton.Size = new System.Drawing.Size(88, 38);
            this.nextWeekButton.TabIndex = 5;
            this.nextWeekButton.Text = "Next";
            this.nextWeekButton.UseVisualStyleBackColor = false;
            this.nextWeekButton.Click += new System.EventHandler(this.nextWeekButton_Click);
            // 
            // weekNumberTextBox
            // 
            this.weekNumberTextBox.Location = new System.Drawing.Point(65, 19);
            this.weekNumberTextBox.Name = "weekNumberTextBox";
            this.weekNumberTextBox.ReadOnly = true;
            this.weekNumberTextBox.Size = new System.Drawing.Size(49, 22);
            this.weekNumberTextBox.TabIndex = 7;
            // 
            // weekNumberLabel
            // 
            this.weekNumberLabel.AutoSize = true;
            this.weekNumberLabel.Location = new System.Drawing.Point(15, 22);
            this.weekNumberLabel.Name = "weekNumberLabel";
            this.weekNumberLabel.Size = new System.Drawing.Size(44, 17);
            this.weekNumberLabel.TabIndex = 6;
            this.weekNumberLabel.Text = "Week";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.personalExpensesTextBox);
            this.panel1.Controls.Add(this.personalExpensesLabel);
            this.panel1.Controls.Add(this.weeksToSellTextBox);
            this.panel1.Controls.Add(this.weeksToSellLabel);
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
            this.panel1.Controls.Add(this.startButton);
            this.panel1.Controls.Add(this.startingCashTextBox);
            this.panel1.Controls.Add(this.startingCashLabel);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(967, 198);
            this.panel1.TabIndex = 26;
            // 
            // personalExpensesTextBox
            // 
            this.personalExpensesTextBox.Location = new System.Drawing.Point(345, 105);
            this.personalExpensesTextBox.Name = "personalExpensesTextBox";
            this.personalExpensesTextBox.Size = new System.Drawing.Size(100, 22);
            this.personalExpensesTextBox.TabIndex = 46;
            // 
            // personalExpensesLabel
            // 
            this.personalExpensesLabel.AutoSize = true;
            this.personalExpensesLabel.Location = new System.Drawing.Point(248, 108);
            this.personalExpensesLabel.Name = "personalExpensesLabel";
            this.personalExpensesLabel.Size = new System.Drawing.Size(76, 17);
            this.personalExpensesLabel.TabIndex = 45;
            this.personalExpensesLabel.Text = "Personal $";
            // 
            // weeksToSellTextBox
            // 
            this.weeksToSellTextBox.Location = new System.Drawing.Point(112, 105);
            this.weeksToSellTextBox.Name = "weeksToSellTextBox";
            this.weeksToSellTextBox.Size = new System.Drawing.Size(100, 22);
            this.weeksToSellTextBox.TabIndex = 44;
            // 
            // weeksToSellLabel
            // 
            this.weeksToSellLabel.AutoSize = true;
            this.weeksToSellLabel.Location = new System.Drawing.Point(15, 108);
            this.weeksToSellLabel.Name = "weeksToSellLabel";
            this.weeksToSellLabel.Size = new System.Drawing.Size(92, 17);
            this.weeksToSellLabel.TabIndex = 43;
            this.weeksToSellLabel.Text = "Weeks to sell";
            // 
            // highWinningBidAmountTextBox
            // 
            this.highWinningBidAmountTextBox.Location = new System.Drawing.Point(817, 61);
            this.highWinningBidAmountTextBox.Name = "highWinningBidAmountTextBox";
            this.highWinningBidAmountTextBox.Size = new System.Drawing.Size(100, 22);
            this.highWinningBidAmountTextBox.TabIndex = 42;
            // 
            // highWinningBidAmountLabel
            // 
            this.highWinningBidAmountLabel.AutoSize = true;
            this.highWinningBidAmountLabel.Location = new System.Drawing.Point(720, 64);
            this.highWinningBidAmountLabel.Name = "highWinningBidAmountLabel";
            this.highWinningBidAmountLabel.Size = new System.Drawing.Size(96, 17);
            this.highWinningBidAmountLabel.TabIndex = 41;
            this.highWinningBidAmountLabel.Text = "High win bid $";
            // 
            // lowWinningBidAmountTextBox
            // 
            this.lowWinningBidAmountTextBox.Location = new System.Drawing.Point(584, 61);
            this.lowWinningBidAmountTextBox.Name = "lowWinningBidAmountTextBox";
            this.lowWinningBidAmountTextBox.Size = new System.Drawing.Size(100, 22);
            this.lowWinningBidAmountTextBox.TabIndex = 40;
            // 
            // lowWinningBidAmountLabel
            // 
            this.lowWinningBidAmountLabel.AutoSize = true;
            this.lowWinningBidAmountLabel.Location = new System.Drawing.Point(487, 64);
            this.lowWinningBidAmountLabel.Name = "lowWinningBidAmountLabel";
            this.lowWinningBidAmountLabel.Size = new System.Drawing.Size(92, 17);
            this.lowWinningBidAmountLabel.TabIndex = 39;
            this.lowWinningBidAmountLabel.Text = "Low win bid $";
            // 
            // profitHighTextBox
            // 
            this.profitHighTextBox.Location = new System.Drawing.Point(817, 20);
            this.profitHighTextBox.Name = "profitHighTextBox";
            this.profitHighTextBox.Size = new System.Drawing.Size(100, 22);
            this.profitHighTextBox.TabIndex = 38;
            // 
            // profitHighLabel
            // 
            this.profitHighLabel.AutoSize = true;
            this.profitHighLabel.Location = new System.Drawing.Point(720, 23);
            this.profitHighLabel.Name = "profitHighLabel";
            this.profitHighLabel.Size = new System.Drawing.Size(72, 17);
            this.profitHighLabel.TabIndex = 37;
            this.profitHighLabel.Text = "Profit high";
            // 
            // profitLowTextBox
            // 
            this.profitLowTextBox.Location = new System.Drawing.Point(584, 20);
            this.profitLowTextBox.Name = "profitLowTextBox";
            this.profitLowTextBox.Size = new System.Drawing.Size(100, 22);
            this.profitLowTextBox.TabIndex = 36;
            // 
            // profitLowLabel
            // 
            this.profitLowLabel.AutoSize = true;
            this.profitLowLabel.Location = new System.Drawing.Point(487, 23);
            this.profitLowLabel.Name = "profitLowLabel";
            this.profitLowLabel.Size = new System.Drawing.Size(65, 17);
            this.profitLowLabel.TabIndex = 35;
            this.profitLowLabel.Text = "Profit low";
            // 
            // winningBidsHighTextBox
            // 
            this.winningBidsHighTextBox.Location = new System.Drawing.Point(345, 61);
            this.winningBidsHighTextBox.Name = "winningBidsHighTextBox";
            this.winningBidsHighTextBox.Size = new System.Drawing.Size(100, 22);
            this.winningBidsHighTextBox.TabIndex = 34;
            // 
            // winningBidsHighLabel
            // 
            this.winningBidsHighLabel.AutoSize = true;
            this.winningBidsHighLabel.Location = new System.Drawing.Point(248, 64);
            this.winningBidsHighLabel.Name = "winningBidsHighLabel";
            this.winningBidsHighLabel.Size = new System.Drawing.Size(94, 17);
            this.winningBidsHighLabel.TabIndex = 33;
            this.winningBidsHighLabel.Text = "# win bid high";
            // 
            // winningBidsLowTextBox
            // 
            this.winningBidsLowTextBox.Location = new System.Drawing.Point(112, 61);
            this.winningBidsLowTextBox.Name = "winningBidsLowTextBox";
            this.winningBidsLowTextBox.Size = new System.Drawing.Size(100, 22);
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
            this.maxInventoryTextBox.Location = new System.Drawing.Point(345, 20);
            this.maxInventoryTextBox.Name = "maxInventoryTextBox";
            this.maxInventoryTextBox.Size = new System.Drawing.Size(100, 22);
            this.maxInventoryTextBox.TabIndex = 30;
            // 
            // maxInventoryLabel
            // 
            this.maxInventoryLabel.AutoSize = true;
            this.maxInventoryLabel.Location = new System.Drawing.Point(248, 23);
            this.maxInventoryLabel.Name = "maxInventoryLabel";
            this.maxInventoryLabel.Size = new System.Drawing.Size(95, 17);
            this.maxInventoryLabel.TabIndex = 29;
            this.maxInventoryLabel.Text = "Max inventory";
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.Green;
            this.startButton.Location = new System.Drawing.Point(18, 145);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(88, 38);
            this.startButton.TabIndex = 28;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // startingCashTextBox
            // 
            this.startingCashTextBox.Location = new System.Drawing.Point(112, 20);
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
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.currentInventoryTextBox);
            this.panel2.Controls.Add(this.currentInventoryLabel);
            this.panel2.Controls.Add(this.nextWeekButton);
            this.panel2.Controls.Add(this.weekNumberTextBox);
            this.panel2.Controls.Add(this.currentCashLabel);
            this.panel2.Controls.Add(this.weekNumberLabel);
            this.panel2.Controls.Add(this.currentCashTextBox);
            this.panel2.Location = new System.Drawing.Point(12, 216);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(967, 288);
            this.panel2.TabIndex = 47;
            // 
            // currentInventoryTextBox
            // 
            this.currentInventoryTextBox.Location = new System.Drawing.Point(554, 19);
            this.currentInventoryTextBox.Name = "currentInventoryTextBox";
            this.currentInventoryTextBox.ReadOnly = true;
            this.currentInventoryTextBox.Size = new System.Drawing.Size(49, 22);
            this.currentInventoryTextBox.TabIndex = 9;
            // 
            // currentInventoryLabel
            // 
            this.currentInventoryLabel.AutoSize = true;
            this.currentInventoryLabel.Location = new System.Drawing.Point(431, 22);
            this.currentInventoryLabel.Name = "currentInventoryLabel";
            this.currentInventoryLabel.Size = new System.Drawing.Size(117, 17);
            this.currentInventoryLabel.TabIndex = 8;
            this.currentInventoryLabel.Text = "Current inventory";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(12, 510);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(488, 176);
            this.panel3.TabIndex = 48;
            // 
            // ledgerTextBox
            // 
            this.ledgerTextBox.Location = new System.Drawing.Point(506, 510);
            this.ledgerTextBox.Multiline = true;
            this.ledgerTextBox.Name = "ledgerTextBox";
            this.ledgerTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ledgerTextBox.Size = new System.Drawing.Size(473, 176);
            this.ledgerTextBox.TabIndex = 49;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 698);
            this.Controls.Add(this.ledgerTextBox);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MainWindow";
            this.Text = "Car Sales Simulator";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.TextBox weeksToSellTextBox;
        private System.Windows.Forms.Label weeksToSellLabel;
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
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox ledgerTextBox;
    }
}