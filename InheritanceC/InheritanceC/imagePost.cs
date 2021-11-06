using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceC
{
    class ImagePost: Post
    {
        protected string ImageURL { get; set; }

        public ImagePost()
        {
        }

        public ImagePost(string title, string sendByUsername, string imageURL, bool isPublic)
        {
            this.ID = GetNextId();
            this.Title = title;
            this.SendByUsername = sendByUsername;
            this.ImageURL = imageURL;
            this.IsPublic = isPublic;
        }

        public override string ToString()
        {
            return String.Format($"{this.ID} - {this.Title} - {this.ImageURL} - by {this.SendByUsername}");
        }
    }
}
