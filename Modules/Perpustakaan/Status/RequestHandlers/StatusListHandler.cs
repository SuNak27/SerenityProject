using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<SerenPro.Perpustakaan.StatusRow>;
using MyRow = SerenPro.Perpustakaan.StatusRow;

namespace SerenPro.Perpustakaan
{
    public interface IStatusListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class StatusListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IStatusListHandler
    {
        public StatusListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}