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


        /// <summary>
        /// Ensures that when creating a deep copy of a Product object
        /// That you can change the orignal product without independantly of the other 
        /// </summary>
        [TestMethod]
        public void TestDeepCopyQuantity()
        {
            // Arrange so create the testing products 
            StockManager stockManager = new StockManager();
            // the product to do a deep copy of
            Product catnip = new Product(1, "catnip");


            // Act 
            catnip.IncreaseQuantity(50);
            Product catnipOrderProduct = stockManager.GetOrderProduct(catnip, 15);

            // Assert 
            // These two should not be equal 
            Assert.AreNotEqual(catnip.Quantity, catnipOrderProduct.Quantity);
            

        }


        /// <summary>
        /// Test that after ordering a product from get order product
        /// The Quantity is correct after substracting the amount of that
        /// product the user ordered 
        /// </summary>
        [TestMethod]
        public void TestQuantityAfterOrder()
        {
            // Arrange so create the testing products 
            StockManager stockManager = new StockManager();
            // the product to do a deep copy of
            Product catnip = new Product(1, "catnip");


            // Act 
            catnip.IncreaseQuantity(50);
            Product catnipOrderProduct = stockManager.GetOrderProduct(catnip, 15);

            //Assert
            // If deep copy works original catnip should be 35

            Assert.AreEqual(catnip.Quantity, 35);
        }


    }

}