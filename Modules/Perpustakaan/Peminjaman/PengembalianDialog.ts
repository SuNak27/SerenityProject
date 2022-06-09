
namespace SerenPro.Perpustakaan {

    @Serenity.Decorators.registerClass()
    export class PengembalianDialog extends Serenity.EntityDialog<PeminjamanRow, any> {
        protected getFormKey() { return PengembalianForm.formKey; }
        protected getIdProperty() { return PeminjamanRow.idProperty; }
        protected getLocalTextPrefix() { return PeminjamanRow.localTextPrefix; }
        protected getNameProperty() { return PeminjamanRow.nameProperty; }
        protected getService() { return PeminjamanService.baseUrl; }
        protected getDeletePermission() { return PeminjamanRow.deletePermission; }
        protected getInsertPermission() { return PeminjamanRow.insertPermission; }
        protected getUpdatePermission() { return PeminjamanRow.updatePermission; }

        protected form = new PengembalianForm(this.idPrefix);

    }
}