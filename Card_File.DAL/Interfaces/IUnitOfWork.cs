using System;
using System.Collections.Generic;
using System.Text;
using Card_File.DAL.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace Card_File.DAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        public IRepository<TextMaterial> TextMaterials { get; set; }
        public IRepository<MaterialPart> MaterialParts { get; set; }
        public IRepository<UserProfile> UserProfiles { get; set; }
        public IRepository<Category> Categories { get; set; }
        public IRepository<Comment> Comments { get; set; }
        public IRepository<Tag> Tags { get; set; }
        void Save();
        Task SaveAsync();
    }
}
