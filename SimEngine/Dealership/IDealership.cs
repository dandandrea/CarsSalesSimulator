using System.Collections.Generic;

namespace SimEngine.Dealership
{
    public interface IDealership
    {
        void Crank();
        List<Car> GetCurrentInventory();
        int GetCurrentCashOnHand();
        int GetNetProfit();
    }
}