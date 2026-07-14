
namespace CodeReviews.MathGame
{
    public class MultiplicationOperation : IMathOperation
    {
        public Operation Type => Operation.Multiplication;
        public string Symbol => "*";
        public int Calculate(int a, int b) => a * b;
    }
}
