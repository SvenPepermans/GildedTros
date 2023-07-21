using GildedTros.App.Constants;
using System.Collections.Generic;
using Xunit;

namespace GildedTros.App
{
    public class GildedTrosTest
    {
        #region RegularItem
        [Fact]
        public void RegularItem_WithinRanges_DecreasesQualityAndSellIn()
        {
            //Arrange
            var sellIn = 5;
            var quality = 15;
            IList<Item> items = new List<Item> { CreateItem("RegularItem", sellIn, quality) };

            //Act
            GildedTros app = new GildedTros(items);
            app.UpdateQuality();

            //Assert
            Assert.Equal(--quality, items[0].Quality);
            Assert.Equal(--sellIn, items[0].SellIn);
        }

        [Fact]
        public void RegularItem_ItemExpired_QualityIsZeroSellInDescreased()
        {
            //Arrange
            var sellIn = 0;
            var quality = 15;
            IList<Item> items = new List<Item> { CreateItem("RegularItem", sellIn, quality) };

            //Act
            GildedTros app = new GildedTros(items);
            app.UpdateQuality();

            //Assert
            Assert.Equal(quality-2, items[0].Quality);
            Assert.Equal(--sellIn, items[0].SellIn);
        }       

        [Fact]
        public void RegularItem_QualityIsZero_QualityRemainsZeroAndSellInDecreased()
        {
            //Arrange
            var sellIn = 5;
            var quality = 0;
            IList<Item> items = new List<Item> { CreateItem("RegularItem", sellIn, quality) };

            //Act
            GildedTros app = new GildedTros(items);
            app.UpdateQuality();

            //Assert
            Assert.Equal(quality, items[0].Quality);
            Assert.Equal(--sellIn, items[0].SellIn);
        }

        #endregion

        #region GooWineItem
        [Fact]
        public void GoodWineItem_WithinRanges_IncreasesQualityAndDecreasesSellIn()
        {
            //Arrange
            var sellIn = 5;
            var quality = 15;
            IList<Item> items = new List<Item> { CreateItem(ItemNameConstants.GoodWine, sellIn, quality) };

            //Act
            GildedTros app = new GildedTros(items);
            app.UpdateQuality();

            //Assert
            Assert.Equal(++quality, items[0].Quality);
            Assert.Equal(--sellIn, items[0].SellIn);
        }

        [Fact]
        public void GoodWineItem_MaxQuality_QualityRemainsAndDecreasesSellIn()
        {
            //Arrange
            var sellIn = 5;
            var quality = QualityConstants.MaxQuality;
            IList<Item> items = new List<Item> { CreateItem(ItemNameConstants.GoodWine, sellIn, quality) };

            //Act
            GildedTros app = new GildedTros(items);
            app.UpdateQuality();

            //Assert
            Assert.Equal(quality, items[0].Quality);
            Assert.Equal(--sellIn, items[0].SellIn);
        }

        [Fact]
        public void GoodWineItem_MaxQualityAndItemExpired_QualityRemainsAndDecreasesSellIn()
        {
            //Arrange
            var sellIn = -1;
            var quality = QualityConstants.MaxQuality;
            IList<Item> items = new List<Item> { CreateItem(ItemNameConstants.GoodWine, sellIn, quality) };

            //Act
            GildedTros app = new GildedTros(items);
            app.UpdateQuality();

            //Assert
            Assert.Equal(quality, items[0].Quality);
            Assert.Equal(--sellIn, items[0].SellIn);
        }

        [Fact]
        public void GoodWineItem_ItemExpired_IncreasesQualityBy2AndDecreasesSellIn()
        {
            //Arrange
            var sellIn = -1;
            var quality = 15;
            IList<Item> items = new List<Item> { CreateItem(ItemNameConstants.GoodWine, sellIn, quality) };

            //Act
            GildedTros app = new GildedTros(items);
            app.UpdateQuality();

            //Assert
            Assert.Equal(quality+2, items[0].Quality);
            Assert.Equal(--sellIn, items[0].SellIn);
        }
        #endregion

        #region BdawgKeyChain
        [Fact]
        public void BdawgKeyChainItem_WithinRanges_NothingChanges()
        {
            //Arrange
            var sellIn = 5;
            var quality = 80;
            IList<Item> items = new List<Item> { CreateItem(ItemNameConstants.BDawgKeyCHain, sellIn, quality) };

            //Act
            GildedTros app = new GildedTros(items);
            app.UpdateQuality();

            //Assert
            Assert.Equal(quality, items[0].Quality);
            Assert.Equal(sellIn, items[0].SellIn);
        }
        #endregion

