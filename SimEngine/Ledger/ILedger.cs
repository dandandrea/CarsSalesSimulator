using System.Collections.Generic;

namespace SimEngine.Ledger
{
    public interface ILedger
    {
        void AddEntry(EntryDirection direction, EntryType entryType, int weekNumber, int amount);
        int GetNetProfit();
        int GetCurrentCashOnHand();
        List<LedgerEntry> GetEntries();
    }
}