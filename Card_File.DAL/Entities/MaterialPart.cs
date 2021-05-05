using System;
using System.Collections.Generic;
using System.Text;

namespace Card_File.DAL.Entities
{
    public class MaterialPart
    {
        public int Id { get; set; }
        public int TextNaterialId { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public virtual TextMaterial TextMaterial { get; set; }
    }
}
