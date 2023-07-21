namespace GildedTros.App.Strategies
{
    public class BDawgKeyChainItemStrategy : IItemStrategy
    {
        public void UpdateQuality(Item item)
        {
            //BdwagChain never increases / decreases in quality and does not have sellin deadline.
        }
    }
}
