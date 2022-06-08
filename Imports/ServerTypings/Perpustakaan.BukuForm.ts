﻿namespace SerenPro.Perpustakaan {
    export interface BukuForm {
        KodeBuku: Serenity.StringEditor;
        IdKategori: Serenity.LookupEditor;
        IdRak: Serenity.LookupEditor;
        Gambar: Serenity.StringEditor;
        Isbn: Serenity.IntegerEditor;
        JudulBuku: Serenity.StringEditor;
        Penerbit: Serenity.StringEditor;
        Pengarang: Serenity.StringEditor;
        TahunBuku: Serenity.DateEditor;
        DeskripsiBuku: Serenity.StringEditor;
        Jumlah: Serenity.IntegerEditor;
        TanggalMasuk: Serenity.DateEditor;
    }

    export class BukuForm extends Serenity.PrefixedContext {
        static formKey = 'Perpustakaan.Buku';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!BukuForm.init)  {
                BukuForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.LookupEditor;
                var w2 = s.IntegerEditor;
                var w3 = s.DateEditor;

                Q.initFormType(BukuForm, [
                    'KodeBuku', w0,
                    'IdKategori', w1,
                    'IdRak', w1,
                    'Gambar', w0,
                    'Isbn', w2,
                    'JudulBuku', w0,
                    'Penerbit', w0,
                    'Pengarang', w0,
                    'TahunBuku', w3,
                    'DeskripsiBuku', w0,
                    'Jumlah', w2,
                    'TanggalMasuk', w3
                ]);
            }
        }
    }
}