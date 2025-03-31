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

            //Console.WriteLine("Task one");
            //Random generator = new Random();
            //int guess = 0, secretNumber;
            //secretNumber = generator.Next(1, 11);
            //while (guess != secretNumber)
            //{
            //    Console.WriteLine("Guess the random number from 1 to 10.");
            //    guess = Convert.ToInt32(Console.ReadLine());
            //    if (guess == secretNumber)
            //        Console.WriteLine("Congratulations! You guessed it!");
            //    else
            //        Console.WriteLine("Wrong! Guess again!");
            //    Console.WriteLine();
            //}

            //Console.WriteLine("Task two");
            //Random generator = new Random();
            //int diceNum1 = 1, diceNum2 = 2;
            //int total;
            //Console.WriteLine("Hit ENTER to roll the dice.");
            //Console.ReadLine();
            //while (diceNum1 != diceNum2)
            //{ 
            //    diceNum1 = generator.Next(1,7);
            //    diceNum2 = generator.Next(1,7);
            //    total = diceNum1 + diceNum2;
            //    Console.WriteLine("Die 1 - " + diceNum1);
            //    Console.WriteLine("Die 2 - " + diceNum2);
            //    Console.WriteLine("Total - " + total);
            //    Console.WriteLine();
            //}

            //bool done = false;
            //int entry = 12345, tries = 0, pin = 0;
            //Console.WriteLine("WELCOME TO THE BANK OF ALDWORTH.");
            //while (!done)
            //{
            //    Console.WriteLine("You have five tries, ENTER YOUR PIN:");
            //    while (!Int32.TryParse(Console.ReadLine(), out pin)) ;
            //    Console.WriteLine("Please enter a valid number");
            //    tries++;
            //    if (pin == entry)
            //    {
            //        Console.WriteLine("Pin accepted!");
            //        done = true;
            //    }
            //    else if (tries == 5)
            //    {
            //        Console.WriteLine("Too many incorrect tries. Access denied");
            //        done = true;
            //    }
            //}

            //bool done = false;
            //int entry = 12345, tries = 0, pin = 0;
            //Console.WriteLine("WELCOME TO THE BANK OF ALDWORTH.");
            //while (!done)
            //{
            //    Console.WriteLine("ENTER YOUR PIN:");
            //    while (!Int32.TryParse(Console.ReadLine(), out pin)) ;
            //    Console.WriteLine("Please enter a valid number");
            //    tries++;
            //    if (pin == entry)
            //    {
            //        Console.WriteLine("Pin accepted!");
            //        done = true;
            //    }
            //    else if (tries == 1)
            //    {
            //        Console.WriteLine("Access denied, 4 attempts left");
            //    }
            //    else if (tries == 2)
            //    {
            //        Console.WriteLine("Access denied, 3 attempts left");
            //    }
            //    else if (tries == 3)
            //    {
            //        Console.WriteLine("Access denied, 2 attempts left");
            //    }
            //    else if (tries == 4)
            //    {
            //        Console.WriteLine("Access denied, 1 attempt left");
            //    }
            //    else if (tries == 5)
            //    {
            //        Console.WriteLine("Too many incorrect tries. Access denied");
            //        done = true;
            //    }
            //}

            //Console.WriteLine("Bad guessing game");
            //bool done = false;
            //Random genertaor = new Random();
            //int guess = 0, tries = 0, secretNumber = genertaor.Next(1, 7);
            //while (!done)
            //{
            //    Console.WriteLine("Guess the random number from 1 to 10:");
            //    guess = Convert.ToInt32(Console.ReadLine());
            //    tries++;
            //    if (guess == secretNumber)
            //    {
            //        Console.WriteLine("Congratulations! You guessed it!");
            //        done = true;
            //    }
            //    else if (tries == 5)
            //    {
            //        Console.WriteLine("Incorrect, You used all your tries!");
            //        done = true;
            //    }
            //}


            //int count = 0;
            //Console.WriteLine("Type in a message, and I'll display it five times.");
            //Console.Write("Message: ");
            //string message = Console.ReadLine();
            //while (count < 5)
            //{
            //    Console.WriteLine((count + 1) + ". " + message);
            //    count++;
            //}

            //Console.WriteLine("Task three");
            //int total = 0;
            //int count = 0;
            //int numbers = 5;
            //int input;
            //Console.WriteLine("Enter five numbers and I will add them.");
            //while (count < numbers)
            //{
            //    Console.WriteLine("Please enter a number.");
            //    input = Convert.ToInt32(Console.ReadLine());
            //    total += input;
            //    count++;
            //}
            //Console.WriteLine();
            //Console.WriteLine("The total is: " + total);
        }
    }
}
