using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    internal class Ball
    {
        public int Id { get; set; }
        private Location location;

        public Location Location
        {
            get { return location; }
            set
            {
                if (!value.Equals(location)) // To make sure we have new location
                {
                    location = value;
                    // Notify Subscribers
                    // When location is changed, activate all the functions related to it
                    // BallLocationChanged?.Invoke(); // old version
                    // Must follow the signature of the delegate
                    BallLocationChanged?.Invoke(this);
                }
            }
        }

        // Event
        // public event Action? BallLocationChanged; // old version
        public event Action<Ball>? BallLocationChanged;

        public override string ToString()
        {
            return $"Ball: Id = {Id}, Location = {location}";
        }
    }
}
