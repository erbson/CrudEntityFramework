using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudEntityFramework
{


    public class BDcontext : DbContext
    {

        public  BDcontext() : base("conexaoBanco") { }

        public  DbSet<Clientes> Clientes { get; set; }
        public  DbSet<Endereco> Endereco { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // mapeamento das tabelas

                modelBuilder.Entity<Clientes>()
                    .Property(e => e.Codigo).HasColumnName("Codigo")
                     .IsRequired();

                modelBuilder.Entity<Clientes>()
                   .Property(e => e.nome).HasColumnName("nome")
                   .HasColumnType("varchar")
                   .HasMaxLength(40)
                     .IsRequired();
                modelBuilder.Entity<Clientes>()
                   .Property(e => e.cpf).HasColumnName("cpf")
                   .HasColumnType("varchar")
                   .HasMaxLength(20)
                    .IsRequired();

                modelBuilder.Entity<Clientes>()
                   .Property(e => e.email).HasColumnName("email")
                   .HasColumnType("varchar")
                   .HasMaxLength(40)
                    .IsRequired();

                modelBuilder.Entity<Clientes>()
                .Property(e => e.whatsapp).HasColumnName("whatsapp")
                .HasColumnType("varchar")
                   .HasMaxLength(40)
                 .IsRequired();

                modelBuilder.Entity<Clientes>()
                .Property(e => e.datanascimento).HasColumnName("datanscimento")
                .HasColumnType("varchar")
                .HasMaxLength(40)
                  
                 .IsRequired();

            //  

            modelBuilder.Entity<Endereco>()
           .Property(e => e.codigo).HasColumnName("codigo");

            modelBuilder.Entity<Endereco>()
              .Property(e => e.rua).HasColumnName("rua")
             .HasColumnType("varchar")
             .HasMaxLength(40)
                .IsRequired();

             modelBuilder.Entity<Endereco>()
                 .Property(e => e.bairro).HasColumnName("bairro")
               .HasColumnType("varchar")
                .HasMaxLength(40)
                .IsRequired();


            modelBuilder.Entity<Endereco>()
              .Property(e => e.cidade).HasColumnName("cidade")
             .HasColumnType("varchar")
              .HasMaxLength(40)
               
             .IsRequired();
              modelBuilder.Entity<Endereco>()
             .Property(e => e.pais).HasColumnName("pais")
              .HasColumnType("varchar")
               .HasMaxLength(40)
                .IsRequired();

          
            modelBuilder.Entity<Endereco>()
           .Property(e => e.uf).HasColumnName("uf")
           .HasColumnType("varchar")
             .HasMaxLength(40)
            .IsRequired();

              modelBuilder.Entity<Endereco>()
              .Property(e => e.cep).HasColumnName("cep")
               .HasColumnType("varchar")
               .HasMaxLength(40)
              .IsRequired();

            modelBuilder.Entity<Endereco>().HasRequired(c => c.Clientes)
            .WithMany(p => p.Enderecos).HasForeignKey(p => p.idcliente);



            // .Property(e => e.idcliente).HasColumnName("Idcliente")









        }
    }
}
