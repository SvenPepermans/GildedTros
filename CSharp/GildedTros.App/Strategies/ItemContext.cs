using GildedTros.App.Constants;

namespace GildedTros.App.Strategies
{
    public class ItemContext
    {
        public IItemStrategy DefineItemStrategy(Item item)
        {
            switch (item.Name)
            {
                case ItemNameConstants.GoodWine:
                    return new GoodWineItemStrategy();
                case ItemNameConstants.BDawgKeyCHain:
                    return new BDawgKeyChainItemStrategy();
                case ItemNameConstants.BackStagePasses:
                    return new BackStagePassesItemStrategy();
                default:
                    {
                        if (ItemNameConstants.SmellyItems.Contains(item.Name))
                            return new SmellyItemStrategy();
                        return new RegularItemStrategy();
                    }

            }
        }
    }
}
