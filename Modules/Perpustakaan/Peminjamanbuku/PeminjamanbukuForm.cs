using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace SerenPro.Perpustakaan.Forms
{
    [FormScript("Perpustakaan.Peminjamanbuku")]
    [BasedOnRow(typeof(PeminjamanbukuRow), CheckNames = true)]
    public class PeminjamanbukuForm
    {
        [DisplayName("Buku")]
        public int IdBuku { get; set; }
    }
}