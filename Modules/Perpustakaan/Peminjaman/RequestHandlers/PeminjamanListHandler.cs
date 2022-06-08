using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<SerenPro.Perpustakaan.PeminjamanRow>;
using MyRow = SerenPro.Perpustakaan.PeminjamanRow;

namespace SerenPro.Perpustakaan
{
    public interface IPeminjamanListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class PeminjamanListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IPeminjamanListHandler
    {
        public PeminjamanListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}