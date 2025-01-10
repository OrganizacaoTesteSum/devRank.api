﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using devRank.Infra.Data;

#nullable disable

namespace devRank.Infra.Migrations
{
    [DbContext(typeof(DevRankContext))]
    [Migration("20250109202019_UsuarioPonto")]
    partial class UsuarioPonto
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("devRank.Domain.Entities.Perfil", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<DateTime?>("DataAlteracao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Perfil", (string)null);
                });

            modelBuilder.Entity("devRank.Domain.Entities.PerfilPermissao", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<DateTime?>("DataAlteracao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime2");

                    b.Property<long>("PerfilId")
                        .HasColumnType("bigint");

                    b.Property<long>("PermissaoId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("PerfilId");

                    b.HasIndex("PermissaoId");

                    b.ToTable("PerfilPermissao", (string)null);
                });

            modelBuilder.Entity("devRank.Domain.Entities.Permissao", b =>
                {
                    b.Property<long>("Id")
                        .HasColumnType("bigint");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("Id");

                    b.ToTable("Permissao", (string)null);
                });

            modelBuilder.Entity("devRank.Domain.Entities.Usuario", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<bool>("Avaliado")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("DataAlteracao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(350)
                        .HasColumnType("nvarchar(350)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<long>("PerfilId")
                        .HasColumnType("bigint");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PerfilId");

                    b.ToTable("Usuario", (string)null);
                });

            modelBuilder.Entity("devRank.Domain.Entities.UsuarioPonto", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("DataAlteracao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime2");

                    b.Property<int>("Movimento")
                        .HasColumnType("int");

                    b.Property<string>("Observacao")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<int>("Ponto")
                        .HasColumnType("int");

                    b.Property<int>("Tipo")
                        .HasColumnType("int");

                    b.Property<long>("UsuarioId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("UsuarioPonto", (string)null);
                });

            modelBuilder.Entity("devRank.Domain.Entities.PerfilPermissao", b =>
                {
                    b.HasOne("devRank.Domain.Entities.Perfil", "Perfil")
                        .WithMany("PerfilPermissao")
                        .HasForeignKey("PerfilId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("devRank.Domain.Entities.Permissao", "Permissao")
                        .WithMany("PerfilPermissao")
                        .HasForeignKey("PermissaoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Perfil");

                    b.Navigation("Permissao");
                });

            modelBuilder.Entity("devRank.Domain.Entities.Usuario", b =>
                {
                    b.HasOne("devRank.Domain.Entities.Perfil", "Perfil")
                        .WithMany("Usuario")
                        .HasForeignKey("PerfilId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Perfil");
                });

            modelBuilder.Entity("devRank.Domain.Entities.UsuarioPonto", b =>
                {
                    b.HasOne("devRank.Domain.Entities.Usuario", "Usuario")
                        .WithMany("UsuarioPonto")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("devRank.Domain.Entities.Perfil", b =>
                {
                    b.Navigation("PerfilPermissao");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("devRank.Domain.Entities.Permissao", b =>
                {
                    b.Navigation("PerfilPermissao");
                });

            modelBuilder.Entity("devRank.Domain.Entities.Usuario", b =>
                {
                    b.Navigation("UsuarioPonto");
                });
#pragma warning restore 612, 618
        }
    }
}
