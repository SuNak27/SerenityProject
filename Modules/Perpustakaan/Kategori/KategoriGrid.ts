
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

        protected getSlickOptions(): Slick.GridOptions {
            let opt = super.getSlickOptions();
            opt.enableTextSelectionOnCells = true;
            opt.selectedCellCssClass = "slick-row-selected";
            opt.enableCellNavigation = true;
            return opt;
        }

        protected createSlickGrid(): Slick.Grid {
            var grid = super.createSlickGrid();
            grid.setSelectionModel(new Slick.RowSelectionModel());
            return grid;
        }
    }
}