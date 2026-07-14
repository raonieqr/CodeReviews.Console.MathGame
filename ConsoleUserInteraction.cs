namespace CodeReviews.MathGame
{
    internal class ConsoleUserInteraction
    {
        int userPoints = 0;

        private int GetUserInput()
        {
            while (true)
            {
                Console.WriteLine("Enter your answer: ");
                var input = Console.ReadLine();
                if (input != null && int.TryParse(input, out var value))
                {
                    return value;
                }
            }

            throw new ArgumentException("Invalid input. Please enter a valid integer.");

        }

        public void ShowQuestion(KeyValuePair<string, List<int>> item, int result, string symbol)
        {

            Console.WriteLine($"Question: {item.Key} - What is {item.Value[0]} {symbol} {item.Value[1]}?");

            int resultOfQuestion = GetUserInput();
            if (resultOfQuestion == result)
            {
                Console.WriteLine("Correct!");
                userPoints++;
            }
            else
            {
                Console.WriteLine($"Incorrect! The correct answer is {result}.");
            }
        }

        public int GetUserPoints()
        {
            return userPoints;
        }

    }
}
