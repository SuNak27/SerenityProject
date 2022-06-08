using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace SerenPro.Perpustakaan.Columns
{
    [ColumnsScript("Perpustakaan.Buku")]
    [BasedOnRow(typeof(BukuRow), CheckNames = true)]
    public class BukuColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public int Id { get; set; }
        [EditLink]
        public string KodeBuku { get; set; }
        [QuickFilter]
        public string NamaKategori { get; set; }
        [QuickFilter]
        public string NamaRak { get; set; }
        public string Gambar { get; set; }
        public int Isbn { get; set; }
        public string JudulBuku { get; set; }
        public string Penerbit { get; set; }
        public string Pengarang { get; set; }
        public DateTime TahunBuku { get; set; }
        public string DeskripsiBuku { get; set; }
        public int Jumlah { get; set; }
        public DateTime TanggalMasuk { get; set; }
    }
}