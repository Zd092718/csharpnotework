using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceC
{
    class Post
    {
        private static int currentPostId;


        //props

        protected int ID { get; set; }
        protected string Title { get; set; }
        protected string SendByUsername { get; set; }
        protected bool IsPublic { get; set; }

        //Default constructor. If a derived class doesn't invoke a
        //base-class constructor explicitly,
        //the default constructor is called implicitly.
        public Post()
        {
            ID = 0;
            Title = "My First Post";
            IsPublic = true;
            SendByUsername = "Zack Dowd";
        }

        // instance constructor with three parameters
        public Post(string title, bool isPublic, string sendByUsername)
        {
            this.ID = GetNextId();
            this.Title = title;
            this.SendByUsername = sendByUsername;
            this.IsPublic = isPublic;
        }

        protected int GetNextId()
        {
            return ++currentPostId;
        }

        public void Update(string title, bool isPublic)
        {
            this.Title = title;
            this.IsPublic = isPublic;
        }

        public override string ToString()
        {
            return String.Format($"{this.ID} - {this.Title} - by {this.SendByUsername}");
        }
    }
}
