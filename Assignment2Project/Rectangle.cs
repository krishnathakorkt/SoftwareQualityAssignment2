using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2Project
{
    public class Rectangle
    {
            private int length { get; set; }
            private int width { get; set; }

            //Default Constructor -that will store length and width to 1
            public Rectangle()
            {
                length = 1;
                width = 1;
            }

            //Parameterized Constructor -that will store length and width according to parameter
            public Rectangle(int length, int width)
            {
                if (length < 0 || width < 0)
                {
                    throw new Exception("Length and Width must be greater than zero.");
                }
                else
                {
                    this.length = length;
                    this.width = width;
                }
            }

            //return length value
            public int GetLength()
            {
                if (length < 0)
                {
                    throw new Exception("Length must be greater than zero.");
                }
                return length;
            }

            //return length value
            public int SetLength(int length)
            {
                if (length < 0)
                {
                    throw new Exception("Length must be greater than zero.");
                }
                else
                {
                    this.length = length;
                    return length;
                }
            }

            //set width value
            public int SetWidth(int width)
            {
            if (width < 0)
            {
                throw new Exception("Width must be greater than zero.");
            }
            else
            {
                this.width = width;
                return width;
            }
           
            }

            //return width value
            public int GetWidth()
            {
            if (width < 0)
            {
                throw new Exception("Length must be greater than zero.");
            }
            else
            {
                return width;
            }
            }
            
            //calculate perimeter and return it
            public int GetPerimeter()
            {
                if (length < 0 || width < 0)
                {
                    throw new Exception("Length and Width must be greater than zero.");
                }
                else
                {
                    return (2 * (length + width));
                }
            
            }
            
            //calculate area and return it
            public int GetArea()
            {
                if (length < 0 || width < 0)
                {
                    throw new Exception("Length and Width must be greater than zero.");
                }
                else
                {
                    return (length * width);
                }
            
            }
        }
}
