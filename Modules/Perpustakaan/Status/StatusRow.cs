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
    [ConnectionKey("MasterData"), Module("Perpustakaan"), TableName("status")]
    [DisplayName("Status"), InstanceName("Status")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    [LookupScript("Perpustakaan.Status")]
    public sealed class StatusRow : Row<StatusRow.RowFields>, IIdRow, INameRow
    {
        [DisplayName("Id"), Identity, IdProperty]
        public int? Id
        {
            get => fields.Id[this];
            set => fields.Id[this] = value;
        }

        [DisplayName("Status"), Size(50), QuickSearch, NameProperty]
        public string Status
        {
            get => fields.Status[this];
            set => fields.Status[this] = value;
        }

        public StatusRow()
            : base()
        {
        }

        public StatusRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field Id;
            public StringField Status;
        }
    }
}
