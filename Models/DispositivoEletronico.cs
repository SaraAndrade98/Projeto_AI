using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_AI.Models
{
    public class DispositivoEletronico
    {

        public string ID { set; get; }
        
        [Required (ErrorMessage ="Preenchimento obrigatório.")]
        public int Ano { set; get; }

        public string Marca_Final { set; get; }
        [NotMapped]
        [Required(ErrorMessage = "Preenchimento obrigatório.")]
        public List<String> Marca { set; get; }

        [Required(ErrorMessage = "Preenchimento obrigatório.")]
        public string Nome { set; get; }

        public string Estado_Final { set; get; }
        [NotMapped]
        [Required(ErrorMessage = "Preenchimento obrigatório.")]
        public List<String> Estado { set; get; }

        public Double Preco { set; get; }

        [Required(ErrorMessage = "Preenchimento obrigatório.")]
        public Boolean IncidentesAquaticos { set; get; }

        [Required(ErrorMessage = "Preenchimento obrigatório.")]
        public Boolean Acessorios { set; get; }

    }
}
