using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eazyCart.Tests
{
    public class ProductTests
    {
        // Test cases for ProductID
        [Test]
        public void ProductID_ShouldBeWithinValidRange_Low()
        {
            var product = new Product(1, "Sample Test Product", 10, 5);

            var actual = product.ProductID;

            Assert.That(actual, Is.EqualTo(1));
        }

        [Test]
        public void ProductID_ShouldBeWithinValidRange_High()
        {
            var product = new Product(1000, "Sample Test Product", 10, 5);

            var actual = product.ProductID;

            Assert.That(actual, Is.EqualTo(1000));
        }

        [Test]
        public void ProductID_ShouldBeWithinValidRange_Mid()
        {
            var product = new Product(500, "Sample Test Product", 10, 5);

            var actual = product.ProductID;

            Assert.That(actual, Is.EqualTo(500));
        }

        // Test cases for ProductName
        [Test]
        public void ProductName_ShouldBeSet_Correctly()
        {
            var product = new Product(1, "Sample Test Product", 10, 5);

            var actual = product.ProductName;

            Assert.That(actual, Is.EqualTo("Sample Test Product"));
        }

        [Test]
        public void ProductName_ShouldAllow_EmptyString()
        {
            var product = new Product(1, "", 10, 5);

            var actual = product.ProductName;

            Assert.That(actual, Is.EqualTo(""));
        }

        [Test]
        public void ProductName_ShouldAllow_Null()
        {
            var product = new Product(1, null, 10, 5);

            var actual = product.ProductName;

            Assert.That(actual, Is.Null);
        }



        // Test cases for Price

        [Test]
        public void Price_ShouldBeWithinValidRange_Low()
        {
            var product = new Product(1, "Sample Test Product", 10, 5);

            var actual = product.Price;

            Assert.That(actual, Is.InRange(1, 5000));
        }

        [Test]
        public void Price_ShouldBeWithinValidRange_High()
        {
            var product = new Product(1, "Sample Test Product", 5000, 5);

            var actual = product.Price;

            Assert.That(actual, Is.EqualTo(5000));
        }

        [Test]
        public void Price_ShouldBeWithinValidRange_Mid()
        {
            var product = new Product(1, "Sample Test Product", 2500, 5);

            var actual = product.Price;

            Assert.That(actual, Is.EqualTo(2500));
        }



        // Test cases for Stock
        
        [Test]
        public void Stock_ShouldBeWithinValidRange_Low()
        {
            var product = new Product(1, "Sample Test Product", 10, 5);

            var actual = product.Stock;

            Assert.That(actual, Is.InRange(1, 1000));
        }

        [Test]
        public void Stock_ShouldBeWithinValidRange_High()
        {
            var product = new Product(1, "Sample Test Product", 10, 1000);

            var actual = product.Stock;

            Assert.That(actual, Is.EqualTo(1000));
        }

        [Test]
        public void Stock_ShouldBeWithinValidRange_Mid()
        {
            var product = new Product(1, "Sample Test Product", 10, 500);

            var actual = product.Stock;

            Assert.That(actual, Is.EqualTo(500));
        }

        // Test cases for Increase method
        [Test]
        public void IncreaseStock_ShouldIncreaseStock()
        {
            var product = new Product(1, "Sample Test Product", 10, 5);

            product.IncreaseStock(5);
            var actual = product.Stock;

            Assert.That(actual, Is.EqualTo(10));
        }

        [Test]
        public void IncreaseStock_ShouldHandleZeroIncrease()
        {
            var product = new Product(1, "Sample Test Product", 10, 5);

            product.IncreaseStock(0);
            var actual = product.Stock;

            Assert.That(actual, Is.EqualTo(5));
        }

        [Test]
        public void IncreaseStock_ShouldThrowExceptionWhenStockOutOfRange()
        {
            var product = new Product(1, "Sample Test Product", 10, 5);

            Assert.That(() => product.IncreaseStock(1000), Throws.TypeOf<ArgumentOutOfRangeException>());
        }

        // Test cases for Decrease method
        [Test]
        public void DecreaseStock_ShouldDecreaseStock()
        {
            var product = new Product(1, "Sample Test Product", 10, 5);

            product.DecreaseStock(3);
            var actual = product.Stock;

            Assert.That(actual, Is.EqualTo(2));
        }

        [Test]
        public void DecreaseStock_ShouldHandleZeroDecrease()
        {
            var product = new Product(1, "Sample Test Product", 10, 5);

            product.DecreaseStock(0);
            var actual = product.Stock;

            Assert.That(actual, Is.EqualTo(5));
        }

        [Test]
        public void DecreaseStock_ShouldThrowExceptionWhenStockGoesNegative()
        {
            var product = new Product(1, "Sample Test Product", 10, 5);

            Assert.That(() => product.DecreaseStock(10), Throws.TypeOf<InvalidOperationException>());
        }
    }
}
