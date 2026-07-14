namespace CodeReviews.MathGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Math Game!");
            var operation = PromptOperationChoice();

            if (operation == null)
            {
                Console.WriteLine("Invalid operation selected.");
                return;
            }

            try
            {
                var questionGenerator = new QuestionGenerator(operation.Value);
                int result = questionGenerator.calculate();
                Console.WriteLine($"Your total points: {result} points");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        static Operation? PromptOperationChoice()
        {
            Console.WriteLine("Choose a type of operation: ");
            foreach (Operation op in Enum.GetValues(typeof(Operation)))
                Console.WriteLine($"{(int)op}. {op.GetDescription()}");

            string? input = Console.ReadLine();
            if (int.TryParse(input, out var value) && Enum.IsDefined(typeof(Operation), value))
                return (Operation)value;

            return null;
        }
    }
}