using NetGit.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetGit.Web.Services
{
    public interface IGitService
    {
        public RepositoryInfo CreateNewRepository(RepositoryInfo repo);
    }
}
