using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Reporteadores.Models;

public partial class ComparteContext : DbContext
{
    

    public ComparteContext()
    {
    }

    public ComparteContext(DbContextOptions<ComparteContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=192.168.101.100; Initial Catalog=Comparte; MultipleActiveResultSets=True; User ID=sa; Password=Admin_sqlABG; TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.UsCodigo);

            entity.ToTable("USUARIO", tb =>
                {
                    tb.HasTrigger("TD_USUARIO");
                    tb.HasTrigger("TU_USUARIO");
                });

            entity.HasIndex(e => e.UsCorto, "XAK1USUARIO").IsUnique();

            entity.Property(e => e.UsCodigo)
                .ValueGeneratedNever()
                .HasColumnName("US_CODIGO");
            entity.Property(e => e.CbCodigo).HasColumnName("CB_CODIGO");
            entity.Property(e => e.CmCodigo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CM_CODIGO");
            entity.Property(e => e.GrCodigo).HasColumnName("GR_CODIGO");
            entity.Property(e => e.UsActivo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("US_ACTIVO");
            entity.Property(e => e.UsAnfitri).HasColumnName("US_ANFITRI");
            entity.Property(e => e.UsArbol)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("US_ARBOL");
            entity.Property(e => e.UsBioId)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("US_BIO_ID");
            entity.Property(e => e.UsBitLst)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("US_BIT_LST");
            entity.Property(e => e.UsBloquea)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("US_BLOQUEA");
            entity.Property(e => e.UsCambia)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("US_CAMBIA");
            entity.Property(e => e.UsCorto)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("US_CORTO");
            entity.Property(e => e.UsDentro)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("US_DENTRO");
            entity.Property(e => e.UsDomain)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("US_DOMAIN");
            entity.Property(e => e.UsEmail)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("US_EMAIL");
            entity.Property(e => e.UsFallas).HasColumnName("US_FALLAS");
            entity.Property(e => e.UsFecIn)
                .HasColumnType("datetime")
                .HasColumnName("US_FEC_IN");
            entity.Property(e => e.UsFecOut)
                .HasColumnType("datetime")
                .HasColumnName("US_FEC_OUT");
            entity.Property(e => e.UsFecPwd)
                .HasColumnType("datetime")
                .HasColumnName("US_FEC_PWD");
            entity.Property(e => e.UsFecSus)
                .HasColumnType("datetime")
                .HasColumnName("US_FEC_SUS");
            entity.Property(e => e.UsForma).HasColumnName("US_FORMA");
            entity.Property(e => e.UsFormato).HasColumnName("US_FORMATO");
            entity.Property(e => e.UsJefe).HasColumnName("US_JEFE");
            entity.Property(e => e.UsLugar)
                .HasMaxLength(8)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("US_LUGAR");
            entity.Property(e => e.UsMaquina)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("US_MAQUINA");
            entity.Property(e => e.UsNivel).HasColumnName("US_NIVEL");
            entity.Property(e => e.UsNombre)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("US_NOMBRE");
            entity.Property(e => e.UsPaginas).HasColumnName("US_PAGINAS");
            entity.Property(e => e.UsPasswrd)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("US_PASSWRD");
            entity.Property(e => e.UsPortal)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("US_PORTAL");
            entity.Property(e => e.UsTelefono)
                .HasMaxLength(254)
                .IsUnicode(false)
                .HasColumnName("US_TELEFONO");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
