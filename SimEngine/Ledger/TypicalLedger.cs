using System;
using System.Collections.Generic;

namespace SimEngine.Ledger
{
    public class TypicalLedger : ILedger
    {
        private readonly int _startingBalance;
        private readonly List<LedgerEntry> _ledgerEntries;

        public List<LedgerEntry> GetEntries() => _ledgerEntries;

        public TypicalLedger(int startingBalance)
        {
            _startingBalance = startingBalance;
            _ledgerEntries = new List<LedgerEntry>();
        }

        public void AddEntry(EntryDirection direction, EntryType entryType, int weekNumber, int amount)
        {
            _ledgerEntries.Add(new LedgerEntry { Direction = direction, Type = entryType, WeekNumber = weekNumber, Amount = amount });
        }

        public int GetCurrentCashOnHand()
        {
            int bal = _startingBalance;
            foreach (var entry in _ledgerEntries)
            {
                if (entry.Direction == EntryDirection.CREDIT)
                {
                    bal = bal + entry.Amount;
                }
                else
                {
                    bal = bal - entry.Amount;
                }
            }

            return bal;
        }

        public int GetNetProfit()
        {
            return Math.Max(0, GetCurrentCashOnHand() - _startingBalance);
        }
    }
}
