using System;
using System.Collections.Generic;
using System.Text;

namespace Card_File.BLL.DTO
{
    public class TextMaterialDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string UserId { get; set; }
        public int CategotyId { get; set; }
        public bool IsHide { get; set; }
        public DateTime Date { get; set; }
        public DateTime EditDate { get; set; }
        public virtual CategoryDto Category { get; set; }
        public virtual UserDto GetUserProfile { get; set; }
        public virtual ICollection<MaterialPartDto> MaterialParts { get; set; }
        public virtual ICollection<TagDto> Tags { get; set; }
    }
}
