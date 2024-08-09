using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Events
{
    internal class Player
    {
        public string PlayerName { get; set; }
        public string TeamName { get; set; }
        
        // Call back function
        public void Run(Ball ball) // must follow the signature of the delegate
        {
            Console.WriteLine($"Player: {PlayerName} is running to the ball in location: {ball.Location}.");
        }
    }
}
