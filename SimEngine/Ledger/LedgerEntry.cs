namespace SimEngine.Ledger
{
    public class LedgerEntry
    {
        public EntryDirection Direction { get; set; }
        public EntryType Type { get; set; }
        public int WeekNumber { get; set; }
        public int Amount { get; set; }

        public override string ToString()
        {
            string s = "";

            switch (Type)
            {
                case EntryType.CAR_PURCHASE:
                    s = $"Bought a car for ${Amount}";
                    break;
                case EntryType.CAR_SALE:
                    s = $"Sold a car for ${Amount}";
                    break;
                case EntryType.PERSONAL_EXPENSES:
                    s = $"Deducted ${Amount} for personal expenses";
                    break;
            }

            return s;
        }
    }
}