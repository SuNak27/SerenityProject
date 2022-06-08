namespace SerenPro.Perpustakaan {
    export enum Status {
        Dipinjam = 1,
        Dikembalikan = 2
    }
    Serenity.Decorators.registerEnumType(Status, 'SerenPro.Perpustakaan.Status', 'Perpustakaan.Status');
}
