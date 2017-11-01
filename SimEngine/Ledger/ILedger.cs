namespace SimEngine.Ledger
{
    public interface ILedger
    {
        void AddEntry(EntryDirection direction, EntryType entryType, int amount);
        int GetNetProfit();
        int GetCurrentCashOnHand();
    }
}
