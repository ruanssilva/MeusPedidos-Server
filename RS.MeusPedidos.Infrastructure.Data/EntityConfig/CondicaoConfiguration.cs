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
    /// Configuração da modelagem da entidade Condicao
    /// </summary>
    public class CondicaoConfiguration : EntityTypeConfiguration<Condicao>
    {
        public CondicaoConfiguration()
        {

            HasKey(hk => new { hk.ConhecimentoId, hk.PerfilId });

            HasRequired(ho => ho.Perfil)
            .WithMany(wm => wm.CondicaoSet)
            .HasForeignKey(hfk => hfk.PerfilId);

            HasRequired(ho => ho.Conhecimento)
            .WithMany(wm => wm.CondicaoSet)
            .HasForeignKey(hfk => hfk.ConhecimentoId);

        }
    }
}
