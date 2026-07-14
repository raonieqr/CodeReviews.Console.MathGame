
namespace CodeReviews.MathGame
{
    public class DivisionOperation : IMathOperation
    {
        public Operation Type => Operation.Division;
        public string Symbol => "/";
        public int Calculate(int a, int b)
        {
            if (b == 0)
                throw new DivideByZeroException();
            return a / b;
        }
    }
}
