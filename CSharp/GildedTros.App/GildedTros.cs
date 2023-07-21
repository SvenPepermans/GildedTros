using GildedTros.App.Strategies;
using System.Collections.Generic;

namespace GildedTros.App
{
    public class GildedTros
    {
        IList<Item> Items;
        public GildedTros(IList<Item> Items)
        {
            this.Items = Items;
        }

        public void UpdateQuality()
        {
           foreach(var item in Items)
            {
                var itemStrategy = ItemContext.DefineItemStrategy(item);
                itemStrategy.UpdateQuality(item);
            } 
           
        }
    }
}
