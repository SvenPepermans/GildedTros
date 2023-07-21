using GildedTros.App.Constants;
using System;

namespace GildedTros.App.Strategies
{
    internal class SmellyItemStrategy : IItemStrategy
    {
        public void UpdateQuality(Item item)
        {
            item.SellIn--;
            item.Quality -= 2;

            if (item.SellIn < SellInConstants.SellInDeadline)
                item.Quality -= 2;

            item.Quality = Math.Max(item.Quality, QualityConstants.MinQuality);
        }
    }
}
