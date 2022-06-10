using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;
using System.IO;

namespace SerenPro.Administration
{
    [ConnectionKey("Default"), Module("Administration"), TableName("notes")]
    [DisplayName("Note"), InstanceName("Note")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class NoteRow : Row<NoteRow.RowFields>, IIdRow, INameRow, IInsertLogRow
    {
        [DisplayName("Note Id"), Column("NoteID"), Identity, IdProperty]
        public long? NoteID
        {
            get => fields.NoteID[this];
            set => fields.NoteID[this] = value;
        }

        [DisplayName("Entity Type"), Size(100), NotNull, NameProperty, Updatable(false)]
        public string EntityType
        {
            get => fields.EntityType[this];
            set => fields.EntityType[this] = value;
        }

        [DisplayName("Entity Id"), Column("EntityID"), NotNull, Updatable(false), Size(100)]
        public long? EntityId
        {
            get => fields.EntityId[this];
            set => fields.EntityId[this] = value;
        }

        [DisplayName("Text"), NotNull, QuickSearch]
        public String Text
        {
            get => fields.Text[this];
            set => fields.Text[this] = value;
        }

        [DisplayName("Insert User Id"), NotNull, Insertable(false), Updatable(false)]
        public int? InsertUserId
        {
            get => fields.InsertUserId[this];
            set => fields.InsertUserId[this] = value;
        }

        [DisplayName("Insert User"), NotMapped]
        public string InsertUserDisplayName
        {
            get => fields.InsertUserDisplayName[this];
            set => fields.InsertUserDisplayName[this] = value;
        }

        [DisplayName("Insert Date"), NotNull, Insertable(false), Updatable(false)]
        public DateTime? InsertDate
        {
            get => fields.InsertDate[this];
            set => fields.InsertDate[this] = value;
        }

        public Field InsertUserIdField
        {
            get
            {
                return Fields.InsertUserId;
            }
        }

        public DateTimeField InsertDateField
        {
            get
            {
                return Fields.InsertDate;
            }
        }


        public NoteRow()
            : base()
        {
        }

        public NoteRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int64Field NoteID;
            public StringField EntityType;
            public Int64Field EntityId;
            public StringField Text;
            public Int32Field InsertUserId;
            public DateTimeField InsertDate;
            public StringField InsertUserDisplayName;
        }
    }
}
