using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Tests
{
    [TestClass]
    public class CartTests
    {
       
        private static  CartManager _cartManager;
        private static CartItem _cartItem;

      

        [ClassInitialize]
        public static void ClassInitialize(TestContext testContext)
        {
            //Arrange
           
          _cartManager = new CartManager();
            _cartItem = new CartItem
            {
                product = new Product()
                {
                    ProductId = 1,
                    ProductName = "Laptop",
                    UnitInPrice = 2500
                },
                Quantity = 1

            };
            //Act
            _cartManager.Add(_cartItem);
        }
        [ClassCleanup]
        public static void ClassCleanup()
        {
            _cartManager.Clear();
        }
        [TestMethod]
        public void When1DifferentProductIsAddedtotheBaskettheTotalNumberofProductsAndtheNumberofElementsintheBasketShouldIncreaseby1()
        {
            int TotalQuantity = _cartManager.TotalQuantity;
            int TotalItem = _cartManager.TotalItem;
            _cartManager.Add(new CartItem
            {
                product = new Product
                {
                    ProductId = 2,
                    ProductName = "House",
                    UnitInPrice = 10

                },
                Quantity = 1
            });

            //Assert
            Assert.AreEqual(TotalQuantity + 1, _cartManager.TotalQuantity);
            Assert.AreEqual(TotalItem + 1, _cartManager.TotalItem);
        }
        [TestMethod,ExpectedException(typeof(Exception))]
        
        public  void  When1ItemisAddedtotheBaskettheTotalNumberofProductintheBasketShouldIncreaseby1andtheNumberofElementsShouldRemaintheSame()
        {
            int TotalQuantity = _cartManager.TotalQuantity;
            int TotalItem = _cartManager.TotalItem;
            _cartManager.Add(_cartItem);
           

            //Assert
            Assert.AreEqual(TotalQuantity + 1, _cartManager.TotalQuantity);
            Assert.AreEqual(TotalItem , _cartManager.TotalItem);
        }

        [TestMethod]
        public void AddtheBox()
        {
            const int expected = 1;
            
            var TotalItemCount = _cartManager.TotalItem;
            //Assert
            Assert.AreEqual(expected, TotalItemCount);
        }
        [TestMethod]
        public void RemovetheBox()
        {
            var TotalItemCount = _cartManager.TotalItem;
            _cartManager.Remove(1);
            var RemainingNumberofElements = _cartManager.TotalItem;
            Assert.AreEqual(TotalItemCount-1, RemainingNumberofElements);
        }
        [TestMethod]
        public void CleartheBox()
        {
            
           
          
            _cartManager.Clear();
           
            Assert.AreEqual(0, _cartManager.TotalQuantity);
            Assert.AreEqual(0, _cartManager.TotalItem);
        }
   
    }
}
