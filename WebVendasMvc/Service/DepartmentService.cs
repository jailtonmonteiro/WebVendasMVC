using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebVendasMvc.Data;
using WebVendasMvc.Models;

namespace WebVendasMvc.Service
{
    public class DepartmentService
    {
        private readonly WebVendasMvcContext _context;
        public DepartmentService(WebVendasMvcContext context)
        {
            _context = context;
        }

        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }
    }
}
