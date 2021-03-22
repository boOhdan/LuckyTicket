using System;

namespace LuckyTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("Enter the ticket number!");

                string number = Console.ReadLine();

                bool isNumeric = int.TryParse(number, out _);

                if (number.Length >= 4 && number.Length <= 8 && isNumeric)
                {
                    if (number.Length % 2 != 0)
                        number = number.Insert(0, "0");

                    bool result = IsLuckyTicket(number);

                    if (result)
                        Console.WriteLine("Ticket is Lucky!!!");
                    else
                        Console.WriteLine("Ticket is not Lucky( \nTry again");
                }
                else
                {
                    Console.WriteLine("The ticket number must be between 4 and 8 AND has only digits!");
                }

                Console.WriteLine("\n---------------------------------------------------------------\n");
            }
        }
        static bool IsLuckyTicket(string number) 
        {
            double firstHalf = 0;
            double secondHalf = 0;
            int halfLength = number.Length / 2;

            for (int i = 0; i < halfLength; i++)
            {
                firstHalf += Char.GetNumericValue(number, i);
                secondHalf += Char.GetNumericValue(number, halfLength + i);
            }

            if (firstHalf == secondHalf)
                return true;
            else
                return false;
        }
    }
}
