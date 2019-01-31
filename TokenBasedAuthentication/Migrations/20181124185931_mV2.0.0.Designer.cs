﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TokenBasedAuthentication.Data;

namespace TokenBasedAuthentication.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20181124185931_mV2.0.0")]
    partial class mV200
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AdamSporMerkezi.API.Models.Gelir", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("GelirAdi");

                    b.Property<double>("GelirMiktari");

                    b.Property<DateTime>("tarih");

                    b.Property<int?>("uyeOdemeId");

                    b.HasKey("Id");

                    b.HasIndex("uyeOdemeId");

                    b.ToTable("gelirs");
                });

            modelBuilder.Entity("AdamSporMerkezi.API.Models.Gider", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("GiderAciklama");

                    b.Property<double>("GiderMiktari");

                    b.Property<DateTime>("tarih");

                    b.HasKey("Id");

                    b.ToTable("giders");
                });

            modelBuilder.Entity("AdamSporMerkezi.API.Models.Stok", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("StokMiktari");

                    b.Property<int>("UrunId");

                    b.HasKey("Id");

                    b.HasIndex("UrunId");

                    b.ToTable("stoks");
                });

            modelBuilder.Entity("AdamSporMerkezi.API.Models.Urun", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("GelirId");

                    b.Property<int>("UrunAdedi");

                    b.Property<string>("UrunAdi");

                    b.Property<double>("UrunFiyati");

                    b.Property<int>("UrunMiktari");

                    b.HasKey("Id");

                    b.HasIndex("GelirId");

                    b.ToTable("uruns");
                });

            modelBuilder.Entity("TokenBasedAuthentication.Models.Antrenman", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AntrenmanAdi");

                    b.Property<int>("SetSayisi");

                    b.Property<int>("TekrarSayisi");

                    b.Property<int?>("UyeProgramId");

                    b.HasKey("Id");

                    b.HasIndex("UyeProgramId");

                    b.ToTable("antrenmen");
                });

            modelBuilder.Entity("TokenBasedAuthentication.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<byte[]>("PasswordHash");

                    b.Property<byte[]>("PasswordSalt");

                    b.Property<string>("UserName");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("TokenBasedAuthentication.Models.Uye", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("email");

                    b.Property<string>("name");

                    b.Property<string>("phone");

                    b.Property<string>("surname");

                    b.HasKey("Id");

                    b.ToTable("uyes");
                });

            modelBuilder.Entity("TokenBasedAuthentication.Models.UyeOdeme", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("KayitTarihi");

                    b.Property<int>("UyeId");

                    b.Property<int>("UyelikSuresi");

                    b.Property<string>("UyelikTipi");

                    b.HasKey("Id");

                    b.HasIndex("UyeId");

                    b.ToTable("uyeOdemes");
                });

            modelBuilder.Entity("TokenBasedAuthentication.Models.UyeProgram", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("UyeId");

                    b.HasKey("Id");

                    b.HasIndex("UyeId")
                        .IsUnique();

                    b.ToTable("uyePrograms");
                });

            modelBuilder.Entity("TokenBasedAuthentication.Models.UyeVucutInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Bel");

                    b.Property<double>("Boy");

                    b.Property<double>("Gogus");

                    b.Property<double>("Kilo");

                    b.Property<double>("Omuz");

                    b.Property<double>("SagBacak");

                    b.Property<double>("SagKol");

                    b.Property<double>("SolBacak");

                    b.Property<double>("SolKol");

                    b.Property<int>("UyeId");

                    b.Property<DateTime>("eklemeTarihi");

                    b.HasKey("Id");

                    b.HasIndex("UyeId");

                    b.ToTable("uyeVucutInfos");
                });

            modelBuilder.Entity("AdamSporMerkezi.API.Models.Gelir", b =>
                {
                    b.HasOne("TokenBasedAuthentication.Models.UyeOdeme", "uyeOdeme")
                        .WithMany()
                        .HasForeignKey("uyeOdemeId");
                });

            modelBuilder.Entity("AdamSporMerkezi.API.Models.Stok", b =>
                {
                    b.HasOne("AdamSporMerkezi.API.Models.Urun", "urun")
                        .WithMany()
                        .HasForeignKey("UrunId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AdamSporMerkezi.API.Models.Urun", b =>
                {
                    b.HasOne("AdamSporMerkezi.API.Models.Gelir")
                        .WithMany("uruns")
                        .HasForeignKey("GelirId");
                });

            modelBuilder.Entity("TokenBasedAuthentication.Models.Antrenman", b =>
                {
                    b.HasOne("TokenBasedAuthentication.Models.UyeProgram")
                        .WithMany("antrenmans")
                        .HasForeignKey("UyeProgramId");
                });

            modelBuilder.Entity("TokenBasedAuthentication.Models.UyeOdeme", b =>
                {
                    b.HasOne("TokenBasedAuthentication.Models.Uye", "uyes")
                        .WithMany("uyeOdemes")
                        .HasForeignKey("UyeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TokenBasedAuthentication.Models.UyeProgram", b =>
                {
                    b.HasOne("TokenBasedAuthentication.Models.Uye", "uye")
                        .WithOne("uyeProgram")
                        .HasForeignKey("TokenBasedAuthentication.Models.UyeProgram", "UyeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TokenBasedAuthentication.Models.UyeVucutInfo", b =>
                {
                    b.HasOne("TokenBasedAuthentication.Models.Uye", "uye")
                        .WithMany("UyeVucutInfos")
                        .HasForeignKey("UyeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
