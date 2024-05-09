using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace scrabble
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] alphabets = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M',
                                'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };

            int [] numbers = { 1 ,3 ,3 ,2 ,1, 4 ,2 ,4 ,1 ,8 ,5 ,1 ,3
                              ,1 ,1 ,3 ,10 ,1 ,1 ,1 ,1 ,4 ,4 ,8 ,4 , 10 };

            Console.Write("Player 1: ");
            string player__1 = Console.ReadLine();
            string player_1 = player__1.ToUpper();
            char[] player1 = player_1.ToCharArray();

            bool flag;
            int sum1 = 0;

            for (int counter = 0; counter < player1.Length; counter++)
            {
                flag = true;
                int i = 0;
                while (flag)
                {
                    if (player1[counter] == alphabets[i])
                    {
                        sum1 = sum1 + numbers[i];

                        flag = false;
                    }

                    if (i == 25)
                    {
                        flag = false;
                    }
                    i++;
                }
            }

            Console.Write("Player 2 : ");
            string player__2 = Console.ReadLine();
            string player_2 = player__2.ToUpper();
            char[] player2 = player_2.ToCharArray();

            int sum2 = 0;

            for (int counter = 0; counter < player2.Length; counter++)
            {
                flag = true;
                int i = 0;
                while (flag)
                {
                    if (player2[counter] == alphabets[i])
                    {
                        sum2 = sum2 + numbers[i];

                        flag = false;
                    }

                    if (i == 25)
                    {
                        flag = false;
                    }
                    i++;
                }
            }
            Console.WriteLine();

            if (sum1 > sum2)
            {
                Console.WriteLine("PLAYER 1 WINS");

            }
            else if(sum1 < sum2)
            {
                Console.WriteLine("PLAYER 2 WINS");
            }
            else
            {
                Console.WriteLine("TIE!!");
            }
            

        }
    }
}
