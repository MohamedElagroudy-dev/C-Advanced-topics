using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventd__Observer_pattern
{
    public delegate void VideoUpload(string name);
    public class YouTubeChannel
    {
        public VideoUpload VideoUpload;
        public void UpladVideos(string videoTitle)
        {
            Console.WriteLine($"New vedio uploaded {videoTitle}");
            VideoUpload.Invoke( videoTitle );

        }
    }

    public class Subscriber
    {
        public void Subscribe(YouTubeChannel channel)
        {
            channel.VideoUpload += WatchTheVedio;
        }
        public void WatchTheVedio(string videoTitle)
        {
            Console.WriteLine($"User wath {videoTitle}");
        }
    }
}
