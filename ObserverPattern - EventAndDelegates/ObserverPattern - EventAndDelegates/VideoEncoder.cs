using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ObserverPattern___EventAndDelegates
{
    public class VideoEncoder
    {
        //1.Create Delegate
        //public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);

        //2.Create Event
        //public event VideoEncodedEventHandler VideoEncoded;

        //4. Can Utilize what .NET has available already....
        public event EventHandler<VideoEventArgs> VideoEncoded;

        //Encoding Method
        public void Encode(Video video)
        {
            Console.WriteLine("Encoding Video...");
            Thread.Sleep(3000);
            OnVideoEncoded(video);
        }
        //3. Define method to send data to Observers
        protected virtual void OnVideoEncoded(Video video)
        {
            if (VideoEncoded != null)
            {
                VideoEncoded(this, new VideoEventArgs(){Video = video});
            }
        }
    }
}
