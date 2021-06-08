using System;
using System.Threading;

namespace EventsAndDelegates
{
    public class VideoEventArgs : EventArgs
    {
        public Video Video { get; set; }
    }

    public class VideoEncoder
    {
        // 1 - Define a delegate
        // 2 - Define an event based on that delegate
        // 3 - Raise an event

        //public delegate void VideoEncodedEventHandler(object source, EventArgs args); // Naming convention NameOfEventEventHandler
        //public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);

        //public event VideoEncodedEventHandler VideoEncoded; // Event based on the delegate, naming convention past tense

        // EventHandler
        // EventHandler<TEventArgs>

        public event EventHandler<VideoEventArgs> VideoEncoded;
        public event EventHandler VideoEncoding;

        public void Encode(Video video)
        {
            Console.WriteLine("Encoding Video...");
            Thread.Sleep(3000);

            //OnVideoEncoded();
            OnVideoEncoded(video);
        }

        //protected virtual void OnVideoEncoded() // .NET convention is protected virtual void. Naming convention OnNameOfEvent
        protected virtual void OnVideoEncoded(Video video) 
        {
            if (VideoEncoded != null) // if there are any subscribers
                //VideoEncoded(this, EventArgs.Empty);
                VideoEncoded(this, new VideoEventArgs() { Video = video });
        }
    }
}