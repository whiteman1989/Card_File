using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Card_File.DAL.Entities
{
    public class Tag
    {
        [Key]
        public int Id { get; set; }
        public string Text { get; set; }
        public virtual ICollection<TextMaterial> TextMaterials { get; set; }
    }
}
