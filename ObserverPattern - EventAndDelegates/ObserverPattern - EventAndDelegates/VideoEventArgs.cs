using System;

namespace ObserverPattern___EventAndDelegates
{
    public class VideoEventArgs : EventArgs
    {
        public Video Video { get; set; }
    }
}
