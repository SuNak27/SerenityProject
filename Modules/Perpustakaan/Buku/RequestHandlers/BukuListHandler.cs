using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<SerenPro.Perpustakaan.BukuRow>;
using MyRow = SerenPro.Perpustakaan.BukuRow;

namespace SerenPro.Perpustakaan
{
    public interface IBukuListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class BukuListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IBukuListHandler
    {
        public BukuListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}