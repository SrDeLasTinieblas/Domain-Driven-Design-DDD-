﻿// <auto-generated />
using Domain_Driven_Design__DDD_.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Domain_Driven_Design__DDD_.Migrations
{
    [DbContext(typeof(YourDbContext))]
    [Migration("20230721014046_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Domain_Driven_Design__DDD_.Domain.Entities.Producto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Productos");
                });

            modelBuilder.Entity("Domain_Driven_Design__DDD_.Domain.Entities.Producto", b =>
                {
                    b.OwnsOne("Domain_Driven_Design__DDD_.Domain.Entities.Precio", "Precio", b1 =>
                        {
                            b1.Property<int>("ProductoId")
                                .HasColumnType("int");

                            b1.Property<string>("Moneda")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("Moneda");

                            b1.Property<decimal>("Valor")
                                .HasColumnType("decimal(18,2)")
                                .HasColumnName("Valor");

                            b1.HasKey("ProductoId");

                            b1.ToTable("Productos");

                            b1.WithOwner()
                                .HasForeignKey("ProductoId");
                        });

                    b.OwnsOne("Domain_Driven_Design__DDD_.Domain.ValueObjects.Descripcion", "Descripcion", b1 =>
                        {
                            b1.Property<int>("ProductoId")
                                .HasColumnType("int");

                            b1.Property<string>("Contenido")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("Contenido");

                            b1.HasKey("ProductoId");

                            b1.ToTable("Productos");

                            b1.WithOwner()
                                .HasForeignKey("ProductoId");
                        });

                    b.Navigation("Descripcion")
                        .IsRequired();

                    b.Navigation("Precio")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
