using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    internal class Referee
    {
        public string RefereeName { get; set; }
        
        // Call back function
        public void Look(Ball ball) // must follow the signature of the delegate
        {
            Console.WriteLine($"Referee: {RefereeName} is looking at the ball in location: {ball.Location}.");
        }
    }
}
