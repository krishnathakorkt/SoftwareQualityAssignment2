/*
 * Student Id-8698445
 * Project Name- Unit Testing on Rectangle Class
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2Project
{
    class Program
    {
        static void Main(string[] args)
        {
            //Program object initialized and call method selectOptions
                Program p = new Program();
                p.selectOptions();
                Console.ReadLine();
        }
        private void selectOptions()
        {
            int choices;
            int length;
            int width;
            bool continueAsk;

            //Rectangle object initialized
            Rectangle rectangle = new Rectangle();
            
            
            //label for goto statement
            Options:
            string answer;
            do
            {
                //Display on Console to get Inputs
                Console.WriteLine("\n1. Get Rectangle Length\n2. Set Rectangle Length\n3. Get Rectangle Width\n4. Set Rectangle Width\n" +
                    "5. Get Rectangle Perimeter\n6. Get Rectangle Area\n7. Exit\nEnter your Choice from Above:");
                answer = Console.ReadLine();
            }
            while (!(int.TryParse(answer, out choices) && (choices > 0 && choices < 9)));
            
            //switch case for option selection
            switch (choices)
            {
                case 1:Console.WriteLine("Length is : "+rectangle.GetLength());
                        break;
                case 2://length setting 
                    continueAsk = false;
                    string tlength;
                    do
                    {
                        Console.Write("Enter Length: ");
                        tlength = Console.ReadLine();
                        continueAsk = (int.TryParse(tlength, out length) && (length > 0));
                        if (!continueAsk)
                            Console.WriteLine("The Rectangle Length must be > 0 and a positive integer.");
                    }
                    while (!continueAsk);
                    rectangle.SetLength(length);
                    Console.WriteLine("Length Set Successfully");
                    break;
                case 3:Console.WriteLine("Width is : "+rectangle.GetWidth());
                        break;
                case 4://width setting
                    continueAsk = false;
                    string twidth;
                    do
                    {
                        Console.Write("Enter Width: ");
                        twidth = Console.ReadLine();
                        continueAsk = (int.TryParse(twidth, out width ) && (width > 0));
                        if (!continueAsk)
                            Console.WriteLine("The Rectangle Width must be > 0 and a positive integer.");
                    }
                    while (!continueAsk);
                    rectangle.SetWidth(width);
                    Console.WriteLine("Width Set Successfully");
                    break;
                case 5:Console.WriteLine("Perimeter values is : "+rectangle.GetPerimeter());
                        break;
                case 6:Console.WriteLine("Area of Rectangle is : "+rectangle.GetArea());
                        break;
                case 7:Environment.Exit(0);
                        break;
            }
            goto Options;//goto the Options select
        }
    }
}
