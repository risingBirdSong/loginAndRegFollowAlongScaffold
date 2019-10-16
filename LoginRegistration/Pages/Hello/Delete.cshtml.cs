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
    public class DeleteModel : PageModel
    {
        private readonly LoginRegistration.Models.LoginRegistrationContext _context;

        public DeleteModel(LoginRegistration.Models.LoginRegistrationContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            MyUser = await _context.MyUser.FindAsync(id);

            if (MyUser != null)
            {
                _context.MyUser.Remove(MyUser);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
