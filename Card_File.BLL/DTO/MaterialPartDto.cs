using System;
using System.Collections.Generic;
using System.Text;

namespace Card_File.BLL.DTO
{
    public class MaterialPartDto
    {
        public int Id { get; set; }
        public int TextNaterialId { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public virtual TextMaterialDto TextMaterial { get; set; }
    }
}
