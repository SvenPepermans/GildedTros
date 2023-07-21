using GildedTros.App.Constants;
using System;

namespace GildedTros.App.Strategies
{
    public class BackStagePassesItemStrategy : IItemStrategy
    {
        public void UpdateQuality(Item item)
        {
            item.SellIn--;
            item.Quality++;
            if (item.SellIn < 0)
            {
                item.Quality = QualityConstants.MinQuality;
                return;
            }
            else if (item.SellIn < SellInConstants.BackStagePassesSecondSellInDeadline)
                item.Quality += 2;
            else if (item.SellIn < SellInConstants.BackStagePassesFirstSellInDeadline)
                item.Quality++;

            item.Quality = Math.Min(item.Quality, QualityConstants.MaxQuality);
        }
    }

}

