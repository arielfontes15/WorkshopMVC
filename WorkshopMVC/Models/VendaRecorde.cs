using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WorkshopMVC.Models.Enumeradores;

namespace WorkshopMVC.Models
{
    public class VendaRecorde
    {
        public int Id { get; set; }
        [Display(Name = "Data da Venda")]
        public DateTime Data { get; set; }
        [Display(Name = "Quantia")]
        public double Quantia { get; set; }
        [Display(Name = "Status da Venda")]
        public VendaStatus Status { get; set; }

        // (1:1)
        public Vendedor Vendedor { get; set; }

        public VendaRecorde()
        {
        }

        public VendaRecorde(int id, DateTime data, double quantia, VendaStatus status, Vendedor vendedor)
        {
            Id = id;
            Data = data;
            Quantia = quantia;
            Status = status;
            Vendedor = vendedor;
        }
    }
}
