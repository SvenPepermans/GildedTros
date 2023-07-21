using GildedTros.App.Constants;

namespace GildedTros.App.Strategies
{
    public static class ItemContext
    {
        public static IItemStrategy DefineItemStrategy(Item item)
        {
            switch (item.Name)
            {
                case ItemNameConstants.GoodWine:
                    return new GoodWineItemStrategy();
                case ItemNameConstants.BDawgKeyCHain:
                    return new BDawgKeyChainItemStrategy();
                case ItemNameConstants.BackStagePassesRefactor:
                case ItemNameConstants.BackStagePassesHAXX:
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
