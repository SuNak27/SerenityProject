using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<SerenPro.Perpustakaan.BukuRow>;
using MyRow = SerenPro.Perpustakaan.BukuRow;

namespace SerenPro.Perpustakaan
{
    public interface IBukuRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class BukuRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IBukuRetrieveHandler
    {
        public BukuRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}