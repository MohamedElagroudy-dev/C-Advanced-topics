namespace Eventd__Observer_pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            YouTubeChannel channel = new YouTubeChannel();

            Subscriber subscriber1 = new Subscriber();
            Subscriber subscriber2 = new Subscriber();
            Subscriber subscriber3 = new Subscriber();

            subscriber1.Subscribe(channel);
            subscriber2.Subscribe(channel);
            subscriber3.Subscribe(channel);

            channel.UpladVideos("How to fuck Honey Gold");

            channel.VideoUpload("Vedio X"); // Proplem....direct invoke
        }
    }
}
