using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendinhaKreski.Services.Validators;

namespace VendinhaKreski.Models
{
    public class Cliente
    {
        [Required]
        public int Id { get; set; }
        [Required, ValidaCpf(ErrorMessage = "CPF inválido."), StringLength(11)]
        public string Cpf { get; set; }
        [Required, DataType(DataType.Date)]
        public DateOnly DataNascimento { get; set; }
        [Required, MaxLength(100)]
        public string Nome { get; set; }
        [Required, EmailAddress(ErrorMessage = "Email inválido.")]
        public string Email { get; set; }
        public int Idade { get; set => CalcularIdade(); }

        private void CalcularIdade()
        {
            var hoje = DateOnly.FromDateTime(DateTime.Today);
            Idade = hoje.Year - DataNascimento.Year;
            if (hoje < DataNascimento.AddYears(Idade))
            {
                Idade--;
            }
        }
    }
}
