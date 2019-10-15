using System;

namespace Decision_Making_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, what is your name?");
            string userName = Console.ReadLine();
            Console.Write("Hello " + userName + ", please enter a number that is between 1 & 100");
            double userNumber = Convert.ToDouble(Console.ReadLine());

            do
            {


                if (userNumber % 2 == 0)
                {
                    if (userNumber < 25 && userNumber >= 2)
                    {
                        Console.WriteLine("The number entered is Even and less than 25");
                    }
                    else if (userNumber > 25 && userNumber <= 60)
                    {
                        Console.WriteLine("Even.");
                    }
                    else if (userNumber > 60)
                    {
                        Console.WriteLine(userNumber + " and even.");
                    }

                    else if (userNumber % 2 != 0)
                    {
                        if (userNumber > 60)
                        {
                            Console.WriteLine("Odd and greater than 60.");
                        }
                        else if (userNumber < 60)
                        {
                            Console.WriteLine(userNumber + " and odd.");
                        }
                    }
                }
            } while ();
            
        }
    }
}



