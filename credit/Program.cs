using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace credit
{
    internal class Program
    {
        static void Main(string[] args)
        {

            long userInput ,  remainder = 0 , uInput;
            bool flag = true ;
            long mult = 10 ,mult2 = 10 , counter = 0 , counter2 = 1 , selection , selecRemainder =0 , sum1 =0 , sum2 =0 ;
            int total = 0;
            Console.Write("please enter a value : ");
            uInput = userInput = Convert.ToInt64(Console.ReadLine());

            while (flag)
            {
                if (counter >= 1)
                {
                    remainder = (uInput % mult);
                    uInput -= remainder;
                    remainder = remainder / mult2;

                    mult2 *= 10;

                }
                else
                {
                    remainder = (uInput % mult);
                    uInput -= remainder;

                }

                if (counter == counter2)
                {
                    counter2 += 2;

                    selection = remainder * 2;

                     if (selection >= 10)
                    {
                        selecRemainder = selection % 10;
                        sum1 = sum1 + selecRemainder;
                        selecRemainder = selection - selecRemainder;
                        sum1 = sum1 + (selecRemainder/10);
                    }
                    else
                    {
                        sum1 = sum1 + selection;
                    } 
                }
                else
                {
                    sum2 = sum2 + remainder;
                }
                counter++;

                mult *= 10;
                if (uInput == 0)
                {
                    flag = false;
                }
            }
            total = (int)(sum1 + sum2);

            if (total % 10 == 0)
            {
                if (counter == 15 && remainder == 3)
                    Console.WriteLine("AMEX");

                if (counter == 16 && remainder == 5)
                    Console.WriteLine("MASTERCARD");

                if (counter == 13 || counter == 16 && remainder == 4)
                    Console.WriteLine("VISA");
            }
            else
            {
                Console.WriteLine("INVALID");
            }

        }
    }
}
