using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<SerenPro.Perpustakaan.PeminjamanbukuRow>;
using MyRow = SerenPro.Perpustakaan.PeminjamanbukuRow;

namespace SerenPro.Perpustakaan
{
    public interface IPeminjamanbukuListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class PeminjamanbukuListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IPeminjamanbukuListHandler
    {
        public PeminjamanbukuListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}