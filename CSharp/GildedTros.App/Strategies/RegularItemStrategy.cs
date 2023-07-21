using GildedTros.App.Constants;

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

            item.Quality = item.Quality < QualityConstants.MinQuality ? QualityConstants.MinQuality : item.Quality;

        }
    }
}
