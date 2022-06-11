using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Reporting;
using Serenity.Demo.Northwind;
using System;
using System.Collections.Generic;

namespace SerenPro.Administration.Entities
{
    [Report("Administration.CetakKartu")]
    [ReportDesign(MVC.Views.Administration.User.CetakKartuDetailReport)]
    [RequiredPermission(PermissionKeys.Security)]
    public class CetakKartuDetailReport : IReport, ICustomizeHtmlToPdf
    {
        public CetakKartuDetailReport(ISqlConnections sqlConnections)
        {
            SqlConnections = sqlConnections ?? throw new ArgumentNullException(nameof(sqlConnections));
        }

        public int UserId { get; set; }

        protected ISqlConnections SqlConnections { get; }

        public object GetData()
        {
            var data = new CetakKartuDetailReportData();

            using (var connection = SqlConnections.NewFor<Entities.UserRow>())
            {
                var o = Entities.UserRow.Fields;

                data.Anggota = connection.TryById<Entities.UserRow>(UserId, q => q
                     .SelectTableFields()
                     .Select(o.KodeAnggota)
                     .Select(o.DisplayName)
                     .Select(o.JenisKelamin)
                     .Select(o.Alamat)
                     .Select(o.Telepon)
                     .Select(o.Whatsapp)
                     .Select(o.Email)
                     .Select(o.InsertDate)
                     .Select(o.UserImage)
                     .Select(o.TanggalLahir)) ?? new Entities.UserRow();
                     Console.WriteLine(o.KodeAnggota);
            }

            return data;
        }

        public void Customize(IHtmlToPdfOptions options)
        {
            // you may customize HTML to PDF converter (WKHTML) parameters here, e.g. 
            options.MarginsAll = "3cm";
        }
    }

    public class CetakKartuDetailReportData
    {
        public Entities.UserRow Anggota {get; set;}
    }
}