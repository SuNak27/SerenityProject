using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Reporting;
using SerenPro.Perpustakaan;
using System;
using System.Collections.Generic;

namespace SerenPro.Perpustakaan
{
    [Report("Perpustakaan.PeminjamanDetail")]
    [ReportDesign(MVC.Views.Perpustakaan.Peminjaman.PeminjamanDetailReport)]
    [RequiredPermission(Administration.PermissionKeys.Security)]
    public class PeminjamanDetailReport : IReport, ICustomizeHtmlToPdf
    {
        public PeminjamanDetailReport(ISqlConnections sqlConnections)
        {
            SqlConnections = sqlConnections ?? throw new ArgumentNullException(nameof(sqlConnections));
        }

        public int Id { get; set; }

        protected ISqlConnections SqlConnections { get; }

        public object GetData()
        {
            var data = new PeminjamanDetailReportData();

            using (var connection = SqlConnections.NewFor<PeminjamanRow>())
            {
                var o = PeminjamanRow.Fields;

                data.Order = connection.TryById<PeminjamanRow>(Id, q => q
                     .SelectTableFields()
                     .Select(o.KodePeminjaman)
                     .Select(o.Status)
                     .Select(o.Id)
                     .Select(o.DisplayName)
                     .Select(o.KodeAnggota)
                     .Select(o.TglPinjam)
                     .Select(o.TglKembali)) ?? new PeminjamanRow();

                var od = PeminjamanbukuRow.Fields;
                data.Details = connection.List<PeminjamanbukuRow>(q => q
                    .SelectTableFields()
                    .Select(od.IdBuku)
                    .Select(od.IdBukuJudulBuku)
                    .Where(od.IdPeminjaman == Id));
            }

            return data;
        }

        public void Customize(IHtmlToPdfOptions options)
        {
            // you may customize HTML to PDF converter (WKHTML) parameters here, e.g. 
            options.MarginsAll = "2cm";
        }
    }

    public class PeminjamanDetailReportData
    {
        public PeminjamanRow Order { get; set; }
        public List<PeminjamanbukuRow> Details { get; set; }
    }
}