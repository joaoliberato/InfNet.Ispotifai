﻿// <auto-generated />
using InfNet.Ispotifai.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace InfNet.Ispotifai.Infrastructure.Migrations
{
    [DbContext(typeof(IspotifaiDbContext))]
    [Migration("20250630233716_AddPlanos")]
    partial class AddPlanos
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("InfNet.Ispotifai.Domain.Musica", b =>
                {
                    b.Property<int>("IdMusica")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdMusica"));

                    b.Property<string>("Album")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Artista")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdMusica");

                    b.ToTable("Musica");
                });

            modelBuilder.Entity("InfNet.Ispotifai.Domain.Plano", b =>
                {
                    b.Property<int>("IdPlano")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdPlano"));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdPlano");

                    b.ToTable("Plano");
                });

            modelBuilder.Entity("InfNet.Ispotifai.Domain.Usuario", b =>
                {
                    b.Property<int>("IdUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdUsuario"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdPlano")
                        .HasColumnType("int");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdUsuario");

                    b.HasIndex("IdPlano");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("MusicaUsuario", b =>
                {
                    b.Property<int>("FavoritasIdMusica")
                        .HasColumnType("int");

                    b.Property<int>("UsuarioIdUsuario")
                        .HasColumnType("int");

                    b.HasKey("FavoritasIdMusica", "UsuarioIdUsuario");

                    b.HasIndex("UsuarioIdUsuario");

                    b.ToTable("MusicaUsuario");
                });

            modelBuilder.Entity("InfNet.Ispotifai.Domain.Usuario", b =>
                {
                    b.HasOne("InfNet.Ispotifai.Domain.Plano", "Plano")
                        .WithMany()
                        .HasForeignKey("IdPlano")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Plano");
                });

            modelBuilder.Entity("MusicaUsuario", b =>
                {
                    b.HasOne("InfNet.Ispotifai.Domain.Musica", null)
                        .WithMany()
                        .HasForeignKey("FavoritasIdMusica")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("InfNet.Ispotifai.Domain.Usuario", null)
                        .WithMany()
                        .HasForeignKey("UsuarioIdUsuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
