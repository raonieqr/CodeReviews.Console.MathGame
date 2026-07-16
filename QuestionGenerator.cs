using CodeReviews.MathGame;

public class QuestionGenerator
{
    private const int NUMBER_OF_QUESTION = 5;

    private Operation operation;

    public QuestionGenerator(Operation operation)
    {
        this.operation = operation;
    }

    private readonly Dictionary<Operation, IMathOperation> _operations = new()
    {
        { Operation.Addition, new AdditionOperation() },
        { Operation.Subtraction, new SubtractionOperation() },
        { Operation.Division, new DivisionOperation() },
        { Operation.Multiplication, new MultiplicationOperation() },
    };

    public int Calculate(ConsoleUserInteraction consoleUserInteraction)
    {
        Dictionary<string, List<int>> mapOfQuestion = RandomNumberAndQuestion();
        IMathOperation op = _operations[operation];


        foreach (KeyValuePair<string, List<int>> item in mapOfQuestion)
        {
            int numberOne = item.Value[0];
            int numberTwo = item.Value[1];
            try
            {
                int result = op.Calculate(numberOne, numberTwo);
                consoleUserInteraction.ShowQuestion(item, result, op.Symbol);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Skipping division by zero question.");
                continue;
            }

        }

        return consoleUserInteraction.GetUserPoints();

    }


    public Dictionary<string, List<int>> RandomNumberAndQuestion()
    {
        Dictionary<string, List<int>> questions = new Dictionary<string, List<int>>();
        Random random = new Random();

        for (int i = 0; i < NUMBER_OF_QUESTION; i++)
        {
            questions.Add($"Question {i + 1}", new List<int> { random.Next(0, 100), random.Next(1, 100) });
        }

        return questions;
    }

}
