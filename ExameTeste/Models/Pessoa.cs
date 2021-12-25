using System;


namespace ExameTeste.Models
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public DateTime BirthDate { get; set; }
        public Boolean Active { get; set; }
        public FaixaEtaria FaixaEtaria { get; set; }

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
