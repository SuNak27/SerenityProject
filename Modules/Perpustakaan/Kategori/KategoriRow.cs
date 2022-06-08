using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;
using System.IO;

namespace SerenPro.Perpustakaan
{
    [ConnectionKey("MasterData"), Module("Perpustakaan"), TableName("kategori")]
    [DisplayName("Kategori"), InstanceName("Kategori")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    [LookupScript("Perpustakaan.Kategori")]
    public sealed class KategoriRow : Row<KategoriRow.RowFields>, IIdRow, INameRow
    {
        [DisplayName("Id"), PrimaryKey, Identity, IdProperty]
        public int? Id
        {
            get => fields.Id[this];
            set => fields.Id[this] = value;
        }

        [DisplayName("Nama"), Size(100), QuickSearch, NameProperty]
        public string Nama
        {
            get => fields.Nama[this];
            set => fields.Nama[this] = value;
        }

        public KategoriRow()
            : base()
        {
        }

        public KategoriRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field Id;
            public StringField Nama;
        }
    }
}
