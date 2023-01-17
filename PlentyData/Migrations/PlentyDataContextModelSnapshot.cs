﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PlentyData.Data;

#nullable disable

namespace PlentyData.Migrations
{
    [DbContext(typeof(PlentyDataContext))]
    partial class PlentyDataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("PlentyData.Models.Empresa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("Ativo")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("CpfCnpj")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("IE")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("NomeFantasia")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int?>("ProdutoValorId")
                        .HasColumnType("int");

                    b.Property<string>("RazaoSocial")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("ProdutoValorId");

                    b.ToTable("Empresa");
                });

            modelBuilder.Entity("PlentyData.Models.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("Ativo")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Cest")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Gtin")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Ncm")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("NomeDocumentoFiscal")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Referencia")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Tipo")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Produto");
                });

            modelBuilder.Entity("PlentyData.Models.ProdutoListaValor", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("Ativo")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int?>("ProdutoValorId")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("ProdutoValorId");

                    b.ToTable("ProdutoListaValor");
                });

            modelBuilder.Entity("PlentyData.Models.ProdutoValor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("Ativo")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("EmpresaId")
                        .HasColumnType("int");

                    b.Property<decimal>("PercentualLucro")
                        .HasColumnType("decimal(65,30)");

                    b.Property<int>("ProdutoId")
                        .HasColumnType("int");

                    b.Property<int>("ProdutoListaValorId")
                        .HasColumnType("int");

                    b.Property<int>("UnidadeId")
                        .HasColumnType("int");

                    b.Property<decimal>("ValorCompra")
                        .HasColumnType("decimal(65,30)");

                    b.Property<decimal>("ValorCusto")
                        .HasColumnType("decimal(65,30)");

                    b.Property<decimal>("ValorCustoMedio")
                        .HasColumnType("decimal(65,30)");

                    b.Property<decimal>("ValorVenda")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("Id");

                    b.HasIndex("ProdutoId");

                    b.ToTable("ProdutoValor");
                });

            modelBuilder.Entity("PlentyData.Models.Unidade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Abreviacao")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("Ativo")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int?>("ProdutoValorId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProdutoValorId");

                    b.ToTable("Unidade");
                });

            modelBuilder.Entity("PlentyData.Models.Empresa", b =>
                {
                    b.HasOne("PlentyData.Models.ProdutoValor", null)
                        .WithMany("Empresas")
                        .HasForeignKey("ProdutoValorId");
                });

            modelBuilder.Entity("PlentyData.Models.ProdutoListaValor", b =>
                {
                    b.HasOne("PlentyData.Models.ProdutoValor", null)
                        .WithMany("ProdutoListaValores")
                        .HasForeignKey("ProdutoValorId");
                });

            modelBuilder.Entity("PlentyData.Models.ProdutoValor", b =>
                {
                    b.HasOne("PlentyData.Models.Produto", null)
                        .WithMany("ProdutoValores")
                        .HasForeignKey("ProdutoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PlentyData.Models.Unidade", b =>
                {
                    b.HasOne("PlentyData.Models.ProdutoValor", null)
                        .WithMany("Unidades")
                        .HasForeignKey("ProdutoValorId");
                });

            modelBuilder.Entity("PlentyData.Models.Produto", b =>
                {
                    b.Navigation("ProdutoValores");
                });

            modelBuilder.Entity("PlentyData.Models.ProdutoValor", b =>
                {
                    b.Navigation("Empresas");

                    b.Navigation("ProdutoListaValores");

                    b.Navigation("Unidades");
                });
#pragma warning restore 612, 618
        }
    }
}
