using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace uinheritence
{
    class Post
    {
        private static int currentPostId;

        //properties
        protected int Id { get; set; }
        protected string Title { get; set; }
        protected string SendByUderName { get; set; }
        protected bool IsPublic { get; set; }


        public Post() 
        {
            Id = 0;
            Title = "My First Post";
            IsPublic = true;
            SendByUderName = "G M";
        }

        //
        public Post(string title, bool isPublic, string sendByUserName)
        {
            this.Id = GetNextId() ;
            this.Title = title ;
            this.IsPublic = isPublic;
            this.SendByUderName = sendByUserName;
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
            return string.Format("{0} - {1} - {2}", this.Id, this.Title, this.SendByUderName);
        }
        

    }
}
