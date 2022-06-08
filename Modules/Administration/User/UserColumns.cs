using Serenity.ComponentModel;
using System;

namespace SerenPro.Administration.Columns
{
    [ColumnsScript("Administration.User")]
    [BasedOnRow(typeof(Entities.UserRow), CheckNames = true)]
    public class UserColumns
    {
        [EditLink, AlignRight, Width(55)]
        public String UserId { get; set; }
        public String KodeAnggota { get; set; }
        [EditLink, Width(150)]
        public String Username { get; set; }
        [Width(150)]
        public String DisplayName { get; set; }
        public String TempatLahir { get; set; }
        public DateTime TanggalLahir { get; set; }
        public JenKel JenisKelamin { get; set; }
        public String Telepon { get; set; }
        public String Whatsapp { get; set; }
        [TextAreaEditor(Rows = 4)]
        public String Alamat { get; set; }
        [Width(250)]
        public String Email { get; set; }
        [Width(100)]
        public String Source { get; set; }
    }
}
