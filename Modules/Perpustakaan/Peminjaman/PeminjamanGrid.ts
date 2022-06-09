
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

        protected getColumns() {
            var columns = super.getColumns();

            columns.push({
                id: "Kembalikan",
                field: null,
                name: 'aksi',
                format: ctx => '<a class="inline-action-kembali btn btn-warning btn-sm" title="Pengembalian Buku" style="padding-top: 2px; color: white;"' + '<i class="fas fa-sign-out"></i>Kembalikan</a>',
                width: 120,
                minWidth: 120,
                maxWidth: 120
            });

            return columns;
        }

        protected onClick(e: JQueryEventObject, row: number, cell: number) {
            super.onClick(e, row, cell);

            if (e.isDefaultPrevented())
                return;

            var item = this.itemAt(row)
            var target = $(e.target);

            if (target.parent().hasClass('inline-action-kembali'))
                target = target.parent();

            if (target.hasClass('inline-action-kembali')) {
                e.preventDefault();

                Q.confirm("Apakah yakin?", () => {
                    PeminjamanService.Update({
                        EntityId: item.Id,
                        Entity: {
                            IdStatus: 2,
                        }
                    }, res => {
                        Q.notifySuccess("Buku telah dikembalikan");
                        this.refresh();
                    })
                },
                    {
                        onNo: () => {
                            Q.notifyInfo("Anda menekan No, Kenapa?")
                        },

                        onCancel: () => {
                            Q.notifyError("Anda menekan x. Operasi dibatalkan, Mau mencoba lagi?");
                        },
                        dialogClass: 's-Message-Dialog s-WarningDialog'
                    })
            }
        }
    }
}