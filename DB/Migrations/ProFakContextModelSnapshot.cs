﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProFak.DB;

namespace ProFak.DB.Migrations
{
    [DbContext(typeof(Baza))]
    partial class ProFakContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.10");

            modelBuilder.Entity("ProFak.DB.Faktura", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("DaneNabywcy")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("DaneSprzedawcy")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DataSprzedazy")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DataWprowadzenia")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DataWystawienia")
                        .HasColumnType("TEXT");

                    b.Property<int>("FakturaKorygowanaId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("FakturaKorygujacaId")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("KursWaluty")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValue(1m);

                    b.Property<string>("NIPNabywcy")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("NIPSprzedawcy")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("NabywcaId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("NazwaNabywcy")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("NazwaSprzedawcy")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Numer")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("OpisSposobuPlatnosci")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("RachunekBankowy")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("RazemBrutto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValue(0m);

                    b.Property<decimal>("RazemNetto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValue(0m);

                    b.Property<decimal>("RazemVat")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValue(0m);

                    b.Property<int>("SposobPlatnosciId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SprzedawcaId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("TerminPlatnosci")
                        .HasColumnType("TEXT");

                    b.Property<string>("Uwagi")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("WalutaId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("FakturaKorygowanaId");

                    b.HasIndex("FakturaKorygujacaId");

                    b.HasIndex("NabywcaId");

                    b.HasIndex("SposobPlatnosciId");

                    b.HasIndex("SprzedawcaId");

                    b.HasIndex("WalutaId");

                    b.ToTable("Faktura");
                });

            modelBuilder.Entity("ProFak.DB.JednostkaMiary", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("CzyGlowna")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasDefaultValue(false);

                    b.Property<int>("LiczbaMiescPoPrzecinku")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasDefaultValue(0);

                    b.Property<string>("Nazwa")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Skrot")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("JednostkaMiary");
                });

            modelBuilder.Entity("ProFak.DB.Kontrahent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AdresKorespondencyjny")
                        .HasColumnType("TEXT");

                    b.Property<string>("AdresRejestrowy")
                        .HasColumnType("TEXT");

                    b.Property<bool>("CzyArchiwalny")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasDefaultValue(false);

                    b.Property<bool>("CzyPodmiot")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasDefaultValue(false);

                    b.Property<string>("EMail")
                        .HasColumnType("TEXT");

                    b.Property<string>("NIP")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nazwa")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PelnaNazwa")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("RachunekBankowy")
                        .HasColumnType("TEXT");

                    b.Property<string>("Telefon")
                        .HasColumnType("TEXT");

                    b.Property<string>("Uwagi")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Kontrahent");
                });

            modelBuilder.Entity("ProFak.DB.PozycjaFaktury", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("CzyWedlugCenBrutto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasDefaultValue(false);

                    b.Property<int>("FakturaId")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Ilosc")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValue(0m);

                    b.Property<decimal>("KwotaBrutto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValue(0m);

                    b.Property<decimal>("KwotaNetto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValue(0m);

                    b.Property<decimal>("KwotaVat")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValue(0m);

                    b.Property<string>("Opis")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("TowarId")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("WartoscBrutto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValue(0m);

                    b.Property<decimal>("WartoscNetto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValue(0m);

                    b.Property<decimal>("WartoscVat")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValue(0m);

                    b.HasKey("Id");

                    b.HasIndex("FakturaId");

                    b.HasIndex("TowarId");

                    b.ToTable("PozycjaFaktury");
                });

            modelBuilder.Entity("ProFak.DB.SposobPlatnosci", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("CzyDomyslny")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasDefaultValue(false);

                    b.Property<int>("LiczbaDni")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasDefaultValue(0);

                    b.Property<string>("Nazwa")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("SposobPlatnosci");
                });

            modelBuilder.Entity("ProFak.DB.StawkaVat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("CzyDomyslna")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasDefaultValue(false);

                    b.Property<string>("Skrot")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Wartosc")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValue(0m);

                    b.HasKey("Id");

                    b.ToTable("StawkaVat");
                });

            modelBuilder.Entity("ProFak.DB.Towar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("CenaBrutto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValue(0m);

                    b.Property<decimal>("CenaNetto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValue(0m);

                    b.Property<bool>("CzyArchiwalny")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasDefaultValue(false);

                    b.Property<bool>("CzyWedlugCenBrutto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasDefaultValue(false);

                    b.Property<int>("JednostkaMiaryId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nazwa")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Rodzaj")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasDefaultValue(0);

                    b.Property<int>("StawkaVatId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("JednostkaMiaryId");

                    b.HasIndex("StawkaVatId");

                    b.ToTable("Towar");
                });

            modelBuilder.Entity("ProFak.DB.Waluta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("CzyDomyslna")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasDefaultValue(false);

                    b.Property<string>("Nazwa")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Skrot")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Waluta");
                });

            modelBuilder.Entity("ProFak.DB.Faktura", b =>
                {
                    b.HasOne("ProFak.DB.Faktura", "FakturaKorygowana")
                        .WithMany()
                        .HasForeignKey("FakturaKorygowanaId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("ProFak.DB.Faktura", "FakturaKorygujaca")
                        .WithMany()
                        .HasForeignKey("FakturaKorygujacaId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("ProFak.DB.Kontrahent", "Nabywca")
                        .WithMany()
                        .HasForeignKey("NabywcaId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("ProFak.DB.SposobPlatnosci", "SposobPlatnosci")
                        .WithMany()
                        .HasForeignKey("SposobPlatnosciId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("ProFak.DB.Kontrahent", "Sprzedawca")
                        .WithMany()
                        .HasForeignKey("SprzedawcaId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("ProFak.DB.Waluta", "Waluta")
                        .WithMany()
                        .HasForeignKey("WalutaId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("FakturaKorygowana");

                    b.Navigation("FakturaKorygujaca");

                    b.Navigation("Nabywca");

                    b.Navigation("SposobPlatnosci");

                    b.Navigation("Sprzedawca");

                    b.Navigation("Waluta");
                });

            modelBuilder.Entity("ProFak.DB.PozycjaFaktury", b =>
                {
                    b.HasOne("ProFak.DB.Faktura", "Faktura")
                        .WithMany("Pozycje")
                        .HasForeignKey("FakturaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProFak.DB.Towar", "Towar")
                        .WithMany()
                        .HasForeignKey("TowarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Faktura");

                    b.Navigation("Towar");
                });

            modelBuilder.Entity("ProFak.DB.Towar", b =>
                {
                    b.HasOne("ProFak.DB.JednostkaMiary", "JednostkaMiary")
                        .WithMany()
                        .HasForeignKey("JednostkaMiaryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProFak.DB.StawkaVat", "StawkaVat")
                        .WithMany()
                        .HasForeignKey("StawkaVatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("JednostkaMiary");

                    b.Navigation("StawkaVat");
                });

            modelBuilder.Entity("ProFak.DB.Faktura", b =>
                {
                    b.Navigation("Pozycje");
                });
#pragma warning restore 612, 618
        }
    }
}
