namespace SimEngine.Ledger
{
    public class LedgerEntry
    {
        public EntryDirection Direction { get; set; }
        public EntryType Type { get; set; }
        public int Amount { get; set; }
    }
}
