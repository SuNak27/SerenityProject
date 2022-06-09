namespace SerenPro.Perpustakaan {
    export interface StatusRow {
        Id?: number;
        Status?: string;
    }

    export namespace StatusRow {
        export const idProperty = 'Id';
        export const nameProperty = 'Status';
        export const localTextPrefix = 'Perpustakaan.Status';
        export const lookupKey = 'Perpustakaan.Status';

        export function getLookup(): Q.Lookup<StatusRow> {
            return Q.getLookup<StatusRow>('Perpustakaan.Status');
        }
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
            Id = "Id",
            Status = "Status"
        }
    }
}
