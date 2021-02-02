using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            Console.WriteLine(IsLeapYear(2000));
            Console.WriteLine(IsUnderAge(18));
            Console.WriteLine(GetPrice("pizza"));
            
            int[] numbers = { 1, 2, 3, 4, 5 };
            Console.WriteLine(CountFives(numbers));
            
            int[] numbers = {20,5};
            Console.WriteLine(GetMax(numbers));

    */
            Console.ReadKey();
        }

        static public bool IsLeapYear(int year)
        {
            bool leap = true;


            if (year <= 1582 && year % 4 == 0)
            {
                leap = true;
            }
            else
            {
                if ((year % 100 == 0 && year % 400 == 0) || (year % 100 != 0 && year % 4 == 0))
                {
                    leap = true;
                }
                else
                {
                    leap = false;
                }

            }

            return leap;
        }
        static public bool IsUnderAge(int age)
        {
            bool underAge = true;


            if (age >= 18)
            {
                underAge = false;
            }
            else
            {
                underAge = true;
            }




            return underAge;
        }
        static public string GetPrice(string product)
        {
            string productPrice;


             switch (product.ToLower)
            {
                case "bananas":
                    {
                        productPrice = "1.50";
                        break;
                    }
                case "spuds":
                    {
                        productPrice = "1.50";
                        break;
                    }
                case "pizza":
                    {
                        productPrice = "3.50";
                        break;
                    }
                case "apples":
                    {
                        productPrice = "3.00";
                        break;
                    }
                case "tomatoes":
                    {
                        productPrice = "3.00";
                        break;
                    }

                case "oranges":
                    {
                        productPrice = "3.00";
                        break;
                    }


                default:
                    {
                        productPrice = "-1";
                        break;

                    }

            //string price = string.Format("{0:n2}", productPrice);

            return productPrice;
        }
        static int CountFives(int[] numbers)
        {

            int count = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == 5)
                {
                    count++;

                }

            }

            return count;

        }
        static int GetMin(int[] numbers)
        {
            int smallest = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (i == 0)
                {
                    smallest = numbers[i];
                }

                if (numbers[i] < smallest)
                {
                    smallest = numbers[i];
                }

            }

            return smallest;
        }
        static int GetMax(int[] numbers)
        {
            int max = -999;


            for (int i = 0; i < numbers.Length; i++)
            {
                if (i == 0)
                {
                    max = numbers[i];
                }

                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }


            return max;
        }

    }
}
