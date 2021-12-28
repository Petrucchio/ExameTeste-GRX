using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExameTeste.Models
{
    public class FaixaEtaria
    {
        public int Id { get; set; }
        public string Classificação {get; set; }
        public ICollection<Pessoa> pessoas{ get; set; } = new List<Pessoa>();

        public FaixaEtaria()
        {

        }

        public FaixaEtaria(int id, string classificação)
        {
            Id = id;
            Classificação = classificação;
        }
        public void adicionar(Pessoa filtro)
        {
            pessoas.Add(filtro);
        }
        public void remover(Pessoa filtro)
        {
            pessoas.Remove(filtro);
        }

        public void Limite (int initial, int final)
        {
           var filtrar = pessoas.Where(filtro => filtro.Age >= initial
           && filtro.Age <=final 
           && filtro.Active.Equals(true))
                .OrderBy(filtro => filtro.Age);
        }
    }
}
