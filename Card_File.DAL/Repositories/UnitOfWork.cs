using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Card_File.DAL.Entities;
using Card_File.DAL.Interfaces;
using Card_File.DAL.EF;

namespace Card_File.DAL.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationContext _appContext;
        private IRepository<TextMaterial> _textMaterials;
        private IRepository<MaterialPart> _materialParts;
        private IRepository<UserProfile> _userProfiles;
        private IRepository<Category> _categories;
        private IRepository<Comment> _comments;
        private IRepository<Tag> _tags;

        public UnitOfWork(ApplicationContext applicationContext)
        {
            _appContext = applicationContext;
        }

        public IRepository<TextMaterial> TextMaterials => 
            _textMaterials  = _textMaterials ?? new EntityRepository<TextMaterial>(_appContext);
        public IRepository<MaterialPart> MaterialParts =>
            _materialParts = _materialParts ?? new EntityRepository<MaterialPart>(_appContext);
        public IRepository<UserProfile> UserProfiles =>
            _userProfiles = _userProfiles ?? new EntityRepository<UserProfile>(_appContext);
        public IRepository<Category> Categories =>
            _categories = _categories ?? new EntityRepository<Category>(_appContext);
        public IRepository<Comment> Comments =>
            _comments = _comments ?? new EntityRepository<Comment>(_appContext);
        public IRepository<Tag> Tags =>
            _tags = _tags ?? new EntityRepository<Tag>(_appContext);

        public void Dispose()
        {
            _appContext.Dispose();
        }

        public void Save()
        {
            _appContext.SaveChanges();
        }

        public async Task SaveAsync()
        {
            await _appContext.SaveChangesAsync();
        }

    }
}
