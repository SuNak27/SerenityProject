using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;
using System.Collections.Generic;

namespace SerenPro.Administration.Entities
{
    [ConnectionKey("Default"), Module("Administration"), TableName("Users")]
    [DisplayName("Users"), InstanceName("User")]
    [ReadPermission(PermissionKeys.Security)]
    [ModifyPermission(PermissionKeys.Security)]
    [LookupScript(Permission = PermissionKeys.Security)]
    public sealed class UserRow : LoggingRow<UserRow.RowFields>, IIdRow, INameRow, IIsActiveRow
    {
        [DisplayName("User Id"), Identity, IdProperty]
        public Int32? UserId
        {
            get => fields.UserId[this];
            set => fields.UserId[this] = value;
        }

        [DisplayName("KodeAnggota"), Size(9)]
        public String KodeAnggota
        {
            get => fields.KodeAnggota[this];
            set => fields.KodeAnggota[this] = value;
        }        

        [DisplayName("Username"), Size(100), NotNull, QuickSearch, LookupInclude, NameProperty]
        public String Username
        {
            get => fields.Username[this];
            set => fields.Username[this] = value;
        }

        [DisplayName("Source"), Size(4), NotNull, Insertable(false), Updatable(false), DefaultValue("site")]
        public String Source
        {
            get => fields.Source[this];
            set => fields.Source[this] = value;
        }

        [DisplayName("Password Hash"), Size(86), NotNull, Insertable(false), Updatable(false), MinSelectLevel(SelectLevel.Never)]
        public String PasswordHash
        {
            get => fields.PasswordHash[this];
            set => fields.PasswordHash[this] = value;
        }

        [DisplayName("Password Salt"), Size(10), NotNull, Insertable(false), Updatable(false), MinSelectLevel(SelectLevel.Never)]
        public String PasswordSalt
        {
            get => fields.PasswordSalt[this];
            set => fields.PasswordSalt[this] = value;
        }

        [DisplayName("Display Name"), Size(100), NotNull, LookupInclude]
        public String DisplayName
        {
            get => fields.DisplayName[this];
            set => fields.DisplayName[this] = value;
        }

        [DisplayName("Email"), Size(100)]
        public String Email
        {
            get => fields.Email[this];
            set => fields.Email[this] = value;
        }

        [DisplayName("User Image"), Size(100)]
        [ImageUploadEditor(FilenameFormat = "UserImage/~", CopyToHistory = true)]
        public String UserImage
        {
            get => fields.UserImage[this];
            set => fields.UserImage[this] = value;
        }

        [DisplayName("Password"), Size(50), NotMapped]
        public String Password
        {
            get => fields.Password[this];
            set => fields.Password[this] = value;
        }

        [NotNull, Insertable(false), Updatable(true)]
        public Int16? IsActive
        {
            get => fields.IsActive[this];
            set => fields.IsActive[this] = value;
        }

        [DisplayName("Confirm Password"), Size(50), NotMapped]
        public String PasswordConfirm
        {
            get => fields.PasswordConfirm[this];
            set => fields.PasswordConfirm[this] = value;
        }

        [DisplayName("Last Directory Update"), Insertable(false), Updatable(false)]
        public DateTime? LastDirectoryUpdate
        {
            get => fields.LastDirectoryUpdate[this];
            set => fields.LastDirectoryUpdate[this] = value;
        }

        [DisplayName("Tempat Lahir"), Size(100)]
        public String TempatLahir
        {
            get => fields.TempatLahir[this];
            set => fields.TempatLahir[this] = value;
        }

        [DisplayName("Tanggal Lahir")]
        public DateTime? TanggalLahir
        {
            get => fields.TanggalLahir[this];
            set => fields.TanggalLahir[this] = value;
        }

        [DisplayName("Jenis Kelamin"), DefaultValue(JenKel.LakiLaki)]
        public JenKel? JenisKelamin
        {
            get => (JenKel?)fields.JenisKelamin[this];
            set => fields.JenisKelamin[this] = (Int32?)value;
        }

        [DisplayName("Telepon"), Size(20)]
        public String Telepon
        {
            get => fields.Telepon[this];
            set => fields.Telepon[this] = value;
        }
        
        [DisplayName("Whatsapp"), Size(20)]
        public String Whatsapp
        {
            get => fields.Whatsapp[this];
            set => fields.Whatsapp[this] = value;
        }

        [DisplayName("Alamat")]
        public String Alamat
        {
            get => fields.Alamat[this];
            set => fields.Alamat[this] = value;
        }

        [NotesEditor, NotMapped]
        public List<NoteRow> NoteList
        {
            get => fields.NoteList[this];
            set => fields.NoteList[this] = value;
        }

        Int16Field IIsActiveRow.IsActiveField
        {
            get => fields.IsActive;
        }

        public UserRow()
        {
        }

        public UserRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : LoggingRowFields
        {
            public Int32Field UserId;
            public StringField KodeAnggota;
            public StringField Username;
            public StringField Source;
            public StringField PasswordHash;
            public StringField PasswordSalt;
            public StringField DisplayName;
            public StringField Email;
            public StringField UserImage;
            public DateTimeField LastDirectoryUpdate;
            public Int16Field IsActive; 

            public StringField Password;
            public StringField PasswordConfirm;

            public StringField TempatLahir;
            public DateTimeField TanggalLahir;
            public Int32Field JenisKelamin;
            public StringField Telepon;
            public StringField Whatsapp;
            public StringField Alamat;
            public RowListField<NoteRow> NoteList;

        }
    }
}