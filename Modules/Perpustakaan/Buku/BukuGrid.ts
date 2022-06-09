namespace SerenPro.Perpustakaan {
    import fld = Perpustakaan.BukuRow.Fields;

    @Serenity.Decorators.filterable()
    @Serenity.Decorators.registerClass()
    export class BukuGrid extends Serenity.EntityGrid<BukuRow, any> {
        protected getColumnsKey() { return BukuColumns.columnsKey; }
        protected getDialogType() { return BukuDialog; }
        protected getIdProperty() { return BukuRow.idProperty; }
        protected getInsertPermission() { return BukuRow.insertPermission; }
        protected getLocalTextPrefix() { return BukuRow.localTextPrefix; }
        protected getService() { return BukuService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }

        protected getColumns(): Slick.Column[] {
            var columns = super.getColumns();


            Q.first(columns, x => x.field == fld.JudulBuku).format =
                ctx => `<a href="javascript:;" class="Buku-link">${Q.htmlEncode(ctx.value)}</a>`;

            Q.first(columns, x => x.field == fld.NamaRak).format =
                ctx => `<a href="javascript:;" class="Rak-link">${Q.htmlEncode(ctx.value)}</a>`;

            Q.first(columns, x => x.field == fld.NamaKategori).format =
                ctx => `<a href="javascript:;" class="Kategori-link">${Q.htmlEncode(ctx.value)}</a>`;

            columns.unshift({
                field: 'Delete Row',
                name: '',
                format: ctx => '<a class="inline-action delete-row" title="delete">' +
                    '<i class="fa fa-trash-o text-red"></i></a>',
                width: 24,
                minWidth: 24,
                maxWidth: 24
            });

            columns.splice(1, 0, {
                field: 'View Details',
                name: '',
                format: ctx => `<a class="inline-action view-details" title="Detail">
                        <i class="fa fa-search"></i></a>`,
                width: 24,
                minWidth: 24,
                maxWidth: 24
            });

            return columns;
        }

        protected onClick(e: JQueryEventObject, row: number, cell: number): void {

            // let base grid handle clicks for its edit links
            super.onClick(e, row, cell);

            // if base grid already handled, we shouldn"t handle it again
            if (e.isDefaultPrevented()) {
                return;
            }

            // get reference to current item
            var item = this.itemAt(row);

            // get reference to clicked element
            var target = $(e.target);

            if (target.hasClass("Buku-link")) {
                e.preventDefault();

                let message = Q.format(
                    "<p>Anda menekan data buku</p>" +
                    "<p>Yes Untuk membuka form buku</p>" +
                    "<p>No untuk menutup dialog</p>",
                    Q.htmlEncode(item.JudulBuku));

                Q.confirm(message, () => {
                    // CustomerDialog doesn't use CustomerID but ID (identity)
                    // so need to find customer to get its actual ID
                    var buku = Q.first(Perpustakaan.BukuRow.getLookup().items,
                        x => x.JudulBuku == item.JudulBuku);

                    new Perpustakaan.BukuDialog().loadByIdAndOpenDialog(buku.Id);
                },
                    {
                        htmlEncode: false,
                        onNo: () => {
                            Q.notifyInfo("Anda menekan tombol no");
                        }
                    });
            }
            else if (target.hasClass("Rak-link")) {
                e.preventDefault();

                Q.notifySuccess("Anda Memfilter Data " + item.NamaRak);
                var rakFilter = this.findQuickFilter(Serenity.LookupEditor,
                    Perpustakaan.BukuRow.Fields.IdRak);
                rakFilter.value = item.IdRak.toString();
                this.refresh();
            }
            else if (target.hasClass("Kategori-link")) {
                e.preventDefault();

                Q.notifySuccess("Anda Memfilter Data " + item.NamaKategori);
                var kategoriFilter = this.findQuickFilter(Serenity.LookupEditor,
                    Perpustakaan.BukuRow.Fields.IdKategori);
                kategoriFilter.value = item.IdKategori.toString();
                this.refresh();
            }

            if (target.parent().hasClass('inline-action'))
                target = target.parent();

            if (target.hasClass('inline-action')) {
                e.preventDefault();

                if (target.hasClass('delete-row')) {
                    Q.confirm('Delete record?', () => {
                        Perpustakaan.BukuService.Delete({
                            EntityId: item.Id,
                        }, response => {
                            this.refresh();
                        });
                    });
                }
                else if (target.hasClass('view-details')) {
                    this.editItem(item.Id);
                }
            }
        }

        protected getQuickSearchFields(): Serenity.QuickSearchField[] {
            const txt = (s) =>
                Q.text(`Db.${BukuRow.localTextPrefix}.${s}`).toLowerCase();

            return [
                { name: "", title: "all" },
                { name: fld.Penerbit, title: txt(fld.Penerbit) },
                { name: fld.Pengarang, title: txt(fld.Pengarang) },
                { name: fld.DeskripsiBuku, title: txt(fld.DeskripsiBuku) },
                { name: fld.TahunBuku, title: txt(fld.TahunBuku) }
            ];
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
    }
}