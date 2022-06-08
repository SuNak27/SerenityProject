
namespace SerenPro.Perpustakaan {

    @Serenity.Decorators.registerClass()
    export class KategoriDialog extends Serenity.EntityDialog<KategoriRow, any> {
        protected getFormKey() { return KategoriForm.formKey; }
        protected getIdProperty() { return KategoriRow.idProperty; }
        protected getLocalTextPrefix() { return KategoriRow.localTextPrefix; }
        protected getNameProperty() { return KategoriRow.nameProperty; }
        protected getService() { return KategoriService.baseUrl; }
        protected getDeletePermission() { return KategoriRow.deletePermission; }
        protected getInsertPermission() { return KategoriRow.insertPermission; }
        protected getUpdatePermission() { return KategoriRow.updatePermission; }

        protected form = new KategoriForm(this.idPrefix);

    }
}