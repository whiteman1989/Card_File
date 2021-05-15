using System;
using System.Collections.Generic;
using System.Text;

namespace Card_File.BLL.DTO
{
    public class TagDto
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public ICollection<TextMaterialDto> TextMaterials { get; set; }
    }
}
