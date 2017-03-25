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
    /// Configuração da modelagem da entidade Resposta
    /// </summary>
    public class RespostaConfiguration : EntityTypeConfiguration<Resposta>
    {
        public RespostaConfiguration()
        {

            HasKey(hk => new { hk.AvaliacaoId, hk.ConhecimentoId });

            HasRequired(ho => ho.Avaliacao)
            .WithMany(wm => wm.RespostaSet)
            .HasForeignKey(hfk => hfk.AvaliacaoId);

            HasRequired(ho => ho.Conhecimento)
            .WithMany(wm => wm.RespostaSet)
            .HasForeignKey(hfk => hfk.ConhecimentoId);

        }
    }
}
