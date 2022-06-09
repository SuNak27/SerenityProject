using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace SerenPro.Perpustakaan.Forms
{
    [FormScript("Perpustakaan.Peminjaman")]
    [BasedOnRow(typeof(PeminjamanRow), CheckNames = true)]
    public class PeminjamanForm
    {
        public string KodePeminjaman { get; set; }
        public int IdUser { get; set; }
        public List<Int32> BukuList { get; set; }
        [DefaultValue("1"), Hidden]
        public Int32 IdStatus { get; set; }
        [DefaultValue("now")]
        public DateTime TglPinjam { get; set; }
        public DateTime TglKembali { get; set; }
        public int Denda { get; set; }
    }
}