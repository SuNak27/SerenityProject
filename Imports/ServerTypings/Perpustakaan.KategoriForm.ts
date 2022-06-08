namespace SerenPro.Perpustakaan {
    export interface KategoriForm {
        Nama: Serenity.StringEditor;
    }

    export class KategoriForm extends Serenity.PrefixedContext {
        static formKey = 'Perpustakaan.Kategori';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!KategoriForm.init)  {
                KategoriForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;

                Q.initFormType(KategoriForm, [
                    'Nama', w0
                ]);
            }
        }
    }
}
