namespace SerenPro.Perpustakaan {
    export interface PeminjamanRow {
        Id?: number;
        KodePeminjaman?: string;
        IdUser?: number;
        KodeAnggota?: string;
        Username?: string;
        IdStatus?: number;
        Status?: string;
        TglPinjam?: string;
        TglKembali?: string;
        Denda?: number;
        BukuList?: PeminjamanbukuRow[];
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
            KodeAnggota = "KodeAnggota",
            Username = "Username",
            IdStatus = "IdStatus",
            Status = "Status",
            TglPinjam = "TglPinjam",
            TglKembali = "TglKembali",
            Denda = "Denda",
            BukuList = "BukuList"
        }
    }
}
