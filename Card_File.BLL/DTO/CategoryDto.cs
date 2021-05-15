using System;
using System.Collections.Generic;
using System.Text;

namespace Card_File.BLL.DTO
{
    public class CategoryDto
    {
        public int Id { get; set; }
        public string CategorName { get; set; }
        public ICollection<TextMaterialDto> TextMaterials { get; set; }
    }
}
