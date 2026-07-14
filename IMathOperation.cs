
namespace CodeReviews.MathGame
{
    public interface IMathOperation
    {
        Operation Type { get; }
        string Symbol { get; }
        int Calculate(int a, int b);
    }
}
