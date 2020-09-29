using LeedsTwitterBot.ApiServices;

namespace LeedsTwitterBot
{
    class Program
    {
        static void Main(string[] args)
        {
            StartUp s = new StartUp();
            s.Run();

            //SendTweet s = new SendTweet();
            //s.SimpleTweet("leeds");
        }
    }
}
