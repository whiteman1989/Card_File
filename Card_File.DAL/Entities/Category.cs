using System;
using System.Collections.Generic;
using System.Text;

namespace Card_File.DAL.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public virtual ICollection<TextMaterial> TextMaterials { get; set; }
    }
}
