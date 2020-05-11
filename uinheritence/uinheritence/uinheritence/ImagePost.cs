using System;
using System.Collections.Generic;
using System.Text;

namespace uinheritence
{
    class ImagePost:Post
    {
        public string ImageURL { get; set; }


        public ImagePost() { }

        public ImagePost(string title, string sendByUserName, string imaageURL, bool isPublic) 
        {
            // these inherited from post
            this.Id = GetNextId();
            this.Title = title;
            this.SendByUderName = sendByUserName;
            this.IsPublic = isPublic;
            //this is from the imagepost
            this.ImageURL = imaageURL;

        }
        public override string ToString()
        {
            return string.Format("{0} - {1} - {2} - {3}", this.Id, this.Title, this.ImageURL, this.SendByUderName);
        }

    }
}
