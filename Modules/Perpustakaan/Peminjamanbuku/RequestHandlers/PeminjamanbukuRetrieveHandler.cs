using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<SerenPro.Perpustakaan.PeminjamanbukuRow>;
using MyRow = SerenPro.Perpustakaan.PeminjamanbukuRow;

namespace SerenPro.Perpustakaan
{
    public interface IPeminjamanbukuRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class PeminjamanbukuRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IPeminjamanbukuRetrieveHandler
    {
        public PeminjamanbukuRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}