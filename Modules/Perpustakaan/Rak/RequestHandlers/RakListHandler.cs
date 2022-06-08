using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<SerenPro.Perpustakaan.RakRow>;
using MyRow = SerenPro.Perpustakaan.RakRow;

namespace SerenPro.Perpustakaan
{
    public interface IRakListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class RakListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IRakListHandler
    {
        public RakListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}