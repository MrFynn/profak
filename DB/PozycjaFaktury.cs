﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProFak.DB
{
	class PozycjaFaktury : Rekord<PozycjaFaktury>
	{
		public int FakturaId { get; set; }
		public int TowarId { get; set; }
		public string Opis { get; set; }
		public decimal KwotaNetto { get; set; }
		public decimal KwotaVat { get; set; }
		public decimal KwotaBrutto { get; set; }
		public decimal Ilosc { get; set; }
		public decimal WartoscNetto { get; set; }
		public decimal WartoscVat { get; set; }
		public decimal WartoscBrutto { get; set; }
		public bool CzyWedlugCenBrutto { get; set; }

		public Ref<Faktura> FakturaRef { get => FakturaId; set => FakturaId = value; }
		public Ref<Towar> TowarRef { get => TowarId; set => TowarId = value; }

		public Faktura Faktura { get; set; }
		public Towar Towar { get; set; }
	}
}