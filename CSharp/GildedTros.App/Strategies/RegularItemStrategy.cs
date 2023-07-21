using GildedTros.App.Constants;
using System;

namespace GildedTros.App.Services
{
    public class RegularItemStrategy : IItemStrategy
    {
        public void UpdateQuality(Item item)
        {
            item.SellIn--;
            item.Quality--;

            if (item.SellIn < SellInConstants.SellInDeadline)
                item.Quality--;

            item.Quality = item.Quality < QualityConstants.MinQuality ? QualityConstants.MinQuality : item.Quality;
          
        }
    }
}
