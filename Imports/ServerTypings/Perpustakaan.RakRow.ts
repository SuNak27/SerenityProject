namespace SerenPro.Perpustakaan {
    export interface RakRow {
        Id?: number;
        Rak?: string;
    }

    export namespace RakRow {
        export const idProperty = 'Id';
        export const nameProperty = 'Rak';
        export const localTextPrefix = 'Perpustakaan.Rak';
        export const lookupKey = 'Perpustakaan.Rak';

        export function getLookup(): Q.Lookup<RakRow> {
            return Q.getLookup<RakRow>('Perpustakaan.Rak');
        }
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
            Id = "Id",
            Rak = "Rak"
        }
    }
}
