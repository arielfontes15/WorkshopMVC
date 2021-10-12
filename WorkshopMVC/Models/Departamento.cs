using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WorkshopMVC.Models
{
    public class Departamento
    {
        public int Id { get; set; }
        [Display(Name = "Nome do Departamento")]
        [Required(ErrorMessage = "O campo {0} é obrigatorio!")]
        public string Name { get; set; }
    }
}
