using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace WorkshopMVC.Models
{
    public class Departamento
    {
        public int Id { get; set; }
        [Display(Name = "Nome do Departamento")]
        [Required(ErrorMessage = "O campo {0} é obrigatorio!")]
        public string Name { get; set; }

        //Relacionamento entre a tabela Vendedor 1 Vendedor para Muitos (1:N)
        public ICollection<Vendedor> Vendedores { get; set; } = new List<Vendedor>();

        public Departamento()
        {
        }

        public Departamento(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void AdicionarVendedor(Vendedor Vendedor)
        {
            Vendedores.Add(Vendedor);
        }

        public double TotalVendas(DateTime Inicio, DateTime Final)
        {
            return Vendedores.Sum(Vendedor => Vendedor.TotalVendas(Inicio, Final));
        }
    }
}
