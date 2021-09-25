﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProFak.DB.Model
{
	class FakturaBuilder
	{
		public static void Configure(EntityTypeBuilder<Faktura> builder)
		{
			builder.ToTable(nameof(Faktura));

			builder.HasKey(e => e.Id);

			builder.Property(e => e.Id).ValueGeneratedOnAdd().IsRequired();
			builder.Property(e => e.Numer).IsRequired();
			builder.Property(e => e.DataWystawienia).IsRequired();
			builder.Property(e => e.DataSprzedazy).IsRequired();
			builder.Property(e => e.DataWprowadzenia).IsRequired();
			builder.Property(e => e.TerminPlatnosci).IsRequired();
			builder.Property(e => e.NIPSprzedawcy).IsRequired();
			builder.Property(e => e.NazwaSprzedawcy).IsRequired();
			builder.Property(e => e.DaneSprzedawcy).IsRequired();
			builder.Property(e => e.NIPNabywcy).IsRequired();
			builder.Property(e => e.NazwaNabywcy).IsRequired();
			builder.Property(e => e.DaneNabywcy).IsRequired();
			builder.Property(e => e.RachunekBankowy).IsRequired();
			builder.Property(e => e.Uwagi).IsRequired();
			builder.Property(e => e.RazemNetto).HasDefaultValue(0).IsRequired();
			builder.Property(e => e.RazemVat).HasDefaultValue(0).IsRequired();
			builder.Property(e => e.RazemBrutto).HasDefaultValue(0).IsRequired();
			builder.Property(e => e.KursWaluty).HasDefaultValue(1).IsRequired();
			builder.Property(e => e.OpisSposobuPlatnosci).IsRequired();

			builder.Property(e => e.SprzedawcaId).IsRequired();
			builder.Property(e => e.NabywcaId).IsRequired();
			builder.Property(e => e.FakturaKorygowanaId).IsRequired();
			builder.Property(e => e.FakturaKorygujacaId).IsRequired();
			builder.Property(e => e.WalutaId).IsRequired();
			builder.Property(e => e.SposobPlatnosciId).IsRequired();

			builder.Ignore(e => e.SprzedawcaRef);
			builder.Ignore(e => e.NabywcaRef);
			builder.Ignore(e => e.FakturaKorygowanaRef);
			builder.Ignore(e => e.FakturaKorygujacaRef);
			builder.Ignore(e => e.WalutaRef);
			builder.Ignore(e => e.SposobPlatnosciRef);

			builder.HasOne(e => e.Sprzedawca).WithMany().HasForeignKey(e => e.SprzedawcaId).OnDelete(DeleteBehavior.Restrict);
			builder.HasOne(e => e.Nabywca).WithMany().HasForeignKey(e => e.NabywcaId).OnDelete(DeleteBehavior.Restrict);
			builder.HasOne(e => e.FakturaKorygowana).WithMany().HasForeignKey(e => e.FakturaKorygowanaId).OnDelete(DeleteBehavior.Restrict);
			builder.HasOne(e => e.FakturaKorygujaca).WithMany().HasForeignKey(e => e.FakturaKorygujacaId).OnDelete(DeleteBehavior.Restrict);
			builder.HasOne(e => e.Waluta).WithMany().HasForeignKey(e => e.WalutaId).OnDelete(DeleteBehavior.Restrict);
			builder.HasOne(e => e.SposobPlatnosci).WithMany().HasForeignKey(e => e.SposobPlatnosciId).OnDelete(DeleteBehavior.Restrict);
		}
	}
}