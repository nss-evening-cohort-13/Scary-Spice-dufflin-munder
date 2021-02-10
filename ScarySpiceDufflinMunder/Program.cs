using System;

namespace ScarySpiceDufflinMunder
{
    class Program
    {
        static void Main(string[] args)
        {
            
            while(true)
            {
                UserInterface.MainGreeting();

                var validSelection = int.TryParse(Console.ReadLine(), out int result);
                if (validSelection && result < 5 && result > 0)
                {
                    UserInterface.UserSelection(result);
                }
                else if(result == 5)
                {
                    Console.WriteLine("Thanks for choosing sales portal");
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Please make a valid selection");
                    continue;
                }
            } 
           

            
        }
    }
}
