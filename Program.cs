using System;

namespace ActionAndFuncDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
 
            // Use the Action<> delegate to point to DisplayMessage. 
            Action<string, ConsoleColor, int> actionTarget =  new Action<string, ConsoleColor, int>(DisplayMessage);
            actionTarget("Action Message!", ConsoleColor.Yellow, 5);

            //Use the Func<> delegate to point to SumToString
            var funcTarget2 = new Func<int, int, string>(SumToString);     // used implicit typing; var keyword
            string sum = funcTarget2(90, 270);
            Console.WriteLine(sum);

            Console.ReadLine();
        }

        // This is a target for the Action<> delegate. 
        static void DisplayMessage(string msg, ConsoleColor txtColor, int printCount)
        {
            // Set color of console text. 
            ConsoleColor previous = Console.ForegroundColor;
            Console.ForegroundColor = txtColor;

            for (int i = 0; i < printCount; i++)
            {
                Console.WriteLine(msg);
            }

            // Restore color. 
            Console.ForegroundColor = previous;
        }

        // Targets for the Func<> delegate. 
        static string SumToString(int x, int y)
        {
            return (x + y).ToString();
        }

    }
}
