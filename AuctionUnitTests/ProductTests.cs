using Auction;

namespace AuctionUnitTests

{
    [TestClass]
    public class ProductTests
    {
        /// <summary>
        /// Test that quantity cannot be put below 0
        /// </summary>
        [TestMethod]
        public void TestNegativeQuantity()
        {
            // Create
            Product ToothBrush = new Product(1, "ToothBrush");

            // Act
            ToothBrush.IncreaseQuantity(25);
            ToothBrush.Quantity -= 45;

            // Assert
            Assert.AreEqual(25, ToothBrush.Quantity);

    
        
        }


        /// <summary>
        /// Tests that a customer can reduce a stock to 0
        /// Make sure that the boundries are correct 
        /// </summary>
        [TestMethod]
        public void TestCanEmpty()
        {
            // Arrange
            Product ToothBrush = new Product(1, "ToothBrush");

            // Act
            ToothBrush.IncreaseQuantity(25);
            ToothBrush.DecreaseQuantity(25);

            // Assert 
            Assert.AreEqual(0, ToothBrush.Quantity);


        }


        /// <summary>
        /// Test that stock levels are correct after making a purchase 
        /// </summary>
        [TestMethod]
        public void TestStockAfterPurchase()
        {
            Product Brush = new Product(1, "Brush");

            Brush.IncreaseQuantity(20);
            Brush.DecreaseQuantity(15);


            Assert.AreEqual(5, Brush.Quantity);

        }



    }

}