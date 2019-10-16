using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LoginRegistration.Models;

namespace LoginRegistration.Pages.Hello
{
    public class IndexModel : PageModel
    {
        private readonly LoginRegistration.Models.LoginRegistrationContext _context;

        public IndexModel(LoginRegistration.Models.LoginRegistrationContext context)
        {
            _context = context;
        }

        public IList<MyUser> MyUser { get;set; }

        public async Task OnGetAsync()
        {
            MyUser = await _context.MyUser.ToListAsync();
        }
    }
}
