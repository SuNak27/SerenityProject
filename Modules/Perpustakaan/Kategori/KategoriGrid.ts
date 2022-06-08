
namespace SerenPro.Perpustakaan {

    @Serenity.Decorators.registerClass()
    export class KategoriGrid extends Serenity.EntityGrid<KategoriRow, any> {
        protected getColumnsKey() { return KategoriColumns.columnsKey; }
        protected getDialogType() { return KategoriDialog; }
        protected getIdProperty() { return KategoriRow.idProperty; }
        protected getInsertPermission() { return KategoriRow.insertPermission; }
        protected getLocalTextPrefix() { return KategoriRow.localTextPrefix; }
        protected getService() { return KategoriService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}