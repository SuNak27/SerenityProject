namespace SerenPro.Perpustakaan {
    export interface PengembalianForm {
        KodePeminjaman: Serenity.StringEditor;
        IdUser: Serenity.LookupEditor;
        BukuList: PeminjamanbukuEditor;
        Status: Serenity.IntegerEditor;
        TglPinjam: Serenity.DateEditor;
        TglKembali: Serenity.DateEditor;
        Denda: Serenity.IntegerEditor;
    }

    export class PengembalianForm extends Serenity.PrefixedContext {
        static formKey = 'Perpustakaan.Pengembalian';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!PengembalianForm.init)  {
                PengembalianForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.LookupEditor;
                var w2 = PeminjamanbukuEditor;
                var w3 = s.IntegerEditor;
                var w4 = s.DateEditor;

                Q.initFormType(PengembalianForm, [
                    'KodePeminjaman', w0,
                    'IdUser', w1,
                    'BukuList', w2,
                    'Status', w3,
                    'TglPinjam', w4,
                    'TglKembali', w4,
                    'Denda', w3
                ]);
            }
        }
    }
}
