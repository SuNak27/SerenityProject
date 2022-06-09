using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace SerenPro.Perpustakaan.Columns
{
    [ColumnsScript("Perpustakaan.Pengembalian")]
    [BasedOnRow(typeof(PeminjamanRow), CheckNames = true)]
    public class PengembalianColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public int Id { get; set; }
        [EditLink]
        public string KodePeminjaman { get; set; }
        public string KodeAnggota { get; set; }
        [Width(200), BukuListFormatter]
        public List<Int32> BukuList { get; set; }
        [Width(150), QuickFilter]
        public String Status { get; set; }
        public DateTime TglPinjam { get; set; }
        public DateTime TglKembali { get; set; }
        public int Denda { get; set; }
    }
}