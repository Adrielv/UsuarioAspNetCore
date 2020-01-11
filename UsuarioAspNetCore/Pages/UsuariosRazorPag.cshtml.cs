using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using UsuarioAspNetCore.Data;
using UsuarioAspNetCore.Models;

namespace UsuarioAspNetCore.Pages
{
    public class UsuariosRazorPagModel : PageModel
    {
        private readonly UsuarioAspNetCore.Data.Contexto _context;

        public UsuariosRazorPagModel(UsuarioAspNetCore.Data.Contexto context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Usuarios Usuarios { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Customers.Add(Usuarios);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}