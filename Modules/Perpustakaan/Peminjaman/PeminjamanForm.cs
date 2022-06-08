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
        public Status Status { get; set; }
        [DefaultValue("now")]
        public DateTime TglPinjam { get; set; }
        public DateTime TglKembali { get; set; }
        [Hidden]
        public int Denda { get; set; }
    }
}