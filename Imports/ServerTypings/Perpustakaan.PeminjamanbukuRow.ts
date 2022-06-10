namespace SerenPro.Perpustakaan {
    export interface PeminjamanbukuRow {
        Id?: number;
        IdPeminjaman?: number;
        IdBuku?: number;
        IdBukuJudulBuku?: string;
        IdBukuKodeBuku?: string;
        IdBukuGambarBuku?: string;
        IdBukuPenerbit?: string;
        IdBukuPengarang?: string;
        IdBukuDeskripsiBuku?: string;
    }

    export namespace PeminjamanbukuRow {
        export const idProperty = 'Id';
        export const localTextPrefix = 'Perpustakaan.Peminjamanbuku';
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
            Id = "Id",
            IdPeminjaman = "IdPeminjaman",
            IdBuku = "IdBuku",
            IdBukuJudulBuku = "IdBukuJudulBuku",
            IdBukuKodeBuku = "IdBukuKodeBuku",
            IdBukuGambarBuku = "IdBukuGambarBuku",
            IdBukuPenerbit = "IdBukuPenerbit",
            IdBukuPengarang = "IdBukuPengarang",
            IdBukuDeskripsiBuku = "IdBukuDeskripsiBuku"
        }
    }
}
