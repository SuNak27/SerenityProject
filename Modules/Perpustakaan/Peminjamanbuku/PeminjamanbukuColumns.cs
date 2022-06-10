using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace SerenPro.Perpustakaan.Columns
{
    [ColumnsScript("Perpustakaan.Peminjamanbuku")]
    [BasedOnRow(typeof(PeminjamanbukuRow), CheckNames = true)]
    public class PeminjamanbukuColumns
    {
        [DisplayName("Kode Buku"), EditLink, Width(150), KodeBukuFormatter]
        public String IdBukuKodeBuku { get; set; } 
        [DisplayName("Gambar"), Width(150), GambarFormatter]
        public String IdBukuGambarBuku { get; set; } 
        [DisplayName("Judul Buku"), Width(150), JudulBukuFormatter]
        public String IdBukuJudulBuku { get; set; } 
        [DisplayName("Penerbit"), Width(150), PenerbitFormatter]
        public String IdBukuPenerbit { get; set; } 
        [DisplayName("Pengarang"), Width(150), PengarangFormatter]
        public String IdBukuPengarang { get; set; } 
        [DisplayName("Deskripsi Buku"), Width(150), DeskripsiFormatter]
        public String IdBukuDeskripsiBuku { get; set; } 

    }
}