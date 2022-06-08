namespace SerenPro.Perpustakaan {
    export interface BukuRow {
        Id?: number;
        KodeBuku?: string;
        Gambar?: string;
        Isbn?: number;
        JudulBuku?: string;
        Penerbit?: string;
        Pengarang?: string;
        TahunBuku?: string;
        DeskripsiBuku?: string;
        Jumlah?: number;
        TanggalMasuk?: string;
        IdKategori?: number;
        NamaKategori?: string;
        IdRak?: number;
        NamaRak?: string;
    }

    export namespace BukuRow {
        export const idProperty = 'Id';
        export const nameProperty = 'JudulBuku';
        export const localTextPrefix = 'Perpustakaan.Buku';
        export const lookupKey = 'Perpustakaan.Buku';

        export function getLookup(): Q.Lookup<BukuRow> {
            return Q.getLookup<BukuRow>('Perpustakaan.Buku');
        }
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
            Id = "Id",
            KodeBuku = "KodeBuku",
            Gambar = "Gambar",
            Isbn = "Isbn",
            JudulBuku = "JudulBuku",
            Penerbit = "Penerbit",
            Pengarang = "Pengarang",
            TahunBuku = "TahunBuku",
            DeskripsiBuku = "DeskripsiBuku",
            Jumlah = "Jumlah",
            TanggalMasuk = "TanggalMasuk",
            IdKategori = "IdKategori",
            NamaKategori = "NamaKategori",
            IdRak = "IdRak",
            NamaRak = "NamaRak"
        }
    }
}
