using System;
using System.Collections.Generic;
using System.Text;

namespace Card_File.DAL.Entities
{
    public class Comment
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public int Rating { get; set; }
        public string UserProfileId { get; set; }
        public int TextMaterialId { get; set; }
        public bool IsHide { get; set; }
        public DateTime Date { get; set; }
        public DateTime EditDate { get; set; }
        public virtual UserProfile UserProfile { get; set; }
        public virtual TextMaterial TextMaterial { get; set; }

    }
}
