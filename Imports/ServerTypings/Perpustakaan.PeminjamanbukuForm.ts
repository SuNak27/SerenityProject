namespace SerenPro.Perpustakaan {
    export interface PeminjamanbukuForm {
        IdBuku: Serenity.LookupEditor;
    }

    export class PeminjamanbukuForm extends Serenity.PrefixedContext {
        static formKey = 'Perpustakaan.Peminjamanbuku';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!PeminjamanbukuForm.init)  {
                PeminjamanbukuForm.init = true;

                var s = Serenity;
                var w0 = s.LookupEditor;

                Q.initFormType(PeminjamanbukuForm, [
                    'IdBuku', w0
                ]);
            }
        }
    }
}
