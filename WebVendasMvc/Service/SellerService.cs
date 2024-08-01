using System.Collections.Generic;
using System.Linq;
using WebVendasMvc.Data;
using WebVendasMvc.Models;

namespace WebVendasMvc.Service
{
    public class SellerService
    {
        private readonly WebVendasMvcContext _context;

        public SellerService(WebVendasMvcContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }

        public void Insert(Seller obj)
        {
            obj.Department = _context.Department.First();
            _context.Add(obj);
            _context.SaveChanges();
        }
    }
}
