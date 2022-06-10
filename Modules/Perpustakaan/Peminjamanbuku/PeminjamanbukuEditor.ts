namespace SerenPro.Perpustakaan {
    @Serenity.Decorators.registerEditor()
    export class PeminjamanbukuEditor extends Serenity.Extensions.GridEditorBase<PeminjamanbukuRow> {
        protected getColumnsKey() { return "Perpustakaan.Peminjamanbuku"; }
        protected getDialogType() { return PeminjamanbukuEditDialog; }
        protected getLocalTextPrefix() { return PeminjamanbukuRow.localTextPrefix; }

        constructor(container: JQuery) {
            super(container);
        }

        protected getAddButtonCaption() {
            return "Add";
        }

        protected validateEntity(row: PeminjamanbukuRow, id: number) {
            if (!super.validateEntity(row, id))
                return false;

            row.IdBukuJudulBuku = BukuRow.getLookup()
                .itemById[row.IdBuku].JudulBuku;

            return true;
        }

        protected getSlickOptions(): Slick.GridOptions {
            let opt = super.getSlickOptions();
            opt.rowHeight = 150;
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

        public disableAddButton() {
            this.toolbar.findButton('add-button').hide();
            this.toolbar.findButton('column-picker-button').hide();
        }
    }
} 