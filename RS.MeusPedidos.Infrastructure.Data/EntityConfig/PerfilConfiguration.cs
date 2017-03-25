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
    /// Configuração da modelagem da entidade Perfil
    /// </summary>
    public class PerfilConfiguration : EntityTypeConfiguration<Perfil>
    {
        public PerfilConfiguration()
        {



            HasMany(hm => hm.CondicaoSet)
            .WithRequired(wo => wo.Perfil)
            .HasForeignKey(hfk => hfk.PerfilId);

            HasOptional(ho => ho.Email)
                .WithMany(wm => wm.PerfilSet)
                .HasForeignKey(hfk => hfk.EmailId);

        }
    }
}
