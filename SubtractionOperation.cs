
namespace CodeReviews.MathGame
{
    public class SubtractionOperation : IMathOperation
    {
        public Operation Type => Operation.Subtraction;
        public string Symbol => "-";
        public int Calculate(int a, int b) => a - b;
    }
}
