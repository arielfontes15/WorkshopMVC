using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkshopMVC.Data;
using WorkshopMVC.Models;

namespace WorkshopMVC.Services
{
    public class Service
    {
        private readonly WorkshopMVCContext _context;

        public Service(WorkshopMVCContext context)
        {
            _context = context;
        }

        public List<Vendedor> FindAll()
        {
            return _context.Vendedor.ToList();
        }

        public void Insert(Vendedor obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }

    }
}
