using System;

namespace ExceptionHandling
{
    public class YoutubeException : Exception
    {
        public YoutubeException(string message, Exception innException)
            : base(message, innException)
        {
            
        }
    }
}