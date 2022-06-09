using System.Linq.Expressions;
using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;
using System.IO;
using System.Collections.Generic;

namespace SerenPro.Perpustakaan
{
    [ConnectionKey("MasterData"), Module("Perpustakaan"), TableName("buku")]
    [DisplayName("Buku"), InstanceName("Buku")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    [LookupScript("Perpustakaan.Buku")]
    public sealed class BukuRow : Row<BukuRow.RowFields>, IIdRow, INameRow
    {
        [DisplayName("Id"), Identity, IdProperty]
        public int? Id
        {
            get => fields.Id[this];
            set => fields.Id[this] = value;
        }

        [DisplayName("Kode Buku"), Size(11), QuickSearch]
        public string KodeBuku
        {
            get => fields.KodeBuku[this];
            set => fields.KodeBuku[this] = value;
        }

        [DisplayName("Gambar")]
        [ImageUploadEditor(FilenameFormat = "Buku/BukuImage/~")]
        public string Gambar
        {
            get => fields.Gambar[this];
            set => fields.Gambar[this] = value;
        }

        [DisplayName("Isbn"), Column("ISBN")]
        public int? Isbn
        {
            get => fields.Isbn[this];
            set => fields.Isbn[this] = value;
        }

        [DisplayName("Judul Buku"), Size(100), NameProperty]
        public string JudulBuku
        {
            get => fields.JudulBuku[this];
            set => fields.JudulBuku[this] = value;
        }

        [DisplayName("Penerbit"), Size(100)]
        public string Penerbit
        {
            get => fields.Penerbit[this];
            set => fields.Penerbit[this] = value;
        }

        [DisplayName("Pengarang"), Size(100)]
        public string Pengarang
        {
            get => fields.Pengarang[this];
            set => fields.Pengarang[this] = value;
        }

        [DisplayName("Tahun Buku")]
        public DateTime? TahunBuku
        {
            get => fields.TahunBuku[this];
            set => fields.TahunBuku[this] = value;
        }

        [DisplayName("Deskripsi Buku")]
        public string DeskripsiBuku
        {
            get => fields.DeskripsiBuku[this];
            set => fields.DeskripsiBuku[this] = value;
        }

        [DisplayName("Jumlah")]
        public int? Jumlah
        {
            get => fields.Jumlah[this];
            set => fields.Jumlah[this] = value;
        }

        [DisplayName("Tanggal Masuk")]
        public DateTime? TanggalMasuk
        {
            get => fields.TanggalMasuk[this];
            set => fields.TanggalMasuk[this] = value;
        }

        [DisplayName("Kategori"), ForeignKey("Kategori", "Id"), LeftJoin("jk")]
        [LookupEditor(typeof(KategoriRow), InplaceAdd = true, DialogType = "Perpustakaan.Kategori")]
        public Int32? IdKategori
        {
            get => fields.IdKategori[this];
            set => fields.IdKategori[this] = value;
        }

        [DisplayName("Kategori"), Expression("jk.Nama")]
        public string NamaKategori
        {
            get => fields.NamaKategori[this];
            set => fields.NamaKategori[this] = value;
        }

        [DisplayName("Rak"), ForeignKey("Rak", "Id"), LeftJoin("r")]
        [LookupEditor(typeof(RakRow), InplaceAdd = true, DialogType = "Perpustakaan.Rak")]
        public Int32? IdRak
        {
            get => fields.IdRak[this];
            set => fields.IdRak[this] = value;
        }

        [DisplayName("Rak"), Expression("r.Rak")]
        public string NamaRak
        {
            get => fields.NamaRak[this];
            set => fields.NamaRak[this] = value;
        }

        public BukuRow()
            : base()
        {
        }

        public BukuRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field Id;
            public StringField KodeBuku;
            public StringField Gambar;
            public Int32Field Isbn;
            public StringField JudulBuku;
            public StringField Penerbit;
            public StringField Pengarang;
            public DateTimeField TahunBuku;
            public StringField DeskripsiBuku;
            public Int32Field Jumlah;
            public DateTimeField TanggalMasuk;
            public Int32Field IdKategori;
            public StringField NamaKategori;
            public Int32Field IdRak;
            public StringField NamaRak;
        }
    }
}
