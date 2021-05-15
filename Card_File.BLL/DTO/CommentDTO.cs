using System;
using System.Collections.Generic;
using System.Text;

namespace Card_File.BLL.DTO
{
    public class CommentDto
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public int Rating { get; set; }
        public string UserProfileId { get; set; }
        public int TextMaterialId { get; set; }
        public bool IsHide { get; set; }
        public DateTime Date { get; set; }
        public DateTime EditDate { get; set; }
        public virtual UserDto User { get; set; }
        public virtual TextMaterialDto TextMaterial { get; set; }
    }
}
