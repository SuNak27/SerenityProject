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
    [ConnectionKey("MasterData"), Module("Perpustakaan"), TableName("rak")]
    [DisplayName("Rak"), InstanceName("Rak")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    [LookupScript("Perpustakaan.Rak")]
    public sealed class RakRow : Row<RakRow.RowFields>, IIdRow, INameRow
    {
        [DisplayName("Id"), Identity, IdProperty]
        public int? Id
        {
            get => fields.Id[this];
            set => fields.Id[this] = value;
        }

        [DisplayName("Rak"), Size(100), QuickSearch, NameProperty]
        public string Rak
        {
            get => fields.Rak[this];
            set => fields.Rak[this] = value;
        }

        public RakRow()
            : base()
        {
        }

        public RakRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field Id;
            public StringField Rak;
        }
    }
}
