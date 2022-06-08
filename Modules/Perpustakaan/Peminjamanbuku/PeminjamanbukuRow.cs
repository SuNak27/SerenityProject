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
        [DisplayName("Id"), PrimaryKey, Identity, IdProperty]
        public int? Id
        {
            get => fields.Id[this];
            set => fields.Id[this] = value;
        }

        [DisplayName("Id Peminjaman"), NotNull]
        public int? IdPeminjaman
        {
            get => fields.IdPeminjaman[this];
            set => fields.IdPeminjaman[this] = value;
        }

        [DisplayName("Id Buku"), NotNull]
        public int? IdBuku
        {
            get => fields.IdBuku[this];
            set => fields.IdBuku[this] = value;
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
        }
    }
}
