using System.Linq;
using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;
using System.IO;

namespace SerenPro.Perpustakaan
{
    [ConnectionKey("MasterData"), Module("Perpustakaan"), TableName("peminjamanbuku")]
    [DisplayName("Peminjamanbuku"), InstanceName("Peminjamanbuku")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class PeminjamanbukuRow : Row<PeminjamanbukuRow.RowFields>, IIdRow
    {
        [DisplayName("Id"), Identity, IdProperty]
        public int? Id
        {
            get => fields.Id[this];
            set => fields.Id[this] = value;
        }

        [DisplayName("Id Peminjaman"), NotNull, ForeignKey("peminjaman", "id"), LeftJoin("jIdPeminjaman"), TextualField("IdPeminjamanKodePeminjaman")]
        public int? IdPeminjaman
        {
            get => fields.IdPeminjaman[this];
            set => fields.IdPeminjaman[this] = value;
        }

        [DisplayName("Id Buku"), NotNull, ForeignKey("buku", "id"), LeftJoin("jIdBuku"), TextualField("IdBukuKodeBuku")]
        [LookupEditor(typeof(BukuRow))]
        public int? IdBuku
        {
            get => fields.IdBuku[this];
            set => fields.IdBuku[this] = value;
        }

        [DisplayName("Id Buku Judul Buku"), Expression("jIdBuku.[JudulBuku]")]
        public String IdBukuJudulBuku
        {
            get => fields.IdBukuJudulBuku[this];
            set => fields.IdBukuJudulBuku[this] = value;
        }

        [DisplayName("Id Buku Kode Buku"), Expression("jIdBuku.[KodeBuku]")]
        public String IdBukuKodeBuku
        {
            get => fields.IdBukuKodeBuku[this];
            set => fields.IdBukuKodeBuku[this] = value;
        }

        [DisplayName("Id Buku Gambar"), Expression("jIdBuku.[Gambar]")]
        public String IdBukuGambarBuku
        {
            get => fields.IdBukuGambarBuku[this];
            set => fields.IdBukuGambarBuku[this] = value;
        }

        [DisplayName("Id Buku Penerbit"), Expression("jIdBuku.[Penerbit]")]
        public String IdBukuPenerbit
        {
            get => fields.IdBukuPenerbit[this];
            set => fields.IdBukuPenerbit[this] = value;
        }

        [DisplayName("Id Buku Pengarang"), Expression("jIdBuku.[Pengarang]")]
        public String IdBukuPengarang
        {
            get => fields.IdBukuPengarang[this];
            set => fields.IdBukuPengarang[this] = value;
        }

        [DisplayName("Id Buku Deskripsi Buku"), Expression("jIdBuku.[DeskripsiBuku]")]
        public String IdBukuDeskripsiBuku
        {
            get => fields.IdBukuDeskripsiBuku[this];
            set => fields.IdBukuDeskripsiBuku[this] = value;
        }

        public PeminjamanbukuRow()
            : base()
        {
        }

        public PeminjamanbukuRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field Id;
            public Int32Field IdPeminjaman;
            public Int32Field IdBuku;
            public StringField IdBukuJudulBuku;
            public StringField IdBukuKodeBuku;
            public StringField IdBukuGambarBuku;
            public StringField IdBukuPenerbit;
            public StringField IdBukuPengarang;
            public StringField IdBukuDeskripsiBuku;
        }
    }
}
