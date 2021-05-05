using System;
using System.Collections.Generic;
using System.Text;

namespace Card_File.DAL.Entities
{
    public class Comment
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public int UserProfileId { get; set; }
        public virtual UserProfile GetUserProfile { get; set; }

    }
}
