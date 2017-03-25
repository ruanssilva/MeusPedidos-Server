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
    /// Configuração da modelagem da entidade Email
    /// </summary>
    public class EmailConfiguration : EntityTypeConfiguration<Email>
    {

        public EmailConfiguration()
        {
            HasMany(hm => hm.PerfilSet)
               .WithOptional(wo => wo.Email)
               .HasForeignKey(hfk => hfk.EmailId);

            Property(p => p.Conteudo)
                .HasMaxLength(255);
        }
    }
}
