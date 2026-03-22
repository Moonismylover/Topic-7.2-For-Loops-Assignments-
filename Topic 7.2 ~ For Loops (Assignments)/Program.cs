namespace Topic_7._2___For_Loops__Assignments_
{
    internal class Program
    {
        public static void Assignment1()
        {
            Console.Title = "Assignment 1 ~ Counting Down";

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
            Console.Title = "Assignment 2 ~ X & Y";

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("  x  |  y  ");
            Console.WriteLine("------------");


            for (int i = -10; i >= -10 && i <= 10; i = i + 2)
            { 
                Console.Write($"  {i}  ");
                for (int y = -10 * 2; y <= -10 * 2; y++)
                {
                    Console.Write($"|  {y}  ");
                }
            }


            // Write another program that uses a for loop.With the loop, make the count
// variable ‘i’ go from - 10 to 10, counting by 2’s.
// Inside the body of the loop, make another variable y become the current value of
// i squared.Then display the current values of both x and y.It should look like this:
// Adding a TAB in a WriteLine() statement can be done using “\t”. This will
// help you line up your columns
        }

        static void Main(string[] args)
        {
            Console.Title = "Topic 7.2 ~ For Loops (Assignments)";

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("~~~~~~ COUNTDOWN ~~~~~~");
            Console.WriteLine();
            Assignment1();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("~~~~~~ X and Y ~~~~~~");
            Console.WriteLine();
            Assignment2();

        }
    }
}
