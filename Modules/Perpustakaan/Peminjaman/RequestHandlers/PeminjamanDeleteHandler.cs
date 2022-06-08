using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = SerenPro.Perpustakaan.PeminjamanRow;

namespace SerenPro.Perpustakaan
{
    public interface IPeminjamanDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class PeminjamanDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IPeminjamanDeleteHandler
    {
        public PeminjamanDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}