using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<SerenPro.Perpustakaan.StatusRow>;
using MyRow = SerenPro.Perpustakaan.StatusRow;

namespace SerenPro.Perpustakaan
{
    public interface IStatusRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class StatusRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IStatusRetrieveHandler
    {
        public StatusRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}