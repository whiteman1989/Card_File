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
        public IRepository<TextMaterial> TextMaterials { get;}
        public IRepository<MaterialPart> MaterialParts { get;}
        public IRepository<UserProfile> UserProfiles { get;}
        public IRepository<Category> Categories { get;}
        public IRepository<Comment> Comments { get;}
        public IRepository<Tag> Tags { get;}
        void Save();
        Task SaveAsync();
    }
}
