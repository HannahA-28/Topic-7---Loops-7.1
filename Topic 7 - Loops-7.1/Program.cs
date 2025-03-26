namespace Topic_7___Loops_7._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //while (true)
            //    Console.WriteLine("Are we there yet?");

            //int pin = 12345;
            //int entry;
            //Console.WriteLine("WELCOME TO THE BANK OF ALDWORTH.");
            //Console.WriteLine("ENTER YOUR PIN: ");
            //int.TryParse(Console.ReadLine(), out entry);
            //Console.WriteLine();
            //while (entry != pin)
            //{
            //    Console.WriteLine("INCORRECT PIN. TRY AGAIN.");
            //    Console.WriteLine("ENTER YOUR PIN: ");
            //    int.TryParse(Console.ReadLine(), out entry);
            //    Console.WriteLine();
            //}
            //Console.WriteLine("PIN ACCEPTED. YOU NOW HAVE ACCESS TO YOUR ACCOUNT.");

            //int age;
            //while (!int.TryParse(Console.ReadLine(), out age))
            //    Console.WriteLine("Please enter a valid number.");

            Console.WriteLine("Task one");
            Random generator = new Random();
            int guess, secretNumber;
            secretNumber = generator.Next(1, 11);
            Console.WriteLine("Guess the random number from 1 to 10.");


            //Random generator = new Random();
            //int guess, secretNumber;
            //secretNumber = generator.Next(1, 11);
            //Console.WriteLine("Guess the random number from 1 to 10.");
            //guess = Convert.ToInt32(Console.ReadLine());
            //if (guess == secretNumber)
            //    Console.WriteLine("Congratulations, you guessed it!");
            //else
            //    Console.WriteLine("Wrong, the secret number was " + secretNumber);
        }
    }
}
