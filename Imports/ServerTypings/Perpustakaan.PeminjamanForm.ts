namespace SerenPro.Perpustakaan {
    export interface PeminjamanForm {
        KodePeminjaman: Serenity.StringEditor;
        IdUser: Serenity.LookupEditor;
        BukuList: PeminjamanbukuEditor;
        IdStatus: Serenity.LookupEditor;
        TglPinjam: Serenity.DateEditor;
        TglKembali: Serenity.DateEditor;
        Denda: Serenity.IntegerEditor;
    }

    export class PeminjamanForm extends Serenity.PrefixedContext {
        static formKey = 'Perpustakaan.Peminjaman';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!PeminjamanForm.init)  {
                PeminjamanForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.LookupEditor;
                var w2 = PeminjamanbukuEditor;
                var w3 = s.DateEditor;
                var w4 = s.IntegerEditor;

                Q.initFormType(PeminjamanForm, [
                    'KodePeminjaman', w0,
                    'IdUser', w1,
                    'BukuList', w2,
                    'IdStatus', w1,
                    'TglPinjam', w3,
                    'TglKembali', w3,
                    'Denda', w4
                ]);
            }
        }
    }
}
