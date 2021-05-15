using System;
using System.Collections.Generic;
using System.Text;

namespace Card_File.DAL.Entities
{
    public class TextMaterial
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string UserProfileId { get; set; }
        public int CategotyId { get; set; }
        public bool IsHide { get; set; }
        public DateTime Date { get; set; }
        public DateTime EditDate { get; set; }
        public virtual Category Category { get; set; }
        public virtual UserProfile GetUserProfile { get; set; }
        public virtual ICollection<MaterialPart> MaterialParts { get; set; }
        public virtual ICollection<Tag> Tags { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
    }
}
