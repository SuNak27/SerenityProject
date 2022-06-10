
namespace SerenPro.Perpustakaan {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.panel()
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

        protected getToolbarButtons(): Serenity.ToolButton[] {
            let buttons = super.getToolbarButtons();

            buttons.splice(Q.indexOf(buttons, x => x.cssClass == "save-and-close-button"), 1);
            buttons.splice(Q.indexOf(buttons, x => x.cssClass == "apply-changes-button"), 1);
            return buttons;
        }

        protected updateInterface(): void {

            super.updateInterface();
            Serenity.EditorUtils.setReadonly(this.element.find('.editor'), true);
            this.element.find('sup').hide();

            this.deleteButton.hide();

            this.form.BukuList.disableAddButton();

        }

    }
}