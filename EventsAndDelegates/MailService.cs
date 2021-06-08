using System;

namespace EventsAndDelegates
{
    public class MailService
    {
        //public void OnVideoEncoded(object source, EventArgs e)
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            //Console.WriteLine("MailService: Sending an mail...");
            Console.WriteLine("MailService: Sending an mail..." + e.Video.Title);
        }
    }
}