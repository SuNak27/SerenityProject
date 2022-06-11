namespace SerenPro.Administration {

    @Serenity.Decorators.registerClass()
    export class UserGrid extends Serenity.EntityGrid<UserRow, any> {
        protected getColumnsKey() { return "Administration.User"; }
        protected getDialogType() { return UserDialog; }
        protected getIdProperty() { return UserRow.idProperty; }
        protected getIsActiveProperty() { return UserRow.isActiveProperty; }
        protected getLocalTextPrefix() { return UserRow.localTextPrefix; }
        protected getService() { return UserService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }

        protected getDefaultSortBy() {
            return [UserRow.Fields.Username];
        }

        protected getSlickOptions(): Slick.GridOptions {
            let opt = super.getSlickOptions();
            opt.rowHeight = 35;
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

        protected getColumns() {
            var columns = super.getColumns();

            columns.push({
                id: "Cetak Kartu Anggota",
                field: null,
                name: 'aksi',
                format: ctx => '<a class="inline-action-cetak btn btn-primary btn-sm" title="Cetak Kartu Anggota" style="color: white;"' + '<i class="fa fa-print"></i> Cetak Kartu Anggota</a>',
                width: 170,
                minWidth: 170,
                maxWidth: 170
            });

            return columns;
        }

        protected onClick(e: JQueryEventObject, row: number, cell: number) {
            super.onClick(e, row, cell);

            if (e.isDefaultPrevented())
                return;

            var item = this.itemAt(row)
            var target = $(e.target);

            if (target.parent().hasClass('inline-action'))
                target = target.parent();

            if (target.hasClass('inline-action-cetak')) {
                e.preventDefault();

                Q.confirm("Cetak Kartu?", () => {
                    Serenity.Extensions.ReportHelper.execute({
                        reportKey: 'Administration.CetakKartu',
                        params: {
                            UserID: item.UserId
                        }
                    });
                })
            }
        }
    }
}