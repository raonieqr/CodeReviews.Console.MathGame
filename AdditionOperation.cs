namespace CodeReviews.MathGame
{
    public class AdditionOperation : IMathOperation
    {
        public Operation Type => Operation.Addition;
        public string Symbol => "+";
        public int Calculate(int a, int b) => a + b;
    }
}
