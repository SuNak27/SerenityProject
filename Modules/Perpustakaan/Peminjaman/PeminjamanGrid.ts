
namespace SerenPro.Perpustakaan {

    @Serenity.Decorators.registerClass()
    export class PeminjamanGrid extends Serenity.EntityGrid<PeminjamanRow, any> {
        protected getColumnsKey() { return PeminjamanColumns.columnsKey; }
        protected getDialogType() { return PeminjamanDialog; }
        protected getIdProperty() { return PeminjamanRow.idProperty; }
        protected getInsertPermission() { return PeminjamanRow.insertPermission; }
        protected getLocalTextPrefix() { return PeminjamanRow.localTextPrefix; }
        protected getService() { return PeminjamanService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}