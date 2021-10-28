using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkshopMVC.Models;
using WorkshopMVC.Models.Enumeradores;

namespace WorkshopMVC.Data
{
    public class SeedingService
    {
        private WorkshopMVCContext _context;

        public SeedingService(WorkshopMVCContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Departamento.Any() ||
                _context.Vendedor.Any() ||
                _context.VendaRecorde.Any())
            {
                return; // DB ja foi populado
            }


            Departamento d1 = new Departamento(1, "Computadores");
            Departamento d2 = new Departamento(2, "Notebooks");

            Vendedor s1 = new Vendedor(1, "Claudio", "teste@hotmail.com", new DateTime(1996, 5, 25), 1000.0, d2);
            Vendedor s2 = new Vendedor(2, "Marcos", "teste3@hotmail.com", new DateTime(1999, 5, 24), 1000.0, d1);

            VendaRecorde r1 = new VendaRecorde(1, new DateTime(2018, 09, 11), 11100.0, VendaStatus.Faturada, s1);


            _context.Departamento.AddRange(d1, d2);
            _context.Vendedor.AddRange(s1, s2);
            _context.VendaRecorde.AddRange(r1);

            _context.SaveChanges();
        }

    }
}
