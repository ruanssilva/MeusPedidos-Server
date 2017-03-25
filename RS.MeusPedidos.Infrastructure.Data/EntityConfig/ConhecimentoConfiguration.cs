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
    /// Configuração da modelagem da entidade Conhecimento
    /// </summary>
    public class ConhecimentoConfiguration : EntityTypeConfiguration<Conhecimento>
    {
        public ConhecimentoConfiguration()
        {


            HasMany(hm => hm.CondicaoSet)
            .WithRequired(wo => wo.Conhecimento)
            .HasForeignKey(hfk => hfk.ConhecimentoId);

        }
    }
}
