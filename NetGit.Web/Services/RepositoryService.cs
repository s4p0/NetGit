using NetGit.Web.Database;
using NetGit.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetGit.Web.Services
{
    public class RepositoryService : IRepositoryService
    {
        private readonly LiteDBContext _db;

        public RepositoryService(LiteDBContext db)
        {
            this._db = db;
        }


        public bool Delete(RepositoryInfo entity)
        {
            return _db.Context
                .GetCollection<RepositoryInfo>()
                .DeleteMany(p => p.Id == entity.Id) > 0;
        }

        public IEnumerable<RepositoryInfo> FindAll()
        {
            return _db.Context
                .GetCollection<RepositoryInfo>()
                .FindAll();
        }

        public RepositoryInfo FindOne(int id)
        {
            return _db.Context
                .GetCollection<RepositoryInfo>()
                .FindOne(p => p.Id == id);
        }

        public bool Insert(RepositoryInfo entity)
        {
            return _db.Context
                .GetCollection<RepositoryInfo>()
                .Insert(entity) > 0;
        }

        public bool Update(RepositoryInfo entity)
        {
            return _db.Context
                .GetCollection<RepositoryInfo>()
                .Update(entity);
        }
    }
}
