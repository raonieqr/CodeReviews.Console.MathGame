namespace CodeReviews.MathGame
{
    public class GameLog
    {
        List<String> log;

        public GameLog() { 
            this.log = new List<String>();
        }

        public void AddLog(string questionAndResult)
        {
            this.log.Add(questionAndResult);
        }

        public void ShowLog()
        {
            Console.WriteLine("Game Log:");
            foreach (var entry in log)
            {
                Console.WriteLine(entry);
            }
        }

    }
}
