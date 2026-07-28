namespace CodeReviews.MathGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            Console.WriteLine("Welcome to the Math Game!");
            var consoleUserInteraction = new ConsoleUserInteraction();

            while (true)
            {
                int choice = PromptMenuChoice();

                if (choice == 9)
                {
                    Console.WriteLine("Exiting the game. Goodbye!");
                    break;
                }

                if (choice == 8)
                {
                    consoleUserInteraction.ShowGameLog();
                    continue;
                }

                if (!Enum.IsDefined(typeof(Operation), choice))
                {
                    Console.WriteLine("Invalid operation selected. Try again.");
                    continue;
                }

                var operation = (Operation)choice;

                try
                {
                    var questionGenerator = new QuestionGenerator(operation);
                    questionGenerator.Calculate(consoleUserInteraction);
                    Console.WriteLine($"Your total points: {consoleUserInteraction.GetUserPoints()} points");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }
        }

        static int PromptMenuChoice()
        {
            Console.WriteLine("Choose a type of operation: ");
            foreach (Operation op in Enum.GetValues(typeof(Operation)))
                Console.WriteLine($"{(int)op}. {op.GetDescription()}");

            Console.WriteLine("8. View logs");
            Console.WriteLine("9. Exit");

            string? input = Console.ReadLine();
            int.TryParse(input, out var value);
            return value;
        }
    }
}