using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    internal class Channel
    {
        public string ChannelName { get; set; }
        public List<Video> Videos { get; set; } // = new List<Video>(); // also possible

        public override string ToString()
        {
            return $"Channel name: {ChannelName}";
        }

        // When to invoke the event action
        public void AddVideo(Video video)
        {
            Videos.Add(video);

            // Notify Subscriber
            // Same signature as the delegate
            UploadVideo?.Invoke(video, this);
        }

        // Creating the event action
        // Notes the signature of the delegate
        public event Action<Video, Channel> UploadVideo;
        
        // You can do this or you write it directly above when declaring the property
        public Channel()
        {
            Videos = new List<Video>();
        }
    }
}
