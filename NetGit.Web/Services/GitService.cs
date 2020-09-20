using LibGit2Sharp;
using NetGit.Web.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace NetGit.Web.Services
{
    public class GitService : IGitService
    {
        public string SubDirectory { get; set; }

        public GitService()
        {
            SubDirectory = ".repos";
        }

        public RepositoryInfo CreateNewRepository(RepositoryInfo repo)
        {
            var relativePath = Path.Combine(SubDirectory, Guid.NewGuid().ToString(), repo.Name);

            repo.Path = Repository.Init(relativePath);

            return repo;
        }
    }
}
