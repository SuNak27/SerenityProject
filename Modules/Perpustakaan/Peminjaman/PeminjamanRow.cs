using System.Security.AccessControl;
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
    [ConnectionKey("MasterData"), Module("Perpustakaan"), TableName("peminjaman")]
    [DisplayName("Peminjaman"), InstanceName("Peminjaman")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class PeminjamanRow : Row<PeminjamanRow.RowFields>, IIdRow, INameRow
    {
        [DisplayName("Id"), Identity, IdProperty]
        public int? Id
        {
            get => fields.Id[this];
            set => fields.Id[this] = value;
        }

        [DisplayName("Kode Peminjaman"), Size(9), QuickSearch, NameProperty]
        public string KodePeminjaman
        {
            get => fields.KodePeminjaman[this];
            set => fields.KodePeminjaman[this] = value;
        }

        [DisplayName("Anggota"), ForeignKey("[perpustakaan_default_v1].[Users]", "UserId"), LeftJoin("jUser")]
        [LookupEditor(typeof(SerenPro.Administration.Entities.UserRow), InplaceAdd = true, DialogType = "Administration.User")]
        public int? IdUser
        {
            get => fields.IdUser[this];
            set => fields.IdUser[this] = value;
        }

        [DisplayName("Buku")]
        [LookupEditor(typeof(BukuRow), Multiple = true, InplaceAdd = true), NotMapped]
        [LinkingSetRelation(typeof(PeminjamanbukuRow), "IdPeminjaman", "IdBuku")]
        public List<Int32> BukuList
        {
            get => fields.BukuList[this];
            set => fields.BukuList[this] = value;
        }

        [DisplayName("Anggota"), Expression("jUser.KodeAnggota")]
        public string KodeAnggota
        {
            get => fields.KodeAnggota[this];
            set => fields.KodeAnggota[this] = value;
        }

        [DisplayName("Status"), ForeignKey("Status", "Id"), LeftJoin("lStatus")]
        [LookupEditor(typeof(StatusRow), InplaceAdd = true, DialogType = "Perpustakaan.Status")]
        public Int32? IdStatus
        {
            get => fields.IdStatus[this];
            set => fields.IdStatus[this] = value;
        }

        [DisplayName("Status"), Expression("lStatus.Status")]
        public String Status
        {
            get => fields.Status[this];
            set => fields.Status[this] = value;
        }

        [DisplayName("Tgl Pinjam")]
        public DateTime? TglPinjam
        {
            get => fields.TglPinjam[this];
            set => fields.TglPinjam[this] = value;
        }

        [DisplayName("Tgl Kembali")]
        public DateTime? TglKembali
        {
            get => fields.TglKembali[this];
            set => fields.TglKembali[this] = value;
        }

        [DisplayName("Denda")]
        public int? Denda
        {
            get => fields.Denda[this];
            set => fields.Denda[this] = value;
        }

        public PeminjamanRow()
            : base()
        {
        }

        public PeminjamanRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field Id;
            public StringField KodePeminjaman;
            public Int32Field IdUser;
            public ListField<Int32> BukuList;
            public StringField KodeAnggota;
            public Int32Field IdStatus;
            public StringField Status;
            public DateTimeField TglPinjam;
            public DateTimeField TglKembali;
            public Int32Field Denda;
        }
    }
}
