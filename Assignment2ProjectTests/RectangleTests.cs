using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assignment2Project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2Project.Tests
{
    [TestClass()]
    public class RectangleTests
    {
        
        [TestMethod()]
        public void RectangleTest()
        {
            //Arrange & Act - Default Constructor
            Rectangle rect = new Rectangle();

            //Assert
            Assert.AreEqual(1, rect.GetLength());
            Assert.AreEqual(1, rect.GetWidth());
        }

        [TestMethod()]
        public void RectangleTest1()
        {
            //Arrange & Act - Default Constructor
            Rectangle rect = new Rectangle(5,5);

            //Assert
            Assert.AreEqual(5, rect.GetLength());
            Assert.AreEqual(5, rect.GetWidth());
        }

        [TestMethod()]
        public void GetLengthTest()
        {
            //Arrange
            Rectangle rect = new Rectangle();

            //Act
            int result=rect.GetLength();

            //Assert
            Assert.AreEqual(1,result);
        }

        [TestMethod()]
        public void GetWidthTest()
        {
            //Arrange
            Rectangle rect = new Rectangle();

            //Act
            int result = rect.GetWidth();

            //Assert
            Assert.AreEqual(1, result);
        }

        [TestMethod()]
        public void SetLengthTest()
        {
            //Arrange
            Rectangle rect = new Rectangle();

            //Act
            rect.SetLength(5);

            //Assert
          // Assert.AreEqual(5,rect.GetLength());
        }


        [TestMethod()]
        public void SetWidthTest()
        {
            //Arrange
            Rectangle rect = new Rectangle();

            //Act
            rect.SetWidth(5);

            //Assert
            Assert.AreEqual(5, rect.GetWidth());
        }

        [TestMethod()]
        public void GetPerimeterTest()
        {
            //Arrange
            Rectangle rect = new Rectangle(2,2);

            //Act
            int perimeter=rect.GetPerimeter();

            //Assert
            Assert.AreEqual(8,perimeter);
        }

        [TestMethod()]
        public void GetAreaTest()
        {
            //Arrange
            Rectangle rect = new Rectangle(2, 2);

            //Act
            int area = rect.GetArea();

            //Assert
            Assert.AreEqual(4, area);
        }
    }
}