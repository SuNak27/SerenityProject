namespace SerenPro.Perpustakaan {

    @Serenity.Decorators.registerClass()
    export class PeminjamanbukuEditDialog extends
        Serenity.Extensions.GridEditorDialog<PeminjamanbukuRow> {
        protected getFormKey() { return PeminjamanbukuForm.formKey; }
        protected getLocalTextPrefix() { return PeminjamanbukuRow.localTextPrefix; }

        protected form: PeminjamanbukuForm;

        constructor() {
            super();
            this.form = new PeminjamanbukuForm(this.idPrefix);
        }
    }
}