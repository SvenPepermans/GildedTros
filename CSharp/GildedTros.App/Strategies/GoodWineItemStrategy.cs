using GildedTros.App.Constants;
using System;

namespace GildedTros.App.Services
{
    public class GoodWineItemStrategy : IItemStrategy
    {
        public void UpdateQuality(Item item)
        {
            item.SellIn--;
            if(item.Quality < QualityConstants.MaxQuality)
            {
                item.Quality++;
                item.Quality = item.SellIn < SellInConstants.SellInDeadline && item.Quality < QualityConstants.MaxQuality ? item.Quality++ : item.Quality;
            }
                
        }
    }
}
