using System;
using System.Collections.Generic;

namespace ExceptionHandling
{
    public class YoutubeApi
    {
        public List<Video> GetVideos(string user)
        {
            try
            {
                // Access Youtube web service
                // Read the data
                // Create a list of Video objects

                throw new Exception("Oops some low level Youtube error");
            }
            catch (Exception ex)
            {
                // Log

                throw new YoutubeException("Could not fetch the videos from Youtube.", ex);
            }

            return new List<Video>();
        }
    }
}