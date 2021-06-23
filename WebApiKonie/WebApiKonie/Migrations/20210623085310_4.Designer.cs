﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApiKonie.Models;

namespace WebApiKonie.Migrations
{
    [DbContext(typeof(ZakladyDB))]
    [Migration("20210623085310_4")]
    partial class _4
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApiKonie.Models.Autoryzacja", b =>
                {
                    b.Property<int>("ID_Autoryzacja")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID_Autoryzacja")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Login");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Password");

                    b.Property<string>("Rola")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Rola");

                    b.HasKey("ID_Autoryzacja");

                    b.ToTable("Autoryzacja");
                });

            modelBuilder.Entity("WebApiKonie.Models.Klient", b =>
                {
                    b.Property<int>("ID_Klienta")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ID_Autoryzacja")
                        .HasColumnType("int");

                    b.Property<string>("Imie")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nazwisko")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("StanKonta")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Wiek")
                        .HasColumnType("int");

                    b.HasKey("ID_Klienta");

                    b.HasIndex("ID_Autoryzacja");

                    b.ToTable("Klienci");
                });

            modelBuilder.Entity("WebApiKonie.Models.Kon", b =>
                {
                    b.Property<int>("ID_Konia")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Kondycja")
                        .HasColumnType("int");

                    b.Property<string>("Kraj")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nazwa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Predkosc")
                        .HasColumnType("int");

                    b.Property<int>("Wiek")
                        .HasColumnType("int");

                    b.HasKey("ID_Konia");

                    b.ToTable("Konie");
                });

            modelBuilder.Entity("WebApiKonie.Models.Przebieg", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Dystans")
                        .HasColumnType("int");

                    b.Property<int>("DystansSuma")
                        .HasColumnType("int");

                    b.Property<int>("ID_konia")
                        .HasColumnType("int");

                    b.Property<int>("ID_wyscigu")
                        .HasColumnType("int");

                    b.Property<int>("Krok")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Przebiegi");
                });

            modelBuilder.Entity("WebApiKonie.Models.SkladWyscigu", b =>
                {
                    b.Property<int>("ID_Skladu")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ID_Wyscigu")
                        .HasColumnType("int");

                    b.Property<int?>("Kon1ID_Konia")
                        .HasColumnType("int");

                    b.Property<int?>("Kon2ID_Konia")
                        .HasColumnType("int");

                    b.Property<int?>("Kon3ID_Konia")
                        .HasColumnType("int");

                    b.Property<int?>("Kon4ID_Konia")
                        .HasColumnType("int");

                    b.Property<int?>("Kon5ID_Konia")
                        .HasColumnType("int");

                    b.Property<double>("KursKon1")
                        .HasColumnType("float");

                    b.Property<double>("KursKon2")
                        .HasColumnType("float");

                    b.Property<double>("KursKon3")
                        .HasColumnType("float");

                    b.Property<double>("KursKon4")
                        .HasColumnType("float");

                    b.Property<double>("KursKon5")
                        .HasColumnType("float");

                    b.HasKey("ID_Skladu");

                    b.HasIndex("Kon1ID_Konia");

                    b.HasIndex("Kon2ID_Konia");

                    b.HasIndex("Kon3ID_Konia");

                    b.HasIndex("Kon4ID_Konia");

                    b.HasIndex("Kon5ID_Konia");

                    b.ToTable("SkladyWyscigow");
                });

            modelBuilder.Entity("WebApiKonie.Models.Wyscig", b =>
                {
                    b.Property<int>("ID_Wyscigu")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<int?>("WygranyID_Konia")
                        .HasColumnType("int");

                    b.Property<bool>("Zakonczony")
                        .HasColumnType("bit");

                    b.HasKey("ID_Wyscigu");

                    b.HasIndex("WygranyID_Konia");

                    b.ToTable("Wyscigi");
                });

            modelBuilder.Entity("WebApiKonie.Models.Zakład", b =>
                {
                    b.Property<int>("ID_Zakladu")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ID_Klienta")
                        .HasColumnType("int");

                    b.Property<int>("ID_Konia")
                        .HasColumnType("int");

                    b.Property<int>("ID_Wyscigu")
                        .HasColumnType("int");

                    b.Property<double>("Kurs")
                        .HasColumnType("float");

                    b.Property<decimal>("KwotaZakladu")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("Wygrany")
                        .HasColumnType("bit");

                    b.Property<bool>("Wyplacony")
                        .HasColumnType("bit");

                    b.HasKey("ID_Zakladu");

                    b.HasIndex("ID_Klienta");

                    b.HasIndex("ID_Konia");

                    b.HasIndex("ID_Wyscigu");

                    b.ToTable("Zaklady");
                });

            modelBuilder.Entity("WebApiKonie.Models.Klient", b =>
                {
                    b.HasOne("WebApiKonie.Models.Autoryzacja", "Autoryzacja")
                        .WithMany()
                        .HasForeignKey("ID_Autoryzacja");

                    b.Navigation("Autoryzacja");
                });

            modelBuilder.Entity("WebApiKonie.Models.SkladWyscigu", b =>
                {
                    b.HasOne("WebApiKonie.Models.Kon", "Kon1")
                        .WithMany()
                        .HasForeignKey("Kon1ID_Konia");

                    b.HasOne("WebApiKonie.Models.Kon", "Kon2")
                        .WithMany()
                        .HasForeignKey("Kon2ID_Konia");

                    b.HasOne("WebApiKonie.Models.Kon", "Kon3")
                        .WithMany()
                        .HasForeignKey("Kon3ID_Konia");

                    b.HasOne("WebApiKonie.Models.Kon", "Kon4")
                        .WithMany()
                        .HasForeignKey("Kon4ID_Konia");

                    b.HasOne("WebApiKonie.Models.Kon", "Kon5")
                        .WithMany()
                        .HasForeignKey("Kon5ID_Konia");

                    b.Navigation("Kon1");

                    b.Navigation("Kon2");

                    b.Navigation("Kon3");

                    b.Navigation("Kon4");

                    b.Navigation("Kon5");
                });

            modelBuilder.Entity("WebApiKonie.Models.Wyscig", b =>
                {
                    b.HasOne("WebApiKonie.Models.Kon", "Wygrany")
                        .WithMany()
                        .HasForeignKey("WygranyID_Konia");

                    b.Navigation("Wygrany");
                });

            modelBuilder.Entity("WebApiKonie.Models.Zakład", b =>
                {
                    b.HasOne("WebApiKonie.Models.Klient", "Klient")
                        .WithMany()
                        .HasForeignKey("ID_Klienta")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApiKonie.Models.Kon", "Kon")
                        .WithMany()
                        .HasForeignKey("ID_Konia")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApiKonie.Models.Wyscig", "Wyscig")
                        .WithMany()
                        .HasForeignKey("ID_Wyscigu")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Klient");

                    b.Navigation("Kon");

                    b.Navigation("Wyscig");
                });
#pragma warning restore 612, 618
        }
    }
}
