using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;

namespace Card_File.DAL.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public virtual UserProfile UserProfile { get; set; }
        public  virtual ICollection<IdentityRole> Roles { get; set; }
    }
}
