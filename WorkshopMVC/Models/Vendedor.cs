using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace WorkshopMVC.Models
{
    public class Vendedor
    {
        public int Id { get; set; }
        [Display(Name = "Nome do Departamento")]
        [Required(ErrorMessage = "O campo {0} é obrigatorio!")]
        public string Name { get; set; }
        [Display(Name = "Email")]
        [Required(ErrorMessage = "O campo {0} é obrigatorio!")]
        public string Email { get; set; }
        [Display(Name = "Data de Nascimento")]
        [Required(ErrorMessage = "O campo {0} é obrigatorio!")]
        public DateTime DataDeNascimento { get; set; }
        [Display(Name = "Salario base")]
        public double SalarioBase { get; set; }
        public Departamento Departamento { get; set; }

        // Relacionamento entre a tabela 1 Recorde de vendas para Muitos (1:N)
        public ICollection<VendaRecorde> Vendas { get; set; } = new List<VendaRecorde>();


        public Vendedor()
        {
        }

        public Vendedor(int id, string name, string email, DateTime dataDeNascimento,
            double salarioBase, Departamento departamento)
        {
            Id = id;
            Name = name;
            Email = email;
            DataDeNascimento = dataDeNascimento;
            SalarioBase = salarioBase;
            Departamento = departamento;
        }

        public void AdicionarVendas(VendaRecorde recorde)
        {
            Vendas.Add(recorde);
        }

        public void RemoverVendas(VendaRecorde recorde)
        {
            Vendas.Remove(recorde);
        }

        public double TotalVendas(DateTime Inicio, DateTime Final)
        {
            return Vendas.Where(recorde => recorde.Data >= Inicio && recorde.Data <= Final)
                .Sum(recorde => recorde.Quantia);
        }
    }
}

