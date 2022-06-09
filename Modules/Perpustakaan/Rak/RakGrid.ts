
namespace SerenPro.Perpustakaan {

    @Serenity.Decorators.registerClass()
    export class RakGrid extends Serenity.EntityGrid<RakRow, any> {
        protected getColumnsKey() { return RakColumns.columnsKey; }
        protected getDialogType() { return RakDialog; }
        protected getIdProperty() { return RakRow.idProperty; }
        protected getInsertPermission() { return RakRow.insertPermission; }
        protected getLocalTextPrefix() { return RakRow.localTextPrefix; }
        protected getService() { return RakService.baseUrl; }

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