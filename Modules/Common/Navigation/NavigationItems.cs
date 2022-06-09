using Serenity.Navigation;
using MyPages = SerenPro.Perpustakaan.Pages;

[assembly: NavigationLink(1000, "Dashboard", url: "~/", permission: "", icon: "fa-tachometer")]

[assembly: NavigationMenu(2000, "Perpustakaan", icon: "fa-database")]
[assembly: NavigationLink(2100, "Perpustakaan/Buku", typeof(MyPages.BukuController), icon: "fa-book")]
[assembly: NavigationLink(2200, "Perpustakaan/Kategori", typeof(MyPages.KategoriController), icon: "fa-list")]
[assembly: NavigationLink(2300, "Perpustakaan/Rak", typeof(MyPages.RakController), icon: "fa-list")]