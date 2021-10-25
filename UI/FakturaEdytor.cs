﻿using ProFak.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProFak.UI
{
	partial class FakturaEdytor : UserControl, IEdytor<Faktura>
	{
		public Faktura Rekord { get => bindingSource.DataSource as Faktura; private set => bindingSource.DataSource = value; }
		public Kontekst Kontekst { get; private set; }

		public FakturaEdytor()
		{
			InitializeComponent();
			comboBoxRodzaj.DataSource = Enum.GetValues(typeof(RodzajFaktury)).Cast<RodzajFaktury>().Select(r => new PozycjaListy<RodzajFaktury> { Wartosc = r, Opis = r.ToString() }).ToArray();
			comboBoxRodzaj.DisplayMember = "Opis";
			comboBoxRodzaj.ValueMember = "Wartosc";
		}

		public void Przygotuj(Kontekst kontekst, Faktura rekord)
		{
			Kontekst = kontekst;
			WypelnijSpisy();
			UstawObowiazkowePola(rekord);
			Rekord = rekord;
		}

		private void WypelnijSpisy()
		{
			new SwobodnySlownik<SposobPlatnosci>(
				Kontekst, comboBoxSposobPlatnosci, buttonSposobPlatnosci,
				Kontekst.Baza.SposobyPlatnosci.ToList,
				sposobPlatnosci => sposobPlatnosci.Nazwa,
				sposobPlatnosci => { if (sposobPlatnosci == null || Rekord.SposobPlatnosciRef == sposobPlatnosci.Ref) return; Rekord.SposobPlatnosciRef = sposobPlatnosci; Rekord.OpisSposobuPlatnosci = sposobPlatnosci.Nazwa; Rekord.TerminPlatnosci = Rekord.DataWystawienia.AddDays(sposobPlatnosci.LiczbaDni); bindingSource.ResetCurrentItem(); },
				Spis.SposobyPlatnosci
				)
				.Zainstaluj();

			new SwobodnySlownik<Kontrahent>(
				Kontekst, comboBoxNIPNabywcy, buttonNabywca,
				Kontekst.Baza.Kontrahenci.ToList,
				kontrahent => kontrahent.NIP,
				kontrahent => { if (kontrahent == null || Rekord.NabywcaRef == kontrahent.Ref) return; Rekord.NabywcaRef = kontrahent; Rekord.NIPNabywcy = kontrahent.NIP; Rekord.NazwaNabywcy = kontrahent.PelnaNazwa; Rekord.DaneNabywcy = kontrahent.AdresRejestrowy; bindingSource.ResetCurrentItem(); },
				Spis.Kontrahenci)
				.Zainstaluj();

			new SwobodnySlownik<Kontrahent>(
				Kontekst, comboBoxNazwaNabywcy, null,
				Kontekst.Baza.Kontrahenci.ToList,
				kontrahent => kontrahent.PelnaNazwa,
				kontrahent => { if (kontrahent == null || Rekord.NabywcaRef == kontrahent.Ref) return; Rekord.NabywcaRef = kontrahent; Rekord.NIPNabywcy = kontrahent.NIP; Rekord.NazwaNabywcy = kontrahent.PelnaNazwa; Rekord.DaneNabywcy = kontrahent.AdresRejestrowy; bindingSource.ResetCurrentItem(); },
				Spis.Kontrahenci)
				.Zainstaluj();

			new SwobodnySlownik<Kontrahent>(
				Kontekst, comboBoxNIPSprzedawcy, buttonSprzedawca,
				Kontekst.Baza.Kontrahenci.ToList,
				kontrahent => kontrahent.NIP,
				kontrahent => { if (kontrahent == null || Rekord.SprzedawcaRef == kontrahent.Ref) return; Rekord.SprzedawcaRef = kontrahent; Rekord.NIPSprzedawcy = kontrahent.NIP; Rekord.NazwaSprzedawcy = kontrahent.PelnaNazwa; Rekord.DaneSprzedawcy = kontrahent.AdresRejestrowy; bindingSource.ResetCurrentItem(); },
				Spis.Kontrahenci)
				.Zainstaluj();

			new SwobodnySlownik<Kontrahent>(
				Kontekst, comboBoxNazwaSprzedawcy, null,
				Kontekst.Baza.Kontrahenci.ToList,
				kontrahent => kontrahent.PelnaNazwa,
				kontrahent => { if (kontrahent == null || Rekord.SprzedawcaRef == kontrahent.Ref) return; Rekord.SprzedawcaRef = kontrahent; Rekord.NIPSprzedawcy = kontrahent.NIP; Rekord.NazwaSprzedawcy = kontrahent.PelnaNazwa; Rekord.DaneSprzedawcy = kontrahent.AdresRejestrowy; bindingSource.ResetCurrentItem(); },
				Spis.Kontrahenci)
				.Zainstaluj();
		}

		private void UstawObowiazkowePola(Faktura faktura)
		{
			if (faktura.Id == 0)
			{
				faktura.DataSprzedazy = DateTime.Now.Date;
				faktura.DataWystawienia = DateTime.Now.Date;
				faktura.DataWprowadzenia = DateTime.Now.Date;
				faktura.TerminPlatnosci = DateTime.Now.Date;
				faktura.WalutaRef = Kontekst.Baza.Waluty.FirstOrDefault(waluta => waluta.CzyDomyslna);
				faktura.SposobPlatnosciRef = Kontekst.Baza.SposobyPlatnosci.FirstOrDefault(sposob => sposob.CzyDomyslny);
				faktura.Uwagi = "";
			}
		}
	}
}