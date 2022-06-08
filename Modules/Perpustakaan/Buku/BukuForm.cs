using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace SerenPro.Perpustakaan.Forms
{
    [FormScript("Perpustakaan.Buku")]
    [BasedOnRow(typeof(BukuRow), CheckNames = true)]
    public class BukuForm
    {
        public string KodeBuku { get; set; }
        public int IdKategori { get; set; }
        public int IdRak { get; set; }
        public string Gambar { get; set; }
        public int Isbn { get; set; }
        public string JudulBuku { get; set; }
        public string Penerbit { get; set; }
        public string Pengarang { get; set; }
        public DateTime TahunBuku { get; set; }
        public string DeskripsiBuku { get; set; }
        public int Jumlah { get; set; }
        [DefaultValue("now")]
        public DateTime TanggalMasuk { get; set; }
    }
}