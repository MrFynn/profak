﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProFak.IO.KSEF;

class InvoiceHeader
{
	public string ReferenceNumber { get; set; }
	public string KsefReferenceNumber { get; set; }
	public DateTime InvoicingDate { get; set; }
	public DateTime AcquisitionTimestamp { get; set; }
	public string IssuedByName { get; set; }
	public string IssuedByNIP { get; set; }
	public string IssuedToName { get; set; }
	public string IssuedToNIP { get; set; }
	public decimal Net { get; set; }
	public decimal Gross { get; set; }
	public decimal Vat { get; set; }
	public string Currency { get; set; }
	public string Type { get; set; }
}