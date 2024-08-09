namespace Events
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Event driven programming
            // It's when I can link a function to an event
            // C# Keyword event

            #region EX01
            Ball ball = new Ball() { Id = 1 };
            Console.WriteLine(ball);
            ball.Location = new Location() { X = 1, Y = 2, Z = 3 };
            Console.WriteLine(ball + "\n");

            Player P01 = new Player() { PlayerName = "Messi", TeamName = "Miami" };
            Player P02 = new Player() { PlayerName = "Alba", TeamName = "Miami" };

            Player P03 = new Player() { PlayerName = "Pedri", TeamName = "Barcelona" };
            Player P04 = new Player() { PlayerName = "Gavi", TeamName = "Barcelona" };

            Referee R01 = new Referee() { RefereeName = "Ibrahim Nour Eldin" };

            Player P05 = new Player() { PlayerName = "Salah", TeamName = "Barcelona" };


            // Invocation list
            // Normal delegate uses =
            // event delegate uses +=
            ball.BallLocationChanged += P01.Run; // not =
            ball.BallLocationChanged += P02.Run;
            ball.BallLocationChanged += P03.Run;
            ball.BallLocationChanged += P04.Run;
            ball.BallLocationChanged += R01.Look;

            ball.Location = new Location() { X = 4, Y = 5, Z = 6 };

            Console.WriteLine("\nAfter Salah changed with Pedri\n");
            ball.BallLocationChanged -= P03.Run;
            ball.BallLocationChanged += P05.Run;
            ball.Location = new Location() { X = 7, Y = 8, Z = 9 };
            #endregion

            #region EX02
            Channel channel = new Channel() { ChannelName = "ABC" };
            channel.AddVideo(new Video() { Title = "Title01", Description = "Description01" });

            Subscriber sub01 = new Subscriber() { SubscriberName = "Ahmed" };
            Subscriber sub02 = new Subscriber() { SubscriberName = "Mohammed" };
            Subscriber sub03 = new Subscriber() { SubscriberName = "Karim" };
            Subscriber sub04 = new Subscriber() { SubscriberName = "Fayez" };
            Subscriber sub05 = new Subscriber() { SubscriberName = "Moustafa" };

            channel.UploadVideo += sub01.Notify;
            channel.UploadVideo += sub02.Notify;
            channel.UploadVideo += sub03.Notify;
            channel.UploadVideo += sub04.Notify;
            channel.UploadVideo += sub05.Notify;

            channel.AddVideo(new Video() { Title = "Title02", Description = "Description02" });

            channel.UploadVideo -= sub04.Notify;
            channel.UploadVideo -= sub05.Notify;
            Console.WriteLine("/nAfter change of subscribers");
            channel.AddVideo(new Video() { Title = "Title03", Description = "Description03" });
            Console.WriteLine();
            #endregion
        }
    }
}
