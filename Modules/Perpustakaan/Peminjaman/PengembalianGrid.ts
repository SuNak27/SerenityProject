
namespace SerenPro.Perpustakaan {

    @Serenity.Decorators.registerClass()
    export class PengembalianGrid extends Serenity.EntityGrid<PeminjamanRow, any> {
        protected getColumnsKey() { return 'Perpustakaan.Pengembalian' }
        protected getDialogType() { return PengembalianDialog; }
        protected getIdProperty() { return PeminjamanRow.idProperty; }
        protected getInsertPermission() { return PeminjamanRow.insertPermission; }
        protected getLocalTextPrefix() { return PeminjamanRow.localTextPrefix; }
        protected getService() { return PeminjamanService.baseUrl; }
        protected createView(): Slick.RemoteView<PeminjamanRow> {
            let view = super.createView();
            (view as any).onDataLoaded.subscribe((e, ui) => {
                this.setTitle('Pengembalian')
            });
            return view;
        }

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

        protected getQuickFilters() {
            var flt = super.getQuickFilters();
            var q = Q.parseQueryString();
            if (q['kategori']) {
                var category = Q.tryFirst(flt, x => x.field == "IdStatus");
                category.init = e => {
                    e.element.getWidget(Serenity.LookupEditor).value = q['kategori'];
                };
                return flt;
            }
        }

        protected getButtons(): Serenity.ToolButton[] {
            var buttons = super.getButtons();
            buttons.splice(Q.indexOf(buttons, x => x.cssClass == "add-button"), 1);

            return buttons;
        }
    }
}