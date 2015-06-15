using Katas;
using NUnit.Framework;

namespace KatasTests
{
    [TestFixture]
    public class PotterPricingTests
    {
        [Test]
        public void BuyZeroBooksCostsZeroEuro()
        {
            int[] books = new int[] {};
            double price = PotterPricing.GetPrice(books);
            Assert.AreEqual(0, price);
        }

        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        [TestCase(4)]
        public void BuyAnyOneBookCostsEightEuro(int i)
        {
            double price = PotterPricing.GetPrice(new int[] {i});
            Assert.AreEqual(8, price);
        }

        [TestCase(new int[] {0,0}, 16)]
        [TestCase(new int[] {1,1,1}, 24)]
        public void BuySameBookTwiceCostsSixteenEuro(int[] books, double expected)
        {
            double price = PotterPricing.GetPrice(books);
            Assert.AreEqual(expected, price);
        }

        [Test]
        public void BuyTwoDifferentBooksYieldsFivePercentDiscount()
        {
            double price = PotterPricing.GetPrice(new[] {0, 1});
            Assert.AreEqual(8*2*0.95, price);
        }
        [Test]
        public void BuyThreeDifferentBooksYieldsTenPercentDiscount()
        {
            double price = PotterPricing.GetPrice(new[] {0, 2, 4});
            Assert.AreEqual(8*3*0.9, price);
        }
        [Test]
        public void BuyFourDifferentBooksYieldsTwentyPercentDiscount()
        {
            double price = PotterPricing.GetPrice(new[] {0, 1, 2, 4});
            Assert.AreEqual(8*4*0.8, price);
        }
        [Test]
        public void BuyFiveDifferentBooksYieldsTwentyFivePercentDiscount()
        {
            double price = PotterPricing.GetPrice(new[] {0, 1, 2, 3, 4});
            Assert.AreEqual(8*5*0.75, price);
        }

        [Test]
        public void BuyTwoSameAndOneDifferentBookCostsTwentyThreeEuroAndTwentyCent()
        {
            double price = PotterPricing.GetPrice(new[] {0, 0, 1});
            Assert.AreEqual(8 + (8*2*0.95), price);
        }

        [Test]
        public void BuyTwoTimesTwoSameBooksCostsThirtyEuroFourtyCent()
        {
            double price = PotterPricing.GetPrice(new[] {0, 0, 1, 1});
            Assert.AreEqual(2*8*2*0.95, price);
        }

        [Test]
        public void BuyTwoTimesTwoSameBooksAndTwoDifferentBooksCostsFourtyEuroEightyCent()
        {
            double price = PotterPricing.GetPrice(new[] { 0, 0, 1, 2, 2, 3 });
            Assert.AreEqual((8 * 4 * 0.8) + (8 * 2 * 0.95), price);
        }

        [Test]
        public void BuyTwoSameBooksAndFourDifferentBooksCostsThirtyEightEuro()
        {
            double price = PotterPricing.GetPrice(new[] { 0, 1, 1, 2, 3, 4 });
            Assert.AreEqual(8 + (8 * 5 * 0.75), price);
        }

        [Test]
        public void BuyTwoTimesFourDifferentBooks()
        {  
            double price = PotterPricing.GetPrice(new[] {0, 0, 1, 1, 2, 2, 3, 4});
            Assert.AreEqual(2 * (8 * 4 * 0.8), price);
        }
    }
}
