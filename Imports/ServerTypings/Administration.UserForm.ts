namespace SerenPro.Administration {
    export interface UserForm {
        KodeAnggota: Serenity.StringEditor;
        Username: Serenity.StringEditor;
        DisplayName: Serenity.StringEditor;
        Email: Serenity.EmailEditor;
        UserImage: Serenity.ImageUploadEditor;
        TempatLahir: Serenity.StringEditor;
        TanggalLahir: Serenity.DateEditor;
        JenisKelamin: Serenity.EnumEditor;
        Telepon: Serenity.StringEditor;
        Whatsapp: Serenity.StringEditor;
        Alamat: Serenity.StringEditor;
        Password: Serenity.PasswordEditor;
        PasswordConfirm: Serenity.PasswordEditor;
        Source: Serenity.StringEditor;
        NoteList: NotesEditor;
    }

    export class UserForm extends Serenity.PrefixedContext {
        static formKey = 'Administration.User';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!UserForm.init)  {
                UserForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.EmailEditor;
                var w2 = s.ImageUploadEditor;
                var w3 = s.DateEditor;
                var w4 = s.EnumEditor;
                var w5 = s.PasswordEditor;
                var w6 = NotesEditor;

                Q.initFormType(UserForm, [
                    'KodeAnggota', w0,
                    'Username', w0,
                    'DisplayName', w0,
                    'Email', w1,
                    'UserImage', w2,
                    'TempatLahir', w0,
                    'TanggalLahir', w3,
                    'JenisKelamin', w4,
                    'Telepon', w0,
                    'Whatsapp', w0,
                    'Alamat', w0,
                    'Password', w5,
                    'PasswordConfirm', w5,
                    'Source', w0,
                    'NoteList', w6
                ]);
            }
        }
    }
}
