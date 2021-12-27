using System;
using System.ComponentModel.DataAnnotations;

namespace ExameTeste.Models
{
    public class Pessoa
    {
        public int Id { get; set; }
        [Display(Name = "Nome")]
        [Required(ErrorMessage = "{0} é necessário")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "{0} Precisa ter {2} a {1} caracteres")]
        public string Name { get; set; }
        [Display(Name = "Idade")]
        [Required(ErrorMessage = "{0} é necessário")]
        public int Age { get; set; }
        [Required(ErrorMessage = "{0} é necessário")]
        [Display (Name = "Data de Nascimento")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime BirthDate { get; set; }
        [Display(Name = "Ativo no Sistema")]
        public Boolean Active { get; set; }
        public FaixaEtaria FaixaEtaria { get; set; }
        [Display(Name = "Faixa Etaria")]
        public int FaixaEtariaId { get; set; }

        public Pessoa()
        {

        }

        public Pessoa(int id, string name, int age, DateTime birthDate, bool active , FaixaEtaria faixaEtaria)
        {
            Id = id;
            Name = name;
            Age = age;
            BirthDate = birthDate;
            Active = active;
            FaixaEtaria = faixaEtaria;
        }
    }
}
