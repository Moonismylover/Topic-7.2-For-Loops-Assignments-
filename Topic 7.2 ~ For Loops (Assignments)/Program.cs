namespace Topic_7._2___For_Loops__Assignments_
{
    internal class Program
    {
        public static void Assignment1()
        {
            Console.Title = "Counting Down";

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("The COUNTDOWN has began!");
            Console.WriteLine();

            for (int a = 10; a <= 10 && a >= 0; a = a - 1)
            {
                Thread.Sleep(500);
                Console.WriteLine($"{a}!");
            }
        }

        public static void Assignment2()
        {
            Console.Title = "X & Y";

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\t    x  |  y  ");
            Console.WriteLine("\t ------------");

            for (int i = -10; i >= -10 && i <= 10; i = i + 2)
            { 
                Console.Write($"\t  {i}  ");
                for (double y = Math.Pow(i, 2); y <= Math.Pow(i, 2); y++)
                {
                    Console.Write($"\t  {y}  ");
                    Console.WriteLine();
                }
            }
        }

        public static void Assignment3()
        {
            Console.Title = "For Loop Fun";

            String name;

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Input a name: ");
            Console.ForegroundColor = ConsoleColor.Red;
            name = Console.ReadLine().ToLower();
            Console.ForegroundColor = ConsoleColor.Blue;

            for (int a = 1, a <= 10, a = a + 1)
            {ole.WriteLine($"")
                {

                Cons

            //Write a program that prompts the user for a name. Then display that name ten times using a for loop.
//However, if the name given is "Aldworth", display it only five times.
// So here's the challenge: write the program using only one if statement (no else) and one for loop.
        }

        static void Main(string[] args)
        {
            Console.Title = "Topic 7.2 ~ For Loops (Assignments)";

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("~~~~~~ COUNTDOWN ~~~~~~");
            Console.WriteLine();
            Assignment1();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine("~~~~~~ X and Y ~~~~~~");
            Console.WriteLine();
            Assignment2();

        }
    }
}
