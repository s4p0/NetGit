using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NetGit.Web.Models;
using NetGit.Web.Services;

namespace NetGit.Web.Pages.Repositories
{
    public class CreateModel : PageModel
    {
        private readonly IRepositoryService service;
        private readonly IGitService gitService;

        [BindProperty]
        public RepositoryInfo Repository { get; set; }

        public CreateModel(IRepositoryService service, IGitService gitService)
        {
            this.service = service;
            this.gitService = gitService;
        }
        
        public IActionResult OnGet()
        {
            return Page();
        }

        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            service.Insert(gitService.CreateNewRepository(Repository));

            return RedirectToPage("./Index");
        }
    }
}
