using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetGit.Web.Models
{
    public class RepositoryInfo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public bool IsEnabled { get; set; }
    }
}
