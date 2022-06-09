namespace SerenPro.Perpustakaan {
    export interface StatusForm {
        Status: Serenity.StringEditor;
    }

    export class StatusForm extends Serenity.PrefixedContext {
        static formKey = 'Perpustakaan.Status';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!StatusForm.init)  {
                StatusForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;

                Q.initFormType(StatusForm, [
                    'Status', w0
                ]);
            }
        }
    }
}
