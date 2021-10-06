using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assignment2Project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2Project.Tests
{
    //All Positive Test Cases:
    [TestClass()]
    public class RectangleTests
    {
        //this will check that length and width value is 1 or not - default constructor
        [TestMethod()]
        public void RectangleTest()
        {
            //Arrange & Act - Default Constructor
            Rectangle rect = new Rectangle();

            //Assert
            Assert.AreEqual(1, rect.GetLength());
            Assert.AreEqual(1, rect.GetWidth());
        }

        //this will check that length and width value is 5 or not - parameterized constructor
        [TestMethod()]
        public void RectangleParamaterConstructorTest1()
        {
            //Arrange & Act - Parameterized Constructor
            Rectangle rect = new Rectangle(5,5);

            //Assert
            Assert.AreEqual(5, rect.GetLength());
            Assert.AreEqual(5, rect.GetWidth());
        }

        //this will check that length value is 1 or not - getlength
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
        //this will check that width value is 1 or not - getwidth
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

        //this will check that length value is 5 or not -setlength and getlength
        [TestMethod()]
        public void SetLengthTest()
        {
            //Arrange
            Rectangle rect = new Rectangle();

            //Act
            rect.SetLength(5);

            //Assert
            Assert.AreEqual(5,rect.GetLength());
        }

        //this will check that width value is 5 or not -setwidth and setwidth
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

        //calculate perimeter according to parameterized constructor value and check 
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

        //calculate area according to parameterized constructor value and check 
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


        //Negative Test Cases
        [TestMethod()]
        public void RectangleNegativeTest()
        {
            //Arrange & Act - Default Constructor
            Rectangle rect = new Rectangle();

            //Assert
            Assert.AreEqual(-8, rect.GetLength());
            Assert.AreEqual(3, rect.GetWidth());
        }

        //this will check that length and width value is 5 or not - parameterized constructor
        [TestMethod()]
        public void RectangleNegativeParameterConstructorTest()
        {
            //Arrange & Act - Parameterized Constructor
            Rectangle rect = new Rectangle(-5, -5);

            //Assert
            Assert.AreEqual(5, rect.GetLength());
            Assert.AreEqual(5, rect.GetWidth());
        }

        //this will check that length value is 1 or not - getlength
        [TestMethod()]
        public void GetLengthNegativeTest()
        {
            //Arrange
            Rectangle rect = new Rectangle();

            //Act
            int result = rect.GetLength();

            //Assert
            Assert.AreEqual(10, result);
        }
        //this will check that width value is 1 or not - getwidth
        [TestMethod()]
        public void GetWidthNegativeTest()
        {
            //Arrange
            Rectangle rect = new Rectangle();

            //Act
            int result = rect.GetWidth();

            //Assert
            Assert.AreEqual(2, result);
        }

        //this will check that length value is 5 or not -setlength and getlength
        [TestMethod()]
        public void SetLengthNegativeTest()
        {
            //Arrange
            Rectangle rect = new Rectangle();

            //Act
            rect.SetLength(-5);

            //Assert
            Assert.AreEqual(5, rect.GetLength());
        }

        //this will check that width value is 5 or not -setwidth and setwidth
        [TestMethod()]
        public void SetWidthNegativeTest()
        {
            //Arrange
            Rectangle rect = new Rectangle();

            //Act
            rect.SetWidth(5);

            //Assert
            Assert.AreEqual(7, rect.GetWidth());
        }

        //calculate perimeter according to parameterized constructor value and check 
        [TestMethod()]
        public void GetNegativePerimeterTest()
        {
            //Arrange
            Rectangle rect = new Rectangle(2, 2);

            //Act
            int perimeter = rect.GetPerimeter();

            //Assert
            Assert.AreEqual(10, perimeter);
        }

        //calculate area according to parameterized constructor value and check 
        [TestMethod()]
        public void GetNegativeAreaTest()
        {
            //Arrange
            Rectangle rect = new Rectangle(2, 2);

            //Act
            int area = rect.GetArea();

            //Assert
            Assert.AreEqual(5, area);
        }
    }
}