using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace InheritanceC
{
    class VideoPost: Post
    {
        // member fields
        protected bool isPlaying = false;
        protected int currDuration = 0;
        Timer timer;

        //props
        protected string VideoURL { get; set; }

        protected int Length { get; set; }

        public VideoPost() { }

        public VideoPost(string title, string sendByUsername, string videoURL, int length, bool isPublic)
        {
            this.ID = GetNextId();
            this.Title = title;
            this.SendByUsername = sendByUsername;
            this.VideoURL = videoURL;
            this.IsPublic = isPublic;
            this.Length = length;
        }

        public void Play()
        {
            if (!isPlaying)
            {
                isPlaying = true;
                Console.WriteLine("Playing!");
                timer = new Timer(TimerCallback, null, 0, 1000);
            }

        }


        private void TimerCallback(Object o)
        {
            if(currDuration < Length)
            {
                currDuration++;
                Console.WriteLine($"Video at {currDuration} seconds");
                GC.Collect();
            } else
            {
                Stop();
            }
        }
        public void Stop()
        {
            if (isPlaying)
            {
                isPlaying = false;
                Console.WriteLine($"Stopped at {currDuration} seconds");
                currDuration = 0;
                timer.Dispose();
            }

        }

        public override string ToString()
        {
            return String.Format($"{this.ID} - {this.Title} - {this.VideoURL} - {this.Length} seconds - by {this.SendByUsername}");
        }


    }
}
