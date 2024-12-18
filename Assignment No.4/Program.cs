using System.ComponentModel.Design;
using System.Text;

namespace Assignment_No._4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Question 13 Write a program to allow the user to enter a string and print the REVERSE of it.
            //Console.Write("please enter the string you want to reverse: ");
            //string normal=Console.ReadLine();
            //StringBuilder reverse = new StringBuilder();
            //for (int i = 0; i < normal.Length; i++)
            //{
            //    reverse.Append(normal.Substring(normal.Length - 1-i, 1));
            //}
            //Console.Write(reverse);
            #endregion

            #region Question 14 Write a program to allow the user to enter int and print the REVERSED of it.
            //int.TryParse(Console.ReadLine(), out int number);
            //int reverse=0;
            //while(number>0)
            //{
            //    reverse = reverse * 10 + number%10;
            //    number/=10;
            //}
            //Console.Write(reverse);
            #endregion

            #region Question 15 Write a program in C# Sharp to find prime numbers within a range of numbers.
            //Console.Write("Input starting number of range: ");         
            //int.TryParse(Console.ReadLine(),out int start);
            //Console.Write("Input ending number of range : ");
            //int.TryParse(Console.ReadLine(), out int end);
            //for (int i = start; i < end; i++)
            //{
            //    int count = 0;
            //    for (int j = 1; j <= i; j++)
            //    {
            //        if (i % j == 0)
            //        {
            //            count++;
            //        }
            //    }
            //    if (count == 2)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            #endregion

            #region Question 16 Write a program in C# Sharp to convert a decimal number into binary without using an array.
            //int.TryParse(Console.ReadLine(), out int num);
            //int binary=0;
            //while (num > 0)
            //{
            //    binary = binary * 10 + num % 2;
            //    num = num / 2;
            //}
            //int reverse = 0;
            //while (binary > 0)
            //{
            //    reverse = reverse * 10 + binary % 10;
            //    binary /= 10;
            //}
            //Console.Write(reverse);
            #endregion

            #region Question 17 Create a program that asks the user to input three points (x1, y1), (x2, y2), and (x3, y3), and determines whether these points lie on a single straight line.
            //Console.Write("Enter the first point (x1,y1): ");
            //int.TryParse(Console.ReadLine(), out int x1);
            //int.TryParse(Console.ReadLine(), out int y1);
            //Console.Write("Enter the second point (x2,y2): ");
            //int.TryParse(Console.ReadLine(), out int x2);
            //int.TryParse(Console.ReadLine(), out int y2);
            //Console.Write("Enter the third point (x3,y3): ");
            //int.TryParse(Console.ReadLine(), out int x3);
            //int.TryParse(Console.ReadLine(), out int y3);
            //if ((x2 - x1) * (y3 - y1) == (y2 - y1) * (x3 - x1))
            //{
            //    Console.WriteLine("these points lie on a single straight line.");
            //}
            //else {
            //    Console.WriteLine("these points dont lie on a single straight line.");
            //        }
            #endregion

            #region Question 18 Within a company, the efficiency of workers is evaluated based on the duration required to complete a specific task.
            //Console.WriteLine("Enter the worker Task time needed: ");
            //int.TryParse(Console.ReadLine(), out int effi);
            //if (effi >= 2 && effi < 3)
            //{
            //    Console.WriteLine("highly efficient Worker");
            //}
            //else if (effi >= 3 && effi < 4)
            //{
            //    Console.WriteLine("Workers needs to increase their speed.");
            //}
            //else if (effi >= 4 && effi <= 5)
            //{
            //    Console.WriteLine("Workers are provided with training to enhance their speed.");
            //}
            //else if (effi > 5)
            //{
            //    Console.WriteLine("Workers are required to leave the company.");
            //}
            #endregion
        }
    }
}
