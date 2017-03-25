using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RS.MeusPedidos.Application.ViewModels
{
    public class CondicaoViewModel
    {
        public string Conhecimento { get; set; }
        [Required]
        [Display(Name = "Conhecimento")]
        public Guid ConhecimentoId { get; set; }
        [Required]
        [Display(Name = "Perfil")]
        public Guid PerfilId { get; set; }
        [Required]
        public short Pontos { get; set; }
    }
}
