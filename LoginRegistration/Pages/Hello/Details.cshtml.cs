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
    public class DetailsModel : PageModel
    {
        private readonly LoginRegistration.Models.LoginRegistrationContext _context;

        public DetailsModel(LoginRegistration.Models.LoginRegistrationContext context)
        {
            _context = context;
        }

        public MyUser MyUser { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            MyUser = await _context.MyUser.FirstOrDefaultAsync(m => m.ID == id);

            if (MyUser == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
