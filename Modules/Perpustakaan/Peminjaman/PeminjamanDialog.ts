
namespace SerenPro.Perpustakaan {

    @Serenity.Decorators.registerClass()
    export class PeminjamanDialog extends Serenity.EntityDialog<PeminjamanRow, any> {
        protected getFormKey() { return PeminjamanForm.formKey; }
        protected getIdProperty() { return PeminjamanRow.idProperty; }
        protected getLocalTextPrefix() { return PeminjamanRow.localTextPrefix; }
        protected getNameProperty() { return PeminjamanRow.nameProperty; }
        protected getService() { return PeminjamanService.baseUrl; }
        protected getDeletePermission() { return PeminjamanRow.deletePermission; }
        protected getInsertPermission() { return PeminjamanRow.insertPermission; }
        protected getUpdatePermission() { return PeminjamanRow.updatePermission; }

        protected form = new PeminjamanForm(this.idPrefix);

        constructor() {
            super();

            this.form.KodePeminjaman.element.on('keyup', (e) => {
                // only auto number when a key between 'A' and 'Z' is pressed
                if (e.which >= 65 && e.which <= 90)
                    this.getNextNumber();
            });
        }

        protected afterLoadEntity() {
            super.afterLoadEntity();

            // fill next number in new record mode
            if (this.isNew())
                this.getNextNumber();
        }

        private getNextNumber() {

            var val = Q.trimToNull(this.form.KodePeminjaman.value);

            // we will only get next number when customer ID is empty or 1 character in length
            if (!val || val.length <= 1) {

                // if no customer ID yet (new record mode probably) use 'C' as a prefix
                var prefix = (val || 'P-').toUpperCase();

                // call our service, see CustomerEndpoint.cs and CustomerRepository.cs
                SerenPro.Perpustakaan.PeminjamanService.GetNextNumber({
                    Prefix: prefix,
                    Length: 5 // we want service to search for and return serials of 5 in length
                }, response => {
                    this.form.KodePeminjaman.value = response.Serial;

                    // this is to mark numerical part after prefix
                    (this.form.KodePeminjaman.element[0] as any).setSelectionRange(prefix.length, response.Serial.length);
                });
            }
        }
    }
}