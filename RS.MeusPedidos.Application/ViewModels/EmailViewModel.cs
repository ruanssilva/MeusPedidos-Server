using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RS.MeusPedidos.Application.ViewModels
{
    public class EmailViewModel
    {
        public Guid Id { get; set; }
        [Required]
        [MaxLength(65)]
        public string Identificador { get; set; }
        [Required]
        [MaxLength(65)]
        public string Assunto { get; set; }
        [Required]
        [MaxLength(255)]
        [Display(Name = "Conteúdo")]
        public string Conteudo { get; set; }
    }
}
