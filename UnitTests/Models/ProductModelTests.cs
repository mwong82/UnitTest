using Microsoft.VisualStudio.TestTools.UnitTesting;
using HWUT.Models;
using System;

namespace UnitTests
{
    [TestClass]
    public class ProductModelTests
    {
        [TestMethod]
        public void ProductModel_Constructor_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ProductModel_Get_Date_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.AreEqual(DateTime.UtcNow.ToShortDateString(), result.Date.ToShortDateString());
        }

        [TestMethod]
        public void ProductModel_Get_Email_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.AreEqual("Unknown", result.Email);
        }

        [TestMethod]
        public void ProductModel_Get_Logistics_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.AreEqual("", result.Logistics);
        }


        [TestMethod]
        public void ProductModel_Set_AverageRating_5_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.AreEqual(5, result.AverageRating());
        }

        [TestMethod]
        public void ProductModel_Set_AverageRating_Null_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel { Ratings = null };

            // Assert
            Assert.AreEqual(0, result.AverageRating());
        }

        [TestMethod]
        public void ProductModel_Set_AverageRating_Zero_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel { Ratings = new int[] { 0 } };

            // Assert
            Assert.AreEqual(0, result.AverageRating());
        }

        [TestMethod]
        public void ProductModel_Average_Rating_Computes_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel { Ratings = new int[] { 1, 2, 3, 4, 5,6,7 } };

            // Assert
            Assert.AreEqual(4, result.AverageRating());
        }

        [TestMethod]
        public void ProductModel_ToString_IsNotNull_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.IsNotNull(result.ToString());
        }




    }
}
