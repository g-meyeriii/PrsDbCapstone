using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace uinheritence
{
    class VideoPost:Post
    {
        //member fields
        protected bool isPlaying = false;
        protected int currDuaration = 0;
        Timer timer;

        //Properties
        protected string VideoURL { get; set; }
        protected int Length { get; set; }


        public VideoPost() { }

        public VideoPost(string title, string sendByUserName, string videoURL, int length,bool isPublic)
        {
            // these inherited from post
            this.Id = GetNextId();
            this.Title = title;
            this.SendByUderName = sendByUserName;
            this.IsPublic = isPublic;
            //this is from the Videopost
            this.VideoURL = videoURL;
            this.Length = length;

        }
        public override string ToString()
        {
            return string.Format("{0} - {1} - {2} - {3} - {4}", this.Id, this.Title, this.VideoURL, this.Length, this.SendByUderName);
        }
        public void Play()
        {
            if (!isPlaying)
            {
                isPlaying = true;
                Console.WriteLine("Playing");
                timer = new Timer(TimerCallback, null, 0, 1000);
            }
        }
        private void TimerCallback(Object o)
        {
            if(currDuaration < Length)
            {
                currDuaration++;
                Console.WriteLine("Video at {0}'s", currDuaration);
                GC.Collect();
            }
            else
            {
                Stop();
            }
        }

        public void Stop()
        {
            if (isPlaying)
            {
                isPlaying = false;
                Console.WriteLine("Stopped at {0}s", currDuaration);
                currDuaration = 0;
                timer.Dispose();
            }
        }
    }
}
