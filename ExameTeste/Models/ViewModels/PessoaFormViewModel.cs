using System.Collections.Generic;

namespace ExameTeste.Models.ViewModels
{
    public class PessoaFormViewModel
    {
        public Pessoa pessoa { get; set; }
        public ICollection<FaixaEtaria> FaixaEtarias { get; set; }
    }
}
