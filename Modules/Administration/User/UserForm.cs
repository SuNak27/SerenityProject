using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace SerenPro.Administration.Forms
{
    [FormScript("Administration.User")]
    [BasedOnRow(typeof(Entities.UserRow), CheckNames = true)]
    public class UserForm
    {
        public String KodeAnggota { get; set; }
        public String Username { get; set; }
        public String DisplayName { get; set; }
        [EmailEditor]
        public String Email { get; set; }
        [DisplayName("Foto")]
        public String UserImage { get; set; }
        public String TempatLahir { get; set; }
        public DateTime TanggalLahir { get; set; }
        public JenKel JenisKelamin { get; set; }
        public String Telepon { get; set; }
        public String Whatsapp { get; set; }
        public String Alamat { get; set; }
        [PasswordEditor, Required(true)]
        public String Password { get; set; }
        [PasswordEditor, OneWay, Required(true)]
        public String PasswordConfirm { get; set; }
        [OneWay]
        public string Source { get; set; }
    }
}