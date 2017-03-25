using RS.MeusPedidos.Infrastructure.Data.EntityConfig;
using RS.MeusPedidos.Infrastructure.Data.Interfaces.DbContexts;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RS.MeusPedidos.Infrastructure.Data.DbContexts
{
    public class MeusPedidosContext : DbContext, IDbContext
    {
        
        public MeusPedidosContext()
            : base("Azure")
        {

        }

        /// <summary>
        /// Configuração da modelagem do meu dominio na base dados
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(65));

            modelBuilder.Properties()
                .Where(p => p.Name == "Id")
                .Configure(p => p.IsKey());

            modelBuilder.Configurations.Add(new AvaliacaoConfiguration());
            modelBuilder.Configurations.Add(new CandidatoConfiguration());
            modelBuilder.Configurations.Add(new CondicaoConfiguration());
            modelBuilder.Configurations.Add(new ConhecimentoConfiguration());
            modelBuilder.Configurations.Add(new PerfilConfiguration());
            modelBuilder.Configurations.Add(new RespostaConfiguration());
            modelBuilder.Configurations.Add(new EmailConfiguration());
        }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("CreatedOn") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("CreatedOn").CurrentValue = DateTime.Now;
                    entry.Property("CreatedBy").CurrentValue = "System";
                }
                else
                    entry.Property("CreatedOn").IsModified = false;                
            }

            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("ModifiedOn") != null))
            {
                if (entry.State == EntityState.Modified)
                {
                    entry.Property("ModifiedOn").CurrentValue = DateTime.Now;
                    entry.Property("ModifiedBy").CurrentValue = "System";
                }
                else
                    entry.Property("ModifiedOn").IsModified = false;                
            }          

            return base.SaveChanges();
        }
    }
}
