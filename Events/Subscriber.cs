using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    internal class Subscriber
    {
        public string SubscriberName { get; set; }
        public override string ToString()
        {
            return $"Subscriber Name: {SubscriberName}.";
        }
        public void Notify(Video video, Channel channel) // Same signature as the delegate
        {
            Console.WriteLine($"Hello {SubscriberName}, a new video titled {video.Title} has been uploaded to the channel {channel.ChannelName}.");
        }
    }
}
