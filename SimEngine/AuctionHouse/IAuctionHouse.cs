using System.Collections.Generic;

namespace SimEngine.AuctionHouse
{
    public interface IAuctionHouse
    {
        List<Car> Buy(int cashOnHand, int carsOnHand);
    }
}
