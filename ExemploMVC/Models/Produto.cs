using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploMVC.Models
{
    public class Produto
    {
        public int Id { get; set; }
        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "O Campo é obrigatório!")]
        public string Descricao { get; set; }
        [Required(ErrorMessage = "O Campo é obrigatório!")]
        [Range(1, 100, ErrorMessage = "Valor fora dos limites de 1 a 100")]
        public int Quantidade { get; set; }
        public int CategoriaId{ get; set; }
        public Categoria Categoria{ get; set; }
    }
}
