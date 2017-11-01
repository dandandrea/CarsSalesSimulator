using SimEngine.Ledger;
using System.Collections.Generic;

namespace SimEngine.Dealership
{
    public interface IDealership
    {
        void Crank(int weekNumber);
        List<Car> GetCurrentInventory();
        int GetCurrentCashOnHand();
        int GetNetProfit();
        DealershipParameters GetParameters();
        ILedger GetLedger();
    }
}