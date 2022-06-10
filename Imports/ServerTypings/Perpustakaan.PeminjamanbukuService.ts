namespace SerenPro.Perpustakaan {
    export namespace PeminjamanbukuService {
        export const baseUrl = 'Perpustakaan/Peminjamanbuku';

        export declare function Create(request: Serenity.SaveRequest<PeminjamanbukuRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Update(request: Serenity.SaveRequest<PeminjamanbukuRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<PeminjamanbukuRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<PeminjamanbukuRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;

        export declare const enum Methods {
            Create = "Perpustakaan/Peminjamanbuku/Create",
            Update = "Perpustakaan/Peminjamanbuku/Update",
            Delete = "Perpustakaan/Peminjamanbuku/Delete",
            Retrieve = "Perpustakaan/Peminjamanbuku/Retrieve",
            List = "Perpustakaan/Peminjamanbuku/List"
        }

        [
            'Create', 
            'Update', 
            'Delete', 
            'Retrieve', 
            'List'
        ].forEach(x => {
            (<any>PeminjamanbukuService)[x] = function (r, s, o) {
                return Q.serviceRequest(baseUrl + '/' + x, r, s, o);
            };
        });
    }
}
