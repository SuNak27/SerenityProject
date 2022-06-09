using Serenity.Data;
using Serenity.Navigation;
using System;
using System.Collections.Generic;

namespace SerenPro
{
    public class PeminjamanPengembalianNavigation : INavigationItemSource
    {
        public PeminjamanPengembalianNavigation(ISqlConnections sqlConnections)
        {
            SqlConnections = sqlConnections ??
                throw new ArgumentNullException(nameof(sqlConnections));
        }

        public ISqlConnections SqlConnections { get; }

        public List<NavigationItemAttribute> GetItems()
        {
            var items = new List<NavigationItemAttribute>
            {
                new NavigationMenuAttribute(3000, "Transaksi", "fa-shopping-cart")
            };

            using (var connection = SqlConnections.NewByKey("MasterData"))
            {
                items.Add(new NavigationLinkAttribute(3100,
                    path: "Transaksi/Peminjaman ",
                    url: "~/Perpustakaan/Peminjaman?kategori=" + 1,
                    permission: "Administration:General",
                    icon: "fa-download"));

            }
            items.Add(new NavigationLinkAttribute(3200,
                       path: "Transaksi/Pengembalian ",
                       url: "~/Perpustakaan/Pengembalian?kategori=" + 2,
                        permission: "Administration:General",
                       icon: "fa-upload"));

            return items;
        }
    }
}
