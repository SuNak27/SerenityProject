using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace SerenPro.Perpustakaan.Columns
{
    [ColumnsScript("Perpustakaan.Peminjaman")]
    [BasedOnRow(typeof(PeminjamanRow), CheckNames = true)]
    public class PeminjamanColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public int Id { get; set; }
        [EditLink]
        public string KodePeminjaman { get; set; }
        public string KodeAnggota { get; set; }
        public string Username { get; set; }
        [BukuListFormatter, Width(150)]
        public List<PeminjamanbukuRow> BukuList { get; set; }
        [Width(150), QuickFilter]
        public String Status { get; set; }
        public DateTime TglPinjam { get; set; }
        public DateTime TglKembali { get; set; }
        public int Denda { get; set; }
    }
}