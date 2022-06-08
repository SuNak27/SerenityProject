namespace SerenPro.Perpustakaan {
    export interface KategoriRow {
        Id?: number;
        Nama?: string;
    }

    export namespace KategoriRow {
        export const idProperty = 'Id';
        export const nameProperty = 'Nama';
        export const localTextPrefix = 'Perpustakaan.Kategori';
        export const lookupKey = 'Perpustakaan.Kategori';

        export function getLookup(): Q.Lookup<KategoriRow> {
            return Q.getLookup<KategoriRow>('Perpustakaan.Kategori');
        }
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
            Id = "Id",
            Nama = "Nama"
        }
    }
}
