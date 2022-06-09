using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace SerenPro.Perpustakaan.Forms
{
    [FormScript("Perpustakaan.Pengembalian")]
    [BasedOnRow(typeof(PeminjamanRow), CheckNames = true)]
    public class PengembalianForm
    {
        public string KodePeminjaman { get; set; }
        public int IdUser { get; set; }
        public List<Int32> BukuList { get; set; }
        [DefaultValue("2"), Hidden]
        public Int32 Status { get; set; }
        [DefaultValue("now")]
        public DateTime TglPinjam { get; set; }
        public DateTime TglKembali { get; set; }
        public int Denda { get; set; }
    }
}