using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NetGit.Web.Services;

namespace NetGit.Web.Pages.Repositories
{
    public class IndexModel : PageModel
    {
        public IndexModel(IRepositoryService service)
        {
            Service = service;
        }

        public IRepositoryService Service { get; }

        public IEnumerable<Models.RepositoryInfo> Repositories
        {
            get
            {
                return Service.FindAll();
            }
        }

        public void OnGet()
        {
            
        }
    }
}
