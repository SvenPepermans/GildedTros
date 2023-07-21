using GildedTros.App.Constants;
using System;

namespace GildedTros.App.Strategies
{
    public class RegularItemStrategy : IItemStrategy
    {
        public void UpdateQuality(Item item)
        {
            item.SellIn--;
            item.Quality--;

            if (item.SellIn < SellInConstants.SellInDeadline)
                item.Quality--;

            item.Quality = Math.Max(item.Quality, QualityConstants.MinQuality);

        }
    }
}
