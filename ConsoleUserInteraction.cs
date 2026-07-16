namespace CodeReviews.MathGame
{
    public class ConsoleUserInteraction
    {
        int userPoints = 0;
        private GameLog log;

        public ConsoleUserInteraction()
        {
            log = new GameLog();
        }

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

            int userAnswer = GetUserInput();
            bool isCorrect = userAnswer == result;

            if (isCorrect)
            {
                Console.WriteLine("Correct!");
                userPoints++;
            }
            else
            {
                Console.WriteLine($"Incorrect! The correct answer is {result}.");
            }

            log.AddLog($"{item.Value[0]} {symbol} {item.Value[1]} = {result} | your answer: {userAnswer}");
        }

        public int GetUserPoints()
        {
            return userPoints;
        }

        public void SetGameLog(GameLog gameLog)
        {
            this.log = gameLog;
        }

        public void ShowGameLog()
        {
            log.ShowLog();
        }

    }
}
