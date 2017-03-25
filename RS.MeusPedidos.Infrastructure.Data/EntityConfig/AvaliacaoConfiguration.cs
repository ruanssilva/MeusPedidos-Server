using RS.MeusPedidos.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RS.MeusPedidos.Infrastructure.Data.EntityConfig
{
    /// <summary>
    /// Configuração da modelagem da entidade Avaliacao
    /// </summary>
    public class AvaliacaoConfiguration : EntityTypeConfiguration<Avaliacao>
    {
        public AvaliacaoConfiguration()
        {


            HasRequired(ho => ho.Candidato)
                .WithMany(wm => wm.AvaliacaoSet)
                .HasForeignKey(hfk => hfk.CandidatoId);

            HasMany(hm => hm.RespostaSet)
                .WithRequired(wo => wo.Avaliacao)
                .HasForeignKey(hfk => hfk.AvaliacaoId);

        }
    }
}
