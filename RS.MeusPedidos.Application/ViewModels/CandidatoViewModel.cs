using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RS.MeusPedidos.Application.ViewModels
{
    public class CandidatoViewModel
    {
        public Guid Id { get; set; }
        [Required]
        [MaxLength(65)]
        public string Nome { get; set; }
        [Required]
        [Display(Name = "E-mail")]
        [MaxLength(65)]
        public string Email { get; set; }

        [Display(Name = "Perfil")]
        public string Perfil { get; set; }

        public IEnumerable<AvaliacaoViewModel> AvaliacaoSet { get; set; }
        [Display(Name = "Habilidades")]
        public IEnumerable<RespostaViewModel> RespostaSet { get; set; }
    }
}
