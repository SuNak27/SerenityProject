
namespace SerenPro.Perpustakaan {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.panel()
    @Serenity.Decorators.maximizable()
    export class BukuDialog extends Serenity.EntityDialog<BukuRow, any> {
        protected getFormKey() { return BukuForm.formKey; }
        protected getIdProperty() { return BukuRow.idProperty; }
        protected getLocalTextPrefix() { return BukuRow.localTextPrefix; }
        protected getNameProperty() { return BukuRow.nameProperty; }
        protected getService() { return BukuService.baseUrl; }
        protected getDeletePermission() { return BukuRow.deletePermission; }
        protected getInsertPermission() { return BukuRow.insertPermission; }
        protected getUpdatePermission() { return BukuRow.updatePermission; }

        protected form = new BukuForm(this.idPrefix);

        constructor() {
            super();

            this.form.KodeBuku.element.on('keyup', (e) => {
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

            var val = Q.trimToNull(this.form.KodeBuku.value);

            // we will only get next number when customer ID is empty or 1 character in length
            if (!val || val.length <= 1) {

                // if no customer ID yet (new record mode probably) use 'C' as a prefix
                var prefix = (val || 'B-').toUpperCase();

                // call our service, see CustomerEndpoint.cs and CustomerRepository.cs
                SerenPro.Perpustakaan.BukuService.GetNextNumber({
                    Prefix: prefix,
                    Length: 5 // we want service to search for and return serials of 5 in length
                }, response => {
                    this.form.KodeBuku.value = response.Serial;

                    // this is to mark numerical part after prefix
                    (this.form.KodeBuku.element[0] as any).setSelectionRange(prefix.length, response.Serial.length);
                });
            }
        }

        protected updateInterface() {
            super.updateInterface();
            this.cloneButton.toggle(this.isEditMode());
        }

        protected getCloningEntity() {
            var clone = super.getCloningEntity();
            var kodeClone = this.getNextNumberClone();
            clone.KodeBuku = kodeClone;
            clone.Gambar = null;
            return clone;
        }

        private getNextNumberClone(): string {

            var val = Q.trimToNull(this.form.KodeBuku.value);

            // we will only get next number when customer ID is empty or 1 character in length
            if (!val || val.length <= 1) {

                // if no customer ID yet (new record mode probably) use 'C' as a prefix
                var prefix = (val || 'B-').toUpperCase();

                // call our service, see CustomerEndpoint.cs and CustomerRepository.cs
                SerenPro.Perpustakaan.BukuService.GetNextNumber({
                    Prefix: "B-",
                    Length: 5 // we want service to search for and return serials of 5 in length
                }, response => {
                    this.form.KodeBuku.value = response.Serial;

                    return response.Serial;
                });
            } else {
                return "";
            }
        }
    }
}