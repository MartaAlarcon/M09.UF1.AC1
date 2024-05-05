using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using M09.UF1.AC1.Data;
using M09.UF1.AC1.Models;

namespace M09.UF1.AC1.Pages.Clientes
{
    public class DetailsModel : PageModel
    {
        private readonly M09.UF1.AC1.Data.M09UF1AC1Context _context;

        public DetailsModel(M09.UF1.AC1.Data.M09UF1AC1Context context)
        {
            _context = context;
        }

        public Cliente Cliente { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cliente = await _context.Cliente.FirstOrDefaultAsync(m => m.Id == id);
            if (cliente == null)
            {
                return NotFound();
            }
            else
            {
                Cliente = cliente;
            }
            return Page();
        }
    }
}
