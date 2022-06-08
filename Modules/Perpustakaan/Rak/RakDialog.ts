
namespace SerenPro.Perpustakaan {

    @Serenity.Decorators.registerClass()
    export class RakDialog extends Serenity.EntityDialog<RakRow, any> {
        protected getFormKey() { return RakForm.formKey; }
        protected getIdProperty() { return RakRow.idProperty; }
        protected getLocalTextPrefix() { return RakRow.localTextPrefix; }
        protected getNameProperty() { return RakRow.nameProperty; }
        protected getService() { return RakService.baseUrl; }
        protected getDeletePermission() { return RakRow.deletePermission; }
        protected getInsertPermission() { return RakRow.insertPermission; }
        protected getUpdatePermission() { return RakRow.updatePermission; }

        protected form = new RakForm(this.idPrefix);

    }
}