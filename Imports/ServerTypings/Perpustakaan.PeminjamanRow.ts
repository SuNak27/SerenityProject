namespace SerenPro.Perpustakaan {
    export interface PeminjamanRow {
        Id?: number;
        KodePeminjaman?: string;
        IdUser?: number;
        BukuList?: number[];
        KodeAnggota?: string;
        Status?: Status;
        TglPinjam?: string;
        TglKembali?: string;
        Denda?: number;
    }

    export namespace PeminjamanRow {
        export const idProperty = 'Id';
        export const nameProperty = 'KodePeminjaman';
        export const localTextPrefix = 'Perpustakaan.Peminjaman';
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
            Id = "Id",
            KodePeminjaman = "KodePeminjaman",
            IdUser = "IdUser",
            BukuList = "BukuList",
            KodeAnggota = "KodeAnggota",
            Status = "Status",
            TglPinjam = "TglPinjam",
            TglKembali = "TglKembali",
            Denda = "Denda"
        }
    }
}