        #region BackStagePasses
        [Fact]
        public void BackStagePassHAXXItem_WithinAllNormalRanges_IncreasesQualityAndDecreasesSellIn()
        {
            //Arrange
            var sellIn = 15;
            var quality = 15;
            IList<Item> items = new List<Item> { CreateItem(ItemNameConstants.BackStagePassesHAXX, sellIn, quality) };

            //Act
            GildedTros app = new GildedTros(items);
            app.UpdateQuality();

            //Assert
            Assert.Equal(++quality, items[0].Quality);
            Assert.Equal(--sellIn, items[0].SellIn);
        }

        [Fact]
        public void BackStagePassHAXXItem_SellInGreatedThen10AndMaxQuality_QualityRemainsAndDecreasesSellIn()
        {
            //Arrange
            var sellIn = 15;
            var quality = QualityConstants.MaxQuality;
            IList<Item> items = new List<Item> { CreateItem(ItemNameConstants.BackStagePassesHAXX, sellIn, quality) };

            //Act
            GildedTros app = new GildedTros(items);
            app.UpdateQuality();

            //Assert
            Assert.Equal(quality, items[0].Quality);
            Assert.Equal(--sellIn, items[0].SellIn);
        }

        [Fact]
        public void BackStagePassHAXXItem_SellInBetween6and10Days_IncreasesQualityBy2AndDecreasesSellIn()
        {
            //Arrange
            var sellIn = 8;
            var quality = 15;
            IList<Item> items = new List<Item> { CreateItem(ItemNameConstants.BackStagePassesHAXX, sellIn, quality) };

            //Act
            GildedTros app = new GildedTros(items);
            app.UpdateQuality();

            //Assert
            Assert.Equal(quality+2, items[0].Quality);
            Assert.Equal(--sellIn, items[0].SellIn);
        }

        [Fact]
        public void BackStagePassHAXXItem_SellInBetween6and10DaysAndMaxQuality_QualityRemainsAndDecreasesSellIn()
        {
            //Arrange
            var sellIn = 8;
            var quality = QualityConstants.MaxQuality;
            IList<Item> items = new List<Item> { CreateItem(ItemNameConstants.BackStagePassesHAXX, sellIn, quality) };

            //Act
            GildedTros app = new GildedTros(items);
            app.UpdateQuality();

            //Assert
            Assert.Equal(quality, items[0].Quality);
            Assert.Equal(--sellIn, items[0].SellIn);
        }

        [Fact]
        public void BackStagePassHAXXItem_SellInLessThen5Days_IncreasesQualityBy3AndDecreasesSellIn()
        {
            //Arrange
            var sellIn = 4;
            var quality = 15;
            IList<Item> items = new List<Item> { CreateItem(ItemNameConstants.BackStagePassesHAXX, sellIn, quality) };

            //Act
            GildedTros app = new GildedTros(items);
            app.UpdateQuality();

            //Assert
            Assert.Equal(quality + 3, items[0].Quality);
            Assert.Equal(--sellIn, items[0].SellIn);
        }

        [Fact]
        public void BackStagePassHAXXItem_SellInLessThen5DaysAndMaxQuality_QualityRemainsAndDecreasesSellIn()
        {
            //Arrange
            var sellIn = 4;
            var quality = QualityConstants.MaxQuality;
            IList<Item> items = new List<Item> { CreateItem(ItemNameConstants.BackStagePassesHAXX, sellIn, quality) };

            //Act
            GildedTros app = new GildedTros(items);
            app.UpdateQuality();

            //Assert
            Assert.Equal(quality, items[0].Quality);
            Assert.Equal(--sellIn, items[0].SellIn);
        }

        [Fact]
        public void BackStagePassHAXXItem_SellInExpired_Quality0AndDecreasesSellIn()
        {
            //Arrange
            var sellIn = 0;
            var quality = 15;
            IList<Item> items = new List<Item> { CreateItem(ItemNameConstants.BackStagePassesHAXX, sellIn, quality) };

            //Act
            GildedTros app = new GildedTros(items);
            app.UpdateQuality();

            //Assert
            Assert.Equal(0, items[0].Quality);
            Assert.Equal(--sellIn, items[0].SellIn);
        }
        #endregion
        private Item CreateItem(string name, int sellIn, int quality)
        {
            return new Item { Name = name, SellIn = sellIn, Quality = quality };
        }      


    }
}