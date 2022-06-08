using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<SerenPro.Perpustakaan.PeminjamanRow>;
using MyRow = SerenPro.Perpustakaan.PeminjamanRow;

namespace SerenPro.Perpustakaan
{
    public interface IPeminjamanRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class PeminjamanRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IPeminjamanRetrieveHandler
    {
        public PeminjamanRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}