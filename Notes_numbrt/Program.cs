using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Note_number
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Please enter the amount: ");
            int amount = int.Parse(Console.ReadLine());
            countCurrency(amount);
            Console.ReadLine();
        }
       public static void countCurrency(int amount)
        {
            int[] notes= new int[] { 500, 100, 50, 10, 5 };
            int[] noteCounter = new int[6];


            if (amount % 5 == 0)
            {
                // count notes using Greedy approach
                for (int i = 0; i < 5; i++)
                {
                    if (amount >= notes[i])
                    {
                        noteCounter[i] = amount / notes[i];
                        amount = amount - noteCounter[i] * notes[i];
                    }
                }

                // Print notes
                Console.WriteLine("Currency Count ->");
                for (int i = 0; i < 5; i++)
                {
                    if (noteCounter[i] != 0)
                    {
                        Console.WriteLine(notes[i] + " : " + noteCounter[i]);
                    }
                }
            }
            else
                Console.WriteLine("Invalid Amount");
        }
    }
}

