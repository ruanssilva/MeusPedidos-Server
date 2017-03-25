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
    /// Configuração da modelagem da entidade Candidato
    /// </summary>
    public class CandidatoConfiguration : EntityTypeConfiguration<Candidato>
    {
        public CandidatoConfiguration()
        {


            HasMany(hm => hm.AvaliacaoSet)
            .WithRequired(wo => wo.Candidato)
            .HasForeignKey(hfk => hfk.CandidatoId);


        }
    }
}
