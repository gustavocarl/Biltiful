using Infraestrutura.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infraestrutura.Config;

public class DatabaseContext : DbContext
{
    public DbSet<Cliente> Cliente { get; set; }

    public DbSet<Fornecedor> Fornecedor { get; set; }

    public DbSet<MateriaPrima> MateriaPrima { get; set; }

    public DbSet<Produto> Produto { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(DatabaseConfig.connectionString);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cliente>()
            .ToTable("CLIENTES")
            .HasKey(c => c.CPF);

        modelBuilder.Entity<Cliente>()
            .Property(c => c.CPF)
            .IsRequired();

        modelBuilder.Entity<Cliente>()
            .Property(c => c.Nome)
            .IsRequired()
            .HasMaxLength(100);

        modelBuilder.Entity<Cliente>()
            .Property(c => c.DataNascimento)
            .HasColumnType("date");

        modelBuilder.Entity<Cliente>()
            .Property(c => c.Sexo)
            .IsRequired();

        modelBuilder.Entity<Cliente>()
            .Property(c => c.UltimaCompra)
            .HasColumnType("date");

        modelBuilder.Entity<Cliente>()
            .Property(c => c.DataCadastro)
            .HasColumnType("date");

        modelBuilder.Entity<Cliente>()
            .Property(c => c.Situacao)
            .HasDefaultValue('A');

        modelBuilder.Entity<Fornecedor>()
            .ToTable("FORNECEDORES")
            .HasKey(f => f.CNPJ);

        modelBuilder.Entity<Fornecedor>()
            .Property(f => f.CNPJ)
            .IsRequired();

        modelBuilder.Entity<Fornecedor>()
            .Property(f => f.RazaoSocial)
            .HasMaxLength(100)
            .IsRequired();

        modelBuilder.Entity<Fornecedor>()
            .Property(f => f.DataAbertura)
            .HasColumnType("date");

        modelBuilder.Entity<Fornecedor>()
            .Property(f => f.UltimaCompra)
            .HasColumnType("date");

        modelBuilder.Entity<Fornecedor>()
            .Property(f => f.DataCadastro)
            .HasColumnType("date");

        modelBuilder.Entity<Fornecedor>()
            .Property(f => f.Situacao)
            .HasDefaultValue('A');

        modelBuilder.Entity<MateriaPrima>()
            .ToTable("MATERIASPRIMAS")
            .HasKey(mp => mp.Id);

        modelBuilder.Entity<MateriaPrima>()
            .Property(mp => mp.Nome)
            .HasMaxLength(100)
            .IsRequired();

        modelBuilder.Entity<MateriaPrima>()
            .Property(mp => mp.UltimaCompra)
            .HasColumnType("date");

        modelBuilder.Entity<MateriaPrima>()
            .Property(mp => mp.DataCadastro)
            .HasColumnType("date");

        modelBuilder.Entity<MateriaPrima>()
            .Property(mp => mp.Situacao)
            .HasDefaultValue('A');

        modelBuilder.Entity<Produto>()
            .ToTable("PRODUTOS")
            .HasKey(p => p.CodigoBarras);

        modelBuilder.Entity<Produto>()
            .Property(p => p.Nome)
            .HasMaxLength(100)
            .IsRequired();

        modelBuilder.Entity<Produto>()
            .Property(p => p.ValorVenda)
            .HasColumnType("decimal(5, 2)")
            .IsRequired();

        modelBuilder.Entity<Produto>()
            .Property(p => p.UltimaVenda)
            .HasColumnType("date");

        modelBuilder.Entity<Produto>()
            .Property(p => p.Situacao)
            .HasDefaultValue('A');
    }
}